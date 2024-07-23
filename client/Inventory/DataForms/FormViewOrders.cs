using Inventory.Classes;
using Inventory.JsonResponses;

namespace Inventory.DataForms
{
    public partial class FormViewOrders : Form
    {
        private List<Order> _newOrders = new List<Order>();

        public FormViewOrders()
        {
            InitializeComponent();

            DatabaseGrid.Columns.Add("0", "Order ID");
            DatabaseGrid.Columns.Add("1", "Product Name");
            DatabaseGrid.Columns.Add("2", "Customer Name");
            DatabaseGrid.Columns.Add("3", "Quantity");
            DatabaseGrid.Columns.Add("4", "Date Ordered");
            DatabaseGrid.Columns.Add("5", "Order Price");

            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "all_order");
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    Logon.AllOrders = JsonSerializer.Deserialize<List<Order>>(json)!;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            foreach (Order o in Logon.AllOrders)
            {
                DatabaseGrid.Rows.Add(o.Id, o.ProdName, o.CustName, o.Quantity, o.Date.ToString("dd/MM/yyyy"), "£" + o.Price);
            }

            WelcomeText.Text = $"welcome, {Logon.CurrentUser}!";
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DatabaseGrid.Rows.Clear();
            _newOrders.Clear();

            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "search_order");
                request.Headers.Add("search", SearchBox.Text);
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    _newOrders = JsonSerializer.Deserialize<List<Order>>(json)!;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            foreach (Order o in _newOrders)
            {
                DatabaseGrid.Rows.Add(o.Id, o.ProdName, o.CustName, o.Quantity, o.Date.ToString("dd/MM/yyyy"), "£" + o.Price);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            DatabaseGrid.Rows.Clear();
            _newOrders.Clear();

            foreach (Order o in Logon.AllOrders)
            {
                DatabaseGrid.Rows.Add(o.Id, o.ProdName, o.CustName, o.Quantity, o.Date.ToString("dd/MM/yyyy"), "£" + o.Price);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormDashboard().Show();
            this.Close();
            this.Dispose();
            GC.Collect();
        }
    }
}
