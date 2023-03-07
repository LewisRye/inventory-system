namespace Inventory.LoginForms
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            TextLogin = new Label();
            TextUsername = new Label();
            TextPassword = new Label();
            TextBoxUsername = new MaterialSkin.Controls.MaterialTextBox();
            TextBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            LinkReset = new LinkLabel();
            LinkShowPassword = new CheckBox();
            ButtonLogin = new MaterialSkin.Controls.MaterialButton();
            ButtonClear = new MaterialSkin.Controls.MaterialButton();
            ButtonExit = new MaterialSkin.Controls.MaterialButton();
            StockNotification = new NotifyIcon(components);
            StockTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TextLogin
            // 
            TextLogin.Location = new Point(7, 0);
            TextLogin.Name = "TextLogin";
            TextLogin.Size = new Size(493, 70);
            TextLogin.TabIndex = 24;
            TextLogin.Text = "Login";
            TextLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextUsername
            // 
            TextUsername.AutoSize = true;
            TextUsername.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextUsername.Location = new Point(6, 70);
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(105, 25);
            TextUsername.TabIndex = 25;
            TextUsername.Text = "Username";
            TextUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextPassword
            // 
            TextPassword.AutoSize = true;
            TextPassword.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.Location = new Point(6, 152);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(99, 25);
            TextPassword.TabIndex = 26;
            TextPassword.Text = "Password";
            TextPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.AnimateReadOnly = false;
            TextBoxUsername.BorderStyle = BorderStyle.None;
            TextBoxUsername.Depth = 0;
            TextBoxUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxUsername.LeadingIcon = null;
            TextBoxUsername.Location = new Point(7, 99);
            TextBoxUsername.MaxLength = 20;
            TextBoxUsername.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxUsername.Multiline = false;
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(493, 50);
            TextBoxUsername.TabIndex = 1;
            TextBoxUsername.Text = "";
            TextBoxUsername.TrailingIcon = null;
            TextBoxUsername.KeyDown += TextBoxUsername_KeyDown;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.AnimateReadOnly = false;
            TextBoxPassword.BorderStyle = BorderStyle.None;
            TextBoxPassword.Depth = 0;
            TextBoxPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBoxPassword.LeadingIcon = null;
            TextBoxPassword.Location = new Point(7, 180);
            TextBoxPassword.MaxLength = 20;
            TextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            TextBoxPassword.Multiline = false;
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Password = true;
            TextBoxPassword.Size = new Size(493, 50);
            TextBoxPassword.TabIndex = 2;
            TextBoxPassword.Text = "";
            TextBoxPassword.TrailingIcon = null;
            TextBoxPassword.KeyDown += TextBoxPassword_KeyDown;
            // 
            // LinkReset
            // 
            LinkReset.ActiveLinkColor = Color.Black;
            LinkReset.AutoSize = true;
            LinkReset.BackColor = Color.Transparent;
            LinkReset.Cursor = Cursors.Hand;
            LinkReset.DisabledLinkColor = Color.Black;
            LinkReset.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LinkReset.ForeColor = Color.Black;
            LinkReset.LinkBehavior = LinkBehavior.AlwaysUnderline;
            LinkReset.LinkColor = Color.Black;
            LinkReset.Location = new Point(2, 240);
            LinkReset.Name = "LinkReset";
            LinkReset.Size = new Size(155, 25);
            LinkReset.TabIndex = 3;
            LinkReset.TabStop = true;
            LinkReset.Text = "Reset Password";
            LinkReset.TextAlign = ContentAlignment.MiddleCenter;
            LinkReset.VisitedLinkColor = Color.Black;
            LinkReset.LinkClicked += LinkReset_LinkClicked;
            // 
            // LinkShowPassword
            // 
            LinkShowPassword.AutoSize = true;
            LinkShowPassword.BackColor = Color.Transparent;
            LinkShowPassword.BackgroundImageLayout = ImageLayout.None;
            LinkShowPassword.Cursor = Cursors.Hand;
            LinkShowPassword.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            LinkShowPassword.ForeColor = Color.Black;
            LinkShowPassword.Location = new Point(336, 238);
            LinkShowPassword.Name = "LinkShowPassword";
            LinkShowPassword.Size = new Size(174, 29);
            LinkShowPassword.TabIndex = 4;
            LinkShowPassword.Text = "Show Password";
            LinkShowPassword.TextAlign = ContentAlignment.MiddleCenter;
            LinkShowPassword.UseVisualStyleBackColor = false;
            LinkShowPassword.CheckedChanged += LinkShowPassword_CheckedChanged;
            LinkShowPassword.KeyDown += LinkShowPassword_KeyDown;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Anchor = AnchorStyles.None;
            ButtonLogin.AutoSize = false;
            ButtonLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonLogin.BackColor = Color.FromArgb(63, 81, 181);
            ButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonLogin.Depth = 0;
            ButtonLogin.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLogin.HighEmphasis = true;
            ButtonLogin.Icon = null;
            ButtonLogin.Location = new Point(7, 273);
            ButtonLogin.Margin = new Padding(4, 6, 4, 6);
            ButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.NoAccentTextColor = Color.Empty;
            ButtonLogin.Size = new Size(289, 42);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "Login";
            ButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonLogin.UseAccentColor = false;
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Anchor = AnchorStyles.None;
            ButtonClear.AutoSize = false;
            ButtonClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonClear.BackColor = Color.FromArgb(63, 81, 181);
            ButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonClear.Depth = 0;
            ButtonClear.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.HighEmphasis = true;
            ButtonClear.Icon = null;
            ButtonClear.Location = new Point(304, 273);
            ButtonClear.Margin = new Padding(4, 6, 4, 6);
            ButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonClear.Name = "ButtonClear";
            ButtonClear.NoAccentTextColor = Color.Empty;
            ButtonClear.Size = new Size(94, 42);
            ButtonClear.TabIndex = 6;
            ButtonClear.Text = "Clear";
            ButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonClear.UseAccentColor = false;
            ButtonClear.UseVisualStyleBackColor = false;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Anchor = AnchorStyles.None;
            ButtonExit.AutoSize = false;
            ButtonExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonExit.BackColor = Color.FromArgb(63, 81, 181);
            ButtonExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonExit.Depth = 0;
            ButtonExit.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonExit.HighEmphasis = true;
            ButtonExit.Icon = null;
            ButtonExit.Location = new Point(406, 273);
            ButtonExit.Margin = new Padding(4, 6, 4, 6);
            ButtonExit.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonExit.Name = "ButtonExit";
            ButtonExit.NoAccentTextColor = Color.Empty;
            ButtonExit.Size = new Size(94, 42);
            ButtonExit.TabIndex = 27;
            ButtonExit.Text = "Exit";
            ButtonExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonExit.UseAccentColor = false;
            ButtonExit.UseVisualStyleBackColor = false;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // StockNotification
            // 
            StockNotification.BalloonTipIcon = ToolTipIcon.Warning;
            StockNotification.BalloonTipText = "There are (x) items running out of stock, click for more information.";
            StockNotification.BalloonTipTitle = "Low Stock";
            StockNotification.Icon = (Icon)resources.GetObject("StockNotification.Icon");
            StockNotification.Text = "Inventory Management System";
            StockNotification.Visible = true;
            StockNotification.BalloonTipClicked += StockNotification_BalloonTipClicked;
            // 
            // StockTimer
            // 
            StockTimer.Interval = 20000;
            StockTimer.Tick += StockTimer_Tick;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(22F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(508, 324);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonClear);
            Controls.Add(ButtonLogin);
            Controls.Add(LinkShowPassword);
            Controls.Add(LinkReset);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextPassword);
            Controls.Add(TextUsername);
            Controls.Add(TextLogin);
            Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(9, 10, 9, 10);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLogin;
        private Label TextUsername;
        private Label TextPassword;
        private MaterialSkin.Controls.MaterialTextBox TextBoxUsername;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPassword;
        private LinkLabel LinkReset;
        private CheckBox LinkShowPassword;
        private MaterialSkin.Controls.MaterialButton ButtonLogin;
        private MaterialSkin.Controls.MaterialButton ButtonClear;
        private MaterialSkin.Controls.MaterialButton ButtonExit;
        private NotifyIcon StockNotification;
        private System.Windows.Forms.Timer StockTimer;
    }
}