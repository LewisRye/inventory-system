namespace Inventory.ProgramForms
{
    public partial class FormPurchase : Form
    {
        private readonly Classes.Basket _basket = new Classes.Basket();
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        private double _price = 0;
        private List<string> _nameOfItem = new List<string>();
        private List<double> _priceOfItem = new List<double>();
        private List<int> _quantityOfItem = new List<int>();

        public FormPurchase()
        {
            InitializeComponent();
            DeliveryDate.MinDate = DateTime.Today.AddDays(1);
            DeliveryDate.MaxDate = DateTime.Today.AddDays(60);                                                          // you can order to arrive in 2 months from the current day
            DeliveryDate.Value = DeliveryDate.MinDate;
            DeliveryDate.CustomFormat = "ddd, dd MMM yyy";                                                              // i changed this line as new year 2022 caused min date to be higher than max
            DeliveryDate.Format = DateTimePickerFormat.Custom;
            ListProducts.Items.Add("Select the item to order...");
            ListBasket.Items.Add("Select item to remove...");

            var databaseConnection = new MySqlConnection(_connStr);
            databaseConnection.Open();                                                                                  // connects to database and reads it

            using (databaseConnection)
            {
                var cmd = new MySqlCommand(@"SELECT Product_Name FROM Product 
                    WHERE Discontinued = 'n'", databaseConnection);                                                     // uses SQL query to read data
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListProducts.Items.Add(reader[0].ToString());                                              // populates the list from the SQL query
                }
            }
            ListProducts.SelectedIndex = 0;                                                                         // shows text 'select item to order'
            ListBasket.SelectedIndex = 0;
            databaseConnection.Close();
        }

        private void OrderProductList_SelectedIndexChanged(object Sender, EventArgs E)  // this function has no point going into a class
        {
            var databaseConnection = new MySqlConnection(_connStr);              // directs code to location of my database file

            databaseConnection.Open();
            string selectedProduct = ListProducts.GetItemText(ListProducts.SelectedItem);
            string priceCommand = "SELECT Buy_Price FROM Product WHERE Product_Name = '"
                            + selectedProduct + "';";                                   // SQL query to get the price of the selected database item
            var cmd = new MySqlCommand(priceCommand, databaseConnection);
            cmd.ExecuteNonQuery();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _price = Convert.ToDouble(reader[0]);
            }
            databaseConnection.Close();                                                 // closes database connection, no longer needed

            int quantity = Convert.ToInt32(QuantityRequired.Value);
            _price = Math.Round(Convert.ToDouble(_price * quantity), 2);                  // rounds the price to 2 decimal places

            TextTotalCost.Text = $"item cost: £{_price.ToString("0.00")}";
        }

        private void QuantityRequired_ValueChanged(object Sender, EventArgs E)          // this function has no point going into a class
        {
            var databaseConnection = new MySqlConnection(_connStr);              // directs code to location of my database file
            databaseConnection.Open();
            string selectedProduct = ListProducts.GetItemText(ListProducts.SelectedItem);
            string priceCommand = "SELECT Buy_Price FROM Product WHERE Product_Name = '"
                            + selectedProduct + "';";                                   // SQL query to get the price of the selected database item
            var cmd = new MySqlCommand(priceCommand, databaseConnection);
            cmd.ExecuteNonQuery();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _price = Convert.ToDouble(reader[0]);
            }

            int quantity = Convert.ToInt32(QuantityRequired.Value);
            _price = Math.Round(Convert.ToDouble(_price * quantity), 2);                  // rounds the price to 2 decimal places

            databaseConnection.Close();                                                 // closes database connection, no longer needed
            TextTotalCost.Text = $"item cost: £{_price.ToString("0.00")}";
        }

        private void ButtonAdd_Click(object Sender, EventArgs E)
        {
            if (ListProducts.SelectedIndex != 0 && QuantityRequired.Value != 0)
            {
                _nameOfItem.Add(ListProducts.GetItemText(ListProducts.SelectedItem));
                _priceOfItem.Add(Convert.ToDouble(_price));
                _quantityOfItem.Add(Convert.ToInt32(QuantityRequired.Value));

                ListBasket.Items.Add(ListProducts.GetItemText($"{ListProducts.SelectedItem}:({QuantityRequired.Value}x)"));

                double newPrice = _priceOfItem.Sum();

                ButtonViewBasket.Text = $"View Basket(£{newPrice.ToString("0.00")})";
            }
            else
            {
                MessageBox.Show("You must select a product and a quantity...", "Error");
            }
        }

        private void ButtonOrder_Click(object Sender, EventArgs E)
        {
            if (_nameOfItem.Count > 0)
            {
                _basket.CreateBasket(_nameOfItem, _priceOfItem, _quantityOfItem);

                new FormDashboard().Show();                                                                                  // go back to the main app
                this.Hide();
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            else
            {
                MessageBox.Show("Please add a quantity and/or an item to order...",
                    "Order Failed");
            }
        }

        private void ButtonViewBasket_Click(object Sender, EventArgs E)
        {
            int totalItemsInBasket = _nameOfItem.Count;
            string currentBasket = "";

            try
            {
                for (int i = 0; i < totalItemsInBasket; i++)
                {
                    currentBasket += $"({_quantityOfItem[i]}x) {_nameOfItem[i]}: £{_priceOfItem[i].ToString("0.00")}\n";
                }

                double totalPrice = _priceOfItem.Sum();
                MessageBox.Show($"{currentBasket}\n\nTotal basket price: £{totalPrice.ToString("0.00")}", "Basket");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ButtonRemove_Click(object Sender, EventArgs E)
        {
            if (ListBasket.SelectedIndex != 0)
            {
                string basketItemToBeRemoved = ListBasket.SelectedItem.ToString();
                string itemToBeRemoved = basketItemToBeRemoved.Substring(0, basketItemToBeRemoved.IndexOf(":"));
                int itemIndex = _nameOfItem.IndexOf(itemToBeRemoved);

                _nameOfItem.RemoveAt(itemIndex);
                _priceOfItem.RemoveAt(itemIndex);
                _quantityOfItem.RemoveAt(itemIndex);

                double newPrice = _priceOfItem.Sum();
                ButtonViewBasket.Text = $"View Basket (£{newPrice.ToString("0.00")})";
                ListBasket.Items.Remove(basketItemToBeRemoved);
                ListBasket.SelectedIndex = 0;

                MessageBox.Show($"'{itemToBeRemoved}' was removed from the basket.", "Item Removed");
            }
        }

        private void CloseButton_Click(object Sender, EventArgs E)
        {
            new FormDashboard().Show();                                                                                 // go back to the main app
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PurchaseForm_Load(object Sender, EventArgs E)
        {

        }
    }
}