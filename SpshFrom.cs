using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class SpshFrom : Form
    {
        public SpshFrom()
        {
            InitializeComponent();
        }

        private void SpshFrom_Load(object sender, EventArgs e)
        {
            this.timer1.Start();

        }
        //
        int starpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starpoint += 1;
            splashpbar.Value = starpoint;

            if (splashpbar.Value == 100)
            {
                splashpbar.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
