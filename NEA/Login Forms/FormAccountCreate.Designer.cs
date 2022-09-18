namespace NEA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountCreate));
            this.ButtonReturnLogin = new MaterialSkin.Controls.MaterialButton();
            this.UnusedLink = new System.Windows.Forms.LinkLabel();
            this.ButtonCreateUser = new MaterialSkin.Controls.MaterialButton();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BarPwdStrength = new MaterialSkin.Controls.MaterialProgressBar();
            this.ValuePwdStrength = new System.Windows.Forms.Label();
            this.LabelPwdStrength = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.HeadingText = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.LabelAccessLevel = new System.Windows.Forms.Label();
            this.ComboBoxAccessLevel = new MaterialSkin.Controls.MaterialComboBox();
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
            this.ButtonReturnLogin.Location = new System.Drawing.Point(185, 336);
            this.ButtonReturnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonReturnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReturnLogin.Name = "ButtonReturnLogin";
            this.ButtonReturnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonReturnLogin.Size = new System.Drawing.Size(161, 31);
            this.ButtonReturnLogin.TabIndex = 9;
            this.ButtonReturnLogin.Text = "Return to Login";
            this.ButtonReturnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonReturnLogin.UseAccentColor = false;
            this.ButtonReturnLogin.UseVisualStyleBackColor = false;
            this.ButtonReturnLogin.Click += new System.EventHandler(this.ButtonReturnLogin_Click);
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
            this.UnusedLink.Location = new System.Drawing.Point(18, 339);
            this.UnusedLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnusedLink.Name = "UnusedLink";
            this.UnusedLink.Size = new System.Drawing.Size(13, 19);
            this.UnusedLink.TabIndex = 22;
            this.UnusedLink.TabStop = true;
            this.UnusedLink.Text = " ";
            this.UnusedLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UnusedLink.Visible = false;
            this.UnusedLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // ButtonCreateUser
            // 
            this.ButtonCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCreateUser.AutoSize = false;
            this.ButtonCreateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonCreateUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonCreateUser.Depth = 0;
            this.ButtonCreateUser.HighEmphasis = true;
            this.ButtonCreateUser.Icon = null;
            this.ButtonCreateUser.Location = new System.Drawing.Point(8, 336);
            this.ButtonCreateUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonCreateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonCreateUser.Name = "ButtonCreateUser";
            this.ButtonCreateUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonCreateUser.Size = new System.Drawing.Size(169, 31);
            this.ButtonCreateUser.TabIndex = 8;
            this.ButtonCreateUser.Text = "Create User";
            this.ButtonCreateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonCreateUser.UseAccentColor = false;
            this.ButtonCreateUser.UseVisualStyleBackColor = false;
            this.ButtonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AcceptsTab = true;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.Location = new System.Drawing.Point(131, 271);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPassword.MaxLength = 20;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(215, 23);
            this.TextBoxPassword.TabIndex = 7;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.AcceptsTab = true;
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(131, 173);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPhoneNumber.MaxLength = 11;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(215, 23);
            this.TextBoxPhoneNumber.TabIndex = 4;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.Location = new System.Drawing.Point(131, 243);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxUsername.MaxLength = 20;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.ReadOnly = true;
            this.TextBoxUsername.Size = new System.Drawing.Size(215, 23);
            this.TextBoxUsername.TabIndex = 6;
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.White;
            this.ToolTip.IsBalloon = true;
            // 
            // BarPwdStrength
            // 
            this.BarPwdStrength.Depth = 0;
            this.BarPwdStrength.Location = new System.Drawing.Point(174, 319);
            this.BarPwdStrength.MouseState = MaterialSkin.MouseState.HOVER;
            this.BarPwdStrength.Name = "BarPwdStrength";
            this.BarPwdStrength.Size = new System.Drawing.Size(172, 5);
            this.BarPwdStrength.TabIndex = 35;
            // 
            // ValuePwdStrength
            // 
            this.ValuePwdStrength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValuePwdStrength.AutoSize = true;
            this.ValuePwdStrength.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValuePwdStrength.ForeColor = System.Drawing.Color.Red;
            this.ValuePwdStrength.Location = new System.Drawing.Point(132, 313);
            this.ValuePwdStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValuePwdStrength.Name = "ValuePwdStrength";
            this.ValuePwdStrength.Size = new System.Drawing.Size(26, 17);
            this.ValuePwdStrength.TabIndex = 34;
            this.ValuePwdStrength.Text = "0%";
            this.ValuePwdStrength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPwdStrength
            // 
            this.LabelPwdStrength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPwdStrength.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPwdStrength.ForeColor = System.Drawing.Color.Black;
            this.LabelPwdStrength.Location = new System.Drawing.Point(5, 310);
            this.LabelPwdStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPwdStrength.Name = "LabelPwdStrength";
            this.LabelPwdStrength.Size = new System.Drawing.Size(123, 23);
            this.LabelPwdStrength.TabIndex = 33;
            this.LabelPwdStrength.Text = "Password Strength:";
            this.LabelPwdStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.Black;
            this.LabelPassword.Location = new System.Drawing.Point(6, 269);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(122, 23);
            this.LabelPassword.TabIndex = 32;
            this.LabelPassword.Text = "Password:";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.LabelPhoneNumber.Location = new System.Drawing.Point(6, 171);
            this.LabelPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(122, 23);
            this.LabelPhoneNumber.TabIndex = 31;
            this.LabelPhoneNumber.Text = "Phone Number:";
            this.LabelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelUsername
            // 
            this.LabelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.Black;
            this.LabelUsername.Location = new System.Drawing.Point(5, 241);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(123, 23);
            this.LabelUsername.TabIndex = 30;
            this.LabelUsername.Text = "Username:";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeadingText
            // 
            this.HeadingText.BackColor = System.Drawing.Color.Transparent;
            this.HeadingText.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.HeadingText.ForeColor = System.Drawing.Color.Black;
            this.HeadingText.Location = new System.Drawing.Point(5, -1);
            this.HeadingText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadingText.Name = "HeadingText";
            this.HeadingText.Size = new System.Drawing.Size(341, 77);
            this.HeadingText.TabIndex = 23;
            this.HeadingText.Text = "Create User";
            this.HeadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.Black;
            this.LabelFirstName.Location = new System.Drawing.Point(5, 81);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(123, 23);
            this.LabelFirstName.TabIndex = 36;
            this.LabelFirstName.Text = "First Name:";
            this.LabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelLastName
            // 
            this.LabelLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.ForeColor = System.Drawing.Color.Black;
            this.LabelLastName.Location = new System.Drawing.Point(5, 112);
            this.LabelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(123, 23);
            this.LabelLastName.TabIndex = 37;
            this.LabelLastName.Text = "Last Name:";
            this.LabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelAddress
            // 
            this.LabelAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.ForeColor = System.Drawing.Color.Black;
            this.LabelAddress.Location = new System.Drawing.Point(6, 141);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(122, 23);
            this.LabelAddress.TabIndex = 38;
            this.LabelAddress.Text = "Address:";
            this.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.AcceptsTab = true;
            this.TextBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFirstName.Location = new System.Drawing.Point(131, 83);
            this.TextBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxFirstName.MaxLength = 20;
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(215, 23);
            this.TextBoxFirstName.TabIndex = 1;
            this.TextBoxFirstName.TextChanged += new System.EventHandler(this.TextBoxFirstName_TextChanged);
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.AcceptsTab = true;
            this.TextBoxLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxLastName.Location = new System.Drawing.Point(131, 114);
            this.TextBoxLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxLastName.MaxLength = 20;
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(215, 23);
            this.TextBoxLastName.TabIndex = 2;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.AcceptsTab = true;
            this.TextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAddress.Location = new System.Drawing.Point(131, 143);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxAddress.MaxLength = 25;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(215, 23);
            this.TextBoxAddress.TabIndex = 3;
            // 
            // LabelAccessLevel
            // 
            this.LabelAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAccessLevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccessLevel.ForeColor = System.Drawing.Color.Black;
            this.LabelAccessLevel.Location = new System.Drawing.Point(6, 200);
            this.LabelAccessLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAccessLevel.Name = "LabelAccessLevel";
            this.LabelAccessLevel.Size = new System.Drawing.Size(122, 23);
            this.LabelAccessLevel.TabIndex = 42;
            this.LabelAccessLevel.Text = "Access Level ID:";
            this.LabelAccessLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBoxAccessLevel
            // 
            this.ComboBoxAccessLevel.AutoResize = false;
            this.ComboBoxAccessLevel.BackColor = System.Drawing.Color.White;
            this.ComboBoxAccessLevel.Depth = 0;
            this.ComboBoxAccessLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxAccessLevel.DropDownHeight = 292;
            this.ComboBoxAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAccessLevel.DropDownWidth = 121;
            this.ComboBoxAccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxAccessLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxAccessLevel.FormattingEnabled = true;
            this.ComboBoxAccessLevel.IntegralHeight = false;
            this.ComboBoxAccessLevel.ItemHeight = 29;
            this.ComboBoxAccessLevel.Location = new System.Drawing.Point(131, 202);
            this.ComboBoxAccessLevel.MaxDropDownItems = 10;
            this.ComboBoxAccessLevel.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxAccessLevel.Name = "ComboBoxAccessLevel";
            this.ComboBoxAccessLevel.Size = new System.Drawing.Size(215, 35);
            this.ComboBoxAccessLevel.StartIndex = 0;
            this.ComboBoxAccessLevel.TabIndex = 43;
            this.ComboBoxAccessLevel.UseAccent = false;
            this.ComboBoxAccessLevel.UseTallSize = false;
            // 
            // FormAccountCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 373);
            this.Controls.Add(this.ComboBoxAccessLevel);
            this.Controls.Add(this.LabelAccessLevel);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.ButtonReturnLogin);
            this.Controls.Add(this.ButtonCreateUser);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.BarPwdStrength);
            this.Controls.Add(this.ValuePwdStrength);
            this.Controls.Add(this.LabelPwdStrength);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.HeadingText);
            this.Controls.Add(this.UnusedLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccountCreate";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.LoginCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ButtonReturnLogin;
        private System.Windows.Forms.LinkLabel UnusedLink;
        private MaterialSkin.Controls.MaterialButton ButtonCreateUser;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.ToolTip ToolTip;
        private MaterialSkin.Controls.MaterialProgressBar BarPwdStrength;
        private System.Windows.Forms.Label ValuePwdStrength;
        private System.Windows.Forms.Label LabelPwdStrength;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label HeadingText;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.Label LabelAccessLevel;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxAccessLevel;
    }
}