﻿namespace Inventory.LoginForms
{
    public partial class FormAccountEdit : Form
    {
        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public FormAccountEdit()
        {
            InitializeComponent();
        }

        private void FormAccountEdit_Load(object sender, EventArgs e)
        {
            ListOfUsers.Items.Add("Select the user");

            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open();                                                        // connects to database and reads it

                var cmd = new MySqlCommand("SELECT username FROM Account", databaseConn); // uses SQL query to read data
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListOfUsers.Items.Add(dr["Username"].ToString());               // populates the list from the SQL query
                }
                ListOfUsers.SelectedIndex = 0;                                              // shows text 'select item to order'
                databaseConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            //

            ListOfAccessLevels.Items.Add("Select level");

            try
            {
                databaseConn.Open(); // connects to database and reads it

                var cmd = new MySqlCommand("SELECT level_name FROM AccessLevel", databaseConn); // uses SQL query to read data
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListOfAccessLevels.Items.Add(dr["level_name"].ToString()); // populates the list from the SQL query
                }
                ListOfAccessLevels.SelectedIndex = 0; // shows text 'select item to order'
                databaseConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ButtonApplyNewUsername_Click(object sender, EventArgs e)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    string selectedUser = ListOfUsers.SelectedItem.ToString();
                    string newUsername = TextBoxUsername.Text;
                    string editUserCommand = @"UPDATE Account SET username = @NewUsername WHERE username = @OldUsername;";
                    var cmd = new MySqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@OldUsername", selectedUser);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The username of '{selectedUser}' is now {newUsername}");
                }
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

        private void ButtonApplyFirstName_Click(object sender, EventArgs e)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    string selectedUser = ListOfUsers.SelectedText.ToString();

                    string getIdCommand = $"SELECT account_id FROM Account WHERE username = '{selectedUser}';";
                    int accountId = 0;
                    var command = new MySqlCommand();
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        accountId = Convert.ToInt32(dr["account_id"]);
                    }


                    string newFirstName = TextBoxFirstName.Text;
                    string editUserCommand = @"UPDATE Staff SET first_name = @NewFirstName WHERE account_id = @AccountID;";
                    var cmd = new MySqlCommand(editUserCommand, databaseConn);
                    cmd.Parameters.AddWithValue("@NewFirstName", newFirstName);
                    cmd.Parameters.AddWithValue("@AccountID", accountId);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The first name of '{ListOfUsers.SelectedItem}' is now {newFirstName}");
                }
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

        private void ButtonApplyLastName_Click(object sender, EventArgs e)
        {
            var databaseConn = new MySqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    string selectedUser = ListOfUsers.SelectedText.ToString();

                    string getIdCommand = $"SELECT account_id FROM Account WHERE username = '{selectedUser}';";
                    int accountId = 0;
                    var command = new MySqlCommand();
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        accountId = Convert.ToInt32(dr["account_id"]);
                    }


                    string newLastName = TextBoxLastName.Text;
                    string editUserCommand = @"UPDATE Staff SET last_name = @NewFirstName WHERE account_id = @AccountID;";
                    var cmd = new MySqlCommand(editUserCommand, databaseConn);
                    cmd.Parameters.AddWithValue("@NewFirstName", newLastName);
                    cmd.Parameters.AddWithValue("@AccountID", accountId);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The last name of '{ListOfUsers.SelectedItem}' is now {newLastName}");
                }
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

        private void ButtonApplyNewAddress_Click(object sender, EventArgs e)
        {
            var databaseConn = new MySqlConnection(_connStr);
            int accountId = 0;

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    string selectedUser = ListOfUsers.SelectedText.ToString();

                    string getIdCommand = $"SELECT account_id FROM Account WHERE username = '{selectedUser}';";
                    var command = new MySqlCommand(getIdCommand, databaseConn);
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        accountId = Convert.ToInt32(dr["account_id"]);
                    }
                    dr.Close();
                    databaseConn.Close();
                }

                databaseConn.Open();
                using (databaseConn)
                {
                    string newAddress = TextBoxAddress.Text;
                    string editUserCommand = @"UPDATE Staff SET staff_address = @NewAddress WHERE account_id = @AccountID;";
                    var cmd = new MySqlCommand(editUserCommand, databaseConn);
                    cmd.Parameters.AddWithValue("@NewAddress", newAddress);
                    cmd.Parameters.AddWithValue("@AccountID", accountId);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The address of '{ListOfUsers.SelectedItem}' is now {newAddress}");
                }
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

        private void ButtonApplyNewAccessLevel_Click(object sender, EventArgs e)
        {
            if (ListOfAccessLevels.SelectedIndex > 0)
            {
                var databaseConn = new MySqlConnection(_connStr);
                string selectedUser = ListOfUsers.SelectedItem.ToString();
                string selectedAccessLevel = ListOfAccessLevels.SelectedItem.ToString();
                int accountId = 0;

                try
                {
                    databaseConn.Open(); // opens connection with the database so it can be queried
                    using (databaseConn)
                    {
                        string getIdCommand = $"SELECT account_id FROM Account WHERE username = '{selectedUser}';";
                        var command = new MySqlCommand(getIdCommand, databaseConn);
                        MySqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            accountId = Convert.ToInt32(dr["account_id"]);
                        }
                        dr.Close();
                        databaseConn.Close();
                    }

                    databaseConn.Open();
                    using (databaseConn)
                    {
                        int newAccessLevel = ListOfAccessLevels.SelectedIndex - 1;
                        string editUserCommand = @"UPDATE Account SET level_id = @NewAccessLevel WHERE Account_ID = @AccountID;";
                        var cmd = new MySqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                        cmd.Parameters.AddWithValue("@NewAccessLevel", newAccessLevel);
                        cmd.Parameters.AddWithValue("@AccountID", accountId);
                        cmd.ExecuteNonQuery();

                        databaseConn.Close();

                        MessageBox.Show($"The access level of '{selectedUser}' is now {selectedAccessLevel}", "Success");
                    }
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
            else
            {
                MessageBox.Show("Please choose an access level.", "Error");
            }
        }

        private void ButtonReturnDash_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormDashboard().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
