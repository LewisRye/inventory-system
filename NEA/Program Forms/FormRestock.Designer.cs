namespace NEA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestock));
            this.ButtonPurchase = new MaterialSkin.Controls.MaterialButton();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.ButtonClose = new MaterialSkin.Controls.MaterialButton();
            this.ButtonViewBasket = new MaterialSkin.Controls.MaterialButton();
            this.TextLogo = new System.Windows.Forms.Label();
            this.Database = new System.Windows.Forms.Label();
            this.TextWelcome = new System.Windows.Forms.Label();
            this.TextRestock = new System.Windows.Forms.Label();
            this.ListProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.QuantityRequired = new System.Windows.Forms.NumericUpDown();
            this.TextPrice = new System.Windows.Forms.Label();
            this.ButtonAddToOrder = new MaterialSkin.Controls.MaterialButton();
            this.DatabaseGrid = new System.Windows.Forms.DataGridView();
            this.ListBasket = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonRemoveBasket = new MaterialSkin.Controls.MaterialButton();
            this.BluePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPurchase
            // 
            this.ButtonPurchase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonPurchase.AutoSize = false;
            this.ButtonPurchase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPurchase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonPurchase.Depth = 0;
            this.ButtonPurchase.HighEmphasis = true;
            this.ButtonPurchase.Icon = null;
            this.ButtonPurchase.Location = new System.Drawing.Point(256, 382);
            this.ButtonPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonPurchase.Name = "ButtonPurchase";
            this.ButtonPurchase.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonPurchase.Size = new System.Drawing.Size(632, 46);
            this.ButtonPurchase.TabIndex = 4;
            this.ButtonPurchase.Text = "Complete Order (£0.00)";
            this.ButtonPurchase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonPurchase.UseAccentColor = false;
            this.ButtonPurchase.UseVisualStyleBackColor = true;
            this.ButtonPurchase.Click += new System.EventHandler(this.ButtonPurchase_Click);
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.Color.Transparent;
            this.BluePanel.Controls.Add(this.ButtonClose);
            this.BluePanel.Controls.Add(this.ButtonViewBasket);
            this.BluePanel.Controls.Add(this.TextLogo);
            this.BluePanel.Controls.Add(this.Database);
            this.BluePanel.Controls.Add(this.TextWelcome);
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BluePanel.Location = new System.Drawing.Point(0, 0);
            this.BluePanel.Margin = new System.Windows.Forms.Padding(2);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(252, 434);
            this.BluePanel.TabIndex = 33;
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
            this.ButtonClose.Location = new System.Drawing.Point(4, 343);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClose.Size = new System.Drawing.Size(244, 45);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClose.UseAccentColor = false;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonViewBasket
            // 
            this.ButtonViewBasket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonViewBasket.AutoSize = false;
            this.ButtonViewBasket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonViewBasket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonViewBasket.Depth = 0;
            this.ButtonViewBasket.HighEmphasis = true;
            this.ButtonViewBasket.Icon = null;
            this.ButtonViewBasket.Location = new System.Drawing.Point(4, 43);
            this.ButtonViewBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonViewBasket.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonViewBasket.Name = "ButtonViewBasket";
            this.ButtonViewBasket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonViewBasket.Size = new System.Drawing.Size(244, 45);
            this.ButtonViewBasket.TabIndex = 7;
            this.ButtonViewBasket.Text = "View Basket (£0.00)";
            this.ButtonViewBasket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonViewBasket.UseAccentColor = false;
            this.ButtonViewBasket.UseVisualStyleBackColor = true;
            this.ButtonViewBasket.Click += new System.EventHandler(this.ButtonViewBasket_Click);
            // 
            // TextLogo
            // 
            this.TextLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextLogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.TextLogo.ForeColor = System.Drawing.Color.Black;
            this.TextLogo.Location = new System.Drawing.Point(0, 393);
            this.TextLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextLogo.Name = "TextLogo";
            this.TextLogo.Size = new System.Drawing.Size(252, 41);
            this.TextLogo.TabIndex = 6;
            this.TextLogo.Text = "Database";
            this.TextLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Database
            // 
            this.Database.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Database.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.Database.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Database.Location = new System.Drawing.Point(0, 920);
            this.Database.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(252, 38);
            this.Database.TabIndex = 3;
            this.Database.Text = "Database";
            this.Database.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextWelcome
            // 
            this.TextWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.TextWelcome.ForeColor = System.Drawing.Color.Black;
            this.TextWelcome.Location = new System.Drawing.Point(0, 0);
            this.TextWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextWelcome.Name = "TextWelcome";
            this.TextWelcome.Size = new System.Drawing.Size(252, 38);
            this.TextWelcome.TabIndex = 2;
            this.TextWelcome.Text = "welcome, (username)!";
            this.TextWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextRestock
            // 
            this.TextRestock.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextRestock.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRestock.Location = new System.Drawing.Point(252, 0);
            this.TextRestock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextRestock.Name = "TextRestock";
            this.TextRestock.Size = new System.Drawing.Size(641, 38);
            this.TextRestock.TabIndex = 42;
            this.TextRestock.Text = "Restock Depleted Items";
            this.TextRestock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListProducts
            // 
            this.ListProducts.AutoResize = false;
            this.ListProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListProducts.Depth = 0;
            this.ListProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListProducts.DropDownHeight = 350;
            this.ListProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListProducts.DropDownWidth = 121;
            this.ListProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.ListProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListProducts.FormattingEnabled = true;
            this.ListProducts.IntegralHeight = false;
            this.ListProducts.ItemHeight = 29;
            this.ListProducts.Location = new System.Drawing.Point(258, 298);
            this.ListProducts.MaxDropDownItems = 12;
            this.ListProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(434, 35);
            this.ListProducts.StartIndex = 0;
            this.ListProducts.TabIndex = 1;
            this.ListProducts.UseAccent = false;
            this.ListProducts.UseTallSize = false;
            this.ListProducts.SelectedIndexChanged += new System.EventHandler(this.ListProducts_SelectedIndexChanged);
            // 
            // QuantityRequired
            // 
            this.QuantityRequired.Location = new System.Drawing.Point(699, 298);
            this.QuantityRequired.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.QuantityRequired.Name = "QuantityRequired";
            this.QuantityRequired.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuantityRequired.Size = new System.Drawing.Size(103, 20);
            this.QuantityRequired.TabIndex = 2;
            this.QuantityRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QuantityRequired.ValueChanged += new System.EventHandler(this.QuantityRequired_ValueChanged);
            // 
            // TextPrice
            // 
            this.TextPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrice.Location = new System.Drawing.Point(717, 321);
            this.TextPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(85, 12);
            this.TextPrice.TabIndex = 45;
            this.TextPrice.Text = "£0.00";
            this.TextPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonAddToOrder
            // 
            this.ButtonAddToOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonAddToOrder.AutoSize = false;
            this.ButtonAddToOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddToOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAddToOrder.Depth = 0;
            this.ButtonAddToOrder.HighEmphasis = true;
            this.ButtonAddToOrder.Icon = null;
            this.ButtonAddToOrder.Location = new System.Drawing.Point(808, 298);
            this.ButtonAddToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAddToOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAddToOrder.Name = "ButtonAddToOrder";
            this.ButtonAddToOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAddToOrder.Size = new System.Drawing.Size(80, 35);
            this.ButtonAddToOrder.TabIndex = 3;
            this.ButtonAddToOrder.Text = "Add";
            this.ButtonAddToOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAddToOrder.UseAccentColor = false;
            this.ButtonAddToOrder.UseVisualStyleBackColor = true;
            this.ButtonAddToOrder.Click += new System.EventHandler(this.ButtonAddToOrder_Click);
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
            this.DatabaseGrid.ColumnHeadersHeight = 34;
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
            this.DatabaseGrid.Location = new System.Drawing.Point(256, 41);
            this.DatabaseGrid.Name = "DatabaseGrid";
            this.DatabaseGrid.RowHeadersVisible = false;
            this.DatabaseGrid.RowHeadersWidth = 62;
            this.DatabaseGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseGrid.ShowCellErrors = false;
            this.DatabaseGrid.ShowCellToolTips = false;
            this.DatabaseGrid.ShowEditingIcon = false;
            this.DatabaseGrid.ShowRowErrors = false;
            this.DatabaseGrid.Size = new System.Drawing.Size(632, 251);
            this.DatabaseGrid.TabIndex = 47;
            // 
            // ListBasket
            // 
            this.ListBasket.AutoResize = false;
            this.ListBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListBasket.Depth = 0;
            this.ListBasket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListBasket.DropDownHeight = 350;
            this.ListBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListBasket.DropDownWidth = 121;
            this.ListBasket.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.ListBasket.ForeColor = System.Drawing.Color.Transparent;
            this.ListBasket.FormattingEnabled = true;
            this.ListBasket.IntegralHeight = false;
            this.ListBasket.ItemHeight = 29;
            this.ListBasket.Location = new System.Drawing.Point(258, 339);
            this.ListBasket.MaxDropDownItems = 12;
            this.ListBasket.MouseState = MaterialSkin.MouseState.OUT;
            this.ListBasket.Name = "ListBasket";
            this.ListBasket.Size = new System.Drawing.Size(434, 35);
            this.ListBasket.StartIndex = 0;
            this.ListBasket.TabIndex = 48;
            this.ListBasket.UseAccent = false;
            this.ListBasket.UseTallSize = false;
            // 
            // ButtonRemoveBasket
            // 
            this.ButtonRemoveBasket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonRemoveBasket.AutoSize = false;
            this.ButtonRemoveBasket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRemoveBasket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonRemoveBasket.Depth = 0;
            this.ButtonRemoveBasket.HighEmphasis = true;
            this.ButtonRemoveBasket.Icon = null;
            this.ButtonRemoveBasket.Location = new System.Drawing.Point(699, 338);
            this.ButtonRemoveBasket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonRemoveBasket.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRemoveBasket.Name = "ButtonRemoveBasket";
            this.ButtonRemoveBasket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonRemoveBasket.Size = new System.Drawing.Size(189, 35);
            this.ButtonRemoveBasket.TabIndex = 49;
            this.ButtonRemoveBasket.Text = "Remove from Basket";
            this.ButtonRemoveBasket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonRemoveBasket.UseAccentColor = false;
            this.ButtonRemoveBasket.UseVisualStyleBackColor = true;
            this.ButtonRemoveBasket.Click += new System.EventHandler(this.ButtonRemoveBasket_Click);
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 434);
            this.Controls.Add(this.ButtonRemoveBasket);
            this.Controls.Add(this.ListBasket);
            this.Controls.Add(this.DatabaseGrid);
            this.Controls.Add(this.ButtonAddToOrder);
            this.Controls.Add(this.TextPrice);
            this.Controls.Add(this.QuantityRequired);
            this.Controls.Add(this.ListProducts);
            this.Controls.Add(this.TextRestock);
            this.Controls.Add(this.ButtonPurchase);
            this.Controls.Add(this.BluePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.RestockForm_Load);
            this.BluePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).EndInit();
            this.ResumeLayout(false);

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