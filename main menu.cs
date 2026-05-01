using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Form1 : Form

    {
        // امسح ده من Form1.cs

        public Form1()
        {
            InitializeComponent();


            // عشان الرسم يبقى ناعم
            this.DoubleBuffered = true;

            // نخلي الفورم من غير لون افتراضي
            this.BackColor = Color.Black;

        }

        // رسم الخلفية Gradient
        protected override void OnPaint(PaintEventArgs e)
        {







            base.OnPaint(e);

            Rectangle rect = this.ClientRectangle;

            // 🔵 الخلفية الأساسية (غامقة جدًا)
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, this.Height),
                Color.FromArgb(0, 0, 20),     // غامق جدًا
                Color.FromArgb(0, 40, 120)))  // أزرق هادي
            {
                e.Graphics.FillRectangle(brush, rect);
            }


            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(this.Width / 4, this.Height / 4, this.Width / 2, this.Height / 2);

                PathGradientBrush glow = new PathGradientBrush(path);
                glow.CenterColor = Color.FromArgb(80, 0, 120, 255); // لمعة
                glow.SurroundColors = new Color[] { Color.Transparent };

                e.Graphics.FillEllipse(glow, this.Width / 4, this.Height / 4, this.Width / 2, this.Height / 2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            // 2. كود عشان المقاس يفضل ثابت ومحدش يشد الشاشة ويكبرها
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // 3. كود عشان يقفل زرار التكبير (Maximize) اللي جنب علامة الـ X

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" انطر ابلكاش ");

            Application.Exit();



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // إنشاء كائن (Object) من صفحة العملاء
            Clientinfo clientPage = new Clientinfo();

            // إظهار صفحة العملاء
            clientPage.Show();

            // اختياري: إخفاء الشاشة الرئيسية الحالية
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 1. إنشاء نسخة من صفحة الغرف
            Roominfo roomPage = new Roominfo();

            // 2. إظهار الصفحة الجديدة
            roomPage.Show();

            // 3. (اختياري) إخفاء الشاشة الرئيسية لو حابب
            this.Hide();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Reservationinfo reservationinfo = new Reservationinfo();

            // 2. إظهار فورم الموظفين
            reservationinfo.Show();

            // 3. إخفاء المنيو الرئيسية (عشان متبقاش مفتوحة في الخلفية)
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            // 1. إنشاء نسخة من فورم الموظفين
            Staffinfo staffPage = new Staffinfo();

            // 2. إظهار فورم الموظفين
            staffPage.Show();

            // 3. إخفاء المنيو الرئيسية (عشان متبقاش مفتوحة في الخلفية)
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();

            // 2. إظهار فورم اللوجن
            frmLogin.Show();

            // 3. إغلاق الفورم الحالية (اللي أنت واقف عليها دلوقتي)
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
