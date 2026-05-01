using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Staffinfo : Form
    {
        // استخدام المسار الديناميكي لضمان عمل قاعدة البيانات في أي مكان
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDB.mdf;Integrated Security=True;User Instance=True;");

        public void populate()
        {
            try
            {
                if (Con.State == ConnectionState.Closed) Con.Open();
                string Myquery = "select * from Staff_tbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                var ds = new DataSet();
                da.Fill(ds);
                staffGridview.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public Staffinfo()
        {
            InitializeComponent();
        }

        private void Staffinfo_Load(object sender, EventArgs e)
        {
            DateIdI.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        // حدث التايمر لتحديث الوقت لحظياً
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateIdI.Text = DateTime.Now.ToLongTimeString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFields()) return;

                if (Con.State == ConnectionState.Closed) Con.Open();

                // التحقق من تكرار الـ ID أو الهاتف
                string checkQuery = "SELECT COUNT(*) FROM Staff_tbl WHERE StaffId= @id OR staffPhone = @phone";
                SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                checkCmd.Parameters.AddWithValue("@id", stafftbl.Text);
                checkCmd.Parameters.AddWithValue("@phone", staffphone.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Duplicate ID or Phone Number found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                string query = "INSERT INTO Staff_tbl (StaffId, Staffname, Staffphone, gender, Staffpassword) VALUES (@id, @name, @phone, @gender, @pass)";
                ExecuteQuery(query, "Added");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { Con.Close(); }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(stafftbl.Text))
                {
                    MessageBox.Show("Please select a staff member to update.");
                    return;
                }

                if (Con.State == ConnectionState.Closed) Con.Open();
                string query = "UPDATE Staff_tbl SET Staffname=@name, Staffphone=@phone, gender=@gender, Staffpassword=@pass WHERE StaffId=@id";
                ExecuteQuery(query, "Updated");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { Con.Close(); }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(stafftbl.Text))
                {
                    MessageBox.Show("Select the staff to delete.");
                    return;
                }

                if (Con.State == ConnectionState.Closed) Con.Open();
                string query = "DELETE FROM Staff_tbl WHERE StaffId = @id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id", stafftbl.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Deleted Successfully!");
                populate();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { Con.Close(); }
        }

        // زر البحث
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed) Con.Open();
                string query = "SELECT * FROM Staff_tbl WHERE Staffname LIKE @name";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                da.SelectCommand.Parameters.AddWithValue("@name", "%" + staffclean.Text + "%");
                DataSet ds = new DataSet();
                da.Fill(ds);
                staffGridview.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Con.Close(); }
        }

        // ربط الجدول بالخانات عند الضغط على صف
        private void staffGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staffGridview.Rows[e.RowIndex];
                stafftbl.Text = row.Cells[0].Value.ToString();
                staffnametbl.Text = row.Cells[1].Value.ToString();
                staffphone.Text = row.Cells[2].Value.ToString();
                staffgerdercb.SelectedItem = row.Cells[3].Value.ToString();
                staffpasswordtn.Text = row.Cells[4].Value.ToString();
            }
        }

        // دالة مساعدة لتنفيذ الاستعلامات لتقليل تكرار الكود
        private void ExecuteQuery(string query, string actionType)
        {
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@id", stafftbl.Text);
            cmd.Parameters.AddWithValue("@name", staffnametbl.Text);
            cmd.Parameters.AddWithValue("@phone", staffphone.Text);
            cmd.Parameters.AddWithValue("@gender", staffgerdercb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@pass", staffpasswordtn.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Staff {actionType} Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            populate();
            ClearFields();
        }

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(stafftbl.Text) || string.IsNullOrWhiteSpace(staffnametbl.Text) ||
                string.IsNullOrWhiteSpace(staffphone.Text) || string.IsNullOrWhiteSpace(staffpasswordtn.Text) ||
                staffgerdercb.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void ClearFields()
        {
            stafftbl.Clear();
            staffnametbl.Clear();
            staffphone.Clear();
            staffpasswordtn.Clear();
            staffgerdercb.SelectedIndex = -1;
            staffgerdercb.Text = "gender";
            stafftbl.Focus();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}