namespace NEA
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.TextNotification1 = new System.Windows.Forms.Label();
            this.ButtonChangeNotifTime = new MaterialSkin.Controls.MaterialButton();
            this.TextSettings = new System.Windows.Forms.Label();
            this.ButtonClose = new MaterialSkin.Controls.MaterialButton();
            this.TextEmail = new System.Windows.Forms.Label();
            this.ButtonChangeEmail = new MaterialSkin.Controls.MaterialButton();
            this.InfoNotification = new System.Windows.Forms.Label();
            this.InfoEmail = new System.Windows.Forms.Label();
            this.UnusedButton = new MaterialSkin.Controls.MaterialButton();
            this.TextColour = new System.Windows.Forms.Label();
            this.InfoColour = new System.Windows.Forms.Label();
            this.ButtonChangeColour = new MaterialSkin.Controls.MaterialButton();
            this.ComboBoxColour = new MaterialSkin.Controls.MaterialComboBox();
            this.TextBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.ComboBoxTime = new MaterialSkin.Controls.MaterialComboBox();
            this.TextNotification2 = new System.Windows.Forms.Label();
            this.ButtonChangeNotifStock = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxStock = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonRestart = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TextNotification1
            // 
            this.TextNotification1.AutoSize = true;
            this.TextNotification1.BackColor = System.Drawing.Color.Transparent;
            this.TextNotification1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNotification1.Location = new System.Drawing.Point(3, 116);
            this.TextNotification1.Name = "TextNotification1";
            this.TextNotification1.Size = new System.Drawing.Size(168, 21);
            this.TextNotification1.TabIndex = 44;
            this.TextNotification1.Text = "Notification Time (s):";
            // 
            // ButtonChangeNotifTime
            // 
            this.ButtonChangeNotifTime.AutoSize = false;
            this.ButtonChangeNotifTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChangeNotifTime.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonChangeNotifTime.Depth = 0;
            this.ButtonChangeNotifTime.HighEmphasis = true;
            this.ButtonChangeNotifTime.Icon = null;
            this.ButtonChangeNotifTime.Location = new System.Drawing.Point(382, 88);
            this.ButtonChangeNotifTime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonChangeNotifTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChangeNotifTime.Name = "ButtonChangeNotifTime";
            this.ButtonChangeNotifTime.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonChangeNotifTime.Size = new System.Drawing.Size(69, 49);
            this.ButtonChangeNotifTime.TabIndex = 3;
            this.ButtonChangeNotifTime.Text = "Save";
            this.ButtonChangeNotifTime.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonChangeNotifTime.UseAccentColor = false;
            this.ButtonChangeNotifTime.UseVisualStyleBackColor = true;
            this.ButtonChangeNotifTime.Click += new System.EventHandler(this.ButtonChangeNotifTime_Click);
            // 
            // TextSettings
            // 
            this.TextSettings.BackColor = System.Drawing.Color.Transparent;
            this.TextSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSettings.Location = new System.Drawing.Point(7, 9);
            this.TextSettings.Name = "TextSettings";
            this.TextSettings.Size = new System.Drawing.Size(444, 73);
            this.TextSettings.TabIndex = 31;
            this.TextSettings.Text = "Settings";
            this.TextSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonClose
            // 
            this.ButtonClose.AutoSize = false;
            this.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClose.Depth = 0;
            this.ButtonClose.HighEmphasis = true;
            this.ButtonClose.Icon = null;
            this.ButtonClose.Location = new System.Drawing.Point(7, 525);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClose.Size = new System.Drawing.Size(444, 36);
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.Text = "Close Without Saving";
            this.ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClose.UseAccentColor = false;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextEmail
            // 
            this.TextEmail.AutoSize = true;
            this.TextEmail.BackColor = System.Drawing.Color.Transparent;
            this.TextEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEmail.Location = new System.Drawing.Point(3, 322);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(181, 21);
            this.TextEmail.TabIndex = 45;
            this.TextEmail.Text = "Receipt Email Address:";
            // 
            // ButtonChangeEmail
            // 
            this.ButtonChangeEmail.AutoSize = false;
            this.ButtonChangeEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChangeEmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonChangeEmail.Depth = 0;
            this.ButtonChangeEmail.HighEmphasis = true;
            this.ButtonChangeEmail.Icon = null;
            this.ButtonChangeEmail.Location = new System.Drawing.Point(382, 293);
            this.ButtonChangeEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonChangeEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChangeEmail.Name = "ButtonChangeEmail";
            this.ButtonChangeEmail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonChangeEmail.Size = new System.Drawing.Size(69, 50);
            this.ButtonChangeEmail.TabIndex = 7;
            this.ButtonChangeEmail.Text = "Save";
            this.ButtonChangeEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonChangeEmail.UseAccentColor = false;
            this.ButtonChangeEmail.UseVisualStyleBackColor = true;
            this.ButtonChangeEmail.Click += new System.EventHandler(this.ButtonChangeEmail_Click);
            // 
            // InfoNotification
            // 
            this.InfoNotification.BackColor = System.Drawing.Color.Transparent;
            this.InfoNotification.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNotification.Location = new System.Drawing.Point(18, 143);
            this.InfoNotification.Name = "InfoNotification";
            this.InfoNotification.Size = new System.Drawing.Size(433, 30);
            this.InfoNotification.TabIndex = 48;
            this.InfoNotification.Text = "the amount of time it takes to display a notification";
            this.InfoNotification.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InfoEmail
            // 
            this.InfoEmail.BackColor = System.Drawing.Color.Transparent;
            this.InfoEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEmail.Location = new System.Drawing.Point(19, 349);
            this.InfoEmail.Name = "InfoEmail";
            this.InfoEmail.Size = new System.Drawing.Size(433, 41);
            this.InfoEmail.TabIndex = 49;
            this.InfoEmail.Text = "this address will receive Database receipts by email";
            this.InfoEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UnusedButton
            // 
            this.UnusedButton.AutoSize = false;
            this.UnusedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnusedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UnusedButton.Depth = 0;
            this.UnusedButton.HighEmphasis = true;
            this.UnusedButton.Icon = null;
            this.UnusedButton.Location = new System.Drawing.Point(308, 532);
            this.UnusedButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnusedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnusedButton.Name = "UnusedButton";
            this.UnusedButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UnusedButton.Size = new System.Drawing.Size(107, 20);
            this.UnusedButton.TabIndex = 1;
            this.UnusedButton.Text = "Change";
            this.UnusedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UnusedButton.UseAccentColor = false;
            this.UnusedButton.UseVisualStyleBackColor = true;
            // 
            // TextColour
            // 
            this.TextColour.AutoSize = true;
            this.TextColour.BackColor = System.Drawing.Color.Transparent;
            this.TextColour.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextColour.Location = new System.Drawing.Point(3, 418);
            this.TextColour.Name = "TextColour";
            this.TextColour.Size = new System.Drawing.Size(130, 21);
            this.TextColour.TabIndex = 50;
            this.TextColour.Text = "Colour Scheme:";
            // 
            // InfoColour
            // 
            this.InfoColour.BackColor = System.Drawing.Color.Transparent;
            this.InfoColour.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoColour.Location = new System.Drawing.Point(7, 445);
            this.InfoColour.Name = "InfoColour";
            this.InfoColour.Size = new System.Drawing.Size(445, 33);
            this.InfoColour.TabIndex = 51;
            this.InfoColour.Text = "the general colour scheme of the application";
            this.InfoColour.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ButtonChangeColour
            // 
            this.ButtonChangeColour.AutoSize = false;
            this.ButtonChangeColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChangeColour.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonChangeColour.Depth = 0;
            this.ButtonChangeColour.HighEmphasis = true;
            this.ButtonChangeColour.Icon = null;
            this.ButtonChangeColour.Location = new System.Drawing.Point(382, 390);
            this.ButtonChangeColour.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonChangeColour.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChangeColour.Name = "ButtonChangeColour";
            this.ButtonChangeColour.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonChangeColour.Size = new System.Drawing.Size(69, 49);
            this.ButtonChangeColour.TabIndex = 9;
            this.ButtonChangeColour.Text = "Save";
            this.ButtonChangeColour.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonChangeColour.UseAccentColor = false;
            this.ButtonChangeColour.UseVisualStyleBackColor = true;
            this.ButtonChangeColour.Click += new System.EventHandler(this.ButtonChangeColour_Click);
            // 
            // ComboBoxColour
            // 
            this.ComboBoxColour.AutoResize = false;
            this.ComboBoxColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxColour.Depth = 0;
            this.ComboBoxColour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxColour.DropDownHeight = 217;
            this.ComboBoxColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxColour.DropDownWidth = 121;
            this.ComboBoxColour.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxColour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxColour.FormattingEnabled = true;
            this.ComboBoxColour.IntegralHeight = false;
            this.ComboBoxColour.ItemHeight = 43;
            this.ComboBoxColour.Location = new System.Drawing.Point(190, 390);
            this.ComboBoxColour.MaxDropDownItems = 5;
            this.ComboBoxColour.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxColour.Name = "ComboBoxColour";
            this.ComboBoxColour.Size = new System.Drawing.Size(185, 49);
            this.ComboBoxColour.StartIndex = 0;
            this.ComboBoxColour.TabIndex = 8;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.AnimateReadOnly = false;
            this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmail.Depth = 0;
            this.TextBoxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxEmail.LeadingIcon = null;
            this.TextBoxEmail.Location = new System.Drawing.Point(190, 293);
            this.TextBoxEmail.MaxLength = 50;
            this.TextBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxEmail.Multiline = false;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(185, 50);
            this.TextBoxEmail.TabIndex = 6;
            this.TextBoxEmail.Text = "";
            this.TextBoxEmail.TrailingIcon = null;
            // 
            // ComboBoxTime
            // 
            this.ComboBoxTime.AutoResize = false;
            this.ComboBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxTime.Depth = 0;
            this.ComboBoxTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxTime.DropDownHeight = 174;
            this.ComboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTime.DropDownWidth = 121;
            this.ComboBoxTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxTime.FormattingEnabled = true;
            this.ComboBoxTime.IntegralHeight = false;
            this.ComboBoxTime.ItemHeight = 43;
            this.ComboBoxTime.Location = new System.Drawing.Point(190, 88);
            this.ComboBoxTime.MaxDropDownItems = 4;
            this.ComboBoxTime.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxTime.Name = "ComboBoxTime";
            this.ComboBoxTime.Size = new System.Drawing.Size(185, 49);
            this.ComboBoxTime.StartIndex = 0;
            this.ComboBoxTime.TabIndex = 2;
            // 
            // TextNotification2
            // 
            this.TextNotification2.AutoSize = true;
            this.TextNotification2.BackColor = System.Drawing.Color.Transparent;
            this.TextNotification2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNotification2.Location = new System.Drawing.Point(3, 223);
            this.TextNotification2.Name = "TextNotification2";
            this.TextNotification2.Size = new System.Drawing.Size(151, 21);
            this.TextNotification2.TabIndex = 56;
            this.TextNotification2.Text = "Notification Stock:";
            // 
            // ButtonChangeNotifStock
            // 
            this.ButtonChangeNotifStock.AutoSize = false;
            this.ButtonChangeNotifStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChangeNotifStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonChangeNotifStock.Depth = 0;
            this.ButtonChangeNotifStock.HighEmphasis = true;
            this.ButtonChangeNotifStock.Icon = null;
            this.ButtonChangeNotifStock.Location = new System.Drawing.Point(382, 195);
            this.ButtonChangeNotifStock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonChangeNotifStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChangeNotifStock.Name = "ButtonChangeNotifStock";
            this.ButtonChangeNotifStock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonChangeNotifStock.Size = new System.Drawing.Size(69, 49);
            this.ButtonChangeNotifStock.TabIndex = 5;
            this.ButtonChangeNotifStock.Text = "Save";
            this.ButtonChangeNotifStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonChangeNotifStock.UseAccentColor = false;
            this.ButtonChangeNotifStock.UseVisualStyleBackColor = true;
            this.ButtonChangeNotifStock.Click += new System.EventHandler(this.ButtonChangeNotifStock_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "the amount of stock that triggers a \'Low Stock\' warning";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ComboBoxStock
            // 
            this.ComboBoxStock.AutoResize = false;
            this.ComboBoxStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxStock.Depth = 0;
            this.ComboBoxStock.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxStock.DropDownHeight = 432;
            this.ComboBoxStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStock.DropDownWidth = 121;
            this.ComboBoxStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxStock.FormattingEnabled = true;
            this.ComboBoxStock.IntegralHeight = false;
            this.ComboBoxStock.ItemHeight = 43;
            this.ComboBoxStock.Location = new System.Drawing.Point(190, 195);
            this.ComboBoxStock.MaxDropDownItems = 10;
            this.ComboBoxStock.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxStock.Name = "ComboBoxStock";
            this.ComboBoxStock.Size = new System.Drawing.Size(185, 49);
            this.ComboBoxStock.StartIndex = 0;
            this.ComboBoxStock.TabIndex = 4;
            // 
            // ButtonRestart
            // 
            this.ButtonRestart.AutoSize = false;
            this.ButtonRestart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRestart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonRestart.Depth = 0;
            this.ButtonRestart.HighEmphasis = true;
            this.ButtonRestart.Icon = null;
            this.ButtonRestart.Location = new System.Drawing.Point(7, 477);
            this.ButtonRestart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonRestart.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonRestart.Name = "ButtonRestart";
            this.ButtonRestart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonRestart.Size = new System.Drawing.Size(444, 36);
            this.ButtonRestart.TabIndex = 10;
            this.ButtonRestart.Text = "Restart Application";
            this.ButtonRestart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonRestart.UseAccentColor = false;
            this.ButtonRestart.UseVisualStyleBackColor = true;
            this.ButtonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 570);
            this.Controls.Add(this.ButtonRestart);
            this.Controls.Add(this.ComboBoxStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonChangeNotifStock);
            this.Controls.Add(this.TextNotification2);
            this.Controls.Add(this.ComboBoxTime);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.ComboBoxColour);
            this.Controls.Add(this.ButtonChangeColour);
            this.Controls.Add(this.InfoColour);
            this.Controls.Add(this.TextColour);
            this.Controls.Add(this.InfoEmail);
            this.Controls.Add(this.InfoNotification);
            this.Controls.Add(this.ButtonChangeEmail);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextNotification1);
            this.Controls.Add(this.ButtonChangeNotifTime);
            this.Controls.Add(this.TextSettings);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.UnusedButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextNotification1;
        private MaterialSkin.Controls.MaterialButton ButtonChangeNotifTime;
        private System.Windows.Forms.Label TextSettings;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private System.Windows.Forms.Label TextEmail;
        private MaterialSkin.Controls.MaterialButton ButtonChangeEmail;
        private System.Windows.Forms.Label InfoNotification;
        private System.Windows.Forms.Label InfoEmail;
        private MaterialSkin.Controls.MaterialButton UnusedButton;
        private System.Windows.Forms.Label TextColour;
        private System.Windows.Forms.Label InfoColour;
        private MaterialSkin.Controls.MaterialButton ButtonChangeColour;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxColour;
        private MaterialSkin.Controls.MaterialTextBox TextBoxEmail;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxTime;
        private System.Windows.Forms.Label TextNotification2;
        private MaterialSkin.Controls.MaterialButton ButtonChangeNotifStock;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxStock;
        private MaterialSkin.Controls.MaterialButton ButtonRestart;
    }
}