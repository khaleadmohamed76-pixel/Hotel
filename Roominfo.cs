using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace HOTEL
{
    public partial class Roominfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\projects\HOTEL\HOTEL\HotelDB.mdf;Integrated Security=True");
        public void populate()
        {

            Con.Open();
            string Myquery = "select * from Room_tbl ";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ROOMGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Roominfo()
        {
            InitializeComponent();
        }
        // دي الدالة نفسها اللي بتعرف البرنامج يعني إيه ClearFields
        public void ClearFields()
        {

            // امسح أسماء الـ TextBoxes دي واكتب الأسماء اللي عندك بالظبط لو مختلفة
            roomtbl.Text = "";
            roomphone.Text = "";
            kryptonRadioButton1.Checked = true; // بيرجع الاختيار لـ Free
            roomtbl.Focus(); // بيرجع الماوس لأول خانة
        }


        private void roomphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddrBtn_Click(object sender, EventArgs e)
        {
            // 1. تحديد الحالة
            string isfree = kryptonRadioButton1.Checked ? "free" : "busy";

            // 2. التحقق من البيانات الفارغة (بشكل شيك)
            if (roomtbl.Text == "" || roomphone.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Con.Open();

            // 3. التأكد من عدم التكرار
            string checkQuery = "select count(*) from Room_tbl where RoomId = " + roomtbl.Text;
            SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Room Number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
            else
            {
                // 4. تنفيذ الإضافة
                string query = "insert into Room_tbl (RoomId, RoomPhone, RoomFree) values(" + roomtbl.Text + ", " + roomphone.Text + ", '" + isfree + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();

                populate();
                ClearFields();

            }
        }

        //    string isfree;
        //    if (kryptonRadioButton1.Checked == true)
        //        isfree = "free";
        //    else
        //        isfree = "busy";

        //    Con.Open();

        //    // هنا حددنا أسماء الأعمدة (RoomId, RoomPhone, RoomFree) عشان نضمن إن كل قيمة تروح مكانها الصح
        //    string query = "insert into Room_tbl (RoomId, RoomPhone, RoomFree) values(" + roomtbl.Text + ", " + roomphone.Text + ", '" + isfree + "')";

        //    SqlCommand cmd = new SqlCommand(query, Con);
        //    cmd.ExecuteNonQuery();

        //    MessageBox.Show("Room Successfully Added");
        //    Con.Close();

        //    populate();
        //    ClearFields();
        //}

        private void Roominfo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void AddrBtn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void roomtbl_KeyPress(object sender, KeyPressEventArgs e)
        {

            // بيسمح بس بالأرقام وزرار الـ Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void roomphone_KeyPress(object sender, KeyPressEventArgs e)
        {

            // بيسمح بس بالأرقام وزرار الـ Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void staffclean_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffclean_KeyPress(object sender, KeyPressEventArgs e)
        {

            // بيسمح بس بالأرقام وزرار الـ Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Deleterbtn_Click(object sender, EventArgs e)
        {
            if (roomtbl.Text == "")
            {
                MessageBox.Show("Please enter the Room Number!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // 1. طلب كلمة السر فقط
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Password:", "Security Check", "");

                if (input == "1") // لو الباسورد "1" هينفذ المسح فوراً
                {
                    Con.Open();
                    string query = "delete from Room_tbl where RoomId = " + roomtbl.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Room Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();

                    populate();   // تحديث الجدول
                    ClearFields(); // تنظيف الخانات
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    // لو الباسورد غلط
                    MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void ROOMGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // السطر ده عشان يتأكد إنك ضغطت على صف فيه بيانات مش بره الجدول
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ROOMGridview.Rows[e.RowIndex];

                // 1. يظهر رقم الغرفة في التكست بوكس الأول
                roomtbl.Text = row.Cells[0].Value.ToString();

                // 2. يظهر رقم التليفون في التكست بوكس التاني
                roomphone.Text = row.Cells[1].Value.ToString();

                // 3. يظبط الـ RadioButtons بناءً على الحالة (Free/Busy)
                if (row.Cells[2].Value.ToString() == "free")
                {
                    kryptonRadioButton1.Checked = true;
                }
                else
                {
                    // لو عندك راديو بوتون تاني للـ Busy ضيفه هنا
                    // kryptonRadioButton2.Checked = true;
                }
            }
        }

        private void Roominfo_Load(object sender, EventArgs e)
        {

            

            // تشغيل التايمر برمجياً
            timer1.Interval = 1000;
            timer1.Start();
            // استدعاء الدالة اللي بتملى الجدول بالبيانات
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DaterIdI.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Con.Open();
            // البحث في جدول الغرف
            string query = "select * from Room_tbl where RoomId like '%" + Rooms.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                // لو الغرفة موجودة اعرضها
                ROOMGridview.DataSource = ds.Tables[0];
            }
            else
            {
                // لو مش موجودة اظهر الرسالة ونظف الجدول
                ROOMGridview.DataSource = null;
                MessageBox.Show("Room ID not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Rooms.Text = ""; // يمسح اللي كتبته في البحث
            populate();              // يرجع يعرض كل البيانات الأصلية
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. طلب كلمة السر للأمان
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Password:", "Security Check", "");

            if (input == "1") // الباسورد بتاعك
            {
                string isfree;
                if (kryptonRadioButton1.Checked == true)
                    isfree = "free";
                else
                    isfree = "busy";

                Con.Open();
                string query = "UPDATE Room_tbl set RoomPhone ='" + roomphone.Text + "', RoomFree = '" + isfree + "' where RoomId = " + roomtbl.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Room Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();

                populate();
                ClearFields();
            }
            else if (!string.IsNullOrEmpty(input))
            {
                // لو الباسورد غلط
                MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            //string isfree;
            //if (kryptonRadioButton1.Checked == true)
            //    isfree = "free";
            //else
            //    isfree = "busy";

            //Con.Open();
            //// عدلت لك الجملة والرسالة بس
            //string query = "UPDATE Room_tbl set RoomPhone ='" + roomphone.Text + "', RoomFree = '" + isfree + "' where RoomId = " + roomtbl.Text + "";
            //SqlCommand cmd = new SqlCommand(query, Con);
            //cmd.ExecuteNonQuery();

            //MessageBox.Show("Room Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Con.Close();

            //populate();
            //ClearFields();
        }

        private void backr_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            // 2. إظهار الفورم الرئيسية
            mainForm.Show();

            // 3. إغلاق الفورم الحالية (صفحة الموظفين أو العملاء)
            this.Hide();
        }

        private void DaterIdI_Click(object sender, EventArgs e)
        {

        }
    }
}

    //try
    //{
    //    if (roomtbl.Text == "" || roomphone.Text == "")
    //    {
    //        MessageBox.Show("Please fill all information");
    //    }
    //    else
    //    {
    //        Con.Open();
    //        string query = "INSERT INTO Room_tbl VALUES (" + roomtbl.Text + ", '" + roomphone.Text + "', 'Free')";
    //        SqlCommand cmd = new SqlCommand(query, Con);
    //        cmd.ExecuteNonQuery();

    //        MessageBox.Show("Room Added Successfully!");
    //        Con.Close();

    //        // تنظيف الخانات والرجوع للـ Number
    //        ClearFields();
    //    }
    //}
    //catch (Exception ex)
    //{
    //    MessageBox.Show("Error: " + ex.Message);
    //    Con.Close();
    //}


