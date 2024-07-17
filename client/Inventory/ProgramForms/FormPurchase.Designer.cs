namespace Inventory.ProgramForms
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPurchase));
            ListProducts = new MaterialSkin.Controls.MaterialComboBox();
            ButtonClose = new MaterialSkin.Controls.MaterialButton();
            ButtonOrder = new MaterialSkin.Controls.MaterialButton();
            TextTotalCost = new Label();
            TextQuantityRequired = new Label();
            QuantityRequired = new NumericUpDown();
            DeliveryDate = new DateTimePicker();
            BluePanel = new Panel();
            StockLink = new LinkLabel();
            TextRestockTitle = new Label();
            TextTerms = new Label();
            TextDeliveryDate = new Label();
            ButtonAdd = new MaterialSkin.Controls.MaterialButton();
            ButtonViewBasket = new MaterialSkin.Controls.MaterialButton();
            TextRemove = new Label();
            ListBasket = new MaterialSkin.Controls.MaterialComboBox();
            ButtonRemove = new MaterialSkin.Controls.MaterialButton();
            ((ISupportInitialize)QuantityRequired).BeginInit();
            BluePanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListProducts
            // 
            ListProducts.AutoResize = false;
            ListProducts.BackColor = Color.FromArgb(255, 255, 255);
            ListProducts.Depth = 0;
            ListProducts.DrawMode = DrawMode.OwnerDrawVariable;
            ListProducts.DropDownHeight = 292;
            ListProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            ListProducts.DropDownWidth = 121;
            ListProducts.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListProducts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ListProducts.FormattingEnabled = true;
            ListProducts.IntegralHeight = false;
            ListProducts.ItemHeight = 29;
            ListProducts.Location = new Point(0, 75);
            ListProducts.Margin = new Padding(4, 3, 4, 3);
            ListProducts.MaxDropDownItems = 10;
            ListProducts.MouseState = MouseState.OUT;
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(831, 35);
            ListProducts.StartIndex = 0;
            ListProducts.TabIndex = 1;
            ListProducts.UseAccent = false;
            ListProducts.UseTallSize = false;
            ListProducts.SelectedIndexChanged += OrderProductList_SelectedIndexChanged;
            // 
            // ButtonClose
            // 
            ButtonClose.AutoSize = false;
            ButtonClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonClose.Depth = 0;
            ButtonClose.HighEmphasis = true;
            ButtonClose.Icon = null;
            ButtonClose.Location = new Point(686, 246);
            ButtonClose.Margin = new Padding(4, 6, 4, 6);
            ButtonClose.MouseState = MouseState.HOVER;
            ButtonClose.Name = "ButtonClose";
            ButtonClose.NoAccentTextColor = Color.Empty;
            ButtonClose.Size = new Size(134, 44);
            ButtonClose.TabIndex = 9;
            ButtonClose.Text = "Close";
            ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClose.UseAccentColor = false;
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += CloseButton_Click;
            // 
            // ButtonOrder
            // 
            ButtonOrder.AutoSize = false;
            ButtonOrder.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonOrder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonOrder.Depth = 0;
            ButtonOrder.HighEmphasis = true;
            ButtonOrder.Icon = null;
            ButtonOrder.Location = new Point(350, 246);
            ButtonOrder.Margin = new Padding(4, 6, 4, 6);
            ButtonOrder.MouseState = MouseState.HOVER;
            ButtonOrder.Name = "ButtonOrder";
            ButtonOrder.NoAccentTextColor = Color.Empty;
            ButtonOrder.Size = new Size(329, 44);
            ButtonOrder.TabIndex = 8;
            ButtonOrder.Text = "Complete Order";
            ButtonOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonOrder.UseAccentColor = false;
            ButtonOrder.UseVisualStyleBackColor = true;
            ButtonOrder.Click += ButtonOrder_Click;
            // 
            // TextTotalCost
            // 
            TextTotalCost.Anchor = AnchorStyles.Left;
            TextTotalCost.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextTotalCost.Location = new Point(293, 162);
            TextTotalCost.Margin = new Padding(4, 0, 4, 0);
            TextTotalCost.Name = "TextTotalCost";
            TextTotalCost.Size = new Size(237, 22);
            TextTotalCost.TabIndex = 24;
            TextTotalCost.Text = "item cost: £0";
            TextTotalCost.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TextQuantityRequired
            // 
            TextQuantityRequired.Anchor = AnchorStyles.Left;
            TextQuantityRequired.AutoSize = true;
            TextQuantityRequired.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextQuantityRequired.Location = new Point(14, 160);
            TextQuantityRequired.Margin = new Padding(4, 0, 4, 0);
            TextQuantityRequired.Name = "TextQuantityRequired";
            TextQuantityRequired.Size = new Size(146, 21);
            TextQuantityRequired.TabIndex = 22;
            TextQuantityRequired.Text = "quantity required:";
            // 
            // QuantityRequired
            // 
            QuantityRequired.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityRequired.Location = new Point(218, 157);
            QuantityRequired.Margin = new Padding(4, 3, 4, 3);
            QuantityRequired.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            QuantityRequired.Name = "QuantityRequired";
            QuantityRequired.Size = new Size(68, 24);
            QuantityRequired.TabIndex = 3;
            QuantityRequired.ValueChanged += QuantityRequired_ValueChanged;
            // 
            // DeliveryDate
            // 
            DeliveryDate.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeliveryDate.Location = new Point(218, 122);
            DeliveryDate.Margin = new Padding(4, 3, 4, 3);
            DeliveryDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            DeliveryDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            DeliveryDate.Name = "DeliveryDate";
            DeliveryDate.Size = new Size(311, 24);
            DeliveryDate.TabIndex = 2;
            DeliveryDate.Value = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            // 
            // BluePanel
            // 
            BluePanel.BackColor = Color.Transparent;
            BluePanel.Controls.Add(StockLink);
            BluePanel.Controls.Add(TextRestockTitle);
            BluePanel.Controls.Add(TextTerms);
            BluePanel.Dock = DockStyle.Top;
            BluePanel.Location = new Point(0, 0);
            BluePanel.Margin = new Padding(2, 1, 2, 1);
            BluePanel.Name = "BluePanel";
            BluePanel.Size = new Size(832, 75);
            BluePanel.TabIndex = 16;
            // 
            // StockLink
            // 
            StockLink.ActiveLinkColor = Color.Transparent;
            StockLink.AutoSize = true;
            StockLink.BackColor = Color.Transparent;
            StockLink.DisabledLinkColor = Color.Transparent;
            StockLink.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StockLink.LinkBehavior = LinkBehavior.NeverUnderline;
            StockLink.LinkColor = Color.Transparent;
            StockLink.Location = new Point(214, 27);
            StockLink.Margin = new Padding(4, 0, 4, 0);
            StockLink.Name = "StockLink";
            StockLink.Size = new Size(13, 19);
            StockLink.TabIndex = 1;
            StockLink.TabStop = true;
            StockLink.Text = " ";
            StockLink.VisitedLinkColor = Color.Transparent;
            // 
            // TextRestockTitle
            // 
            TextRestockTitle.Anchor = AnchorStyles.Left;
            TextRestockTitle.AutoSize = true;
            TextRestockTitle.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TextRestockTitle.ForeColor = Color.Black;
            TextRestockTitle.Location = new Point(13, 21);
            TextRestockTitle.Margin = new Padding(2, 0, 2, 0);
            TextRestockTitle.Name = "TextRestockTitle";
            TextRestockTitle.Size = new Size(168, 30);
            TextRestockTitle.TabIndex = 1;
            TextRestockTitle.Text = "Restock Items";
            // 
            // TextTerms
            // 
            TextTerms.Anchor = AnchorStyles.Left;
            TextTerms.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            TextTerms.ForeColor = Color.Black;
            TextTerms.Location = new Point(531, 14);
            TextTerms.Margin = new Padding(2, 0, 2, 0);
            TextTerms.Name = "TextTerms";
            TextTerms.Size = new Size(288, 42);
            TextTerms.TabIndex = 2;
            TextTerms.Text = "for simulation purposes, your item will \r\narrive inside the database instantly";
            TextTerms.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextDeliveryDate
            // 
            TextDeliveryDate.Anchor = AnchorStyles.Left;
            TextDeliveryDate.AutoSize = true;
            TextDeliveryDate.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextDeliveryDate.Location = new Point(14, 126);
            TextDeliveryDate.Margin = new Padding(4, 0, 4, 0);
            TextDeliveryDate.Name = "TextDeliveryDate";
            TextDeliveryDate.Size = new Size(111, 21);
            TextDeliveryDate.TabIndex = 25;
            TextDeliveryDate.Text = "delivery date:";
            // 
            // ButtonAdd
            // 
            ButtonAdd.AutoSize = false;
            ButtonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonAdd.Depth = 0;
            ButtonAdd.HighEmphasis = true;
            ButtonAdd.Icon = null;
            ButtonAdd.Location = new Point(537, 122);
            ButtonAdd.Margin = new Padding(4, 6, 4, 6);
            ButtonAdd.MouseState = MouseState.HOVER;
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.NoAccentTextColor = Color.Empty;
            ButtonAdd.Size = new Size(284, 62);
            ButtonAdd.TabIndex = 5;
            ButtonAdd.Text = "Add to Basket";
            ButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonAdd.UseAccentColor = false;
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonViewBasket
            // 
            ButtonViewBasket.AutoSize = false;
            ButtonViewBasket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonViewBasket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonViewBasket.Depth = 0;
            ButtonViewBasket.HighEmphasis = true;
            ButtonViewBasket.Icon = null;
            ButtonViewBasket.Location = new Point(14, 246);
            ButtonViewBasket.Margin = new Padding(4, 6, 4, 6);
            ButtonViewBasket.MouseState = MouseState.HOVER;
            ButtonViewBasket.Name = "ButtonViewBasket";
            ButtonViewBasket.NoAccentTextColor = Color.Empty;
            ButtonViewBasket.Size = new Size(329, 44);
            ButtonViewBasket.TabIndex = 7;
            ButtonViewBasket.Text = "View Basket (£0.00)";
            ButtonViewBasket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonViewBasket.UseAccentColor = false;
            ButtonViewBasket.UseVisualStyleBackColor = true;
            ButtonViewBasket.Click += ButtonViewBasket_Click;
            // 
            // TextRemove
            // 
            TextRemove.Anchor = AnchorStyles.Left;
            TextRemove.AutoSize = true;
            TextRemove.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextRemove.Location = new Point(13, 203);
            TextRemove.Margin = new Padding(4, 0, 4, 0);
            TextRemove.Name = "TextRemove";
            TextRemove.Size = new Size(168, 21);
            TextRemove.TabIndex = 28;
            TextRemove.Text = "remove from basket:";
            // 
            // ListBasket
            // 
            ListBasket.AutoResize = false;
            ListBasket.BackColor = Color.FromArgb(255, 255, 255);
            ListBasket.Depth = 0;
            ListBasket.DrawMode = DrawMode.OwnerDrawVariable;
            ListBasket.DropDownHeight = 292;
            ListBasket.DropDownStyle = ComboBoxStyle.DropDownList;
            ListBasket.DropDownWidth = 121;
            ListBasket.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListBasket.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ListBasket.FormattingEnabled = true;
            ListBasket.IntegralHeight = false;
            ListBasket.ItemHeight = 29;
            ListBasket.Location = new Point(216, 196);
            ListBasket.Margin = new Padding(4, 3, 4, 3);
            ListBasket.MaxDropDownItems = 10;
            ListBasket.MouseState = MouseState.OUT;
            ListBasket.Name = "ListBasket";
            ListBasket.Size = new Size(308, 35);
            ListBasket.StartIndex = 0;
            ListBasket.TabIndex = 4;
            ListBasket.UseAccent = false;
            ListBasket.UseTallSize = false;
            // 
            // ButtonRemove
            // 
            ButtonRemove.AutoSize = false;
            ButtonRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonRemove.Depth = 0;
            ButtonRemove.HighEmphasis = true;
            ButtonRemove.Icon = null;
            ButtonRemove.Location = new Point(536, 193);
            ButtonRemove.Margin = new Padding(4, 6, 4, 6);
            ButtonRemove.MouseState = MouseState.HOVER;
            ButtonRemove.Name = "ButtonRemove";
            ButtonRemove.NoAccentTextColor = Color.Empty;
            ButtonRemove.Size = new Size(285, 44);
            ButtonRemove.TabIndex = 6;
            ButtonRemove.Text = "Remove Item from Basket";
            ButtonRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonRemove.UseAccentColor = false;
            ButtonRemove.UseVisualStyleBackColor = true;
            ButtonRemove.Click += ButtonRemove_Click;
            // 
            // FormPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 303);
            Controls.Add(ButtonRemove);
            Controls.Add(ListBasket);
            Controls.Add(TextRemove);
            Controls.Add(ButtonViewBasket);
            Controls.Add(ButtonAdd);
            Controls.Add(ListProducts);
            Controls.Add(ButtonClose);
            Controls.Add(ButtonOrder);
            Controls.Add(TextTotalCost);
            Controls.Add(TextQuantityRequired);
            Controls.Add(QuantityRequired);
            Controls.Add(DeliveryDate);
            Controls.Add(BluePanel);
            Controls.Add(TextDeliveryDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormPurchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            ((ISupportInitialize)QuantityRequired).EndInit();
            BluePanel.ResumeLayout(false);
            BluePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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