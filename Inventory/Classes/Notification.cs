namespace Inventory.Classes
{
    internal class Notification
    {
        /*
         *  Contents
         */

        //  -handles notifications

        private MySqlConnection databaseConnection = new MySqlConnection(Logon.ConnectionString); // directs code to location of my database
        private protected int NumberLowItems = 0;

        public void CheckForLowStock(NotifyIcon Notification)
        {
            try
            {
                databaseConnection.Open();

                var sda = new MySqlDataAdapter($@"SELECT COUNT(product_id) 
                    FROM Product 
                    WHERE stock <= {Logon.NotificationStock}", databaseConnection); // SQL query for user defined critical stock level
                var dt = new DataTable();
                sda.Fill(dt);
                NumberLowItems = Convert.ToInt32(dt.Rows[0][0]);
                databaseConnection.Close();

                if (dt.Rows.Count > 0) // if table has any rows, there is a low stock item
                {
                    Notification.BalloonTipIcon = ToolTipIcon.Info;
                    Notification.BalloonTipText = $"There are {NumberLowItems} items running low or out of stock, click for more information.";
                    Notification.BalloonTipTitle = "Stock Warning";
                    Notification.ShowBalloonTip(30000);
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
    }
}
