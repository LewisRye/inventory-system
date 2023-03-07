namespace Inventory.ProgramForms
{
    partial class FormAlter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlter));
            this.CloseButton = new MaterialSkin.Controls.MaterialButton();
            this.TextAddCategory = new System.Windows.Forms.Label();
            this.TextAddProduct = new System.Windows.Forms.Label();
            this.TextDiscontinueProduct = new System.Windows.Forms.Label();
            this.ProductList = new MaterialSkin.Controls.MaterialComboBox();
            this.DiscontinueButton = new MaterialSkin.Controls.MaterialButton();
            this.AddCategoryButton = new MaterialSkin.Controls.MaterialButton();
            this.AddProductButton = new MaterialSkin.Controls.MaterialButton();
            this.CategoryList = new MaterialSkin.Controls.MaterialComboBox();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.TextCategoryName = new System.Windows.Forms.Label();
            this.TextProductName = new System.Windows.Forms.Label();
            this.InputProductName = new System.Windows.Forms.TextBox();
            this.TextProductCategory = new System.Windows.Forms.Label();
            this.TextProductStock = new System.Windows.Forms.Label();
            this.TextProductPrice = new System.Windows.Forms.Label();
            this.ProductStock = new System.Windows.Forms.NumericUpDown();
            this.ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.UnusedButton = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TextExistingProductName = new System.Windows.Forms.Label();
            this.TextNewPrice = new System.Windows.Forms.Label();
            this.NewProductPrice = new System.Windows.Forms.NumericUpDown();
            this.ExistingProductName = new System.Windows.Forms.TextBox();
            this.ButtonChange = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = false;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CloseButton.Depth = 0;
            this.CloseButton.HighEmphasis = true;
            this.CloseButton.Icon = null;
            this.CloseButton.Location = new System.Drawing.Point(12, 389);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CloseButton.Size = new System.Drawing.Size(433, 36);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseButton.UseAccentColor = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TextAddCategory
            // 
            this.TextAddCategory.AutoSize = true;
            this.TextAddCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAddCategory.Location = new System.Drawing.Point(12, 9);
            this.TextAddCategory.Name = "TextAddCategory";
            this.TextAddCategory.Size = new System.Drawing.Size(95, 17);
            this.TextAddCategory.TabIndex = 1;
            this.TextAddCategory.Text = "Add Category:";
            // 
            // TextAddProduct
            // 
            this.TextAddProduct.AutoSize = true;
            this.TextAddProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAddProduct.Location = new System.Drawing.Point(12, 74);
            this.TextAddProduct.Name = "TextAddProduct";
            this.TextAddProduct.Size = new System.Drawing.Size(88, 17);
            this.TextAddProduct.TabIndex = 2;
            this.TextAddProduct.Text = "Add Product:";
            // 
            // TextDiscontinueProduct
            // 
            this.TextDiscontinueProduct.AutoSize = true;
            this.TextDiscontinueProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDiscontinueProduct.Location = new System.Drawing.Point(12, 227);
            this.TextDiscontinueProduct.Name = "TextDiscontinueProduct";
            this.TextDiscontinueProduct.Size = new System.Drawing.Size(137, 17);
            this.TextDiscontinueProduct.TabIndex = 3;
            this.TextDiscontinueProduct.Text = "Discontinue Product:";
            // 
            // ProductList
            // 
            this.ProductList.AutoResize = false;
            this.ProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductList.Depth = 0;
            this.ProductList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProductList.DropDownHeight = 292;
            this.ProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductList.DropDownWidth = 121;
            this.ProductList.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.ProductList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.IntegralHeight = false;
            this.ProductList.ItemHeight = 29;
            this.ProductList.Location = new System.Drawing.Point(12, 247);
            this.ProductList.MaxDropDownItems = 10;
            this.ProductList.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(319, 35);
            this.ProductList.StartIndex = 0;
            this.ProductList.TabIndex = 9;
            this.ProductList.UseAccent = false;
            this.ProductList.UseTallSize = false;
            // 
            // DiscontinueButton
            // 
            this.DiscontinueButton.AutoSize = false;
            this.DiscontinueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiscontinueButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DiscontinueButton.Depth = 0;
            this.DiscontinueButton.HighEmphasis = true;
            this.DiscontinueButton.Icon = null;
            this.DiscontinueButton.Location = new System.Drawing.Point(338, 247);
            this.DiscontinueButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DiscontinueButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiscontinueButton.Name = "DiscontinueButton";
            this.DiscontinueButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DiscontinueButton.Size = new System.Drawing.Size(107, 35);
            this.DiscontinueButton.TabIndex = 10;
            this.DiscontinueButton.Text = "Discontinue";
            this.DiscontinueButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DiscontinueButton.UseAccentColor = false;
            this.DiscontinueButton.UseVisualStyleBackColor = true;
            this.DiscontinueButton.Click += new System.EventHandler(this.DiscontinueButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.AutoSize = false;
            this.AddCategoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddCategoryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddCategoryButton.Depth = 0;
            this.AddCategoryButton.HighEmphasis = true;
            this.AddCategoryButton.Icon = null;
            this.AddCategoryButton.Location = new System.Drawing.Point(338, 39);
            this.AddCategoryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddCategoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddCategoryButton.Size = new System.Drawing.Size(107, 20);
            this.AddCategoryButton.TabIndex = 3;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddCategoryButton.UseAccentColor = false;
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.AutoSize = false;
            this.AddProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddProductButton.Depth = 0;
            this.AddProductButton.HighEmphasis = true;
            this.AddProductButton.Icon = null;
            this.AddProductButton.Location = new System.Drawing.Point(338, 101);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddProductButton.Size = new System.Drawing.Size(107, 112);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddProductButton.UseAccentColor = false;
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // CategoryList
            // 
            this.CategoryList.AutoResize = false;
            this.CategoryList.BackColor = System.Drawing.Color.White;
            this.CategoryList.Depth = 0;
            this.CategoryList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CategoryList.DropDownHeight = 292;
            this.CategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryList.DropDownWidth = 121;
            this.CategoryList.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.IntegralHeight = false;
            this.CategoryList.ItemHeight = 29;
            this.CategoryList.Location = new System.Drawing.Point(143, 126);
            this.CategoryList.MaxDropDownItems = 10;
            this.CategoryList.MouseState = MaterialSkin.MouseState.OUT;
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(188, 35);
            this.CategoryList.StartIndex = 0;
            this.CategoryList.TabIndex = 5;
            this.CategoryList.UseAccent = false;
            this.CategoryList.UseTallSize = false;
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(143, 39);
            this.CategoryName.MaxLength = 30;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(188, 20);
            this.CategoryName.TabIndex = 2;
            // 
            // TextCategoryName
            // 
            this.TextCategoryName.AutoSize = true;
            this.TextCategoryName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCategoryName.Location = new System.Drawing.Point(12, 39);
            this.TextCategoryName.Name = "TextCategoryName";
            this.TextCategoryName.Size = new System.Drawing.Size(103, 17);
            this.TextCategoryName.TabIndex = 24;
            this.TextCategoryName.Text = "Category Name:";
            // 
            // TextProductName
            // 
            this.TextProductName.AutoSize = true;
            this.TextProductName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProductName.Location = new System.Drawing.Point(13, 101);
            this.TextProductName.Name = "TextProductName";
            this.TextProductName.Size = new System.Drawing.Size(95, 17);
            this.TextProductName.TabIndex = 25;
            this.TextProductName.Text = "Product Name:";
            // 
            // InputProductName
            // 
            this.InputProductName.Location = new System.Drawing.Point(143, 100);
            this.InputProductName.MaxLength = 30;
            this.InputProductName.Name = "InputProductName";
            this.InputProductName.Size = new System.Drawing.Size(188, 20);
            this.InputProductName.TabIndex = 4;
            // 
            // TextProductCategory
            // 
            this.TextProductCategory.AutoSize = true;
            this.TextProductCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProductCategory.Location = new System.Drawing.Point(13, 132);
            this.TextProductCategory.Name = "TextProductCategory";
            this.TextProductCategory.Size = new System.Drawing.Size(113, 17);
            this.TextProductCategory.TabIndex = 27;
            this.TextProductCategory.Text = "Product Category:";
            // 
            // TextProductStock
            // 
            this.TextProductStock.AutoSize = true;
            this.TextProductStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProductStock.Location = new System.Drawing.Point(12, 167);
            this.TextProductStock.Name = "TextProductStock";
            this.TextProductStock.Size = new System.Drawing.Size(92, 17);
            this.TextProductStock.TabIndex = 28;
            this.TextProductStock.Text = "Product Stock:";
            // 
            // TextProductPrice
            // 
            this.TextProductPrice.AutoSize = true;
            this.TextProductPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProductPrice.Location = new System.Drawing.Point(13, 193);
            this.TextProductPrice.Name = "TextProductPrice";
            this.TextProductPrice.Size = new System.Drawing.Size(101, 17);
            this.TextProductPrice.TabIndex = 29;
            this.TextProductPrice.Text = "Buying Price (£):";
            // 
            // ProductStock
            // 
            this.ProductStock.BackColor = System.Drawing.Color.White;
            this.ProductStock.Location = new System.Drawing.Point(143, 167);
            this.ProductStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductStock.Name = "ProductStock";
            this.ProductStock.Size = new System.Drawing.Size(188, 20);
            this.ProductStock.TabIndex = 6;
            this.ProductStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.Color.White;
            this.ProductPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ProductPrice.Location = new System.Drawing.Point(143, 193);
            this.ProductPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ProductPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(188, 20);
            this.ProductPrice.TabIndex = 7;
            this.ProductPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UnusedButton
            // 
            this.UnusedButton.AutoSize = false;
            this.UnusedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnusedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UnusedButton.Depth = 0;
            this.UnusedButton.HighEmphasis = true;
            this.UnusedButton.Icon = null;
            this.UnusedButton.Location = new System.Drawing.Point(368, 167);
            this.UnusedButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnusedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnusedButton.Name = "UnusedButton";
            this.UnusedButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UnusedButton.Size = new System.Drawing.Size(44, 36);
            this.UnusedButton.TabIndex = 1;
            this.UnusedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UnusedButton.UseAccentColor = false;
            this.UnusedButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Change Product Price:";
            // 
            // TextExistingProductName
            // 
            this.TextExistingProductName.AutoSize = true;
            this.TextExistingProductName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextExistingProductName.Location = new System.Drawing.Point(13, 324);
            this.TextExistingProductName.Name = "TextExistingProductName";
            this.TextExistingProductName.Size = new System.Drawing.Size(95, 17);
            this.TextExistingProductName.TabIndex = 31;
            this.TextExistingProductName.Text = "Product Name:";
            // 
            // TextNewPrice
            // 
            this.TextNewPrice.AutoSize = true;
            this.TextNewPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNewPrice.Location = new System.Drawing.Point(14, 350);
            this.TextNewPrice.Name = "TextNewPrice";
            this.TextNewPrice.Size = new System.Drawing.Size(101, 17);
            this.TextNewPrice.TabIndex = 32;
            this.TextNewPrice.Text = "Buying Price (£):";
            // 
            // NewProductPrice
            // 
            this.NewProductPrice.BackColor = System.Drawing.Color.White;
            this.NewProductPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NewProductPrice.Location = new System.Drawing.Point(143, 350);
            this.NewProductPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NewProductPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NewProductPrice.Name = "NewProductPrice";
            this.NewProductPrice.Size = new System.Drawing.Size(188, 20);
            this.NewProductPrice.TabIndex = 33;
            this.NewProductPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ExistingProductName
            // 
            this.ExistingProductName.Location = new System.Drawing.Point(143, 323);
            this.ExistingProductName.MaxLength = 30;
            this.ExistingProductName.Name = "ExistingProductName";
            this.ExistingProductName.Size = new System.Drawing.Size(188, 20);
            this.ExistingProductName.TabIndex = 34;
            // 
            // ButtonChange
            // 
            this.ButtonChange.AutoSize = false;
            this.ButtonChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChange.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonChange.Depth = 0;
            this.ButtonChange.HighEmphasis = true;
            this.ButtonChange.Icon = null;
            this.ButtonChange.Location = new System.Drawing.Point(338, 323);
            this.ButtonChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonChange.Size = new System.Drawing.Size(107, 47);
            this.ButtonChange.TabIndex = 35;
            this.ButtonChange.Text = "Change";
            this.ButtonChange.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonChange.UseAccentColor = false;
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // AlterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 440);
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.ExistingProductName);
            this.Controls.Add(this.NewProductPrice);
            this.Controls.Add(this.TextNewPrice);
            this.Controls.Add(this.TextExistingProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.ProductStock);
            this.Controls.Add(this.TextProductPrice);
            this.Controls.Add(this.TextProductStock);
            this.Controls.Add(this.TextProductCategory);
            this.Controls.Add(this.InputProductName);
            this.Controls.Add(this.TextProductName);
            this.Controls.Add(this.TextCategoryName);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.DiscontinueButton);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.TextDiscontinueProduct);
            this.Controls.Add(this.TextAddProduct);
            this.Controls.Add(this.TextAddCategory);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UnusedButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.AlterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton CloseButton;
        private System.Windows.Forms.Label TextAddCategory;
        private System.Windows.Forms.Label TextAddProduct;
        private System.Windows.Forms.Label TextDiscontinueProduct;
        private MaterialSkin.Controls.MaterialComboBox ProductList;
        private MaterialSkin.Controls.MaterialButton DiscontinueButton;
        private MaterialSkin.Controls.MaterialButton AddCategoryButton;
        private MaterialSkin.Controls.MaterialButton AddProductButton;
        private MaterialSkin.Controls.MaterialComboBox CategoryList;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.Label TextCategoryName;
        private System.Windows.Forms.Label TextProductName;
        private System.Windows.Forms.TextBox InputProductName;
        private System.Windows.Forms.Label TextProductCategory;
        private System.Windows.Forms.Label TextProductStock;
        private System.Windows.Forms.Label TextProductPrice;
        private System.Windows.Forms.NumericUpDown ProductStock;
        private System.Windows.Forms.NumericUpDown ProductPrice;
        private MaterialSkin.Controls.MaterialButton UnusedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextExistingProductName;
        private System.Windows.Forms.Label TextNewPrice;
        private System.Windows.Forms.NumericUpDown NewProductPrice;
        private System.Windows.Forms.TextBox ExistingProductName;
        private MaterialSkin.Controls.MaterialButton ButtonChange;
    }
}