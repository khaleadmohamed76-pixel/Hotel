using Krypton.Toolkit;

namespace HOTEL
{
    partial class Reservationinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservationinfo));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            label1 = new Label();
            DaterIdI = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            Reseridtd = new Bunifu.UI.WinForms.BunifuTextBox();
            label4 = new Label();
            label5 = new Label();
            dateout = new KryptonDateTimePicker();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ReservationGridview = new DataGridView();
            Deleterbtn = new Button();
            button3 = new Button();
            AddrBtn = new Button();
            Reservationsea = new Bunifu.UI.WinForms.BunifuTextBox();
            DateinTime = new KryptonDateTimePicker();
            clientcd = new ComboBox();
            roomcd = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            backr = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReservationGridview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 35);
            label1.Name = "label1";
            label1.Size = new Size(430, 47);
            label1.TabIndex = 1;
            label1.Text = "Reservation  Information";
            // 
            // DaterIdI
            // 
            DaterIdI.AutoSize = true;
            DaterIdI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DaterIdI.Location = new Point(955, 94);
            DaterIdI.Name = "DaterIdI";
            DaterIdI.Size = new Size(58, 30);
            DaterIdI.TabIndex = 2;
            DaterIdI.Text = "Date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(DaterIdI);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 124);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 121);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(973, 82);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 2;
            label2.Text = "Date";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(347, 35);
            label3.Name = "label3";
            label3.Size = new Size(381, 50);
            label3.TabIndex = 1;
            label3.Text = "Reservation  Information";
            label3.Click += label3_Click;
            // 
            // Reseridtd
            // 
            Reseridtd.AcceptsReturn = false;
            Reseridtd.AcceptsTab = false;
            Reseridtd.AnimationSpeed = 200;
            Reseridtd.AutoCompleteMode = AutoCompleteMode.None;
            Reseridtd.AutoCompleteSource = AutoCompleteSource.None;
            Reseridtd.AutoSizeHeight = true;
            Reseridtd.BackColor = Color.Transparent;
            Reseridtd.BackgroundImage = (Image)resources.GetObject("Reseridtd.BackgroundImage");
            Reseridtd.BorderColorActive = Color.DodgerBlue;
            Reseridtd.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Reseridtd.BorderColorHover = Color.FromArgb(105, 181, 255);
            Reseridtd.BorderColorIdle = Color.Silver;
            Reseridtd.BorderRadius = 20;
            Reseridtd.BorderThickness = 0;
            Reseridtd.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            Reseridtd.CharacterCasing = CharacterCasing.Normal;
            Reseridtd.Cursor = Cursors.AppStarting;
            Reseridtd.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reseridtd.DefaultText = "";
            Reseridtd.FillColor = Color.White;
            Reseridtd.ForeColor = Color.FromArgb(0, 0, 192);
            Reseridtd.HideSelection = true;
            Reseridtd.IconLeft = null;
            Reseridtd.IconLeftCursor = Cursors.IBeam;
            Reseridtd.IconPadding = 10;
            Reseridtd.IconRight = null;
            Reseridtd.IconRightCursor = Cursors.IBeam;
            Reseridtd.Location = new Point(46, 216);
            Reseridtd.MaxLength = 32767;
            Reseridtd.MinimumSize = new Size(1, 1);
            Reseridtd.Modified = false;
            Reseridtd.Multiline = false;
            Reseridtd.Name = "Reseridtd";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            Reseridtd.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            Reseridtd.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            Reseridtd.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.FromArgb(0, 0, 192);
            stateProperties4.PlaceholderForeColor = Color.Empty;
            Reseridtd.OnIdleState = stateProperties4;
            Reseridtd.Padding = new Padding(3);
            Reseridtd.PasswordChar = '\0';
            Reseridtd.PlaceholderForeColor = Color.DodgerBlue;
            Reseridtd.PlaceholderText = "Reservation ID\r\n";
            Reseridtd.ReadOnly = false;
            Reseridtd.ScrollBars = ScrollBars.None;
            Reseridtd.SelectedText = "";
            Reseridtd.SelectionLength = 0;
            Reseridtd.SelectionStart = 0;
            Reseridtd.ShortcutsEnabled = true;
            Reseridtd.Size = new Size(238, 40);
            Reseridtd.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Reseridtd.TabIndex = 49;
            Reseridtd.TextAlign = HorizontalAlignment.Left;
            Reseridtd.TextMarginBottom = 0;
            Reseridtd.TextMarginLeft = 3;
            Reseridtd.TextMarginTop = 1;
            Reseridtd.TextPlaceholder = "Reservation ID\r\n";
            Reseridtd.UseSystemPasswordChar = false;
            Reseridtd.WordWrap = true;
            Reseridtd.TextChanged += Reseridtd_TextChanged;
            Reseridtd.KeyPress += Reseridtd_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(26, 446);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 54;
            label4.Text = "Datein";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(26, 502);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 56;
            label5.Text = "DateOut";
            // 
            // dateout
            // 
            dateout.Location = new Point(130, 506);
            dateout.Name = "dateout";
            dateout.Size = new Size(171, 21);
            dateout.TabIndex = 55;
            dateout.ValueChanged += dateout_ValueChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1003, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(893, 129);
            button1.Name = "button1";
            button1.Size = new Size(104, 41);
            button1.TabIndex = 60;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReservationGridview
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            ReservationGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ReservationGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReservationGridview.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ReservationGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ReservationGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ReservationGridview.DefaultCellStyle = dataGridViewCellStyle3;
            ReservationGridview.Location = new Point(318, 176);
            ReservationGridview.Name = "ReservationGridview";
            ReservationGridview.ReadOnly = true;
            ReservationGridview.Size = new Size(771, 631);
            ReservationGridview.TabIndex = 65;
            ReservationGridview.CellClick += ReservationGridview_CellClick;
            ReservationGridview.CellContentClick += ReservationGridview_CellContentClick;
            // 
            // Deleterbtn
            // 
            Deleterbtn.FlatAppearance.BorderSize = 0;
            Deleterbtn.FlatStyle = FlatStyle.Flat;
            Deleterbtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deleterbtn.ForeColor = Color.DodgerBlue;
            Deleterbtn.Location = new Point(196, 621);
            Deleterbtn.Name = "Deleterbtn";
            Deleterbtn.Size = new Size(76, 43);
            Deleterbtn.TabIndex = 68;
            Deleterbtn.Text = "DELETE";
            Deleterbtn.UseVisualStyleBackColor = true;
            Deleterbtn.Click += Deleterbtn_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(103, 621);
            button3.Name = "button3";
            button3.Size = new Size(75, 43);
            button3.TabIndex = 67;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddrBtn
            // 
            AddrBtn.FlatAppearance.BorderSize = 0;
            AddrBtn.FlatStyle = FlatStyle.Flat;
            AddrBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddrBtn.ForeColor = Color.DodgerBlue;
            AddrBtn.Location = new Point(21, 621);
            AddrBtn.Name = "AddrBtn";
            AddrBtn.Size = new Size(75, 43);
            AddrBtn.TabIndex = 66;
            AddrBtn.Text = "ADD";
            AddrBtn.UseVisualStyleBackColor = true;
            AddrBtn.Click += AddrBtn_Click;
            // 
            // Reservationsea
            // 
            Reservationsea.AcceptsReturn = false;
            Reservationsea.AcceptsTab = false;
            Reservationsea.AnimationSpeed = 200;
            Reservationsea.AutoCompleteMode = AutoCompleteMode.None;
            Reservationsea.AutoCompleteSource = AutoCompleteSource.None;
            Reservationsea.AutoSizeHeight = true;
            Reservationsea.BackColor = Color.Transparent;
            Reservationsea.BackgroundImage = (Image)resources.GetObject("Reservationsea.BackgroundImage");
            Reservationsea.BorderColorActive = Color.DodgerBlue;
            Reservationsea.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            Reservationsea.BorderColorHover = Color.FromArgb(105, 181, 255);
            Reservationsea.BorderColorIdle = Color.Silver;
            Reservationsea.BorderRadius = 20;
            Reservationsea.BorderThickness = 0;
            Reservationsea.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            Reservationsea.CharacterCasing = CharacterCasing.Normal;
            Reservationsea.Cursor = Cursors.AppStarting;
            Reservationsea.DefaultFont = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reservationsea.DefaultText = "";
            Reservationsea.FillColor = Color.White;
            Reservationsea.ForeColor = Color.DarkBlue;
            Reservationsea.HideSelection = true;
            Reservationsea.IconLeft = null;
            Reservationsea.IconLeftCursor = Cursors.IBeam;
            Reservationsea.IconPadding = 10;
            Reservationsea.IconRight = null;
            Reservationsea.IconRightCursor = Cursors.IBeam;
            Reservationsea.Location = new Point(627, 130);
            Reservationsea.MaxLength = 32767;
            Reservationsea.MinimumSize = new Size(1, 1);
            Reservationsea.Modified = false;
            Reservationsea.Multiline = false;
            Reservationsea.Name = "Reservationsea";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            Reservationsea.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            Reservationsea.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            Reservationsea.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.DarkBlue;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            Reservationsea.OnIdleState = stateProperties8;
            Reservationsea.Padding = new Padding(3);
            Reservationsea.PasswordChar = '\0';
            Reservationsea.PlaceholderForeColor = Color.DodgerBlue;
            Reservationsea.PlaceholderText = "Reservation Search";
            Reservationsea.ReadOnly = false;
            Reservationsea.ScrollBars = ScrollBars.None;
            Reservationsea.SelectedText = "";
            Reservationsea.SelectionLength = 0;
            Reservationsea.SelectionStart = 0;
            Reservationsea.ShortcutsEnabled = true;
            Reservationsea.Size = new Size(260, 40);
            Reservationsea.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            Reservationsea.TabIndex = 69;
            Reservationsea.TextAlign = HorizontalAlignment.Left;
            Reservationsea.TextMarginBottom = 0;
            Reservationsea.TextMarginLeft = 3;
            Reservationsea.TextMarginTop = 1;
            Reservationsea.TextPlaceholder = "Reservation Search";
            Reservationsea.UseSystemPasswordChar = false;
            Reservationsea.WordWrap = true;
            // 
            // DateinTime
            // 
            DateinTime.Location = new Point(130, 447);
            DateinTime.Name = "DateinTime";
            DateinTime.Size = new Size(171, 21);
            DateinTime.TabIndex = 70;
            DateinTime.ValueChanged += DateinTime_ValueChanged;
            // 
            // clientcd
            // 
            clientcd.BackColor = SystemColors.Window;
            clientcd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientcd.ForeColor = Color.DodgerBlue;
            clientcd.FormattingEnabled = true;
            clientcd.Location = new Point(103, 290);
            clientcd.Name = "clientcd";
            clientcd.Size = new Size(198, 28);
            clientcd.TabIndex = 71;
            clientcd.Text = "Client Name";
            // 
            // roomcd
            // 
            roomcd.BackColor = SystemColors.Window;
            roomcd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomcd.ForeColor = Color.DodgerBlue;
            roomcd.FormattingEnabled = true;
            roomcd.Location = new Point(103, 347);
            roomcd.Name = "roomcd";
            roomcd.Size = new Size(198, 28);
            roomcd.TabIndex = 72;
            roomcd.Text = "Room id";
            roomcd.SelectedIndexChanged += roomcd_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(26, 293);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 73;
            label6.Text = "Client";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(26, 349);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 74;
            label7.Text = "Room";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // backr
            // 
            backr.FlatAppearance.BorderSize = 0;
            backr.FlatStyle = FlatStyle.Flat;
            backr.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backr.ForeColor = Color.DodgerBlue;
            backr.Location = new Point(103, 717);
            backr.Name = "backr";
            backr.Size = new Size(75, 43);
            backr.TabIndex = 75;
            backr.Text = "BACK";
            backr.UseVisualStyleBackColor = true;
            backr.Click += backr_Click;
            // 
            // Reservationinfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 827);
            Controls.Add(backr);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(roomcd);
            Controls.Add(clientcd);
            Controls.Add(DateinTime);
            Controls.Add(Reservationsea);
            Controls.Add(Deleterbtn);
            Controls.Add(button3);
            Controls.Add(AddrBtn);
            Controls.Add(ReservationGridview);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(dateout);
            Controls.Add(label4);
            Controls.Add(Reseridtd);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reservationinfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservationinfo";
            Load += Reservationinfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReservationGridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label DaterIdI;
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox Reseridtd;

        public KryptonDateTimePicker datein { get; private set; }

        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Krypton.Toolkit.KryptonDateTimePicker dateout;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private ComboBox comboBox1;
        private DataGridView ReservationGridview;
        private Button Deleterbtn;
        private Button button3;
        private Button AddrBtn;
        private Bunifu.UI.WinForms.BunifuTextBox roomphone;
        private Bunifu.UI.WinForms.BunifuTextBox roomtbl;
        private Bunifu.UI.WinForms.BunifuTextBox Reservationsea;
        private KryptonDateTimePicker DateinTime;
        private ComboBox clientcd;
        private ComboBox roomcd;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private Button backr;
        // private KryptonDateTimePicker datein;
    }
}