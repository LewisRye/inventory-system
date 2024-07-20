using Inventory.JsonResponses;

namespace Inventory.DataForms
{
    public partial class FormViewStock : Form
    {
        private List<Category> _allCategories = new List<Category>();
        private List<Product> _allProducts = new List<Product>();
        private List<Product> _newProducts = new List<Product>();

        public FormViewStock()
        {
            InitializeComponent();

            ComboBoxType.Items.Add("Select the category");
            ComboBoxSort.Items.Add("Select the sort");
            ComboBoxSort.Items.Add("Price (low to high)");
            ComboBoxSort.Items.Add("Price (high to low)");
            ComboBoxSort.Items.Add("Product Name (A to Z)");
            ComboBoxSort.Items.Add("Product Name (Z to A)");
            ComboBoxSort.Items.Add("Stock (low to high)");
            ComboBoxSort.Items.Add("Stock (high to low)");

            DatabaseGrid.Columns.Add("0", "ID");
            DatabaseGrid.Columns.Add("1", "Name");
            DatabaseGrid.Columns.Add("2", "Category");
            DatabaseGrid.Columns.Add("3", "Stock");
            DatabaseGrid.Columns.Add("4", "Buy Price");
            DatabaseGrid.Columns.Add("5", "Discontinued");

            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;

            try
            {
                using HttpClient client = new HttpClient();
                HttpRequestMessage request;
                HttpResponseMessage response;

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "all_product");
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    _allProducts = JsonSerializer.Deserialize<List<Product>>(json)!;
                }

                request = new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "all_category");
                response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;

                    _allCategories = JsonSerializer.Deserialize<List<Category>>(json)!;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void FormViewStock_Load(object sender, EventArgs e)
        {
            foreach (Category c in _allCategories)
            {
                ComboBoxType.Items.Add(c.Name + "");
            }

            foreach (Product p in _allProducts)
            {
                DatabaseGrid.Rows.Add(p.Id, p.ProdName, _allCategories[p.CatId - 1].Name, p.Stock, "£" + p.Price.ToString("0.00"), p.Discontinued);
            }

            TextWelcome.Text = $"welcome, {Classes.Logon.CurrentUser}!";
        }

        private void ButtonApplyCategoryFilter_Click(object sender, EventArgs e)
        {
            if (ComboBoxType.SelectedIndex != 0)
            {
                DatabaseGrid.Rows.Clear();
                foreach (Product p in _allProducts)
                {
                    if (p.CatId == ComboBoxType.SelectedIndex)
                    {
                        DatabaseGrid.Rows.Add(p.Id, p.ProdName, _allCategories[p.CatId - 1].Name, p.Stock, "£" + p.Price.ToString("0.00"), p.Discontinued);
                    }
                }
            }
            else
            {
                MessageBox.Show("You must apply a filter first.", "Error");
            }
        }

        private void ButtonApplySort_Click(object sender, EventArgs e)
        {
            switch (ComboBoxSort.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("You must apply a sort first.", "Error");
                    break;
                case 1:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["4"], ListSortDirection.Descending);
                    break;
                case 2:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["4"], ListSortDirection.Ascending);
                    break;
                case 3:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["1"], ListSortDirection.Ascending);
                    break;
                case 4:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["1"], ListSortDirection.Descending);
                    break;
                case 5:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["3"], ListSortDirection.Ascending);
                    break;
                case 6:
                    DatabaseGrid.Sort(DatabaseGrid.Columns["3"], ListSortDirection.Descending);
                    break;
            }
        }

        private void ButtonResetSort_Click(object sender, EventArgs e)
        {
            DatabaseGrid.Rows.Clear();
            foreach (Product p in _allProducts)
            {
                DatabaseGrid.Rows.Add(p.Id, p.ProdName, _allCategories[p.CatId - 1].Name, p.Stock, "£" + p.Price.ToString("0.00"), p.Discontinued);
            }

            SearchBox.Text = "";
            ComboBoxType.SelectedIndex = 0;
            ComboBoxSort.SelectedIndex = 0;
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return; // ignores if the user didnt press enter

            DatabaseGrid.Rows.Clear();
            _newProducts.Clear();

            if (SearchBox.Text == "")
            {
                foreach (Product p in _allProducts)
                {
                    DatabaseGrid.Rows.Add(p.Id, p.ProdName, _allCategories[p.CatId - 1].Name, p.Stock, "£" + p.Price.ToString("0.00"), p.Discontinued);
                }
            }
            else
            {
                try
                {
                    using HttpClient client = new HttpClient();
                    HttpRequestMessage request =
                        new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "search_product");
                    request.Headers.Add("search", SearchBox.Text);
                    HttpResponseMessage response = client.Send(request);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync().Result;

                        _newProducts = JsonSerializer.Deserialize<List<Product>>(json)!;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                foreach (Product p in _newProducts)
                {
                    DatabaseGrid.Rows.Add(p.Id, p.ProdName, _allCategories[p.CatId - 1].Name, p.Stock, "£" + p.Price.ToString("0.00"), p.Discontinued);
                }
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            DatabaseGrid.Rows.Clear();
            _newProducts.Clear();

            if (SearchBox.Text == "")
            {
                foreach (Product p in _allProducts)
                {
                    DatabaseGrid.Rows.Add(p.Id, p.ProdName, _allCategories[p.CatId - 1].Name, p.Stock, "£" + p.Price.ToString("0.00"), p.Discontinued);
                }
            }
            else
            {
                try
                {
                    using HttpClient client = new HttpClient();
                    HttpRequestMessage request =
                        new HttpRequestMessage(HttpMethod.Get, Classes.Logon.UriPath + "search_product");
                    request.Headers.Add("search", SearchBox.Text);
                    HttpResponseMessage response = client.Send(request);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync().Result;

                        _newProducts = JsonSerializer.Deserialize<List<Product>>(json)!;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                foreach (Product p in _newProducts)
                {
                    DatabaseGrid.Rows.Add(p.Id, p.ProdName, _allCategories[p.CatId - 1].Name, p.Stock, "£" + p.Price.ToString("0.00"), p.Discontinued);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            SearchBox.Clear();
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        private void ButtonDiscontinue_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        private void ButtonChangePrice_Click(object sender, EventArgs e)
        {
            new ProgramForms.FormAlter().Show();
            this.Close();
            this.Dispose();
            GC.Collect();
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
