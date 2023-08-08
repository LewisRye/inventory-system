namespace Inventory.DataForms
{
    partial class FormViewInsights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            Title title1 = new Title();
            CloseButton = new MaterialSkin.Controls.MaterialButton();
            WelcomeText = new Label();
            TextInsights = new Label();
            FromDate = new DateTimePicker();
            ToDate = new DateTimePicker();
            TextDates = new Label();
            ButtonInsight = new MaterialSkin.Controls.MaterialButton();
            TextBestSeller = new Label();
            TextMostProfitableDay = new Label();
            TextTotalProfit = new Label();
            TextTotalItemsSold = new Label();
            DatabaseGrid = new DataGridView();
            TextDataGrid = new Label();
            ChartDailyRevenue = new Chart();
            TextDuringThisTime = new Label();
            TextSelectDate = new Label();
            ((ISupportInitialize)DatabaseGrid).BeginInit();
            ((ISupportInitialize)ChartDailyRevenue).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Left;
            CloseButton.AutoSize = false;
            CloseButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CloseButton.Depth = 0;
            CloseButton.HighEmphasis = true;
            CloseButton.Icon = null;
            CloseButton.Location = new Point(1104, 638);
            CloseButton.Margin = new Padding(4, 6, 4, 6);
            CloseButton.MouseState = MouseState.HOVER;
            CloseButton.Name = "CloseButton";
            CloseButton.NoAccentTextColor = Color.Empty;
            CloseButton.Size = new Size(142, 57);
            CloseButton.TabIndex = 28;
            CloseButton.Text = "Dashboard";
            CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            CloseButton.UseAccentColor = false;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // WelcomeText
            // 
            WelcomeText.BackColor = Color.Transparent;
            WelcomeText.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeText.ForeColor = Color.Black;
            WelcomeText.Location = new Point(794, 10);
            WelcomeText.Margin = new Padding(2, 0, 2, 0);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(451, 46);
            WelcomeText.TabIndex = 26;
            WelcomeText.Text = "welcome, (blank)!";
            WelcomeText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TextInsights
            // 
            TextInsights.BackColor = Color.Transparent;
            TextInsights.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TextInsights.Location = new Point(14, 10);
            TextInsights.Margin = new Padding(4, 0, 4, 0);
            TextInsights.Name = "TextInsights";
            TextInsights.Size = new Size(303, 46);
            TextInsights.TabIndex = 35;
            TextInsights.Text = "Insights";
            TextInsights.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FromDate
            // 
            FromDate.CustomFormat = "dd/MM/yyyy";
            FromDate.Location = new Point(292, 23);
            FromDate.Margin = new Padding(4, 3, 4, 3);
            FromDate.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            FromDate.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            FromDate.Name = "FromDate";
            FromDate.Size = new Size(154, 23);
            FromDate.TabIndex = 36;
            FromDate.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            FromDate.ValueChanged += FromDate_ValueChanged;
            // 
            // ToDate
            // 
            ToDate.CustomFormat = "dd/MM/yyyy";
            ToDate.Location = new Point(499, 23);
            ToDate.Margin = new Padding(4, 3, 4, 3);
            ToDate.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            ToDate.MinDate = new DateTime(2020, 1, 2, 0, 0, 0, 0);
            ToDate.Name = "ToDate";
            ToDate.Size = new Size(154, 23);
            ToDate.TabIndex = 37;
            ToDate.Value = new DateTime(2022, 4, 12, 0, 0, 0, 0);
            ToDate.ValueChanged += ToDate_ValueChanged;
            // 
            // TextDates
            // 
            TextDates.BackColor = Color.Transparent;
            TextDates.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextDates.Location = new Point(138, 15);
            TextDates.Margin = new Padding(4, 0, 4, 0);
            TextDates.Name = "TextDates";
            TextDates.Size = new Size(433, 35);
            TextDates.TabIndex = 38;
            TextDates.Text = "Get data from:                               to:";
            TextDates.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ButtonInsight
            // 
            ButtonInsight.AutoSize = false;
            ButtonInsight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonInsight.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonInsight.Depth = 0;
            ButtonInsight.HighEmphasis = true;
            ButtonInsight.Icon = null;
            ButtonInsight.Location = new Point(663, 23);
            ButtonInsight.Margin = new Padding(5, 7, 5, 7);
            ButtonInsight.MouseState = MouseState.HOVER;
            ButtonInsight.Name = "ButtonInsight";
            ButtonInsight.NoAccentTextColor = Color.Empty;
            ButtonInsight.Size = new Size(125, 23);
            ButtonInsight.TabIndex = 40;
            ButtonInsight.Text = "Get Insights";
            ButtonInsight.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonInsight.UseAccentColor = false;
            ButtonInsight.UseVisualStyleBackColor = true;
            ButtonInsight.Click += ButtonInsight_Click;
            // 
            // TextBestSeller
            // 
            TextBestSeller.BackColor = Color.Transparent;
            TextBestSeller.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBestSeller.Location = new Point(15, 230);
            TextBestSeller.Margin = new Padding(4, 0, 4, 0);
            TextBestSeller.Name = "TextBestSeller";
            TextBestSeller.Size = new Size(776, 36);
            TextBestSeller.TabIndex = 41;
            TextBestSeller.Text = "Select dates to see the best selling item during that time.";
            TextBestSeller.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TextMostProfitableDay
            // 
            TextMostProfitableDay.BackColor = Color.Transparent;
            TextMostProfitableDay.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextMostProfitableDay.Location = new Point(15, 158);
            TextMostProfitableDay.Margin = new Padding(4, 0, 4, 0);
            TextMostProfitableDay.Name = "TextMostProfitableDay";
            TextMostProfitableDay.Size = new Size(776, 36);
            TextMostProfitableDay.TabIndex = 42;
            TextMostProfitableDay.Text = "Select dates to see the most profitable day during that time.";
            TextMostProfitableDay.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TextTotalProfit
            // 
            TextTotalProfit.BackColor = Color.Transparent;
            TextTotalProfit.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextTotalProfit.Location = new Point(15, 194);
            TextTotalProfit.Margin = new Padding(4, 0, 4, 0);
            TextTotalProfit.Name = "TextTotalProfit";
            TextTotalProfit.Size = new Size(776, 36);
            TextTotalProfit.TabIndex = 43;
            TextTotalProfit.Text = "Select dates to see the total profit during that time.";
            TextTotalProfit.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TextTotalItemsSold
            // 
            TextTotalItemsSold.BackColor = Color.Transparent;
            TextTotalItemsSold.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextTotalItemsSold.Location = new Point(14, 122);
            TextTotalItemsSold.Margin = new Padding(4, 0, 4, 0);
            TextTotalItemsSold.Name = "TextTotalItemsSold";
            TextTotalItemsSold.Size = new Size(777, 36);
            TextTotalItemsSold.TabIndex = 44;
            TextTotalItemsSold.Text = "Select dates to see the amount of items sold during that time.";
            TextTotalItemsSold.TextAlign = ContentAlignment.BottomLeft;
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
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DatabaseGrid.DefaultCellStyle = dataGridViewCellStyle1;
            DatabaseGrid.EnableHeadersVisualStyles = false;
            DatabaseGrid.GridColor = Color.White;
            DatabaseGrid.Location = new Point(20, 330);
            DatabaseGrid.Margin = new Padding(4, 3, 4, 3);
            DatabaseGrid.Name = "DatabaseGrid";
            DatabaseGrid.RowHeadersVisible = false;
            DatabaseGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            DatabaseGrid.ShowCellErrors = false;
            DatabaseGrid.ShowCellToolTips = false;
            DatabaseGrid.ShowEditingIcon = false;
            DatabaseGrid.ShowRowErrors = false;
            DatabaseGrid.Size = new Size(1068, 365);
            DatabaseGrid.TabIndex = 45;
            // 
            // TextDataGrid
            // 
            TextDataGrid.BackColor = Color.Transparent;
            TextDataGrid.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextDataGrid.Location = new Point(15, 295);
            TextDataGrid.Margin = new Padding(4, 0, 4, 0);
            TextDataGrid.Name = "TextDataGrid";
            TextDataGrid.Size = new Size(433, 35);
            TextDataGrid.TabIndex = 46;
            TextDataGrid.Text = "Orders from the selected dates:";
            TextDataGrid.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ChartDailyRevenue
            // 
            ChartDailyRevenue.BackColor = Color.Transparent;
            ChartDailyRevenue.BorderlineColor = Color.Transparent;
            ChartDailyRevenue.BorderSkin.BackColor = Color.Transparent;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            ChartDailyRevenue.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.BackColor = Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChartDailyRevenue.Legends.Add(legend1);
            ChartDailyRevenue.Location = new Point(775, 72);
            ChartDailyRevenue.Margin = new Padding(4, 3, 4, 3);
            ChartDailyRevenue.Name = "ChartDailyRevenue";
            ChartDailyRevenue.Palette = ChartColorPalette.SeaGreen;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Color = Color.Transparent;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.EmptyPointStyle.BorderWidth = 5;
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.Font = new Font("Microsoft YaHei UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            series1.Legend = "Legend1";
            series1.Name = "Revenue Per Order";
            series1.Palette = ChartColorPalette.SeaGreen;
            ChartDailyRevenue.Series.Add(series1);
            ChartDailyRevenue.Size = new Size(471, 258);
            ChartDailyRevenue.TabIndex = 47;
            ChartDailyRevenue.TabStop = false;
            ChartDailyRevenue.Text = "ChartStockType";
            title1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title1.Name = "Title";
            title1.Text = "Profit Per Order (£)";
            ChartDailyRevenue.Titles.Add(title1);
            // 
            // TextDuringThisTime
            // 
            TextDuringThisTime.BackColor = Color.Transparent;
            TextDuringThisTime.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextDuringThisTime.Location = new Point(15, 88);
            TextDuringThisTime.Margin = new Padding(4, 0, 4, 0);
            TextDuringThisTime.Name = "TextDuringThisTime";
            TextDuringThisTime.Size = new Size(433, 35);
            TextDuringThisTime.TabIndex = 48;
            TextDuringThisTime.Text = "During this time:";
            TextDuringThisTime.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TextSelectDate
            // 
            TextSelectDate.BackColor = Color.Transparent;
            TextSelectDate.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextSelectDate.Location = new Point(15, 330);
            TextSelectDate.Margin = new Padding(4, 0, 4, 0);
            TextSelectDate.Name = "TextSelectDate";
            TextSelectDate.Size = new Size(777, 36);
            TextSelectDate.TabIndex = 49;
            TextSelectDate.Text = "Select dates to see all customer orders during that time.";
            TextSelectDate.TextAlign = ContentAlignment.BottomLeft;
            // 
            // FormViewInsights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1259, 708);
            Controls.Add(TextSelectDate);
            Controls.Add(TextDuringThisTime);
            Controls.Add(ChartDailyRevenue);
            Controls.Add(ToDate);
            Controls.Add(FromDate);
            Controls.Add(TextDataGrid);
            Controls.Add(DatabaseGrid);
            Controls.Add(TextTotalItemsSold);
            Controls.Add(TextTotalProfit);
            Controls.Add(CloseButton);
            Controls.Add(TextMostProfitableDay);
            Controls.Add(TextBestSeller);
            Controls.Add(WelcomeText);
            Controls.Add(ButtonInsight);
            Controls.Add(TextDates);
            Controls.Add(TextInsights);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormViewInsights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += FormViewInsights_Load;
            ((ISupportInitialize)DatabaseGrid).EndInit();
            ((ISupportInitialize)ChartDailyRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label WelcomeText;
        private MaterialSkin.Controls.MaterialButton CloseButton;
        private Label TextInsights;
        private DateTimePicker FromDate;
        private DateTimePicker ToDate;
        private Label TextDates;
        private MaterialSkin.Controls.MaterialButton ButtonInsight;
        private Label TextBestSeller;
        private Label TextMostProfitableDay;
        private Label TextTotalProfit;
        private Label TextTotalItemsSold;
        private DataGridView DatabaseGrid;
        private Label TextDataGrid;
        private Chart ChartDailyRevenue;
        private Label TextDuringThisTime;
        private Label TextSelectDate;
    }
}