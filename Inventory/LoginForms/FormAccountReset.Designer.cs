namespace Inventory.LoginForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountReset));
            LabelResetPassword = new Label();
            LabelUsername = new Label();
            LabelAddress = new Label();
            LabelPassword = new Label();
            LabelPwdStrength = new Label();
            ValuePwdStrength = new Label();
            TextBoxUsername = new TextBox();
            TextBoxAddress = new TextBox();
            TextBoxPassword = new TextBox();
            BarPwdStrength = new MaterialSkin.Controls.MaterialProgressBar();
            ButtonResetPwd = new MaterialSkin.Controls.MaterialButton();
            ButtonReturnLogin = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // LabelResetPassword
            // 
            LabelResetPassword.BackColor = Color.Transparent;
            LabelResetPassword.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelResetPassword.ForeColor = Color.Black;
            LabelResetPassword.Location = new Point(6, 3);
            LabelResetPassword.Margin = new Padding(2, 0, 2, 0);
            LabelResetPassword.Name = "LabelResetPassword";
            LabelResetPassword.Size = new Size(340, 61);
            LabelResetPassword.TabIndex = 10;
            LabelResetPassword.Text = "Reset Password";
            LabelResetPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelUsername
            // 
            LabelUsername.Anchor = AnchorStyles.None;
            LabelUsername.BackColor = Color.Transparent;
            LabelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsername.ForeColor = Color.Black;
            LabelUsername.Location = new Point(6, 69);
            LabelUsername.Margin = new Padding(2, 0, 2, 0);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(120, 23);
            LabelUsername.TabIndex = 11;
            LabelUsername.Text = "Username:";
            LabelUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelAddress
            // 
            LabelAddress.Anchor = AnchorStyles.None;
            LabelAddress.BackColor = Color.Transparent;
            LabelAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAddress.ForeColor = Color.Black;
            LabelAddress.Location = new Point(6, 94);
            LabelAddress.Margin = new Padding(2, 0, 2, 0);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(120, 23);
            LabelAddress.TabIndex = 12;
            LabelAddress.Text = "Address:";
            LabelAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelPassword
            // 
            LabelPassword.Anchor = AnchorStyles.None;
            LabelPassword.BackColor = Color.Transparent;
            LabelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.ForeColor = Color.Black;
            LabelPassword.Location = new Point(6, 144);
            LabelPassword.Margin = new Padding(2, 0, 2, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(120, 23);
            LabelPassword.TabIndex = 13;
            LabelPassword.Text = "New Password:";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelPwdStrength
            // 
            LabelPwdStrength.Anchor = AnchorStyles.None;
            LabelPwdStrength.BackColor = Color.Transparent;
            LabelPwdStrength.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPwdStrength.ForeColor = Color.Black;
            LabelPwdStrength.Location = new Point(6, 176);
            LabelPwdStrength.Margin = new Padding(2, 0, 2, 0);
            LabelPwdStrength.Name = "LabelPwdStrength";
            LabelPwdStrength.Size = new Size(120, 23);
            LabelPwdStrength.TabIndex = 14;
            LabelPwdStrength.Text = "Password Strength:";
            LabelPwdStrength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ValuePwdStrength
            // 
            ValuePwdStrength.Anchor = AnchorStyles.None;
            ValuePwdStrength.BackColor = Color.Transparent;
            ValuePwdStrength.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ValuePwdStrength.ForeColor = Color.Red;
            ValuePwdStrength.Location = new Point(128, 176);
            ValuePwdStrength.Margin = new Padding(2, 0, 2, 0);
            ValuePwdStrength.Name = "ValuePwdStrength";
            ValuePwdStrength.Size = new Size(46, 23);
            ValuePwdStrength.TabIndex = 15;
            ValuePwdStrength.Text = "0%";
            ValuePwdStrength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(131, 71);
            TextBoxUsername.MaxLength = 20;
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(215, 23);
            TextBoxUsername.TabIndex = 1;
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.Location = new Point(131, 96);
            TextBoxAddress.MaxLength = 20;
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(215, 23);
            TextBoxAddress.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(131, 144);
            TextBoxPassword.MaxLength = 20;
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(215, 23);
            TextBoxPassword.TabIndex = 3;
            TextBoxPassword.UseSystemPasswordChar = true;
            TextBoxPassword.TextChanged += TextBoxPassword_TextChanged;
            // 
            // BarPwdStrength
            // 
            BarPwdStrength.Depth = 0;
            BarPwdStrength.Location = new Point(172, 185);
            BarPwdStrength.MouseState = MouseState.HOVER;
            BarPwdStrength.Name = "BarPwdStrength";
            BarPwdStrength.Size = new Size(172, 5);
            BarPwdStrength.TabIndex = 18;
            // 
            // ButtonResetPwd
            // 
            ButtonResetPwd.Anchor = AnchorStyles.None;
            ButtonResetPwd.AutoSize = false;
            ButtonResetPwd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonResetPwd.BackColor = Color.FromArgb(63, 81, 181);
            ButtonResetPwd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonResetPwd.Depth = 0;
            ButtonResetPwd.HighEmphasis = true;
            ButtonResetPwd.Icon = null;
            ButtonResetPwd.Location = new Point(6, 212);
            ButtonResetPwd.Margin = new Padding(4, 6, 4, 6);
            ButtonResetPwd.MouseState = MouseState.HOVER;
            ButtonResetPwd.Name = "ButtonResetPwd";
            ButtonResetPwd.NoAccentTextColor = Color.Empty;
            ButtonResetPwd.Size = new Size(184, 31);
            ButtonResetPwd.TabIndex = 4;
            ButtonResetPwd.Text = "Reset Password";
            ButtonResetPwd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonResetPwd.UseAccentColor = false;
            ButtonResetPwd.UseVisualStyleBackColor = false;
            ButtonResetPwd.Click += ButtonResetPwd_Click;
            // 
            // ButtonReturnLogin
            // 
            ButtonReturnLogin.Anchor = AnchorStyles.None;
            ButtonReturnLogin.AutoSize = false;
            ButtonReturnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonReturnLogin.BackColor = Color.FromArgb(63, 81, 181);
            ButtonReturnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonReturnLogin.Depth = 0;
            ButtonReturnLogin.HighEmphasis = true;
            ButtonReturnLogin.Icon = null;
            ButtonReturnLogin.Location = new Point(198, 212);
            ButtonReturnLogin.Margin = new Padding(4, 6, 4, 6);
            ButtonReturnLogin.MouseState = MouseState.HOVER;
            ButtonReturnLogin.Name = "ButtonReturnLogin";
            ButtonReturnLogin.NoAccentTextColor = Color.Empty;
            ButtonReturnLogin.Size = new Size(148, 31);
            ButtonReturnLogin.TabIndex = 19;
            ButtonReturnLogin.Text = "Return to Login";
            ButtonReturnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonReturnLogin.UseAccentColor = false;
            ButtonReturnLogin.UseVisualStyleBackColor = false;
            ButtonReturnLogin.Click += ButtonReturnLogin_Click;
            // 
            // FormAccountReset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(353, 249);
            Controls.Add(ButtonReturnLogin);
            Controls.Add(ButtonResetPwd);
            Controls.Add(BarPwdStrength);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxAddress);
            Controls.Add(TextBoxUsername);
            Controls.Add(ValuePwdStrength);
            Controls.Add(LabelPwdStrength);
            Controls.Add(LabelPassword);
            Controls.Add(LabelAddress);
            Controls.Add(LabelUsername);
            Controls.Add(LabelResetPassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAccountReset";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += FormAccountReset_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelResetPassword;
        private Label LabelUsername;
        private Label LabelAddress;
        private Label LabelPassword;
        private Label LabelPwdStrength;
        private Label ValuePwdStrength;
        private TextBox TextBoxUsername;
        private TextBox TextBoxAddress;
        private TextBox TextBoxPassword;
        private MaterialSkin.Controls.MaterialProgressBar BarPwdStrength;
        private MaterialSkin.Controls.MaterialButton ButtonResetPwd;
        private MaterialSkin.Controls.MaterialButton ButtonReturnLogin;
    }
}