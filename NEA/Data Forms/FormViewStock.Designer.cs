namespace NEA
{
    partial class FormViewStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewStock));
            this.TextSearch = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.ButtonChangePrice = new MaterialSkin.Controls.MaterialButton();
            this.ButtonDiscontinue = new MaterialSkin.Controls.MaterialButton();
            this.ButtonAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.ButtonAddCategory = new MaterialSkin.Controls.MaterialButton();
            this.ButtonClose = new MaterialSkin.Controls.MaterialButton();
            this.Database = new System.Windows.Forms.Label();
            this.TextWelcome = new System.Windows.Forms.Label();
            this.ButtonClear = new MaterialSkin.Controls.MaterialButton();
            this.TextFilter = new System.Windows.Forms.Label();
            this.TextSort = new System.Windows.Forms.Label();
            this.ComboBoxType = new MaterialSkin.Controls.MaterialComboBox();
            this.TextType = new System.Windows.Forms.Label();
            this.TextPrice = new System.Windows.Forms.Label();
            this.MinPrice = new System.Windows.Forms.NumericUpDown();
            this.MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.ButtonApplyPriceFilter = new MaterialSkin.Controls.MaterialButton();
            this.ButtonApplyCategoryFilter = new MaterialSkin.Controls.MaterialButton();
            this.TextSortBy = new System.Windows.Forms.Label();
            this.ComboBoxSort = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonApplySort = new MaterialSkin.Controls.MaterialButton();
            this.ButtonResetSort = new MaterialSkin.Controls.MaterialButton();
            this.ButtonUnused = new MaterialSkin.Controls.MaterialButton();
            this.DatabaseGrid = new System.Windows.Forms.DataGridView();
            this.BluePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSearch
            // 
            this.TextSearch.AutoSize = true;
            this.TextSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.TextSearch.Location = new System.Drawing.Point(226, 584);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(164, 19);
            this.TextSearch.TabIndex = 19;
            this.TextSearch.Text = "Search by Name or Type:";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(396, 585);
            this.SearchBox.MaxLength = 50;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(475, 20);
            this.SearchBox.TabIndex = 14;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.Color.Transparent;
            this.BluePanel.Controls.Add(this.ButtonChangePrice);
            this.BluePanel.Controls.Add(this.ButtonDiscontinue);
            this.BluePanel.Controls.Add(this.ButtonAddProduct);
            this.BluePanel.Controls.Add(this.ButtonAddCategory);
            this.BluePanel.Controls.Add(this.ButtonClose);
            this.BluePanel.Controls.Add(this.Database);
            this.BluePanel.Controls.Add(this.TextWelcome);
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BluePanel.Location = new System.Drawing.Point(0, 0);
            this.BluePanel.Margin = new System.Windows.Forms.Padding(2);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(221, 616);
            this.BluePanel.TabIndex = 15;
            // 
            // ButtonChangePrice
            // 
            this.ButtonChangePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonChangePrice.AutoSize = false;
            this.ButtonChangePrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChangePrice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonChangePrice.Depth = 0;
            this.ButtonChangePrice.HighEmphasis = true;
            this.ButtonChangePrice.Icon = null;
            this.ButtonChangePrice.Location = new System.Drawing.Point(5, 221);
            this.ButtonChangePrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonChangePrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChangePrice.Name = "ButtonChangePrice";
            this.ButtonChangePrice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonChangePrice.Size = new System.Drawing.Size(213, 49);
            this.ButtonChangePrice.TabIndex = 5;
            this.ButtonChangePrice.Text = "Change Product Price";
            this.ButtonChangePrice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonChangePrice.UseAccentColor = false;
            this.ButtonChangePrice.UseVisualStyleBackColor = true;
            this.ButtonChangePrice.Click += new System.EventHandler(this.ButtonChangePrice_Click);
            // 
            // ButtonDiscontinue
            // 
            this.ButtonDiscontinue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonDiscontinue.AutoSize = false;
            this.ButtonDiscontinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDiscontinue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonDiscontinue.Depth = 0;
            this.ButtonDiscontinue.HighEmphasis = true;
            this.ButtonDiscontinue.Icon = null;
            this.ButtonDiscontinue.Location = new System.Drawing.Point(5, 162);
            this.ButtonDiscontinue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonDiscontinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDiscontinue.Name = "ButtonDiscontinue";
            this.ButtonDiscontinue.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonDiscontinue.Size = new System.Drawing.Size(213, 49);
            this.ButtonDiscontinue.TabIndex = 4;
            this.ButtonDiscontinue.Text = "Discontinue Product";
            this.ButtonDiscontinue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonDiscontinue.UseAccentColor = false;
            this.ButtonDiscontinue.UseVisualStyleBackColor = true;
            this.ButtonDiscontinue.Click += new System.EventHandler(this.ButtonDiscontinue_Click);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonAddProduct.AutoSize = false;
            this.ButtonAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAddProduct.Depth = 0;
            this.ButtonAddProduct.HighEmphasis = true;
            this.ButtonAddProduct.Icon = null;
            this.ButtonAddProduct.Location = new System.Drawing.Point(5, 103);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAddProduct.Size = new System.Drawing.Size(213, 49);
            this.ButtonAddProduct.TabIndex = 3;
            this.ButtonAddProduct.Text = "Add Product";
            this.ButtonAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAddProduct.UseAccentColor = false;
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonAddCategory
            // 
            this.ButtonAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonAddCategory.AutoSize = false;
            this.ButtonAddCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAddCategory.Depth = 0;
            this.ButtonAddCategory.HighEmphasis = true;
            this.ButtonAddCategory.Icon = null;
            this.ButtonAddCategory.Location = new System.Drawing.Point(5, 44);
            this.ButtonAddCategory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonAddCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAddCategory.Name = "ButtonAddCategory";
            this.ButtonAddCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAddCategory.Size = new System.Drawing.Size(213, 49);
            this.ButtonAddCategory.TabIndex = 2;
            this.ButtonAddCategory.Text = "Add Category";
            this.ButtonAddCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAddCategory.UseAccentColor = false;
            this.ButtonAddCategory.UseVisualStyleBackColor = true;
            this.ButtonAddCategory.Click += new System.EventHandler(this.ButtonAddCategory_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonClose.AutoSize = false;
            this.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClose.Depth = 0;
            this.ButtonClose.HighEmphasis = true;
            this.ButtonClose.Icon = null;
            this.ButtonClose.Location = new System.Drawing.Point(5, 509);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClose.Size = new System.Drawing.Size(213, 49);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "Dashboard";
            this.ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClose.UseAccentColor = false;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Database
            // 
            this.Database.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Database.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.Database.ForeColor = System.Drawing.Color.Black;
            this.Database.Location = new System.Drawing.Point(0, 567);
            this.Database.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(221, 49);
            this.Database.TabIndex = 3;
            this.Database.Text = "Database";
            this.Database.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextWelcome
            // 
            this.TextWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextWelcome.ForeColor = System.Drawing.Color.Black;
            this.TextWelcome.Location = new System.Drawing.Point(0, 0);
            this.TextWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextWelcome.Name = "TextWelcome";
            this.TextWelcome.Size = new System.Drawing.Size(221, 38);
            this.TextWelcome.TabIndex = 2;
            this.TextWelcome.Text = "welcome, (blank)!";
            this.TextWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonClear.AutoSize = false;
            this.ButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClear.Depth = 0;
            this.ButtonClear.HighEmphasis = true;
            this.ButtonClear.Icon = null;
            this.ButtonClear.Location = new System.Drawing.Point(877, 584);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClear.Size = new System.Drawing.Size(110, 21);
            this.ButtonClear.TabIndex = 15;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClear.UseAccentColor = false;
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextFilter
            // 
            this.TextFilter.BackColor = System.Drawing.Color.Transparent;
            this.TextFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFilter.ForeColor = System.Drawing.Color.Black;
            this.TextFilter.Location = new System.Drawing.Point(225, 0);
            this.TextFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextFilter.Name = "TextFilter";
            this.TextFilter.Size = new System.Drawing.Size(221, 38);
            this.TextFilter.TabIndex = 7;
            this.TextFilter.Text = "Filter:";
            this.TextFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextSort
            // 
            this.TextSort.BackColor = System.Drawing.Color.Transparent;
            this.TextSort.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSort.ForeColor = System.Drawing.Color.Black;
            this.TextSort.Location = new System.Drawing.Point(628, 0);
            this.TextSort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextSort.Name = "TextSort";
            this.TextSort.Size = new System.Drawing.Size(221, 38);
            this.TextSort.TabIndex = 8;
            this.TextSort.Text = "Sort:";
            this.TextSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.AutoResize = false;
            this.ComboBoxType.BackColor = System.Drawing.Color.White;
            this.ComboBoxType.Depth = 0;
            this.ComboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxType.DropDownHeight = 292;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.DropDownWidth = 121;
            this.ComboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.IntegralHeight = false;
            this.ComboBoxType.ItemHeight = 29;
            this.ComboBoxType.Location = new System.Drawing.Point(273, 41);
            this.ComboBoxType.MaxDropDownItems = 10;
            this.ComboBoxType.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(212, 35);
            this.ComboBoxType.StartIndex = 0;
            this.ComboBoxType.TabIndex = 6;
            this.ComboBoxType.UseAccent = false;
            this.ComboBoxType.UseTallSize = false;
            // 
            // TextType
            // 
            this.TextType.AutoSize = true;
            this.TextType.BackColor = System.Drawing.Color.Transparent;
            this.TextType.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextType.ForeColor = System.Drawing.Color.Black;
            this.TextType.Location = new System.Drawing.Point(227, 41);
            this.TextType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextType.Name = "TextType";
            this.TextType.Size = new System.Drawing.Size(41, 19);
            this.TextType.TabIndex = 11;
            this.TextType.Text = "Type:";
            this.TextType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextPrice
            // 
            this.TextPrice.AutoSize = true;
            this.TextPrice.BackColor = System.Drawing.Color.Transparent;
            this.TextPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrice.ForeColor = System.Drawing.Color.Black;
            this.TextPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TextPrice.Location = new System.Drawing.Point(227, 82);
            this.TextPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(120, 38);
            this.TextPrice.TabIndex = 12;
            this.TextPrice.Text = "Selling Price from:\r\nto:";
            this.TextPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MinPrice
            // 
            this.MinPrice.Location = new System.Drawing.Point(352, 82);
            this.MinPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(133, 20);
            this.MinPrice.TabIndex = 8;
            this.MinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // MaxPrice
            // 
            this.MaxPrice.Location = new System.Drawing.Point(352, 101);
            this.MaxPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(133, 20);
            this.MaxPrice.TabIndex = 9;
            this.MaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ButtonApplyPriceFilter
            // 
            this.ButtonApplyPriceFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonApplyPriceFilter.AutoSize = false;
            this.ButtonApplyPriceFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyPriceFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyPriceFilter.Depth = 0;
            this.ButtonApplyPriceFilter.HighEmphasis = true;
            this.ButtonApplyPriceFilter.Icon = null;
            this.ButtonApplyPriceFilter.Location = new System.Drawing.Point(491, 82);
            this.ButtonApplyPriceFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonApplyPriceFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyPriceFilter.Name = "ButtonApplyPriceFilter";
            this.ButtonApplyPriceFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyPriceFilter.Size = new System.Drawing.Size(73, 41);
            this.ButtonApplyPriceFilter.TabIndex = 10;
            this.ButtonApplyPriceFilter.Text = "Apply";
            this.ButtonApplyPriceFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyPriceFilter.UseAccentColor = false;
            this.ButtonApplyPriceFilter.UseVisualStyleBackColor = true;
            this.ButtonApplyPriceFilter.Click += new System.EventHandler(this.ButtonApplyFilter_Click);
            // 
            // ButtonApplyCategoryFilter
            // 
            this.ButtonApplyCategoryFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonApplyCategoryFilter.AutoSize = false;
            this.ButtonApplyCategoryFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyCategoryFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyCategoryFilter.Depth = 0;
            this.ButtonApplyCategoryFilter.HighEmphasis = true;
            this.ButtonApplyCategoryFilter.Icon = null;
            this.ButtonApplyCategoryFilter.Location = new System.Drawing.Point(491, 41);
            this.ButtonApplyCategoryFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonApplyCategoryFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyCategoryFilter.Name = "ButtonApplyCategoryFilter";
            this.ButtonApplyCategoryFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyCategoryFilter.Size = new System.Drawing.Size(73, 35);
            this.ButtonApplyCategoryFilter.TabIndex = 7;
            this.ButtonApplyCategoryFilter.Text = "Apply";
            this.ButtonApplyCategoryFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyCategoryFilter.UseAccentColor = false;
            this.ButtonApplyCategoryFilter.UseVisualStyleBackColor = true;
            this.ButtonApplyCategoryFilter.Click += new System.EventHandler(this.ButtonApplyCategoryFilter_Click);
            // 
            // TextSortBy
            // 
            this.TextSortBy.AutoSize = true;
            this.TextSortBy.BackColor = System.Drawing.Color.Transparent;
            this.TextSortBy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSortBy.ForeColor = System.Drawing.Color.Black;
            this.TextSortBy.Location = new System.Drawing.Point(630, 46);
            this.TextSortBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextSortBy.Name = "TextSortBy";
            this.TextSortBy.Size = new System.Drawing.Size(27, 19);
            this.TextSortBy.TabIndex = 24;
            this.TextSortBy.Text = "By:";
            this.TextSortBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.AutoResize = false;
            this.ComboBoxSort.BackColor = System.Drawing.Color.White;
            this.ComboBoxSort.Depth = 0;
            this.ComboBoxSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxSort.DropDownHeight = 292;
            this.ComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSort.DropDownWidth = 121;
            this.ComboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.IntegralHeight = false;
            this.ComboBoxSort.ItemHeight = 29;
            this.ComboBoxSort.Location = new System.Drawing.Point(666, 41);
            this.ComboBoxSort.MaxDropDownItems = 10;
            this.ComboBoxSort.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(242, 35);
            this.ComboBoxSort.StartIndex = 0;
            this.ComboBoxSort.TabIndex = 11;
            this.ComboBoxSort.UseAccent = false;
            this.ComboBoxSort.UseTallSize = false;
            // 
            // ButtonApplySort
            // 
            this.ButtonApplySort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonApplySort.AutoSize = false;
            this.ButtonApplySort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplySort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplySort.Depth = 0;
            this.ButtonApplySort.HighEmphasis = true;
            this.ButtonApplySort.Icon = null;
            this.ButtonApplySort.Location = new System.Drawing.Point(913, 41);
            this.ButtonApplySort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonApplySort.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplySort.Name = "ButtonApplySort";
            this.ButtonApplySort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplySort.Size = new System.Drawing.Size(73, 35);
            this.ButtonApplySort.TabIndex = 13;
            this.ButtonApplySort.Text = "Apply";
            this.ButtonApplySort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplySort.UseAccentColor = false;
            this.ButtonApplySort.UseVisualStyleBackColor = true;
            this.ButtonApplySort.Click += new System.EventHandler(this.ButtonApplySort_Click);
            // 
            // ButtonResetSort
            // 
            this.ButtonResetSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonResetSort.AutoSize = false;
            this.ButtonResetSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonResetSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonResetSort.Depth = 0;
            this.ButtonResetSort.HighEmphasis = true;
            this.ButtonResetSort.Icon = null;
            this.ButtonResetSort.Location = new System.Drawing.Point(633, 80);
            this.ButtonResetSort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonResetSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonResetSort.Name = "ButtonResetSort";
            this.ButtonResetSort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonResetSort.Size = new System.Drawing.Size(353, 41);
            this.ButtonResetSort.TabIndex = 12;
            this.ButtonResetSort.Text = "Reset All Sorts and Filters";
            this.ButtonResetSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonResetSort.UseAccentColor = false;
            this.ButtonResetSort.UseVisualStyleBackColor = true;
            this.ButtonResetSort.Click += new System.EventHandler(this.ButtonResetSort_Click);
            // 
            // ButtonUnused
            // 
            this.ButtonUnused.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonUnused.AutoSize = false;
            this.ButtonUnused.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonUnused.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonUnused.Depth = 0;
            this.ButtonUnused.HighEmphasis = true;
            this.ButtonUnused.Icon = null;
            this.ButtonUnused.Location = new System.Drawing.Point(534, 288);
            this.ButtonUnused.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonUnused.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonUnused.Name = "ButtonUnused";
            this.ButtonUnused.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonUnused.Size = new System.Drawing.Size(94, 21);
            this.ButtonUnused.TabIndex = 28;
            this.ButtonUnused.Text = "Unused";
            this.ButtonUnused.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonUnused.UseAccentColor = false;
            this.ButtonUnused.UseVisualStyleBackColor = true;
            // 
            // DatabaseGrid
            // 
            this.DatabaseGrid.AllowUserToAddRows = false;
            this.DatabaseGrid.AllowUserToDeleteRows = false;
            this.DatabaseGrid.AllowUserToResizeColumns = false;
            this.DatabaseGrid.AllowUserToResizeRows = false;
            this.DatabaseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatabaseGrid.BackgroundColor = System.Drawing.Color.White;
            this.DatabaseGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DatabaseGrid.EnableHeadersVisualStyles = false;
            this.DatabaseGrid.GridColor = System.Drawing.Color.White;
            this.DatabaseGrid.Location = new System.Drawing.Point(226, 131);
            this.DatabaseGrid.Name = "DatabaseGrid";
            this.DatabaseGrid.RowHeadersVisible = false;
            this.DatabaseGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseGrid.ShowCellErrors = false;
            this.DatabaseGrid.ShowCellToolTips = false;
            this.DatabaseGrid.ShowEditingIcon = false;
            this.DatabaseGrid.ShowRowErrors = false;
            this.DatabaseGrid.Size = new System.Drawing.Size(761, 440);
            this.DatabaseGrid.TabIndex = 29;
            // 
            // FormViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 616);
            this.Controls.Add(this.DatabaseGrid);
            this.Controls.Add(this.ButtonResetSort);
            this.Controls.Add(this.ButtonApplySort);
            this.Controls.Add(this.ComboBoxSort);
            this.Controls.Add(this.TextSortBy);
            this.Controls.Add(this.ButtonApplyCategoryFilter);
            this.Controls.Add(this.ButtonApplyPriceFilter);
            this.Controls.Add(this.MaxPrice);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.MinPrice);
            this.Controls.Add(this.TextSort);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.TextPrice);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.TextType);
            this.Controls.Add(this.BluePanel);
            this.Controls.Add(this.TextFilter);
            this.Controls.Add(this.ButtonUnused);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormViewStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.ViewStockForm_Load);
            this.BluePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextSearch;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel BluePanel;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.Label TextWelcome;
        private MaterialSkin.Controls.MaterialButton ButtonClear;
        private MaterialSkin.Controls.MaterialButton ButtonDiscontinue;
        private MaterialSkin.Controls.MaterialButton ButtonAddProduct;
        private MaterialSkin.Controls.MaterialButton ButtonAddCategory;
        private System.Windows.Forms.Label TextPrice;
        private System.Windows.Forms.Label TextType;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxType;
        private System.Windows.Forms.Label TextSort;
        private System.Windows.Forms.Label TextFilter;
        private System.Windows.Forms.NumericUpDown MaxPrice;
        private System.Windows.Forms.NumericUpDown MinPrice;
        private MaterialSkin.Controls.MaterialButton ButtonApplyPriceFilter;
        private MaterialSkin.Controls.MaterialButton ButtonApplyCategoryFilter;
        private System.Windows.Forms.Label TextSortBy;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSort;
        private MaterialSkin.Controls.MaterialButton ButtonApplySort;
        private MaterialSkin.Controls.MaterialButton ButtonResetSort;
        private MaterialSkin.Controls.MaterialButton ButtonUnused;
        private System.Windows.Forms.DataGridView DatabaseGrid;
        private MaterialSkin.Controls.MaterialButton ButtonChangePrice;
    }
}