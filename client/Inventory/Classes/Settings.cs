﻿namespace Inventory.Classes
{
    internal class Settings
    {
        /*
         *  Contents
         */

        //  -handles app settings, reads/writes to the settings.txt file

        public void LoadSettings()
        {
            if (File.Exists(Logon.FilePath))
            {
                try
                {
                    Logon.NotificationTime = Convert.ToInt32(File.ReadLines(Logon.FilePath).Skip(1).Take(1).First());    // reads the line where notification time is stored
                    Logon.NotificationStock = Convert.ToInt16(File.ReadLines(Logon.FilePath).Skip(3).Take(1).First());   // reads the line where notification time is stored
                    Logon.RecipientEmailAddress = File.ReadLines(Logon.FilePath).Skip(5).Take(1).First();                // reads the line where recipient email address is stored
                    Logon.ColourScheme = File.ReadLines(Logon.FilePath).Skip(7).Take(1).First();                         // reads the line where colour scheme is stored
                }
                catch (Exception)                                                                                   // detects if file has been corrupted
                {
                    MessageBox.Show("Your settings file has been corrupted, " +
                                    "a new settings file will be created...\n", "Error");
                    CreateFile();
                    Logon.NotificationTime = Convert.ToInt32(File.ReadLines(Logon.FilePath).Skip(1).Take(1).First());    // reads the line where notification time is stored
                    Logon.NotificationStock = Convert.ToInt16(File.ReadLines(Logon.FilePath).Skip(3).Take(1).First());   // reads the line where notification time is stored
                    Logon.RecipientEmailAddress = File.ReadLines(Logon.FilePath).Skip(5).Take(1).First();                // reads the line where recipient email address is stored
                    Logon.ColourScheme = File.ReadLines(Logon.FilePath).Skip(7).Take(1).First();                         // reads the line where colour scheme is stored
                }
            }
            else
            {
                MessageBox.Show("Welcome to the Inventory Management System.\n\n" +
                                "Because the app has never been opened before, " +
                                "a settings file has been created at:\n\n" +
                                Directory.GetCurrentDirectory() + "\\InventorySettings.txt\n\n" +
                                "Please ensure notifications are enabled on your device for optimal use.", "Welcome");                      // detects if the app has never been opened
                CreateFile();
                Logon.NotificationTime = Convert.ToInt32(File.ReadLines(Logon.FilePath).Skip(1).Take(1).First());        // reads the line where notification time is stored
                Logon.NotificationStock = Convert.ToInt16(File.ReadLines(Logon.FilePath).Skip(3).Take(1).First());       // reads the line where notification time is stored
                Logon.RecipientEmailAddress = File.ReadLines(Logon.FilePath).Skip(5).Take(1).First();                    // reads the line where recipient email address is stored
                Logon.ColourScheme = File.ReadLines(Logon.FilePath).Skip(7).Take(1).First();                             // reads the line where colour scheme is stored
            }
        }

        private void CreateFile()
        {
            try
            {
                using FileStream fs = File.Create(Logon.FilePath);
                byte[] fileContents = new UTF8Encoding(true).GetBytes(
                    "NotificationTime\n30000\n" +
                    "NotificationStock\n10\n" +
                    "RecipientEmailAddress\nexample@gmail.com\n" +
                    "ColourScheme\nGrey");
                fs.Write(fileContents, 0, fileContents.Length);                                     // writes the correct information to the new file
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void ChangeFileNotificationTime(int newNotificationTimeSeconds)
        {
            try
            {
                if (newNotificationTimeSeconds >= 20)
                {
                    int newNotificationTimeMilliseconds = newNotificationTimeSeconds * 1000;                        // converts time from seconds to milliseconds
                    string[] notificationLines = File.ReadAllLines(Logon.FilePath);
                    notificationLines[1] = Convert.ToString(newNotificationTimeMilliseconds);
                    File.WriteAllLines(Logon.FilePath, notificationLines);                                               // writes the new notification time to the settings file
                    MessageBox.Show("Notification time changed! Click restart to apply changes.", "Success");
                }
                else
                {
                    MessageBox.Show("Notifications must be at least 20 seconds apart.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void ChangeFileNotificationStock(int newNotificationStockLevel)
        {
            try
            {
                string[] notificationLines = File.ReadAllLines(Logon.FilePath);
                notificationLines[3] = Convert.ToString(newNotificationStockLevel);
                File.WriteAllLines(Logon.FilePath, notificationLines);                                                   // writes the new notification stock to the settings file
                MessageBox.Show("Notification time changed! Click restart to apply changes.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void ChangeFileEmail(string newRecipientEmailAddress)
        {
            try
            {
                string[] emailLines = File.ReadAllLines(Logon.FilePath);
                emailLines[5] = newRecipientEmailAddress;
                File.WriteAllLines(Logon.FilePath, emailLines);                                                      // writes the new email address to the settings file
                MessageBox.Show("Recipient email address changed! Click restart to apply changes.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void ChangeFileColour(string newColourScheme)
        {
            try
            {
                string[] colourLines = File.ReadAllLines(Logon.FilePath);
                colourLines[7] = newColourScheme;
                File.WriteAllLines(Logon.FilePath, colourLines);                                                         // writes the new colour scheme to the settings file
                MessageBox.Show("Colour scheme changed! Click restart to apply changes.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}