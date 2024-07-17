using Inventory.JsonResponses;

namespace Inventory.Classes
{
    internal class Insights
    {
        /*
         *  Contents
         */
        
        public async Task CreateStockByTypeChart(Chart chart)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_stock_type");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<StockType>? stockTypes = JsonSerializer.Deserialize<List<StockType>>(jsonContent);

                    Series s = new Series
                    {
                        Name = "Stock By Type",
                        ChartType = SeriesChartType.Doughnut,
                    };

                    if (stockTypes != null)
                        foreach (var stock in stockTypes)
                        {
                            s.Points.AddXY(stock.Category, stock.Stock);
                        }

                    chart.Series.Add(s);
                }
            }
            catch (JsonException e)
            {
                MessageBox.Show($"StockType: JSON Error\n{e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateDailyOrdersChart(Chart chart)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_daily_orders");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<DailyOrder>? dailyOrders = JsonSerializer.Deserialize<List<DailyOrder>>(jsonContent);

                    Series s = new Series
                    {
                        Name = "Daily Orders",
                        ChartType = SeriesChartType.Bar,
                    };

                    if (dailyOrders != null)
                        foreach (DailyOrder day in dailyOrders)
                        {
                            s.Points.AddXY(day.Date, day.Orders);
                        }

                    chart.Series.Add(s);
                }
            }
            catch (JsonException e)
            {
                MessageBox.Show($"DailyOrders: JSON Error\n{e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateBestSellersChart(Label label)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_best_sellers");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<BestSeller>? bestSellers = JsonSerializer.Deserialize<List<BestSeller>>(jsonContent);
                    int i = 1;
                    StringBuilder sb = new StringBuilder();
                    if (bestSellers != null)
                        foreach (BestSeller item in bestSellers)
                        {
                            sb.Append($"{i}. {item.Name} ({item.Quantity}x sold)\n\n");
                            i++;
                        }

                    label.Text = sb.ToString();
                }
            }
            catch (JsonException e)
            {
                MessageBox.Show($"BestSeller: JSON Error\n{e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateQuantityItemsStockText(Button button)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_stock");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    button.Text = jsonContent;
                }
            }
            catch (JsonException e)
            {
                MessageBox.Show($"ItemsStock: JSON Error\n{e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateQuantityItemsProfitText(Button button)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_profit");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    string result = float.Parse(jsonContent).ToString("#,##0.00");
                    button.Text = $"£{result}";
                }
            }
            catch (JsonException e)
            {
                MessageBox.Show($"ItemsProfit: JSON Error\n{e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }

        public async Task CreateQuantityItemsOrdersText(Button button)
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(Classes.Logon.UriPath + "dashboard_orders");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    button.Text = jsonContent;
                }
            }
            catch (JsonException e)
            {
                MessageBox.Show($"ItemsOrders: JSON Error\n{e.Message}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"HTTP Error: {e.Message}");
            }
        }
    }
}
