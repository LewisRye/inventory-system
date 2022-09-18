using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Configuration;

namespace NEA
{
    internal class Insights
    {
        /*
         *  Contents
         */

        //  -creates insights based on SQL queries

        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public void CreateStockByTypeChart(Chart Chart)
        {
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var stockbytypeDa = new SqlDataAdapter(@"SELECT SUM(NumberInStock) AS Stock, CategoryName 
                    FROM Product, Category WHERE Product.CategoryID = Category.CategoryID 
                    GROUP BY Category.CategoryName;", _connStr);                                      // finds amount of stock of each product category
                var stockbytypeDs = new DataSet();
                stockbytypeDa.Fill(stockbytypeDs);                                                                      // adds all values from SQL into a set of data
                Chart.DataSource = stockbytypeDs;                                                                       // graph takes values from the dataset
                Chart.Series["StockByType"].XValueMember = "CategoryName";                                              // adds all found category names to the key
                Chart.Series["StockByType"].YValueMembers = "Stock";                                                    // adds all stock numbers into the donut graph
                Chart.Series["StockByType"]["PieLabelStyle"] = "Disabled";                                              // stops the chart from labelling
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var dailyOrdersDa = new SqlDataAdapter(@"SELECT COUNT(*) AS ORDERS, OrderDate AS DATE 
                FROM CustomerOrders WHERE OrderDate BETWEEN GETDATE()-7 AND GETDATE() 
                GROUP BY OrderDate;", databaseConn); // finds the amount of orders in the last 7 days

                var dailyOrdersDt = new DataTable(); // creates a new set of data found by the query
                dailyOrdersDa.Fill(dailyOrdersDt);

                Chart.DataSource = dailyOrdersDt;

                Chart.Series["DailyOrders"].XValueMember = "DATE";    // adds the date column to the X axis
                Chart.Series["DailyOrders"].YValueMembers = "ORDERS"; // adds the amount of orders per day to the Y axis
                Chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";

                databaseConn.Close();
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var bestSellersDa = new SqlDataAdapter(@"SELECT TOP(5) CustomerOrderDetails.ProductID, 
                    SUM(QuantityOrdered) AS TotalQuantity, Product.ProductName FROM CustomerOrderDetails 
                    INNER JOIN Product ON Product.ProductID = CustomerOrderDetails.ProductID 
                    GROUP BY CustomerOrderDetails.ProductID, ProductName 
                    ORDER BY SUM(QuantityOrdered) DESC;", _connStr);                                                    // finds the top 5 selling items
                var bestSellersDt = new DataTable();
                bestSellersDa.Fill(bestSellersDt);                                                                      // adds all values from SQL into the dataset

                int rowNumber = 1;
                Label.Text = "";

                foreach (DataRow row in bestSellersDt.Rows)
                {
                    string rowProduct = row[2].ToString();                                                              // gets the ProductName column from the Data Table
                    string rowQuantity = row[1].ToString();                                                             // gets the QuantityOrdered column from the Data Table
                    Label.Text += $"{rowNumber}. {rowProduct} ({rowQuantity}x sold)\n\n";                          // adds a product to the list in the form shown here
                    rowNumber++;
                }
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var stockCmd = new SqlCommand(@"SELECT SUM(NumberInStock) FROM Product", databaseConn); // finds the total number in stock of every item in the warehouse.

                var reader = stockCmd.ExecuteReader();

                while (reader.Read())
                {
                    Button.Text = reader[0].ToString();
                }
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var profitCmd = new SqlCommand(@"SELECT SUM((Product.SellingPrice - Product.BuyingPrice) * 
                    CustomerOrderDetails.QuantityOrdered) FROM CustomerOrderDetails, Product, CustomerOrders 
                    WHERE Product.ProductID = CustomerOrderDetails.ProductID 
                    AND CustomerOrders.OrderID = CustomerOrderDetails.OrderID 
                    AND CustomerOrders.OrderDate BETWEEN GETDATE() - 7 AND GETDATE(); ", databaseConn); // finds the amount of profit from every order in the last 7 days

                var reader = profitCmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        string orderProfit = Convert.ToDouble(reader[0]).ToString("0.00");                        // gets the profit value and converts it into a money format for readability
                        Button.Text = $"£{orderProfit}";                                                                // adds a GBP sign in front of the profit
                    }
                }
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var orderdateCmd = new SqlCommand(@"SELECT COUNT(OrderID) FROM CustomerOrders 
                    WHERE OrderDate BETWEEN GETDATE()-7 and GETDATE(); ", databaseConn);    // finds the amount of orders in the past 7 days

                var reader = orderdateCmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        Button.Text = reader[0].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error"); 
            }
        }
    }
}
