namespace Inventory.ProgramForms
{
    public partial class FormDashboard : Form
    {
        private readonly Classes.Insights _insights = new Classes.Insights();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private async void FormDashboard_Load(object sender, EventArgs e)
        {
            WelcomeText.Text = $"welcome, {Classes.Logon.CurrentUser}!";

            await GenerateContent(); // generates content for the dashboard
        }

        private async Task GenerateContent()
        {
            //
            //  creating data to put inside of the graphs
            //

            await _insights.CreateStockByTypeChart(ChartStockType);                       // fills 'Stock by Type' chart with data
            await _insights.CreateDailyOrdersChart(ChartDailyOrders);                     // fills 'Order History' chart with data
            await _insights.CreateBestSellersChart(ListBestSellers);                     // fills 'Best Sellers' chart with data

            //
            //  creating data to put inside of the buttons
            //
            await _insights.CreateQuantityItemsStockText(QuantityItemsStock);             // fills 'items in stock currently' with data
            await _insights.CreateQuantityItemsProfitText(QuantityItemsProfit);           // fills 'profit in the last 7 days' with data
            await _insights.CreateQuantityItemsOrdersText(QuantityItemsOrders);           // fills 'orders in the last 7 days' with data
        }

        private void ViewStockButton_Click(object sender, EventArgs e)
        {
            new DataForms.FormViewStock().Show();
            this.Hide();
            this.Close();
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            new LoginForms.FormAccountReset().Show();
            Classes.Logon.CurrentUser = "";
            Classes.Logon.AccessLevel = "";
            this.Hide();
            this.Close();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormSettings().Show();
            this.Hide();
            this.Close();
        }

        private void ViewInsightButton_Click(object sender, EventArgs e)
        {
            if (Classes.Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                new DataForms.FormViewInsights().Show();
                this.Hide();
                this.Close();
            }
        }

        private void OpenOrdersButton_Click(object sender, EventArgs e)
        {
            if (Classes.Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                new DataForms.FormViewOrders().Show();
                this.Hide();
                this.Close();
            }
        }

        private void OpenRestockButton_Click(object sender, EventArgs e)
        {
            if (Classes.Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                new ProgramForms.FormPurchase().Show();
                this.Hide();
                this.Close();
            }
        }

        private void OpenEditButton_Click(object sender, EventArgs e)
        {
            if (Classes.Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                new LoginForms.FormAccountEdit().Show();
                this.Hide();
                this.Close();
            }
        }

        private void LogOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                if (var.Name == "FormLogin")
                {
                    var.Visible = true;
                }
            }
            Classes.Logon.CurrentUser = ""; // removes the currently logged in username
            Classes.Logon.AccessLevel = ""; // removes the currently logged in access level
            this.Hide();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // completely exits application
        }
    }
}
