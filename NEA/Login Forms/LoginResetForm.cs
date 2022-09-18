using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NEA
{
    public partial class LoginResetForm : Form
    {
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["TechWorld"].ConnectionString;
        private bool _passwordValid;

        public LoginResetForm()
        {
            InitializeComponent();
        }

        private void CheckPasswordRequirements(string NewPassword)
        {
            var contains8Characters = new Regex(@".{8,}");                                                        // checks if a string has 8 characters
            var containsUpperCase = new Regex(@"[A-Z]+");                                                         // checks if a string has an upper case char
            var containsLowerCase = new Regex(@"[a-z]+");                                                         // checks if a string has a lower case char
            var containsNumber = new Regex(@"[0-9]+");                                                            // checks if a string has a number
            var containsLegalChars = new Regex(@"^[a-zA-Z0-9- _ = + ! @ # $ % ^ & * ( )]*$");                     // checks if a string has all legal characters (unlike emojis)

            if (contains8Characters.IsMatch(NewPassword)
                && containsUpperCase.IsMatch(NewPassword)
                && containsLowerCase.IsMatch(NewPassword)
                && containsNumber.IsMatch(NewPassword))
            {
                if (!containsLegalChars.IsMatch(NewPassword))
                {
                    MessageBox.Show("Invalid characters detected...", "Error");
                }
                else
                {
                    _passwordValid = true;
                }
            }
            else
            {
                MessageBox.Show("Password does not meet criteria...", "Error");
            }
        }

        private void ResetPassword(string Username, long Phone, string NewPassword)
        {
            CheckPasswordRequirements(NewPassword);

            if (_passwordValid)
            {
                int userExists = 0;
                var databaseConnection = new SqlConnection(_connStr);

                try
                {
                    databaseConnection.Open();                                                                          // opens connection with the database so it can be queried
                    string resetQuery = @"SELECT COUNT(*) FROM Staff WHERE StaffFirstName = @fname 
                                            AND StaffPhone = @phone";
                    var command = new SqlCommand(resetQuery, databaseConnection);
                    command.Parameters.AddWithValue("@fname", Username);                                    // changes @user in the query to match username input
                    command.Parameters.AddWithValue("@phone", Phone);                                       // these parameters prevent SQL injection
                    var da = new SqlDataAdapter(command);                                                               // executes the SQL command
                    var dt = new DataTable();                                                                           // creates an instance of a table
                    da.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        userExists++;
                    }

                    if (userExists > 0)
                    {
                        string hashedInput = new Hashing().EncryptText(NewPassword);

                        string updateCommand = @"UPDATE Account SET PasswordHash = @hash 
                                                WHERE Username = @user;";
                        var changePwd = new SqlCommand(updateCommand, databaseConnection);
                        changePwd.Parameters.AddWithValue("@user", Username);                               // changes @user in the query to match username input
                        changePwd.Parameters.AddWithValue("@hash", hashedInput);                            // changes @password in the query to match password input
                        changePwd.ExecuteNonQuery();
                        MessageBox.Show("Password has been successfully changed", "Success");
                        Logon.PasswordChanged = true;
                    }

                    else
                    {
                        MessageBox.Show("Account does not exist...", "Error");
                    }

                    databaseConnection.Close();
                }
                catch (SqlException)
                {
                    new LoginDisconnectForm().Show();
                }
            }
        }

        private void ResetForm_Load(object Sender, EventArgs E)
        {
            
        }

        private void ResetButton_Click(object Sender, EventArgs E)
        {
            if(TextBoxUsername.Text.Length > 0                                          // ensures all fields have been entered correctly
                && TextBoxPhoneNumber.Text.Length > 10
                && TextBoxPassword.Text.Length > 7)
            {
                ResetPassword(TextBoxUsername.Text, Convert.ToInt64(TextBoxPhoneNumber.Text), TextBoxPassword.Text);
            }

            else
            {
                MessageBox.Show("Not all fields have been entered correctly...", "Error");
            }

            if (Logon.PasswordChanged)
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

        private void PhoneBox_TextChanged(object Sender, EventArgs E)
        {
            if (Regex.IsMatch(TextBoxPhoneNumber.Text, "[^0-9]"))                             // ensures only numbers have been entered
            {
                ToolTip.SetToolTip(TextBoxPhoneNumber, "Only numbers from 0-9 are allowed to be entered...");
                TextBoxPhoneNumber.Text = TextBoxPhoneNumber.Text.Remove(TextBoxPhoneNumber.Text.Length - 1);
            }
        }

        private void PasswordBox_TextChanged(object Sender, EventArgs E)
        {
            ToolTip.SetToolTip(TextBoxPassword, "Passwords must be: \n • at least 8 characters \n" + 
                                                "And contain: \n • at least 1 lowercase \n • at least 1 uppercase \n • at least 1 number");

            if (TextBoxPassword.Text.Length > 0)
            {
                double newPwdStrength = (TextBoxPassword.Text.Length * 4);

                int numberOfSpecials = Regex.Matches(TextBoxPassword.Text, "[- _ = + ! @ # $ % ^ & * ( ) £]").Count;
                newPwdStrength += (numberOfSpecials*numberOfSpecials) * 1.7;          // number of specials squared, means more specials dramatically improve strength

                int numberOfCapitals = Regex.Matches(TextBoxPassword.Text, "[A-Z]").Count;
                newPwdStrength += (numberOfCapitals*numberOfCapitals) * 1.7;          // number of capitals squared, means more capitals dramatically improve strength

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

        private void ReturnLoginButton_Click(object Sender, EventArgs E)
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

        private void PasswordBox_KeyDown(object Sender, KeyEventArgs E)
        {
            if (E.KeyCode == Keys.Enter)
            {
                if(TextBoxPassword.Text.Length != 0)
                {
                    if (TextBoxUsername.Text.Length > 0 
                        && TextBoxPhoneNumber.Text.Length > 10 
                        && TextBoxPassword.Text.Length > 7)
                    {
                        ResetPassword(TextBoxUsername.Text, Convert.ToInt64(TextBoxPhoneNumber.Text), TextBoxPassword.Text);
                    }
                    else
                    {
                        MessageBox.Show("Not all fields have been entered correctly...", "Error");
                    }

                    if (Logon.PasswordChanged)
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
