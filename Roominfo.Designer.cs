namespace HOTEL
{
    partial class Roominfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roominfo));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            panel1 = new Panel();
            DaterIdI = new Label();
            label1 = new Label();
            roomtbl = new Bunifu.UI.WinForms.BunifuTextBox();
            FreeBtn = new Button();
            kryptonRadioButton1 = new Krypton.Toolkit.KryptonRadioButton();
            button1 = new Button();
            kryptonRadioButton2 = new Krypton.Toolkit.KryptonRadioButton();
            button2 = new Button();
            AddrBtn = new Button();
            button3 = new Button();
            Deleterbtn = new Button();
            backr = new Button();
            ROOMGridview = new DataGridView();
            Rooms = new Bunifu.UI.WinForms.BunifuTextBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            roomphone = new Bunifu.UI.WinForms.BunifuTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ROOMGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(DaterIdI);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 120);
            panel1.TabIndex = 2;
            // 
            // DaterIdI
            // 
            DaterIdI.AutoSize = true;
            DaterIdI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DaterIdI.Location = new Point(965, 83);
            DaterIdI.Name = "DaterIdI";
            DaterIdI.Size = new Size(58, 30);
            DaterIdI.TabIndex = 2;
            DaterIdI.Text = "Date";
            DaterIdI.Click += DaterIdI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 36);
            label1.Name = "label1";
            label1.Size = new Size(286, 50);
            label1.TabIndex = 1;
            label1.Text = "Room Information";
            // 
            // roomtbl
            // 
            roomtbl.AcceptsReturn = false;
            roomtbl.AcceptsTab = false;
            roomtbl.AnimationSpeed = 200;
            roomtbl.AutoCompleteMode = AutoCompleteMode.None;
            roomtbl.AutoCompleteSource = AutoCompleteSource.None;
            roomtbl.AutoSizeHeight = true;
            roomtbl.BackColor = Color.Transparent;
            roomtbl.BackgroundImage = (Image)resources.GetObject("roomtbl.BackgroundImage");
            roomtbl.BorderColorActive = Color.DodgerBlue;
            roomtbl.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            roomtbl.BorderColorHover = Color.FromArgb(105, 181, 255);
            roomtbl.BorderColorIdle = Color.Silver;
            roomtbl.BorderRadius = 20;
            roomtbl.BorderThickness = 0;
            roomtbl.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            roomtbl.CharacterCasing = CharacterCasing.Normal;
            roomtbl.Cursor = Cursors.AppStarting;
            roomtbl.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomtbl.DefaultText = "";
            roomtbl.FillColor = Color.White;
            roomtbl.ForeColor = Color.FromArgb(0, 0, 192);
            roomtbl.HideSelection = true;
            roomtbl.IconLeft = null;
            roomtbl.IconLeftCursor = Cursors.IBeam;
            roomtbl.IconPadding = 10;
            roomtbl.IconRight = null;
            roomtbl.IconRightCursor = Cursors.IBeam;
            roomtbl.Location = new Point(30, 222);
            roomtbl.MaxLength = 32767;
            roomtbl.MinimumSize = new Size(1, 1);
            roomtbl.Modified = false;
            roomtbl.Multiline = false;
            roomtbl.Name = "roomtbl";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            roomtbl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            roomtbl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            roomtbl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.FromArgb(0, 0, 192);
            stateProperties4.PlaceholderForeColor = Color.Empty;
            roomtbl.OnIdleState = stateProperties4;
            roomtbl.Padding = new Padding(3);
            roomtbl.PasswordChar = '\0';
            roomtbl.PlaceholderForeColor = Color.DodgerBlue;
            roomtbl.PlaceholderText = "Room Number";
            roomtbl.ReadOnly = false;
            roomtbl.ScrollBars = ScrollBars.None;
            roomtbl.SelectedText = "";
            roomtbl.SelectionLength = 0;
            roomtbl.SelectionStart = 0;
            roomtbl.ShortcutsEnabled = true;
            roomtbl.Size = new Size(238, 40);
            roomtbl.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            roomtbl.TabIndex = 33;
            roomtbl.TextAlign = HorizontalAlignment.Left;
            roomtbl.TextMarginBottom = 0;
            roomtbl.TextMarginLeft = 3;
            roomtbl.TextMarginTop = 1;
            roomtbl.TextPlaceholder = "Room Number";
            roomtbl.UseSystemPasswordChar = false;
            roomtbl.WordWrap = true;
            roomtbl.KeyPress += roomtbl_KeyPress;
            // 
            // FreeBtn
            // 
            FreeBtn.FlatAppearance.BorderSize = 0;
            FreeBtn.FlatStyle = FlatStyle.Flat;
            FreeBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FreeBtn.ForeColor = Color.DodgerBlue;
            FreeBtn.Location = new Point(30, 445);
            FreeBtn.Name = "FreeBtn";
            FreeBtn.Size = new Size(53, 43);
            FreeBtn.TabIndex = 35;
            FreeBtn.Text = "Free";
            FreeBtn.UseVisualStyleBackColor = true;
            // 
            // kryptonRadioButton1
            // 
            kryptonRadioButton1.Location = new Point(89, 454);
            kryptonRadioButton1.Name = "kryptonRadioButton1";
            kryptonRadioButton1.Size = new Size(18, 25);
            kryptonRadioButton1.TabIndex = 36;
            kryptonRadioButton1.Values.Text = "";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(113, 445);
            button1.Name = "button1";
            button1.Size = new Size(53, 43);
            button1.TabIndex = 37;
            button1.Text = "Yes";
            button1.UseVisualStyleBackColor = true;
            // 
            // kryptonRadioButton2
            // 
            kryptonRadioButton2.Location = new Point(173, 454);
            kryptonRadioButton2.Name = "kryptonRadioButton2";
            kryptonRadioButton2.Size = new Size(18, 25);
            kryptonRadioButton2.TabIndex = 38;
            kryptonRadioButton2.Values.Text = "";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(197, 445);
            button2.Name = "button2";
            button2.Size = new Size(53, 43);
            button2.TabIndex = 39;
            button2.Text = "NO";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddrBtn
            // 
            AddrBtn.FlatAppearance.BorderSize = 0;
            AddrBtn.FlatStyle = FlatStyle.Flat;
            AddrBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddrBtn.ForeColor = Color.DodgerBlue;
            AddrBtn.Location = new Point(31, 605);
            AddrBtn.Name = "AddrBtn";
            AddrBtn.Size = new Size(75, 43);
            AddrBtn.TabIndex = 40;
            AddrBtn.Text = "ADD";
            AddrBtn.UseVisualStyleBackColor = true;
            AddrBtn.Click += AddrBtn_Click;
            AddrBtn.KeyPress += AddrBtn_KeyPress;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(113, 605);
            button3.Name = "button3";
            button3.Size = new Size(75, 43);
            button3.TabIndex = 41;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Deleterbtn
            // 
            Deleterbtn.FlatAppearance.BorderSize = 0;
            Deleterbtn.FlatStyle = FlatStyle.Flat;
            Deleterbtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deleterbtn.ForeColor = Color.DodgerBlue;
            Deleterbtn.Location = new Point(206, 605);
            Deleterbtn.Name = "Deleterbtn";
            Deleterbtn.Size = new Size(76, 43);
            Deleterbtn.TabIndex = 42;
            Deleterbtn.Text = "DELETE";
            Deleterbtn.UseVisualStyleBackColor = true;
            Deleterbtn.Click += Deleterbtn_Click;
            // 
            // backr
            // 
            backr.FlatAppearance.BorderSize = 0;
            backr.FlatStyle = FlatStyle.Flat;
            backr.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backr.ForeColor = Color.DodgerBlue;
            backr.Location = new Point(113, 691);
            backr.Name = "backr";
            backr.Size = new Size(75, 43);
            backr.TabIndex = 43;
            backr.Text = "BACK";
            backr.UseVisualStyleBackColor = true;
            backr.Click += backr_Click;
            // 
            // ROOMGridview
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ROOMGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ROOMGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ROOMGridview.BackgroundColor = SystemColors.ButtonHighlight;
            ROOMGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ROOMGridview.DefaultCellStyle = dataGridViewCellStyle2;
            ROOMGridview.Location = new Point(314, 172);
            ROOMGridview.Name = "ROOMGridview";
            ROOMGridview.ReadOnly = true;
            ROOMGridview.Size = new Size(771, 643);
            ROOMGridview.TabIndex = 44;
            ROOMGridview.CellClick += ROOMGridview_CellClick;
            ROOMGridview.CellContentClick += staffGridview_CellContentClick;
            // 
            // Rooms
            // 
            Rooms.AcceptsReturn = false;
            Rooms.AcceptsTab = false;
            Rooms.AnimationSpeed = 200;
            Rooms.AutoCompleteMode = AutoCompleteMode.None;
            Rooms.AutoCompleteSource = AutoCompleteSource.None;
            Rooms.AutoSizeHeight = true;
            Rooms.BackColor = Color.Transparent;
            Rooms.BackgroundImage = (Image)resources.GetObject("Rooms.BackgroundImage");
            Rooms.BorderColorActive = Color.DodgerBlue;
            Rooms.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Rooms.BorderColorHover = Color.FromArgb(105, 181, 255);
            Rooms.BorderColorIdle = Color.Silver;
            Rooms.BorderRadius = 20;
            Rooms.BorderThickness = 0;
            Rooms.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            Rooms.CharacterCasing = CharacterCasing.Normal;
            Rooms.Cursor = Cursors.AppStarting;
            Rooms.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rooms.DefaultText = "";
            Rooms.FillColor = Color.White;
            Rooms.ForeColor = Color.DarkBlue;
            Rooms.HideSelection = true;
            Rooms.IconLeft = null;
            Rooms.IconLeftCursor = Cursors.IBeam;
            Rooms.IconPadding = 10;
            Rooms.IconRight = null;
            Rooms.IconRightCursor = Cursors.IBeam;
            Rooms.Location = new Point(587, 126);
            Rooms.MaxLength = 32767;
            Rooms.MinimumSize = new Size(1, 1);
            Rooms.Modified = false;
            Rooms.Multiline = false;
            Rooms.Name = "Rooms";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            Rooms.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            Rooms.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            Rooms.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.DarkBlue;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            Rooms.OnIdleState = stateProperties8;
            Rooms.Padding = new Padding(3);
            Rooms.PasswordChar = '\0';
            Rooms.PlaceholderForeColor = Color.DodgerBlue;
            Rooms.PlaceholderText = "Room Search";
            Rooms.ReadOnly = false;
            Rooms.ScrollBars = ScrollBars.None;
            Rooms.SelectedText = "";
            Rooms.SelectionLength = 0;
            Rooms.SelectionStart = 0;
            Rooms.ShortcutsEnabled = true;
            Rooms.Size = new Size(260, 40);
            Rooms.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Rooms.TabIndex = 47;
            Rooms.TextAlign = HorizontalAlignment.Left;
            Rooms.TextMarginBottom = 0;
            Rooms.TextMarginLeft = 3;
            Rooms.TextMarginTop = 1;
            Rooms.TextPlaceholder = "Room Search";
            Rooms.UseSystemPasswordChar = false;
            Rooms.WordWrap = true;
            Rooms.TextChanged += staffclean_TextChanged;
            Rooms.KeyPress += staffclean_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(977, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(867, 126);
            button4.Name = "button4";
            button4.Size = new Size(104, 40);
            button4.TabIndex = 45;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.KeyDown += button4_KeyDown;
            // 
            // roomphone
            // 
            roomphone.AcceptsReturn = false;
            roomphone.AcceptsTab = false;
            roomphone.AnimationSpeed = 200;
            roomphone.AutoCompleteMode = AutoCompleteMode.None;
            roomphone.AutoCompleteSource = AutoCompleteSource.None;
            roomphone.AutoSizeHeight = true;
            roomphone.BackColor = Color.Transparent;
            roomphone.BackgroundImage = (Image)resources.GetObject("roomphone.BackgroundImage");
            roomphone.BorderColorActive = Color.DodgerBlue;
            roomphone.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            roomphone.BorderColorHover = Color.FromArgb(105, 181, 255);
            roomphone.BorderColorIdle = Color.Silver;
            roomphone.BorderRadius = 20;
            roomphone.BorderThickness = 0;
            roomphone.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            roomphone.CharacterCasing = CharacterCasing.Normal;
            roomphone.Cursor = Cursors.AppStarting;
            roomphone.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomphone.DefaultText = "";
            roomphone.FillColor = Color.White;
            roomphone.ForeColor = Color.FromArgb(0, 0, 192);
            roomphone.HideSelection = true;
            roomphone.IconLeft = null;
            roomphone.IconLeftCursor = Cursors.IBeam;
            roomphone.IconPadding = 10;
            roomphone.IconRight = null;
            roomphone.IconRightCursor = Cursors.IBeam;
            roomphone.Location = new Point(30, 332);
            roomphone.MaxLength = 32767;
            roomphone.MinimumSize = new Size(1, 1);
            roomphone.Modified = false;
            roomphone.Multiline = false;
            roomphone.Name = "roomphone";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            roomphone.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            roomphone.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            roomphone.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.FromArgb(0, 0, 192);
            stateProperties12.PlaceholderForeColor = Color.Empty;
            roomphone.OnIdleState = stateProperties12;
            roomphone.Padding = new Padding(3);
            roomphone.PasswordChar = '\0';
            roomphone.PlaceholderForeColor = Color.DodgerBlue;
            roomphone.PlaceholderText = "Room Phone";
            roomphone.ReadOnly = false;
            roomphone.ScrollBars = ScrollBars.None;
            roomphone.SelectedText = "";
            roomphone.SelectionLength = 0;
            roomphone.SelectionStart = 0;
            roomphone.ShortcutsEnabled = true;
            roomphone.Size = new Size(238, 40);
            roomphone.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            roomphone.TabIndex = 48;
            roomphone.TextAlign = HorizontalAlignment.Left;
            roomphone.TextMarginBottom = 0;
            roomphone.TextMarginLeft = 3;
            roomphone.TextMarginTop = 1;
            roomphone.TextPlaceholder = "Room Phone";
            roomphone.UseSystemPasswordChar = false;
            roomphone.WordWrap = true;
            roomphone.TextChanged += roomphone_TextChanged;
            roomphone.KeyPress += roomphone_KeyPress;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Roominfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 827);
            Controls.Add(roomphone);
            Controls.Add(Rooms);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(ROOMGridview);
            Controls.Add(backr);
            Controls.Add(Deleterbtn);
            Controls.Add(button3);
            Controls.Add(AddrBtn);
            Controls.Add(button2);
            Controls.Add(kryptonRadioButton2);
            Controls.Add(button1);
            Controls.Add(kryptonRadioButton1);
            Controls.Add(FreeBtn);
            Controls.Add(roomtbl);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Roominfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roominfo";
            Load += Roominfo_Load;
            KeyPress += Roominfo_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ROOMGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label DaterIdI;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox staffphone;
        private Bunifu.UI.WinForms.BunifuTextBox roomtbl;
        private Button FreeBtn;
        private Krypton.Toolkit.KryptonRadioButton kryptonRadioButton1;
        private Button button1;
        private Krypton.Toolkit.KryptonRadioButton kryptonRadioButton2;
        private Button button2;
        private Button AddrBtn;
        private Button button3;
        private Button Deleterbtn;
        private Button backr;
        private DataGridView ROOMGridview;
        private Bunifu.UI.WinForms.BunifuTextBox Rooms;
        private PictureBox pictureBox1;
        private Button button4;
        private Bunifu.UI.WinForms.BunifuTextBox roomphone;
        private System.Windows.Forms.Timer timer1;
    }
}