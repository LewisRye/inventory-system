namespace Inventory.LoginForms
{
    partial class FormAccountEdit
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAccountEdit));
            ListOfAccessLevels = new MaterialSkin.Controls.MaterialComboBox();
            LabelAccessLevel = new Label();
            TextBoxAddress = new TextBox();
            TextBoxLastName = new TextBox();
            TextBoxFirstName = new TextBox();
            LabelAddress = new Label();
            ButtonReturnDash = new MaterialSkin.Controls.MaterialButton();
            LabelUsername = new Label();
            HeadingText = new Label();
            ToolTip = new ToolTip(components);
            TextBoxUsername = new TextBox();
            UnusedLink = new LinkLabel();
            LabelFirstName = new Label();
            LabelLastName = new Label();
            TextUserToChange = new Label();
            ListOfUsers = new MaterialSkin.Controls.MaterialComboBox();
            ButtonApplyFirstName = new MaterialSkin.Controls.MaterialButton();
            ButtonApplyLastName = new MaterialSkin.Controls.MaterialButton();
            ButtonApplyNewAddress = new MaterialSkin.Controls.MaterialButton();
            ButtonApplyNewAccessLevel = new MaterialSkin.Controls.MaterialButton();
            ButtonApplyNewUsername = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // ListOfAccessLevels
            // 
            ListOfAccessLevels.AutoResize = false;
            ListOfAccessLevels.BackColor = Color.White;
            ListOfAccessLevels.Depth = 0;
            ListOfAccessLevels.DrawMode = DrawMode.OwnerDrawVariable;
            ListOfAccessLevels.DropDownHeight = 292;
            ListOfAccessLevels.DropDownStyle = ComboBoxStyle.DropDownList;
            ListOfAccessLevels.DropDownWidth = 121;
            ListOfAccessLevels.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ListOfAccessLevels.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ListOfAccessLevels.FormattingEnabled = true;
            ListOfAccessLevels.IntegralHeight = false;
            ListOfAccessLevels.ItemHeight = 29;
            ListOfAccessLevels.Location = new Point(140, 309);
            ListOfAccessLevels.Margin = new Padding(4, 3, 4, 3);
            ListOfAccessLevels.MaxDropDownItems = 10;
            ListOfAccessLevels.MouseState = MouseState.OUT;
            ListOfAccessLevels.Name = "ListOfAccessLevels";
            ListOfAccessLevels.Size = new Size(182, 35);
            ListOfAccessLevels.StartIndex = 0;
            ListOfAccessLevels.TabIndex = 64;
            ListOfAccessLevels.UseAccent = false;
            ListOfAccessLevels.UseTallSize = false;
            // 
            // LabelAccessLevel
            // 
            LabelAccessLevel.Anchor = AnchorStyles.None;
            LabelAccessLevel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccessLevel.ForeColor = Color.Black;
            LabelAccessLevel.Location = new Point(12, 309);
            LabelAccessLevel.Margin = new Padding(2, 0, 2, 0);
            LabelAccessLevel.Name = "LabelAccessLevel";
            LabelAccessLevel.Size = new Size(138, 35);
            LabelAccessLevel.TabIndex = 63;
            LabelAccessLevel.Text = "New Access Level:";
            LabelAccessLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBoxAddress
            // 
            TextBoxAddress.AcceptsTab = true;
            TextBoxAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxAddress.Location = new Point(141, 255);
            TextBoxAddress.Margin = new Padding(5, 3, 5, 3);
            TextBoxAddress.MaxLength = 25;
            TextBoxAddress.Name = "TextBoxAddress";
            TextBoxAddress.Size = new Size(181, 23);
            TextBoxAddress.TabIndex = 46;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.AcceptsTab = true;
            TextBoxLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxLastName.Location = new Point(141, 222);
            TextBoxLastName.Margin = new Padding(5, 3, 5, 3);
            TextBoxLastName.MaxLength = 20;
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(181, 23);
            TextBoxLastName.TabIndex = 45;
            // 
            // TextBoxFirstName
            // 
            TextBoxFirstName.AcceptsTab = true;
            TextBoxFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxFirstName.Location = new Point(141, 186);
            TextBoxFirstName.Margin = new Padding(5, 3, 5, 3);
            TextBoxFirstName.MaxLength = 20;
            TextBoxFirstName.Name = "TextBoxFirstName";
            TextBoxFirstName.Size = new Size(181, 23);
            TextBoxFirstName.TabIndex = 44;
            // 
            // LabelAddress
            // 
            LabelAddress.Anchor = AnchorStyles.None;
            LabelAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAddress.ForeColor = Color.Black;
            LabelAddress.Location = new Point(12, 253);
            LabelAddress.Margin = new Padding(2, 0, 2, 0);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(122, 27);
            LabelAddress.TabIndex = 62;
            LabelAddress.Text = "New Address:";
            LabelAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonReturnDash
            // 
            ButtonReturnDash.Anchor = AnchorStyles.None;
            ButtonReturnDash.AutoSize = false;
            ButtonReturnDash.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonReturnDash.BackColor = Color.FromArgb(63, 81, 181);
            ButtonReturnDash.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonReturnDash.Depth = 0;
            ButtonReturnDash.HighEmphasis = true;
            ButtonReturnDash.Icon = null;
            ButtonReturnDash.Location = new Point(15, 395);
            ButtonReturnDash.Margin = new Padding(5, 3, 5, 3);
            ButtonReturnDash.MouseState = MouseState.HOVER;
            ButtonReturnDash.Name = "ButtonReturnDash";
            ButtonReturnDash.NoAccentTextColor = Color.Empty;
            ButtonReturnDash.Size = new Size(390, 132);
            ButtonReturnDash.TabIndex = 51;
            ButtonReturnDash.Text = "Return to Dashboard";
            ButtonReturnDash.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonReturnDash.UseAccentColor = false;
            ButtonReturnDash.UseVisualStyleBackColor = false;
            ButtonReturnDash.Click += ButtonReturnDash_Click;
            // 
            // LabelUsername
            // 
            LabelUsername.Anchor = AnchorStyles.None;
            LabelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsername.ForeColor = Color.Black;
            LabelUsername.Location = new Point(12, 155);
            LabelUsername.Margin = new Padding(2, 0, 2, 0);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(122, 24);
            LabelUsername.TabIndex = 54;
            LabelUsername.Text = "New Username:";
            LabelUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HeadingText
            // 
            HeadingText.BackColor = Color.Transparent;
            HeadingText.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingText.ForeColor = Color.Black;
            HeadingText.Location = new Point(7, 2);
            HeadingText.Margin = new Padding(2, 0, 2, 0);
            HeadingText.Name = "HeadingText";
            HeadingText.Size = new Size(398, 89);
            HeadingText.TabIndex = 53;
            HeadingText.Text = "Edit User";
            HeadingText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ToolTip
            // 
            ToolTip.BackColor = Color.White;
            ToolTip.IsBalloon = true;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.AcceptsTab = true;
            TextBoxUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUsername.Location = new Point(140, 152);
            TextBoxUsername.Margin = new Padding(5, 3, 5, 3);
            TextBoxUsername.MaxLength = 20;
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(182, 23);
            TextBoxUsername.TabIndex = 48;
            // 
            // UnusedLink
            // 
            UnusedLink.ActiveLinkColor = Color.Black;
            UnusedLink.AutoSize = true;
            UnusedLink.BackColor = Color.White;
            UnusedLink.Cursor = Cursors.Hand;
            UnusedLink.DisabledLinkColor = Color.Black;
            UnusedLink.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UnusedLink.ForeColor = Color.White;
            UnusedLink.LinkColor = Color.White;
            UnusedLink.Location = new Point(22, 395);
            UnusedLink.Margin = new Padding(5, 0, 5, 0);
            UnusedLink.Name = "UnusedLink";
            UnusedLink.Size = new Size(13, 19);
            UnusedLink.TabIndex = 52;
            UnusedLink.TabStop = true;
            UnusedLink.Text = " ";
            UnusedLink.TextAlign = ContentAlignment.MiddleCenter;
            UnusedLink.Visible = false;
            UnusedLink.VisitedLinkColor = Color.White;
            // 
            // LabelFirstName
            // 
            LabelFirstName.Anchor = AnchorStyles.None;
            LabelFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFirstName.ForeColor = Color.Black;
            LabelFirstName.Location = new Point(12, 186);
            LabelFirstName.Margin = new Padding(2, 0, 2, 0);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(122, 27);
            LabelFirstName.TabIndex = 60;
            LabelFirstName.Text = "New First Name:";
            LabelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelLastName
            // 
            LabelLastName.Anchor = AnchorStyles.None;
            LabelLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLastName.ForeColor = Color.Black;
            LabelLastName.Location = new Point(12, 222);
            LabelLastName.Margin = new Padding(2, 0, 2, 0);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(122, 27);
            LabelLastName.TabIndex = 61;
            LabelLastName.Text = "New Last Name:";
            LabelLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextUserToChange
            // 
            TextUserToChange.Anchor = AnchorStyles.None;
            TextUserToChange.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TextUserToChange.ForeColor = Color.Black;
            TextUserToChange.Location = new Point(12, 104);
            TextUserToChange.Margin = new Padding(2, 0, 2, 0);
            TextUserToChange.Name = "TextUserToChange";
            TextUserToChange.Size = new Size(122, 27);
            TextUserToChange.TabIndex = 65;
            TextUserToChange.Text = "User to Change:";
            TextUserToChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ListOfUsers
            // 
            ListOfUsers.AutoResize = false;
            ListOfUsers.BackColor = Color.White;
            ListOfUsers.Depth = 0;
            ListOfUsers.DrawMode = DrawMode.OwnerDrawVariable;
            ListOfUsers.DropDownHeight = 292;
            ListOfUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            ListOfUsers.DropDownWidth = 121;
            ListOfUsers.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ListOfUsers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ListOfUsers.FormattingEnabled = true;
            ListOfUsers.IntegralHeight = false;
            ListOfUsers.ItemHeight = 29;
            ListOfUsers.Location = new Point(140, 104);
            ListOfUsers.Margin = new Padding(4, 3, 4, 3);
            ListOfUsers.MaxDropDownItems = 10;
            ListOfUsers.MouseState = MouseState.OUT;
            ListOfUsers.Name = "ListOfUsers";
            ListOfUsers.Size = new Size(265, 35);
            ListOfUsers.StartIndex = 0;
            ListOfUsers.TabIndex = 66;
            ListOfUsers.UseAccent = false;
            ListOfUsers.UseTallSize = false;
            // 
            // ButtonApplyFirstName
            // 
            ButtonApplyFirstName.Anchor = AnchorStyles.None;
            ButtonApplyFirstName.AutoSize = false;
            ButtonApplyFirstName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonApplyFirstName.BackColor = Color.FromArgb(63, 81, 181);
            ButtonApplyFirstName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonApplyFirstName.Depth = 0;
            ButtonApplyFirstName.HighEmphasis = true;
            ButtonApplyFirstName.Icon = null;
            ButtonApplyFirstName.Location = new Point(332, 186);
            ButtonApplyFirstName.Margin = new Padding(5, 3, 5, 3);
            ButtonApplyFirstName.MouseState = MouseState.HOVER;
            ButtonApplyFirstName.Name = "ButtonApplyFirstName";
            ButtonApplyFirstName.NoAccentTextColor = Color.Empty;
            ButtonApplyFirstName.Size = new Size(72, 27);
            ButtonApplyFirstName.TabIndex = 67;
            ButtonApplyFirstName.Text = "Apply";
            ButtonApplyFirstName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonApplyFirstName.UseAccentColor = false;
            ButtonApplyFirstName.UseVisualStyleBackColor = false;
            ButtonApplyFirstName.Click += ButtonApplyFirstName_Click;
            // 
            // ButtonApplyLastName
            // 
            ButtonApplyLastName.Anchor = AnchorStyles.None;
            ButtonApplyLastName.AutoSize = false;
            ButtonApplyLastName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonApplyLastName.BackColor = Color.FromArgb(63, 81, 181);
            ButtonApplyLastName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonApplyLastName.Depth = 0;
            ButtonApplyLastName.HighEmphasis = true;
            ButtonApplyLastName.Icon = null;
            ButtonApplyLastName.Location = new Point(332, 222);
            ButtonApplyLastName.Margin = new Padding(5, 3, 5, 3);
            ButtonApplyLastName.MouseState = MouseState.HOVER;
            ButtonApplyLastName.Name = "ButtonApplyLastName";
            ButtonApplyLastName.NoAccentTextColor = Color.Empty;
            ButtonApplyLastName.Size = new Size(72, 27);
            ButtonApplyLastName.TabIndex = 68;
            ButtonApplyLastName.Text = "Apply";
            ButtonApplyLastName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonApplyLastName.UseAccentColor = false;
            ButtonApplyLastName.UseVisualStyleBackColor = false;
            ButtonApplyLastName.Click += ButtonApplyLastName_Click;
            // 
            // ButtonApplyNewAddress
            // 
            ButtonApplyNewAddress.Anchor = AnchorStyles.None;
            ButtonApplyNewAddress.AutoSize = false;
            ButtonApplyNewAddress.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonApplyNewAddress.BackColor = Color.FromArgb(63, 81, 181);
            ButtonApplyNewAddress.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonApplyNewAddress.Depth = 0;
            ButtonApplyNewAddress.HighEmphasis = true;
            ButtonApplyNewAddress.Icon = null;
            ButtonApplyNewAddress.Location = new Point(332, 256);
            ButtonApplyNewAddress.Margin = new Padding(5, 3, 5, 3);
            ButtonApplyNewAddress.MouseState = MouseState.HOVER;
            ButtonApplyNewAddress.Name = "ButtonApplyNewAddress";
            ButtonApplyNewAddress.NoAccentTextColor = Color.Empty;
            ButtonApplyNewAddress.Size = new Size(72, 27);
            ButtonApplyNewAddress.TabIndex = 69;
            ButtonApplyNewAddress.Text = "Apply";
            ButtonApplyNewAddress.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonApplyNewAddress.UseAccentColor = false;
            ButtonApplyNewAddress.UseVisualStyleBackColor = false;
            ButtonApplyNewAddress.Click += ButtonApplyNewAddress_Click;
            // 
            // ButtonApplyNewAccessLevel
            // 
            ButtonApplyNewAccessLevel.Anchor = AnchorStyles.None;
            ButtonApplyNewAccessLevel.AutoSize = false;
            ButtonApplyNewAccessLevel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonApplyNewAccessLevel.BackColor = Color.FromArgb(63, 81, 181);
            ButtonApplyNewAccessLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonApplyNewAccessLevel.Depth = 0;
            ButtonApplyNewAccessLevel.HighEmphasis = true;
            ButtonApplyNewAccessLevel.Icon = null;
            ButtonApplyNewAccessLevel.Location = new Point(333, 309);
            ButtonApplyNewAccessLevel.Margin = new Padding(5, 3, 5, 3);
            ButtonApplyNewAccessLevel.MouseState = MouseState.HOVER;
            ButtonApplyNewAccessLevel.Name = "ButtonApplyNewAccessLevel";
            ButtonApplyNewAccessLevel.NoAccentTextColor = Color.Empty;
            ButtonApplyNewAccessLevel.Size = new Size(72, 35);
            ButtonApplyNewAccessLevel.TabIndex = 71;
            ButtonApplyNewAccessLevel.Text = "Apply";
            ButtonApplyNewAccessLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonApplyNewAccessLevel.UseAccentColor = false;
            ButtonApplyNewAccessLevel.UseVisualStyleBackColor = false;
            ButtonApplyNewAccessLevel.Click += ButtonApplyNewAccessLevel_Click;
            // 
            // ButtonApplyNewUsername
            // 
            ButtonApplyNewUsername.Anchor = AnchorStyles.None;
            ButtonApplyNewUsername.AutoSize = false;
            ButtonApplyNewUsername.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonApplyNewUsername.BackColor = Color.FromArgb(63, 81, 181);
            ButtonApplyNewUsername.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonApplyNewUsername.Depth = 0;
            ButtonApplyNewUsername.HighEmphasis = true;
            ButtonApplyNewUsername.Icon = null;
            ButtonApplyNewUsername.Location = new Point(332, 151);
            ButtonApplyNewUsername.Margin = new Padding(5, 3, 5, 3);
            ButtonApplyNewUsername.MouseState = MouseState.HOVER;
            ButtonApplyNewUsername.Name = "ButtonApplyNewUsername";
            ButtonApplyNewUsername.NoAccentTextColor = Color.Empty;
            ButtonApplyNewUsername.Size = new Size(72, 27);
            ButtonApplyNewUsername.TabIndex = 72;
            ButtonApplyNewUsername.Text = "Apply";
            ButtonApplyNewUsername.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonApplyNewUsername.UseAccentColor = false;
            ButtonApplyNewUsername.UseVisualStyleBackColor = false;
            ButtonApplyNewUsername.Click += ButtonApplyNewUsername_Click;
            // 
            // FormAccountEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 540);
            Controls.Add(ButtonApplyNewUsername);
            Controls.Add(ButtonApplyNewAccessLevel);
            Controls.Add(ButtonApplyNewAddress);
            Controls.Add(ButtonApplyLastName);
            Controls.Add(ButtonApplyFirstName);
            Controls.Add(ListOfUsers);
            Controls.Add(TextUserToChange);
            Controls.Add(ListOfAccessLevels);
            Controls.Add(LabelAccessLevel);
            Controls.Add(TextBoxAddress);
            Controls.Add(TextBoxLastName);
            Controls.Add(TextBoxFirstName);
            Controls.Add(LabelAddress);
            Controls.Add(LabelLastName);
            Controls.Add(LabelFirstName);
            Controls.Add(ButtonReturnDash);
            Controls.Add(LabelUsername);
            Controls.Add(HeadingText);
            Controls.Add(TextBoxUsername);
            Controls.Add(UnusedLink);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAccountEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += FormAccountEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox ListOfAccessLevels;
        private System.Windows.Forms.Label LabelAccessLevel;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelAddress;
        private MaterialSkin.Controls.MaterialButton ButtonReturnDash;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label HeadingText;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.LinkLabel UnusedLink;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label TextUserToChange;
        private MaterialSkin.Controls.MaterialComboBox ListOfUsers;
        private MaterialSkin.Controls.MaterialButton ButtonApplyFirstName;
        private MaterialSkin.Controls.MaterialButton ButtonApplyLastName;
        private MaterialSkin.Controls.MaterialButton ButtonApplyNewAddress;
        private MaterialSkin.Controls.MaterialButton ButtonApplyNewAccessLevel;
        private MaterialSkin.Controls.MaterialButton ButtonApplyNewUsername;
    }
}