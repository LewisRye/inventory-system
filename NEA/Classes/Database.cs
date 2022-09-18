using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NEA
{
    internal class Database
    {
        /*
         *  Contents
         */

        //  -handles some operations involving databases

        /*
         *  Required Variables
         */

        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        /*
         *  Product Database
         */

        public void LoadDataFromProductDb(DataGridView DatabaseGrid)
        {
            var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database file

            try
            {
                databaseConnection.Open();

                var sda = new SqlDataAdapter(@"SELECT Product.ProductID AS 'ID', Product.ProductName AS 'Name', 
                    Category.CategoryName AS 'Category', Product.NumberInStock AS 'Stock', Product.SellingPrice AS 'Sell Price', 
                    Product.BuyingPrice AS 'Buy Price', Product.Discontinued AS 'Discontinued'  
                    FROM Product, Category 
                    WHERE Product.CategoryID = Category.CategoryID 
                    GROUP BY CategoryName, Product.ProductID, Product.ProductName, 
                    Product.NumberInStock, Product.SellingPrice, Product.BuyingPrice, Product.Discontinued;", databaseConnection);            // uses SQL query to read every piece of data in database

                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseGrid.DataSource = dt;
                databaseConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        public void SearchDataFromProductDb(DataGridView DatabaseGrid, string SearchBox)
        {
            var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database

            try
            {
                databaseConnection.Open();

                string searchQuery = @"SELECT Product.ProductID as 'ID', Product.ProductName as 'Name', 
                    Category.CategoryName as 'Category', Product.NumberInStock as 'Stock', Product.SellingPrice as 'Sell Price', 
                    Product.BuyingPrice as 'Buy Price', Product.Discontinued AS 'Discontinued' 
                    FROM Product INNER JOIN Category ON Product.CategoryID = Category.CategoryID 
                    WHERE Product.ProductName LIKE @search OR Category.CategoryName LIKE @search;"; // finds all products that relate to the user's search term

                var command = new SqlCommand(searchQuery, databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + SearchBox + "%");                     // this line prevents SQL injection
                var da = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                da.Fill(dt);
                DatabaseGrid.DataSource = dt;   // binds the data from the query to the GridView
                databaseConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        public void LoadNoStockFromProductDb(DataGridView DatabaseGrid, ComboBox DatabaseComboBox)
        {
            var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database file

            try
            {
                databaseConnection.Open();

                var da = new SqlDataAdapter($@"SELECT Product.ProductID as 'ID', Product.ProductName as 'Name', 
                    Category.CategoryName as 'Category', Product.NumberInStock as 'Stock', Product.SellingPrice as 'Sell Price', 
                    Product.BuyingPrice as 'Buy Price', Product.Discontinued AS 'Discontinued' 
                    FROM Product INNER JOIN Category on Product.CategoryID = Category.CategoryID 
                    WHERE NumberInStock < {Logon.NotificationStock} AND Discontinued = 'n'", databaseConnection);                               // uses SQL query to read every piece of data in database
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                DatabaseGrid.DataSource = dt;   // binds the data from the query to the DataGrid
                databaseConnection.Close();

                foreach (DataGridViewRow row in DatabaseGrid.Rows)
                {
                    DatabaseComboBox.Items.Add(row.Cells["Name"].Value.ToString()); // adds all out of stock items to the combo box
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        /*
         *  Order Database
         */

        public void LoadDataFromOrdersDb(DataGridView DatabaseGrid)
        {
            var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database file

            try
            {
                databaseConnection.Open();

                var sda = new SqlDataAdapter(@"SELECT CustomerOrderDetails.OrderID AS 'Order ID', Product.ProductName AS 'Product Name', 
                    Customer.CustomerFirstName AS 'First Name', Customer.CustomerLastName AS 'Last Name', 
                    CustomerOrderDetails.QuantityOrdered AS 'Quantity', CustomerOrders.OrderDate AS 'Date Ordered', 
                    SUM(CustomerOrderDetails.QuantityOrdered * (Product.SellingPrice-Product.BuyingPrice)) AS 'Profit (£)' 
                    FROM CustomerOrderDetails, Product, CustomerOrders, Customer 
                    WHERE CustomerOrderDetails.OrderID = CustomerOrders.OrderID 
                    AND Product.ProductID = CustomerOrderDetails.ProductID 
                    AND Customer.CustomerID = CustomerOrders.CustomerID 
                    GROUP BY CustomerOrderDetails.OrderID, Product.ProductName, Customer.CustomerFirstName, 
						Customer.CustomerLastName, CustomerOrderDetails.QuantityOrdered, CustomerOrders.OrderDate 
                    ORDER BY OrderDate ASC;", databaseConnection); // uses SQL query to read every piece of data in database

                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseGrid.DataSource = dt;
                databaseConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        public void SearchDataFromOrdersDb(DataGridView DatabaseGrid, string SearchBox)
        {
            var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database file

            try
            {
                databaseConnection.Open();

                string searchQuery = @"SELECT CustomerOrderDetails.OrderID AS 'Order ID', Product.ProductName AS 'Product Name', 
                    Customer.CustomerFirstName AS 'First Name', Customer.CustomerLastName AS 'Last Name', 
                    CustomerOrderDetails.QuantityOrdered AS 'Quantity', CustomerOrders.OrderDate AS 'Date Ordered', 
                    SUM(CustomerOrderDetails.QuantityOrdered * (Product.SellingPrice-Product.BuyingPrice)) AS 'Profit (£)' 
                    FROM CustomerOrderDetails, Product, CustomerOrders, Customer 
                    WHERE Product.ProductName LIKE @search AND CustomerOrderDetails.OrderID = CustomerOrders.OrderID 
                    AND Product.ProductID = CustomerOrderDetails.ProductID 
                    AND Customer.CustomerID = CustomerOrders.CustomerID 
                    GROUP BY CustomerOrderDetails.OrderID, Product.ProductName, Customer.CustomerFirstName, 
						Customer.CustomerLastName, CustomerOrderDetails.QuantityOrdered, CustomerOrders.OrderDate 
                    ORDER BY OrderDate ASC;"; // finds all products that relate to the user's search term

                var command = new SqlCommand(searchQuery, databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + SearchBox + "%");                     // this line prevents SQL injection
                var sda = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseGrid.DataSource = dt;
                databaseConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }
    }
}