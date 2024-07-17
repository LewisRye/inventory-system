using System.Globalization;

namespace Inventory.Classes
{
    internal class Basket
    {
        /*
         *  Contents
         */

        //  -takes items ordered, and adds them to a basket

        public void CreateBasket(List<string> listOfItems, List<double> listOfPrices, List<int> listOfQuantity)
        {
            int totalItemsInBasket = listOfItems.Count;                                                                     // allows the correct array size

            try
            {
                string[,] basket = new string[totalItemsInBasket, 3];                                                       // creates a 2D array to contain all basket information

                for (int i = 0; i < totalItemsInBasket; i++)
                {
                    basket[i, 0] = listOfItems[i];                                                                          // adds individual item name to basket
                    basket[i, 1] = listOfPrices[i].ToString();                                                              // adds individual item's price to basket
                    basket[i, 2] = listOfQuantity[i].ToString();                                                            // adds quantity of item to basket

                    InsertStockToProductDb(Convert.ToInt32(basket[i, 2]), basket[i, 0]);                            // uses function to insert these items into the database
                }

                // CreateEmailReceipt(basket);                                                                      // uses function to create and send email receipt
            }
            catch (MySqlException)
            {
                MessageBox.Show("The database could not be updated.", "Error");
            }
            catch (SmtpException)
            {
                MessageBox.Show("The email could not be sent.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unknown error occured.\n{ex.Message}", "Error");
            }
        }

        private void InsertStockToProductDb(int quantity, string productName)
        {
            var databaseConnection = new MySqlConnection(Classes.Logon.ConnectionString);

            databaseConnection.Open();

            var updateCommand = $@"UPDATE Product SET Number_In_Stock = Number_In_Stock + 
                                   {quantity} WHERE Product_Name = '{productName}';";
            var cmdUpdate = new MySqlCommand(updateCommand, databaseConnection);                                              // forms an SQL command to change stock values

            cmdUpdate.ExecuteNonQuery();                                                                                    // changes stock value then closes connection

            databaseConnection.Close();
        }

        private void CreateEmailReceipt(string[,] basket)
        {
            string recipient = Classes.Logon.RecipientEmailAddress; // gets the recipient email address from settings
            string emailText = "";
            double totalPrice = 0;

            for (int i = 0; i < basket.GetLength(0); i++) // adds entire basket to the email body
            {
                int quantity = Convert.ToInt32(basket[i, 2]);
                string itemName = basket[i, 0];
                double priceExact = Convert.ToDouble(basket[i, 1]);
                string priceTo2Dp = priceExact.ToString("0.00"); // ensures the price is in the correct format

                emailText += $"({quantity}x) {itemName}: £{priceTo2Dp}\n"; // formats a line of the email contents
            }

            for (int i = 0; i < basket.GetLength(0); i++)
            {
                totalPrice += Convert.ToDouble(basket[i, 1]); // finds total price of the order
            }

            string totalPriceTo2Dp = totalPrice.ToString("0.00"); // puts the total price in correct money format

            // sending the email

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(
                                ConfigurationManager.AppSettings["EmailUsername"],
                                ConfigurationManager.AppSettings["EmailPassword"]
                                ), // email credentials are stored in configuration manager
                EnableSsl = true,
            };

            var message = new MailMessage
            (
                "{insert sender name} {insert email}@gmail.com", // sender's name and email address
                recipient, // recipient's email address
                "Restocking Invoice", // email subject
                "You ordered:\n\n" +
                emailText + "\n\nThis order has been successfully delivered!"
            );

            smtpClient.Send(message);

            MessageBox.Show("Your order of:\n\n" + emailText + "\nHas completed, for a total price of £" +
                            totalPriceTo2Dp + "\n-An email has been sent to confirm this.",
                            "Order Complete");
        }
    }
}
