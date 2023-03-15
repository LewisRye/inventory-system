namespace Inventory.DataForms
{
    partial class FormViewOrders
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormViewOrders));
            DatabaseGrid = new DataGridView();
            LeftPanel = new Panel();
            WelcomeText = new Label();
            ButtonClose = new MaterialSkin.Controls.MaterialButton();
            ((ISupportInitialize)DatabaseGrid).BeginInit();
            LeftPanel.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DatabaseGrid.DefaultCellStyle = dataGridViewCellStyle1;
            DatabaseGrid.EnableHeadersVisualStyles = false;
            DatabaseGrid.GridColor = Color.White;
            DatabaseGrid.Location = new Point(228, 75);
            DatabaseGrid.Margin = new Padding(4, 3, 4, 3);
            DatabaseGrid.Name = "DatabaseGrid";
            DatabaseGrid.RowHeadersVisible = false;
            DatabaseGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            DatabaseGrid.ShowCellErrors = false;
            DatabaseGrid.ShowCellToolTips = false;
            DatabaseGrid.ShowEditingIcon = false;
            DatabaseGrid.ShowRowErrors = false;
            DatabaseGrid.Size = new Size(814, 512);
            DatabaseGrid.TabIndex = 30;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.Transparent;
            LeftPanel.Controls.Add(WelcomeText);
            LeftPanel.Controls.Add(ButtonClose);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(221, 599);
            LeftPanel.TabIndex = 31;
            // 
            // WelcomeText
            // 
            WelcomeText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeText.Location = new Point(0, 0);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(221, 38);
            WelcomeText.TabIndex = 8;
            WelcomeText.Text = "welcome, {username}!";
            WelcomeText.TextAlign = ContentAlignment.MiddleCenter;
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
            ButtonClose.Location = new Point(4, 544);
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
            // FormViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 599);
            Controls.Add(LeftPanel);
            Controls.Add(DatabaseGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += ViewOrdersForm_Load;
            ((ISupportInitialize)DatabaseGrid).EndInit();
            LeftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView DatabaseGrid;
        private Panel LeftPanel;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private Label WelcomeText;
    }
}