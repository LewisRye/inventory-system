namespace Inventory.DataForms
{
    public partial class FormViewInsights : Form
    {
        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public FormViewInsights()
        {
            InitializeComponent();
            DateTime minTime = new DateTime(2020, 1, 1);

            FromDate.MinDate = minTime;
            FromDate.MaxDate = DateTime.Today;
            FromDate.Value = minTime;
            ToDate.MinDate = minTime;
            ToDate.MaxDate = DateTime.Today;
            ToDate.Value = DateTime.Today;
        }

        private void FormViewInsights_Load(object Sender, EventArgs E)
        {
            WelcomeText.Text = $"welcome, {Classes.Logon.CurrentUser}!";
        }

        private void GenerateBestSeller(Label BestSeller)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var bestSeller = new MySqlCommand($@"SELECT Product.product_name, CustomerOrderDetails.quantity_ordered
                    FROM CustomerOrders
                    INNER JOIN CustomerOrderDetails ON CustomerOrderDetails.order_id = CustomerOrders.order_id
                    INNER JOIN Product ON Product.product_id = CustomerOrderDetails.product_id
                    WHERE CustomerOrders.order_date BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}'
                    GROUP BY Product.product_name, CustomerOrderDetails.quantity_ordered
                    ORDER BY SUM(CustomerOrderDetails.quantity_ordered) DESC LIMIT 1;", databaseConn); // finds the top selling item between dates selected

                var reader = bestSeller.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value) // stops an error when the database is empty
                    {
                        BestSeller.Text = $@"•The best selling item was: {reader[0]} ({reader[1]} sold)";
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
        }

        private void GenerateTotalProfit(Label TotalProfit)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var profitTotal = new MySqlCommand($@"SELECT SUM((Product.buy_price/0.8) *
                    CustomerOrderDetails.quantity_ordered) FROM CustomerOrderDetails, Product, CustomerOrders
                    WHERE Product.product_id = CustomerOrderDetails.product_id
                    AND CustomerOrders.order_id = CustomerOrderDetails.order_id
                    AND CustomerOrders.order_date BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}'
                    ORDER BY SUM((Product.buy_price/0.8) *
                    CustomerOrderDetails.quantity_ordered) DESC;", databaseConn); // finds the top selling item between dates selected

                var reader = profitTotal.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value) // stops an error when the database is empty
                    {
                        var profit = reader[0];
                        TotalProfit.Text = $@"•The total profit was: £{profit}";
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
        }

        private void GenerateMostProfitableDay(Label MostProfitableDay)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var mostProfitableDay = new MySqlCommand($@"SELECT CustomerOrders.order_date, SUM((Product.buy_price/0.8) *
                    CustomerOrderDetails.quantity_ordered) FROM CustomerOrderDetails, Product, CustomerOrders
                    WHERE Product.product_id = CustomerOrderDetails.product_id
                    AND CustomerOrders.order_id = CustomerOrderDetails.order_id
                    AND CustomerOrders.order_date BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}'
                    GROUP BY CustomerOrders.order_date
                    ORDER BY SUM((Product.buy_price/0.8) *
                    CustomerOrderDetails.quantity_ordered) DESC LIMIT 1;", databaseConn); // finds the top selling item between dates selected

                var reader = mostProfitableDay.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value) // stops an error when the database is empty
                    {
                        DateTime originalDate = Convert.ToDateTime(reader[0].ToString());
                        var convertedDate = originalDate.ToString("ddd', 'dd' 'MMM' 'yyyy");
                        var profit = reader[1];
                        MostProfitableDay.Text = $@"•The most profitable day was: {convertedDate} (£{profit} profit was made)";
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
        }

        private void GenerateTotalItemsSold(Label ItemsSold)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                var bestSeller = new MySqlCommand($@"SELECT SUM(quantity_ordered) 
                    FROM CustomerOrderDetails, CustomerOrders
                    WHERE CustomerOrderDetails.order_id = CustomerOrders.order_id 
                    AND CustomerOrders.order_date BETWEEN '
                {FromDate.Value.ToString("MM/dd/yyyy")}' 
                    AND '{ToDate.Value.ToString("MM/dd/yyyy")}';", databaseConn); // finds the top selling item between dates selected

                var reader = bestSeller.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value) // stops an error when the database is empty
                    {
                        ItemsSold.Text = $@"•The amount of items sold was: {reader[0]}";
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
        }

        private void CreateDailyOrdersChart(Chart Chart)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                Chart.Series["Revenue Per Order"].Points.Clear();

                databaseConn.Open();

                var dailyOrdersDa = new MySqlDataAdapter($@"SELECT CustomerOrders.order_id AS 'ORDER ID',
                    SUM((Product.buy_price/0.8) * CustomerOrderDetails.quantity_ordered) AS 'REVENUE'
                    FROM CustomerOrders, CustomerOrderDetails, Product
                    WHERE CustomerOrders.order_id = CustomerOrderDetails.order_id
                    AND CustomerOrderDetails.product_id = Product.product_id
                    AND order_date BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}'
                    GROUP BY CustomerOrders.order_id;", databaseConn); // finds the amount of orders in the last 7 days

                var dailyOrdersDs = new DataSet(); // creates a new set of data found by the query
                dailyOrdersDa.Fill(dailyOrdersDs);
                Chart.DataSource = dailyOrdersDs;

                Chart.Series["Revenue Per Order"].XValueMember = "ORDER ID";    // adds the date column to the X axis
                Chart.Series["Revenue Per Order"].YValueMembers = "REVENUE"; // adds the amount of orders per day to the Y axis

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

        private void ButtonInsight_Click(object Sender, EventArgs E)
        {
            TextSelectDate.Visible = false;

            var databaseConnection = new MySqlConnection(_connStr);                                                       // directs code to location of my database file

            databaseConnection.Open();

            var sda = new MySqlDataAdapter($@"SELECT CustomerOrders.order_id AS 'Order ID', CustomerOrders.customer_id AS 'Customer ID',
                Product.product_name AS 'Product Name', CustomerOrderDetails.quantity_ordered AS 'Quantity', CustomerOrders.order_date AS 'Date Ordered',
                SUM(CustomerOrderDetails.quantity_ordered * buy_price) AS 'Order Price (£)'
                FROM CustomerOrders, CustomerOrderDetails, Product
                WHERE CustomerOrders.order_id = CustomerOrderDetails.order_id
                AND CustomerOrderDetails.product_id = Product.product_id
                AND order_date BETWEEN '{FromDate.Value.ToString("MM/dd/yyyy")}' AND '{ToDate.Value.ToString("MM/dd/yyyy")}'
                GROUP BY CustomerOrders.order_id, CustomerOrders.customer_id, Product.product_name, CustomerOrderDetails.quantity_ordered, CustomerOrders.order_date;", databaseConnection);

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
            new ProgramForms.FormDashboard().Show();
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
