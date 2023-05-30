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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAlter));
            CloseButton = new MaterialSkin.Controls.MaterialButton();
            TextAddCategory = new Label();
            TextAddProduct = new Label();
            TextDiscontinueProduct = new Label();
            ProductList = new MaterialSkin.Controls.MaterialComboBox();
            DiscontinueButton = new MaterialSkin.Controls.MaterialButton();
            AddCategoryButton = new MaterialSkin.Controls.MaterialButton();
            AddProductButton = new MaterialSkin.Controls.MaterialButton();
            CategoryList = new MaterialSkin.Controls.MaterialComboBox();
            CategoryName = new TextBox();
            TextCategoryName = new Label();
            TextProductName = new Label();
            InputProductName = new TextBox();
            TextProductCategory = new Label();
            TextProductStock = new Label();
            TextProductPrice = new Label();
            ProductStock = new NumericUpDown();
            ProductPrice = new NumericUpDown();
            UnusedButton = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            TextExistingProductName = new Label();
            TextNewPrice = new Label();
            NewProductPrice = new NumericUpDown();
            ExistingProductName = new TextBox();
            ButtonChange = new MaterialSkin.Controls.MaterialButton();
            ((ISupportInitialize)ProductStock).BeginInit();
            ((ISupportInitialize)ProductPrice).BeginInit();
            ((ISupportInitialize)NewProductPrice).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = false;
            CloseButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CloseButton.Depth = 0;
            CloseButton.HighEmphasis = true;
            CloseButton.Icon = null;
            CloseButton.Location = new Point(14, 449);
            CloseButton.Margin = new Padding(5, 7, 5, 7);
            CloseButton.MouseState = MouseState.HOVER;
            CloseButton.Name = "CloseButton";
            CloseButton.NoAccentTextColor = Color.Empty;
            CloseButton.Size = new Size(505, 42);
            CloseButton.TabIndex = 11;
            CloseButton.Text = "Close";
            CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            CloseButton.UseAccentColor = false;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // TextAddCategory
            // 
            TextAddCategory.AutoSize = true;
            TextAddCategory.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TextAddCategory.Location = new Point(14, 10);
            TextAddCategory.Margin = new Padding(4, 0, 4, 0);
            TextAddCategory.Name = "TextAddCategory";
            TextAddCategory.Size = new Size(95, 17);
            TextAddCategory.TabIndex = 1;
            TextAddCategory.Text = "Add Category:";
            // 
            // TextAddProduct
            // 
            TextAddProduct.AutoSize = true;
            TextAddProduct.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TextAddProduct.Location = new Point(14, 85);
            TextAddProduct.Margin = new Padding(4, 0, 4, 0);
            TextAddProduct.Name = "TextAddProduct";
            TextAddProduct.Size = new Size(88, 17);
            TextAddProduct.TabIndex = 2;
            TextAddProduct.Text = "Add Product:";
            // 
            // TextDiscontinueProduct
            // 
            TextDiscontinueProduct.AutoSize = true;
            TextDiscontinueProduct.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TextDiscontinueProduct.Location = new Point(14, 262);
            TextDiscontinueProduct.Margin = new Padding(4, 0, 4, 0);
            TextDiscontinueProduct.Name = "TextDiscontinueProduct";
            TextDiscontinueProduct.Size = new Size(137, 17);
            TextDiscontinueProduct.TabIndex = 3;
            TextDiscontinueProduct.Text = "Discontinue Product:";
            // 
            // ProductList
            // 
            ProductList.AutoResize = false;
            ProductList.BackColor = Color.FromArgb(255, 255, 255);
            ProductList.Depth = 0;
            ProductList.DrawMode = DrawMode.OwnerDrawVariable;
            ProductList.DropDownHeight = 292;
            ProductList.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductList.DropDownWidth = 121;
            ProductList.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ProductList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ProductList.FormattingEnabled = true;
            ProductList.IntegralHeight = false;
            ProductList.ItemHeight = 29;
            ProductList.Location = new Point(14, 285);
            ProductList.Margin = new Padding(4, 3, 4, 3);
            ProductList.MaxDropDownItems = 10;
            ProductList.MouseState = MouseState.OUT;
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(372, 35);
            ProductList.StartIndex = 0;
            ProductList.TabIndex = 9;
            ProductList.UseAccent = false;
            ProductList.UseTallSize = false;
            // 
            // DiscontinueButton
            // 
            DiscontinueButton.AutoSize = false;
            DiscontinueButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DiscontinueButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DiscontinueButton.Depth = 0;
            DiscontinueButton.HighEmphasis = true;
            DiscontinueButton.Icon = null;
            DiscontinueButton.Location = new Point(394, 285);
            DiscontinueButton.Margin = new Padding(5, 7, 5, 7);
            DiscontinueButton.MouseState = MouseState.HOVER;
            DiscontinueButton.Name = "DiscontinueButton";
            DiscontinueButton.NoAccentTextColor = Color.Empty;
            DiscontinueButton.Size = new Size(125, 40);
            DiscontinueButton.TabIndex = 10;
            DiscontinueButton.Text = "Discontinue";
            DiscontinueButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DiscontinueButton.UseAccentColor = false;
            DiscontinueButton.UseVisualStyleBackColor = true;
            DiscontinueButton.Click += DiscontinueButton_Click;
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.AutoSize = false;
            AddCategoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddCategoryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddCategoryButton.Depth = 0;
            AddCategoryButton.HighEmphasis = true;
            AddCategoryButton.Icon = null;
            AddCategoryButton.Location = new Point(394, 45);
            AddCategoryButton.Margin = new Padding(5, 7, 5, 7);
            AddCategoryButton.MouseState = MouseState.HOVER;
            AddCategoryButton.Name = "AddCategoryButton";
            AddCategoryButton.NoAccentTextColor = Color.Empty;
            AddCategoryButton.Size = new Size(125, 23);
            AddCategoryButton.TabIndex = 3;
            AddCategoryButton.Text = "Add";
            AddCategoryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddCategoryButton.UseAccentColor = false;
            AddCategoryButton.UseVisualStyleBackColor = true;
            AddCategoryButton.Click += AddCategoryButton_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.AutoSize = false;
            AddProductButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddProductButton.Depth = 0;
            AddProductButton.HighEmphasis = true;
            AddProductButton.Icon = null;
            AddProductButton.Location = new Point(394, 117);
            AddProductButton.Margin = new Padding(5, 7, 5, 7);
            AddProductButton.MouseState = MouseState.HOVER;
            AddProductButton.Name = "AddProductButton";
            AddProductButton.NoAccentTextColor = Color.Empty;
            AddProductButton.Size = new Size(125, 129);
            AddProductButton.TabIndex = 8;
            AddProductButton.Text = "Add";
            AddProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddProductButton.UseAccentColor = false;
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // CategoryList
            // 
            CategoryList.AutoResize = false;
            CategoryList.BackColor = Color.White;
            CategoryList.Depth = 0;
            CategoryList.DrawMode = DrawMode.OwnerDrawVariable;
            CategoryList.DropDownHeight = 292;
            CategoryList.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryList.DropDownWidth = 121;
            CategoryList.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CategoryList.FormattingEnabled = true;
            CategoryList.IntegralHeight = false;
            CategoryList.ItemHeight = 29;
            CategoryList.Location = new Point(167, 145);
            CategoryList.Margin = new Padding(4, 3, 4, 3);
            CategoryList.MaxDropDownItems = 10;
            CategoryList.MouseState = MouseState.OUT;
            CategoryList.Name = "CategoryList";
            CategoryList.Size = new Size(219, 35);
            CategoryList.StartIndex = 0;
            CategoryList.TabIndex = 5;
            CategoryList.UseAccent = false;
            CategoryList.UseTallSize = false;
            // 
            // CategoryName
            // 
            CategoryName.Location = new Point(167, 45);
            CategoryName.Margin = new Padding(4, 3, 4, 3);
            CategoryName.MaxLength = 30;
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(219, 23);
            CategoryName.TabIndex = 2;
            // 
            // TextCategoryName
            // 
            TextCategoryName.AutoSize = true;
            TextCategoryName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextCategoryName.Location = new Point(14, 45);
            TextCategoryName.Margin = new Padding(4, 0, 4, 0);
            TextCategoryName.Name = "TextCategoryName";
            TextCategoryName.Size = new Size(103, 17);
            TextCategoryName.TabIndex = 24;
            TextCategoryName.Text = "Category Name:";
            // 
            // TextProductName
            // 
            TextProductName.AutoSize = true;
            TextProductName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextProductName.Location = new Point(15, 117);
            TextProductName.Margin = new Padding(4, 0, 4, 0);
            TextProductName.Name = "TextProductName";
            TextProductName.Size = new Size(95, 17);
            TextProductName.TabIndex = 25;
            TextProductName.Text = "Product Name:";
            // 
            // InputProductName
            // 
            InputProductName.Location = new Point(167, 115);
            InputProductName.Margin = new Padding(4, 3, 4, 3);
            InputProductName.MaxLength = 30;
            InputProductName.Name = "InputProductName";
            InputProductName.Size = new Size(219, 23);
            InputProductName.TabIndex = 4;
            // 
            // TextProductCategory
            // 
            TextProductCategory.AutoSize = true;
            TextProductCategory.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextProductCategory.Location = new Point(15, 152);
            TextProductCategory.Margin = new Padding(4, 0, 4, 0);
            TextProductCategory.Name = "TextProductCategory";
            TextProductCategory.Size = new Size(113, 17);
            TextProductCategory.TabIndex = 27;
            TextProductCategory.Text = "Product Category:";
            // 
            // TextProductStock
            // 
            TextProductStock.AutoSize = true;
            TextProductStock.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextProductStock.Location = new Point(14, 193);
            TextProductStock.Margin = new Padding(4, 0, 4, 0);
            TextProductStock.Name = "TextProductStock";
            TextProductStock.Size = new Size(92, 17);
            TextProductStock.TabIndex = 28;
            TextProductStock.Text = "Product Stock:";
            // 
            // TextProductPrice
            // 
            TextProductPrice.AutoSize = true;
            TextProductPrice.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextProductPrice.Location = new Point(15, 223);
            TextProductPrice.Margin = new Padding(4, 0, 4, 0);
            TextProductPrice.Name = "TextProductPrice";
            TextProductPrice.Size = new Size(101, 17);
            TextProductPrice.TabIndex = 29;
            TextProductPrice.Text = "Buying Price (£):";
            // 
            // ProductStock
            // 
            ProductStock.BackColor = Color.White;
            ProductStock.Location = new Point(167, 193);
            ProductStock.Margin = new Padding(4, 3, 4, 3);
            ProductStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ProductStock.Name = "ProductStock";
            ProductStock.Size = new Size(219, 23);
            ProductStock.TabIndex = 6;
            ProductStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ProductPrice
            // 
            ProductPrice.BackColor = Color.White;
            ProductPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            ProductPrice.Location = new Point(167, 223);
            ProductPrice.Margin = new Padding(4, 3, 4, 3);
            ProductPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ProductPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(219, 23);
            ProductPrice.TabIndex = 7;
            ProductPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // UnusedButton
            // 
            UnusedButton.AutoSize = false;
            UnusedButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UnusedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            UnusedButton.Depth = 0;
            UnusedButton.HighEmphasis = true;
            UnusedButton.Icon = null;
            UnusedButton.Location = new Point(429, 193);
            UnusedButton.Margin = new Padding(5, 7, 5, 7);
            UnusedButton.MouseState = MouseState.HOVER;
            UnusedButton.Name = "UnusedButton";
            UnusedButton.NoAccentTextColor = Color.Empty;
            UnusedButton.Size = new Size(51, 42);
            UnusedButton.TabIndex = 1;
            UnusedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            UnusedButton.UseAccentColor = false;
            UnusedButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 343);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 30;
            label1.Text = "Change Product Price:";
            // 
            // TextExistingProductName
            // 
            TextExistingProductName.AutoSize = true;
            TextExistingProductName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextExistingProductName.Location = new Point(15, 374);
            TextExistingProductName.Margin = new Padding(4, 0, 4, 0);
            TextExistingProductName.Name = "TextExistingProductName";
            TextExistingProductName.Size = new Size(95, 17);
            TextExistingProductName.TabIndex = 31;
            TextExistingProductName.Text = "Product Name:";
            // 
            // TextNewPrice
            // 
            TextNewPrice.AutoSize = true;
            TextNewPrice.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextNewPrice.Location = new Point(16, 404);
            TextNewPrice.Margin = new Padding(4, 0, 4, 0);
            TextNewPrice.Name = "TextNewPrice";
            TextNewPrice.Size = new Size(101, 17);
            TextNewPrice.TabIndex = 32;
            TextNewPrice.Text = "Buying Price (£):";
            // 
            // NewProductPrice
            // 
            NewProductPrice.BackColor = Color.White;
            NewProductPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NewProductPrice.Location = new Point(167, 404);
            NewProductPrice.Margin = new Padding(4, 3, 4, 3);
            NewProductPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NewProductPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NewProductPrice.Name = "NewProductPrice";
            NewProductPrice.Size = new Size(219, 23);
            NewProductPrice.TabIndex = 33;
            NewProductPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ExistingProductName
            // 
            ExistingProductName.Location = new Point(167, 373);
            ExistingProductName.Margin = new Padding(4, 3, 4, 3);
            ExistingProductName.MaxLength = 30;
            ExistingProductName.Name = "ExistingProductName";
            ExistingProductName.Size = new Size(219, 23);
            ExistingProductName.TabIndex = 34;
            // 
            // ButtonChange
            // 
            ButtonChange.AutoSize = false;
            ButtonChange.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonChange.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonChange.Depth = 0;
            ButtonChange.HighEmphasis = true;
            ButtonChange.Icon = null;
            ButtonChange.Location = new Point(394, 373);
            ButtonChange.Margin = new Padding(5, 7, 5, 7);
            ButtonChange.MouseState = MouseState.HOVER;
            ButtonChange.Name = "ButtonChange";
            ButtonChange.NoAccentTextColor = Color.Empty;
            ButtonChange.Size = new Size(125, 54);
            ButtonChange.TabIndex = 35;
            ButtonChange.Text = "Change";
            ButtonChange.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonChange.UseAccentColor = false;
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // FormAlter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(534, 508);
            Controls.Add(ButtonChange);
            Controls.Add(ExistingProductName);
            Controls.Add(NewProductPrice);
            Controls.Add(TextNewPrice);
            Controls.Add(TextExistingProductName);
            Controls.Add(label1);
            Controls.Add(ProductPrice);
            Controls.Add(ProductStock);
            Controls.Add(TextProductPrice);
            Controls.Add(TextProductStock);
            Controls.Add(TextProductCategory);
            Controls.Add(InputProductName);
            Controls.Add(TextProductName);
            Controls.Add(TextCategoryName);
            Controls.Add(CategoryName);
            Controls.Add(CategoryList);
            Controls.Add(AddProductButton);
            Controls.Add(AddCategoryButton);
            Controls.Add(DiscontinueButton);
            Controls.Add(ProductList);
            Controls.Add(TextDiscontinueProduct);
            Controls.Add(TextAddProduct);
            Controls.Add(TextAddCategory);
            Controls.Add(CloseButton);
            Controls.Add(UnusedButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAlter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += AlterForm_Load;
            ((ISupportInitialize)ProductStock).EndInit();
            ((ISupportInitialize)ProductPrice).EndInit();
            ((ISupportInitialize)NewProductPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
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