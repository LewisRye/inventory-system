namespace NEA
{
    partial class FormViewInsights
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewInsights));
            this.CloseButton = new MaterialSkin.Controls.MaterialButton();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.TextInsights = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.TextDates = new System.Windows.Forms.Label();
            this.ButtonInsight = new MaterialSkin.Controls.MaterialButton();
            this.TextBestSeller = new System.Windows.Forms.Label();
            this.TextMostProfitableDay = new System.Windows.Forms.Label();
            this.TextTotalProfit = new System.Windows.Forms.Label();
            this.TextTotalItemsSold = new System.Windows.Forms.Label();
            this.DatabaseGrid = new System.Windows.Forms.DataGridView();
            this.TextDataGrid = new System.Windows.Forms.Label();
            this.ChartDailyRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextDuringThisTime = new System.Windows.Forms.Label();
            this.TextSelectDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDailyRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CloseButton.AutoSize = false;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CloseButton.Depth = 0;
            this.CloseButton.HighEmphasis = true;
            this.CloseButton.Icon = null;
            this.CloseButton.Location = new System.Drawing.Point(946, 553);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CloseButton.Size = new System.Drawing.Size(122, 49);
            this.CloseButton.TabIndex = 28;
            this.CloseButton.Text = "Dashboard";
            this.CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseButton.UseAccentColor = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeText.ForeColor = System.Drawing.Color.Black;
            this.WelcomeText.Location = new System.Drawing.Point(681, 9);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(387, 40);
            this.WelcomeText.TabIndex = 26;
            this.WelcomeText.Text = "welcome, (blank)!";
            this.WelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextInsights
            // 
            this.TextInsights.BackColor = System.Drawing.Color.Transparent;
            this.TextInsights.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInsights.Location = new System.Drawing.Point(12, 9);
            this.TextInsights.Name = "TextInsights";
            this.TextInsights.Size = new System.Drawing.Size(260, 40);
            this.TextInsights.TabIndex = 35;
            this.TextInsights.Text = "Insights";
            this.TextInsights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd/MM/yyyy";
            this.FromDate.Location = new System.Drawing.Point(250, 20);
            this.FromDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(133, 20);
            this.FromDate.TabIndex = 36;
            this.FromDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd/MM/yyyy";
            this.ToDate.Location = new System.Drawing.Point(428, 20);
            this.ToDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.ToDate.MinDate = new System.DateTime(2020, 1, 2, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(133, 20);
            this.ToDate.TabIndex = 37;
            this.ToDate.Value = new System.DateTime(2022, 4, 12, 0, 0, 0, 0);
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // TextDates
            // 
            this.TextDates.BackColor = System.Drawing.Color.Transparent;
            this.TextDates.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDates.Location = new System.Drawing.Point(118, 13);
            this.TextDates.Name = "TextDates";
            this.TextDates.Size = new System.Drawing.Size(371, 30);
            this.TextDates.TabIndex = 38;
            this.TextDates.Text = "Get data from:                               to:";
            this.TextDates.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ButtonInsight
            // 
            this.ButtonInsight.AutoSize = false;
            this.ButtonInsight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonInsight.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonInsight.Depth = 0;
            this.ButtonInsight.HighEmphasis = true;
            this.ButtonInsight.Icon = null;
            this.ButtonInsight.Location = new System.Drawing.Point(568, 20);
            this.ButtonInsight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonInsight.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonInsight.Name = "ButtonInsight";
            this.ButtonInsight.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonInsight.Size = new System.Drawing.Size(107, 20);
            this.ButtonInsight.TabIndex = 40;
            this.ButtonInsight.Text = "Get Insights";
            this.ButtonInsight.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonInsight.UseAccentColor = false;
            this.ButtonInsight.UseVisualStyleBackColor = true;
            this.ButtonInsight.Click += new System.EventHandler(this.ButtonInsight_Click);
            // 
            // TextBestSeller
            // 
            this.TextBestSeller.BackColor = System.Drawing.Color.Transparent;
            this.TextBestSeller.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBestSeller.Location = new System.Drawing.Point(13, 199);
            this.TextBestSeller.Name = "TextBestSeller";
            this.TextBestSeller.Size = new System.Drawing.Size(665, 31);
            this.TextBestSeller.TabIndex = 41;
            this.TextBestSeller.Text = "Select dates to see the best selling item during that time.";
            this.TextBestSeller.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextMostProfitableDay
            // 
            this.TextMostProfitableDay.BackColor = System.Drawing.Color.Transparent;
            this.TextMostProfitableDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMostProfitableDay.Location = new System.Drawing.Point(13, 137);
            this.TextMostProfitableDay.Name = "TextMostProfitableDay";
            this.TextMostProfitableDay.Size = new System.Drawing.Size(665, 31);
            this.TextMostProfitableDay.TabIndex = 42;
            this.TextMostProfitableDay.Text = "Select dates to see the most profitable day during that time.";
            this.TextMostProfitableDay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextTotalProfit
            // 
            this.TextTotalProfit.BackColor = System.Drawing.Color.Transparent;
            this.TextTotalProfit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTotalProfit.Location = new System.Drawing.Point(13, 168);
            this.TextTotalProfit.Name = "TextTotalProfit";
            this.TextTotalProfit.Size = new System.Drawing.Size(665, 31);
            this.TextTotalProfit.TabIndex = 43;
            this.TextTotalProfit.Text = "Select dates to see the total profit during that time.";
            this.TextTotalProfit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextTotalItemsSold
            // 
            this.TextTotalItemsSold.BackColor = System.Drawing.Color.Transparent;
            this.TextTotalItemsSold.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTotalItemsSold.Location = new System.Drawing.Point(12, 106);
            this.TextTotalItemsSold.Name = "TextTotalItemsSold";
            this.TextTotalItemsSold.Size = new System.Drawing.Size(666, 31);
            this.TextTotalItemsSold.TabIndex = 44;
            this.TextTotalItemsSold.Text = "Select dates to see the amount of items sold during that time.";
            this.TextTotalItemsSold.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            this.DatabaseGrid.Location = new System.Drawing.Point(17, 286);
            this.DatabaseGrid.Name = "DatabaseGrid";
            this.DatabaseGrid.RowHeadersVisible = false;
            this.DatabaseGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseGrid.ShowCellErrors = false;
            this.DatabaseGrid.ShowCellToolTips = false;
            this.DatabaseGrid.ShowEditingIcon = false;
            this.DatabaseGrid.ShowRowErrors = false;
            this.DatabaseGrid.Size = new System.Drawing.Size(915, 316);
            this.DatabaseGrid.TabIndex = 45;
            // 
            // TextDataGrid
            // 
            this.TextDataGrid.BackColor = System.Drawing.Color.Transparent;
            this.TextDataGrid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDataGrid.Location = new System.Drawing.Point(13, 256);
            this.TextDataGrid.Name = "TextDataGrid";
            this.TextDataGrid.Size = new System.Drawing.Size(371, 30);
            this.TextDataGrid.TabIndex = 46;
            this.TextDataGrid.Text = "Orders from the selected dates:";
            this.TextDataGrid.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ChartDailyRevenue
            // 
            this.ChartDailyRevenue.BackColor = System.Drawing.Color.Transparent;
            this.ChartDailyRevenue.BorderlineColor = System.Drawing.Color.Transparent;
            this.ChartDailyRevenue.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartDailyRevenue.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartDailyRevenue.Legends.Add(legend1);
            this.ChartDailyRevenue.Location = new System.Drawing.Point(664, 62);
            this.ChartDailyRevenue.Name = "ChartDailyRevenue";
            this.ChartDailyRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Transparent;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.EmptyPointStyle.BorderWidth = 5;
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Revenue Per Order";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.ChartDailyRevenue.Series.Add(series1);
            this.ChartDailyRevenue.Size = new System.Drawing.Size(404, 224);
            this.ChartDailyRevenue.TabIndex = 47;
            this.ChartDailyRevenue.TabStop = false;
            this.ChartDailyRevenue.Text = "ChartStockType";
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "Profit Per Order (£)";
            this.ChartDailyRevenue.Titles.Add(title1);
            // 
            // TextDuringThisTime
            // 
            this.TextDuringThisTime.BackColor = System.Drawing.Color.Transparent;
            this.TextDuringThisTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDuringThisTime.Location = new System.Drawing.Point(13, 76);
            this.TextDuringThisTime.Name = "TextDuringThisTime";
            this.TextDuringThisTime.Size = new System.Drawing.Size(371, 30);
            this.TextDuringThisTime.TabIndex = 48;
            this.TextDuringThisTime.Text = "During this time:";
            this.TextDuringThisTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextSelectDate
            // 
            this.TextSelectDate.BackColor = System.Drawing.Color.Transparent;
            this.TextSelectDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSelectDate.Location = new System.Drawing.Point(13, 286);
            this.TextSelectDate.Name = "TextSelectDate";
            this.TextSelectDate.Size = new System.Drawing.Size(666, 31);
            this.TextSelectDate.TabIndex = 49;
            this.TextSelectDate.Text = "Select dates to see all customer orders during that time.";
            this.TextSelectDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormViewInsights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 614);
            this.Controls.Add(this.TextSelectDate);
            this.Controls.Add(this.TextDuringThisTime);
            this.Controls.Add(this.ChartDailyRevenue);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.TextDataGrid);
            this.Controls.Add(this.DatabaseGrid);
            this.Controls.Add(this.TextTotalItemsSold);
            this.Controls.Add(this.TextTotalProfit);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TextMostProfitableDay);
            this.Controls.Add(this.TextBestSeller);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.ButtonInsight);
            this.Controls.Add(this.TextDates);
            this.Controls.Add(this.TextInsights);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormViewInsights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.ViewInsightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDailyRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WelcomeText;
        private MaterialSkin.Controls.MaterialButton CloseButton;
        private System.Windows.Forms.Label TextInsights;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label TextDates;
        private MaterialSkin.Controls.MaterialButton ButtonInsight;
        private System.Windows.Forms.Label TextBestSeller;
        private System.Windows.Forms.Label TextMostProfitableDay;
        private System.Windows.Forms.Label TextTotalProfit;
        private System.Windows.Forms.Label TextTotalItemsSold;
        private System.Windows.Forms.DataGridView DatabaseGrid;
        private System.Windows.Forms.Label TextDataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDailyRevenue;
        private System.Windows.Forms.Label TextDuringThisTime;
        private System.Windows.Forms.Label TextSelectDate;
    }
}