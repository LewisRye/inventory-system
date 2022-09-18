using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using MaterialSkin;

namespace NEA
{
    public partial class FormLogin : Form
    {
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        private readonly Settings _settings = new Settings();
        private readonly Notification _notification = new Notification();
        private bool _passwordValid;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void CheckLoginRequirements(string Username, string Password)
        {
            var containsLegalChars = new Regex(@"^[a-zA-Z0-9- _ = + ! @ # $ % ^ & * ( )]*$");                     // checks if a string has all legal characters (unlike emojis)

            if (Username.Length < 3 || Password.Length < 8)
            {
                MessageBox.Show("Details are incorrect.", "Error");
            }

            else if (!containsLegalChars.IsMatch(Username) || !containsLegalChars.IsMatch(Password))
            {
                MessageBox.Show("Illegal characters were entered.", "Failed");
            }

            else
            {
                _passwordValid = true;
            }
        }

        private void Login(string Username, string Password)
        {
            CheckLoginRequirements(Username, Password);

            if (_passwordValid)
            {
                var databaseConn = new SqlConnection(_connStr);

                try
                {
                    databaseConn.Open(); // opens connection with the database so it can be queried

                    string hashedInput =
                        new Hashing().GenerateHash(Password, Username); // hashes the user input to match the password hashes in database

                    string query = @"SELECT AccessLevelID FROM Account WHERE Username = @user
                                AND PasswordHash = @pass";

                    var command = new SqlCommand(query, databaseConn);
                    command.Parameters.AddWithValue("@user", Username); // changes @user in the query to match username input
                    command.Parameters.AddWithValue("@pass", hashedInput); // these parameters prevent SQL injection

                    var da = new SqlDataAdapter(command); // executes the SQL command
                    var dt = new DataTable(); // creates an instance of a table
                    da.Fill(dt);    // fills the table with the access level returned by SQL command

                    if (dt.Rows.Count > 0)
                    {
                        int userAccessLevel = Convert.ToInt32(dt.Rows[0][0]); // AccessLevelID is returned, so read the returned value

                        switch (userAccessLevel)
                        {
                            case 0:
                                Logon.CurrentUser = Username; // remembers logged in user's username
                                Logon.AccessLevel = "Admin";
                                new FormAccountCreate().Show();
                                break;
                            case 1:
                                Logon.CurrentUser = Username; // remembers logged in user's username
                                Logon.AccessLevel = "Manager";
                                new FormDashboard().Show();
                                break;
                            case 2:
                                Logon.CurrentUser = Username; // remembers logged in user's username
                                Logon.AccessLevel = "Staff";
                                new FormDashboard().Show();
                                break;
                        }

                        StockTimer.Interval = Logon.NotificationTime;
                        StockTimer.Start();

                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Details are incorrect.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void ButtonLogin_Click(object Sender, EventArgs E)
        {
            Login(TextBoxUsername.Text, TextBoxPassword.Text);
            TextBoxUsername.Clear();                                        // clears all typed characters
            TextBoxPassword.Clear();
        }

        private void ShowPassword_CheckedChanged(object Sender, EventArgs E)
        {
            if (LinkShowPassword.Checked)
            {
                TextBoxPassword.Password = false;
            }
            else
            {
                TextBoxPassword.Password = true;               // this hides the password for security
            }
        }

        private void LinkReset_LinkClicked(object Sender, LinkLabelLinkClickedEventArgs E)
        {
            this.Visible = false;                                       // only gets rid of the login window if there is still a connection
            new FormAccountReset().Show();                                // shows the reset password prompt
            TextBoxUsername.Clear();                                        // clears all typed characters
            TextBoxPassword.Clear();
        }

        private void TextBoxUsername_KeyDown(object Sender, KeyEventArgs E) // allows the enter button to be pressed to log in the user
        {
            if (E.KeyCode == Keys.Enter)
            {
                E.SuppressKeyPress = true; 

                Login(TextBoxUsername.Text, TextBoxPassword.Text);
                TextBoxUsername.Clear();                                        // clears all typed characters
                TextBoxPassword.Clear();

                E.Handled = true;
            }
        }

        private void TextBoxPassword_KeyDown(object Sender, KeyEventArgs E)
        {
            if (E.KeyCode == Keys.Enter)
            {
                E.SuppressKeyPress = true;

                Login(TextBoxUsername.Text, TextBoxPassword.Text);
                TextBoxUsername.Clear();                                        // clears all typed characters
                TextBoxPassword.Clear();

                E.Handled = true;
            }
        }

        private void LinkShowPassword_KeyDown(object Sender, KeyEventArgs E)// allows the enter button to be pressed to enable the password hide
        {
            if (E.KeyCode == Keys.Enter)
            {
                if (LinkShowPassword.Checked == false)
                {
                    LinkShowPassword.Checked = true;
                }
                else
                {
                    LinkShowPassword.Checked = false;
                }
                E.Handled = true;
            }
        }

        private void ButtonClear_Click(object Sender, EventArgs E)
        {
            TextBoxUsername.Clear();                                        // clears all typed characters
            TextBoxPassword.Clear();
        }

        private void LoginForm_Load(object Sender, EventArgs E)
        {
            _settings.LoadSettings();

            // setting the colour scheme

            var materialSkinManager = MaterialSkinManager.Instance;

            switch (Logon.ColourScheme)
            {
                case "Red":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Red200, TextShade.WHITE);
                    break;
                case "Green":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green200, TextShade.WHITE);
                    break;
                case "Indigo":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Indigo200, TextShade.WHITE);
                    break;
                case "Grey":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey600, Primary.Grey100, Accent.Orange100, TextShade.WHITE);
                    break;
            }
        }

        private void StockTimer_Tick(object Sender, EventArgs E)
        {
            _notification.CheckForLowStock(StockNotification);
        }

        private void StockNotification_BalloonTipClicked(object Sender, EventArgs E)
        {
            if (Logon.AccessLevel == "Manager")
            {
                new FormRestock().Show();
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name != "RestockForm")
                    {
                        form.WindowState = FormWindowState.Minimized;                    // minimises all windows so you can focus on the restocking form
                    }
                }
            }
            else
            {
                MessageBox.Show("Please contact the manager, item(s) are running out of stock...", "Notification");
                foreach (Form var in Application.OpenForms)
                {
                    var.WindowState = FormWindowState.Normal;
                }
            }

            StockTimer.Stop();
        }

        private void ButtonExit_Click(object Sender, EventArgs E)
        {
            Environment.Exit(0);                                        // closes app
        }

        private void LoginForm_FormClosing(object Sender, FormClosingEventArgs E)
        {
        }

        private void StockNotification_MouseDoubleClick(object Sender, MouseEventArgs E)
        {

        }
    }
}