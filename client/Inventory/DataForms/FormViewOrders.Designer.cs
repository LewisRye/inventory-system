﻿namespace Inventory.DataForms
{
    partial class FormViewOrders
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormViewOrders));
            DatabaseGrid = new DataGridView();
            ButtonClose = new MaterialSkin.Controls.MaterialButton();
            WelcomeText = new Label();
            ButtonReset = new MaterialSkin.Controls.MaterialButton();
            SearchBox = new TextBox();
            TextSearch = new Label();
            ButtonSearch = new MaterialSkin.Controls.MaterialButton();
            ((ISupportInitialize)DatabaseGrid).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DatabaseGrid.DefaultCellStyle = dataGridViewCellStyle1;
            DatabaseGrid.EnableHeadersVisualStyles = false;
            DatabaseGrid.GridColor = Color.White;
            DatabaseGrid.Location = new Point(13, 63);
            DatabaseGrid.Margin = new Padding(4, 3, 4, 3);
            DatabaseGrid.Name = "DatabaseGrid";
            DatabaseGrid.ReadOnly = true;
            DatabaseGrid.RowHeadersVisible = false;
            DatabaseGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            DatabaseGrid.ShowCellErrors = false;
            DatabaseGrid.ShowCellToolTips = false;
            DatabaseGrid.ShowEditingIcon = false;
            DatabaseGrid.ShowRowErrors = false;
            DatabaseGrid.Size = new Size(1029, 463);
            DatabaseGrid.TabIndex = 30;
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
            ButtonClose.Location = new Point(13, 535);
            ButtonClose.Margin = new Padding(4, 6, 4, 6);
            ButtonClose.MouseState = MouseState.HOVER;
            ButtonClose.Name = "ButtonClose";
            ButtonClose.NoAccentTextColor = Color.Empty;
            ButtonClose.Size = new Size(1029, 49);
            ButtonClose.TabIndex = 6;
            ButtonClose.Text = "Dashboard";
            ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClose.UseAccentColor = false;
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // WelcomeText
            // 
            WelcomeText.Font = new Font("Segoe UI", 15.75F);
            WelcomeText.Location = new Point(1, 9);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(221, 38);
            WelcomeText.TabIndex = 8;
            WelcomeText.Text = "welcome, {username}!";
            WelcomeText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonReset
            // 
            ButtonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonReset.AutoSize = false;
            ButtonReset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonReset.Depth = 0;
            ButtonReset.Font = new Font("Segoe UI", 8.25F);
            ButtonReset.HighEmphasis = true;
            ButtonReset.Icon = null;
            ButtonReset.Location = new Point(949, 22);
            ButtonReset.Margin = new Padding(4, 6, 4, 6);
            ButtonReset.MouseState = MouseState.HOVER;
            ButtonReset.Name = "ButtonReset";
            ButtonReset.NoAccentTextColor = Color.Empty;
            ButtonReset.Size = new Size(93, 23);
            ButtonReset.TabIndex = 35;
            ButtonReset.Text = "Reset";
            ButtonReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonReset.UseAccentColor = false;
            ButtonReset.UseVisualStyleBackColor = false;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SearchBox.Location = new Point(471, 22);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(370, 23);
            SearchBox.TabIndex = 34;
            // 
            // TextSearch
            // 
            TextSearch.AutoSize = true;
            TextSearch.BackColor = Color.Transparent;
            TextSearch.Font = new Font("Segoe UI", 9.75F);
            TextSearch.Location = new Point(232, 21);
            TextSearch.Name = "TextSearch";
            TextSearch.Size = new Size(233, 17);
            TextSearch.TabIndex = 33;
            TextSearch.Text = "Search by Customer Name or Product:";
            TextSearch.TextAlign = ContentAlignment.MiddleLeft;
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
            ButtonSearch.Location = new Point(848, 22);
            ButtonSearch.Margin = new Padding(4, 6, 4, 6);
            ButtonSearch.MouseState = MouseState.HOVER;
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.NoAccentTextColor = Color.Empty;
            ButtonSearch.Size = new Size(93, 23);
            ButtonSearch.TabIndex = 36;
            ButtonSearch.Text = "Search";
            ButtonSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSearch.UseAccentColor = false;
            ButtonSearch.UseVisualStyleBackColor = false;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // FormViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 599);
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonReset);
            Controls.Add(SearchBox);
            Controls.Add(TextSearch);
            Controls.Add(ButtonClose);
            Controls.Add(WelcomeText);
            Controls.Add(DatabaseGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += ViewOrdersForm_Load;
            ((ISupportInitialize)DatabaseGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DatabaseGrid;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private Label WelcomeText;
        private MaterialSkin.Controls.MaterialButton ButtonReset;
        private TextBox SearchBox;
        private Label TextSearch;
        private MaterialSkin.Controls.MaterialButton ButtonSearch;
    }
}