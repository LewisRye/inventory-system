using Inventory.Classes;

namespace Inventory.DataForms
{
    public partial class FormViewOrders : Form
    {
        private readonly Database _database = new Database();
        private List<Order> allOrders = new List<Order>();
        private List<Order> newOrders = new List<Order>();

        public FormViewOrders()
        {
            InitializeComponent();

            DatabaseGrid.Columns.Add("0", "Order ID");
            DatabaseGrid.Columns.Add("1", "Product Name");
            DatabaseGrid.Columns.Add("2", "Customer Name");
            DatabaseGrid.Columns.Add("3", "Quantity");
            DatabaseGrid.Columns.Add("4", "Date Ordered");
            DatabaseGrid.Columns.Add("5", "Order Price");

            allOrders = _database.GetOrders();
        }

        private void ViewOrdersForm_Load(object Sender, EventArgs E)
        {
            foreach (Order o in allOrders)
            {
                DatabaseGrid.Rows.Add(o.GetId(), o.GetProductName(), o.GetFullName(), o.GetQuantity(), o.GetDate().ToString("dd/MM/yyyy"), "£" + o.GetPrice());
            }

            WelcomeText.Text = $"welcome, {Logon.CurrentUser}!";
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DatabaseGrid.Rows.Clear();
            newOrders.Clear();

            if (SearchBox.Text == "")
            {
                foreach (Order o in allOrders)
                {
                    DatabaseGrid.Rows.Add(o.GetId(), o.GetProductName(), o.GetFullName(), o.GetQuantity(), o.GetDate().ToString("dd/MM/yyyy"), "£" + o.GetPrice());
                }
            }
            else
            {
                newOrders = _database.GetOrders(SearchBox.Text);
                foreach (Order o in newOrders)
                {
                    DatabaseGrid.Rows.Add(o.GetId(), o.GetProductName(), o.GetFullName(), o.GetQuantity(), o.GetDate().ToString("dd/MM/yyyy"), "£" + o.GetPrice());
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
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
