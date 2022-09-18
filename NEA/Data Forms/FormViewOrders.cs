using System;
using System.Windows.Forms;

namespace NEA
{
    public partial class FormViewOrders : Form
    {
        private static readonly Database _database = new Database();

        public FormViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrdersForm_Load(object Sender, EventArgs E)
        {
            _database.LoadDataFromOrdersDb(DatabaseGrid); // opens the database
            WelcomeText.Text = $"welcome, {Logon.CurrentUser}!";
        }

        private void SearchBox_TextChanged(object Sender, EventArgs E)
        {
            _database.SearchDataFromOrdersDb(DatabaseGrid, SearchBox.Text);
        }

        private void CloseButton_Click(object Sender, EventArgs E)
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
