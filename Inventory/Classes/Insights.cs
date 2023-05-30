namespace Inventory.Classes
{
    internal class Insights
    {
        /*
         *  Contents
         */

        //  -creates insights based on SQL queries
        MySqlConnection databaseConn = new MySqlConnection(Classes.Logon.ConnectionString);

        public void CreateStockByTypeChart(Chart Chart)
        {
            try
            {
                databaseConn.Open();

                var stockbytypeDa = new MySqlDataAdapter(@"SELECT SUM(Number_In_Stock) AS Stock, Category_Name 
                    FROM Product, Category WHERE Product.Category_ID = Category.Category_ID 
                    GROUP BY Category.Category_Name;", Logon.ConnectionString);                                      // finds amount of stock of each product category
                var stockbytypeDs = new DataSet();
                stockbytypeDa.Fill(stockbytypeDs);                                                                      // adds all values from SQL into a set of data
                Chart.DataSource = stockbytypeDs;                                                                       // graph takes values from the dataset
                Chart.Series["StockByType"].XValueMember = "Category_Name";                                              // adds all found category names to the key
                Chart.Series["StockByType"].YValueMembers = "Stock";                                                    // adds all stock numbers into the donut graph
                Chart.Series["StockByType"]["PieLabelStyle"] = "Disabled";                                              // stops the chart from labelling

                databaseConn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CreateDailyOrdersChart(Chart Chart)
        {
            try
            {
                databaseConn.Open();

                var dailyOrdersDa = new MySqlDataAdapter(@"SELECT COUNT(*) AS ORDERS, Order_Date AS DATE 
                FROM CustomerOrders WHERE Order_Date BETWEEN CURDATE()-7 AND CURDATE() 
                GROUP BY Order_Date;", databaseConn); // finds the amount of orders in the last 7 days

                var dailyOrdersDt = new DataTable(); // creates a new set of data found by the query
                dailyOrdersDa.Fill(dailyOrdersDt);

                Chart.DataSource = dailyOrdersDt;

                Chart.Series["DailyOrders"].XValueMember = "DATE";    // adds the date column to the X axis
                Chart.Series["DailyOrders"].YValueMembers = "ORDERS"; // adds the amount of orders per day to the Y axis
                Chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";

                databaseConn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CreateBestSellersChart(Label Label)
        {
            try
            {
                databaseConn.Open();

                var bestSellersDa = new MySqlDataAdapter(@"SELECT SUM(CustomerOrderDetails.Quantity_Ordered) AS Quantity, Product.Product_Name AS Name FROM CustomerOrderDetails 
                    INNER JOIN Product ON Product.Product_ID = CustomerOrderDetails.Product_ID 
                    GROUP BY CustomerOrderDetails.Product_ID, Product_Name 
                    ORDER BY SUM(Quantity_Ordered) DESC LIMIT 5;", Logon.ConnectionString);                                                    // finds the top 5 selling items
                var bestSellersDt = new DataTable();
                bestSellersDa.Fill(bestSellersDt);                                                                      // adds all values from SQL into the dataset

                int rowNumber = 1;
                Label.Text = "";

                foreach (DataRow row in bestSellersDt.Rows)
                {
                    string rowProduct = row[1].ToString();                                                              // gets the ProductName column from the Data Table
                    string rowQuantity = row[0].ToString();                                                             // gets the QuantityOrdered column from the Data Table
                    Label.Text += $"{rowNumber}. {rowProduct} ({rowQuantity}x sold)\n\n";                          // adds a product to the list in the form shown here
                    rowNumber++;
                }

                databaseConn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CreateQuantityItemsStockText(Button Button)
        {
            try
            {
                databaseConn.Open();

                var stockCmd = new MySqlCommand(@"SELECT SUM(Number_In_Stock) FROM Product", databaseConn); // finds the total number in stock of every item in the warehouse.

                var reader = stockCmd.ExecuteReader();

                while (reader.Read())
                {
                    Button.Text = reader[0].ToString();
                }

                databaseConn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CreateQuantityItemsProfitText(Button Button)
        {
            try
            {
                databaseConn.Open();

                var profitCmd = new MySqlCommand(@"SELECT SUM((1.2 * Product.Buy_Price) * 
                    CustomerOrderDetails.Quantity_Ordered) FROM CustomerOrderDetails, Product, CustomerOrders 
                    WHERE Product.Product_ID = CustomerOrderDetails.Product_ID 
                    AND CustomerOrders.Order_ID = CustomerOrderDetails.Order_ID 
                    AND CustomerOrders.Order_Date BETWEEN CURDATE() - 7 AND CURDATE(); ", databaseConn); // finds the amount of profit from every order in the last 7 days

                var reader = profitCmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        string orderProfit = Convert.ToDouble(reader[0]).ToString("0.00");                        // gets the profit value and converts it into a money format for readability
                        Button.Text = $"£{orderProfit}";                                                                // adds a GBP sign in front of the profit
                    }
                }

                databaseConn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CreateQuantityItemsOrdersText(Button Button)
        {
            try
            {
                databaseConn.Open();

                var orderdateCmd = new MySqlCommand(@"SELECT COUNT(Order_ID) FROM CustomerOrders 
                    WHERE Order_Date BETWEEN CURDATE()-7 and CURDATE(); ", databaseConn);    // finds the amount of orders in the past 7 days

                var reader = orderdateCmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        Button.Text = reader[0].ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            databaseConn.Close();
        }
    }
}
