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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountEdit));
            this.ListOfAccessLevels = new MaterialSkin.Controls.MaterialComboBox();
            this.LabelAccessLevel = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.ButtonReturnDash = new MaterialSkin.Controls.MaterialButton();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.HeadingText = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.UnusedLink = new System.Windows.Forms.LinkLabel();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.TextUserToChange = new System.Windows.Forms.Label();
            this.ListOfUsers = new MaterialSkin.Controls.MaterialComboBox();
            this.ButtonApplyFirstName = new MaterialSkin.Controls.MaterialButton();
            this.ButtonApplyLastName = new MaterialSkin.Controls.MaterialButton();
            this.ButtonApplyNewAddress = new MaterialSkin.Controls.MaterialButton();
            this.ButtonApplyNewPhone = new MaterialSkin.Controls.MaterialButton();
            this.ButtonApplyNewAccessLevel = new MaterialSkin.Controls.MaterialButton();
            this.ButtonApplyNewUsername = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ListOfAccessLevels
            // 
            this.ListOfAccessLevels.AutoResize = false;
            this.ListOfAccessLevels.BackColor = System.Drawing.Color.White;
            this.ListOfAccessLevels.Depth = 0;
            this.ListOfAccessLevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListOfAccessLevels.DropDownHeight = 292;
            this.ListOfAccessLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOfAccessLevels.DropDownWidth = 121;
            this.ListOfAccessLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ListOfAccessLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListOfAccessLevels.FormattingEnabled = true;
            this.ListOfAccessLevels.IntegralHeight = false;
            this.ListOfAccessLevels.ItemHeight = 29;
            this.ListOfAccessLevels.Location = new System.Drawing.Point(133, 301);
            this.ListOfAccessLevels.MaxDropDownItems = 10;
            this.ListOfAccessLevels.MouseState = MaterialSkin.MouseState.OUT;
            this.ListOfAccessLevels.Name = "ListOfAccessLevels";
            this.ListOfAccessLevels.Size = new System.Drawing.Size(144, 35);
            this.ListOfAccessLevels.StartIndex = 0;
            this.ListOfAccessLevels.TabIndex = 64;
            this.ListOfAccessLevels.UseAccent = false;
            this.ListOfAccessLevels.UseTallSize = false;
            // 
            // LabelAccessLevel
            // 
            this.LabelAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAccessLevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccessLevel.ForeColor = System.Drawing.Color.Black;
            this.LabelAccessLevel.Location = new System.Drawing.Point(10, 301);
            this.LabelAccessLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAccessLevel.Name = "LabelAccessLevel";
            this.LabelAccessLevel.Size = new System.Drawing.Size(118, 23);
            this.LabelAccessLevel.TabIndex = 63;
            this.LabelAccessLevel.Text = "New Access Level:";
            this.LabelAccessLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.AcceptsTab = true;
            this.TextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAddress.Location = new System.Drawing.Point(121, 221);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxAddress.MaxLength = 25;
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(156, 23);
            this.TextBoxAddress.TabIndex = 46;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.AcceptsTab = true;
            this.TextBoxLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxLastName.Location = new System.Drawing.Point(121, 192);
            this.TextBoxLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxLastName.MaxLength = 20;
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(156, 23);
            this.TextBoxLastName.TabIndex = 45;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.AcceptsTab = true;
            this.TextBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFirstName.Location = new System.Drawing.Point(121, 161);
            this.TextBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxFirstName.MaxLength = 20;
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(156, 23);
            this.TextBoxFirstName.TabIndex = 44;
            // 
            // LabelAddress
            // 
            this.LabelAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.ForeColor = System.Drawing.Color.Black;
            this.LabelAddress.Location = new System.Drawing.Point(10, 219);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(105, 23);
            this.LabelAddress.TabIndex = 62;
            this.LabelAddress.Text = "New Address:";
            this.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonReturnDash
            // 
            this.ButtonReturnDash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonReturnDash.AutoSize = false;
            this.ButtonReturnDash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonReturnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonReturnDash.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonReturnDash.Depth = 0;
            this.ButtonReturnDash.HighEmphasis = true;
            this.ButtonReturnDash.Icon = null;
            this.ButtonReturnDash.Location = new System.Drawing.Point(13, 342);
            this.ButtonReturnDash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonReturnDash.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReturnDash.Name = "ButtonReturnDash";
            this.ButtonReturnDash.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonReturnDash.Size = new System.Drawing.Size(334, 114);
            this.ButtonReturnDash.TabIndex = 51;
            this.ButtonReturnDash.Text = "Dashboard";
            this.ButtonReturnDash.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonReturnDash.UseAccentColor = false;
            this.ButtonReturnDash.UseVisualStyleBackColor = false;
            this.ButtonReturnDash.Click += new System.EventHandler(this.ButtonReturnDash_Click);
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.LabelPhoneNumber.Location = new System.Drawing.Point(10, 251);
            this.LabelPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(86, 23);
            this.LabelPhoneNumber.TabIndex = 55;
            this.LabelPhoneNumber.Text = "New Phone:";
            this.LabelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelUsername
            // 
            this.LabelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.Black;
            this.LabelUsername.Location = new System.Drawing.Point(10, 134);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(105, 21);
            this.LabelUsername.TabIndex = 54;
            this.LabelUsername.Text = "New Username:";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeadingText
            // 
            this.HeadingText.BackColor = System.Drawing.Color.Transparent;
            this.HeadingText.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.HeadingText.ForeColor = System.Drawing.Color.Black;
            this.HeadingText.Location = new System.Drawing.Point(6, 2);
            this.HeadingText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeadingText.Name = "HeadingText";
            this.HeadingText.Size = new System.Drawing.Size(341, 77);
            this.HeadingText.TabIndex = 53;
            this.HeadingText.Text = "Edit User";
            this.HeadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.White;
            this.ToolTip.IsBalloon = true;
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.AcceptsTab = true;
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(121, 251);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxPhoneNumber.MaxLength = 11;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(156, 23);
            this.TextBoxPhoneNumber.TabIndex = 47;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AcceptsTab = true;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.Location = new System.Drawing.Point(120, 132);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxUsername.MaxLength = 20;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(157, 23);
            this.TextBoxUsername.TabIndex = 48;
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
            this.UnusedLink.Location = new System.Drawing.Point(19, 342);
            this.UnusedLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnusedLink.Name = "UnusedLink";
            this.UnusedLink.Size = new System.Drawing.Size(13, 19);
            this.UnusedLink.TabIndex = 52;
            this.UnusedLink.TabStop = true;
            this.UnusedLink.Text = " ";
            this.UnusedLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UnusedLink.Visible = false;
            this.UnusedLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFirstName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.ForeColor = System.Drawing.Color.Black;
            this.LabelFirstName.Location = new System.Drawing.Point(10, 161);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(105, 23);
            this.LabelFirstName.TabIndex = 60;
            this.LabelFirstName.Text = "New First Name:";
            this.LabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelLastName
            // 
            this.LabelLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.ForeColor = System.Drawing.Color.Black;
            this.LabelLastName.Location = new System.Drawing.Point(10, 192);
            this.LabelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(105, 23);
            this.LabelLastName.TabIndex = 61;
            this.LabelLastName.Text = "New Last Name:";
            this.LabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextUserToChange
            // 
            this.TextUserToChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextUserToChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserToChange.ForeColor = System.Drawing.Color.Black;
            this.TextUserToChange.Location = new System.Drawing.Point(10, 90);
            this.TextUserToChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextUserToChange.Name = "TextUserToChange";
            this.TextUserToChange.Size = new System.Drawing.Size(105, 23);
            this.TextUserToChange.TabIndex = 65;
            this.TextUserToChange.Text = "User to Change:";
            this.TextUserToChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListOfUsers
            // 
            this.ListOfUsers.AutoResize = false;
            this.ListOfUsers.BackColor = System.Drawing.Color.White;
            this.ListOfUsers.Depth = 0;
            this.ListOfUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListOfUsers.DropDownHeight = 292;
            this.ListOfUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOfUsers.DropDownWidth = 121;
            this.ListOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ListOfUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListOfUsers.FormattingEnabled = true;
            this.ListOfUsers.IntegralHeight = false;
            this.ListOfUsers.ItemHeight = 29;
            this.ListOfUsers.Location = new System.Drawing.Point(120, 90);
            this.ListOfUsers.MaxDropDownItems = 10;
            this.ListOfUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.ListOfUsers.Name = "ListOfUsers";
            this.ListOfUsers.Size = new System.Drawing.Size(228, 35);
            this.ListOfUsers.StartIndex = 0;
            this.ListOfUsers.TabIndex = 66;
            this.ListOfUsers.UseAccent = false;
            this.ListOfUsers.UseTallSize = false;
            // 
            // ButtonApplyFirstName
            // 
            this.ButtonApplyFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApplyFirstName.AutoSize = false;
            this.ButtonApplyFirstName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonApplyFirstName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyFirstName.Depth = 0;
            this.ButtonApplyFirstName.HighEmphasis = true;
            this.ButtonApplyFirstName.Icon = null;
            this.ButtonApplyFirstName.Location = new System.Drawing.Point(285, 161);
            this.ButtonApplyFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonApplyFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyFirstName.Name = "ButtonApplyFirstName";
            this.ButtonApplyFirstName.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyFirstName.Size = new System.Drawing.Size(62, 23);
            this.ButtonApplyFirstName.TabIndex = 67;
            this.ButtonApplyFirstName.Text = "Apply";
            this.ButtonApplyFirstName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyFirstName.UseAccentColor = false;
            this.ButtonApplyFirstName.UseVisualStyleBackColor = false;
            this.ButtonApplyFirstName.Click += new System.EventHandler(this.ButtonApplyFirstName_Click);
            // 
            // ButtonApplyLastName
            // 
            this.ButtonApplyLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApplyLastName.AutoSize = false;
            this.ButtonApplyLastName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonApplyLastName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyLastName.Depth = 0;
            this.ButtonApplyLastName.HighEmphasis = true;
            this.ButtonApplyLastName.Icon = null;
            this.ButtonApplyLastName.Location = new System.Drawing.Point(285, 192);
            this.ButtonApplyLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonApplyLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyLastName.Name = "ButtonApplyLastName";
            this.ButtonApplyLastName.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyLastName.Size = new System.Drawing.Size(62, 23);
            this.ButtonApplyLastName.TabIndex = 68;
            this.ButtonApplyLastName.Text = "Apply";
            this.ButtonApplyLastName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyLastName.UseAccentColor = false;
            this.ButtonApplyLastName.UseVisualStyleBackColor = false;
            this.ButtonApplyLastName.Click += new System.EventHandler(this.ButtonApplyLastName_Click);
            // 
            // ButtonApplyNewAddress
            // 
            this.ButtonApplyNewAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApplyNewAddress.AutoSize = false;
            this.ButtonApplyNewAddress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyNewAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonApplyNewAddress.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyNewAddress.Depth = 0;
            this.ButtonApplyNewAddress.HighEmphasis = true;
            this.ButtonApplyNewAddress.Icon = null;
            this.ButtonApplyNewAddress.Location = new System.Drawing.Point(285, 222);
            this.ButtonApplyNewAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonApplyNewAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyNewAddress.Name = "ButtonApplyNewAddress";
            this.ButtonApplyNewAddress.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyNewAddress.Size = new System.Drawing.Size(62, 23);
            this.ButtonApplyNewAddress.TabIndex = 69;
            this.ButtonApplyNewAddress.Text = "Apply";
            this.ButtonApplyNewAddress.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyNewAddress.UseAccentColor = false;
            this.ButtonApplyNewAddress.UseVisualStyleBackColor = false;
            this.ButtonApplyNewAddress.Click += new System.EventHandler(this.ButtonApplyNewAddress_Click);
            // 
            // ButtonApplyNewPhone
            // 
            this.ButtonApplyNewPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApplyNewPhone.AutoSize = false;
            this.ButtonApplyNewPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyNewPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonApplyNewPhone.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyNewPhone.Depth = 0;
            this.ButtonApplyNewPhone.HighEmphasis = true;
            this.ButtonApplyNewPhone.Icon = null;
            this.ButtonApplyNewPhone.Location = new System.Drawing.Point(285, 251);
            this.ButtonApplyNewPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonApplyNewPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyNewPhone.Name = "ButtonApplyNewPhone";
            this.ButtonApplyNewPhone.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyNewPhone.Size = new System.Drawing.Size(62, 23);
            this.ButtonApplyNewPhone.TabIndex = 70;
            this.ButtonApplyNewPhone.Text = "Apply";
            this.ButtonApplyNewPhone.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyNewPhone.UseAccentColor = false;
            this.ButtonApplyNewPhone.UseVisualStyleBackColor = false;
            this.ButtonApplyNewPhone.Click += new System.EventHandler(this.ButtonApplyNewPhone_Click);
            // 
            // ButtonApplyNewAccessLevel
            // 
            this.ButtonApplyNewAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApplyNewAccessLevel.AutoSize = false;
            this.ButtonApplyNewAccessLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyNewAccessLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonApplyNewAccessLevel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyNewAccessLevel.Depth = 0;
            this.ButtonApplyNewAccessLevel.HighEmphasis = true;
            this.ButtonApplyNewAccessLevel.Icon = null;
            this.ButtonApplyNewAccessLevel.Location = new System.Drawing.Point(284, 301);
            this.ButtonApplyNewAccessLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonApplyNewAccessLevel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyNewAccessLevel.Name = "ButtonApplyNewAccessLevel";
            this.ButtonApplyNewAccessLevel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyNewAccessLevel.Size = new System.Drawing.Size(62, 35);
            this.ButtonApplyNewAccessLevel.TabIndex = 71;
            this.ButtonApplyNewAccessLevel.Text = "Apply";
            this.ButtonApplyNewAccessLevel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyNewAccessLevel.UseAccentColor = false;
            this.ButtonApplyNewAccessLevel.UseVisualStyleBackColor = false;
            this.ButtonApplyNewAccessLevel.Click += new System.EventHandler(this.ButtonApplyNewAccessLevel_Click);
            // 
            // ButtonApplyNewUsername
            // 
            this.ButtonApplyNewUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonApplyNewUsername.AutoSize = false;
            this.ButtonApplyNewUsername.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonApplyNewUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ButtonApplyNewUsername.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonApplyNewUsername.Depth = 0;
            this.ButtonApplyNewUsername.HighEmphasis = true;
            this.ButtonApplyNewUsername.Icon = null;
            this.ButtonApplyNewUsername.Location = new System.Drawing.Point(285, 131);
            this.ButtonApplyNewUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonApplyNewUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonApplyNewUsername.Name = "ButtonApplyNewUsername";
            this.ButtonApplyNewUsername.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonApplyNewUsername.Size = new System.Drawing.Size(62, 23);
            this.ButtonApplyNewUsername.TabIndex = 72;
            this.ButtonApplyNewUsername.Text = "Apply";
            this.ButtonApplyNewUsername.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonApplyNewUsername.UseAccentColor = false;
            this.ButtonApplyNewUsername.UseVisualStyleBackColor = false;
            this.ButtonApplyNewUsername.Click += new System.EventHandler(this.ButtonApplyNewUsername_Click);
            // 
            // FormAccountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 468);
            this.Controls.Add(this.ButtonApplyNewUsername);
            this.Controls.Add(this.ButtonApplyNewAccessLevel);
            this.Controls.Add(this.ButtonApplyNewPhone);
            this.Controls.Add(this.ButtonApplyNewAddress);
            this.Controls.Add(this.ButtonApplyLastName);
            this.Controls.Add(this.ButtonApplyFirstName);
            this.Controls.Add(this.ListOfUsers);
            this.Controls.Add(this.TextUserToChange);
            this.Controls.Add(this.ListOfAccessLevels);
            this.Controls.Add(this.LabelAccessLevel);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.ButtonReturnDash);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.HeadingText);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.UnusedLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccountEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.FormAccountEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox ListOfAccessLevels;
        private System.Windows.Forms.Label LabelAccessLevel;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelAddress;
        private MaterialSkin.Controls.MaterialButton ButtonReturnDash;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label HeadingText;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.LinkLabel UnusedLink;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label TextUserToChange;
        private MaterialSkin.Controls.MaterialComboBox ListOfUsers;
        private MaterialSkin.Controls.MaterialButton ButtonApplyFirstName;
        private MaterialSkin.Controls.MaterialButton ButtonApplyLastName;
        private MaterialSkin.Controls.MaterialButton ButtonApplyNewAddress;
        private MaterialSkin.Controls.MaterialButton ButtonApplyNewPhone;
        private MaterialSkin.Controls.MaterialButton ButtonApplyNewAccessLevel;
        private MaterialSkin.Controls.MaterialButton ButtonApplyNewUsername;
    }
}