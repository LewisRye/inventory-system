using Inventory.Classes;
using Inventory.JsonResponses;

namespace Inventory.DataForms
{
    public partial class FormViewInsights : Form
    {
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

        private void FormViewInsights_Load(object sender, EventArgs e)
        {
            WelcomeText.Text = $"welcome, {Classes.Logon.CurrentUser}!";
        }

        private void GenerateTotalItemsSold(Label itemsSold)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "insight_total_items");
                request.Headers.Add("from", FromDate.Value.ToString("dd/MM/yyyy"));
                request.Headers.Add("to", ToDate.Value.ToString("dd/MM/yyyy"));
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    Int32 i = JsonSerializer.Deserialize<Int32>(json)!;
                    itemsSold.Text = $@"•The amount of items sold was: {i}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void GenerateMostProfitableDay(Label mostProfitableDayLabel)
        {
            /*
            var databaseConn = new MySqlConnection(ConnStr);

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
                        mostProfitableDayLabel.Text = $@"•The most profitable day was: {convertedDate} (£{profit} profit was made)";
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
            */
        }

        private void GenerateTotalProfit(Label totalProfit)
        {
            /*
            var databaseConn = new MySqlConnection(ConnStr);

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
                        totalProfit.Text = $@"•The total profit was: £{profit}";
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
            */
        }

        private void GenerateBestSeller(Label bestSellerLabel)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "insight_best_seller");
                request.Headers.Add("from", FromDate.Value.ToString("dd/MM/yyyy"));
                request.Headers.Add("to", ToDate.Value.ToString("dd/MM/yyyy"));
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    List<BestSeller> b = JsonSerializer.Deserialize<List<BestSeller>>(json)!;
                    bestSellerLabel.Text = $@"•The best selling item was: {b.First().Name} ({b.First().Quantity} sold)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CreateDailyOrdersChart(Chart chart)
        {
            /*
            var databaseConn = new MySqlConnection(ConnStr);

            try
            {
                chart.Series["Revenue Per Order"].Points.Clear();

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
                chart.DataSource = dailyOrdersDs;

                chart.Series["Revenue Per Order"].XValueMember = "ORDER ID";    // adds the date column to the X axis
                chart.Series["Revenue Per Order"].YValueMembers = "REVENUE"; // adds the amount of orders per day to the Y axis

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
            */
        }

        private void ButtonInsight_Click(object sender, EventArgs e)
        {
            TextSelectDate.Visible = false;

            /*
            var databaseConnection = new MySqlConnection(ConnStr);                                                       // directs code to location of my database file

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
            */

            GenerateTotalItemsSold(TextTotalItemsSold);
            //GenerateMostProfitableDay(TextMostProfitableDay);
            //GenerateTotalProfit(TextTotalProfit);
            GenerateBestSeller(TextBestSeller);
            //CreateDailyOrdersChart(ChartDailyRevenue);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormDashboard().Show();
            this.Close();
            this.Dispose();
            GC.Collect();
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
