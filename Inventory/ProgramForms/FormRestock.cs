namespace Inventory.ProgramForms
{
    public partial class FormRestock : Form
    {
        private readonly Basket _basket = new Basket();
        private readonly Database _database = new Database();
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        private double _price = 0;
        private List<string> _nameOfItem = new List<string>();
        private List<double> _priceOfItem = new List<double>();
        private List<int> _quantityOfItem = new List<int>();

        public FormRestock()
        {
            InitializeComponent();
            ListProducts.Items.Add("Select the items to add to the basket...");
            ListProducts.SelectedIndex = 0;
            ListBasket.Items.Add("Select the items to remove from the basket...");
            ListBasket.SelectedIndex = 0;
        }

        private void RestockForm_Load(object Sender, EventArgs E)
        {
            _database.LoadNoStockFromProductDb(DatabaseGrid, ListProducts);
            TextWelcome.Text = $"welcome, {Logon.CurrentUser}!";
        }

        private void ListProducts_SelectedIndexChanged(object Sender, EventArgs E)
        {
            if (QuantityRequired.Value != 0)
            {
                double temporaryPrice = 0;

                var databaseConnection = new MySqlConnection(_connStr);              // directs code to location of my database file
                databaseConnection.Open();

                string selectedProduct = ListProducts.GetItemText(ListProducts.SelectedItem);
                string priceCommand = "SELECT Buy_Price FROM Product WHERE Product_Name = '"
                                      + selectedProduct + "';";                              // SQL query to get the price of the selected database item

                var cmd = new MySqlCommand(priceCommand, databaseConnection);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temporaryPrice = Convert.ToDouble(reader[0]);
                }

                int quantity = Convert.ToInt32(QuantityRequired.Value);
                temporaryPrice = Math.Round(Convert.ToDouble(temporaryPrice * quantity), 2);// rounds the price to 2 decimal places

                databaseConnection.Close();                                                 // closes database connection, no longer needed

                _price = temporaryPrice;
                TextPrice.Text = $"£{_price.ToString("0.00")}";
            }
        }

        private void QuantityRequired_ValueChanged(object Sender, EventArgs E)
        {
            if (ListProducts.SelectedIndex != 0)
            {
                double temporaryPrice = 0;

                var databaseConnection = new MySqlConnection(_connStr);              // directs code to location of my database file
                databaseConnection.Open();

                string selectedProduct = ListProducts.GetItemText(ListProducts.SelectedItem);
                string priceCommand = "SELECT Buy_Price FROM Product WHERE Product_Name = '"
                                      + selectedProduct + "';";                              // SQL query to get the price of the selected database item

                var cmd = new MySqlCommand(priceCommand, databaseConnection);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temporaryPrice = Convert.ToDouble(reader[0]);
                }

                int quantity = Convert.ToInt32(QuantityRequired.Value);
                temporaryPrice = Math.Round(Convert.ToDouble(temporaryPrice * quantity), 2);// rounds the price to 2 decimal places

                databaseConnection.Close();                                                 // closes database connection, no longer needed

                _price = temporaryPrice;
                TextPrice.Text = $"£{_price.ToString("0.00")}";
            }
        }

        private void ButtonAddToOrder_Click(object Sender, EventArgs E)
        {
            if (Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else if (ListProducts.SelectedIndex == 0 || QuantityRequired.Value == 0)
            {
                MessageBox.Show("You need to specify an item and amount to purchase", "Error");
            }

            else
            {
                _nameOfItem.Add(ListProducts.GetItemText(ListProducts.SelectedItem));
                _priceOfItem.Add(_price);
                _quantityOfItem.Add(Convert.ToInt32(QuantityRequired.Value));

                ListBasket.Items.Add(ListProducts.GetItemText($"{ListProducts.SelectedItem}:({QuantityRequired.Value}x)"));

                double newPrice = _priceOfItem.Sum();

                ButtonViewBasket.Text = $"View Basket(£{newPrice.ToString("0.00")})";
                ButtonPurchase.Text = $"Complete Order (£{newPrice.ToString("0.00")})";

                double newTotal = _priceOfItem.Sum();
                ButtonViewBasket.Text = $"View Basket (£{newTotal.ToString("0.00")})";
                ButtonPurchase.Text = $"Complete Order (£{newTotal.ToString("0.00")})";
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

        private void ButtonRemoveBasket_Click(object Sender, EventArgs E)
        {
            if (ListBasket.SelectedIndex != 0)
            {
                string basketItemToBeRemoved = ListBasket.SelectedItem.ToString();
                string itemToBeRemoved = basketItemToBeRemoved.Substring(0, basketItemToBeRemoved.IndexOf(":"));
                int itemIndex = _nameOfItem.IndexOf(itemToBeRemoved);

                _nameOfItem.RemoveAt(itemIndex);
                _priceOfItem.RemoveAt(itemIndex);
                _quantityOfItem.RemoveAt(itemIndex);

                double newTotal = _priceOfItem.Sum();
                ButtonViewBasket.Text = $"View Basket (£{newTotal.ToString("0.00")})";
                ButtonPurchase.Text = $"Complete Order (£{newTotal.ToString("0.00")})";
                ListBasket.Items.Remove(basketItemToBeRemoved);
                ListBasket.SelectedIndex = 0;

                MessageBox.Show($"'{itemToBeRemoved}' was removed from the basket.", "Item Removed");
            }
        }

        private void ButtonPurchase_Click(object Sender, EventArgs E)
        {
            if (Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else if (ButtonPurchase.Text == "Complete Order (£0)" || ButtonPurchase.Text == "Complete Order (£0.00)")
            {
                MessageBox.Show("Please add a quantity and/or an item to order...",
                    "Order Failed");
            }

            else
            {
                _basket.CreateBasket(_nameOfItem, _priceOfItem, _quantityOfItem);

                foreach (Form var in Application.OpenForms)
                {
                    var.WindowState = FormWindowState.Normal;
                }
                this.Hide();
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void ButtonClose_Click(object Sender, EventArgs E)
        {
            this.Hide();
            foreach (Form var in Application.OpenForms)
            {
                var.WindowState = FormWindowState.Normal;
            }
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}