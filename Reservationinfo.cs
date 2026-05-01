using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HOTEL
{
    public partial class Reservationinfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\projects\HOTEL\HOTEL\HotelDB.mdf;Integrated Security=True");
        public Reservationinfo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DateTime today;
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridview.DataSource = ds.Tables[0];

           // الكود الجديد للتلوين
           

            Con.Close();
        }
        public void populate1()
        {
            Con.Open();
            string Myquery = "select * from Reservation_tbl ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridview.DataSource = ds.Tables[0];
            // الكود الجديد للتلوين
            foreach (DataGridViewRow row in ReservationGridview.Rows)
            {
                // بنجيب قيمة تاريخ الخروج من العمود رقم 4 (DateOut)
                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value)
                {
                    DateTime dateOut = Convert.ToDateTime(row.Cells[4].Value);

                    // هنا بنقارن بالوقت الحالي بالظبط (DateTime.Now) 
                    // عشان لو الساعة عدت حتى بدقيقة واحدة يلون أحمر فوراً
                    if (dateOut <= DateTime.Now)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White; // خط أبيض عشان يظهر
                    }
                }
            }

            // الكود الجديد للتلوين


            Con.Close();
        }

        public void fillRoomcombo()
        {
            if (Con.State == ConnectionState.Open) Con.Close(); // تأمين للاتصال
            Con.Open();

            string roomstate = "free";
            // استخدمنا Select مباشرة في الـ Load عشان نضمن تطابق الأعمدة
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl where RoomFree = '" + roomstate + "'", Con);
            SqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);

            // السطرين دول هم اللي هيخلوا الأرقام تظهر في الكومبو بوكس
            roomcd.DataSource = dt;
            roomcd.ValueMember = "RoomId";
            roomcd.DisplayMember = "RoomId"; // لازم السطر ده عشان يعرض الرقم

            Con.Close();
        }
        public void fillClientcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName ", typeof(string));
            dt.Load(rdr);
            clientcd.ValueMember = "ClientName";
            clientcd.DataSource = dt;
            Con.Close();
        }
        private void Reservationinfo_Load(object sender, EventArgs e)
        {
            today = DateinTime.Value;
            fillRoomcombo();
            fillClientcombo();
            populate1(); 
           
            label2.Text = // هيظهر بالشكل ده: 26/04/2026
 DateTime.Now.ToString("dd/MM/yyyy");
        }



        private void DateinTime_ValueChanged(object sender, EventArgs e)
        {

            // مقارنة التاريخ المختار بالتاريخ الحالي
            int res = DateTime.Compare(DateinTime.Value, today);

            // إذا كان التاريخ المختار قبل التاريخ الحالي (قيمة سالبة)
            if (res < 0)
            {
                MessageBox.Show(" Wrong Date For Reservation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            // مقارنة التاريخ المختار بالتاريخ الحالي

            // مقارنة تاريخ المغادرة المختارة مع تاريخ الدخول
            int res = DateTime.Compare(dateout.Value, DateinTime.Value);

            // إذا كان تاريخ المغادرة (Dateout) يسبق تاريخ الدخول (Datein)                                               
            if (res < 0)
            {
                MessageBox.Show("Wrong Dateout. check once more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void updateroomstate()
        {
            if (roomcd.Text != "") // تأكد إن فيه أوضة مختارة الأول
            {
                Con.Open();
                string newstate = "busy";

                // التعديل هنا: استخدمنا roomcd.Text أضمن وأبسط عشان ميبانش إن الكود معقد
                string query = "UPDATE Room_tbl set RoomFree = '" + newstate + "' where RoomId = " + roomcd.Text + "";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                Con.Close();

                // تحديث القائمة عشان الأوضة اللي اتحجزت تختفي فوراً
                fillRoomcombo();
            }
            else
            {
                MessageBox.Show("Please select a Room first!");
            }




        }
        public void updateroomondelete()
        {

            Con.Open();
            string newstate = "free";

            // استخدمنا CurrentRow عشان ياخد الصف اللي أنت واقف عليه حالاً من غير ما يطلب تحديد كامل
            int roomid = Convert.ToInt32(ReservationGridview.CurrentRow.Cells[2].Value.ToString());

            string query = "UPDATE Room_tbl set RoomFree  ='" + newstate + "'   where  RoomId= " + roomid + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();

            // MessageBox.Show(" Reservation Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Con.Close();
            fillRoomcombo();



        }
        private void AddrBtn_Click(object sender, EventArgs e)
        {
            if (Reseridtd.Text == "" || clientcd.Text == "" || roomcd.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Con.Open();

            // 3. التأكد من عدم التكرار
            string checkQuery = "select count(*) from Reservation_tbl where ResId = " + Reseridtd.Text;
            SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Reservation ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
            else
            {
                // 4. تنفيذ الإضافة
                string query = "insert into Reservation_tbl (ResId, Client, Room, DateIn, DateOut) values(" + Reseridtd.Text + ", '" + clientcd.SelectedValue.ToString() + "', " + roomcd.SelectedValue.ToString() + ", '" + DateinTime.Value + "', '" + dateout.Value + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Reservation Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                updateroomstate();
                populate1();

            }
        }

        private void clientcd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reseridtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reseridtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // بيسمح بس بالأرقام وزرار الـ Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ReservationGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ReservationGridview.Rows[e.RowIndex];

                // 1. يظهر الـ ID في التكست بوكس
                Reseridtd.Text = row.Cells[0].Value.ToString();

                // 2. يظهر اسم العميل في الـ ComboBox
                clientcd.Text = row.Cells[1].Value.ToString();

                // 3. يظهر رقم الغرفة في الـ ComboBox
                roomcd.Text = row.Cells[2].Value.ToString();

                // 4. يظهر تاريخ الدخول
          
            }

        }

        private void Deleterbtn_Click(object sender, EventArgs e)
        {
            if (Reseridtd.Text == "")
            {
                MessageBox.Show("Enter the Reservation to be deleted", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // 1. طلب كلمة السر فقط
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Password:", "Security Check", "");

                if (input == "1") // لو الباسورد "1" هينفذ المسح فوراً
                {
                    Con.Open();
                    string query = "delete from Reservation_tbl where ResId = " + Reseridtd.Text;

                    SqlCommand cmd = new SqlCommand(query, Con);

                    // بنحسب عدد الصفوف اللي اتمسحت
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // بنقفل الاتصال هنا عشان الميثودز اللي تحت هتحتاج تفتح اتصال جديد غالباً
                        Con.Close();

                        updateroomondelete();
                        populate();   // تحديث الجدول
                    }
                    else
                    {
                        Con.Close();
                        // لو الـ ID مش موجود أصلاً في قاعدة البيانات
                        MessageBox.Show("No reservation found with this ID!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    // لو الباسورد غلط
                    MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Reseridtd.Text == "")
            {
                MessageBox.Show("Empty ResId, Enter The Reservation!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Password:", "Security Check", "");

                if (input == "1")
                {
                    Con.Open();

                    // 1. نجيب رقم الأوضة اللي كانت محجوزة أصلاً قبل ما نعدلها عشان نرجعها فاضية
                    // بناخدها من الجريد فيو لأنها لسه متغيرةش هناك
                    // غير السطر اللي فيه المشكلة وخليه كدة:
                    string oldRoomId = ReservationGridview.CurrentRow.Cells[2].Value.ToString();
                    string queryRelease = "UPDATE Room_tbl set RoomFree = 'free' where RoomId = " + oldRoomId;
                    SqlCommand cmdRelease = new SqlCommand(queryRelease, Con);
                    cmdRelease.ExecuteNonQuery();

                    // 2. نحدث بيانات الحجز نفسه (العميل، الأوضة الجديدة، التواريخ)
                    string clientValue = clientcd.SelectedValue != null ? clientcd.SelectedValue.ToString() : clientcd.Text;
                    string roomValue = roomcd.SelectedValue != null ? roomcd.SelectedValue.ToString() : roomcd.Text;

                    string queryUpdate = "UPDATE Reservation_tbl set Client ='" + clientValue + "', Room = '" + roomValue + "', Datein='" + DateinTime.Value.ToString() + "', DateOut ='" + dateout.Value.ToString() + "' where ResId= " + Reseridtd.Text;
                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, Con);
                    cmdUpdate.ExecuteNonQuery();

                    // 3. نخلي الأوضة الجديدة اللي اخترناها تبقى مشغولة (busy)
                    string queryBusy = "UPDATE Room_tbl set RoomFree = 'busy' where RoomId = '" + roomValue + "'";
                    SqlCommand cmdBusy = new SqlCommand(queryBusy, Con);
                    cmdBusy.ExecuteNonQuery();

                    Con.Close();

                    // 4. تحديث الشاشة والكومبو بوكس
                    MessageBox.Show("Reservation Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populate1();
                    fillRoomcombo();
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void backr_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            // 2. إظهار الفورم الرئيسية
            mainForm.Show();

            // 3. إغلاق الفورم الحالية (صفحة الموظفين أو العملاء)
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reseridtd.Clear();
            Reservationsea.Text = ""; // يمسح اللي كتبته في البحث
            populate1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from Reservation_tbl where ResId like '%" + Reservationsea.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);

            // فحص هل الجدول يحتوي على بيانات أم لا
            if (ds.Tables[0].Rows.Count > 0)
            {
                // لو فيه بيانات، اعرضها في الجريد
                ReservationGridview.DataSource = ds.Tables[0];
            }
            else
            {
                // لو مفيش بيانات، اظهر رسالة ونظف الجريد
                ReservationGridview.DataSource = null;
                MessageBox.Show("عذراً، هذا الرقم غير موجود!", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Con.Close();
            //Con.Open();
            //// التعديل هنا: البحث في جدول الحجوزات Reservation_tbl باستخدام معرف الحجز ResId
            //string query = "select * from Reservation_tbl where ResId like '%" + Reservationsea.Text + "%'";

            //SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //var ds = new DataSet();
            //sda.Fill(ds);

            //// ربط النتيجة بالـ GridView
            //ReservationGridview.DataSource = ds.Tables[0];

            //Con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roomcd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReservationGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Reseridtd.Text = ReservationGridview.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}




