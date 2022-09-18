namespace NEA
{
    partial class FormAccountReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountReset));
            this.ButtonReturnLogin = new MaterialSkin.Controls.MaterialButton();
            this.UnusedLink = new System.Windows.Forms.LinkLabel();
            this.ButtonResetPwd = new MaterialSkin.Controls.MaterialButton();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.LabelResetPassword = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.LabelNewPassword = new System.Windows.Forms.Label();
            this.LabelPwdStrength = new System.Windows.Forms.Label();
            this.ValuePwdStrength = new System.Windows.Forms.Label();
            this.BarPwdStrength = new MaterialSkin.Controls.MaterialProgressBar();
            this.SuspendLayout();
            // 
            // ButtonReturnLogin
            // 
            this.ButtonReturnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonReturnLogin.AutoSize = false;
            this.ButtonReturnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonReturnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonReturnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonReturnLogin.Depth = 0;
            this.ButtonReturnLogin.HighEmphasis = true;
            this.ButtonReturnLogin.Icon = null;
            this.ButtonReturnLogin.Location = new System.Drawing.Point(216, 212);
            this.ButtonReturnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonReturnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReturnLogin.Name = "ButtonReturnLogin";
            this.ButtonReturnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonReturnLogin.Size = new System.Drawing.Size(129, 31);
            this.ButtonReturnLogin.TabIndex = 15;
            this.ButtonReturnLogin.Text = "Return to Login";
            this.ButtonReturnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonReturnLogin.UseAccentColor = false;
            this.ButtonReturnLogin.UseVisualStyleBackColor = false;
            this.ButtonReturnLogin.Click += new System.EventHandler(this.ReturnLoginButton_Click);
            // 
            // UnusedLink
            // 
            this.UnusedLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.UnusedLink.AutoSize = true;
            this.UnusedLink.BackColor = System.Drawing.Color.White;
            this.UnusedLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnusedLink.DisabledLinkColor = System.Drawing.Color.Black;
            this.UnusedLink.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.UnusedLink.ForeColor = System.Drawing.Color.White;
            this.UnusedLink.LinkColor = System.Drawing.Color.White;
            this.UnusedLink.Location = new System.Drawing.Point(185, 309);
            this.UnusedLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnusedLink.Name = "UnusedLink";
            this.UnusedLink.Size = new System.Drawing.Size(13, 19);
            this.UnusedLink.TabIndex = 8;
            this.UnusedLink.TabStop = true;
            this.UnusedLink.Text = " ";
            this.UnusedLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UnusedLink.Visible = false;
            this.UnusedLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // ButtonResetPwd
            // 
            this.ButtonResetPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonResetPwd.AutoSize = false;
            this.ButtonResetPwd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonResetPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonResetPwd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonResetPwd.Depth = 0;
            this.ButtonResetPwd.HighEmphasis = true;
            this.ButtonResetPwd.Icon = null;
            this.ButtonResetPwd.Location = new System.Drawing.Point(6, 212);
            this.ButtonResetPwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonResetPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonResetPwd.Name = "ButtonResetPwd";
            this.ButtonResetPwd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonResetPwd.Size = new System.Drawing.Size(202, 31);
            this.ButtonResetPwd.TabIndex = 14;
            this.ButtonResetPwd.Text = "Reset Password";
            this.ButtonResetPwd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonResetPwd.UseAccentColor = false;
            this.ButtonResetPwd.UseVisualStyleBackColor = false;
            this.ButtonResetPwd.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AcceptsTab = true;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.Location = new System.Drawing.Point(131, 144);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPassword.MaxLength = 20;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(215, 23);
            this.TextBoxPassword.TabIndex = 13;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.AcceptsTab = true;
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(131, 96);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPhoneNumber.MaxLength = 11;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(215, 23);
            this.TextBoxPhoneNumber.TabIndex = 12;
            this.TextBoxPhoneNumber.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AcceptsTab = true;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.Location = new System.Drawing.Point(131, 71);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxUsername.MaxLength = 20;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(215, 23);
            this.TextBoxUsername.TabIndex = 11;
            // 
            // LabelResetPassword
            // 
            this.LabelResetPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.LabelResetPassword.ForeColor = System.Drawing.Color.Black;
            this.LabelResetPassword.Location = new System.Drawing.Point(6, 3);
            this.LabelResetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelResetPassword.Name = "LabelResetPassword";
            this.LabelResetPassword.Size = new System.Drawing.Size(340, 61);
            this.LabelResetPassword.TabIndex = 10;
            this.LabelResetPassword.Text = "Reset Password";
            this.LabelResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.White;
            this.ToolTip.IsBalloon = true;
            // 
            // LabelUsername
            // 
            this.LabelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.Black;
            this.LabelUsername.Location = new System.Drawing.Point(5, 69);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(80, 23);
            this.LabelUsername.TabIndex = 16;
            this.LabelUsername.Text = "Username:";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.LabelPhoneNumber.Location = new System.Drawing.Point(5, 94);
            this.LabelPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(101, 23);
            this.LabelPhoneNumber.TabIndex = 17;
            this.LabelPhoneNumber.Text = "Phone Number:";
            this.LabelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelNewPassword
            // 
            this.LabelNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewPassword.ForeColor = System.Drawing.Color.Black;
            this.LabelNewPassword.Location = new System.Drawing.Point(5, 144);
            this.LabelNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNewPassword.Name = "LabelNewPassword";
            this.LabelNewPassword.Size = new System.Drawing.Size(97, 23);
            this.LabelNewPassword.TabIndex = 18;
            this.LabelNewPassword.Text = "New Password:";
            this.LabelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPwdStrength
            // 
            this.LabelPwdStrength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPwdStrength.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPwdStrength.ForeColor = System.Drawing.Color.Black;
            this.LabelPwdStrength.Location = new System.Drawing.Point(3, 176);
            this.LabelPwdStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPwdStrength.Name = "LabelPwdStrength";
            this.LabelPwdStrength.Size = new System.Drawing.Size(123, 23);
            this.LabelPwdStrength.TabIndex = 19;
            this.LabelPwdStrength.Text = "Password Strength:";
            this.LabelPwdStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValuePwdStrength
            // 
            this.ValuePwdStrength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValuePwdStrength.AutoSize = true;
            this.ValuePwdStrength.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValuePwdStrength.ForeColor = System.Drawing.Color.Red;
            this.ValuePwdStrength.Location = new System.Drawing.Point(128, 179);
            this.ValuePwdStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePwdStrength.Name = "ValuePwdStrength";
            this.ValuePwdStrength.Size = new System.Drawing.Size(26, 17);
            this.ValuePwdStrength.TabIndex = 20;
            this.ValuePwdStrength.Text = "0%";
            this.ValuePwdStrength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarPwdStrength
            // 
            this.BarPwdStrength.Depth = 0;
            this.BarPwdStrength.Location = new System.Drawing.Point(172, 185);
            this.BarPwdStrength.MouseState = MaterialSkin.MouseState.HOVER;
            this.BarPwdStrength.Name = "BarPwdStrength";
            this.BarPwdStrength.Size = new System.Drawing.Size(172, 5);
            this.BarPwdStrength.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarPwdStrength.TabIndex = 21;
            // 
            // LoginResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 249);
            this.Controls.Add(this.BarPwdStrength);
            this.Controls.Add(this.ValuePwdStrength);
            this.Controls.Add(this.LabelPwdStrength);
            this.Controls.Add(this.LabelNewPassword);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonReturnLogin);
            this.Controls.Add(this.ButtonResetPwd);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelResetPassword);
            this.Controls.Add(this.UnusedLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginResetForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.ResetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButtonReturnLogin;
        private System.Windows.Forms.LinkLabel UnusedLink;
        private MaterialSkin.Controls.MaterialButton ButtonResetPwd;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label LabelResetPassword;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelNewPassword;
        private System.Windows.Forms.Label LabelPwdStrength;
        private System.Windows.Forms.Label ValuePwdStrength;
        private MaterialSkin.Controls.MaterialProgressBar BarPwdStrength;
    }
}