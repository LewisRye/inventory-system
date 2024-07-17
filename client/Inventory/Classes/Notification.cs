namespace Inventory.Classes
{
    internal class Notification
    {
        /*
         *  Contents
         */

        // -handles notifications 
        // THE ENTIRE FORM REQUIRES A REFACTOR TO THE API

        private MySqlConnection _databaseConnection = new MySqlConnection(Logon.ConnectionString); // directs code to location of my database
        private protected int NumberLowItems = 0;

        public void CheckForLowStock(NotifyIcon notification)
        {
            try
            {
                _databaseConnection.Open();

                var sda = new MySqlDataAdapter($@"SELECT COUNT(product_id) 
                    FROM Product 
                    WHERE number_in_stock <= {Logon.NotificationStock}", _databaseConnection); // SQL query for user defined critical stock level
                var dt = new DataTable();
                sda.Fill(dt);
                NumberLowItems = Convert.ToInt32(dt.Rows[0][0]);
                _databaseConnection.Close();

                if (dt.Rows.Count > 0) // if table has any rows, there is a low stock item
                {
                    notification.BalloonTipIcon = ToolTipIcon.Info;
                    notification.BalloonTipText = $"There are {NumberLowItems} items running low or out of stock, click for more information.";
                    notification.BalloonTipTitle = "Stock Warning";
                    notification.ShowBalloonTip(30000);
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
