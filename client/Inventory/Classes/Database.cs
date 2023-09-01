namespace Inventory.Classes
{
    internal class Database
    {
        private MySqlConnection databaseConnection = new MySqlConnection(Logon.ConnectionString); // directs code to location of my database file

        private List<Classes.Product> products = new List<Classes.Product>();
        private List<Classes.Category> categories = new List<Classes.Category>();
        private List<Classes.Order> orders = new List<Classes.Order>();

        private List<Classes.Product> newProductList = new List<Classes.Product>();
        private List<Classes.Order> newOrderList = new List<Classes.Order>();

        public List<Classes.Product> GetProducts()
        {
            LoadProducts();
            return products;
        }

        public List<Classes.Product> GetProducts(String Search)
        {
            LoadProducts(Search);
            return newProductList;
        }

        public List<Classes.Category> GetCategories()
        {
            LoadCategories();
            return categories;
        }

        public List<Classes.Order> GetOrders()
        {
            LoadOrders();
            return orders;
        }

        public List<Classes.Order> GetOrders(String Search)
        {
            LoadOrders(Search);
            return newOrderList;
        }

        private void LoadProducts()
        {
            try
            {
                newProductList.Clear();
                databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT Product.Product_ID, Product.Product_Name, 
                    Category.Category_Name, Product.number_in_stock, Product.Buy_Price, Product.Discontinued  
                    FROM Product, Category 
                    WHERE Product.Category_ID = Category.Category_ID 
                    GROUP BY Category.Category_Name, Product.Product_ID, Product.Product_Name, 
                    Product.number_in_stock, Product.Buy_Price, Product.Discontinued;", databaseConnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Classes.Product(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToDecimal(reader.GetString(4)), Convert.ToChar(reader.GetString(5))));
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        private void LoadProducts(string Search)
        {
            try
            {
                databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT Product.Product_ID, Product.Product_Name, 
                    Category.Category_Name, Product.number_in_stock, Product.Buy_Price, Product.Discontinued  
                    FROM Product INNER JOIN Category ON Product.Category_ID = Category.Category_ID 
                    WHERE Product.Product_Name LIKE @search OR Category.Category_Name LIKE @search;", databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + Search + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newProductList.Add(new Classes.Product(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToDecimal(reader.GetString(4)), Convert.ToChar(reader.GetString(5))));
                }
                databaseConnection.Close();
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
                databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT category_id, category_name FROM Category", databaseConnection); // uses SQL query to read data
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Classes.Category(Convert.ToInt32(reader.GetString(0)), reader.GetString(1).ToString()));
                }
                databaseConnection.Close();
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
                databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT CustomerOrderDetails.Order_ID AS 'Order ID', Product.Product_Name AS 'Product Name', 
                    Customer.Customer_FName AS 'First Name', Customer.Customer_LName AS 'Last Name', CustomerOrderDetails.Quantity_Ordered AS 'Quantity', 
                    CustomerOrders.Order_Date AS 'Date Ordered', ROUND(Product.Buy_Price * 1.2, 2) AS 'Order Price' FROM Product, CustomerOrders, CustomerOrderDetails, Customer 
                    WHERE CustomerOrderDetails.Order_ID = CustomerOrders.Order_ID AND Product.Product_ID = CustomerOrderDetails.Product_ID AND Customer.Customer_ID = CustomerOrders.Customer_ID 
                    GROUP BY CustomerOrderDetails.Order_ID, Product.Product_Name, Customer.Customer_FName, Customer.Customer_LName, CustomerOrderDetails.Quantity_Ordered, CustomerOrders.Order_Date, Product.Buy_Price 
                    ORDER BY Order_Date ASC;", databaseConnection); // uses SQL query to read data
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Classes.Order(Convert.ToInt32(reader.GetString(0)), reader.GetString(1).ToString(), reader.GetString(2), reader.GetString(3), Convert.ToInt32(reader.GetString(4)), Convert.ToDateTime(reader.GetString(5)), Convert.ToDecimal(reader.GetString(6))));
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        private void LoadOrders(string Search)
        {
            try
            {
                databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT CustomerOrderDetails.Order_ID AS 'Order ID', Product.Product_Name AS 'Product Name', 
                    Customer.Customer_FName AS 'First Name', Customer.Customer_LName AS 'Last Name', CustomerOrderDetails.Quantity_Ordered AS 'Quantity', 
                    CustomerOrders.Order_Date AS 'Date Ordered', ROUND(Product.Buy_Price * 1.2, 2) AS 'Order Price' FROM Product, CustomerOrders, CustomerOrderDetails, Customer 
                    WHERE (Customer.Customer_FName LIKE @search OR Customer.Customer_LName LIKE @search OR Product.Product_Name LIKE @search) AND CustomerOrderDetails.Order_ID = CustomerOrders.Order_ID AND Product.Product_ID = CustomerOrderDetails.Product_ID AND Customer.Customer_ID = CustomerOrders.Customer_ID 
                    GROUP BY CustomerOrderDetails.Order_ID, Product.Product_Name, Customer.Customer_FName, Customer.Customer_LName, CustomerOrderDetails.Quantity_Ordered, CustomerOrders.Order_Date, Product.Buy_Price 
                    ORDER BY Order_Date ASC;", databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + Search + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newOrderList.Add(new Classes.Order(Convert.ToInt32(reader.GetString(0)), reader.GetString(1).ToString(), reader.GetString(2), reader.GetString(3), Convert.ToInt32(reader.GetString(4)), Convert.ToDateTime(reader.GetString(5)), Convert.ToDecimal(reader.GetString(6))));
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        public List<Classes.Product> SearchDataFromProductDb(string SearchBox)
        {
            List<Classes.Product> products = new List<Classes.Product>();
            try
            {
                databaseConnection.Open();
                var command = new MySqlCommand(@"SELECT Product.Product_ID, Product.Product_Name, 
                    Category.Category_Name, Product.number_in_stock, Product.Buy_Price, Product.Discontinued  
                    FROM Product INNER JOIN Category ON Product.Category_ID = Category.Category_ID 
                    WHERE Product.Product_Name LIKE @search OR Category.Category_Name LIKE @search;", databaseConnection);
                command.Parameters.AddWithValue("@search", SearchBox);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Classes.Product(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToInt32(reader.GetString(3)), Convert.ToDecimal(reader.GetString(4)), Convert.ToChar(reader.GetString(5))));
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            return products;
        }

        public void LoadNoStockFromProductDb(DataGridView DatabaseGrid, ComboBox DatabaseComboBox)
        {
            try
            {
                databaseConnection.Open();
                DatabaseGrid.Rows.Clear();
                var da = new MySqlDataAdapter($@"SELECT Product.Product_ID AS 'ID', Product.Product_Name AS 'Name', 
                    Category.Category_Name AS 'Category', Product.Number_In_Stock AS 'Stock', Product.Buy_Price AS 'Buy Price', 
                    Product.Discontinued AS 'Discontinued' 
                    FROM Product INNER JOIN Category on Product.Category_ID = Category.Category_ID 
                    WHERE stock < {Logon.NotificationStock} AND Discontinued = 'n'", databaseConnection);                               // uses SQL query to read every piece of data in database

                DataTable dt = new DataTable();
                da.Fill(dt);
                DatabaseGrid.DataSource = dt;   // binds the data from the query to the DataGrid
                databaseConnection.Close();

                foreach (DataGridViewRow row in DatabaseGrid.Rows)
                {
                    DatabaseComboBox.Items.Add(row.Cells["Name"].Value.ToString()); // adds all out of stock items to the combo box
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

        public void LoadDataFromOrdersDb(DataGridView DatabaseGrid)
        {
            try
            {
                databaseConnection.Open();
                DatabaseGrid.Rows.Clear();
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
                    ORDER BY Order_Date ASC;", databaseConnection); // uses SQL query to read every piece of data in database

                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseGrid.DataSource = dt;
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }

        public void SearchDataFromOrdersDb(DataGridView DatabaseGrid, string SearchBox)
        {
            try
            {
                databaseConnection.Open();
                DatabaseGrid.Rows.Clear();
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

                var command = new MySqlCommand(searchQuery, databaseConnection);
                command.Parameters.AddWithValue("@search", "%" + SearchBox + "%");                     // this line prevents SQL injection
                var sda = new MySqlDataAdapter(command);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseGrid.DataSource = dt;
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
        }
    }
}