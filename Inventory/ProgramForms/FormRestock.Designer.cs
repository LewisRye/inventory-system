namespace Inventory.ProgramForms
{
    partial class FormRestock
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormRestock));
            ButtonPurchase = new MaterialSkin.Controls.MaterialButton();
            BluePanel = new Panel();
            ButtonClose = new MaterialSkin.Controls.MaterialButton();
            ButtonViewBasket = new MaterialSkin.Controls.MaterialButton();
            TextLogo = new Label();
            Database = new Label();
            TextWelcome = new Label();
            TextRestock = new Label();
            ListProducts = new MaterialSkin.Controls.MaterialComboBox();
            QuantityRequired = new NumericUpDown();
            TextPrice = new Label();
            ButtonAddToOrder = new MaterialSkin.Controls.MaterialButton();
            DatabaseGrid = new DataGridView();
            ListBasket = new MaterialSkin.Controls.MaterialComboBox();
            ButtonRemoveBasket = new MaterialSkin.Controls.MaterialButton();
            BluePanel.SuspendLayout();
            ((ISupportInitialize)QuantityRequired).BeginInit();
            ((ISupportInitialize)DatabaseGrid).BeginInit();
            SuspendLayout();
            // 
            // ButtonPurchase
            // 
            ButtonPurchase.Anchor = AnchorStyles.Left;
            ButtonPurchase.AutoSize = false;
            ButtonPurchase.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonPurchase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonPurchase.Depth = 0;
            ButtonPurchase.HighEmphasis = true;
            ButtonPurchase.Icon = null;
            ButtonPurchase.Location = new Point(299, 441);
            ButtonPurchase.Margin = new Padding(5, 6, 5, 6);
            ButtonPurchase.MouseState = MouseState.HOVER;
            ButtonPurchase.Name = "ButtonPurchase";
            ButtonPurchase.NoAccentTextColor = Color.Empty;
            ButtonPurchase.Size = new Size(737, 53);
            ButtonPurchase.TabIndex = 4;
            ButtonPurchase.Text = "Complete Order (£0.00)";
            ButtonPurchase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonPurchase.UseAccentColor = false;
            ButtonPurchase.UseVisualStyleBackColor = true;
            ButtonPurchase.Click += ButtonPurchase_Click;
            // 
            // BluePanel
            // 
            BluePanel.BackColor = Color.Transparent;
            BluePanel.Controls.Add(ButtonClose);
            BluePanel.Controls.Add(ButtonViewBasket);
            BluePanel.Controls.Add(TextLogo);
            BluePanel.Controls.Add(Database);
            BluePanel.Controls.Add(TextWelcome);
            BluePanel.Dock = DockStyle.Left;
            BluePanel.Location = new Point(0, 0);
            BluePanel.Margin = new Padding(2);
            BluePanel.Name = "BluePanel";
            BluePanel.Size = new Size(294, 501);
            BluePanel.TabIndex = 33;
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
            ButtonClose.Location = new Point(5, 396);
            ButtonClose.Margin = new Padding(5, 6, 5, 6);
            ButtonClose.MouseState = MouseState.HOVER;
            ButtonClose.Name = "ButtonClose";
            ButtonClose.NoAccentTextColor = Color.Empty;
            ButtonClose.Size = new Size(285, 52);
            ButtonClose.TabIndex = 5;
            ButtonClose.Text = "Close";
            ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClose.UseAccentColor = false;
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ButtonViewBasket
            // 
            ButtonViewBasket.Anchor = AnchorStyles.Left;
            ButtonViewBasket.AutoSize = false;
            ButtonViewBasket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonViewBasket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonViewBasket.Depth = 0;
            ButtonViewBasket.HighEmphasis = true;
            ButtonViewBasket.Icon = null;
            ButtonViewBasket.Location = new Point(5, 50);
            ButtonViewBasket.Margin = new Padding(5, 6, 5, 6);
            ButtonViewBasket.MouseState = MouseState.HOVER;
            ButtonViewBasket.Name = "ButtonViewBasket";
            ButtonViewBasket.NoAccentTextColor = Color.Empty;
            ButtonViewBasket.Size = new Size(285, 52);
            ButtonViewBasket.TabIndex = 7;
            ButtonViewBasket.Text = "View Basket (£0.00)";
            ButtonViewBasket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonViewBasket.UseAccentColor = false;
            ButtonViewBasket.UseVisualStyleBackColor = true;
            ButtonViewBasket.Click += ButtonViewBasket_Click;
            // 
            // TextLogo
            // 
            TextLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextLogo.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TextLogo.ForeColor = Color.Black;
            TextLogo.Location = new Point(0, 453);
            TextLogo.Margin = new Padding(2, 0, 2, 0);
            TextLogo.Name = "TextLogo";
            TextLogo.Size = new Size(294, 47);
            TextLogo.TabIndex = 6;
            TextLogo.Text = "Database";
            TextLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Database
            // 
            Database.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Database.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Database.ForeColor = SystemColors.ButtonHighlight;
            Database.Location = new Point(0, 1062);
            Database.Margin = new Padding(2, 0, 2, 0);
            Database.Name = "Database";
            Database.Size = new Size(294, 44);
            Database.TabIndex = 3;
            Database.Text = "Database";
            Database.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextWelcome
            // 
            TextWelcome.Dock = DockStyle.Top;
            TextWelcome.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TextWelcome.ForeColor = Color.Black;
            TextWelcome.Location = new Point(0, 0);
            TextWelcome.Margin = new Padding(2, 0, 2, 0);
            TextWelcome.Name = "TextWelcome";
            TextWelcome.Size = new Size(294, 44);
            TextWelcome.TabIndex = 2;
            TextWelcome.Text = "welcome, (username)!";
            TextWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextRestock
            // 
            TextRestock.Dock = DockStyle.Top;
            TextRestock.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextRestock.Location = new Point(294, 0);
            TextRestock.Margin = new Padding(2, 0, 2, 0);
            TextRestock.Name = "TextRestock";
            TextRestock.Size = new Size(748, 44);
            TextRestock.TabIndex = 42;
            TextRestock.Text = "Restock Depleted Items";
            TextRestock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListProducts
            // 
            ListProducts.AutoResize = false;
            ListProducts.BackColor = Color.FromArgb(255, 255, 255);
            ListProducts.Depth = 0;
            ListProducts.DrawMode = DrawMode.OwnerDrawVariable;
            ListProducts.DropDownHeight = 350;
            ListProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            ListProducts.DropDownWidth = 121;
            ListProducts.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListProducts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ListProducts.FormattingEnabled = true;
            ListProducts.IntegralHeight = false;
            ListProducts.ItemHeight = 29;
            ListProducts.Location = new Point(301, 344);
            ListProducts.Margin = new Padding(4, 3, 4, 3);
            ListProducts.MaxDropDownItems = 12;
            ListProducts.MouseState = MouseState.OUT;
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(506, 35);
            ListProducts.StartIndex = 0;
            ListProducts.TabIndex = 1;
            ListProducts.UseAccent = false;
            ListProducts.UseTallSize = false;
            ListProducts.SelectedIndexChanged += ListProducts_SelectedIndexChanged;
            // 
            // QuantityRequired
            // 
            QuantityRequired.Location = new Point(816, 344);
            QuantityRequired.Margin = new Padding(4, 3, 4, 3);
            QuantityRequired.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            QuantityRequired.Name = "QuantityRequired";
            QuantityRequired.RightToLeft = RightToLeft.No;
            QuantityRequired.Size = new Size(120, 23);
            QuantityRequired.TabIndex = 2;
            QuantityRequired.TextAlign = HorizontalAlignment.Right;
            QuantityRequired.ValueChanged += QuantityRequired_ValueChanged;
            // 
            // TextPrice
            // 
            TextPrice.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextPrice.Location = new Point(836, 370);
            TextPrice.Margin = new Padding(2, 0, 2, 0);
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new Size(99, 14);
            TextPrice.TabIndex = 45;
            TextPrice.Text = "£0.00";
            TextPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ButtonAddToOrder
            // 
            ButtonAddToOrder.Anchor = AnchorStyles.Left;
            ButtonAddToOrder.AutoSize = false;
            ButtonAddToOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAddToOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonAddToOrder.Depth = 0;
            ButtonAddToOrder.HighEmphasis = true;
            ButtonAddToOrder.Icon = null;
            ButtonAddToOrder.Location = new Point(943, 344);
            ButtonAddToOrder.Margin = new Padding(5, 6, 5, 6);
            ButtonAddToOrder.MouseState = MouseState.HOVER;
            ButtonAddToOrder.Name = "ButtonAddToOrder";
            ButtonAddToOrder.NoAccentTextColor = Color.Empty;
            ButtonAddToOrder.Size = new Size(93, 40);
            ButtonAddToOrder.TabIndex = 3;
            ButtonAddToOrder.Text = "Add";
            ButtonAddToOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonAddToOrder.UseAccentColor = false;
            ButtonAddToOrder.UseVisualStyleBackColor = true;
            ButtonAddToOrder.Click += ButtonAddToOrder_Click;
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
            DatabaseGrid.ColumnHeadersHeight = 34;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DatabaseGrid.DefaultCellStyle = dataGridViewCellStyle1;
            DatabaseGrid.EnableHeadersVisualStyles = false;
            DatabaseGrid.GridColor = Color.White;
            DatabaseGrid.Location = new Point(299, 47);
            DatabaseGrid.Margin = new Padding(4, 3, 4, 3);
            DatabaseGrid.Name = "DatabaseGrid";
            DatabaseGrid.RowHeadersVisible = false;
            DatabaseGrid.RowHeadersWidth = 62;
            DatabaseGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            DatabaseGrid.ShowCellErrors = false;
            DatabaseGrid.ShowCellToolTips = false;
            DatabaseGrid.ShowEditingIcon = false;
            DatabaseGrid.ShowRowErrors = false;
            DatabaseGrid.Size = new Size(737, 290);
            DatabaseGrid.TabIndex = 47;
            // 
            // ListBasket
            // 
            ListBasket.AutoResize = false;
            ListBasket.BackColor = Color.FromArgb(255, 255, 255);
            ListBasket.Depth = 0;
            ListBasket.DrawMode = DrawMode.OwnerDrawVariable;
            ListBasket.DropDownHeight = 350;
            ListBasket.DropDownStyle = ComboBoxStyle.DropDownList;
            ListBasket.DropDownWidth = 121;
            ListBasket.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListBasket.ForeColor = Color.Transparent;
            ListBasket.FormattingEnabled = true;
            ListBasket.IntegralHeight = false;
            ListBasket.ItemHeight = 29;
            ListBasket.Location = new Point(301, 391);
            ListBasket.Margin = new Padding(4, 3, 4, 3);
            ListBasket.MaxDropDownItems = 12;
            ListBasket.MouseState = MouseState.OUT;
            ListBasket.Name = "ListBasket";
            ListBasket.Size = new Size(506, 35);
            ListBasket.StartIndex = 0;
            ListBasket.TabIndex = 48;
            ListBasket.UseAccent = false;
            ListBasket.UseTallSize = false;
            // 
            // ButtonRemoveBasket
            // 
            ButtonRemoveBasket.Anchor = AnchorStyles.Left;
            ButtonRemoveBasket.AutoSize = false;
            ButtonRemoveBasket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonRemoveBasket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonRemoveBasket.Depth = 0;
            ButtonRemoveBasket.HighEmphasis = true;
            ButtonRemoveBasket.Icon = null;
            ButtonRemoveBasket.Location = new Point(816, 390);
            ButtonRemoveBasket.Margin = new Padding(5, 6, 5, 6);
            ButtonRemoveBasket.MouseState = MouseState.HOVER;
            ButtonRemoveBasket.Name = "ButtonRemoveBasket";
            ButtonRemoveBasket.NoAccentTextColor = Color.Empty;
            ButtonRemoveBasket.Size = new Size(220, 40);
            ButtonRemoveBasket.TabIndex = 49;
            ButtonRemoveBasket.Text = "Remove from Basket";
            ButtonRemoveBasket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonRemoveBasket.UseAccentColor = false;
            ButtonRemoveBasket.UseVisualStyleBackColor = true;
            ButtonRemoveBasket.Click += ButtonRemoveBasket_Click;
            // 
            // FormRestock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1042, 501);
            Controls.Add(ButtonRemoveBasket);
            Controls.Add(ListBasket);
            Controls.Add(DatabaseGrid);
            Controls.Add(ButtonAddToOrder);
            Controls.Add(TextPrice);
            Controls.Add(QuantityRequired);
            Controls.Add(ListProducts);
            Controls.Add(TextRestock);
            Controls.Add(ButtonPurchase);
            Controls.Add(BluePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRestock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += RestockForm_Load;
            BluePanel.ResumeLayout(false);
            ((ISupportInitialize)QuantityRequired).EndInit();
            ((ISupportInitialize)DatabaseGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ButtonPurchase;
        private System.Windows.Forms.Panel BluePanel;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private System.Windows.Forms.Label TextLogo;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.Label TextWelcome;
        private System.Windows.Forms.Label TextRestock;
        private MaterialSkin.Controls.MaterialComboBox ListProducts;
        private System.Windows.Forms.NumericUpDown QuantityRequired;
        private System.Windows.Forms.Label TextPrice;
        private MaterialSkin.Controls.MaterialButton ButtonAddToOrder;
        private System.Windows.Forms.DataGridView DatabaseGrid;
        private MaterialSkin.Controls.MaterialButton ButtonViewBasket;
        private MaterialSkin.Controls.MaterialComboBox ListBasket;
        private MaterialSkin.Controls.MaterialButton ButtonRemoveBasket;
    }
}