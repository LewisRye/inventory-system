using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace NEA
{
    public partial class FormAlter : Form
    {
        private static readonly string _connStr = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public FormAlter()
        {
            InitializeComponent();
            ProductPrice.Minimum = 0;
            ProductPrice.Maximum = 10000;
            ProductPrice.DecimalPlaces = 2;
            ProductPrice.Increment = 0.01m;

            NewProductPrice.Minimum = 0;
            NewProductPrice.Maximum = 10000;
            NewProductPrice.DecimalPlaces = 2;
            NewProductPrice.Increment = 0.01m;
        }

        private void AlterForm_Load(object Sender, EventArgs E)
        {
            CategoryList.Items.Add("Select the category");

            var databaseConn = new SqlConnection(_connStr);

            try
            {
                databaseConn.Open();                                                        // connects to database and reads it

                var cmd = new SqlCommand("SELECT CategoryName FROM Category", databaseConn); // uses SQL query to read data
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CategoryList.Items.Add(dr["CategoryName"].ToString());               // populates the list from the SQL query
                }
                CategoryList.SelectedIndex = 0;                                              // shows text 'select item to order'
                databaseConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            ProductList.Items.Add("Select the item to discontinue");

            var databaseConnection = new SqlConnection(_connStr);

            try
            {
                databaseConnection.Open();                                                 // connects to database and reads it

                var cmd = new SqlCommand("SELECT ProductName FROM Product", databaseConnection); // uses SQL query to read data
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProductList.Items.Add(dr["ProductName"].ToString());               // populates the list from the SQL query
                }
                ProductList.SelectedIndex = 0;                                             // shows text 'select item to order'
                databaseConnection.Close();
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

        private void AddCategoryButton_Click(object Sender, EventArgs E)
        {
            if (CategoryName.Text.Length > 0)
            {
                var databaseConnection = new SqlConnection(_connStr);

                try
                {
                    databaseConnection.Open();                                                                          // opens connection with the database so it can be queried
                    var sda = new SqlDataAdapter("SELECT CategoryID FROM Category WHERE CategoryName = '" + CategoryName.Text + "';",
                        databaseConnection);

                    var dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        string addCategoryCommand = @"INSERT INTO Category 
                        VALUES((SELECT COUNT(CategoryID) FROM Category) + 1, @CategoryName);";
                        var cmd = new SqlCommand(addCategoryCommand, databaseConnection);                               // forms an SQL command to add a new category
                        cmd.Parameters.AddWithValue("@CategoryName", CategoryName.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"The product category '{CategoryName.Text}' has been added.",
                            "New Category");
                    }
                    else
                    {
                        MessageBox.Show($"The product category '{CategoryName.Text}' already exists.", "Error");
                    }

                    databaseConnection.Close();
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
        }

        private void AddProductButton_Click(object Sender, EventArgs E)
        {
            if (InputProductName.Text != "" && CategoryList.SelectedIndex != 0)
            {
                var databaseConnection = new SqlConnection(_connStr);

                try
                {
                    var sda = new SqlDataAdapter("SELECT ProductID FROM Product WHERE ProductName = '" +
                                                 InputProductName.Text + "';", databaseConnection);
                    var dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        databaseConnection.Open();
                        using (databaseConnection)
                        {
                            double sellingPrice = Convert.ToDouble(ProductPrice.Value) / 0.8;
                            string insertCommand = "INSERT INTO Product VALUES((SELECT COUNT(ProductID) FROM Product) + 1, " +
                                                   "@ProductName, @CategoryID, @NumberInStock, @SellingPrice, @BuyingPrice, 'n');";
                            var cmd = new SqlCommand(insertCommand, databaseConnection);                                        // forms an SQL command to add new item
                            cmd.Parameters.AddWithValue("@ProductName", InputProductName.Text);
                            cmd.Parameters.AddWithValue("@CategoryID", CategoryList.SelectedIndex);
                            cmd.Parameters.AddWithValue("@NumberInStock", ProductStock.Value);
                            cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                            cmd.Parameters.AddWithValue("@BuyingPrice", ProductPrice.Value);
                            cmd.ExecuteNonQuery();

                            databaseConnection.Close();

                            MessageBox.Show($"The product '{InputProductName.Text}' has been added to the database.",
                                "New Product");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"The product '{InputProductName.Text}' already exists.", "Error");
                    }

                    databaseConnection.Close();
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
                MessageBox.Show("Not all fields have been entered correctly...", "Error");
            }
        }

        private void DiscontinueButton_Click(object Sender, EventArgs E)
        {
            if (ProductList.SelectedIndex != 0)
            {
                var databaseConnection = new SqlConnection(_connStr);

                try
                {
                    databaseConnection.Open();                                                                              // opens connection with the database so it can be queried
                    using (databaseConnection)
                    {
                        string selectedItem = ProductList.GetItemText(ProductList.SelectedItem);
                        int selectedIndex = ProductList.SelectedIndex;
                        string discontinueCommand = @"UPDATE Product SET Discontinued = 'y', 
                        NumberInStock = 0 WHERE ProductID = " + selectedIndex + ";";
                        var cmd = new SqlCommand(discontinueCommand, databaseConnection);                                   // forms an SQL command to change stock values
                        cmd.ExecuteNonQuery();

                        databaseConnection.Close();

                        MessageBox.Show($"'{selectedItem}' is now discontinued.");
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
                MessageBox.Show("You must select a product...", "Error");
            }
        }

        private void ButtonChange_Click(object Sender, EventArgs E)
        {
            var databaseConnection = new SqlConnection(_connStr);

            var sda = new SqlDataAdapter("SELECT ProductID FROM Product WHERE ProductName = '" +
                                         ExistingProductName.Text + "';", databaseConnection);
            var dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                try
                {
                    databaseConnection.Open(); // opens connection with the database so it can be queried
                    using (databaseConnection)
                    {
                        string selectedItem = ExistingProductName.Text;
                        double newBuyingPrice = Convert.ToDouble(NewProductPrice.Value);
                        double newSellingPrice = Convert.ToDouble(NewProductPrice.Value) / 0.8;
                        string newPriceCommand = @"UPDATE Product SET SellingPrice = @NewSellingPrice, 
                        BuyingPrice = @NewBuyingPrice WHERE ProductName = @ProductName;";
                        var cmd = new SqlCommand(newPriceCommand,
                            databaseConnection); // forms an SQL command to change stock values
                        cmd.Parameters.AddWithValue("@NewSellingPrice", newSellingPrice);
                        cmd.Parameters.AddWithValue("@NewBuyingPrice", newBuyingPrice);
                        cmd.Parameters.AddWithValue("@ProductName", selectedItem);
                        cmd.ExecuteNonQuery();

                        databaseConnection.Close();

                        MessageBox.Show(
                            $"The selling price of '{selectedItem}' is now £{newSellingPrice.ToString("0.00")}");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Unable to connect to the database. " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This product does not exist." + ex.Message, "Error");
                }
            }
        }

        private void CloseButton_Click(object Sender, EventArgs E)
        {
            this.Hide();
            new FormViewStock().Show();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
