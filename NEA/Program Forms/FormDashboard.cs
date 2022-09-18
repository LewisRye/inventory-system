using System;
using System.Windows.Forms;

namespace NEA
{
    public partial class FormDashboard : Form
    {
        private readonly Insights _insights = new Insights();

        public FormDashboard()
        {
            InitializeComponent();
            
        }

        private void DashboardForm_Load(object Sender, EventArgs E)
        {
            WelcomeText.Text = $"Welcome, {Logon.CurrentUser}!";

            QuantityItemsStock.Text = "0";
            QuantityItemsProfit.Text = "£0";
            QuantityItemsOrders.Text = "0";

            //
            //  creating data to put inside of the graphs
            //

            _insights.CreateStockByTypeChart(ChartStockType);                       // fills 'Stock by Type' chart with data
            _insights.CreateDailyOrdersChart(ChartDailyOrders);                     // fills 'Order History' chart with data
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
            new FormViewStock().Show();
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ResetPasswordButton_Click(object Sender, EventArgs E)
        {
            new FormAccountReset().Show();
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
            new FormSettings().Show();
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
                new FormViewInsights().Show();
                this.Hide();
                this.Close();
                this.Dispose();
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
                new FormViewOrders().Show();
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
                new FormPurchase().Show();
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
                new FormAccountEdit().Show();
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
                if (var.Name == "LoginForm")
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

        private void CloseButton_Click(object Sender, EventArgs E)
        {
            Environment.Exit(0); // completely exits application
        }
    }
}
