using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NEA
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

            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();                                                        // connects to database and reads it

                var cmd = new SqlCommand("SELECT Username FROM Account", databaseConn); // uses SQL query to read data
                SqlDataReader dr = cmd.ExecuteReader();
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

                var cmd = new SqlCommand("SELECT AccessLevelName FROM AccessLevel", databaseConn); // uses SQL query to read data
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListOfAccessLevels.Items.Add(dr["AccessLevelName"].ToString()); // populates the list from the SQL query
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    int selectedUser = ListOfUsers.SelectedIndex - 1;
                    string newUsername = TextBoxUsername.Text;
                    string editUserCommand = @"UPDATE Account SET Username = @NewUsername WHERE AccountID = @AccountID;";
                    var cmd = new SqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@AccountID", selectedUser);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The username of '{ListOfUsers.SelectedItem}' is now {newUsername}");
                }
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    int selectedUser = ListOfUsers.SelectedIndex - 1;
                    string newFirstName = TextBoxFirstName.Text;
                    string editUserCommand = @"UPDATE Staff SET StaffFirstName = @NewFirstName WHERE AccountID = @AccountID;";
                    var cmd = new SqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                    cmd.Parameters.AddWithValue("@NewFirstName", newFirstName);
                    cmd.Parameters.AddWithValue("@AccountID", selectedUser);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The first name of '{ListOfUsers.SelectedItem}' is now {newFirstName}");
                }
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    int selectedUser = ListOfUsers.SelectedIndex - 1;
                    string newLastName = TextBoxLastName.Text;
                    string editUserCommand = @"UPDATE Staff SET StaffLastName = @NewLastName WHERE AccountID = @AccountID;";
                    var cmd = new SqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                    cmd.Parameters.AddWithValue("@NewLastName", newLastName);
                    cmd.Parameters.AddWithValue("@AccountID", selectedUser);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The first name of '{ListOfUsers.SelectedItem}' is now {newLastName}");
                }
            }
            catch (SqlException ex)
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
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    int selectedUser = ListOfUsers.SelectedIndex - 1;
                    string newAddress = TextBoxAddress.Text;
                    string editUserCommand = @"UPDATE Staff SET StaffAddress = @NewAddress WHERE AccountID = @AccountID;";
                    var cmd = new SqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                    cmd.Parameters.AddWithValue("@NewAddress", newAddress);
                    cmd.Parameters.AddWithValue("@AccountID", selectedUser);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The address of '{ListOfUsers.SelectedItem}' is now {newAddress}");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Unable to connect to the database. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ButtonApplyNewPhone_Click(object sender, EventArgs e)
        {
            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open(); // opens connection with the database so it can be queried
                using (databaseConn)
                {
                    int selectedUser = ListOfUsers.SelectedIndex - 1;
                    string newPhone = TextBoxPhoneNumber.Text;
                    string editUserCommand = @"UPDATE Staff SET StaffPhone = @NewPhone WHERE AccountID = @AccountID;";
                    var cmd = new SqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                    cmd.Parameters.AddWithValue("@NewPhone", newPhone);
                    cmd.Parameters.AddWithValue("@AccountID", selectedUser);
                    cmd.ExecuteNonQuery();

                    databaseConn.Close();

                    MessageBox.Show(
                        $"The phone number of '{ListOfUsers.SelectedItem}' is now {newPhone}");
                }
            }
            catch (SqlException ex)
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
                var databaseConn = new SqlConnection(_connStr);

                try
                {
                    databaseConn.Open(); // opens connection with the database so it can be queried
                    using (databaseConn)
                    {
                        int selectedUser = ListOfUsers.SelectedIndex - 1;
                        int newAccessLevel = ListOfAccessLevels.SelectedIndex - 1;
                        string editUserCommand = @"UPDATE Account SET AccessLevelID = @NewAccessLevel WHERE AccountID = @AccountID;";
                        var cmd = new SqlCommand(editUserCommand, databaseConn); // forms an SQL command to change stock values
                        cmd.Parameters.AddWithValue("@NewAccessLevel", newAccessLevel);
                        cmd.Parameters.AddWithValue("@AccountID", selectedUser);
                        cmd.ExecuteNonQuery();

                        databaseConn.Close();

                        MessageBox.Show(
                            $"The access level of '{ListOfUsers.SelectedItem}' is now {ListOfAccessLevels.GetItemText(ListOfAccessLevels.SelectedItem)}");
                    }
                }
                catch (SqlException ex)
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
            new FormDashboard().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
