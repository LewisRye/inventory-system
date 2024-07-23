namespace Inventory.Classes
{
    internal class Database
    {
        /*
        private MySqlConnection _databaseConnection = new MySqlConnection(Logon.ConnectionString); // directs code to location of my database file

        private List<Classes.Product> _products = new List<Classes.Product>();
        private List<Classes.Category> _categories = new List<Classes.Category>();
        private List<Classes.Order> _orders = new List<Classes.Order>();

        private List<Classes.Product> _newProductList = new List<Classes.Product>();
        private List<Classes.Order> _newOrderList = new List<Classes.Order>();

        public List<Classes.Product> GetProducts()
        {
            LoadProducts();
            return _products;
        }

        public List<Classes.Product> GetProducts(String search)
        {
            LoadProducts(search);
            return _newProductList;
        }

        public List<Classes.Category> GetCategories()
        {
            LoadCategories();
            return _categories;
        }

        public List<Classes.Order> GetOrders()
        {
            LoadOrders();
            return _orders;
        }

        public List<Classes.Order> GetOrders(String search)
        {
            LoadOrders(search);
            return _newOrderList;
        }

        private void LoadProducts()
        {
            try
            {
                _newProductList.Clear();
                _databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT Product.Product_ID, Product.Product_Name, 
                    Category.Category_Name, Product.number_in_stock, Product.Buy_Price, Product.Discontinued  
                    FROM Product, Category 
                    WHERE Product.Category_ID = Category.Category_ID 
                    GROUP BY Category.Category_Name, Product.Product_ID, Product.Product_Name, 
                    Product.number_in_stock, Product.Buy_Price, Product.Discontinued;", _databaseConnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _products.Add(new Classes.Product(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToDecimal(reader.GetString(4)), Convert.ToChar(reader.GetString(5))));
                }
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        private void LoadProducts(string search)
        {
            try
            {
                _databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT Product.Product_ID, Product.Product_Name, 
                    Category.Category_Name, Product.number_in_stock, Product.Buy_Price, Product.Discontinued  
                    FROM Product INNER JOIN Category ON Product.Category_ID = Category.Category_ID 
                    WHERE Product.Product_Name LIKE @search OR Category.Category_Name LIKE @search;", _databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + search + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _newProductList.Add(new Classes.Product(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToDecimal(reader.GetString(4)), Convert.ToChar(reader.GetString(5))));
                }
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            try
            {
                _databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT category_id, category_name FROM Category", _databaseConnection); // uses SQL query to read data
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _categories.Add(new Classes.Category(Convert.ToInt32(reader.GetString(0)), reader.GetString(1)));
                }
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        private void LoadOrders()
        {
            try
            {
                _databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT CustomerOrderDetails.Order_ID AS 'Order ID', Product.Product_Name AS 'Product Name', 
                    Customer.Customer_FName AS 'First Name', Customer.Customer_LName AS 'Last Name', CustomerOrderDetails.Quantity_Ordered AS 'Quantity', 
                    CustomerOrders.Order_Date AS 'Date Ordered', ROUND(Product.Buy_Price * 1.2, 2) AS 'Order Price' FROM Product, CustomerOrders, CustomerOrderDetails, Customer 
                    WHERE CustomerOrderDetails.Order_ID = CustomerOrders.Order_ID AND Product.Product_ID = CustomerOrderDetails.Product_ID AND Customer.Customer_ID = CustomerOrders.Customer_ID 
                    GROUP BY CustomerOrderDetails.Order_ID, Product.Product_Name, Customer.Customer_FName, Customer.Customer_LName, CustomerOrderDetails.Quantity_Ordered, CustomerOrders.Order_Date, Product.Buy_Price 
                    ORDER BY Order_Date ASC;", _databaseConnection); // uses SQL query to read data
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _orders.Add(new Order(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), Convert.ToInt32(reader.GetString(4)), Convert.ToDateTime(reader.GetString(5)), Convert.ToDecimal(reader.GetString(6))));
                }
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        private void LoadOrders(string search)
        {
            try
            {
                _databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT CustomerOrderDetails.Order_ID AS 'Order ID', Product.Product_Name AS 'Product Name', 
                    Customer.Customer_FName AS 'First Name', Customer.Customer_LName AS 'Last Name', CustomerOrderDetails.Quantity_Ordered AS 'Quantity', 
                    CustomerOrders.Order_Date AS 'Date Ordered', ROUND(Product.Buy_Price * 1.2, 2) AS 'Order Price' FROM Product, CustomerOrders, CustomerOrderDetails, Customer 
                    WHERE (Customer.Customer_FName LIKE @search OR Customer.Customer_LName LIKE @search OR Product.Product_Name LIKE @search) AND CustomerOrderDetails.Order_ID = CustomerOrders.Order_ID AND Product.Product_ID = CustomerOrderDetails.Product_ID AND Customer.Customer_ID = CustomerOrders.Customer_ID 
                    GROUP BY CustomerOrderDetails.Order_ID, Product.Product_Name, Customer.Customer_FName, Customer.Customer_LName, CustomerOrderDetails.Quantity_Ordered, CustomerOrders.Order_Date, Product.Buy_Price 
                    ORDER BY Order_Date ASC;", _databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + search + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _newOrderList.Add(new Classes.Order(Convert.ToInt32(reader.GetString(0)), reader.GetString(1).ToString(), reader.GetString(2), reader.GetString(3), Convert.ToInt32(reader.GetString(4)), Convert.ToDateTime(reader.GetString(5)), Convert.ToDecimal(reader.GetString(6))));
                }
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        public List<Classes.Product> SearchDataFromProductDb(string searchBox)
        {
            List<Classes.Product> products = new List<Classes.Product>();
            try
            {
                _databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT Product.Product_ID, Product.Product_Name, 
                    Category.Category_Name, Product.number_in_stock, Product.Buy_Price, Product.Discontinued  
                    FROM Product INNER JOIN Category ON Product.Category_ID = Category.Category_ID 
                    WHERE Product.Product_Name LIKE @search OR Category.Category_Name LIKE @search;", _databaseConnection);
                command.Parameters.AddWithValue("@search", searchBox);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Classes.Product(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToDecimal(reader.GetString(4)), Convert.ToChar(reader.GetString(5))));
                }
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            return products;
        }

        public void LoadNoStockFromProductDb(DataGridView databaseGrid, ComboBox databaseComboBox)
        {
            try
            {
                _databaseConnection.Open();
                databaseGrid.Rows.Clear();
                var da = new MySqlDataAdapter($@"SELECT Product.Product_ID AS 'ID', Product.Product_Name AS 'Name', 
                    Category.Category_Name AS 'Category', Product.Number_In_Stock AS 'Stock', Product.Buy_Price AS 'Buy Price', 
                    Product.Discontinued AS 'Discontinued' 
                    FROM Product INNER JOIN Category on Product.Category_ID = Category.Category_ID 
                    WHERE stock < {Logon.NotificationStock} AND Discontinued = 'n'", _databaseConnection);                               // uses SQL query to read every piece of data in database

                DataTable dt = new DataTable();
                da.Fill(dt);
                databaseGrid.DataSource = dt;   // binds the data from the query to the DataGrid
                _databaseConnection.Close();

                foreach (DataGridViewRow row in databaseGrid.Rows)
                {
                    databaseComboBox.Items.Add(row.Cells["Name"].Value.ToString()); // adds all out of stock items to the combo box
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        /*
         *  Order Database
         */

        /*
        public void LoadDataFromOrdersDb(DataGridView databaseGrid)
        {
            try
            {
                _databaseConnection.Open();
                databaseGrid.Rows.Clear();
                var sda = new MySqlDataAdapter(@"SELECT CustomerOrderDetails.Order_ID AS 'Order ID', Product.Product_Name AS 'Product Name', 
                    Customer.Customer_fName AS 'First Name', Customer.Customer_lName AS 'Last Name', 
                    CustomerOrderDetails.Quantity_Ordered AS 'Quantity', CustomerOrders.Order_Date AS 'Date Ordered', 
                    SUM(CustomerOrderDetails.Quantity_Ordered * (Product.Sell_Price-Product.Buy_Price)) AS 'Profit (£)' 
                    FROM CustomerOrderDetails, Product, CustomerOrders, Customer 
                    WHERE CustomerOrderDetails.Order_ID = CustomerOrders.Order_ID 
                    AND Product.Product_ID = CustomerOrderDetails.Product_ID 
                    AND Customer.Customer_ID = CustomerOrders.Customer_ID 
                    GROUP BY CustomerOrderDetails.Order_ID, Product.Product_Name, Customer.Customer_fName, 
						Customer.Customer_lName, CustomerOrderDetails.Quantity_Ordered, CustomerOrders.Order_Date 
                    ORDER BY Order_Date ASC;", _databaseConnection); // uses SQL query to read every piece of data in database

                DataTable dt = new DataTable();
                sda.Fill(dt);
                databaseGrid.DataSource = dt;
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        public void SearchDataFromOrdersDb(DataGridView databaseGrid, string searchBox)
        {
            try
            {
                _databaseConnection.Open();
                databaseGrid.Rows.Clear();
                string searchQuery = @"SELECT CustomerOrderDetails.Order_ID AS 'Order ID', Product.Product_Name AS 'Product Name', 
                    Customer.Customer_fName AS 'First Name', Customer.Customer_lName AS 'Last Name', 
                    CustomerOrderDetails.Quantity_Ordered AS 'Quantity', CustomerOrders.Order_Date AS 'Date Ordered', 
                    SUM(CustomerOrderDetails.Quantity_Ordered * (Product.Sell_Price-Product.Buy_Price)) AS 'Profit (£)' 
                    FROM CustomerOrderDetails, Product, CustomerOrders, Customer 
                    WHERE Product.Product_Name LIKE @search AND CustomerOrderDetails.Order_ID = CustomerOrders.Order_ID 
                    AND Product.Product_ID = CustomerOrderDetails.Product_ID 
                    AND Customer.Customer_ID = CustomerOrders.Customer_ID 
                    GROUP BY CustomerOrderDetails.Order_ID, Product.Product_Name, Customer.Customer_fName, 
						Customer.Customer_lName, CustomerOrderDetails.Quantity_Ordered, CustomerOrders.Order_Date 
                    ORDER BY Order_Date ASC;"; // finds all products that relate to the user's search term

                var command = new MySqlCommand(searchQuery, _databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + searchBox + "%");                     // this line prevents SQL injection
                var sda = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                databaseGrid.DataSource = dt;
                _databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }
        */
    }
}