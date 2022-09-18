using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NEA
{
    public partial class FormViewStock : Form
    {
        private readonly Database _database = new Database();
        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public FormViewStock()
        {
            InitializeComponent();
            var databaseConn = new SqlConnection(_connStr);

            ComboBoxType.Items.Add("Select the category");
            ComboBoxSort.Items.Add("Select the sort");
            ComboBoxSort.Items.Add("Price (low to high)"); // index 1
            ComboBoxSort.Items.Add("Price (high to low)");
            ComboBoxSort.Items.Add("Product Name (A to Z)");
            ComboBoxSort.Items.Add("Product Name (Z to A)");
            ComboBoxSort.Items.Add("Stock (low to high)");
            ComboBoxSort.Items.Add("Stock (high to low)"); // index 6
            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;
            databaseConn.Open();                                                        // connects to database and reads it

            var cmd = new SqlCommand("SELECT CategoryName FROM Category", databaseConn); // uses SQL query to read data
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ComboBoxType.Items.Add(dr["CategoryName"].ToString());               // populates the list from the SQL query
            }
            databaseConn.Close();
        }

        private void ViewStockForm_Load(object Sender, EventArgs E)
        {
            _database.LoadDataFromProductDb(DatabaseGrid); // opens the database
            TextWelcome.Text = $"welcome, {Logon.CurrentUser}!";
        }

        private void ButtonApplyCategoryFilter_Click(object Sender, EventArgs E)
        {
            var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database file

            if (ComboBoxType.SelectedIndex != 0)
            {
                databaseConnection.Open();

                string searchQuery = @"SELECT Product.ProductID as 'ID', Product.ProductName as 'Name', 
                    Category.CategoryName as 'Category', Product.NumberInStock as 'Stock', Product.SellingPrice as 'Sell Price', Product.BuyingPrice as 'Buy Price', 
                    Product.Discontinued AS 'Discontinued' 
                    FROM Product INNER JOIN Category ON Product.CategoryID = Category.CategoryID 
                    WHERE Product.CategoryID = @category;";

                var command = new SqlCommand(searchQuery, databaseConnection);
                command.Parameters.AddWithValue("@category", ComboBoxType.SelectedIndex);                     // this line prevents SQL injection

                var da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DatabaseGrid.DataSource = dt;
                databaseConnection.Close();
            }
            else
            {
                MessageBox.Show("You must apply a filter first...", "Error");
            }
        }

        private void ButtonApplyFilter_Click(object Sender, EventArgs E)
        {
            if (MaxPrice.Value > MinPrice.Value)
            {
                var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database file

                databaseConnection.Open();

                string searchQuery = @"SELECT Product.ProductID as 'ID', Product.ProductName as 'Name', 
                    Category.CategoryName as 'Category', Product.NumberInStock as 'Stock', Product.SellingPrice as 'Sell Price', 
                    Product.BuyingPrice as 'Buy Price', Product.Discontinued AS 'Discontinued' 
                    FROM Product INNER JOIN Category ON Product.CategoryID = Category.CategoryID 
                    WHERE Product.SellingPrice BETWEEN @lowprice AND @topprice;";

                var command = new SqlCommand(searchQuery, databaseConnection);
                command.Parameters.AddWithValue("@lowprice", MinPrice.Value);                     // this line prevents SQL injection
                command.Parameters.AddWithValue("@topprice", MaxPrice.Value);                     // this line prevents SQL injection

                var da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DatabaseGrid.DataSource = dt;
                databaseConnection.Close();
            }
            else
            {
                MessageBox.Show("Not all fields have been entered..", "Error");
            }
        }

        private void ButtonApplySort_Click(object Sender, EventArgs E)
        {
            switch (ComboBoxSort.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("You must apply a sort first.", "Error");
                    break;
                case 1:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["Sell Price"], ListSortDirection.Ascending);
                    break;
                case 2:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["Sell Price"], ListSortDirection.Descending);
                    break;
                case 3:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["Name"], ListSortDirection.Ascending);
                    break;
                case 4:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["Name"], ListSortDirection.Descending);
                    break;
                case 5:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["Stock"], ListSortDirection.Ascending);
                    break;
                case 6:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["Stock"], ListSortDirection.Descending);
                    break;
            }
        }

        private void ButtonResetSort_Click(object Sender, EventArgs E)
        {
            _database.LoadDataFromProductDb(DatabaseGrid); // opens the database
            MinPrice.Value = 0;
            MaxPrice.Value = 0;
            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;
        }

        private void SearchBox_KeyDown(object Sender, KeyEventArgs E)
        {
            if (E.KeyCode == Keys.Enter)
            {
                E.SuppressKeyPress = true;
                _database.SearchDataFromProductDb(DatabaseGrid, SearchBox.Text);
                E.Handled = true;
            }
        }

        private void SearchBox_TextChanged(object Sender, EventArgs E)
        {
            _database.SearchDataFromProductDb(DatabaseGrid, SearchBox.Text);
        }

        private void ButtonClear_Click(object Sender, EventArgs E)
        {
            SearchBox.Clear();
        }

        private void ButtonAddCategory_Click(object Sender, EventArgs E)
        {
            new FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonAddProduct_Click(object Sender, EventArgs E)
        {
            new FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonDiscontinue_Click(object Sender, EventArgs E)
        {
            new FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonChangePrice_Click(object sender, EventArgs e)
        {
            new FormAlter().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonClose_Click(object Sender, EventArgs E)
        {
            new FormDashboard().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
