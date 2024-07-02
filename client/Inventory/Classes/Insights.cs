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
                    MessageBox.Show(jsonContent);
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
                    MessageBox.Show(jsonContent);
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
                    MessageBox.Show(jsonContent);
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
