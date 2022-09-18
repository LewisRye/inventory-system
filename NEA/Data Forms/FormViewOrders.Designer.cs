namespace NEA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewOrders));
            this.CloseButton = new MaterialSkin.Controls.MaterialButton();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.DatabaseGrid = new System.Windows.Forms.DataGridView();
            this.BluePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = false;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CloseButton.Depth = 0;
            this.CloseButton.HighEmphasis = true;
            this.CloseButton.Icon = null;
            this.CloseButton.Location = new System.Drawing.Point(744, 561);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CloseButton.Size = new System.Drawing.Size(155, 47);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "Close";
            this.CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseButton.UseAccentColor = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.Color.Transparent;
            this.BluePanel.Controls.Add(this.WelcomeText);
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BluePanel.Location = new System.Drawing.Point(0, 0);
            this.BluePanel.Margin = new System.Windows.Forms.Padding(2);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(905, 60);
            this.BluePanel.TabIndex = 18;
            // 
            // WelcomeText
            // 
            this.WelcomeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.WelcomeText.ForeColor = System.Drawing.Color.Black;
            this.WelcomeText.Location = new System.Drawing.Point(2, 15);
            this.WelcomeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(260, 30);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = "welcome, (username)!";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(189, 575);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(549, 20);
            this.SearchBox.TabIndex = 17;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.SearchLabel.Location = new System.Drawing.Point(6, 574);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(167, 19);
            this.SearchLabel.TabIndex = 21;
            this.SearchLabel.Text = "Search by Product Name:\r\n";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DatabaseGrid.Location = new System.Drawing.Point(7, 65);
            this.DatabaseGrid.Name = "DatabaseGrid";
            this.DatabaseGrid.RowHeadersVisible = false;
            this.DatabaseGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseGrid.ShowCellErrors = false;
            this.DatabaseGrid.ShowCellToolTips = false;
            this.DatabaseGrid.ShowEditingIcon = false;
            this.DatabaseGrid.ShowRowErrors = false;
            this.DatabaseGrid.Size = new System.Drawing.Size(886, 488);
            this.DatabaseGrid.TabIndex = 30;
            // 
            // FormViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 614);
            this.Controls.Add(this.DatabaseGrid);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BluePanel);
            this.Controls.Add(this.SearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.ViewOrdersForm_Load);
            this.BluePanel.ResumeLayout(false);
            this.BluePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton CloseButton;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridView DatabaseGrid;
    }
}