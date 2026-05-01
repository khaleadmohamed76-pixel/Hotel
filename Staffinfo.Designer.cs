using Bunifu.UI.WinForms;

namespace HOTEL
{
    partial class Staffinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staffinfo));
            BunifuTextBox.StateProperties stateProperties1 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties2 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties3 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties4 = new BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BunifuTextBox.StateProperties stateProperties5 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties6 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties7 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties8 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties9 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties10 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties11 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties12 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties13 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties14 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties15 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties16 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties17 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties18 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties19 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties20 = new BunifuTextBox.StateProperties();
            panel1 = new Panel();
            DateIdI = new Label();
            label1 = new Label();
            stafftbl = new BunifuTextBox();
            staffgerdercb = new ComboBox();
            staffGridview = new DataGridView();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            staffclean = new BunifuTextBox();
            button1 = new Button();
            Deletebtn = new Button();
            AddBtn = new Button();
            staffphone = new BunifuTextBox();
            staffnametbl = new BunifuTextBox();
            staffpasswordtn = new BunifuTextBox();
            back = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)staffGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(DateIdI);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 116);
            panel1.TabIndex = 1;
            // 
            // DateIdI
            // 
            DateIdI.AutoSize = true;
            DateIdI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateIdI.Location = new Point(971, 86);
            DateIdI.Name = "DateIdI";
            DateIdI.Size = new Size(58, 30);
            DateIdI.TabIndex = 2;
            DateIdI.Text = "Date";
            //DateIdI.Click += DateIdI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 36);
            label1.Name = "label1";
            label1.Size = new Size(270, 50);
            label1.TabIndex = 1;
            label1.Text = "Staff Information";
            //label1.Click += label1_Click;
            // 
            // stafftbl
            // 
            stafftbl.AcceptsReturn = false;
            stafftbl.AcceptsTab = false;
            stafftbl.AnimationSpeed = 200;
            stafftbl.AutoCompleteMode = AutoCompleteMode.None;
            stafftbl.AutoCompleteSource = AutoCompleteSource.None;
            stafftbl.AutoSizeHeight = true;
            stafftbl.BackColor = Color.Transparent;
            stafftbl.BackgroundImage = (Image)resources.GetObject("stafftbl.BackgroundImage");
            stafftbl.BorderColorActive = Color.DodgerBlue;
            stafftbl.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            stafftbl.BorderColorHover = Color.FromArgb(105, 181, 255);
            stafftbl.BorderColorIdle = Color.Silver;
            stafftbl.BorderRadius = 20;
            stafftbl.BorderThickness = 0;
            stafftbl.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            stafftbl.CharacterCasing = CharacterCasing.Normal;
            stafftbl.Cursor = Cursors.AppStarting;
            stafftbl.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stafftbl.DefaultText = "";
            stafftbl.FillColor = Color.White;
            stafftbl.ForeColor = Color.DarkBlue;
            stafftbl.HideSelection = true;
            stafftbl.IconLeft = null;
            stafftbl.IconLeftCursor = Cursors.IBeam;
            stafftbl.IconPadding = 10;
            stafftbl.IconRight = null;
            stafftbl.IconRightCursor = Cursors.IBeam;
            stafftbl.Location = new Point(27, 221);
            stafftbl.MaxLength = 32767;
            stafftbl.MinimumSize = new Size(1, 1);
            stafftbl.Modified = false;
            stafftbl.Multiline = false;
            stafftbl.Name = "stafftbl";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            stafftbl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            stafftbl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            stafftbl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.DarkBlue;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            stafftbl.OnIdleState = stateProperties4;
            stafftbl.Padding = new Padding(3);
            stafftbl.PasswordChar = '\0';
            stafftbl.PlaceholderForeColor = Color.DodgerBlue;
            stafftbl.PlaceholderText = "Staff ID ";
            stafftbl.ReadOnly = false;
            stafftbl.ScrollBars = ScrollBars.None;
            stafftbl.SelectedText = "";
            stafftbl.SelectionLength = 0;
            stafftbl.SelectionStart = 0;
            stafftbl.ShortcutsEnabled = true;
            stafftbl.Size = new Size(238, 40);
            stafftbl.Style = BunifuTextBox._Style.Bunifu;
            stafftbl.TabIndex = 16;
            stafftbl.TextAlign = HorizontalAlignment.Left;
            stafftbl.TextMarginBottom = 0;
            stafftbl.TextMarginLeft = 3;
            stafftbl.TextMarginTop = 1;
            stafftbl.TextPlaceholder = "Staff ID ";
            stafftbl.UseSystemPasswordChar = false;
            stafftbl.WordWrap = true;
            //stafftbl.TextChanged += stafftbl_TextChanged;
            //stafftbl.KeyPress += stafftbl_KeyPress;
            // 
            // staffgerdercb
            // 
            staffgerdercb.FlatStyle = FlatStyle.Flat;
            staffgerdercb.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffgerdercb.ForeColor = Color.DodgerBlue;
            staffgerdercb.FormattingEnabled = true;
            staffgerdercb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            staffgerdercb.Location = new Point(27, 585);
            staffgerdercb.Name = "staffgerdercb";
            staffgerdercb.Size = new Size(238, 31);
            staffgerdercb.TabIndex = 19;
            staffgerdercb.Text = "Gender";
            // 
            // staffGridview
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            staffGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffGridview.BackgroundColor = SystemColors.ButtonHighlight;
            staffGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            staffGridview.DefaultCellStyle = dataGridViewCellStyle2;
            staffGridview.Location = new Point(316, 171);
            staffGridview.Name = "staffGridview";
            staffGridview.ReadOnly = true;
            staffGridview.Size = new Size(771, 644);
            staffGridview.TabIndex = 20;
            //staffGridview.CellClick += staffGridview_CellClick;
            staffGridview.CellContentClick += staffGridview_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(985, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            //pictureBox1.Click += pictureBox1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(875, 122);
            button4.Name = "button4";
            button4.Size = new Size(104, 40);
            button4.TabIndex = 24;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            //button4.Click += button4_Click;
            // 
            // staffclean
            // 
            staffclean.AcceptsReturn = false;
            staffclean.AcceptsTab = false;
            staffclean.AnimationSpeed = 200;
            staffclean.AutoCompleteMode = AutoCompleteMode.None;
            staffclean.AutoCompleteSource = AutoCompleteSource.None;
            staffclean.AutoSizeHeight = true;
            staffclean.BackColor = Color.Transparent;
            staffclean.BackgroundImage = (Image)resources.GetObject("staffclean.BackgroundImage");
            staffclean.BorderColorActive = Color.DodgerBlue;
            staffclean.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            staffclean.BorderColorHover = Color.FromArgb(105, 181, 255);
            staffclean.BorderColorIdle = Color.Silver;
            staffclean.BorderRadius = 20;
            staffclean.BorderThickness = 0;
            staffclean.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            staffclean.CharacterCasing = CharacterCasing.Normal;
            staffclean.Cursor = Cursors.AppStarting;
            staffclean.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffclean.DefaultText = "";
            staffclean.FillColor = Color.White;
            staffclean.ForeColor = Color.DarkBlue;
            staffclean.HideSelection = true;
            staffclean.IconLeft = null;
            staffclean.IconLeftCursor = Cursors.IBeam;
            staffclean.IconPadding = 10;
            staffclean.IconRight = null;
            staffclean.IconRightCursor = Cursors.IBeam;
            staffclean.Location = new Point(595, 122);
            staffclean.MaxLength = 32767;
            staffclean.MinimumSize = new Size(1, 1);
            staffclean.Modified = false;
            staffclean.Multiline = false;
            staffclean.Name = "staffclean";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            staffclean.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            staffclean.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            staffclean.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.DarkBlue;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            staffclean.OnIdleState = stateProperties8;
            staffclean.Padding = new Padding(3);
            staffclean.PasswordChar = '\0';
            staffclean.PlaceholderForeColor = Color.DodgerBlue;
            staffclean.PlaceholderText = "Staff Search";
            staffclean.ReadOnly = false;
            staffclean.ScrollBars = ScrollBars.None;
            staffclean.SelectedText = "";
            staffclean.SelectionLength = 0;
            staffclean.SelectionStart = 0;
            staffclean.ShortcutsEnabled = true;
            staffclean.Size = new Size(260, 40);
            staffclean.Style = BunifuTextBox._Style.Bunifu;
            staffclean.TabIndex = 26;
            staffclean.TextAlign = HorizontalAlignment.Left;
            staffclean.TextMarginBottom = 0;
            staffclean.TextMarginLeft = 3;
            staffclean.TextMarginTop = 1;
            staffclean.TextPlaceholder = "Staff Search";
            staffclean.UseSystemPasswordChar = false;
            staffclean.WordWrap = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(101, 652);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 29;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.FlatAppearance.BorderSize = 0;
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.DodgerBlue;
            Deletebtn.Location = new Point(182, 652);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(76, 43);
            Deletebtn.TabIndex = 28;
            Deletebtn.Text = "DELETE";
            Deletebtn.UseVisualStyleBackColor = true;
            //Deletebtn.Click += Deletebtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.DodgerBlue;
            AddBtn.Location = new Point(20, 652);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 43);
            AddBtn.TabIndex = 27;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // staffphone
            // 
            staffphone.AcceptsReturn = false;
            staffphone.AcceptsTab = false;
            staffphone.AnimationSpeed = 200;
            staffphone.AutoCompleteMode = AutoCompleteMode.None;
            staffphone.AutoCompleteSource = AutoCompleteSource.None;
            staffphone.AutoSizeHeight = true;
            staffphone.BackColor = Color.White;
            staffphone.BackgroundImage = (Image)resources.GetObject("staffphone.BackgroundImage");
            staffphone.BorderColorActive = Color.DodgerBlue;
            staffphone.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            staffphone.BorderColorHover = Color.FromArgb(105, 181, 255);
            staffphone.BorderColorIdle = Color.Silver;
            staffphone.BorderRadius = 20;
            staffphone.BorderThickness = 0;
            staffphone.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            staffphone.CharacterCasing = CharacterCasing.Normal;
            staffphone.Cursor = Cursors.AppStarting;
            staffphone.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffphone.DefaultText = "";
            staffphone.FillColor = Color.White;
            staffphone.ForeColor = Color.DarkBlue;
            staffphone.HideSelection = true;
            staffphone.IconLeft = null;
            staffphone.IconLeftCursor = Cursors.IBeam;
            staffphone.IconPadding = 10;
            staffphone.IconRight = null;
            staffphone.IconRightCursor = Cursors.IBeam;
            staffphone.Location = new Point(27, 409);
            staffphone.MaxLength = 32767;
            staffphone.MinimumSize = new Size(1, 1);
            staffphone.Modified = false;
            staffphone.Multiline = false;
            staffphone.Name = "staffphone";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            staffphone.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            staffphone.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            staffphone.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.DarkBlue;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            staffphone.OnIdleState = stateProperties12;
            staffphone.Padding = new Padding(3);
            staffphone.PasswordChar = '\0';
            staffphone.PlaceholderForeColor = Color.DodgerBlue;
            staffphone.PlaceholderText = "staff Num";
            staffphone.ReadOnly = false;
            staffphone.ScrollBars = ScrollBars.None;
            staffphone.SelectedText = "";
            staffphone.SelectionLength = 0;
            staffphone.SelectionStart = 0;
            staffphone.ShortcutsEnabled = true;
            staffphone.Size = new Size(238, 40);
            staffphone.Style = BunifuTextBox._Style.Bunifu;
            staffphone.TabIndex = 32;
            staffphone.TextAlign = HorizontalAlignment.Left;
            staffphone.TextMarginBottom = 0;
            staffphone.TextMarginLeft = 3;
            staffphone.TextMarginTop = 1;
            staffphone.TextPlaceholder = "staff Num";
            staffphone.UseSystemPasswordChar = false;
            staffphone.WordWrap = true;
            //staffphone.KeyPress += staffphone_KeyPress;
            // 
            // staffnametbl
            // 
            staffnametbl.AcceptsReturn = false;
            staffnametbl.AcceptsTab = false;
            staffnametbl.AnimationSpeed = 200;
            staffnametbl.AutoCompleteMode = AutoCompleteMode.None;
            staffnametbl.AutoCompleteSource = AutoCompleteSource.None;
            staffnametbl.AutoSizeHeight = true;
            staffnametbl.BackColor = Color.Transparent;
            staffnametbl.BackgroundImage = (Image)resources.GetObject("staffnametbl.BackgroundImage");
            staffnametbl.BorderColorActive = Color.DodgerBlue;
            staffnametbl.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            staffnametbl.BorderColorHover = Color.FromArgb(105, 181, 255);
            staffnametbl.BorderColorIdle = Color.Silver;
            staffnametbl.BorderRadius = 20;
            staffnametbl.BorderThickness = 0;
            staffnametbl.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            staffnametbl.CharacterCasing = CharacterCasing.Normal;
            staffnametbl.Cursor = Cursors.AppStarting;
            staffnametbl.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffnametbl.DefaultText = "";
            staffnametbl.FillColor = Color.White;
            staffnametbl.ForeColor = Color.FromArgb(0, 0, 192);
            staffnametbl.HideSelection = true;
            staffnametbl.IconLeft = null;
            staffnametbl.IconLeftCursor = Cursors.IBeam;
            staffnametbl.IconPadding = 10;
            staffnametbl.IconRight = null;
            staffnametbl.IconRightCursor = Cursors.IBeam;
            staffnametbl.Location = new Point(27, 315);
            staffnametbl.MaxLength = 32767;
            staffnametbl.MinimumSize = new Size(1, 1);
            staffnametbl.Modified = false;
            staffnametbl.Multiline = false;
            staffnametbl.Name = "staffnametbl";
            stateProperties13.BorderColor = Color.DodgerBlue;
            stateProperties13.FillColor = Color.Empty;
            stateProperties13.ForeColor = Color.Empty;
            stateProperties13.PlaceholderForeColor = Color.Empty;
            staffnametbl.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties14.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties14.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties14.PlaceholderForeColor = Color.DarkGray;
            staffnametbl.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties15.FillColor = Color.Empty;
            stateProperties15.ForeColor = Color.Empty;
            stateProperties15.PlaceholderForeColor = Color.Empty;
            staffnametbl.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = Color.Silver;
            stateProperties16.FillColor = Color.White;
            stateProperties16.ForeColor = Color.FromArgb(0, 0, 192);
            stateProperties16.PlaceholderForeColor = Color.Empty;
            staffnametbl.OnIdleState = stateProperties16;
            staffnametbl.Padding = new Padding(3);
            staffnametbl.PasswordChar = '\0';
            staffnametbl.PlaceholderForeColor = Color.DodgerBlue;
            staffnametbl.PlaceholderText = "Staff Name";
            staffnametbl.ReadOnly = false;
            staffnametbl.ScrollBars = ScrollBars.None;
            staffnametbl.SelectedText = "";
            staffnametbl.SelectionLength = 0;
            staffnametbl.SelectionStart = 0;
            staffnametbl.ShortcutsEnabled = true;
            staffnametbl.Size = new Size(238, 40);
            staffnametbl.Style = BunifuTextBox._Style.Bunifu;
            staffnametbl.TabIndex = 31;
            staffnametbl.TextAlign = HorizontalAlignment.Left;
            staffnametbl.TextMarginBottom = 0;
            staffnametbl.TextMarginLeft = 3;
            staffnametbl.TextMarginTop = 1;
            staffnametbl.TextPlaceholder = "Staff Name";
            staffnametbl.UseSystemPasswordChar = false;
            staffnametbl.WordWrap = true;
            staffnametbl.TextChanged += Staffnametbl_TextChanged;
            //staffnametbl.KeyPress += staffnametbl_KeyPress;
            // 
            // staffpasswordtn
            // 
            staffpasswordtn.AcceptsReturn = false;
            staffpasswordtn.AcceptsTab = false;
            staffpasswordtn.AnimationSpeed = 200;
            staffpasswordtn.AutoCompleteMode = AutoCompleteMode.None;
            staffpasswordtn.AutoCompleteSource = AutoCompleteSource.None;
            staffpasswordtn.AutoSizeHeight = true;
            staffpasswordtn.BackColor = Color.White;
            staffpasswordtn.BackgroundImage = (Image)resources.GetObject("staffpasswordtn.BackgroundImage");
            staffpasswordtn.BorderColorActive = Color.DodgerBlue;
            staffpasswordtn.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            staffpasswordtn.BorderColorHover = Color.FromArgb(105, 181, 255);
            staffpasswordtn.BorderColorIdle = Color.Silver;
            staffpasswordtn.BorderRadius = 20;
            staffpasswordtn.BorderThickness = 0;
            staffpasswordtn.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            staffpasswordtn.CharacterCasing = CharacterCasing.Normal;
            staffpasswordtn.Cursor = Cursors.AppStarting;
            staffpasswordtn.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            staffpasswordtn.DefaultText = "";
            staffpasswordtn.FillColor = Color.White;
            staffpasswordtn.ForeColor = Color.DarkBlue;
            staffpasswordtn.HideSelection = true;
            staffpasswordtn.IconLeft = null;
            staffpasswordtn.IconLeftCursor = Cursors.IBeam;
            staffpasswordtn.IconPadding = 10;
            staffpasswordtn.IconRight = null;
            staffpasswordtn.IconRightCursor = Cursors.IBeam;
            staffpasswordtn.Location = new Point(27, 493);
            staffpasswordtn.MaxLength = 32767;
            staffpasswordtn.MinimumSize = new Size(1, 1);
            staffpasswordtn.Modified = false;
            staffpasswordtn.Multiline = false;
            staffpasswordtn.Name = "staffpasswordtn";
            stateProperties17.BorderColor = Color.DodgerBlue;
            stateProperties17.FillColor = Color.Empty;
            stateProperties17.ForeColor = Color.Empty;
            stateProperties17.PlaceholderForeColor = Color.Empty;
            staffpasswordtn.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties18.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties18.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties18.PlaceholderForeColor = Color.DarkGray;
            staffpasswordtn.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties19.FillColor = Color.Empty;
            stateProperties19.ForeColor = Color.Empty;
            stateProperties19.PlaceholderForeColor = Color.Empty;
            staffpasswordtn.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = Color.Silver;
            stateProperties20.FillColor = Color.White;
            stateProperties20.ForeColor = Color.DarkBlue;
            stateProperties20.PlaceholderForeColor = Color.Empty;
            staffpasswordtn.OnIdleState = stateProperties20;
            staffpasswordtn.Padding = new Padding(3);
            staffpasswordtn.PasswordChar = '\0';
            staffpasswordtn.PlaceholderForeColor = Color.DodgerBlue;
            staffpasswordtn.PlaceholderText = "staff password";
            staffpasswordtn.ReadOnly = false;
            staffpasswordtn.ScrollBars = ScrollBars.None;
            staffpasswordtn.SelectedText = "";
            staffpasswordtn.SelectionLength = 0;
            staffpasswordtn.SelectionStart = 0;
            staffpasswordtn.ShortcutsEnabled = true;
            staffpasswordtn.Size = new Size(238, 40);
            staffpasswordtn.Style = BunifuTextBox._Style.Bunifu;
            staffpasswordtn.TabIndex = 33;
            staffpasswordtn.TextAlign = HorizontalAlignment.Left;
            staffpasswordtn.TextMarginBottom = 0;
            staffpasswordtn.TextMarginLeft = 3;
            staffpasswordtn.TextMarginTop = 1;
            staffpasswordtn.TextPlaceholder = "staff password";
            staffpasswordtn.UseSystemPasswordChar = false;
            staffpasswordtn.WordWrap = true;
            // 
            // back
            // 
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.ForeColor = Color.DodgerBlue;
            back.Location = new Point(92, 748);
            back.Name = "back";
            back.Size = new Size(75, 43);
            back.TabIndex = 34;
            back.Text = "BACK";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Staffinfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 827);
            Controls.Add(back);
            Controls.Add(staffpasswordtn);
            Controls.Add(staffphone);
            Controls.Add(staffnametbl);
            Controls.Add(button1);
            Controls.Add(Deletebtn);
            Controls.Add(AddBtn);
            Controls.Add(staffclean);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(staffGridview);
            Controls.Add(staffgerdercb);
            Controls.Add(panel1);
            Controls.Add(stafftbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Staffinfo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Staffinfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)staffGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void Staffnametbl_TextChanged(object sender, EventArgs e)
        {
           
        }





        #endregion

        private Panel panel1;
        private Label DateIdI;
        private Label label1;

        public BunifuTextBox Stafftphone { get; private set; }

        private Bunifu.UI.WinForms.BunifuTextBox staffphone;
        private Bunifu.UI.WinForms.BunifuTextBox staffnametbl;
        private Bunifu.UI.WinForms.BunifuTextBox stafftbl;
        private ComboBox staffgerdercb;
        private DataGridView staffGridview;
        private PictureBox pictureBox1;
        private Button button4;
        private Bunifu.UI.WinForms.BunifuTextBox staffclean;
        private Button button1;
        private Button Deletebtn;
        private Button AddBtn;
        private Bunifu.UI.WinForms.BunifuTextBox Cilentclean;
        private BunifuTextBox staffpasswordtn;
        private Button back;
        private System.Windows.Forms.Timer timer1;
    }
} 