using Inventory.JsonResponses;

namespace Inventory.Classes
{
    internal class Insights
    {
        /*
         *  Contents
         */

        HttpClient client = new HttpClient();

        public async Task CreateStockByTypeChart(Chart Chart)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_stock_type");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<StockType> stockTypes = JsonSerializer.Deserialize<List<StockType>>(jsonContent);

                    Series s = new Series
                    {
                        Name = "Stock By Type",
                        ChartType = SeriesChartType.Doughnut,
                    };

                    foreach (StockType stock in stockTypes)
                    {
                        s.Points.AddXY(stock.Category, stock.Stock);
                    }

                    Chart.Series.Add(s);
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON Error: {e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateDailyOrdersChart(Chart Chart)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_daily_orders");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<DailyOrder> dailyOrders = JsonSerializer.Deserialize<List<DailyOrder>>(jsonContent);

                    Series s = new Series
                    {
                        Name = "Daily Orders",
                        ChartType = SeriesChartType.Bar,
                    };

                    foreach (DailyOrder day in dailyOrders)
                    {
                        s.Points.AddXY(day.Date, day.Orders);
                    }

                    Chart.Series.Add(s);
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON Error: {e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateBestSellersChart(Label Label)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_best_sellers");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<BestSeller> bestSellers = JsonSerializer.Deserialize<List<BestSeller>>(jsonContent);
                    int i = 1;
                    StringBuilder sb = new StringBuilder();
                    foreach (BestSeller item in bestSellers)
                    {
                        sb.Append($"{i}. {item.Name} ({item.Quantity}x sold)\n\n");
                        i++;
                    }
                    Label.Text = sb.ToString();
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON Error: {e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateQuantityItemsStockText(Button Button)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_stock");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    Button.Text = jsonContent;
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON Error: {e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateQuantityItemsProfitText(Button Button)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_profit");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    string result = float.Parse(jsonContent).ToString("#,##0.00");
                    Button.Text = $"£{result}";
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON Error: {e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateQuantityItemsOrdersText(Button Button)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_orders");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    Button.Text = jsonContent;
                }
            }
            catch (JsonException e)
            {
                Console.WriteLine($"JSON Error: {e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }
    }
}
