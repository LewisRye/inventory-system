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
            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "insight_most_profitable_day");
                request.Headers.Add("from", FromDate.Value.ToString("dd/MM/yyyy"));
                request.Headers.Add("to", ToDate.Value.ToString("dd/MM/yyyy"));
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    List<DailyOrder>? dailyOrders = JsonSerializer.Deserialize<List<DailyOrder>>(json)!;
                    mostProfitableDayLabel.Text = $@"•The most profitable day was: {dailyOrders[0].Date.ToShortDateString()} (£{dailyOrders[0].Orders} profit was made)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void GenerateTotalProfit(Label totalProfit)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "insight_total_profit");
                request.Headers.Add("from", FromDate.Value.ToString("dd/MM/yyyy"));
                request.Headers.Add("to", ToDate.Value.ToString("dd/MM/yyyy"));
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    Int32 profit = JsonSerializer.Deserialize<Int32>(json)!;
                    totalProfit.Text = $@"•The total profit was: £{profit}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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

        private void ButtonInsight_Click(object sender, EventArgs e)
        {
            TextSelectDate.Visible = false;
            
            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "insight_total_orders");
                request.Headers.Add("from", FromDate.Value.ToString("dd/MM/yyyy"));
                request.Headers.Add("to", ToDate.Value.ToString("dd/MM/yyyy"));
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    List<Order> orders = JsonSerializer.Deserialize<List<Order>>(json)!;
                    DatabaseGrid.DataSource = orders;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            GenerateTotalItemsSold(TextTotalItemsSold);
            GenerateMostProfitableDay(TextMostProfitableDay);
            GenerateTotalProfit(TextTotalProfit);
            GenerateBestSeller(TextBestSeller);
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
