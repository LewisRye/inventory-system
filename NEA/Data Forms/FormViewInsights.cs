using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;

namespace NEA
{
    public partial class FormViewInsights : Form
    {
        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public FormViewInsights()
        {
            string minimumDate = "";

            InitializeComponent();
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var bestSeller = new SqlCommand($@"SELECT TOP(1) CustomerOrders.OrderDate 
                    FROM CustomerOrders ORDER BY OrderDate ASC;", databaseConn);

                var reader = bestSeller.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        minimumDate = reader[0].ToString();
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

            FromDate.MinDate = Convert.ToDateTime(minimumDate);
            FromDate.MaxDate = DateTime.Today;
            ToDate.MinDate = Convert.ToDateTime(minimumDate);
            ToDate.MaxDate = DateTime.Today;
            ToDate.Value = DateTime.Today;
        }

        private void ViewInsightsForm_Load(object Sender, EventArgs E)
        {
            WelcomeText.Text = $"welcome, {Logon.CurrentUser}!";
        }

        private void GenerateBestSeller(Label BestSeller)
        {
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var bestSeller = new SqlCommand($@"SELECT TOP(1) Product.ProductName, CustomerOrderDetails.QuantityOrdered
                    FROM CustomerOrders
                    INNER JOIN CustomerOrderDetails ON CustomerOrderDetails.OrderID = CustomerOrders.OrderID
                    INNER JOIN Product ON Product.ProductID = CustomerOrderDetails.ProductID
                    WHERE CustomerOrders.OrderDate BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}'
                    GROUP BY Product.ProductName, CustomerOrderDetails.QuantityOrdered
                    ORDER BY SUM(CustomerOrderDetails.QuantityOrdered) DESC;", databaseConn);                                                    // finds the top selling item between dates selected

                var reader = bestSeller.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        BestSeller.Text = $@"•The best selling item was: {reader[0]} ({reader[1]} sold)"; // adds a GBP sign in front of the profit
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

        private void GenerateTotalProfit(Label TotalProfit)
        {
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var profitTotal = new SqlCommand($@"SELECT SUM((Product.SellingPrice - Product.BuyingPrice) *
                    CustomerOrderDetails.QuantityOrdered) FROM CustomerOrderDetails, Product, CustomerOrders
                    WHERE Product.ProductID = CustomerOrderDetails.ProductID
                    AND CustomerOrders.OrderID = CustomerOrderDetails.OrderID
                    AND CustomerOrders.OrderDate BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}' 
                    ORDER BY SUM((Product.SellingPrice -Product.BuyingPrice) *
                    CustomerOrderDetails.QuantityOrdered) DESC;", databaseConn);                                                    // finds the top selling item between dates selected

                var reader = profitTotal.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        var profit = reader[0];
                        TotalProfit.Text = $@"•The total profit was: £{profit}"; // adds a GBP sign in front of the profit
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

        private void GenerateMostProfitableDay(Label MostProfitableDay)
        {
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var mostProfitableDay = new SqlCommand($@"SELECT TOP 1 CustomerOrders.OrderDate, SUM((Product.SellingPrice - Product.BuyingPrice) *
                    CustomerOrderDetails.QuantityOrdered) FROM CustomerOrderDetails, Product, CustomerOrders
                    WHERE Product.ProductID = CustomerOrderDetails.ProductID
                    AND CustomerOrders.OrderID = CustomerOrderDetails.OrderID
                    AND CustomerOrders.OrderDate BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}' 
                    GROUP BY CustomerOrders.OrderDate
                    ORDER BY SUM((Product.SellingPrice -Product.BuyingPrice) *
                    CustomerOrderDetails.QuantityOrdered) DESC;", databaseConn);                                                    // finds the top selling item between dates selected
                
                var reader = mostProfitableDay.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        DateTime originalDate = Convert.ToDateTime(reader[0].ToString());
                        var convertedDate = originalDate.ToString("ddd', 'dd' 'MMM' 'yyyy");
                        var profit = reader[1];
                        MostProfitableDay.Text = $@"•The most profitable day was: {convertedDate} (£{profit} profit was made)"; // adds a GBP sign in front of the profit
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

        private void GenerateTotalItemsSold(Label ItemsSold)
        {
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();

            var bestSeller = new SqlCommand($@"SELECT SUM(QuantityOrdered) 
                    FROM CustomerOrderDetails, CustomerOrders
                    WHERE CustomerOrderDetails.OrderID = CustomerOrders.OrderID 
                    AND CustomerOrders.OrderDate BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' 
                    AND '{ToDate.Value.ToString("MM/dd/yyyy")}';", databaseConn);                                 // finds the top selling item between dates selected

                var reader = bestSeller.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)                                                                      // stops an error when the database is empty
                    {
                        ItemsSold.Text = $@"•The amount of items sold was: {reader[0]}";
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

        private void CreateDailyOrdersChart(Chart Chart)
        {
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                Chart.Series["Revenue Per Order"].Points.Clear();

                databaseConn.Open();

                var dailyOrdersDa = new SqlDataAdapter($@"SELECT CustomerOrders.OrderID AS 'ORDER ID', 
                    SUM((Product.SellingPrice-Product.BuyingPrice) * CustomerOrderDetails.QuantityOrdered) AS 'REVENUE' 
                    FROM CustomerOrders, CustomerOrderDetails, Product 
                    WHERE CustomerOrders.OrderID = CustomerOrderDetails.OrderID 
                    AND CustomerOrderDetails.ProductID = Product.ProductID 
                    AND OrderDate BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}' 
                    GROUP BY CustomerOrders.OrderID;", databaseConn); // finds the amount of orders in the last 7 days

                var dailyOrdersDs = new DataSet(); // creates a new set of data found by the query
                dailyOrdersDa.Fill(dailyOrdersDs);
                Chart.DataSource = dailyOrdersDs;

                Chart.Series["Revenue Per Order"].XValueMember = "ORDER ID";    // adds the date column to the X axis
                Chart.Series["Revenue Per Order"].YValueMembers = "REVENUE"; // adds the amount of orders per day to the Y axis

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

        private void ButtonInsight_Click(object Sender, EventArgs E)
        {
            TextSelectDate.Visible = false;

            var databaseConnection = new SqlConnection(_connStr);                                                       // directs code to location of my database file

            databaseConnection.Open();

            var sda = new SqlDataAdapter($@"SELECT CustomerOrders.OrderID AS 'Order ID', CustomerOrders.CustomerID AS 'Customer ID', 
                Product.ProductName AS 'Product Name', CustomerOrderDetails.QuantityOrdered AS 'Quantity', CustomerOrders.OrderDate AS 'Date Ordered', 
                SUM(CustomerOrderDetails.QuantityOrdered * SellingPrice) AS 'Order Price (£)' 
                FROM CustomerOrders, CustomerOrderDetails, Product 
                WHERE CustomerOrders.OrderID = CustomerOrderDetails.OrderID
                AND CustomerOrderDetails.ProductID = Product.ProductID 
                AND OrderDate BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}' 
                GROUP BY CustomerOrders.OrderID, CustomerOrders.CustomerID, Product.ProductName, CustomerOrderDetails.QuantityOrdered, CustomerOrders.OrderDate", databaseConnection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            DatabaseGrid.DataSource = dt;
            databaseConnection.Close();

            if (dt.Rows.Count == 0)
            {
                TextTotalItemsSold.Text = "During the selected time period, there were no orders.";
                TextMostProfitableDay.Text = "Please select a different time period.";
                TextTotalProfit.Text = "";
                TextBestSeller.Text = "";
            }

            GenerateTotalItemsSold(TextTotalItemsSold);
            GenerateMostProfitableDay(TextMostProfitableDay);
            GenerateTotalProfit(TextTotalProfit);
            GenerateBestSeller(TextBestSeller);
            CreateDailyOrdersChart(ChartDailyRevenue);
        }

        private void CloseButton_Click(object Sender, EventArgs E)
        {
            new FormDashboard().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            if (ToDate.Value < FromDate.Value)
            {
                MessageBox.Show("'From Date' must come before the 'To Date'...", "Error");
                FromDate.Value = FromDate.MinDate;
                ToDate.Value = ToDate.MaxDate;
            }
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            if (ToDate.Value < FromDate.Value)
            {
                MessageBox.Show("'From Date' must come before the 'To Date'...", "Error");
                FromDate.Value = FromDate.MinDate;
                ToDate.Value = ToDate.MaxDate;
            }
        }
    }
}
