using Inventory.Classes;

namespace Inventory.DataForms
{
    public partial class FormViewStock : Form
    {
        private readonly Database _database = new Database();
        private MySqlConnection _databaseConn = new MySqlConnection(Logon.ConnectionString);

        private List<Category> _allCategories = new List<Category>();
        private List<Product> _allProducts = new List<Product>();
        private List<Product> _newProducts = new List<Product>();

        public FormViewStock()
        {
            InitializeComponent();

            ComboBoxType.Items.Add("Select the category");
            ComboBoxSort.Items.Add("Select the sort");
            ComboBoxSort.Items.Add("Price (low to high)");
            ComboBoxSort.Items.Add("Price (high to low)");
            ComboBoxSort.Items.Add("Product Name (A to Z)");
            ComboBoxSort.Items.Add("Product Name (Z to A)");
            ComboBoxSort.Items.Add("Stock (low to high)");
            ComboBoxSort.Items.Add("Stock (high to low)");

            DatabaseGrid.Columns.Add("0", "ID");
            DatabaseGrid.Columns.Add("1", "Name");
            DatabaseGrid.Columns.Add("2", "Category");
            DatabaseGrid.Columns.Add("3", "Stock");
            DatabaseGrid.Columns.Add("4", "Buy Price");
            DatabaseGrid.Columns.Add("5", "Discontinued");

            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;

            _allCategories = _database.GetCategories();
            _allProducts = _database.GetProducts();
        }

        private void FormViewStock_Load(object sender, EventArgs e)
        {
            foreach (Category c in _allCategories)
            {
                ComboBoxType.Items.Add(c.GetName());
            }

            foreach (Product p in _allProducts)
            {
                DatabaseGrid.Rows.Add(p.GetId(), p.GetName(), p.GetCategory(), p.GetStock(), "£" + p.GetPrice(), p.GetDiscontinued());
            }

            TextWelcome.Text = $"welcome, {Logon.CurrentUser}!";
        }

        private void ButtonApplyCategoryFilter_Click(object sender, EventArgs e)
        {
            if (ComboBoxType.SelectedIndex != 0)
            {
                List<Product> newProducts = new List<Product>();
                DatabaseGrid.Rows.Clear();
                _databaseConn.Open();

                var command = new MySqlCommand(@"SELECT Product.Product_ID as 'ID', Product.Product_Name as 'Name', 
                    Category.Category_Name as 'Category', Product.Number_In_Stock as 'Stock', Product.Buy_Price as 'Buy Price', 
                    Product.Discontinued AS 'Discontinued' 
                    FROM Product INNER JOIN Category ON Product.Category_ID = Category.Category_ID 
                    WHERE Product.Category_ID = @category;", _databaseConn);
                command.Parameters.AddWithValue("@category", ComboBoxType.SelectedIndex);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newProducts.Add(new Classes.Product(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToDecimal(reader.GetString(4)), Convert.ToChar(reader.GetString(5))));
                }
                _databaseConn.Close();

                foreach (Product p in newProducts)
                {
                    DatabaseGrid.Rows.Add(p.GetId(), p.GetName(), p.GetCategory(), p.GetStock(), "£" + p.GetPrice(), p.GetDiscontinued());
                }
            }
            else
            {
                MessageBox.Show("You must apply a filter first.", "Error");
            }
        }

        private void ButtonApplySort_Click(object sender, EventArgs e)
        {
            switch (ComboBoxSort.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("You must apply a sort first.", "Error");
                    break;
                case 1:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["5"], ListSortDirection.Ascending);
                    break;
                case 2:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["5"], ListSortDirection.Descending);
                    break;
                case 3:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["1"], ListSortDirection.Ascending);
                    break;
                case 4:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["1"], ListSortDirection.Descending);
                    break;
                case 5:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["3"], ListSortDirection.Ascending);
                    break;
                case 6:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["3"], ListSortDirection.Descending);
                    break;
            }
        }

        private void ButtonResetSort_Click(object sender, EventArgs e)
        {
            DatabaseGrid.Rows.Clear();
            foreach (Product p in _allProducts)
            {
                DatabaseGrid.Rows.Add(p.GetId(), p.GetName(), p.GetCategory(), p.GetStock(), "£" + p.GetPrice(), p.GetDiscontinued());
            }

            SearchBox.Text = "";
            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DatabaseGrid.Rows.Clear();
            _newProducts.Clear();

            if (SearchBox.Text == "")
            {
                foreach (Product p in _allProducts)
                {
                    DatabaseGrid.Rows.Add(p.GetId(), p.GetName(), p.GetCategory(), p.GetStock(), "£" + p.GetPrice(), p.GetDiscontinued());
                }
            }
            else
            {
                _newProducts = _database.GetProducts(SearchBox.Text);
                foreach (Product p in _newProducts)
                {
                    DatabaseGrid.Rows.Add(p.GetId(), p.GetName(), p.GetCategory(), p.GetStock(), "£" + p.GetPrice(), p.GetDiscontinued());
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonDiscontinue_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonChangePrice_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormDashboard().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
