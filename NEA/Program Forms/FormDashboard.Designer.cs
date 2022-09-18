namespace NEA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.OpenRestockButton = new MaterialSkin.Controls.MaterialButton();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.OpenEditButton = new MaterialSkin.Controls.MaterialButton();
            this.HeadingInsights = new System.Windows.Forms.Label();
            this.ButtonSettings = new MaterialSkin.Controls.MaterialButton();
            this.InsightButton = new MaterialSkin.Controls.MaterialButton();
            this.ToolsGeneralText = new System.Windows.Forms.Label();
            this.ToolsManagerText = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.LinkLabel();
            this.ViewStockButton = new MaterialSkin.Controls.MaterialButton();
            this.OpenOrdersButton = new MaterialSkin.Controls.MaterialButton();
            this.ResetPasswordButton = new MaterialSkin.Controls.MaterialButton();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.ExitButton = new MaterialSkin.Controls.MaterialButton();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.ChartStockType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopMiddlePanel = new System.Windows.Forms.Panel();
            this.ChartDailyOrders = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopRightPanel = new System.Windows.Forms.Panel();
            this.ListBestSellers = new System.Windows.Forms.Label();
            this.TextBestSellers = new System.Windows.Forms.Label();
            this.HeaderProfit = new System.Windows.Forms.Label();
            this.HeaderProducts = new System.Windows.Forms.Label();
            this.PanelProfit = new System.Windows.Forms.Panel();
            this.QuantityItemsProfit = new System.Windows.Forms.Button();
            this.WeeklyProfitText = new System.Windows.Forms.Label();
            this.PanelOrders = new System.Windows.Forms.Panel();
            this.QuantityItemsOrders = new System.Windows.Forms.Button();
            this.WeeklyOrderText = new System.Windows.Forms.Label();
            this.HeaderOrders = new System.Windows.Forms.Label();
            this.WeeklyStockText = new System.Windows.Forms.Label();
            this.QuantityItemsStock = new System.Windows.Forms.Button();
            this.PanelStock = new System.Windows.Forms.Panel();
            this.UnusedButton = new MaterialSkin.Controls.MaterialButton();
            this.LeftPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStockType)).BeginInit();
            this.TopMiddlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDailyOrders)).BeginInit();
            this.TopRightPanel.SuspendLayout();
            this.PanelProfit.SuspendLayout();
            this.PanelOrders.SuspendLayout();
            this.PanelStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenRestockButton
            // 
            this.OpenRestockButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenRestockButton.AutoSize = false;
            this.OpenRestockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenRestockButton.BackColor = System.Drawing.Color.White;
            this.OpenRestockButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenRestockButton.Depth = 0;
            this.OpenRestockButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenRestockButton.HighEmphasis = true;
            this.OpenRestockButton.Icon = null;
            this.OpenRestockButton.Location = new System.Drawing.Point(6, 479);
            this.OpenRestockButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OpenRestockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenRestockButton.Name = "OpenRestockButton";
            this.OpenRestockButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenRestockButton.Size = new System.Drawing.Size(213, 64);
            this.OpenRestockButton.TabIndex = 7;
            this.OpenRestockButton.Text = "Restock Items";
            this.OpenRestockButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenRestockButton.UseAccentColor = false;
            this.OpenRestockButton.UseVisualStyleBackColor = false;
            this.OpenRestockButton.Click += new System.EventHandler(this.OpenRestockButton_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel.Controls.Add(this.OpenEditButton);
            this.LeftPanel.Controls.Add(this.HeadingInsights);
            this.LeftPanel.Controls.Add(this.ButtonSettings);
            this.LeftPanel.Controls.Add(this.InsightButton);
            this.LeftPanel.Controls.Add(this.ToolsGeneralText);
            this.LeftPanel.Controls.Add(this.ToolsManagerText);
            this.LeftPanel.Controls.Add(this.LogoutButton);
            this.LeftPanel.Controls.Add(this.ViewStockButton);
            this.LeftPanel.Controls.Add(this.OpenRestockButton);
            this.LeftPanel.Controls.Add(this.OpenOrdersButton);
            this.LeftPanel.Controls.Add(this.ResetPasswordButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.ForeColor = System.Drawing.Color.White;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(226, 681);
            this.LeftPanel.TabIndex = 27;
            // 
            // OpenEditButton
            // 
            this.OpenEditButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenEditButton.AutoSize = false;
            this.OpenEditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenEditButton.BackColor = System.Drawing.Color.White;
            this.OpenEditButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenEditButton.Depth = 0;
            this.OpenEditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenEditButton.HighEmphasis = true;
            this.OpenEditButton.Icon = null;
            this.OpenEditButton.Location = new System.Drawing.Point(6, 553);
            this.OpenEditButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OpenEditButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenEditButton.Name = "OpenEditButton";
            this.OpenEditButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenEditButton.Size = new System.Drawing.Size(213, 64);
            this.OpenEditButton.TabIndex = 35;
            this.OpenEditButton.Text = "Change User Info";
            this.OpenEditButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenEditButton.UseAccentColor = false;
            this.OpenEditButton.UseVisualStyleBackColor = false;
            this.OpenEditButton.Click += new System.EventHandler(this.OpenEditButton_Click);
            // 
            // HeadingInsights
            // 
            this.HeadingInsights.BackColor = System.Drawing.Color.Transparent;
            this.HeadingInsights.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingInsights.ForeColor = System.Drawing.Color.Black;
            this.HeadingInsights.Location = new System.Drawing.Point(3, 3);
            this.HeadingInsights.Name = "HeadingInsights";
            this.HeadingInsights.Size = new System.Drawing.Size(214, 43);
            this.HeadingInsights.TabIndex = 34;
            this.HeadingInsights.Text = "Dashboard";
            this.HeadingInsights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonSettings.AutoSize = false;
            this.ButtonSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSettings.BackColor = System.Drawing.Color.White;
            this.ButtonSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSettings.Depth = 0;
            this.ButtonSettings.HighEmphasis = true;
            this.ButtonSettings.Icon = null;
            this.ButtonSettings.Location = new System.Drawing.Point(6, 225);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSettings.Size = new System.Drawing.Size(213, 64);
            this.ButtonSettings.TabIndex = 30;
            this.ButtonSettings.Text = "App Settings";
            this.ButtonSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSettings.UseAccentColor = false;
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // InsightButton
            // 
            this.InsightButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InsightButton.AutoSize = false;
            this.InsightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsightButton.BackColor = System.Drawing.Color.White;
            this.InsightButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.InsightButton.Depth = 0;
            this.InsightButton.HighEmphasis = true;
            this.InsightButton.Icon = null;
            this.InsightButton.Location = new System.Drawing.Point(6, 331);
            this.InsightButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InsightButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InsightButton.Name = "InsightButton";
            this.InsightButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.InsightButton.Size = new System.Drawing.Size(213, 64);
            this.InsightButton.TabIndex = 5;
            this.InsightButton.Text = "View Insights";
            this.InsightButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.InsightButton.UseAccentColor = false;
            this.InsightButton.UseVisualStyleBackColor = false;
            this.InsightButton.Click += new System.EventHandler(this.ViewInsightButton_Click);
            // 
            // ToolsGeneralText
            // 
            this.ToolsGeneralText.BackColor = System.Drawing.Color.Transparent;
            this.ToolsGeneralText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsGeneralText.ForeColor = System.Drawing.Color.Black;
            this.ToolsGeneralText.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ToolsGeneralText.Location = new System.Drawing.Point(2, 46);
            this.ToolsGeneralText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToolsGeneralText.Name = "ToolsGeneralText";
            this.ToolsGeneralText.Size = new System.Drawing.Size(217, 26);
            this.ToolsGeneralText.TabIndex = 29;
            this.ToolsGeneralText.Text = "Standard Tools";
            this.ToolsGeneralText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ToolsManagerText
            // 
            this.ToolsManagerText.BackColor = System.Drawing.Color.Transparent;
            this.ToolsManagerText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsManagerText.ForeColor = System.Drawing.Color.Black;
            this.ToolsManagerText.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ToolsManagerText.Location = new System.Drawing.Point(2, 294);
            this.ToolsManagerText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToolsManagerText.Name = "ToolsManagerText";
            this.ToolsManagerText.Size = new System.Drawing.Size(217, 32);
            this.ToolsManagerText.TabIndex = 28;
            this.ToolsManagerText.Text = "Manager Tools";
            this.ToolsManagerText.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LogoutButton
            // 
            this.LogoutButton.ActiveLinkColor = System.Drawing.Color.Black;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.DisabledLinkColor = System.Drawing.Color.Black;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.LinkColor = System.Drawing.Color.Black;
            this.LogoutButton.Location = new System.Drawing.Point(0, 631);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(221, 41);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.TabStop = true;
            this.LogoutButton.Text = "log out";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoutButton.VisitedLinkColor = System.Drawing.Color.Black;
            this.LogoutButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLink_LinkClicked);
            // 
            // ViewStockButton
            // 
            this.ViewStockButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ViewStockButton.AutoSize = false;
            this.ViewStockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewStockButton.BackColor = System.Drawing.Color.White;
            this.ViewStockButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ViewStockButton.Depth = 0;
            this.ViewStockButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ViewStockButton.HighEmphasis = true;
            this.ViewStockButton.Icon = null;
            this.ViewStockButton.Location = new System.Drawing.Point(6, 77);
            this.ViewStockButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ViewStockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViewStockButton.Name = "ViewStockButton";
            this.ViewStockButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ViewStockButton.Size = new System.Drawing.Size(213, 64);
            this.ViewStockButton.TabIndex = 3;
            this.ViewStockButton.Text = "View all Stock";
            this.ViewStockButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ViewStockButton.UseAccentColor = false;
            this.ViewStockButton.UseVisualStyleBackColor = false;
            this.ViewStockButton.Click += new System.EventHandler(this.ViewStockButton_Click);
            // 
            // OpenOrdersButton
            // 
            this.OpenOrdersButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenOrdersButton.AutoSize = false;
            this.OpenOrdersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenOrdersButton.BackColor = System.Drawing.Color.White;
            this.OpenOrdersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenOrdersButton.Depth = 0;
            this.OpenOrdersButton.HighEmphasis = true;
            this.OpenOrdersButton.Icon = null;
            this.OpenOrdersButton.Location = new System.Drawing.Point(6, 405);
            this.OpenOrdersButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OpenOrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenOrdersButton.Name = "OpenOrdersButton";
            this.OpenOrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenOrdersButton.Size = new System.Drawing.Size(213, 64);
            this.OpenOrdersButton.TabIndex = 6;
            this.OpenOrdersButton.Text = "View Cust Orders";
            this.OpenOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenOrdersButton.UseAccentColor = false;
            this.OpenOrdersButton.UseVisualStyleBackColor = false;
            this.OpenOrdersButton.Click += new System.EventHandler(this.OpenOrdersButton_Click);
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResetPasswordButton.AutoSize = false;
            this.ResetPasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetPasswordButton.BackColor = System.Drawing.Color.White;
            this.ResetPasswordButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ResetPasswordButton.Depth = 0;
            this.ResetPasswordButton.HighEmphasis = true;
            this.ResetPasswordButton.Icon = null;
            this.ResetPasswordButton.Location = new System.Drawing.Point(6, 151);
            this.ResetPasswordButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ResetPasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ResetPasswordButton.Size = new System.Drawing.Size(213, 64);
            this.ResetPasswordButton.TabIndex = 4;
            this.ResetPasswordButton.Text = "Change Password";
            this.ResetPasswordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ResetPasswordButton.UseAccentColor = false;
            this.ResetPasswordButton.UseVisualStyleBackColor = false;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.ForeColor = System.Drawing.Color.Black;
            this.WelcomeText.Location = new System.Drawing.Point(487, 3);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(584, 43);
            this.WelcomeText.TabIndex = 26;
            this.WelcomeText.Text = "welcome, (blank)!";
            this.WelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = false;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExitButton.Depth = 0;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ExitButton.HighEmphasis = true;
            this.ExitButton.Icon = null;
            this.ExitButton.Location = new System.Drawing.Point(232, 631);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(1);
            this.ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExitButton.Size = new System.Drawing.Size(839, 41);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExitButton.UseAccentColor = false;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopLeftPanel.Controls.Add(this.ChartStockType);
            this.TopLeftPanel.Location = new System.Drawing.Point(232, 79);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Size = new System.Drawing.Size(270, 212);
            this.TopLeftPanel.TabIndex = 28;
            // 
            // ChartStockType
            // 
            this.ChartStockType.BackColor = System.Drawing.Color.Transparent;
            this.ChartStockType.BorderlineColor = System.Drawing.Color.Transparent;
            this.ChartStockType.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartStockType.ChartAreas.Add(chartArea1);
            this.ChartStockType.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Title = "Types";
            legend1.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartStockType.Legends.Add(legend1);
            this.ChartStockType.Location = new System.Drawing.Point(0, 0);
            this.ChartStockType.Name = "ChartStockType";
            this.ChartStockType.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "StockByType";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.ChartStockType.Series.Add(series1);
            this.ChartStockType.Size = new System.Drawing.Size(270, 212);
            this.ChartStockType.TabIndex = 0;
            this.ChartStockType.TabStop = false;
            this.ChartStockType.Text = "ChartStockType";
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "StockByType";
            title1.Text = "Stock by Type";
            this.ChartStockType.Titles.Add(title1);
            // 
            // TopMiddlePanel
            // 
            this.TopMiddlePanel.BackColor = System.Drawing.Color.Transparent;
            this.TopMiddlePanel.Controls.Add(this.ChartDailyOrders);
            this.TopMiddlePanel.Location = new System.Drawing.Point(516, 79);
            this.TopMiddlePanel.Name = "TopMiddlePanel";
            this.TopMiddlePanel.Size = new System.Drawing.Size(270, 212);
            this.TopMiddlePanel.TabIndex = 29;
            // 
            // ChartDailyOrders
            // 
            this.ChartDailyOrders.BackColor = System.Drawing.Color.Transparent;
            this.ChartDailyOrders.BorderlineColor = System.Drawing.Color.Transparent;
            this.ChartDailyOrders.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ChartDailyOrders.ChartAreas.Add(chartArea2);
            this.ChartDailyOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartDailyOrders.Legends.Add(legend2);
            this.ChartDailyOrders.Location = new System.Drawing.Point(0, 0);
            this.ChartDailyOrders.Name = "ChartDailyOrders";
            this.ChartDailyOrders.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.Transparent;
            series2.CustomProperties = "EmptyPointValue=Zero";
            series2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "DailyOrders";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.ChartDailyOrders.Series.Add(series2);
            this.ChartDailyOrders.Size = new System.Drawing.Size(270, 212);
            this.ChartDailyOrders.TabIndex = 1;
            this.ChartDailyOrders.TabStop = false;
            this.ChartDailyOrders.Text = "ChartBestSellers";
            title2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "DailyOrders";
            title2.Text = "Orders This Week";
            this.ChartDailyOrders.Titles.Add(title2);
            // 
            // TopRightPanel
            // 
            this.TopRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopRightPanel.Controls.Add(this.ListBestSellers);
            this.TopRightPanel.Controls.Add(this.TextBestSellers);
            this.TopRightPanel.Location = new System.Drawing.Point(801, 79);
            this.TopRightPanel.Name = "TopRightPanel";
            this.TopRightPanel.Size = new System.Drawing.Size(270, 212);
            this.TopRightPanel.TabIndex = 29;
            // 
            // ListBestSellers
            // 
            this.ListBestSellers.BackColor = System.Drawing.Color.Transparent;
            this.ListBestSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBestSellers.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBestSellers.Location = new System.Drawing.Point(0, 37);
            this.ListBestSellers.Name = "ListBestSellers";
            this.ListBestSellers.Size = new System.Drawing.Size(270, 175);
            this.ListBestSellers.TabIndex = 1;
            this.ListBestSellers.Text = "1. item1\r\n\r\n2. item2\r\n\r\n3. item3\r\n\r\n4. item4\r\n\r\n5. item5";
            this.ListBestSellers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBestSellers
            // 
            this.TextBestSellers.BackColor = System.Drawing.Color.Transparent;
            this.TextBestSellers.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBestSellers.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBestSellers.Location = new System.Drawing.Point(0, 0);
            this.TextBestSellers.Name = "TextBestSellers";
            this.TextBestSellers.Size = new System.Drawing.Size(270, 37);
            this.TextBestSellers.TabIndex = 0;
            this.TextBestSellers.Text = "Best Selling Items";
            this.TextBestSellers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderProfit
            // 
            this.HeaderProfit.BackColor = System.Drawing.Color.Navy;
            this.HeaderProfit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderProfit.ForeColor = System.Drawing.Color.White;
            this.HeaderProfit.Location = new System.Drawing.Point(516, 331);
            this.HeaderProfit.Name = "HeaderProfit";
            this.HeaderProfit.Size = new System.Drawing.Size(270, 32);
            this.HeaderProfit.TabIndex = 1;
            this.HeaderProfit.Text = "Profit";
            this.HeaderProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderProducts
            // 
            this.HeaderProducts.BackColor = System.Drawing.Color.Teal;
            this.HeaderProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderProducts.ForeColor = System.Drawing.Color.White;
            this.HeaderProducts.Location = new System.Drawing.Point(232, 331);
            this.HeaderProducts.Name = "HeaderProducts";
            this.HeaderProducts.Size = new System.Drawing.Size(270, 32);
            this.HeaderProducts.TabIndex = 0;
            this.HeaderProducts.Text = "Products";
            this.HeaderProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelProfit
            // 
            this.PanelProfit.BackColor = System.Drawing.Color.MediumOrchid;
            this.PanelProfit.Controls.Add(this.QuantityItemsProfit);
            this.PanelProfit.Controls.Add(this.WeeklyProfitText);
            this.PanelProfit.Location = new System.Drawing.Point(516, 363);
            this.PanelProfit.Name = "PanelProfit";
            this.PanelProfit.Size = new System.Drawing.Size(270, 255);
            this.PanelProfit.TabIndex = 36;
            // 
            // QuantityItemsProfit
            // 
            this.QuantityItemsProfit.BackColor = System.Drawing.Color.RoyalBlue;
            this.QuantityItemsProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityItemsProfit.FlatAppearance.BorderSize = 0;
            this.QuantityItemsProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityItemsProfit.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityItemsProfit.ForeColor = System.Drawing.Color.White;
            this.QuantityItemsProfit.Location = new System.Drawing.Point(0, 0);
            this.QuantityItemsProfit.Name = "QuantityItemsProfit";
            this.QuantityItemsProfit.Size = new System.Drawing.Size(270, 180);
            this.QuantityItemsProfit.TabIndex = 29;
            this.QuantityItemsProfit.TabStop = false;
            this.QuantityItemsProfit.Text = "£(total)";
            this.QuantityItemsProfit.UseVisualStyleBackColor = false;
            // 
            // WeeklyProfitText
            // 
            this.WeeklyProfitText.BackColor = System.Drawing.Color.RoyalBlue;
            this.WeeklyProfitText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WeeklyProfitText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyProfitText.ForeColor = System.Drawing.Color.White;
            this.WeeklyProfitText.Location = new System.Drawing.Point(0, 180);
            this.WeeklyProfitText.Name = "WeeklyProfitText";
            this.WeeklyProfitText.Size = new System.Drawing.Size(270, 75);
            this.WeeklyProfitText.TabIndex = 3;
            this.WeeklyProfitText.Text = "profit in the last 7 days";
            this.WeeklyProfitText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelOrders
            // 
            this.PanelOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(225)))), ((int)(((byte)(30)))));
            this.PanelOrders.Controls.Add(this.QuantityItemsOrders);
            this.PanelOrders.Controls.Add(this.WeeklyOrderText);
            this.PanelOrders.Location = new System.Drawing.Point(801, 363);
            this.PanelOrders.Name = "PanelOrders";
            this.PanelOrders.Size = new System.Drawing.Size(270, 255);
            this.PanelOrders.TabIndex = 36;
            // 
            // QuantityItemsOrders
            // 
            this.QuantityItemsOrders.BackColor = System.Drawing.Color.Goldenrod;
            this.QuantityItemsOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityItemsOrders.FlatAppearance.BorderSize = 0;
            this.QuantityItemsOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityItemsOrders.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityItemsOrders.ForeColor = System.Drawing.Color.White;
            this.QuantityItemsOrders.Location = new System.Drawing.Point(0, 0);
            this.QuantityItemsOrders.Name = "QuantityItemsOrders";
            this.QuantityItemsOrders.Size = new System.Drawing.Size(270, 180);
            this.QuantityItemsOrders.TabIndex = 30;
            this.QuantityItemsOrders.TabStop = false;
            this.QuantityItemsOrders.Text = "(items)";
            this.QuantityItemsOrders.UseVisualStyleBackColor = false;
            // 
            // WeeklyOrderText
            // 
            this.WeeklyOrderText.BackColor = System.Drawing.Color.Goldenrod;
            this.WeeklyOrderText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WeeklyOrderText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyOrderText.ForeColor = System.Drawing.Color.White;
            this.WeeklyOrderText.Location = new System.Drawing.Point(0, 180);
            this.WeeklyOrderText.Name = "WeeklyOrderText";
            this.WeeklyOrderText.Size = new System.Drawing.Size(270, 75);
            this.WeeklyOrderText.TabIndex = 4;
            this.WeeklyOrderText.Text = "orders in the last 7 days";
            this.WeeklyOrderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderOrders
            // 
            this.HeaderOrders.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.HeaderOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderOrders.ForeColor = System.Drawing.Color.White;
            this.HeaderOrders.Location = new System.Drawing.Point(801, 331);
            this.HeaderOrders.Name = "HeaderOrders";
            this.HeaderOrders.Size = new System.Drawing.Size(270, 32);
            this.HeaderOrders.TabIndex = 2;
            this.HeaderOrders.Text = "Orders";
            this.HeaderOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeeklyStockText
            // 
            this.WeeklyStockText.BackColor = System.Drawing.Color.LightSeaGreen;
            this.WeeklyStockText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WeeklyStockText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklyStockText.ForeColor = System.Drawing.Color.White;
            this.WeeklyStockText.Location = new System.Drawing.Point(0, 180);
            this.WeeklyStockText.Name = "WeeklyStockText";
            this.WeeklyStockText.Size = new System.Drawing.Size(270, 75);
            this.WeeklyStockText.TabIndex = 1;
            this.WeeklyStockText.Text = "items in stock currently";
            this.WeeklyStockText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityItemsStock
            // 
            this.QuantityItemsStock.BackColor = System.Drawing.Color.LightSeaGreen;
            this.QuantityItemsStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityItemsStock.FlatAppearance.BorderSize = 0;
            this.QuantityItemsStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityItemsStock.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityItemsStock.ForeColor = System.Drawing.Color.White;
            this.QuantityItemsStock.Location = new System.Drawing.Point(0, 0);
            this.QuantityItemsStock.Name = "QuantityItemsStock";
            this.QuantityItemsStock.Size = new System.Drawing.Size(270, 180);
            this.QuantityItemsStock.TabIndex = 28;
            this.QuantityItemsStock.TabStop = false;
            this.QuantityItemsStock.Text = "(items)";
            this.QuantityItemsStock.UseVisualStyleBackColor = false;
            // 
            // PanelStock
            // 
            this.PanelStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(203)))), ((int)(((byte)(225)))));
            this.PanelStock.Controls.Add(this.QuantityItemsStock);
            this.PanelStock.Controls.Add(this.WeeklyStockText);
            this.PanelStock.Location = new System.Drawing.Point(232, 363);
            this.PanelStock.Name = "PanelStock";
            this.PanelStock.Size = new System.Drawing.Size(270, 255);
            this.PanelStock.TabIndex = 35;
            // 
            // UnusedButton
            // 
            this.UnusedButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnusedButton.AutoSize = false;
            this.UnusedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnusedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.UnusedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UnusedButton.Depth = 0;
            this.UnusedButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.UnusedButton.HighEmphasis = true;
            this.UnusedButton.Icon = null;
            this.UnusedButton.Location = new System.Drawing.Point(237, 331);
            this.UnusedButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UnusedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnusedButton.Name = "UnusedButton";
            this.UnusedButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UnusedButton.Size = new System.Drawing.Size(11, 19);
            this.UnusedButton.TabIndex = 1;
            this.UnusedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UnusedButton.UseAccentColor = false;
            this.UnusedButton.UseVisualStyleBackColor = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 681);
            this.Controls.Add(this.PanelStock);
            this.Controls.Add(this.HeaderProducts);
            this.Controls.Add(this.HeaderProfit);
            this.Controls.Add(this.HeaderOrders);
            this.Controls.Add(this.PanelOrders);
            this.Controls.Add(this.PanelProfit);
            this.Controls.Add(this.TopMiddlePanel);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.TopRightPanel);
            this.Controls.Add(this.TopLeftPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.UnusedButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartStockType)).EndInit();
            this.TopMiddlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDailyOrders)).EndInit();
            this.TopRightPanel.ResumeLayout(false);
            this.PanelProfit.ResumeLayout(false);
            this.PanelOrders.ResumeLayout(false);
            this.PanelStock.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartStockType;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDailyOrders;
        private MaterialSkin.Controls.MaterialButton ButtonSettings;
        private System.Windows.Forms.Label TextBestSellers;
        private System.Windows.Forms.Label ListBestSellers;
        private MaterialSkin.Controls.MaterialButton OpenEditButton;
    }
}