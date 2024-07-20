namespace Inventory.DataForms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormViewStock));
            LeftPanel = new Panel();
            ButtonClose = new MaterialSkin.Controls.MaterialButton();
            ButtonChangePrice = new MaterialSkin.Controls.MaterialButton();
            ButtonDiscontinue = new MaterialSkin.Controls.MaterialButton();
            ButtonAddProduct = new MaterialSkin.Controls.MaterialButton();
            ButtonAddCategory = new MaterialSkin.Controls.MaterialButton();
            TextWelcome = new Label();
            TextFilter = new Label();
            TextSort = new Label();
            DatabaseGrid = new DataGridView();
            TextSearch = new Label();
            SearchBox = new TextBox();
            ButtonClear = new MaterialSkin.Controls.MaterialButton();
            TextType = new Label();
            ComboBoxType = new MaterialSkin.Controls.MaterialComboBox();
            TextSortBy = new Label();
            ComboBoxSort = new MaterialSkin.Controls.MaterialComboBox();
            ButtonApplyCategoryFilter = new MaterialSkin.Controls.MaterialButton();
            ButtonApplySort = new MaterialSkin.Controls.MaterialButton();
            ButtonResetSort = new MaterialSkin.Controls.MaterialButton();
            ButtonSearch = new MaterialSkin.Controls.MaterialButton();
            LeftPanel.SuspendLayout();
            ((ISupportInitialize)DatabaseGrid).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.Transparent;
            LeftPanel.Controls.Add(ButtonClose);
            LeftPanel.Controls.Add(ButtonChangePrice);
            LeftPanel.Controls.Add(ButtonDiscontinue);
            LeftPanel.Controls.Add(ButtonAddProduct);
            LeftPanel.Controls.Add(ButtonAddCategory);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(221, 616);
            LeftPanel.TabIndex = 0;
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Left;
            ButtonClose.AutoSize = false;
            ButtonClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonClose.Depth = 0;
            ButtonClose.HighEmphasis = true;
            ButtonClose.Icon = null;
            ButtonClose.Location = new Point(3, 561);
            ButtonClose.Margin = new Padding(4, 6, 4, 6);
            ButtonClose.MouseState = MouseState.HOVER;
            ButtonClose.Name = "ButtonClose";
            ButtonClose.NoAccentTextColor = Color.Empty;
            ButtonClose.Size = new Size(214, 49);
            ButtonClose.TabIndex = 6;
            ButtonClose.Text = "Dashboard";
            ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClose.UseAccentColor = false;
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ButtonChangePrice
            // 
            ButtonChangePrice.Anchor = AnchorStyles.Left;
            ButtonChangePrice.AutoSize = false;
            ButtonChangePrice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonChangePrice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonChangePrice.Depth = 0;
            ButtonChangePrice.HighEmphasis = true;
            ButtonChangePrice.Icon = null;
            ButtonChangePrice.Location = new Point(3, 221);
            ButtonChangePrice.Margin = new Padding(4, 6, 4, 6);
            ButtonChangePrice.MouseState = MouseState.HOVER;
            ButtonChangePrice.Name = "ButtonChangePrice";
            ButtonChangePrice.NoAccentTextColor = Color.Empty;
            ButtonChangePrice.Size = new Size(214, 49);
            ButtonChangePrice.TabIndex = 5;
            ButtonChangePrice.Text = "Change Price";
            ButtonChangePrice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonChangePrice.UseAccentColor = false;
            ButtonChangePrice.UseVisualStyleBackColor = false;
            ButtonChangePrice.Click += ButtonChangePrice_Click;
            // 
            // ButtonDiscontinue
            // 
            ButtonDiscontinue.Anchor = AnchorStyles.Left;
            ButtonDiscontinue.AutoSize = false;
            ButtonDiscontinue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonDiscontinue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonDiscontinue.Depth = 0;
            ButtonDiscontinue.HighEmphasis = true;
            ButtonDiscontinue.Icon = null;
            ButtonDiscontinue.Location = new Point(3, 162);
            ButtonDiscontinue.Margin = new Padding(4, 6, 4, 6);
            ButtonDiscontinue.MouseState = MouseState.HOVER;
            ButtonDiscontinue.Name = "ButtonDiscontinue";
            ButtonDiscontinue.NoAccentTextColor = Color.Empty;
            ButtonDiscontinue.Size = new Size(214, 49);
            ButtonDiscontinue.TabIndex = 4;
            ButtonDiscontinue.Text = "Discontinue Product";
            ButtonDiscontinue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonDiscontinue.UseAccentColor = false;
            ButtonDiscontinue.UseVisualStyleBackColor = false;
            ButtonDiscontinue.Click += ButtonDiscontinue_Click;
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Anchor = AnchorStyles.Left;
            ButtonAddProduct.AutoSize = false;
            ButtonAddProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonAddProduct.Depth = 0;
            ButtonAddProduct.HighEmphasis = true;
            ButtonAddProduct.Icon = null;
            ButtonAddProduct.Location = new Point(3, 103);
            ButtonAddProduct.Margin = new Padding(4, 6, 4, 6);
            ButtonAddProduct.MouseState = MouseState.HOVER;
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.NoAccentTextColor = Color.Empty;
            ButtonAddProduct.Size = new Size(214, 49);
            ButtonAddProduct.TabIndex = 3;
            ButtonAddProduct.Text = "Add Product";
            ButtonAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonAddProduct.UseAccentColor = false;
            ButtonAddProduct.UseVisualStyleBackColor = false;
            ButtonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // ButtonAddCategory
            // 
            ButtonAddCategory.Anchor = AnchorStyles.Left;
            ButtonAddCategory.AutoSize = false;
            ButtonAddCategory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAddCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonAddCategory.Depth = 0;
            ButtonAddCategory.HighEmphasis = true;
            ButtonAddCategory.Icon = null;
            ButtonAddCategory.Location = new Point(4, 44);
            ButtonAddCategory.Margin = new Padding(4, 6, 4, 6);
            ButtonAddCategory.MouseState = MouseState.HOVER;
            ButtonAddCategory.Name = "ButtonAddCategory";
            ButtonAddCategory.NoAccentTextColor = Color.Empty;
            ButtonAddCategory.Size = new Size(214, 49);
            ButtonAddCategory.TabIndex = 2;
            ButtonAddCategory.Text = "Add Category";
            ButtonAddCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonAddCategory.UseAccentColor = false;
            ButtonAddCategory.UseVisualStyleBackColor = false;
            ButtonAddCategory.Click += ButtonAddCategory_Click;
            // 
            // TextWelcome
            // 
            TextWelcome.Font = new Font("Segoe UI", 15.75F);
            TextWelcome.Location = new Point(0, 0);
            TextWelcome.Name = "TextWelcome";
            TextWelcome.Size = new Size(221, 38);
            TextWelcome.TabIndex = 1;
            TextWelcome.Text = "welcome, {username}!";
            TextWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextFilter
            // 
            TextFilter.Font = new Font("Segoe UI", 15.75F);
            TextFilter.Location = new Point(226, 0);
            TextFilter.Name = "TextFilter";
            TextFilter.Size = new Size(221, 38);
            TextFilter.TabIndex = 2;
            TextFilter.Text = "Filter:";
            TextFilter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextSort
            // 
            TextSort.Font = new Font("Segoe UI", 15.75F);
            TextSort.Location = new Point(552, 0);
            TextSort.Name = "TextSort";
            TextSort.Size = new Size(358, 38);
            TextSort.TabIndex = 3;
            TextSort.Text = "Sort:";
            TextSort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DatabaseGrid
            // 
            DatabaseGrid.AllowUserToAddRows = false;
            DatabaseGrid.AllowUserToDeleteRows = false;
            DatabaseGrid.AllowUserToResizeColumns = false;
            DatabaseGrid.AllowUserToResizeRows = false;
            DatabaseGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatabaseGrid.BackgroundColor = Color.White;
            DatabaseGrid.BorderStyle = BorderStyle.None;
            DatabaseGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DatabaseGrid.DefaultCellStyle = dataGridViewCellStyle1;
            DatabaseGrid.EnableHeadersVisualStyles = false;
            DatabaseGrid.GridColor = Color.White;
            DatabaseGrid.Location = new Point(226, 103);
            DatabaseGrid.Name = "DatabaseGrid";
            DatabaseGrid.ReadOnly = true;
            DatabaseGrid.RowHeadersVisible = false;
            DatabaseGrid.ShowCellErrors = false;
            DatabaseGrid.ShowCellToolTips = false;
            DatabaseGrid.ShowEditingIcon = false;
            DatabaseGrid.ShowRowErrors = false;
            DatabaseGrid.Size = new Size(761, 468);
            DatabaseGrid.TabIndex = 29;
            // 
            // TextSearch
            // 
            TextSearch.AutoSize = true;
            TextSearch.BackColor = Color.Transparent;
            TextSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextSearch.Location = new Point(224, 586);
            TextSearch.Name = "TextSearch";
            TextSearch.Size = new Size(155, 17);
            TextSearch.TabIndex = 30;
            TextSearch.Text = "Search by Name or Type:";
            TextSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBox.Location = new Point(387, 585);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(405, 23);
            SearchBox.TabIndex = 31;
            SearchBox.KeyDown += SearchBox_KeyDown;
            // 
            // ButtonClear
            // 
            ButtonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClear.AutoSize = false;
            ButtonClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonClear.Depth = 0;
            ButtonClear.Font = new Font("Segoe UI", 8.25F);
            ButtonClear.HighEmphasis = true;
            ButtonClear.Icon = null;
            ButtonClear.Location = new Point(899, 580);
            ButtonClear.Margin = new Padding(4, 6, 4, 6);
            ButtonClear.MouseState = MouseState.HOVER;
            ButtonClear.Name = "ButtonClear";
            ButtonClear.NoAccentTextColor = Color.Empty;
            ButtonClear.Size = new Size(92, 30);
            ButtonClear.TabIndex = 32;
            ButtonClear.Text = "Clear";
            ButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClear.UseAccentColor = false;
            ButtonClear.UseVisualStyleBackColor = false;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // TextType
            // 
            TextType.AutoSize = true;
            TextType.Font = new Font("Segoe UI", 9.75F);
            TextType.Location = new Point(227, 41);
            TextType.Name = "TextType";
            TextType.Size = new Size(38, 17);
            TextType.TabIndex = 33;
            TextType.Text = "Type:";
            TextType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboBoxType
            // 
            ComboBoxType.AutoResize = false;
            ComboBoxType.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxType.Depth = 0;
            ComboBoxType.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxType.DropDownHeight = 174;
            ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxType.DropDownWidth = 121;
            ComboBoxType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxType.FormattingEnabled = true;
            ComboBoxType.IntegralHeight = false;
            ComboBoxType.ItemHeight = 43;
            ComboBoxType.Location = new Point(273, 41);
            ComboBoxType.MaxDropDownItems = 4;
            ComboBoxType.MouseState = MouseState.OUT;
            ComboBoxType.Name = "ComboBoxType";
            ComboBoxType.Size = new Size(199, 49);
            ComboBoxType.StartIndex = 0;
            ComboBoxType.TabIndex = 34;
            // 
            // TextSortBy
            // 
            TextSortBy.AutoSize = true;
            TextSortBy.Font = new Font("Segoe UI", 9.75F);
            TextSortBy.Location = new Point(554, 41);
            TextSortBy.Name = "TextSortBy";
            TextSortBy.Size = new Size(24, 17);
            TextSortBy.TabIndex = 35;
            TextSortBy.Text = "By:";
            TextSortBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboBoxSort
            // 
            ComboBoxSort.AutoResize = false;
            ComboBoxSort.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxSort.Depth = 0;
            ComboBoxSort.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxSort.DropDownHeight = 174;
            ComboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSort.DropDownWidth = 121;
            ComboBoxSort.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxSort.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxSort.FormattingEnabled = true;
            ComboBoxSort.IntegralHeight = false;
            ComboBoxSort.ItemHeight = 43;
            ComboBoxSort.Location = new Point(596, 41);
            ComboBoxSort.MaxDropDownItems = 4;
            ComboBoxSort.MouseState = MouseState.OUT;
            ComboBoxSort.Name = "ComboBoxSort";
            ComboBoxSort.Size = new Size(243, 49);
            ComboBoxSort.StartIndex = 0;
            ComboBoxSort.TabIndex = 36;
            // 
            // ButtonApplyCategoryFilter
            // 
            ButtonApplyCategoryFilter.Anchor = AnchorStyles.Left;
            ButtonApplyCategoryFilter.AutoSize = false;
            ButtonApplyCategoryFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonApplyCategoryFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonApplyCategoryFilter.Depth = 0;
            ButtonApplyCategoryFilter.HighEmphasis = true;
            ButtonApplyCategoryFilter.Icon = null;
            ButtonApplyCategoryFilter.Location = new Point(479, 41);
            ButtonApplyCategoryFilter.Margin = new Padding(4, 6, 4, 6);
            ButtonApplyCategoryFilter.MouseState = MouseState.HOVER;
            ButtonApplyCategoryFilter.Name = "ButtonApplyCategoryFilter";
            ButtonApplyCategoryFilter.NoAccentTextColor = Color.Empty;
            ButtonApplyCategoryFilter.Size = new Size(69, 49);
            ButtonApplyCategoryFilter.TabIndex = 7;
            ButtonApplyCategoryFilter.Text = "Apply";
            ButtonApplyCategoryFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonApplyCategoryFilter.UseAccentColor = false;
            ButtonApplyCategoryFilter.UseVisualStyleBackColor = false;
            ButtonApplyCategoryFilter.Click += ButtonApplyCategoryFilter_Click;
            // 
            // ButtonApplySort
            // 
            ButtonApplySort.Anchor = AnchorStyles.Left;
            ButtonApplySort.AutoSize = false;
            ButtonApplySort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonApplySort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonApplySort.Depth = 0;
            ButtonApplySort.HighEmphasis = true;
            ButtonApplySort.Icon = null;
            ButtonApplySort.Location = new Point(846, 41);
            ButtonApplySort.Margin = new Padding(4, 6, 4, 6);
            ButtonApplySort.MouseState = MouseState.HOVER;
            ButtonApplySort.Name = "ButtonApplySort";
            ButtonApplySort.NoAccentTextColor = Color.Empty;
            ButtonApplySort.Size = new Size(69, 49);
            ButtonApplySort.TabIndex = 37;
            ButtonApplySort.Text = "Apply";
            ButtonApplySort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonApplySort.UseAccentColor = false;
            ButtonApplySort.UseVisualStyleBackColor = false;
            ButtonApplySort.Click += ButtonApplySort_Click;
            // 
            // ButtonResetSort
            // 
            ButtonResetSort.Anchor = AnchorStyles.Left;
            ButtonResetSort.AutoSize = false;
            ButtonResetSort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonResetSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonResetSort.Depth = 0;
            ButtonResetSort.HighEmphasis = true;
            ButtonResetSort.Icon = null;
            ButtonResetSort.Location = new Point(923, 41);
            ButtonResetSort.Margin = new Padding(4, 6, 4, 6);
            ButtonResetSort.MouseState = MouseState.HOVER;
            ButtonResetSort.Name = "ButtonResetSort";
            ButtonResetSort.NoAccentTextColor = Color.Empty;
            ButtonResetSort.Size = new Size(68, 49);
            ButtonResetSort.TabIndex = 38;
            ButtonResetSort.Text = "Reset All";
            ButtonResetSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonResetSort.UseAccentColor = false;
            ButtonResetSort.UseVisualStyleBackColor = false;
            ButtonResetSort.Click += ButtonResetSort_Click;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSearch.AutoSize = false;
            ButtonSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSearch.Depth = 0;
            ButtonSearch.Font = new Font("Segoe UI", 8.25F);
            ButtonSearch.HighEmphasis = true;
            ButtonSearch.Icon = null;
            ButtonSearch.Location = new Point(799, 580);
            ButtonSearch.Margin = new Padding(4, 6, 4, 6);
            ButtonSearch.MouseState = MouseState.HOVER;
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.NoAccentTextColor = Color.Empty;
            ButtonSearch.Size = new Size(92, 30);
            ButtonSearch.TabIndex = 39;
            ButtonSearch.Text = "Search";
            ButtonSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSearch.UseAccentColor = false;
            ButtonSearch.UseVisualStyleBackColor = false;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // FormViewStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(997, 616);
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonResetSort);
            Controls.Add(ButtonApplySort);
            Controls.Add(ButtonApplyCategoryFilter);
            Controls.Add(ComboBoxSort);
            Controls.Add(TextSortBy);
            Controls.Add(ComboBoxType);
            Controls.Add(TextType);
            Controls.Add(ButtonClear);
            Controls.Add(SearchBox);
            Controls.Add(TextSearch);
            Controls.Add(DatabaseGrid);
            Controls.Add(TextSort);
            Controls.Add(TextFilter);
            Controls.Add(TextWelcome);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormViewStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += FormViewStock_Load;
            LeftPanel.ResumeLayout(false);
            ((ISupportInitialize)DatabaseGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LeftPanel;
        private Label TextWelcome;
        private Label TextFilter;
        private Label TextSort;
        private MaterialSkin.Controls.MaterialButton ButtonChangePrice;
        private MaterialSkin.Controls.MaterialButton ButtonDiscontinue;
        private MaterialSkin.Controls.MaterialButton ButtonAddProduct;
        private MaterialSkin.Controls.MaterialButton ButtonAddCategory;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private DataGridView DatabaseGrid;
        private Label TextSearch;
        private TextBox SearchBox;
        private MaterialSkin.Controls.MaterialButton ButtonClear;
        private Label TextType;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxType;
        private Label TextSortBy;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxSort;
        private MaterialSkin.Controls.MaterialButton ButtonApplyCategoryFilter;
        private MaterialSkin.Controls.MaterialButton ButtonApplySort;
        private MaterialSkin.Controls.MaterialButton ButtonResetSort;
        private MaterialSkin.Controls.MaterialButton ButtonSearch;
    }
}