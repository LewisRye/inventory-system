namespace Inventory.ProgramForms
{
    public partial class FormSettings : Form
    {
        private readonly Settings _settings = new Settings();

        public FormSettings()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object Sender, EventArgs E)
        {
            ComboBoxTime.Items.Add("Select a time.");
            ComboBoxTime.Items.Add("30 seconds");
            ComboBoxTime.Items.Add("45 seconds");
            ComboBoxTime.Items.Add("60 seconds");

            ComboBoxStock.Items.Add("Select a level.");
            ComboBoxStock.Items.Add("10 items");
            ComboBoxStock.Items.Add("15 items");
            ComboBoxStock.Items.Add("20 items");

            TextBoxEmail.Text = "Enter an email.";

            ComboBoxColour.Items.Add("Select a colour.");
            ComboBoxColour.Items.Add("Red");
            ComboBoxColour.Items.Add("Green");
            ComboBoxColour.Items.Add("Indigo");
            ComboBoxColour.Items.Add("Grey");

            ComboBoxTime.SelectedIndex = 0;
            ComboBoxStock.SelectedIndex = 0;
            ComboBoxColour.SelectedIndex = 0;
        }

        private void ButtonChangeNotifTime_Click(object Sender, EventArgs E)
        {
            if (ComboBoxTime.SelectedIndex != 0)
            {
                string seconds = ComboBoxTime.SelectedItem.ToString().Substring(0, 2);
                _settings.ChangeFileNotifTime(Convert.ToInt16(seconds));
            }
            else
            {
                MessageBox.Show("Please select a time.", "Error");
            }
        }

        private void ButtonChangeNotifStock_Click(object Sender, EventArgs E)
        {
            if (ComboBoxStock.SelectedIndex != 0)
            {
                string stockLevel = ComboBoxStock.SelectedItem.ToString().Substring(0, 2);
                _settings.ChangeFileNotifStock(Convert.ToInt16(stockLevel));
            }
            else
            {
                MessageBox.Show("Please select a stock level.", "Error");
            }
        }

        private bool EmailValid(string EmailAddress)
        {
            try
            {
                var Email = new MailAddress(EmailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void ButtonChangeEmail_Click(object Sender, EventArgs E)
        {
            bool Valid = EmailValid(TextBoxEmail.Text); // checks if the entered email exists

            if (Valid)
            {
                _settings.ChangeFileEmail(TextBoxEmail.Text);
            }
            else
            {
                MessageBox.Show("The email you entered is invalid.", "Error");
            }
        }

        private void ButtonChangeColour_Click(object Sender, EventArgs E)
        {
            if (ComboBoxColour.SelectedIndex != 0)
            {
                _settings.ChangeFileColour(ComboBoxColour.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a colour.", "Error");
            }
        }

        private void ButtonRestart_Click(object Sender, EventArgs E)
        {
            Application.Restart();
        }

        private void ButtonClose_Click(object Sender, EventArgs E)
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
