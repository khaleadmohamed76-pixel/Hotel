namespace HOTEL
{
    partial class SpshFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpshFrom));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            splashpbar = new CircularProgressBar_NET5.CircularProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(151, 19);
            label1.Name = "label1";
            label1.Size = new Size(296, 30);
            label1.TabIndex = 0;
            label1.Text = "HOTEL MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 43);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(247, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 45);
            label2.TabIndex = 2;
            label2.Text = "VOLT";
            // 
            // splashpbar
            // 
            splashpbar.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            splashpbar.AnimationSpeed = 500;
            splashpbar.BackColor = Color.Transparent;
            splashpbar.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            splashpbar.ForeColor = Color.FromArgb(64, 64, 64);
            splashpbar.InnerColor = Color.FromArgb(224, 224, 224);
            splashpbar.InnerMargin = 2;
            splashpbar.InnerWidth = -1;
            splashpbar.Location = new Point(197, 71);
            splashpbar.MarqueeAnimationSpeed = 2000;
            splashpbar.Name = "splashpbar";
            splashpbar.OuterColor = Color.Gray;
            splashpbar.OuterMargin = -25;
            splashpbar.OuterWidth = 26;
            splashpbar.ProgressColor = Color.Navy;
            splashpbar.ProgressWidth = 25;
            splashpbar.SecondaryFont = new Font("Segoe UI", 36F);
            splashpbar.Size = new Size(187, 189);
            splashpbar.StartAngle = 270;
            splashpbar.SubscriptColor = Color.FromArgb(166, 166, 166);
            splashpbar.SubscriptMargin = new Padding(10, -35, 0, 0);
            splashpbar.SubscriptText = ".23";
            splashpbar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            splashpbar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            splashpbar.SuperscriptText = "°C";
            splashpbar.TabIndex = 17;
            splashpbar.TextMargin = new Padding(8, 8, 0, 0);
            splashpbar.Value = 68;
            splashpbar.Click += circularProgressBar1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // SpshFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 307);
            Controls.Add(splashpbar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SpshFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "exi";
            Load += SpshFrom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private CircularProgressBar_NET5.CircularProgressBar splashpbar;
        private System.Windows.Forms.Timer timer1;
    }
}