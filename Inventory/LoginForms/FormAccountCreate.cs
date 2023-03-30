namespace Inventory.LoginForms
{
    public partial class FormAccountCreate : Form
    {
        private readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public FormAccountCreate()
        {
            InitializeComponent();

            var databaseConn = new MySqlConnection(_connStr);
            databaseConn.Open();                                                        // connects to database and reads it

            var cmd = new MySqlCommand("SELECT level_id, level_name FROM AccessLevel;", databaseConn); // uses SQL query to read data
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ComboBoxAccessLevel.Items.Add($"{dr["level_id"]}: {dr["level_name"]}");               // populates the list from the SQL query
            }
            databaseConn.Close();
        }

        public int RandomNumber()
        {
            return new Random().Next(1000, 9999);
        }

        public bool CheckRequirements(string Username, string Password)
        {
            var contains4Characters = new Regex(@".{4,}"); // checks if a string has 8 characters
            var contains8Characters = new Regex(@".{8,}"); // checks if a string has 8 characters
            var containsUpperCase = new Regex(@"[A-Z]+"); // checks if a string has an upper case char
            var containsLowerCase = new Regex(@"[a-z]+"); // checks if a string has a lower case char
            var containsNumber = new Regex(@"[0-9]+"); // checks if a string has a number
            var containsLegalChars = new Regex(@"^[a-zA-Z0-9- _ = + ! @ # $ % ^ & * ( )]*$"); // checks if a string has all legal characters

            if (contains4Characters.IsMatch(Username)
                        && contains8Characters.IsMatch(Password)
                        && containsUpperCase.IsMatch(Password)
                        && containsLowerCase.IsMatch(Password)
                        && containsNumber.IsMatch(Password))
            {
                if (containsLegalChars.IsMatch(Password))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid characters detected...", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username or Password does not meet criteria...", "Error");
                return false;
            }
        }

        public void CreateAccount(string FirstName, string LastName, string Address, int AccessLevel, string Username, string Password)
        {
            string hashedInput = Hashing.GenerateHash(Password, Username);
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open();

                int newAccountId = 0;
                bool unique = false;

                while (!unique)
                {
                    newAccountId = RandomNumber(); // creating a new Account requires an AccountID

                    var cmd = new MySqlCommand(@"SELECT COUNT(account_id) FROM Account WHERE account_id = @ID ORDER BY account_id DESC; ", databaseConn);
                    cmd.Parameters.AddWithValue("@ID", newAccountId);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read()) // finds an ID suitable for the new account
                    {
                        if (Convert.ToInt32(reader[0]) == 0)
                        {
                            unique = true;
                        }
                    }
                }

                databaseConn.Close();
                databaseConn.Open();

                var insertAccountCmd = new MySqlCommand("INSERT INTO Account VALUES(@AccountID, @User, @PassHash, @AccessLevelID); ", databaseConn);

                insertAccountCmd.Parameters.AddWithValue("@AccountID", newAccountId);
                insertAccountCmd.Parameters.AddWithValue("@User", Username);
                insertAccountCmd.Parameters.AddWithValue("@PassHash", hashedInput);
                insertAccountCmd.Parameters.AddWithValue("@AccessLevelID", AccessLevel);

                var insertStaffCmd = new MySqlCommand(@"INSERT INTO Staff VALUES(@StaffID, @fname, @lname, @address, @AccountID); ", databaseConn);

                insertStaffCmd.Parameters.AddWithValue("@StaffID", newAccountId);
                insertStaffCmd.Parameters.AddWithValue("@fname", FirstName);
                insertStaffCmd.Parameters.AddWithValue("@lname", LastName);
                insertStaffCmd.Parameters.AddWithValue("@address", Address);
                insertStaffCmd.Parameters.AddWithValue("@AccountID", newAccountId);

                insertAccountCmd.ExecuteNonQuery(); // inserts the new account details
                insertStaffCmd.ExecuteNonQuery(); // inserts the new staff details

                databaseConn.Close();

                MessageBox.Show("Account successfully added", "Success");
                Logon.AccountCreated = true; // tells the Logon class that account has been created
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

        private void ButtonCreateUser_Click(object Sender, EventArgs E)
        {
            if (CheckRequirements(TextBoxUsername.Text, TextBoxPassword.Text))
            {
                CreateAccount(TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxAddress.Text, ComboBoxAccessLevel.SelectedIndex,
                    TextBoxUsername.Text, TextBoxPassword.Text);
            }

            if (Logon.AccountCreated)
            {
                foreach (Form var in Application.OpenForms)
                {
                    var.Visible = true;
                }
                this.Hide();
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void ButtonReturnLogin_Click(object Sender, EventArgs E)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Visible = true;
            }
            Logon.CurrentUser = "";
            Logon.AccessLevel = "";
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void TextBoxPassword_TextChanged(object Sender, EventArgs E)
        {
            ToolTip.SetToolTip(TextBoxPassword, "Passwords must be: \n • at least 8 characters \n" +
                                                "And contain: \n • at least 1 lowercase \n • at least 1 uppercase \n • at least 1 number");

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

        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            int Prefix = RandomNumber();
            TextBoxUsername.Text = TextBoxFirstName.Text + Prefix.ToString();
        }

        private void FormAccountCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
