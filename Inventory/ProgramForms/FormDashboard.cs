using Inventory.DataForms;
using Inventory.LoginForms;

namespace Inventory.ProgramForms
{
    public partial class FormDashboard : Form
    {
        private readonly Insights _insights = new Insights();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object Sender, EventArgs E)
        {
            WelcomeText.Text = $"welcome, {Logon.CurrentUser}!";

            QuantityItemsStock.Text = "0";
            QuantityItemsProfit.Text = "£0";
            QuantityItemsOrders.Text = "0";

            //
            //  creating data to put inside of the graphs
            //

            //_insights.CreateStockByTypeChart(ChartStockType);                       // fills 'Stock by Type' chart with data
            //_insights.CreateDailyOrdersChart(ChartDailyOrders);                     // fills 'Order History' chart with data
            _insights.CreateBestSellersChart(ListBestSellers);                     // fills 'Best Sellers' chart with data

            //
            //  creating data to put inside of the buttons
            //

            _insights.CreateQuantityItemsStockText(QuantityItemsStock);             // fills 'items in stock currently' with data
            _insights.CreateQuantityItemsProfitText(QuantityItemsProfit);           // fills 'profit in the last 7 days' with data
            _insights.CreateQuantityItemsOrdersText(QuantityItemsOrders);           // fills 'orders in the last 7 days' with data

            //new NotificationForm().Show();
        }

        private void ViewStockButton_Click(object Sender, EventArgs E)
        {
            new DataForms.FormViewStock().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ResetPasswordButton_Click(object Sender, EventArgs E)
        {
            new LoginForms.FormAccountReset().Show();
            Logon.CurrentUser = "";
            Logon.AccessLevel = "";
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ButtonSettings_Click(object Sender, EventArgs E)
        {
            new ProgramForms.FormSettings().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ViewInsightButton_Click(object Sender, EventArgs E)
        {
            if (Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                // new DataForms.FormViewInsights().Show(); // do not do this until the form has been finished
                // this.Hide();
                // this.Close();
                // this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void OpenOrdersButton_Click(object Sender, EventArgs E)
        {
            if (Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                new DataForms.FormViewOrders().Show();
                this.Hide();
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void OpenRestockButton_Click(object Sender, EventArgs E)
        {
            if (Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                new ProgramForms.FormPurchase().Show();
                this.Hide();
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void OpenEditButton_Click(object sender, EventArgs e)
        {
            if (Logon.AccessLevel != "Manager")
            {
                MessageBox.Show("You need to be a manager to use this feature", "Manager Required");
            }

            else
            {
                new LoginForms.FormAccountEdit().Show();
                this.Hide();
                this.Close();
                this.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void LogOutLink_LinkClicked(object Sender, LinkLabelLinkClickedEventArgs E)
        {
            foreach (Form var in Application.OpenForms)
            {
                if (var.Name == "FormLogin")
                {
                    var.Visible = true;
                }
            }
            Logon.CurrentUser = ""; // removes the currently logged in username
            Logon.AccessLevel = ""; // removes the currently logged in access level
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // completely exits application
        }
    }
}
