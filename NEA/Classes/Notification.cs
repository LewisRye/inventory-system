using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace NEA
{
    internal class Notification
    {
        /*
         *  Contents
         */

        //  -handles notifications

        private protected readonly string ConnStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        private protected int NumberLowItems { get; set; }

        public void CheckForLowStock(NotifyIcon Notification)
        {
            var databaseConnection = new SqlConnection(ConnStr); // directs code to location of my database

            try
            {
                databaseConnection.Open();

                var sda = new SqlDataAdapter($@"SELECT COUNT(ProductID) 
                    FROM Product 
                    WHERE NumberInStock < {Logon.NotificationStock}", databaseConnection); // SQL query for user defined critical stock level
                var dt = new DataTable();
                sda.Fill(dt);
                NumberLowItems = Convert.ToInt32(dt.Rows[0][0]);
                databaseConnection.Close();

                if (dt.Rows.Count > 0) // if table has any rows, there is a low stock item
                {
                    Notification.BalloonTipText = $"There are {NumberLowItems} items running out of stock, click for more information.";
                    Notification.Visible = true; // shows a Windows notification to the user
                    Notification.ShowBalloonTip(30000);
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
    }
}
