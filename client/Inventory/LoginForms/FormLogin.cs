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

        private bool ValidLogin(string username, string password)
        {
            var regex = new Regex(@"^[a-zA-Z0-9- _ = + ! @ # $ % ^ & * ( )]*$"); // checks if a string only has legal characters (unlike emojis)

            if (username.Length < 4 || password.Length < 8)
            {
                MessageBox.Show("Incorrect Credentials", "Error");
                return false;
            }

            if (!regex.IsMatch(username) || !regex.IsMatch(password))
            {
                MessageBox.Show("Incorrect Credentials", "Error");
                return false;
            }

            return true;
        }

        private async Task Login(string username, string password)
        {
            if (ValidLogin(username, password))
            {
                try
                {
                    using HttpClient client = new HttpClient();
                    HttpRequestMessage request =
                        new HttpRequestMessage(HttpMethod.Post, Classes.Logon.UriPath + "login");
                    request.Headers.Add("user", username);
                    request.Headers.Add("pass", Classes.Hashing.GenerateHash(password, username));
                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        Classes.Logon.CurrentUser = username; // remembers logged-in user's username
                        request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "access_level");
                        request.Headers.Add("user", username); // get access level of user
                        response = await client.SendAsync(request);

                        var json = await response.Content.ReadAsStringAsync();

                        switch (json)
                        {
                            case "0":
                                Classes.Logon.AccessLevel = "Admin";
                                new FormAccountCreate().Show();
                                break;
                            case "1":
                                Classes.Logon.AccessLevel = "Manager";
                                new ProgramForms.FormDashboard().Show();
                                break;
                            case "2":
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
                        MessageBox.Show("Incorrect Credentials", "Error");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Server Connection Failed\n" + e.Message, "Error");
                }
            }
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            await Login(TextBoxUsername.Text, TextBoxPassword.Text);
            TextBoxUsername.Clear();
            TextBoxPassword.Clear();
        }

        private void LinkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.Password = LinkShowPassword.Checked == false; // this hides the password for security
        }

        private void LinkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;                                       // only gets rid of the login window if there is still a connection
            new FormAccountReset().Show();                                // shows the reset password prompt
            TextBoxUsername.Clear();                                        // clears all typed characters
            TextBoxPassword.Clear();
        }

        private async void TextBoxUsername_KeyDown(object sender, KeyEventArgs e) // allows the enter button to be pressed to log in the user
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;

            await Login(TextBoxUsername.Text, TextBoxPassword.Text);
            TextBoxUsername.Clear();                                        // clears all typed characters
            TextBoxPassword.Clear();

            e.Handled = true;
        }

        private async void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                await Login(TextBoxUsername.Text, TextBoxPassword.Text);
                TextBoxUsername.Clear();                                        // clears all typed characters
                TextBoxPassword.Clear();

                e.Handled = true;
            }
        }

        private void LinkShowPassword_KeyDown(object sender, KeyEventArgs e) // allows the enter button to be pressed to enable the password hide
        {
            if (e.KeyCode == Keys.Enter)
            {
                LinkShowPassword.Checked = LinkShowPassword.Checked == false;
                e.Handled = true;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Clear();                                        // clears all typed characters
            TextBoxPassword.Clear();
            TextBoxUsername.Focus();
        }

        private void FormLogin_Load(object sender, EventArgs e)
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

        private void StockTimer_Tick(object sender, EventArgs e)
        {
            _notification.CheckForLowStock(StockNotification);
            StockTimer.Stop();
        }

        private void StockNotification_BalloonTipClicked(object sender, EventArgs e)
        {
            if (Classes.Logon.AccessLevel == "Manager")
            {
                new ProgramForms.FormRestock().Show();
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name != "RestockForm")
                    {
                        form.WindowState = FormWindowState.Minimized;                    // minimises all windows, so you can focus on the restocking form
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}