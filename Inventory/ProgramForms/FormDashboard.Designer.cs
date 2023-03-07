namespace Inventory.ProgramForms
{
    partial class FormDashboard
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDashboard));
            OpenRestockButton = new MaterialSkin.Controls.MaterialButton();
            LeftPanel = new Panel();
            OpenEditButton = new MaterialSkin.Controls.MaterialButton();
            HeadingInsights = new Label();
            ButtonSettings = new MaterialSkin.Controls.MaterialButton();
            InsightButton = new MaterialSkin.Controls.MaterialButton();
            ToolsGeneralText = new Label();
            ToolsManagerText = new Label();
            LogoutButton = new LinkLabel();
            ViewStockButton = new MaterialSkin.Controls.MaterialButton();
            OpenOrdersButton = new MaterialSkin.Controls.MaterialButton();
            ResetPasswordButton = new MaterialSkin.Controls.MaterialButton();
            WelcomeText = new Label();
            ExitButton = new MaterialSkin.Controls.MaterialButton();
            TopLeftPanel = new Panel();
            TopMiddlePanel = new Panel();
            TopRightPanel = new Panel();
            ListBestSellers = new Label();
            TextBestSellers = new Label();
            HeaderProfit = new Label();
            HeaderProducts = new Label();
            PanelProfit = new Panel();
            QuantityItemsProfit = new Button();
            WeeklyProfitText = new Label();
            PanelOrders = new Panel();
            QuantityItemsOrders = new Button();
            WeeklyOrderText = new Label();
            HeaderOrders = new Label();
            WeeklyStockText = new Label();
            QuantityItemsStock = new Button();
            PanelStock = new Panel();
            UnusedButton = new MaterialSkin.Controls.MaterialButton();
            LeftPanel.SuspendLayout();
            TopRightPanel.SuspendLayout();
            PanelProfit.SuspendLayout();
            PanelOrders.SuspendLayout();
            PanelStock.SuspendLayout();
            SuspendLayout();
            // 
            // OpenRestockButton
            // 
            OpenRestockButton.Anchor = AnchorStyles.Left;
            OpenRestockButton.AutoSize = false;
            OpenRestockButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OpenRestockButton.BackColor = Color.White;
            OpenRestockButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            OpenRestockButton.Depth = 0;
            OpenRestockButton.ForeColor = SystemColors.ControlText;
            OpenRestockButton.HighEmphasis = true;
            OpenRestockButton.Icon = null;
            OpenRestockButton.Location = new Point(7, 553);
            OpenRestockButton.Margin = new Padding(4, 6, 4, 6);
            OpenRestockButton.MouseState = MouseState.HOVER;
            OpenRestockButton.Name = "OpenRestockButton";
            OpenRestockButton.NoAccentTextColor = Color.Empty;
            OpenRestockButton.Size = new Size(248, 74);
            OpenRestockButton.TabIndex = 7;
            OpenRestockButton.Text = "Restock Items";
            OpenRestockButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            OpenRestockButton.UseAccentColor = false;
            OpenRestockButton.UseVisualStyleBackColor = false;
            OpenRestockButton.Click += OpenRestockButton_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.Transparent;
            LeftPanel.Controls.Add(OpenEditButton);
            LeftPanel.Controls.Add(HeadingInsights);
            LeftPanel.Controls.Add(ButtonSettings);
            LeftPanel.Controls.Add(InsightButton);
            LeftPanel.Controls.Add(ToolsGeneralText);
            LeftPanel.Controls.Add(ToolsManagerText);
            LeftPanel.Controls.Add(LogoutButton);
            LeftPanel.Controls.Add(ViewStockButton);
            LeftPanel.Controls.Add(OpenRestockButton);
            LeftPanel.Controls.Add(OpenOrdersButton);
            LeftPanel.Controls.Add(ResetPasswordButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.ForeColor = Color.White;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Margin = new Padding(4, 3, 4, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(264, 786);
            LeftPanel.TabIndex = 27;
            // 
            // OpenEditButton
            // 
            OpenEditButton.Anchor = AnchorStyles.Left;
            OpenEditButton.AutoSize = false;
            OpenEditButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OpenEditButton.BackColor = Color.White;
            OpenEditButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            OpenEditButton.Depth = 0;
            OpenEditButton.ForeColor = SystemColors.ControlText;
            OpenEditButton.HighEmphasis = true;
            OpenEditButton.Icon = null;
            OpenEditButton.Location = new Point(7, 638);
            OpenEditButton.Margin = new Padding(4, 6, 4, 6);
            OpenEditButton.MouseState = MouseState.HOVER;
            OpenEditButton.Name = "OpenEditButton";
            OpenEditButton.NoAccentTextColor = Color.Empty;
            OpenEditButton.Size = new Size(248, 74);
            OpenEditButton.TabIndex = 35;
            OpenEditButton.Text = "Change User Info";
            OpenEditButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            OpenEditButton.UseAccentColor = false;
            OpenEditButton.UseVisualStyleBackColor = false;
            OpenEditButton.Click += OpenEditButton_Click;
            // 
            // HeadingInsights
            // 
            HeadingInsights.BackColor = Color.Transparent;
            HeadingInsights.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingInsights.ForeColor = Color.Black;
            HeadingInsights.Location = new Point(4, 3);
            HeadingInsights.Margin = new Padding(4, 0, 4, 0);
            HeadingInsights.Name = "HeadingInsights";
            HeadingInsights.Size = new Size(254, 50);
            HeadingInsights.TabIndex = 34;
            HeadingInsights.Text = "Dashboard";
            HeadingInsights.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonSettings
            // 
            ButtonSettings.Anchor = AnchorStyles.Left;
            ButtonSettings.AutoSize = false;
            ButtonSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSettings.BackColor = Color.White;
            ButtonSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSettings.Depth = 0;
            ButtonSettings.HighEmphasis = true;
            ButtonSettings.Icon = null;
            ButtonSettings.Location = new Point(7, 260);
            ButtonSettings.Margin = new Padding(4, 6, 4, 6);
            ButtonSettings.MouseState = MouseState.HOVER;
            ButtonSettings.Name = "ButtonSettings";
            ButtonSettings.NoAccentTextColor = Color.Empty;
            ButtonSettings.Size = new Size(248, 74);
            ButtonSettings.TabIndex = 30;
            ButtonSettings.Text = "App Settings";
            ButtonSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSettings.UseAccentColor = false;
            ButtonSettings.UseVisualStyleBackColor = false;
            ButtonSettings.Click += ButtonSettings_Click;
            // 
            // InsightButton
            // 
            InsightButton.Anchor = AnchorStyles.Left;
            InsightButton.AutoSize = false;
            InsightButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InsightButton.BackColor = Color.White;
            InsightButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            InsightButton.Depth = 0;
            InsightButton.HighEmphasis = true;
            InsightButton.Icon = null;
            InsightButton.Location = new Point(7, 382);
            InsightButton.Margin = new Padding(4, 6, 4, 6);
            InsightButton.MouseState = MouseState.HOVER;
            InsightButton.Name = "InsightButton";
            InsightButton.NoAccentTextColor = Color.Empty;
            InsightButton.Size = new Size(248, 74);
            InsightButton.TabIndex = 5;
            InsightButton.Text = "View Insights";
            InsightButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            InsightButton.UseAccentColor = false;
            InsightButton.UseVisualStyleBackColor = false;
            InsightButton.Click += ViewInsightButton_Click;
            // 
            // ToolsGeneralText
            // 
            ToolsGeneralText.BackColor = Color.Transparent;
            ToolsGeneralText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToolsGeneralText.ForeColor = Color.Black;
            ToolsGeneralText.ImageAlign = ContentAlignment.BottomLeft;
            ToolsGeneralText.Location = new Point(2, 53);
            ToolsGeneralText.Margin = new Padding(2, 0, 2, 0);
            ToolsGeneralText.Name = "ToolsGeneralText";
            ToolsGeneralText.Size = new Size(253, 30);
            ToolsGeneralText.TabIndex = 29;
            ToolsGeneralText.Text = "Standard Tools";
            ToolsGeneralText.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ToolsManagerText
            // 
            ToolsManagerText.BackColor = Color.Transparent;
            ToolsManagerText.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ToolsManagerText.ForeColor = Color.Black;
            ToolsManagerText.ImageAlign = ContentAlignment.BottomLeft;
            ToolsManagerText.Location = new Point(2, 339);
            ToolsManagerText.Margin = new Padding(2, 0, 2, 0);
            ToolsManagerText.Name = "ToolsManagerText";
            ToolsManagerText.Size = new Size(253, 37);
            ToolsManagerText.TabIndex = 28;
            ToolsManagerText.Text = "Manager Tools";
            ToolsManagerText.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LogoutButton
            // 
            LogoutButton.ActiveLinkColor = Color.Black;
            LogoutButton.BackColor = Color.Transparent;
            LogoutButton.DisabledLinkColor = Color.Black;
            LogoutButton.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.LinkColor = Color.Black;
            LogoutButton.Location = new Point(0, 728);
            LogoutButton.Margin = new Padding(4, 0, 4, 0);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(258, 47);
            LogoutButton.TabIndex = 2;
            LogoutButton.TabStop = true;
            LogoutButton.Text = "log out";
            LogoutButton.TextAlign = ContentAlignment.MiddleCenter;
            LogoutButton.VisitedLinkColor = Color.Black;
            LogoutButton.LinkClicked += LogOutLink_LinkClicked;
            // 
            // ViewStockButton
            // 
            ViewStockButton.Anchor = AnchorStyles.Left;
            ViewStockButton.AutoSize = false;
            ViewStockButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ViewStockButton.BackColor = Color.White;
            ViewStockButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ViewStockButton.Depth = 0;
            ViewStockButton.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewStockButton.HighEmphasis = true;
            ViewStockButton.Icon = null;
            ViewStockButton.Location = new Point(7, 89);
            ViewStockButton.Margin = new Padding(4, 6, 4, 6);
            ViewStockButton.MouseState = MouseState.HOVER;
            ViewStockButton.Name = "ViewStockButton";
            ViewStockButton.NoAccentTextColor = Color.Empty;
            ViewStockButton.Size = new Size(248, 74);
            ViewStockButton.TabIndex = 3;
            ViewStockButton.Text = "View all Stock";
            ViewStockButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ViewStockButton.UseAccentColor = false;
            ViewStockButton.UseVisualStyleBackColor = false;
            ViewStockButton.Click += ViewStockButton_Click;
            // 
            // OpenOrdersButton
            // 
            OpenOrdersButton.Anchor = AnchorStyles.Left;
            OpenOrdersButton.AutoSize = false;
            OpenOrdersButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OpenOrdersButton.BackColor = Color.White;
            OpenOrdersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            OpenOrdersButton.Depth = 0;
            OpenOrdersButton.HighEmphasis = true;
            OpenOrdersButton.Icon = null;
            OpenOrdersButton.Location = new Point(7, 467);
            OpenOrdersButton.Margin = new Padding(4, 6, 4, 6);
            OpenOrdersButton.MouseState = MouseState.HOVER;
            OpenOrdersButton.Name = "OpenOrdersButton";
            OpenOrdersButton.NoAccentTextColor = Color.Empty;
            OpenOrdersButton.Size = new Size(248, 74);
            OpenOrdersButton.TabIndex = 6;
            OpenOrdersButton.Text = "View Cust Orders";
            OpenOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            OpenOrdersButton.UseAccentColor = false;
            OpenOrdersButton.UseVisualStyleBackColor = false;
            OpenOrdersButton.Click += OpenOrdersButton_Click;
            // 
            // ResetPasswordButton
            // 
            ResetPasswordButton.Anchor = AnchorStyles.Left;
            ResetPasswordButton.AutoSize = false;
            ResetPasswordButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResetPasswordButton.BackColor = Color.White;
            ResetPasswordButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ResetPasswordButton.Depth = 0;
            ResetPasswordButton.HighEmphasis = true;
            ResetPasswordButton.Icon = null;
            ResetPasswordButton.Location = new Point(7, 174);
            ResetPasswordButton.Margin = new Padding(4, 6, 4, 6);
            ResetPasswordButton.MouseState = MouseState.HOVER;
            ResetPasswordButton.Name = "ResetPasswordButton";
            ResetPasswordButton.NoAccentTextColor = Color.Empty;
            ResetPasswordButton.Size = new Size(248, 74);
            ResetPasswordButton.TabIndex = 4;
            ResetPasswordButton.Text = "Change Password";
            ResetPasswordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ResetPasswordButton.UseAccentColor = false;
            ResetPasswordButton.UseVisualStyleBackColor = false;
            ResetPasswordButton.Click += ResetPasswordButton_Click;
            // 
            // WelcomeText
            // 
            WelcomeText.BackColor = Color.Transparent;
            WelcomeText.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeText.ForeColor = Color.Black;
            WelcomeText.Location = new Point(276, 3);
            WelcomeText.Margin = new Padding(2, 0, 2, 0);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(973, 50);
            WelcomeText.TabIndex = 26;
            WelcomeText.Text = "welcome, {username}!";
            WelcomeText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.AutoSize = false;
            ExitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ExitButton.Depth = 0;
            ExitButton.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.HighEmphasis = true;
            ExitButton.Icon = null;
            ExitButton.Location = new Point(271, 728);
            ExitButton.Margin = new Padding(1);
            ExitButton.MouseState = MouseState.HOVER;
            ExitButton.Name = "ExitButton";
            ExitButton.NoAccentTextColor = Color.Empty;
            ExitButton.Size = new Size(979, 47);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ExitButton.UseAccentColor = false;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // TopLeftPanel
            // 
            TopLeftPanel.BackColor = Color.Transparent;
            TopLeftPanel.Location = new Point(271, 91);
            TopLeftPanel.Margin = new Padding(4, 3, 4, 3);
            TopLeftPanel.Name = "TopLeftPanel";
            TopLeftPanel.Size = new Size(315, 245);
            TopLeftPanel.TabIndex = 28;
            // 
            // TopMiddlePanel
            // 
            TopMiddlePanel.BackColor = Color.Transparent;
            TopMiddlePanel.Location = new Point(602, 91);
            TopMiddlePanel.Margin = new Padding(4, 3, 4, 3);
            TopMiddlePanel.Name = "TopMiddlePanel";
            TopMiddlePanel.Size = new Size(315, 245);
            TopMiddlePanel.TabIndex = 29;
            // 
            // TopRightPanel
            // 
            TopRightPanel.BackColor = Color.Transparent;
            TopRightPanel.Controls.Add(ListBestSellers);
            TopRightPanel.Controls.Add(TextBestSellers);
            TopRightPanel.Location = new Point(934, 91);
            TopRightPanel.Margin = new Padding(4, 3, 4, 3);
            TopRightPanel.Name = "TopRightPanel";
            TopRightPanel.Size = new Size(315, 245);
            TopRightPanel.TabIndex = 29;
            // 
            // ListBestSellers
            // 
            ListBestSellers.BackColor = Color.Transparent;
            ListBestSellers.Dock = DockStyle.Fill;
            ListBestSellers.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ListBestSellers.Location = new Point(0, 43);
            ListBestSellers.Margin = new Padding(4, 0, 4, 0);
            ListBestSellers.Name = "ListBestSellers";
            ListBestSellers.Size = new Size(315, 202);
            ListBestSellers.TabIndex = 1;
            ListBestSellers.Text = "1. item1\r\n\r\n2. item2\r\n\r\n3. item3\r\n\r\n4. item4\r\n\r\n5. item5";
            // 
            // TextBestSellers
            // 
            TextBestSellers.BackColor = Color.Transparent;
            TextBestSellers.Dock = DockStyle.Top;
            TextBestSellers.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBestSellers.Location = new Point(0, 0);
            TextBestSellers.Margin = new Padding(4, 0, 4, 0);
            TextBestSellers.Name = "TextBestSellers";
            TextBestSellers.Size = new Size(315, 43);
            TextBestSellers.TabIndex = 0;
            TextBestSellers.Text = "Best Selling Items";
            TextBestSellers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeaderProfit
            // 
            HeaderProfit.BackColor = Color.Navy;
            HeaderProfit.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderProfit.ForeColor = Color.White;
            HeaderProfit.Location = new Point(602, 382);
            HeaderProfit.Margin = new Padding(4, 0, 4, 0);
            HeaderProfit.Name = "HeaderProfit";
            HeaderProfit.Size = new Size(315, 37);
            HeaderProfit.TabIndex = 1;
            HeaderProfit.Text = "Profit";
            HeaderProfit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeaderProducts
            // 
            HeaderProducts.BackColor = Color.Teal;
            HeaderProducts.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderProducts.ForeColor = Color.White;
            HeaderProducts.Location = new Point(271, 382);
            HeaderProducts.Margin = new Padding(4, 0, 4, 0);
            HeaderProducts.Name = "HeaderProducts";
            HeaderProducts.Size = new Size(315, 37);
            HeaderProducts.TabIndex = 0;
            HeaderProducts.Text = "Products";
            HeaderProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelProfit
            // 
            PanelProfit.BackColor = Color.MediumOrchid;
            PanelProfit.Controls.Add(QuantityItemsProfit);
            PanelProfit.Controls.Add(WeeklyProfitText);
            PanelProfit.Location = new Point(602, 419);
            PanelProfit.Margin = new Padding(4, 3, 4, 3);
            PanelProfit.Name = "PanelProfit";
            PanelProfit.Size = new Size(315, 294);
            PanelProfit.TabIndex = 36;
            // 
            // QuantityItemsProfit
            // 
            QuantityItemsProfit.BackColor = Color.RoyalBlue;
            QuantityItemsProfit.Dock = DockStyle.Fill;
            QuantityItemsProfit.FlatAppearance.BorderSize = 0;
            QuantityItemsProfit.FlatStyle = FlatStyle.Flat;
            QuantityItemsProfit.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityItemsProfit.ForeColor = Color.White;
            QuantityItemsProfit.Location = new Point(0, 0);
            QuantityItemsProfit.Margin = new Padding(4, 3, 4, 3);
            QuantityItemsProfit.Name = "QuantityItemsProfit";
            QuantityItemsProfit.Size = new Size(315, 207);
            QuantityItemsProfit.TabIndex = 29;
            QuantityItemsProfit.TabStop = false;
            QuantityItemsProfit.Text = "£(total)";
            QuantityItemsProfit.UseVisualStyleBackColor = false;
            // 
            // WeeklyProfitText
            // 
            WeeklyProfitText.BackColor = Color.RoyalBlue;
            WeeklyProfitText.Dock = DockStyle.Bottom;
            WeeklyProfitText.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            WeeklyProfitText.ForeColor = Color.White;
            WeeklyProfitText.Location = new Point(0, 207);
            WeeklyProfitText.Margin = new Padding(4, 0, 4, 0);
            WeeklyProfitText.Name = "WeeklyProfitText";
            WeeklyProfitText.Size = new Size(315, 87);
            WeeklyProfitText.TabIndex = 3;
            WeeklyProfitText.Text = "profit in the last 7 days";
            WeeklyProfitText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelOrders
            // 
            PanelOrders.BackColor = Color.FromArgb(203, 225, 30);
            PanelOrders.Controls.Add(QuantityItemsOrders);
            PanelOrders.Controls.Add(WeeklyOrderText);
            PanelOrders.Location = new Point(934, 419);
            PanelOrders.Margin = new Padding(4, 3, 4, 3);
            PanelOrders.Name = "PanelOrders";
            PanelOrders.Size = new Size(315, 294);
            PanelOrders.TabIndex = 36;
            // 
            // QuantityItemsOrders
            // 
            QuantityItemsOrders.BackColor = Color.Goldenrod;
            QuantityItemsOrders.Dock = DockStyle.Fill;
            QuantityItemsOrders.FlatAppearance.BorderSize = 0;
            QuantityItemsOrders.FlatStyle = FlatStyle.Flat;
            QuantityItemsOrders.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityItemsOrders.ForeColor = Color.White;
            QuantityItemsOrders.Location = new Point(0, 0);
            QuantityItemsOrders.Margin = new Padding(4, 3, 4, 3);
            QuantityItemsOrders.Name = "QuantityItemsOrders";
            QuantityItemsOrders.Size = new Size(315, 207);
            QuantityItemsOrders.TabIndex = 30;
            QuantityItemsOrders.TabStop = false;
            QuantityItemsOrders.Text = "(items)";
            QuantityItemsOrders.UseVisualStyleBackColor = false;
            // 
            // WeeklyOrderText
            // 
            WeeklyOrderText.BackColor = Color.Goldenrod;
            WeeklyOrderText.Dock = DockStyle.Bottom;
            WeeklyOrderText.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            WeeklyOrderText.ForeColor = Color.White;
            WeeklyOrderText.Location = new Point(0, 207);
            WeeklyOrderText.Margin = new Padding(4, 0, 4, 0);
            WeeklyOrderText.Name = "WeeklyOrderText";
            WeeklyOrderText.Size = new Size(315, 87);
            WeeklyOrderText.TabIndex = 4;
            WeeklyOrderText.Text = "orders in the last 7 days";
            WeeklyOrderText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeaderOrders
            // 
            HeaderOrders.BackColor = Color.DarkGoldenrod;
            HeaderOrders.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderOrders.ForeColor = Color.White;
            HeaderOrders.Location = new Point(934, 382);
            HeaderOrders.Margin = new Padding(4, 0, 4, 0);
            HeaderOrders.Name = "HeaderOrders";
            HeaderOrders.Size = new Size(315, 37);
            HeaderOrders.TabIndex = 2;
            HeaderOrders.Text = "Orders";
            HeaderOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeeklyStockText
            // 
            WeeklyStockText.BackColor = Color.LightSeaGreen;
            WeeklyStockText.Dock = DockStyle.Bottom;
            WeeklyStockText.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            WeeklyStockText.ForeColor = Color.White;
            WeeklyStockText.Location = new Point(0, 207);
            WeeklyStockText.Margin = new Padding(4, 0, 4, 0);
            WeeklyStockText.Name = "WeeklyStockText";
            WeeklyStockText.Size = new Size(315, 87);
            WeeklyStockText.TabIndex = 1;
            WeeklyStockText.Text = "items in stock currently";
            WeeklyStockText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuantityItemsStock
            // 
            QuantityItemsStock.BackColor = Color.LightSeaGreen;
            QuantityItemsStock.Dock = DockStyle.Fill;
            QuantityItemsStock.FlatAppearance.BorderSize = 0;
            QuantityItemsStock.FlatStyle = FlatStyle.Flat;
            QuantityItemsStock.Font = new Font("Microsoft YaHei", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityItemsStock.ForeColor = Color.White;
            QuantityItemsStock.Location = new Point(0, 0);
            QuantityItemsStock.Margin = new Padding(4, 3, 4, 3);
            QuantityItemsStock.Name = "QuantityItemsStock";
            QuantityItemsStock.Size = new Size(315, 207);
            QuantityItemsStock.TabIndex = 28;
            QuantityItemsStock.TabStop = false;
            QuantityItemsStock.Text = "(items)";
            QuantityItemsStock.UseVisualStyleBackColor = false;
            // 
            // PanelStock
            // 
            PanelStock.BackColor = Color.FromArgb(30, 203, 225);
            PanelStock.Controls.Add(QuantityItemsStock);
            PanelStock.Controls.Add(WeeklyStockText);
            PanelStock.Location = new Point(271, 419);
            PanelStock.Margin = new Padding(4, 3, 4, 3);
            PanelStock.Name = "PanelStock";
            PanelStock.Size = new Size(315, 294);
            PanelStock.TabIndex = 35;
            // 
            // UnusedButton
            // 
            UnusedButton.Anchor = AnchorStyles.Left;
            UnusedButton.AutoSize = false;
            UnusedButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UnusedButton.BackColor = Color.FromArgb(63, 81, 181);
            UnusedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            UnusedButton.Depth = 0;
            UnusedButton.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UnusedButton.HighEmphasis = true;
            UnusedButton.Icon = null;
            UnusedButton.Location = new Point(276, 382);
            UnusedButton.Margin = new Padding(4, 6, 4, 6);
            UnusedButton.MouseState = MouseState.HOVER;
            UnusedButton.Name = "UnusedButton";
            UnusedButton.NoAccentTextColor = Color.Empty;
            UnusedButton.Size = new Size(13, 22);
            UnusedButton.TabIndex = 1;
            UnusedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            UnusedButton.UseAccentColor = false;
            UnusedButton.UseVisualStyleBackColor = false;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1259, 786);
            Controls.Add(PanelStock);
            Controls.Add(HeaderProducts);
            Controls.Add(HeaderProfit);
            Controls.Add(HeaderOrders);
            Controls.Add(PanelOrders);
            Controls.Add(PanelProfit);
            Controls.Add(TopMiddlePanel);
            Controls.Add(WelcomeText);
            Controls.Add(TopRightPanel);
            Controls.Add(TopLeftPanel);
            Controls.Add(LeftPanel);
            Controls.Add(ExitButton);
            Controls.Add(UnusedButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += FormDashboard_Load;
            LeftPanel.ResumeLayout(false);
            TopRightPanel.ResumeLayout(false);
            PanelProfit.ResumeLayout(false);
            PanelOrders.ResumeLayout(false);
            PanelStock.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton OpenRestockButton;
        private System.Windows.Forms.Panel LeftPanel;
        private MaterialSkin.Controls.MaterialButton ViewStockButton;
        private MaterialSkin.Controls.MaterialButton ResetPasswordButton;
        private System.Windows.Forms.Label WelcomeText;
        private MaterialSkin.Controls.MaterialButton OpenOrdersButton;
        private MaterialSkin.Controls.MaterialButton ExitButton;
        private System.Windows.Forms.LinkLabel LogoutButton;
        private System.Windows.Forms.Panel TopLeftPanel;
        private System.Windows.Forms.Panel TopMiddlePanel;
        private System.Windows.Forms.Panel TopRightPanel;
        private System.Windows.Forms.Label HeadingInsights;
        private System.Windows.Forms.Label HeaderProfit;
        private System.Windows.Forms.Label HeaderProducts;
        private System.Windows.Forms.Panel PanelProfit;
        private System.Windows.Forms.Label WeeklyProfitText;
        private System.Windows.Forms.Panel PanelOrders;
        private System.Windows.Forms.Label WeeklyOrderText;
        private System.Windows.Forms.Button QuantityItemsProfit;
        private System.Windows.Forms.Button QuantityItemsOrders;
        private System.Windows.Forms.Label HeaderOrders;
        private System.Windows.Forms.Label WeeklyStockText;
        private System.Windows.Forms.Button QuantityItemsStock;
        private System.Windows.Forms.Panel PanelStock;
        private System.Windows.Forms.Label ToolsGeneralText;
        private System.Windows.Forms.Label ToolsManagerText;
        private MaterialSkin.Controls.MaterialButton InsightButton;
        private MaterialSkin.Controls.MaterialButton UnusedButton;
        private MaterialSkin.Controls.MaterialButton ButtonSettings;
        private System.Windows.Forms.Label TextBestSellers;
        private System.Windows.Forms.Label ListBestSellers;
        private MaterialSkin.Controls.MaterialButton OpenEditButton;
    }
}