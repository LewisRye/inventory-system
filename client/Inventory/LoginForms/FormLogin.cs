namespace Inventory.LoginForms
{
    public partial class FormLogin : Form
    {
        private readonly Classes.Settings _settings = new Classes.Settings();
        private readonly Classes.Notification _notification = new Classes.Notification();

        public FormLogin()
        {
            InitializeComponent();
        }

        private bool ValidLogin(string Username, string Password)
        {
            var containsLegalChars = new Regex(@"^[a-zA-Z0-9- _ = + ! @ # $ % ^ & * ( )]*$");                     // checks if a string has all legal characters (unlike emojis)

            if (Username.Length < 4 || Password.Length < 8)
            {
                MessageBox.Show("Details are incorrect.", "Error");
                return false;
            }

            else if (!containsLegalChars.IsMatch(Username) || !containsLegalChars.IsMatch(Password))
            {
                MessageBox.Show("Invalid characters were entered.", "Failed");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void Login(string Username, string Password)
        {
            if (Username.Equals("1") && Password.Equals("1")) // bypass the login for testing purposes
            {
                Classes.Logon.CurrentUser = "TestUser";
                Classes.Logon.AccessLevel = "Manager";
                new ProgramForms.FormDashboard().Show();
                return;
            }
            if (ValidLogin(Username, Password))
            {
                var databaseConn = new MySqlConnection(Classes.Logon.ConnectionString);

                try
                {
                    databaseConn.Open(); // opens connection with the database so it can be queried

                    string hashedInput = Hashing.GenerateHash(Password, Username); // hashes the user input to match the password hashes in database

                    string query = "SELECT Account.level_id FROM Account WHERE username = @user AND passhash = @pass GROUP BY Account.level_id;";

                    var command = new MySqlCommand(query, databaseConn);
                    command.Parameters.AddWithValue("@user", Username); // changes @user in the query to match username input
                    command.Parameters.AddWithValue("@pass", hashedInput); // these parameters prevent SQL injection

                    var da = new MySqlDataAdapter(command); // executes the SQL command
                    var dt = new DataTable(); // creates an instance of a table
                    da.Fill(dt);    // fills the table with the access level returned by SQL command

                    if (dt.Rows.Count > 0)
                    {
                        int AccessLevel = Convert.ToInt32(dt.Rows[0][0]);

                        switch (AccessLevel)
                        {
                            case 0:
                                Classes.Logon.CurrentUser = Username; // remembers logged in user's username
                                Classes.Logon.AccessLevel = "Admin";
                                new LoginForms.FormAccountCreate().Show();
                                break;
                            case 1:
                                Classes.Logon.CurrentUser = Username; // remembers logged in user's username
                                Classes.Logon.AccessLevel = "Manager";
                                new ProgramForms.FormDashboard().Show();
                                break;
                            case 2:
                                Classes.Logon.CurrentUser = Username; // remembers logged in user's username
                                Classes.Logon.AccessLevel = "Staff";
                                new ProgramForms.FormDashboard().Show();
                                break;
                        }

                        StockTimer.Interval = Classes.Logon.NotificationTime;
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
            TextBoxUsername.Clear();
            TextBoxPassword.Clear();
        }

        private void LinkShowPassword_CheckedChanged(object Sender, EventArgs E)
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
            new LoginForms.FormAccountReset().Show();                                // shows the reset password prompt
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

        private void LinkShowPassword_KeyDown(object Sender, KeyEventArgs E) // allows the enter button to be pressed to enable the password hide
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
            TextBoxUsername.Focus();
        }

        private void FormLogin_Load(object Sender, EventArgs E)
        {
            _settings.LoadSettings();

            // setting the colour scheme

            var materialSkinManager = MaterialSkinManager.Instance;

            switch (Classes.Logon.ColourScheme)
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
            StockTimer.Stop();
        }

        private void StockNotification_BalloonTipClicked(object Sender, EventArgs E)
        {
            if (Classes.Logon.AccessLevel == "Manager")
            {
                new ProgramForms.FormRestock().Show();
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
            Environment.Exit(0);
        }
    }
}