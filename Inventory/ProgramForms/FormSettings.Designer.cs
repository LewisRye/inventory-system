namespace Inventory.ProgramForms
{
    partial class FormSettings
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSettings));
            TextNotification1 = new Label();
            ButtonChangeNotifTime = new MaterialSkin.Controls.MaterialButton();
            TextSettings = new Label();
            ButtonClose = new MaterialSkin.Controls.MaterialButton();
            TextEmail = new Label();
            ButtonChangeEmail = new MaterialSkin.Controls.MaterialButton();
            InfoNotification = new Label();
            InfoEmail = new Label();
            UnusedButton = new MaterialSkin.Controls.MaterialButton();
            TextColour = new Label();
            InfoColour = new Label();
            ButtonChangeColour = new MaterialSkin.Controls.MaterialButton();
            ComboBoxColour = new MaterialSkin.Controls.MaterialComboBox();
            TextBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            ComboBoxTime = new MaterialSkin.Controls.MaterialComboBox();
            TextNotification2 = new Label();
            ButtonChangeNotifStock = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            ComboBoxStock = new MaterialSkin.Controls.MaterialComboBox();
            ButtonRestart = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // TextNotification1
            // 
            TextNotification1.AutoSize = true;
            TextNotification1.BackColor = Color.Transparent;
            TextNotification1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNotification1.Location = new Point(4, 134);
            TextNotification1.Margin = new Padding(4, 0, 4, 0);
            TextNotification1.Name = "TextNotification1";
            TextNotification1.Size = new Size(168, 21);
            TextNotification1.TabIndex = 44;
            TextNotification1.Text = "Notification Time (s):";
            // 
            // ButtonChangeNotifTime
            // 
            ButtonChangeNotifTime.AutoSize = false;
            ButtonChangeNotifTime.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonChangeNotifTime.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonChangeNotifTime.Depth = 0;
            ButtonChangeNotifTime.HighEmphasis = true;
            ButtonChangeNotifTime.Icon = null;
            ButtonChangeNotifTime.Location = new Point(446, 106);
            ButtonChangeNotifTime.Margin = new Padding(5, 7, 5, 7);
            ButtonChangeNotifTime.MouseState = MouseState.HOVER;
            ButtonChangeNotifTime.Name = "ButtonChangeNotifTime";
            ButtonChangeNotifTime.NoAccentTextColor = Color.Empty;
            ButtonChangeNotifTime.Size = new Size(80, 49);
            ButtonChangeNotifTime.TabIndex = 3;
            ButtonChangeNotifTime.Text = "Save";
            ButtonChangeNotifTime.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonChangeNotifTime.UseAccentColor = false;
            ButtonChangeNotifTime.UseVisualStyleBackColor = true;
            ButtonChangeNotifTime.Click += ButtonChangeNotifTime_Click;
            // 
            // TextSettings
            // 
            TextSettings.BackColor = Color.Transparent;
            TextSettings.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            TextSettings.Location = new Point(8, 10);
            TextSettings.Margin = new Padding(4, 0, 4, 0);
            TextSettings.Name = "TextSettings";
            TextSettings.Size = new Size(518, 84);
            TextSettings.TabIndex = 31;
            TextSettings.Text = "Settings";
            TextSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonClose
            // 
            ButtonClose.AutoSize = false;
            ButtonClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonClose.Depth = 0;
            ButtonClose.HighEmphasis = true;
            ButtonClose.Icon = null;
            ButtonClose.Location = new Point(8, 606);
            ButtonClose.Margin = new Padding(5, 7, 5, 7);
            ButtonClose.MouseState = MouseState.HOVER;
            ButtonClose.Name = "ButtonClose";
            ButtonClose.NoAccentTextColor = Color.Empty;
            ButtonClose.Size = new Size(518, 42);
            ButtonClose.TabIndex = 11;
            ButtonClose.Text = "Reload Later";
            ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClose.UseAccentColor = false;
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // TextEmail
            // 
            TextEmail.AutoSize = true;
            TextEmail.BackColor = Color.Transparent;
            TextEmail.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.Location = new Point(4, 372);
            TextEmail.Margin = new Padding(4, 0, 4, 0);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(181, 21);
            TextEmail.TabIndex = 45;
            TextEmail.Text = "Receipt Email Address:";
            // 
            // ButtonChangeEmail
            // 
            ButtonChangeEmail.AutoSize = false;
            ButtonChangeEmail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonChangeEmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonChangeEmail.Depth = 0;
            ButtonChangeEmail.HighEmphasis = true;
            ButtonChangeEmail.Icon = null;
            ButtonChangeEmail.Location = new Point(446, 343);
            ButtonChangeEmail.Margin = new Padding(5, 7, 5, 7);
            ButtonChangeEmail.MouseState = MouseState.HOVER;
            ButtonChangeEmail.Name = "ButtonChangeEmail";
            ButtonChangeEmail.NoAccentTextColor = Color.Empty;
            ButtonChangeEmail.Size = new Size(80, 50);
            ButtonChangeEmail.TabIndex = 7;
            ButtonChangeEmail.Text = "Save";
            ButtonChangeEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonChangeEmail.UseAccentColor = false;
            ButtonChangeEmail.UseVisualStyleBackColor = true;
            ButtonChangeEmail.Click += ButtonChangeEmail_Click;
            // 
            // InfoNotification
            // 
            InfoNotification.BackColor = Color.Transparent;
            InfoNotification.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            InfoNotification.Location = new Point(21, 165);
            InfoNotification.Margin = new Padding(4, 0, 4, 0);
            InfoNotification.Name = "InfoNotification";
            InfoNotification.Size = new Size(505, 35);
            InfoNotification.TabIndex = 48;
            InfoNotification.Text = "the amount of time it takes to display a notification";
            InfoNotification.TextAlign = ContentAlignment.TopRight;
            // 
            // InfoEmail
            // 
            InfoEmail.BackColor = Color.Transparent;
            InfoEmail.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            InfoEmail.Location = new Point(22, 403);
            InfoEmail.Margin = new Padding(4, 0, 4, 0);
            InfoEmail.Name = "InfoEmail";
            InfoEmail.Size = new Size(505, 47);
            InfoEmail.TabIndex = 49;
            InfoEmail.Text = "this address will receive Database receipts by email";
            InfoEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // UnusedButton
            // 
            UnusedButton.AutoSize = false;
            UnusedButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UnusedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            UnusedButton.Depth = 0;
            UnusedButton.HighEmphasis = true;
            UnusedButton.Icon = null;
            UnusedButton.Location = new Point(359, 614);
            UnusedButton.Margin = new Padding(5, 7, 5, 7);
            UnusedButton.MouseState = MouseState.HOVER;
            UnusedButton.Name = "UnusedButton";
            UnusedButton.NoAccentTextColor = Color.Empty;
            UnusedButton.Size = new Size(125, 23);
            UnusedButton.TabIndex = 1;
            UnusedButton.Text = "Change";
            UnusedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            UnusedButton.UseAccentColor = false;
            UnusedButton.UseVisualStyleBackColor = true;
            // 
            // TextColour
            // 
            TextColour.AutoSize = true;
            TextColour.BackColor = Color.Transparent;
            TextColour.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextColour.Location = new Point(4, 482);
            TextColour.Margin = new Padding(4, 0, 4, 0);
            TextColour.Name = "TextColour";
            TextColour.Size = new Size(130, 21);
            TextColour.TabIndex = 50;
            TextColour.Text = "Colour Scheme:";
            // 
            // InfoColour
            // 
            InfoColour.BackColor = Color.Transparent;
            InfoColour.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            InfoColour.Location = new Point(8, 513);
            InfoColour.Margin = new Padding(4, 0, 4, 0);
            InfoColour.Name = "InfoColour";
            InfoColour.Size = new Size(519, 38);
            InfoColour.TabIndex = 51;
            InfoColour.Text = "the general colour scheme of the application";
            InfoColour.TextAlign = ContentAlignment.TopRight;
            // 
            // ButtonChangeColour
            // 
            ButtonChangeColour.AutoSize = false;
            ButtonChangeColour.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonChangeColour.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonChangeColour.Depth = 0;
            ButtonChangeColour.HighEmphasis = true;
            ButtonChangeColour.Icon = null;
            ButtonChangeColour.Location = new Point(446, 454);
            ButtonChangeColour.Margin = new Padding(5, 7, 5, 7);
            ButtonChangeColour.MouseState = MouseState.HOVER;
            ButtonChangeColour.Name = "ButtonChangeColour";
            ButtonChangeColour.NoAccentTextColor = Color.Empty;
            ButtonChangeColour.Size = new Size(80, 49);
            ButtonChangeColour.TabIndex = 9;
            ButtonChangeColour.Text = "Save";
            ButtonChangeColour.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonChangeColour.UseAccentColor = false;
            ButtonChangeColour.UseVisualStyleBackColor = true;
            ButtonChangeColour.Click += ButtonChangeColour_Click;
            // 
            // ComboBoxColour
            // 
            ComboBoxColour.AutoResize = false;
            ComboBoxColour.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxColour.Depth = 0;
            ComboBoxColour.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxColour.DropDownHeight = 217;
            ComboBoxColour.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxColour.DropDownWidth = 121;
            ComboBoxColour.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxColour.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxColour.FormattingEnabled = true;
            ComboBoxColour.IntegralHeight = false;
            ComboBoxColour.ItemHeight = 43;
            ComboBoxColour.Location = new Point(222, 454);
            ComboBoxColour.Margin = new Padding(4, 3, 4, 3);
            ComboBoxColour.MaxDropDownItems = 5;
            ComboBoxColour.MouseState = MouseState.OUT;
            ComboBoxColour.Name = "ComboBoxColour";
            ComboBoxColour.Size = new Size(215, 49);
            ComboBoxColour.StartIndex = 0;
            ComboBoxColour.TabIndex = 8;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.AnimateReadOnly = false;
            TextBoxEmail.BorderStyle = BorderStyle.None;
            TextBoxEmail.Depth = 0;
            TextBoxEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxEmail.LeadingIcon = null;
            TextBoxEmail.Location = new Point(222, 343);
            TextBoxEmail.Margin = new Padding(4, 3, 4, 3);
            TextBoxEmail.MaxLength = 50;
            TextBoxEmail.MouseState = MouseState.OUT;
            TextBoxEmail.Multiline = false;
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(216, 50);
            TextBoxEmail.TabIndex = 6;
            TextBoxEmail.Text = "";
            TextBoxEmail.TrailingIcon = null;
            // 
            // ComboBoxTime
            // 
            ComboBoxTime.AutoResize = false;
            ComboBoxTime.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxTime.Depth = 0;
            ComboBoxTime.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxTime.DropDownHeight = 174;
            ComboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTime.DropDownWidth = 121;
            ComboBoxTime.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxTime.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxTime.FormattingEnabled = true;
            ComboBoxTime.IntegralHeight = false;
            ComboBoxTime.ItemHeight = 43;
            ComboBoxTime.Location = new Point(222, 106);
            ComboBoxTime.Margin = new Padding(4, 3, 4, 3);
            ComboBoxTime.MaxDropDownItems = 4;
            ComboBoxTime.MouseState = MouseState.OUT;
            ComboBoxTime.Name = "ComboBoxTime";
            ComboBoxTime.Size = new Size(215, 49);
            ComboBoxTime.StartIndex = 0;
            ComboBoxTime.TabIndex = 2;
            // 
            // TextNotification2
            // 
            TextNotification2.AutoSize = true;
            TextNotification2.BackColor = Color.Transparent;
            TextNotification2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextNotification2.Location = new Point(4, 257);
            TextNotification2.Margin = new Padding(4, 0, 4, 0);
            TextNotification2.Name = "TextNotification2";
            TextNotification2.Size = new Size(151, 21);
            TextNotification2.TabIndex = 56;
            TextNotification2.Text = "Notification Stock:";
            // 
            // ButtonChangeNotifStock
            // 
            ButtonChangeNotifStock.AutoSize = false;
            ButtonChangeNotifStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonChangeNotifStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonChangeNotifStock.Depth = 0;
            ButtonChangeNotifStock.HighEmphasis = true;
            ButtonChangeNotifStock.Icon = null;
            ButtonChangeNotifStock.Location = new Point(446, 229);
            ButtonChangeNotifStock.Margin = new Padding(5, 7, 5, 7);
            ButtonChangeNotifStock.MouseState = MouseState.HOVER;
            ButtonChangeNotifStock.Name = "ButtonChangeNotifStock";
            ButtonChangeNotifStock.NoAccentTextColor = Color.Empty;
            ButtonChangeNotifStock.Size = new Size(80, 49);
            ButtonChangeNotifStock.TabIndex = 5;
            ButtonChangeNotifStock.Text = "Save";
            ButtonChangeNotifStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonChangeNotifStock.UseAccentColor = false;
            ButtonChangeNotifStock.UseVisualStyleBackColor = true;
            ButtonChangeNotifStock.Click += ButtonChangeNotifStock_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(15, 287);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(511, 35);
            label1.TabIndex = 58;
            label1.Text = "the amount of stock that triggers a 'Low Stock' warning";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // ComboBoxStock
            // 
            ComboBoxStock.AutoResize = false;
            ComboBoxStock.BackColor = Color.FromArgb(255, 255, 255);
            ComboBoxStock.Depth = 0;
            ComboBoxStock.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxStock.DropDownHeight = 432;
            ComboBoxStock.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxStock.DropDownWidth = 121;
            ComboBoxStock.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxStock.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxStock.FormattingEnabled = true;
            ComboBoxStock.IntegralHeight = false;
            ComboBoxStock.ItemHeight = 43;
            ComboBoxStock.Location = new Point(222, 229);
            ComboBoxStock.Margin = new Padding(4, 3, 4, 3);
            ComboBoxStock.MaxDropDownItems = 10;
            ComboBoxStock.MouseState = MouseState.OUT;
            ComboBoxStock.Name = "ComboBoxStock";
            ComboBoxStock.Size = new Size(215, 49);
            ComboBoxStock.StartIndex = 0;
            ComboBoxStock.TabIndex = 4;
            // 
            // ButtonRestart
            // 
            ButtonRestart.AutoSize = false;
            ButtonRestart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonRestart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonRestart.Depth = 0;
            ButtonRestart.HighEmphasis = true;
            ButtonRestart.Icon = null;
            ButtonRestart.Location = new Point(8, 550);
            ButtonRestart.Margin = new Padding(5, 7, 5, 7);
            ButtonRestart.MouseState = MouseState.HOVER;
            ButtonRestart.Name = "ButtonRestart";
            ButtonRestart.NoAccentTextColor = Color.Empty;
            ButtonRestart.Size = new Size(518, 42);
            ButtonRestart.TabIndex = 10;
            ButtonRestart.Text = "Reload Now";
            ButtonRestart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonRestart.UseAccentColor = false;
            ButtonRestart.UseVisualStyleBackColor = true;
            ButtonRestart.Click += ButtonRestart_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(534, 658);
            Controls.Add(ButtonRestart);
            Controls.Add(ComboBoxStock);
            Controls.Add(label1);
            Controls.Add(ButtonChangeNotifStock);
            Controls.Add(TextNotification2);
            Controls.Add(ComboBoxTime);
            Controls.Add(TextBoxEmail);
            Controls.Add(ComboBoxColour);
            Controls.Add(ButtonChangeColour);
            Controls.Add(InfoColour);
            Controls.Add(TextColour);
            Controls.Add(InfoEmail);
            Controls.Add(InfoNotification);
            Controls.Add(ButtonChangeEmail);
            Controls.Add(TextEmail);
            Controls.Add(TextNotification1);
            Controls.Add(ButtonChangeNotifTime);
            Controls.Add(TextSettings);
            Controls.Add(ButtonClose);
            Controls.Add(UnusedButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TextNotification1;
        private MaterialSkin.Controls.MaterialButton ButtonChangeNotifTime;
        private Label TextSettings;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private Label TextEmail;
        private MaterialSkin.Controls.MaterialButton ButtonChangeEmail;
        private Label InfoNotification;
        private Label InfoEmail;
        private MaterialSkin.Controls.MaterialButton UnusedButton;
        private Label TextColour;
        private Label InfoColour;
        private MaterialSkin.Controls.MaterialButton ButtonChangeColour;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxColour;
        private MaterialSkin.Controls.MaterialTextBox TextBoxEmail;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxTime;
        private Label TextNotification2;
        private MaterialSkin.Controls.MaterialButton ButtonChangeNotifStock;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxStock;
        private MaterialSkin.Controls.MaterialButton ButtonRestart;
    }
}