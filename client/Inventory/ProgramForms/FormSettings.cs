namespace Inventory.ProgramForms
{
    public partial class FormSettings : Form
    {
        private readonly Classes.Settings _settings = new Classes.Settings();

        public FormSettings()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
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

        private void ButtonChangeNotifTime_Click(object sender, EventArgs e)
        {
            if (ComboBoxTime.SelectedIndex != 0)
            {
                string? seconds = ComboBoxTime.SelectedItem?.ToString()?.Substring(0, 2);
                _settings.ChangeFileNotificationTime(Convert.ToInt16(seconds));
            }
            else
            {
                MessageBox.Show("Please select a time.", "Error");
            }
        }

        private void ButtonChangeNotifStock_Click(object sender, EventArgs e)
        {
            if (ComboBoxStock.SelectedIndex != 0)
            {
                string? stockLevel = ComboBoxStock.SelectedItem?.ToString()?.Substring(0, 2);
                _settings.ChangeFileNotificationStock(Convert.ToInt16(stockLevel));
            }
            else
            {
                MessageBox.Show("Please select a stock level.", "Error");
            }
        }

        private bool EmailValid(string emailAddress)
        {
            try
            {
                var email = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void ButtonChangeEmail_Click(object sender, EventArgs e)
        {
            bool valid = EmailValid(TextBoxEmail.Text); // checks if the entered email exists

            if (valid)
            {
                _settings.ChangeFileEmail(TextBoxEmail.Text);
            }
            else
            {
                MessageBox.Show("The email you entered is invalid.", "Error");
            }
        }

        private void ButtonChangeColour_Click(object sender, EventArgs e)
        {
            if (ComboBoxColour.SelectedIndex != 0)
            {
                if (ComboBoxColour.SelectedItem != null)
                    _settings.ChangeFileColour(ComboBoxColour.SelectedItem.ToString() ?? "Grey");
            }
            else
            {
                MessageBox.Show("Please select a colour.", "Error");
            }
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
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
