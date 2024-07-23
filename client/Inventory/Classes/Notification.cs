namespace Inventory.Classes
{
    internal class Notification
    {
        /*
         *  Contents
         */

        // -handles notifications 

        private protected int NumberLowItems = 0;

        public void CheckForLowStock(NotifyIcon notification)
        {
            try
            {
                try
                {
                    using HttpClient client = new HttpClient();
                    HttpRequestMessage request =
                        new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "notification");
                    request.Headers.Add("threshold", $"{Logon.NotificationStock}");
                    HttpResponseMessage response = client.Send(request);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync().Result;

                        NumberLowItems = JsonSerializer.Deserialize<int>(json)!;

                        MessageBox.Show("checked and got good result");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                if (NumberLowItems > 0) // there is a low stock item
                {
                    notification.BalloonTipIcon = ToolTipIcon.Info;
                    notification.BalloonTipText = $"There are {NumberLowItems} items running low or out of stock, click for more information.";
                    notification.BalloonTipTitle = "Stock Warning";
                    notification.ShowBalloonTip(30000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
