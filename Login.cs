using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Login : Form
    {
        // تم تعديل المسار هنا ليكون ديناميكياً ويعمل على أي جهاز
        string Con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, this.Height),
                Color.FromArgb(0, 0, 20),
                Color.FromArgb(0, 40, 120)))
            {
                g.FillRectangle(brush, rect);
            }

            int glowWidth = this.Width / 2;
            int glowHeight = this.Height / 2;
            int glowX = (this.Width - glowWidth) / 2;
            int glowY = (this.Height - glowHeight) / 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(glowX, glowY, glowWidth, glowHeight);
                using (PathGradientBrush glow = new PathGradientBrush(path))
                {
                    glow.CenterColor = Color.FromArgb(70, 0, 120, 255);
                    glow.SurroundColors = new Color[] { Color.Transparent };
                    g.FillEllipse(glow, glowX, glowY, glowWidth, glowHeight);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(PassWord1.Text))
            {
                MessageBox.Show("Please enter the username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sqlQuery = "SELECT COUNT(*) FROM Staff_tbl WHERE LOWER(TRIM(Staffname)) = LOWER(@u) AND Staffpassword = @p";

                using (SqlConnection con = new SqlConnection(Con))
                using (SqlCommand sqlCmd = new SqlCommand(sqlQuery, con))
                {
                    sqlCmd.Parameters.AddWithValue("@u", username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@p", PassWord1.Text.Trim());

                    con.Open();
                    int userExists = (int)sqlCmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        Form1 main = new Form1();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث مشكله " + " " + ex.Message, "خطأ فني", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // باقي الأحداث كما هي
        private void Login_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}