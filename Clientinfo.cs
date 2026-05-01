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


    public partial class Clientinfo : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True");






        public void populate()
        {

            Con.Open();
            string Myquery = "select * from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Clientinfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            // غير 'ClientGridview' لاسم الجدول عندك
           // ClientGridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            timer1.Interval = 1000;
            
            timer1.Start();
            // تشغيل التايمر برمجياً

            // استدعاء الدالة اللي بتملى الجدول بالبيانات
            populate();




        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            // الاستعلام للبحث عن العميل بالاسم
            string Myquery = "select * from Client_tbl where ClientName = '" + Cilentclean.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            var ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                // عرض بيانات العميل في الجريد في حال وجوده
                ClientGridview.DataSource = ds.Tables[0];
            }
            else
            {
                // إفراغ الجريد وإظهار رسالة تنبيه
                ClientGridview.DataSource = null;
                MessageBox.Show("Client not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            Con.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // بنأكد إننا ضغطنا على سطر حقيقي مش على العناوين اللي فوق
            if (e.RowIndex >= 0)
            {
                // بنحدد السطر اللي اتضغط عليه
                DataGridViewRow row = ClientGridview.Rows[e.RowIndex];

                // بنوزع البيانات من خلايا الجدول (Cells) للتكست بوكس بتاعتك
                // تأكد من ترتيب الأعمدة عندك (0 هو أول عمود، 1 التاني، وهكذا)
                cilentidtbl.Text = row.Cells[0].Value.ToString();
                cilentnametbl.Text = row.Cells[1].Value.ToString();
                cilentphone.Text = row.Cells[2].Value.ToString();

                // بالنسبة للبلد (ComboBox)
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            
        }

        private string GetText()
        {
            return cilentphone.Text;
        }

        //private void button1_Click(object sender, EventArgs e, string text)
        //{
        //    Con.Open();
        //    SqlCommand cmd = new SqlCommand("insert into Client_tbl values(" + cilentidtbl.Text + ",'" + cilentnametbl.Text + "','" + cilentphone.Text + "','" + comboBox1.SelectedItem.ToString() + "')", Con);
        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show("Client Successfully Added");
        //    Con.Close();

        //}

        private void DateIdI_Click(object sender, EventArgs e)
        {

        }

        private void cilentidtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            //Con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Client_tbl values(" + cilentidtbl.Text + ",'" + cilentnametbl.Text + "','" + cilentphone.Text + "','" + comboBox1.SelectedItem.ToString() + "')", Con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Client Successfully Added");
            //Con.Close();
            /*--بداية دالة زرار الإضافة-- -*/

            try
            {
                // 1. Check if any field is empty (Strict Validation)
                if (string.IsNullOrWhiteSpace(cilentidtbl.Text) ||
                    string.IsNullOrWhiteSpace(cilentnametbl.Text) ||
                    string.IsNullOrWhiteSpace(cilentphone.Text) ||
                    comboBox1.Text == "Country" || comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Con.State == ConnectionState.Closed) Con.Open();

                // 2. Check if ID or Phone already exists before inserting
                string checkQuery = "SELECT COUNT(*) FROM Client_tbl WHERE ClientId = " + cilentidtbl.Text + " OR ClientPhone = '" + cilentphone.Text + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    string dupCheck = "SELECT ClientId FROM Client_tbl WHERE ClientId = " + cilentidtbl.Text;
                    SqlCommand dupCmd = new SqlCommand(dupCheck, Con);
                    SqlDataReader dr = dupCmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("This ID is already registered!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("This Phone Number is already registered!", "Duplicate Phone", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    dr.Close();
                    Con.Close();
                    return;
                }

                // 3. Insert Query (If everything is OK)
                string query = "INSERT INTO Client_tbl (ClientId, ClientName, ClientPhone, ClientCountry) VALUES (" + cilentidtbl.Text + ", '" + cilentnametbl.Text + "', '" + cilentphone.Text + "', '" + comboBox1.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Client Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // لازم نقفل الكونيكشن قبل ما ننادي على populate عشان ميسحبش رامات زيادة أو يعمل Error
                Con.Close();

                // --- التعديل هنا: السطر ده هو اللي هيخلي البيانات تظهر في الـ Grid فوراً ---
                populate();

                // 4. Reset & Focus
                cilentidtbl.Clear();
                cilentnametbl.Clear();
                cilentphone.Clear();
                comboBox1.Text = "Country";
                cilentidtbl.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
            populate();

            // 3. تنظيف الخانات الجانبية (ID والاسم والرقم) عشان تبدأ من جديد]
            cilentnametbl.Clear();
            cilentidtbl.Clear();
            cilentphone.Clear();
            comboBox1.Text = "Country";
        }

        private void cilentidtbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ارفض الكتابة
            }
        }

        private void cilentnametbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void cilentnametbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ممنوع أرقام هنا يا هندسة
            }
        }

        private void cilentphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cilentphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cilentclean.Clear();

            // 2. عرض كل البيانات في الجدول تاني (ريفريش)
            populate();

            // 3. تنظيف الخانات الجانبية (ID والاسم والرقم) عشان تبدأ من جديد]
            cilentnametbl.Clear();
            cilentidtbl.Clear();
            cilentphone.Clear();
            comboBox1.Text = "Country";


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            // 1. Password Protection
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Password:", "Security Check", "");
            if (input != "1")
            {
                if (!string.IsNullOrEmpty(input)) MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 2. Validation
            if (string.IsNullOrWhiteSpace(cilentidtbl.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a client first!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Execution
            try
            {
                if (Con.State == ConnectionState.Closed) Con.Open();

                string myquery = "UPDATE Client_tbl set ClientName ='" + cilentnametbl.Text + "',ClientPhone ='" + cilentphone.Text + "',ClientCountry='" + comboBox1.SelectedItem.ToString() + "' where Clientid = " + cilentidtbl.Text + ";";

                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Client Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();

                populate();
                // Clear Fields
                cilentidtbl.Clear(); cilentnametbl.Clear(); cilentphone.Clear();
                comboBox1.SelectedIndex = -1; comboBox1.Text = "Country";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (Con.State == ConnectionState.Open) Con.Close();
            }


        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Admin Password to Delete:", "Security Check", "");
            if (input != "1")
            {
                if (!string.IsNullOrEmpty(input)) MessageBox.Show("Incorrect Password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Con.Open();
            // غيرت staffid لـ ClientId عشان يمسح من جدول العملاء صح
            string query = "delete from Client_tbl where ClientId = " + cilentidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client Successfully Deleted");
            Con.Close();

            populate();
            cilentidtbl.Clear();
            cilentnametbl.Clear();
            cilentphone.Clear();
            comboBox1.Text = "Country";
            cilentidtbl.Focus();


            cilentidtbl.Focus();
            populate();
            //Con.Open();
            //string query = "delete from Client_tbl where Clientid=" + cilentidtbl.Text + " ";
            //SqlCommand cmd = new SqlCommand(query, Con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Client Successfully Deleted ");
            //Con.Close();
            //populate();
            //cilentidtbl.Clear();     // بيمسح الرقم اللي كان مكتوب في الـ ID
            //cilentnametbl.Clear();   // بيمسح الاسم
            //cilentphone.Clear();    // بيمسح رقم التليفون
            //comboBox1.Text = "Country"; // بيرجع الكومبو بوكس لوضعه الأصلي

            //cilentidtbl.Focus();
            //populate();


        }

        private void ClientGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ClientGridview.Rows[e.RowIndex];
                // بنسحب البيانات بناءً على مكان الصف (Row) مش بناءً على الاسم
                cilentidtbl.Text = row.Cells[0].Value.ToString();
                cilentnametbl.Text = row.Cells[1].Value.ToString();
                cilentphone.Text = row.Cells[2].Value.ToString();
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void ClientGridview_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void Cilentclean_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            // 2. إظهار الفورم الرئيسية
            mainForm.Show();

            // 3. إغلاق الفورم الحالية (صفحة الموظفين أو العملاء)
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

