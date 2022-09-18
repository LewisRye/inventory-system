namespace NEA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.ButtonExit = new MaterialSkin.Controls.MaterialButton();
            this.ButtonClear = new MaterialSkin.Controls.MaterialButton();
            this.ButtonLogin = new MaterialSkin.Controls.MaterialButton();
            this.LinkReset = new System.Windows.Forms.LinkLabel();
            this.LinkShowPassword = new System.Windows.Forms.CheckBox();
            this.StockNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.StockTimer = new System.Windows.Forms.Timer(this.components);
            this.TextBoxUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.TextLogin = new System.Windows.Forms.Label();
            this.TextUsername = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonExit.AutoSize = false;
            this.ButtonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonExit.Depth = 0;
            this.ButtonExit.HighEmphasis = true;
            this.ButtonExit.Icon = null;
            this.ButtonExit.Location = new System.Drawing.Point(406, 273);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonExit.Size = new System.Drawing.Size(94, 42);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonExit.UseAccentColor = false;
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear.AutoSize = false;
            this.ButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClear.Depth = 0;
            this.ButtonClear.HighEmphasis = true;
            this.ButtonClear.Icon = null;
            this.ButtonClear.Location = new System.Drawing.Point(304, 273);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClear.Size = new System.Drawing.Size(94, 42);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClear.UseAccentColor = false;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonLogin.AutoSize = false;
            this.ButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonLogin.Depth = 0;
            this.ButtonLogin.HighEmphasis = true;
            this.ButtonLogin.Icon = null;
            this.ButtonLogin.Location = new System.Drawing.Point(7, 273);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonLogin.Size = new System.Drawing.Size(289, 42);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonLogin.UseAccentColor = false;
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LinkReset
            // 
            this.LinkReset.ActiveLinkColor = System.Drawing.Color.Black;
            this.LinkReset.AutoSize = true;
            this.LinkReset.BackColor = System.Drawing.Color.Transparent;
            this.LinkReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkReset.DisabledLinkColor = System.Drawing.Color.Black;
            this.LinkReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkReset.ForeColor = System.Drawing.Color.Black;
            this.LinkReset.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LinkReset.LinkColor = System.Drawing.Color.Black;
            this.LinkReset.Location = new System.Drawing.Point(2, 240);
            this.LinkReset.Name = "LinkReset";
            this.LinkReset.Size = new System.Drawing.Size(155, 25);
            this.LinkReset.TabIndex = 3;
            this.LinkReset.TabStop = true;
            this.LinkReset.Text = "Reset Password";
            this.LinkReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkReset.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkReset_LinkClicked);
            // 
            // LinkShowPassword
            // 
            this.LinkShowPassword.AutoSize = true;
            this.LinkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.LinkShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LinkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkShowPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkShowPassword.ForeColor = System.Drawing.Color.Black;
            this.LinkShowPassword.Location = new System.Drawing.Point(336, 238);
            this.LinkShowPassword.Name = "LinkShowPassword";
            this.LinkShowPassword.Size = new System.Drawing.Size(174, 29);
            this.LinkShowPassword.TabIndex = 4;
            this.LinkShowPassword.Text = "Show Password";
            this.LinkShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkShowPassword.UseVisualStyleBackColor = false;
            this.LinkShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            this.LinkShowPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LinkShowPassword_KeyDown);
            // 
            // StockNotification
            // 
            this.StockNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.StockNotification.BalloonTipText = "There are (x) items running out of stock, click for more information.";
            this.StockNotification.BalloonTipTitle = "Low Stock";
            this.StockNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("StockNotification.Icon")));
            this.StockNotification.Text = "Inventory Management Software";
            this.StockNotification.Visible = true;
            this.StockNotification.BalloonTipClicked += new System.EventHandler(this.StockNotification_BalloonTipClicked);
            this.StockNotification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StockNotification_MouseDoubleClick);
            // 
            // StockTimer
            // 
            this.StockTimer.Interval = 20000;
            this.StockTimer.Tick += new System.EventHandler(this.StockTimer_Tick);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AnimateReadOnly = false;
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.Depth = 0;
            this.TextBoxUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxUsername.LeadingIcon = null;
            this.TextBoxUsername.Location = new System.Drawing.Point(7, 99);
            this.TextBoxUsername.MaxLength = 20;
            this.TextBoxUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxUsername.Multiline = false;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(493, 50);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.Text = "";
            this.TextBoxUsername.TrailingIcon = null;
            this.TextBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUsername_KeyDown);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AnimateReadOnly = false;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Depth = 0;
            this.TextBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxPassword.LeadingIcon = null;
            this.TextBoxPassword.Location = new System.Drawing.Point(7, 180);
            this.TextBoxPassword.MaxLength = 20;
            this.TextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPassword.Multiline = false;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Password = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(493, 50);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.Text = "";
            this.TextBoxPassword.TrailingIcon = null;
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            // 
            // TextLogin
            // 
            this.TextLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLogin.Location = new System.Drawing.Point(7, 0);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(493, 70);
            this.TextLogin.TabIndex = 24;
            this.TextLogin.Text = "Login";
            this.TextLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextUsername
            // 
            this.TextUsername.AutoSize = true;
            this.TextUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsername.Location = new System.Drawing.Point(6, 70);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(105, 25);
            this.TextUsername.TabIndex = 25;
            this.TextUsername.Text = "Username";
            this.TextUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.Location = new System.Drawing.Point(6, 152);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(99, 25);
            this.TextPassword.TabIndex = 26;
            this.TextPassword.Text = "Password";
            this.TextPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 324);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.LinkShowPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LinkReset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButtonExit;
        private MaterialSkin.Controls.MaterialButton ButtonClear;
        private MaterialSkin.Controls.MaterialButton ButtonLogin;
        private System.Windows.Forms.LinkLabel LinkReset;
        private System.Windows.Forms.CheckBox LinkShowPassword;
        private System.Windows.Forms.NotifyIcon StockNotification;
        private System.Windows.Forms.Timer StockTimer;
        private MaterialSkin.Controls.MaterialTextBox TextBoxUsername;
        private MaterialSkin.Controls.MaterialTextBox TextBoxPassword;
        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.Label TextUsername;
        private System.Windows.Forms.Label TextPassword;
    }
}

