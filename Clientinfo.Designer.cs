using Bunifu.UI.WinForms;

namespace HOTEL
{
    partial class Clientinfo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientinfo));
            BunifuTextBox.StateProperties stateProperties1 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties2 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties3 = new BunifuTextBox.StateProperties();
            BunifuTextBox.StateProperties stateProperties4 = new BunifuTextBox.StateProperties();
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
            panel1 = new Panel();
            label2 = new Label();
            DateIdI = new Label();
            label1 = new Label();
            ClientGridview = new DataGridView();
            comboBox1 = new ComboBox();
            cilentidtbl = new BunifuTextBox();
            cilentnametbl = new BunifuTextBox();
            cilentphone = new BunifuTextBox();
            AddBtn = new Button();
            Deletebtn = new Button();
            Cilentclean = new BunifuTextBox();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientGridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DateIdI);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 115);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(973, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 3;
            label2.Text = "Date";
            label2.Click += label2_Click;
            // 
            // DateIdI
            // 
            DateIdI.AutoSize = true;
            DateIdI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateIdI.Location = new Point(996, 94);
            DateIdI.Name = "DateIdI";
            DateIdI.Size = new Size(19, 30);
            DateIdI.TabIndex = 2;
            DateIdI.Text = " ";
            DateIdI.Click += DateIdI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(382, 25);
            label1.Name = "label1";
            label1.Size = new Size(287, 50);
            label1.TabIndex = 1;
            label1.Text = "Client Information";
            label1.Click += label1_Click;
            // 
            // ClientGridview
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            ClientGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ClientGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientGridview.BackgroundColor = Color.White;
            ClientGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ClientGridview.DefaultCellStyle = dataGridViewCellStyle2;
            ClientGridview.Location = new Point(322, 167);
            ClientGridview.Name = "ClientGridview";
            ClientGridview.ReadOnly = true;
            ClientGridview.Size = new Size(766, 648);
            ClientGridview.TabIndex = 9;
            ClientGridview.AutoSizeColumnsModeChanged += ClientGridview_AutoSizeColumnsModeChanged;
            ClientGridview.CellClick += ClientGridview_CellClick;
            ClientGridview.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.DodgerBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Egypt", "Saudi Arabia", "United Arab Emirates", "Kuwait", "United Kingdom", "Germany", "France", "Italy", "Russia", "China", "Japan" });
            comboBox1.Location = new Point(12, 512);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 31);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Country";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cilentidtbl
            // 
            cilentidtbl.AcceptsReturn = false;
            cilentidtbl.AcceptsTab = false;
            cilentidtbl.AnimationSpeed = 200;
            cilentidtbl.AutoCompleteMode = AutoCompleteMode.None;
            cilentidtbl.AutoCompleteSource = AutoCompleteSource.None;
            cilentidtbl.AutoSizeHeight = true;
            cilentidtbl.BackColor = Color.Transparent;
            cilentidtbl.BackgroundImage = (Image)resources.GetObject("cilentidtbl.BackgroundImage");
            cilentidtbl.BorderColorActive = Color.DodgerBlue;
            cilentidtbl.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            cilentidtbl.BorderColorHover = Color.FromArgb(105, 181, 255);
            cilentidtbl.BorderColorIdle = Color.Silver;
            cilentidtbl.BorderRadius = 20;
            cilentidtbl.BorderThickness = 0;
            cilentidtbl.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            cilentidtbl.CharacterCasing = CharacterCasing.Normal;
            cilentidtbl.Cursor = Cursors.AppStarting;
            cilentidtbl.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cilentidtbl.DefaultText = "";
            cilentidtbl.FillColor = Color.White;
            cilentidtbl.ForeColor = Color.DarkBlue;
            cilentidtbl.HideSelection = true;
            cilentidtbl.IconLeft = null;
            cilentidtbl.IconLeftCursor = Cursors.IBeam;
            cilentidtbl.IconPadding = 10;
            cilentidtbl.IconRight = null;
            cilentidtbl.IconRightCursor = Cursors.IBeam;
            cilentidtbl.Location = new Point(12, 221);
            cilentidtbl.MaxLength = 32767;
            cilentidtbl.MinimumSize = new Size(1, 1);
            cilentidtbl.Modified = false;
            cilentidtbl.Multiline = false;
            cilentidtbl.Name = "cilentidtbl";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            cilentidtbl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            cilentidtbl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            cilentidtbl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.DarkBlue;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            cilentidtbl.OnIdleState = stateProperties4;
            cilentidtbl.Padding = new Padding(3);
            cilentidtbl.PasswordChar = '\0';
            cilentidtbl.PlaceholderForeColor = Color.DodgerBlue;
            cilentidtbl.PlaceholderText = "Cilent ID ";
            cilentidtbl.ReadOnly = false;
            cilentidtbl.ScrollBars = ScrollBars.None;
            cilentidtbl.SelectedText = "";
            cilentidtbl.SelectionLength = 0;
            cilentidtbl.SelectionStart = 0;
            cilentidtbl.ShortcutsEnabled = true;
            cilentidtbl.Size = new Size(238, 40);
            cilentidtbl.Style = BunifuTextBox._Style.Bunifu;
            cilentidtbl.TabIndex = 13;
            cilentidtbl.TextAlign = HorizontalAlignment.Left;
            cilentidtbl.TextMarginBottom = 0;
            cilentidtbl.TextMarginLeft = 3;
            cilentidtbl.TextMarginTop = 1;
            cilentidtbl.TextPlaceholder = "Cilent ID ";
            cilentidtbl.UseSystemPasswordChar = false;
            cilentidtbl.WordWrap = true;
            cilentidtbl.TextChanged += cilentidtbl_TextChanged;
            cilentidtbl.KeyDown += cilentidtbl_KeyDown;
            cilentidtbl.KeyPress += cilentidtbl_KeyPress;
            // 
            // cilentnametbl
            // 
            cilentnametbl.AcceptsReturn = false;
            cilentnametbl.AcceptsTab = false;
            cilentnametbl.AnimationSpeed = 200;
            cilentnametbl.AutoCompleteMode = AutoCompleteMode.None;
            cilentnametbl.AutoCompleteSource = AutoCompleteSource.None;
            cilentnametbl.AutoSizeHeight = true;
            cilentnametbl.BackColor = Color.Transparent;
            cilentnametbl.BackgroundImage = (Image)resources.GetObject("cilentnametbl.BackgroundImage");
            cilentnametbl.BorderColorActive = Color.DodgerBlue;
            cilentnametbl.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            cilentnametbl.BorderColorHover = Color.FromArgb(105, 181, 255);
            cilentnametbl.BorderColorIdle = Color.Silver;
            cilentnametbl.BorderRadius = 20;
            cilentnametbl.BorderThickness = 0;
            cilentnametbl.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            cilentnametbl.CharacterCasing = CharacterCasing.Normal;
            cilentnametbl.Cursor = Cursors.AppStarting;
            cilentnametbl.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cilentnametbl.DefaultText = "";
            cilentnametbl.FillColor = Color.White;
            cilentnametbl.ForeColor = Color.FromArgb(0, 0, 192);
            cilentnametbl.HideSelection = true;
            cilentnametbl.IconLeft = null;
            cilentnametbl.IconLeftCursor = Cursors.IBeam;
            cilentnametbl.IconPadding = 10;
            cilentnametbl.IconRight = null;
            cilentnametbl.IconRightCursor = Cursors.IBeam;
            cilentnametbl.Location = new Point(12, 313);
            cilentnametbl.MaxLength = 32767;
            cilentnametbl.MinimumSize = new Size(1, 1);
            cilentnametbl.Modified = false;
            cilentnametbl.Multiline = false;
            cilentnametbl.Name = "cilentnametbl";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            cilentnametbl.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            cilentnametbl.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            cilentnametbl.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.FromArgb(0, 0, 192);
            stateProperties8.PlaceholderForeColor = Color.Empty;
            cilentnametbl.OnIdleState = stateProperties8;
            cilentnametbl.Padding = new Padding(3);
            cilentnametbl.PasswordChar = '\0';
            cilentnametbl.PlaceholderForeColor = Color.DodgerBlue;
            cilentnametbl.PlaceholderText = "Cilent Name";
            cilentnametbl.ReadOnly = false;
            cilentnametbl.ScrollBars = ScrollBars.None;
            cilentnametbl.SelectedText = "";
            cilentnametbl.SelectionLength = 0;
            cilentnametbl.SelectionStart = 0;
            cilentnametbl.ShortcutsEnabled = true;
            cilentnametbl.Size = new Size(238, 40);
            cilentnametbl.Style = BunifuTextBox._Style.Bunifu;
            cilentnametbl.TabIndex = 14;
            cilentnametbl.TextAlign = HorizontalAlignment.Left;
            cilentnametbl.TextMarginBottom = 0;
            cilentnametbl.TextMarginLeft = 3;
            cilentnametbl.TextMarginTop = 1;
            cilentnametbl.TextPlaceholder = "Cilent Name";
            cilentnametbl.UseSystemPasswordChar = false;
            cilentnametbl.WordWrap = true;
            cilentnametbl.TextChanged += cilentnametbl_TextChanged;
            cilentnametbl.KeyDown += cilentnametbl_KeyDown;
            cilentnametbl.KeyPress += cilentnametbl_KeyPress;
            // 
            // cilentphone
            // 
            cilentphone.AcceptsReturn = false;
            cilentphone.AcceptsTab = false;
            cilentphone.AnimationSpeed = 200;
            cilentphone.AutoCompleteMode = AutoCompleteMode.None;
            cilentphone.AutoCompleteSource = AutoCompleteSource.None;
            cilentphone.AutoSizeHeight = true;
            cilentphone.BackColor = Color.White;
            cilentphone.BackgroundImage = (Image)resources.GetObject("cilentphone.BackgroundImage");
            cilentphone.BorderColorActive = Color.DodgerBlue;
            cilentphone.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            cilentphone.BorderColorHover = Color.FromArgb(105, 181, 255);
            cilentphone.BorderColorIdle = Color.Silver;
            cilentphone.BorderRadius = 20;
            cilentphone.BorderThickness = 0;
            cilentphone.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            cilentphone.CharacterCasing = CharacterCasing.Normal;
            cilentphone.Cursor = Cursors.AppStarting;
            cilentphone.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cilentphone.DefaultText = "";
            cilentphone.FillColor = Color.White;
            cilentphone.ForeColor = Color.DarkBlue;
            cilentphone.HideSelection = true;
            cilentphone.IconLeft = null;
            cilentphone.IconLeftCursor = Cursors.IBeam;
            cilentphone.IconPadding = 10;
            cilentphone.IconRight = null;
            cilentphone.IconRightCursor = Cursors.IBeam;
            cilentphone.Location = new Point(12, 416);
            cilentphone.MaxLength = 32767;
            cilentphone.MinimumSize = new Size(1, 1);
            cilentphone.Modified = false;
            cilentphone.Multiline = false;
            cilentphone.Name = "cilentphone";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            cilentphone.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            cilentphone.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            cilentphone.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.DarkBlue;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            cilentphone.OnIdleState = stateProperties12;
            cilentphone.Padding = new Padding(3);
            cilentphone.PasswordChar = '\0';
            cilentphone.PlaceholderForeColor = Color.DodgerBlue;
            cilentphone.PlaceholderText = "Cilent Num";
            cilentphone.ReadOnly = false;
            cilentphone.ScrollBars = ScrollBars.None;
            cilentphone.SelectedText = "";
            cilentphone.SelectionLength = 0;
            cilentphone.SelectionStart = 0;
            cilentphone.ShortcutsEnabled = true;
            cilentphone.Size = new Size(238, 40);
            cilentphone.Style = BunifuTextBox._Style.Bunifu;
            cilentphone.TabIndex = 15;
            cilentphone.TextAlign = HorizontalAlignment.Left;
            cilentphone.TextMarginBottom = 0;
            cilentphone.TextMarginLeft = 3;
            cilentphone.TextMarginTop = 1;
            cilentphone.TextPlaceholder = "Cilent Num";
            cilentphone.UseSystemPasswordChar = false;
            cilentphone.WordWrap = true;
            cilentphone.TextChanged += cilentphone_TextChanged;
            cilentphone.KeyPress += cilentphone_KeyPress;
            // 
            // AddBtn
            // 
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.DodgerBlue;
            AddBtn.Location = new Point(9, 603);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 43);
            AddBtn.TabIndex = 16;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.FlatAppearance.BorderSize = 0;
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.DodgerBlue;
            Deletebtn.Location = new Point(171, 603);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(76, 43);
            Deletebtn.TabIndex = 18;
            Deletebtn.Text = "DELETE";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Cilentclean
            // 
            Cilentclean.AcceptsReturn = false;
            Cilentclean.AcceptsTab = false;
            Cilentclean.AnimationSpeed = 200;
            Cilentclean.AutoCompleteMode = AutoCompleteMode.None;
            Cilentclean.AutoCompleteSource = AutoCompleteSource.None;
            Cilentclean.AutoSizeHeight = true;
            Cilentclean.BackColor = Color.Transparent;
            Cilentclean.BackgroundImage = (Image)resources.GetObject("Cilentclean.BackgroundImage");
            Cilentclean.BorderColorActive = Color.DodgerBlue;
            Cilentclean.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Cilentclean.BorderColorHover = Color.FromArgb(105, 181, 255);
            Cilentclean.BorderColorIdle = Color.Silver;
            Cilentclean.BorderRadius = 20;
            Cilentclean.BorderThickness = 0;
            Cilentclean.CharacterCase = BunifuTextBox.CharacterCases.Normal;
            Cilentclean.CharacterCasing = CharacterCasing.Normal;
            Cilentclean.Cursor = Cursors.AppStarting;
            Cilentclean.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cilentclean.DefaultText = "";
            Cilentclean.FillColor = Color.White;
            Cilentclean.ForeColor = Color.DarkBlue;
            Cilentclean.HideSelection = true;
            Cilentclean.IconLeft = null;
            Cilentclean.IconLeftCursor = Cursors.IBeam;
            Cilentclean.IconPadding = 10;
            Cilentclean.IconRight = null;
            Cilentclean.IconRightCursor = Cursors.IBeam;
            Cilentclean.Location = new Point(613, 121);
            Cilentclean.MaxLength = 32767;
            Cilentclean.MinimumSize = new Size(1, 1);
            Cilentclean.Modified = false;
            Cilentclean.Multiline = false;
            Cilentclean.Name = "Cilentclean";
            stateProperties13.BorderColor = Color.DodgerBlue;
            stateProperties13.FillColor = Color.Empty;
            stateProperties13.ForeColor = Color.Empty;
            stateProperties13.PlaceholderForeColor = Color.Empty;
            Cilentclean.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties14.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties14.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties14.PlaceholderForeColor = Color.DarkGray;
            Cilentclean.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties15.FillColor = Color.Empty;
            stateProperties15.ForeColor = Color.Empty;
            stateProperties15.PlaceholderForeColor = Color.Empty;
            Cilentclean.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = Color.Silver;
            stateProperties16.FillColor = Color.White;
            stateProperties16.ForeColor = Color.DarkBlue;
            stateProperties16.PlaceholderForeColor = Color.Empty;
            Cilentclean.OnIdleState = stateProperties16;
            Cilentclean.Padding = new Padding(3);
            Cilentclean.PasswordChar = '\0';
            Cilentclean.PlaceholderForeColor = Color.DodgerBlue;
            Cilentclean.PlaceholderText = "Cilent Search";
            Cilentclean.ReadOnly = false;
            Cilentclean.ScrollBars = ScrollBars.None;
            Cilentclean.SelectedText = "";
            Cilentclean.SelectionLength = 0;
            Cilentclean.SelectionStart = 0;
            Cilentclean.ShortcutsEnabled = true;
            Cilentclean.Size = new Size(260, 40);
            Cilentclean.Style = BunifuTextBox._Style.Bunifu;
            Cilentclean.TabIndex = 19;
            Cilentclean.TextAlign = HorizontalAlignment.Left;
            Cilentclean.TextMarginBottom = 0;
            Cilentclean.TextMarginLeft = 3;
            Cilentclean.TextMarginTop = 1;
            Cilentclean.TextPlaceholder = "Cilent Search";
            Cilentclean.UseSystemPasswordChar = false;
            Cilentclean.WordWrap = true;
            Cilentclean.TextChanged += Cilentclean_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(879, 121);
            button4.Name = "button4";
            button4.Size = new Size(104, 40);
            button4.TabIndex = 20;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(90, 603);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 21;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(989, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(90, 704);
            button3.Name = "button3";
            button3.Size = new Size(75, 43);
            button3.TabIndex = 23;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Clientinfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 827);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(Cilentclean);
            Controls.Add(Deletebtn);
            Controls.Add(AddBtn);
            Controls.Add(cilentphone);
            Controls.Add(cilentnametbl);
            Controls.Add(cilentidtbl);
            Controls.Add(ClientGridview);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Clientinfo";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Load += Clientinfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClientGridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cilentnametbl_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void cilentidtbl_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            
          
        }

        

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView ClientGridview;
        private ComboBox comboBox1;
        private BunifuTextBox cilentidtbl;
        private BunifuTextBox cilentnametbl;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox3;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuTextBox cilentphone;
        private Button AddBtn;

        public Button Editbtn { get; private set; }

        private Button button2;
        private Button Deletebtn;
        private Bunifu.UI.WinForms.BunifuTextBox Cilentclean;
        private Button button4;
        private Label DateIdI;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label2;
    }
}