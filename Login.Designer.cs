namespace HOTEL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            PassWord1 = new Bunifu.UI.WinForms.BunifuTextBox();
            username = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 27);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 375);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PassWord1
            // 
            PassWord1.AcceptsReturn = false;
            PassWord1.AcceptsTab = false;
            PassWord1.AnimationSpeed = 200;
            PassWord1.AutoCompleteMode = AutoCompleteMode.None;
            PassWord1.AutoCompleteSource = AutoCompleteSource.None;
            PassWord1.AutoSizeHeight = true;
            PassWord1.BackColor = Color.Navy;
            PassWord1.BackgroundImage = (Image)resources.GetObject("PassWord1.BackgroundImage");
            PassWord1.BorderColorActive = Color.DodgerBlue;
            PassWord1.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            PassWord1.BorderColorHover = Color.FromArgb(105, 181, 255);
            PassWord1.BorderColorIdle = Color.Silver;
            PassWord1.BorderRadius = 20;
            PassWord1.BorderThickness = 0;
            PassWord1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            PassWord1.CharacterCasing = CharacterCasing.Normal;
            PassWord1.Cursor = Cursors.AppStarting;
            PassWord1.DefaultFont = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PassWord1.DefaultText = "";
            PassWord1.FillColor = Color.Navy;
            PassWord1.ForeColor = Color.White;
            PassWord1.HideSelection = true;
            PassWord1.IconLeft = null;
            PassWord1.IconLeftCursor = Cursors.IBeam;
            PassWord1.IconPadding = 2;
            PassWord1.IconRight = (Image)resources.GetObject("PassWord1.IconRight");
            PassWord1.IconRightCursor = Cursors.IBeam;
            PassWord1.Location = new Point(66, 298);
            PassWord1.MaxLength = 32767;
            PassWord1.MinimumSize = new Size(1, 1);
            PassWord1.Modified = false;
            PassWord1.Multiline = false;
            PassWord1.Name = "PassWord1";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            PassWord1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            PassWord1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            PassWord1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.Navy;
            stateProperties4.ForeColor = Color.White;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            PassWord1.OnIdleState = stateProperties4;
            PassWord1.Padding = new Padding(3);
            PassWord1.PasswordChar = '\0';
            PassWord1.PlaceholderForeColor = Color.White;
            PassWord1.PlaceholderText = "password:";
            PassWord1.ReadOnly = false;
            PassWord1.ScrollBars = ScrollBars.None;
            PassWord1.SelectedText = "";
            PassWord1.SelectionLength = 0;
            PassWord1.SelectionStart = 0;
            PassWord1.ShortcutsEnabled = true;
            PassWord1.Size = new Size(320, 40);
            PassWord1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            PassWord1.TabIndex = 1;
            PassWord1.TextAlign = HorizontalAlignment.Left;
            PassWord1.TextMarginBottom = 0;
            PassWord1.TextMarginLeft = 3;
            PassWord1.TextMarginTop = 1;
            PassWord1.TextPlaceholder = "password:";
            PassWord1.UseSystemPasswordChar = true;
            PassWord1.WordWrap = true;
            // 
            // username
            // 
            username.AcceptsReturn = false;
            username.AcceptsTab = false;
            username.AnimationSpeed = 200;
            username.AutoCompleteMode = AutoCompleteMode.None;
            username.AutoCompleteSource = AutoCompleteSource.None;
            username.AutoSizeHeight = true;
            username.BackColor = Color.Navy;
            username.BackgroundImage = (Image)resources.GetObject("username.BackgroundImage");
            username.BorderColorActive = Color.DodgerBlue;
            username.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            username.BorderColorHover = Color.FromArgb(105, 181, 255);
            username.BorderColorIdle = Color.Silver;
            username.BorderRadius = 20;
            username.BorderThickness = 0;
            username.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            username.CharacterCasing = CharacterCasing.Normal;
            username.Cursor = Cursors.AppStarting;
            username.DefaultFont = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            username.DefaultText = "";
            username.FillColor = Color.Navy;
            username.ForeColor = Color.White;
            username.HideSelection = true;
            username.IconLeft = null;
            username.IconLeftCursor = Cursors.IBeam;
            username.IconPadding = 2;
            username.IconRight = (Image)resources.GetObject("username.IconRight");
            username.IconRightCursor = Cursors.IBeam;
            username.Location = new Point(66, 230);
            username.MaxLength = 32767;
            username.MinimumSize = new Size(1, 1);
            username.Modified = false;
            username.Multiline = false;
            username.Name = "username";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Transparent;
            stateProperties5.ForeColor = Color.Transparent;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            username.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(204, 204, 204);
            stateProperties6.ForeColor = SystemColors.GrayText;
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            username.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Transparent;
            stateProperties7.ForeColor = Color.Transparent;
            stateProperties7.PlaceholderForeColor = Color.Transparent;
            username.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.Navy;
            stateProperties8.ForeColor = Color.White;
            stateProperties8.PlaceholderForeColor = Color.Transparent;
            username.OnIdleState = stateProperties8;
            username.Padding = new Padding(3);
            username.PasswordChar = '\0';
            username.PlaceholderForeColor = Color.White;
            username.PlaceholderText = "user name:";
            username.ReadOnly = false;
            username.ScrollBars = ScrollBars.None;
            username.SelectedText = "";
            username.SelectionLength = 0;
            username.SelectionStart = 0;
            username.ShortcutsEnabled = true;
            username.Size = new Size(320, 40);
            username.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            username.TabIndex = 0;
            username.TextAlign = HorizontalAlignment.Left;
            username.TextMarginBottom = 0;
            username.TextMarginLeft = 3;
            username.TextMarginTop = 1;
            username.TextPlaceholder = "user name:";
            username.UseSystemPasswordChar = false;
            username.WordWrap = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(463, 465);
            Controls.Add(username);
            Controls.Add(PassWord1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.White;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuTextBox roomphone;
        private Bunifu.UI.WinForms.BunifuTextBox PassWord1;
        private Bunifu.UI.WinForms.BunifuTextBox username;
    }
}