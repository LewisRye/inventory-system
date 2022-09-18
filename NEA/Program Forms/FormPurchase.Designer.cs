namespace NEA
{
    partial class FormPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchase));
            this.ListProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonClose = new MaterialSkin.Controls.MaterialButton();
            this.ButtonOrder = new MaterialSkin.Controls.MaterialButton();
            this.TextTotalCost = new System.Windows.Forms.Label();
            this.TextQuantityRequired = new System.Windows.Forms.Label();
            this.QuantityRequired = new System.Windows.Forms.NumericUpDown();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.StockLink = new System.Windows.Forms.LinkLabel();
            this.TextRestockTitle = new System.Windows.Forms.Label();
            this.TextTerms = new System.Windows.Forms.Label();
            this.TextDeliveryDate = new System.Windows.Forms.Label();
            this.ButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.ButtonViewBasket = new MaterialSkin.Controls.MaterialButton();
            this.TextRemove = new System.Windows.Forms.Label();
            this.ListBasket = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonRemove = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityRequired)).BeginInit();
            this.BluePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListProducts
            // 
            this.ListProducts.AutoResize = false;
            this.ListProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListProducts.Depth = 0;
            this.ListProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListProducts.DropDownHeight = 292;
            this.ListProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListProducts.DropDownWidth = 121;
            this.ListProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.ListProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListProducts.FormattingEnabled = true;
            this.ListProducts.IntegralHeight = false;
            this.ListProducts.ItemHeight = 29;
            this.ListProducts.Location = new System.Drawing.Point(0, 65);
            this.ListProducts.MaxDropDownItems = 10;
            this.ListProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(713, 35);
            this.ListProducts.StartIndex = 0;
            this.ListProducts.TabIndex = 1;
            this.ListProducts.UseAccent = false;
            this.ListProducts.UseTallSize = false;
            this.ListProducts.SelectedIndexChanged += new System.EventHandler(this.OrderProductList_SelectedIndexChanged);
            // 
            // ButtonClose
            // 
            this.ButtonClose.AutoSize = false;
            this.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClose.Depth = 0;
            this.ButtonClose.HighEmphasis = true;
            this.ButtonClose.Icon = null;
            this.ButtonClose.Location = new System.Drawing.Point(588, 213);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClose.Size = new System.Drawing.Size(115, 38);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClose.UseAccentColor = false;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.AutoSize = false;
            this.ButtonOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonOrder.Depth = 0;
            this.ButtonOrder.HighEmphasis = true;
            this.ButtonOrder.Icon = null;
            this.ButtonOrder.Location = new System.Drawing.Point(300, 213);
            this.ButtonOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonOrder.Size = new System.Drawing.Size(282, 38);
            this.ButtonOrder.TabIndex = 8;
            this.ButtonOrder.Text = "Complete Order";
            this.ButtonOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonOrder.UseAccentColor = false;
            this.ButtonOrder.UseVisualStyleBackColor = true;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // TextTotalCost
            // 
            this.TextTotalCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextTotalCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTotalCost.Location = new System.Drawing.Point(251, 140);
            this.TextTotalCost.Name = "TextTotalCost";
            this.TextTotalCost.Size = new System.Drawing.Size(203, 19);
            this.TextTotalCost.TabIndex = 24;
            this.TextTotalCost.Text = "item cost: £0";
            this.TextTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextQuantityRequired
            // 
            this.TextQuantityRequired.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextQuantityRequired.AutoSize = true;
            this.TextQuantityRequired.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextQuantityRequired.Location = new System.Drawing.Point(12, 139);
            this.TextQuantityRequired.Name = "TextQuantityRequired";
            this.TextQuantityRequired.Size = new System.Drawing.Size(146, 21);
            this.TextQuantityRequired.TabIndex = 22;
            this.TextQuantityRequired.Text = "quantity required:";
            // 
            // QuantityRequired
            // 
            this.QuantityRequired.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.QuantityRequired.Location = new System.Drawing.Point(187, 136);
            this.QuantityRequired.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.QuantityRequired.Name = "QuantityRequired";
            this.QuantityRequired.Size = new System.Drawing.Size(58, 24);
            this.QuantityRequired.TabIndex = 3;
            this.QuantityRequired.ValueChanged += new System.EventHandler(this.QuantityRequired_ValueChanged);
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.DeliveryDate.Location = new System.Drawing.Point(187, 106);
            this.DeliveryDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DeliveryDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(267, 24);
            this.DeliveryDate.TabIndex = 2;
            this.DeliveryDate.Value = new System.DateTime(2022, 1, 12, 0, 0, 0, 0);
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.Color.Transparent;
            this.BluePanel.Controls.Add(this.StockLink);
            this.BluePanel.Controls.Add(this.TextRestockTitle);
            this.BluePanel.Controls.Add(this.TextTerms);
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BluePanel.Location = new System.Drawing.Point(0, 0);
            this.BluePanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(713, 65);
            this.BluePanel.TabIndex = 16;
            // 
            // StockLink
            // 
            this.StockLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.StockLink.AutoSize = true;
            this.StockLink.BackColor = System.Drawing.Color.Transparent;
            this.StockLink.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.StockLink.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.StockLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.StockLink.LinkColor = System.Drawing.Color.Transparent;
            this.StockLink.Location = new System.Drawing.Point(183, 23);
            this.StockLink.Name = "StockLink";
            this.StockLink.Size = new System.Drawing.Size(13, 19);
            this.StockLink.TabIndex = 1;
            this.StockLink.TabStop = true;
            this.StockLink.Text = " ";
            this.StockLink.VisitedLinkColor = System.Drawing.Color.Transparent;
            // 
            // TextRestockTitle
            // 
            this.TextRestockTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextRestockTitle.AutoSize = true;
            this.TextRestockTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.TextRestockTitle.ForeColor = System.Drawing.Color.Black;
            this.TextRestockTitle.Location = new System.Drawing.Point(11, 18);
            this.TextRestockTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextRestockTitle.Name = "TextRestockTitle";
            this.TextRestockTitle.Size = new System.Drawing.Size(168, 30);
            this.TextRestockTitle.TabIndex = 1;
            this.TextRestockTitle.Text = "Restock Items";
            // 
            // TextTerms
            // 
            this.TextTerms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextTerms.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.TextTerms.ForeColor = System.Drawing.Color.Black;
            this.TextTerms.Location = new System.Drawing.Point(455, 12);
            this.TextTerms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextTerms.Name = "TextTerms";
            this.TextTerms.Size = new System.Drawing.Size(247, 36);
            this.TextTerms.TabIndex = 2;
            this.TextTerms.Text = "for simulation purposes, your item will \r\narrive inside the database instantly";
            this.TextTerms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextDeliveryDate
            // 
            this.TextDeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextDeliveryDate.AutoSize = true;
            this.TextDeliveryDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDeliveryDate.Location = new System.Drawing.Point(12, 109);
            this.TextDeliveryDate.Name = "TextDeliveryDate";
            this.TextDeliveryDate.Size = new System.Drawing.Size(111, 21);
            this.TextDeliveryDate.TabIndex = 25;
            this.TextDeliveryDate.Text = "delivery date:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.AutoSize = false;
            this.ButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonAdd.Depth = 0;
            this.ButtonAdd.HighEmphasis = true;
            this.ButtonAdd.Icon = null;
            this.ButtonAdd.Location = new System.Drawing.Point(460, 106);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonAdd.Size = new System.Drawing.Size(243, 54);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add to Basket";
            this.ButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonAdd.UseAccentColor = false;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonViewBasket
            // 
            this.ButtonViewBasket.AutoSize = false;
            this.ButtonViewBasket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonViewBasket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonViewBasket.Depth = 0;
            this.ButtonViewBasket.HighEmphasis = true;
            this.ButtonViewBasket.Icon = null;
            this.ButtonViewBasket.Location = new System.Drawing.Point(12, 213);
            this.ButtonViewBasket.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonViewBasket.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonViewBasket.Name = "ButtonViewBasket";
            this.ButtonViewBasket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonViewBasket.Size = new System.Drawing.Size(282, 38);
            this.ButtonViewBasket.TabIndex = 7;
            this.ButtonViewBasket.Text = "View Basket (£0.00)";
            this.ButtonViewBasket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonViewBasket.UseAccentColor = false;
            this.ButtonViewBasket.UseVisualStyleBackColor = true;
            this.ButtonViewBasket.Click += new System.EventHandler(this.ButtonViewBasket_Click);
            // 
            // TextRemove
            // 
            this.TextRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextRemove.AutoSize = true;
            this.TextRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRemove.Location = new System.Drawing.Point(11, 181);
            this.TextRemove.Name = "TextRemove";
            this.TextRemove.Size = new System.Drawing.Size(168, 21);
            this.TextRemove.TabIndex = 28;
            this.TextRemove.Text = "remove from basket:";
            // 
            // ListBasket
            // 
            this.ListBasket.AutoResize = false;
            this.ListBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListBasket.Depth = 0;
            this.ListBasket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListBasket.DropDownHeight = 292;
            this.ListBasket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListBasket.DropDownWidth = 121;
            this.ListBasket.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.ListBasket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBasket.FormattingEnabled = true;
            this.ListBasket.IntegralHeight = false;
            this.ListBasket.ItemHeight = 29;
            this.ListBasket.Location = new System.Drawing.Point(185, 170);
            this.ListBasket.MaxDropDownItems = 10;
            this.ListBasket.MouseState = MaterialSkin.MouseState.OUT;
            this.ListBasket.Name = "ListBasket";
            this.ListBasket.Size = new System.Drawing.Size(265, 35);
            this.ListBasket.StartIndex = 0;
            this.ListBasket.TabIndex = 4;
            this.ListBasket.UseAccent = false;
            this.ListBasket.UseTallSize = false;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.AutoSize = false;
            this.ButtonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonRemove.Depth = 0;
            this.ButtonRemove.HighEmphasis = true;
            this.ButtonRemove.Icon = null;
            this.ButtonRemove.Location = new System.Drawing.Point(459, 167);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonRemove.Size = new System.Drawing.Size(244, 38);
            this.ButtonRemove.TabIndex = 6;
            this.ButtonRemove.Text = "Remove Item from Basket";
            this.ButtonRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonRemove.UseAccentColor = false;
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 263);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ListBasket);
            this.Controls.Add(this.TextRemove);
            this.Controls.Add(this.ButtonViewBasket);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ListProducts);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonOrder);
            this.Controls.Add(this.TextTotalCost);
            this.Controls.Add(this.TextQuantityRequired);
            this.Controls.Add(this.QuantityRequired);
            this.Controls.Add(this.DeliveryDate);
            this.Controls.Add(this.BluePanel);
            this.Controls.Add(this.TextDeliveryDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityRequired)).EndInit();
            this.BluePanel.ResumeLayout(false);
            this.BluePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox ListProducts;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private MaterialSkin.Controls.MaterialButton ButtonOrder;
        private System.Windows.Forms.Label TextTotalCost;
        private System.Windows.Forms.Label TextQuantityRequired;
        private System.Windows.Forms.NumericUpDown QuantityRequired;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.Label TextTerms;
        private System.Windows.Forms.LinkLabel StockLink;
        private System.Windows.Forms.Label TextRestockTitle;
        private System.Windows.Forms.Label TextDeliveryDate;
        private MaterialSkin.Controls.MaterialButton ButtonAdd;
        private MaterialSkin.Controls.MaterialButton ButtonViewBasket;
        private System.Windows.Forms.Label TextRemove;
        private MaterialSkin.Controls.MaterialComboBox ListBasket;
        private MaterialSkin.Controls.MaterialButton ButtonRemove;
    }
}