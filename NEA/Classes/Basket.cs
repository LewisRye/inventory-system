using System;
using System.Configuration;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NEA
{
    internal class Basket
    {
        /*
         *  Contents
         */

        //  -takes items ordered, and adds them to a basket

        private protected readonly string ConnStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;      // gets the database connection string

        public void CreateBasket(List<string> ListOfItems, List<double> ListOfPrices, List<int> ListOfQuantity)
        {
            int totalItemsInBasket = ListOfItems.Count;                                                                     // allows the correct array size

            try
            {
                string[,] basket = new string[totalItemsInBasket, 3];                                                       // creates a 2D array to contain all basket information

                for (int i = 0; i < totalItemsInBasket; i++)
                {
                    basket[i, 0] = ListOfItems[i];                                                                          // adds individual item name to basket
                    basket[i, 1] = ListOfPrices[i].ToString();                                                              // adds individual item's price to basket
                    basket[i, 2] = ListOfQuantity[i].ToString();                                                            // adds quantity of item to basket
                    
                    InsertStockToProductDb(Convert.ToInt32(basket[i, 2]), basket[i, 0]);                            // uses function to insert these items into the database
                }

                CreateEmailReceipt(basket);                                                                      // uses function to create and send email receipt
            }
            catch (SqlException)
            {
                MessageBox.Show("The database could not be updated.", "Error");
            }
            catch (SmtpException)
            {
                MessageBox.Show("The email could not be sent, but the database updated successfully.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"An unknown error occured.
                {ex.Message}", "Error");
            }
        }

        private void InsertStockToProductDb(int Quantity, string ProductName)
        {
            var databaseConnection = new SqlConnection(ConnStr);

            databaseConnection.Open();

            string updateCommand = $@"UPDATE Product SET NumberInStock = NumberInStock + 
                                   {Quantity} WHERE ProductName = '{ProductName}';";
            var cmdUpdate = new SqlCommand(updateCommand, databaseConnection);                                              // forms an SQL command to change stock values
            
            cmdUpdate.ExecuteNonQuery();                                                                                    // changes stock value then closes connection
            
            databaseConnection.Close();
        }

        private void CreateEmailReceipt(string[,] Basket)
        {
            string recipient = Logon.RecipientEmailAddress; // gets the recipient email address from settings
            string emailText = "";
            double totalPrice = 0; 

            for (int i = 0; i < Basket.GetLength(0); i++) // adds entire basket to the email body
            {
                int quantity = Convert.ToInt32(Basket[i, 2]);
                string itemName = Basket[i, 0];
                double priceExact = Convert.ToDouble(Basket[i, 1]);
                string priceTo2DP = priceExact.ToString("0.00"); // ensures the price is in the correct format

                emailText += $"({quantity}x) {itemName}: £{priceTo2DP}\n"; // formats a line of the email contents
            }

            for (int i = 0; i < Basket.GetLength(0); i++)
            {
                totalPrice += Convert.ToDouble(Basket[i, 1]); // finds total price of the order
            }

            string totalPriceTo2DP = totalPrice.ToString("0.00"); // puts the total price in correct money format

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
                "Lewis Rye lewiscstest@gmail.com", // sender's name and email address
                recipient, // recipient's email address
                "Restocking Invoice", // email subject
                "You ordered:\n\n" +
                emailText + "\n\nThis order has been successfully delivered!"
            );

            smtpClient.Send(message);

            MessageBox.Show("Your order of:\n\n" + emailText + "\nHas completed, for a total price of £" +
                            totalPriceTo2DP + "\n-An email has been sent to confirm this.",
                            "Order Complete");
        }
    }
}
