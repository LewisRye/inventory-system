namespace Inventory.LoginForms
{
    partial class FormAccountCreate
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAccountCreate));
            HeadingText = new Label();
            LabelFirstName = new Label();
            LabelLastName = new Label();
            LabelAddress = new Label();
            LabelAccessLevel = new Label();
            LabelUsername = new Label();
            LabelPassword = new Label();
            LabelPwdStrength = new Label();
            ValuePwdStrength = new Label();
            BarPwdStrength = new MaterialSkin.Controls.MaterialProgressBar();
            ButtonCreateUser = new MaterialSkin.Controls.MaterialButton();
            ButtonReturnLogin = new MaterialSkin.Controls.MaterialButton();
            TextBoxFirstName = new TextBox();
            TextBoxLastName = new TextBox();
            TextBoxAddress = new TextBox();
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            ToolTip = new ToolTip(components);
            ComboBoxAccessLevel = new MaterialSkin.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // HeadingText
            // 
            HeadingText.BackColor = Color.Transparent;
            HeadingText.Font = new Font("Microsoft YaHei UI", 27.75F);
            HeadingText.ForeColor = Color.Black;
            HeadingText.Location = new Point(5, 0);
            HeadingText.Margin = new Padding(2, 0, 2, 0);
            HeadingText.Name = "HeadingText";
            HeadingText.Size = new Size(341, 77);
            HeadingText.TabIndex = 23;
            HeadingText.Text = "Create User";
            HeadingText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelFirstName
            // 
            LabelFirstName.Anchor = AnchorStyles.None;
            LabelFirstName.Font = new Font("Segoe UI", 9.75F);
            LabelFirstName.ForeColor = Color.Black;
            LabelFirstName.Location = new Point(5, 81);
            LabelFirstName.Margin = new Padding(2, 0, 2, 0);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(123, 23);
            LabelFirstName.TabIndex = 36;
            LabelFirstName.Text = "First Name:";
            LabelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelLastName
            // 
            LabelLastName.Anchor = AnchorStyles.None;
            LabelLastName.Font = new Font("Segoe UI", 9.75F);
            LabelLastName.ForeColor = Color.Black;
            LabelLastName.Location = new Point(4, 110);
            LabelLastName.Margin = new Padding(2, 0, 2, 0);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(123, 23);
            LabelLastName.TabIndex = 37;
            LabelLastName.Text = "Last Name:";
            LabelLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelAddress
            // 
            LabelAddress.Anchor = AnchorStyles.None;
            LabelAddress.Font = new Font("Segoe UI", 9.75F);
            LabelAddress.ForeColor = Color.Black;
            LabelAddress.Location = new Point(4, 141);
            LabelAddress.Margin = new Padding(2, 0, 2, 0);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(123, 23);
            LabelAddress.TabIndex = 38;
            LabelAddress.Text = "Address:";
            LabelAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelAccessLevel
            // 
            LabelAccessLevel.Anchor = AnchorStyles.None;
            LabelAccessLevel.Font = new Font("Segoe UI", 9.75F);
            LabelAccessLevel.ForeColor = Color.Black;
            LabelAccessLevel.Location = new Point(5, 164);
            LabelAccessLevel.Margin = new Padding(2, 0, 2, 0);
            LabelAccessLevel.Name = "LabelAccessLevel";
            LabelAccessLevel.Size = new Size(122, 59);
            LabelAccessLevel.TabIndex = 40;
            LabelAccessLevel.Text = "Access Level ID:";
            LabelAccessLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelUsername
            // 
            LabelUsername.Anchor = AnchorStyles.None;
            LabelUsername.Font = new Font("Segoe UI", 9.75F);
            LabelUsername.ForeColor = Color.Black;
            LabelUsername.Location = new Point(6, 235);
            LabelUsername.Margin = new Padding(2, 0, 2, 0);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(122, 23);
            LabelUsername.TabIndex = 41;
            LabelUsername.Text = "Username:";
            LabelUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelPassword
            // 
            LabelPassword.Anchor = AnchorStyles.None;
            LabelPassword.Font = new Font("Segoe UI", 9.75F);
            LabelPassword.ForeColor = Color.Black;
            LabelPassword.Location = new Point(6, 263);
            LabelPassword.Margin = new Padding(2, 0, 2, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(122, 23);
            LabelPassword.TabIndex = 42;
            LabelPassword.Text = "Password:";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelPwdStrength
            // 
            LabelPwdStrength.Anchor = AnchorStyles.None;
            LabelPwdStrength.Font = new Font("Segoe UI", 9.75F);
            LabelPwdStrength.ForeColor = Color.Black;
            LabelPwdStrength.Location = new Point(5, 310);
            LabelPwdStrength.Margin = new Padding(2, 0, 2, 0);
            LabelPwdStrength.Name = "LabelPwdStrength";
            LabelPwdStrength.Size = new Size(122, 23);
            LabelPwdStrength.TabIndex = 43;
            LabelPwdStrength.Text = "Password Strength:";
            LabelPwdStrength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ValuePwdStrength
            // 
            ValuePwdStrength.Anchor = AnchorStyles.None;
            ValuePwdStrength.Font = new Font("Segoe UI", 9.75F);
            ValuePwdStrength.ForeColor = Color.Red;
            ValuePwdStrength.Location = new Point(132, 313);
            ValuePwdStrength.Margin = new Padding(2, 0, 2, 0);
            ValuePwdStrength.Name = "ValuePwdStrength";
            ValuePwdStrength.Size = new Size(45, 17);
            ValuePwdStrength.TabIndex = 44;
            ValuePwdStrength.Text = "0%";
            ValuePwdStrength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BarPwdStrength
            // 
            BarPwdStrength.Depth = 0;
            BarPwdStrength.Location = new Point(185, 319);
            BarPwdStrength.MouseState = MouseState.HOVER;
            BarPwdStrength.Name = "BarPwdStrength";
            BarPwdStrength.Size = new Size(161, 5);
            BarPwdStrength.TabIndex = 45;
            // 
            // ButtonCreateUser
            // 
            ButtonCreateUser.AutoSize = false;
            ButtonCreateUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCreateUser.BackColor = Color.FromArgb(63, 81, 181);
            ButtonCreateUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCreateUser.Depth = 0;
            ButtonCreateUser.HighEmphasis = true;
            ButtonCreateUser.Icon = null;
            ButtonCreateUser.Location = new Point(8, 336);
            ButtonCreateUser.Margin = new Padding(4, 3, 4, 3);
            ButtonCreateUser.MouseState = MouseState.HOVER;
            ButtonCreateUser.Name = "ButtonCreateUser";
            ButtonCreateUser.NoAccentTextColor = Color.Empty;
            ButtonCreateUser.Size = new Size(169, 31);
            ButtonCreateUser.TabIndex = 8;
            ButtonCreateUser.Text = "Create User";
            ButtonCreateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCreateUser.UseAccentColor = false;
            ButtonCreateUser.UseVisualStyleBackColor = false;
            ButtonCreateUser.Click += ButtonCreateUser_Click;
            // 
            // ButtonReturnLogin
            // 
            ButtonReturnLogin.AutoSize = false;
            ButtonReturnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonReturnLogin.BackColor = Color.FromArgb(63, 81, 181);
            ButtonReturnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonReturnLogin.Depth = 0;
            ButtonReturnLogin.HighEmphasis = true;
            ButtonReturnLogin.Icon = null;
            ButtonReturnLogin.Location = new Point(185, 336);
            ButtonReturnLogin.Margin = new Padding(4, 3, 4, 3);
            ButtonReturnLogin.MouseState = MouseState.HOVER;
            ButtonReturnLogin.Name = "ButtonReturnLogin";
            ButtonReturnLogin.NoAccentTextColor = Color.Empty;
            ButtonReturnLogin.Size = new Size(161, 31);
            ButtonReturnLogin.TabIndex = 46;
            ButtonReturnLogin.Text = "Return to Login";
            ButtonReturnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonReturnLogin.UseAccentColor = false;
            ButtonReturnLogin.UseVisualStyleBackColor = false;
            ButtonReturnLogin.Click += ButtonReturnLogin_Click;
            // 
            // TextBoxFirstName
            // 
            TextBoxFirstName.AcceptsTab = true;
            TextBoxFirstName.Font = new Font("Segoe UI", 9F);
            TextBoxFirstName.Location = new Point(131, 83);
            TextBoxFirstName.Margin = new Padding(4, 3, 4, 3);
            TextBoxFirstName.MaxLength = 20;
            TextBoxFirstName.Name = "TextBoxFirstName";
            TextBoxFirstName.Size = new Size(215, 23);
            TextBoxFirstName.TabIndex = 1;
            TextBoxFirstName.TextChanged += TextBoxFirstName_TextChanged;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.AcceptsTab = true;
            TextBoxLastName.Font = new Font("Segoe UI", 9F);
            TextBoxLastName.Location = new Point(131, 112);
            TextBoxLastName.Margin = new Padding(4, 3, 4, 3);
            TextBoxLastName.MaxLength = 20;
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(215, 23);
            TextBoxLastName.TabIndex = 2;
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.AcceptsTab = true;
            TextBoxAddress.Font = new Font("Segoe UI", 9F);
            TextBoxAddress.Location = new Point(131, 143);
            TextBoxAddress.Margin = new Padding(4, 3, 4, 3);
            TextBoxAddress.MaxLength = 20;
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(215, 23);
            TextBoxAddress.TabIndex = 3;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.AcceptsTab = true;
            TextBoxUsername.Font = new Font("Segoe UI", 9F);
            TextBoxUsername.Location = new Point(132, 237);
            TextBoxUsername.Margin = new Padding(4, 3, 4, 3);
            TextBoxUsername.MaxLength = 20;
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.ReadOnly = true;
            TextBoxUsername.Size = new Size(215, 23);
            TextBoxUsername.TabIndex = 6;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.AcceptsTab = true;
            TextBoxPassword.Font = new Font("Segoe UI", 9F);
            TextBoxPassword.Location = new Point(132, 265);
            TextBoxPassword.Margin = new Padding(4, 3, 4, 3);
            TextBoxPassword.MaxLength = 20;
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(215, 23);
            TextBoxPassword.TabIndex = 7;
            TextBoxPassword.UseSystemPasswordChar = true;
            TextBoxPassword.TextChanged += TextBoxPassword_TextChanged;
            // 
            // ToolTip
            // 
            ToolTip.BackColor = Color.White;
            ToolTip.IsBalloon = true;
            // 
            // ComboBoxAccessLevel
            // 
            ComboBoxAccessLevel.AutoResize = false;
            ComboBoxAccessLevel.BackColor = Color.White;
            ComboBoxAccessLevel.Depth = 0;
            ComboBoxAccessLevel.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxAccessLevel.DropDownHeight = 118;
            ComboBoxAccessLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxAccessLevel.DropDownWidth = 121;
            ComboBoxAccessLevel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBoxAccessLevel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBoxAccessLevel.FormattingEnabled = true;
            ComboBoxAccessLevel.IntegralHeight = false;
            ComboBoxAccessLevel.ItemHeight = 29;
            ComboBoxAccessLevel.Location = new Point(131, 182);
            ComboBoxAccessLevel.MaxDropDownItems = 4;
            ComboBoxAccessLevel.MouseState = MouseState.OUT;
            ComboBoxAccessLevel.Name = "ComboBoxAccessLevel";
            ComboBoxAccessLevel.Size = new Size(215, 35);
            ComboBoxAccessLevel.StartIndex = 0;
            ComboBoxAccessLevel.TabIndex = 47;
            ComboBoxAccessLevel.UseTallSize = false;
            // 
            // FormAccountCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(353, 373);
            Controls.Add(ComboBoxAccessLevel);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            Controls.Add(TextBoxAddress);
            Controls.Add(TextBoxLastName);
            Controls.Add(TextBoxFirstName);
            Controls.Add(ButtonReturnLogin);
            Controls.Add(ButtonCreateUser);
            Controls.Add(BarPwdStrength);
            Controls.Add(ValuePwdStrength);
            Controls.Add(LabelPwdStrength);
            Controls.Add(LabelPassword);
            Controls.Add(LabelUsername);
            Controls.Add(LabelAccessLevel);
            Controls.Add(LabelAddress);
            Controls.Add(LabelLastName);
            Controls.Add(LabelFirstName);
            Controls.Add(HeadingText);
            Font = new Font("Microsoft YaHei UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormAccountCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadingText;
        private Label LabelFirstName;
        private Label LabelLastName;
        private Label LabelAddress;
        private Label LabelAccessLevel;
        private Label LabelUsername;
        private Label LabelPassword;
        private Label LabelPwdStrength;
        private Label ValuePwdStrength;
        private MaterialSkin.Controls.MaterialProgressBar BarPwdStrength;
        private MaterialSkin.Controls.MaterialButton ButtonCreateUser;
        private MaterialSkin.Controls.MaterialButton ButtonReturnLogin;
        private TextBox TextBoxFirstName;
        private TextBox TextBoxLastName;
        private TextBox TextBoxAddress;
        private TextBox TextBoxUsername;
        private TextBox TextBoxPassword;
        private ToolTip ToolTip;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxAccessLevel;
    }
}