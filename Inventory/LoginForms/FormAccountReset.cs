namespace Inventory.LoginForms
{
    public partial class FormAccountReset : Form
    {
        public FormAccountReset()
        {
            InitializeComponent();
        }

        private void ResetPassword(string Username, string Address, string NewPassword)
        {
            if (Hashing.ValidPassword(NewPassword))
            {
                int userExists = 0;
                var databaseConnection = new MySqlConnection(Classes.Logon.ConnectionString);

                try
                {
                    databaseConnection.Open();                                                                          // opens connection with the database so it can be queried
                    string resetQuery = @"SELECT COUNT(staff_id) FROM Staff, Account WHERE account.username = @user 
                                        AND staff.staff_address = @address";
                    var command = new MySqlCommand(resetQuery, databaseConnection);
                    command.Parameters.AddWithValue("@user", Username);                                    // changes @user in the query to match username input
                    command.Parameters.AddWithValue("@address", Address);                                       // these parameters prevent SQL injection
                    var da = new MySqlDataAdapter(command);                                                               // executes the SQL command
                    var dt = new DataTable();                                                                           // creates an instance of a table
                    da.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        userExists++;
                    }

                    if (userExists > 0)
                    {
                        string hashedInput = Hashing.GenerateHash(NewPassword, Username);

                        string updateCommand = @"UPDATE Account SET PasswordHash = @hash 
                                            WHERE Username = @user;";
                        var changePwd = new MySqlCommand(updateCommand, databaseConnection);
                        changePwd.Parameters.AddWithValue("@user", Username);                               // changes @user in the query to match username input
                        changePwd.Parameters.AddWithValue("@hash", hashedInput);                            // changes @password in the query to match password input
                        changePwd.ExecuteNonQuery();
                        MessageBox.Show("Password has been successfully changed", "Success");
                        Classes.Logon.PasswordChanged = true;
                    }

                    else
                    {
                        MessageBox.Show("Account does not exist...", "Error");
                    }

                    databaseConnection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Unable to connect to database. " + ex.Message, "Error");
                }
            }
        }

        private void ButtonResetPwd_Click(object Sender, EventArgs E)
        {
            if (TextBoxUsername.Text.Length > 0                                          // ensures all fields have been entered correctly
                && TextBoxAddress.Text.Length > 0
                && TextBoxPassword.Text.Length > 7)
            {
                ResetPassword(TextBoxUsername.Text, TextBoxAddress.Text, TextBoxPassword.Text);
            }

            else
            {
                MessageBox.Show("Not all fields have been entered correctly...", "Error");
            }

            if (Classes.Logon.PasswordChanged)
            {
                foreach (Form var in Application.OpenForms)
                {
                    if (var.Name == "LoginForm")
                    {
                        var.Visible = true;
                    }
                }
                this.Hide();
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void TextBoxPassword_TextChanged(object Sender, EventArgs E)
        {
            //ToolTip.SetToolTip(TextBoxPassword, "Passwords must be: \n • at least 8 characters \n" +
            //"And contain: \n • at least 1 lowercase \n • at least 1 uppercase \n • at least 1 number");

            if (TextBoxPassword.Text.Length > 0)
            {
                double newPwdStrength = (TextBoxPassword.Text.Length * 4);

                int numberOfSpecials = Regex.Matches(TextBoxPassword.Text, "[- _ = + ! @ # $ % ^ & * ( ) £]").Count;
                newPwdStrength += (numberOfSpecials * numberOfSpecials) * 1.7;          // number of specials squared, means more specials dramatically improve strength

                int numberOfCapitals = Regex.Matches(TextBoxPassword.Text, "[A-Z]").Count;
                newPwdStrength += (numberOfCapitals * numberOfCapitals) * 1.7;          // number of capitals squared, means more capitals dramatically improve strength

                int numberOfNumbers = Regex.Matches(TextBoxPassword.Text, "[0-9]").Count;
                newPwdStrength += (numberOfNumbers * numberOfNumbers) * 1.7;          // number of numbers squared, means more capitals dramatically improve strength

                if (newPwdStrength > 100)
                {
                    newPwdStrength = 100;                                             // ensures the value never goes above 100%
                }

                ValuePwdStrength.Text = newPwdStrength.ToString() + "%";              // displays password strength % in the text box
                ValuePwdStrength.ForeColor = Color.Red;

                BarPwdStrength.Value = Convert.ToInt16(newPwdStrength);                  // adds strength bar for visual indication of strength

                if (newPwdStrength > 33)
                {
                    ValuePwdStrength.ForeColor = Color.OrangeRed;
                }
                if (newPwdStrength > 40)
                {
                    ValuePwdStrength.ForeColor = Color.SandyBrown;
                }
                if (newPwdStrength > 65)
                {
                    ValuePwdStrength.ForeColor = Color.YellowGreen;
                }
                if (newPwdStrength > 80)
                {
                    ValuePwdStrength.ForeColor = Color.Green;
                }
            }
            else
            {
                ValuePwdStrength.Text = "0%";
            }
        }

        private void ButtonReturnLogin_Click(object Sender, EventArgs E)
        {
            foreach (Form var in Application.OpenForms)
            {
                if (var.Name == "FormLogin")
                {
                    var.Visible = true;
                }
            }
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PasswordBox_KeyDown(object Sender, KeyEventArgs E)
        {
            if (E.KeyCode == Keys.Enter)
            {
                if (TextBoxPassword.Text.Length != 0)
                {
                    if (TextBoxUsername.Text.Length > 0 && TextBoxAddress.Text.Length > 0 && TextBoxPassword.Text.Length > 7)
                    {
                        ResetPassword(TextBoxUsername.Text, TextBoxAddress.Text, TextBoxPassword.Text);
                    }
                    else
                    {
                        MessageBox.Show("Not all fields have been entered correctly...", "Error");
                    }

                    if (Classes.Logon.PasswordChanged)
                    {
                        foreach (Form var in Application.OpenForms)
                        {
                            if (var.Name == "LoginForm")
                            {
                                var.Show();
                            }
                        }
                        this.Hide();
                        this.Close();
                        this.Dispose();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                }
                E.SuppressKeyPress = true;
                E.Handled = true;
            }
        }
    }
}