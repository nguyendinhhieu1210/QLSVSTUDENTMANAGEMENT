using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVSTUDENTMANAGEMENT
{
    public partial class FormTeacher : Form
    {


        // Khai báo biến trạng thái chỉnh sửa và ID học sinh được chọn
        private bool isEditingMode = false;
        private int selectedStudentID = -1;

        SqlConnection connection;
        SqlCommand command;
        public FormTeacher()
        {
            connection = new SqlConnection("Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True");
            InitializeComponent();
        }

        public void FillData()
        {
            string query = "select * from students ";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            connection.Close();
        }







        private void FormTeacher_Load(object sender, EventArgs e)
        {
            string selectQuery = "select * from students ";
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dgv.DataSource = dataTable;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {



                int studentID = Convert.ToInt32(txtStudentID.Text);
                string name = txtName.Text;
                string gender = comboGender.Text;
                string address = txtAddress.Text;
                DateTime dateOfBirth = dtpDateOfBirth.Value;
                string phoneNumber = txtPhoneNumber.Text;
                string email = txtEmail.Text;
                int? classID = string.IsNullOrEmpty(txtClassID.Text) ? null : (int?)Convert.ToInt32(txtClassID.Text);


                // Kết nối SQL
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True"))
                {
                    connection.Open();

                    // Thực hiện thêm thông tin học sinh vào bảng Students
                    string insertStudentQuery = "INSERT INTO Students (StudentID, Name, DateOfBirth, ClassID, PhoneNumber, Email, Address, Gender) VALUES (@StudentID, @Name, @DateOfBirth, @ClassID, @PhoneNumber, @Email, @Address, @Gender)";
                    using (SqlCommand cmd = new SqlCommand(insertStudentQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@ClassID", classID);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Gender", gender);

                        // Thực thi truy vấn
                        cmd.ExecuteNonQuery();
                    }


                }

            
                // Hiển thị thông báo khi thêm thành công
                MessageBox.Show("Added information successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }



        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem đã chọn một học sinh để xóa chưa
            if (selectedStudentID == -1)
            {
                // Xác nhận xóa học sinh
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Xóa học sinh khỏi database
                    using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True"))
                    {
                        connection.Open();

                        string deleteStudentQuery = "DELETE FROM Students WHERE StudentID = @StudentID";
                        using (SqlCommand cmd = new SqlCommand(deleteStudentQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@StudentID", selectedStudentID);

                            // Thực thi truy vấn
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Hiển thị thông báo khi xóa thành công
                    MessageBox.Show("Deleted student successfully!");

                    // Xóa dữ liệu trên các control
                    ClearControls();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void ClearControls()
        {
            txtStudentID.Text = string.Empty;
            txtName.Text = string.Empty;
            comboGender.Text = string.Empty;
            txtAddress.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtClassID.Text = string.Empty;
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            // Lấy StudentID của học sinh được chọn trong DataGridView
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                selectedStudentID = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);
            }
        }

        private void LoatData()
        {
            // Lấy dữ liệu từ database và hiển thị lên DataGridView
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True"))
            {
                connection.Open();

                string selectStudentsQuery = "SELECT * FROM Students";
                using (SqlCommand cmd = new SqlCommand(selectStudentsQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable studentsTable = new DataTable();
                        adapter.Fill(studentsTable);

                        dgv.DataSource = studentsTable;
                    }
                }
            }
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(txtStudentID.Text);
                string name = txtName.Text;
                string gender = comboGender.Text;
                string address = txtAddress.Text;
                DateTime dateOfBirth = dtpDateOfBirth.Value;
                string phoneNumber = txtPhoneNumber.Text;
                string email = txtEmail.Text;
                int? classID = string.IsNullOrEmpty(txtClassID.Text) ? null : (int?)Convert.ToInt32(txtClassID.Text);

                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True"))
                {
                    connection.Open();

                    // Thực hiện cập nhật thông tin sinh viên trong bảng Students
                    string updateStudentQuery = "UPDATE Students SET Name = @Name, DateOfBirth = @DateOfBirth, ClassID = @ClassID, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address, Gender = @Gender WHERE StudentID = @StudentID";
                    using (SqlCommand cmd = new SqlCommand(updateStudentQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@ClassID", classID);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Gender", gender);

                        // Thực thi truy vấn cập nhật
                        cmd.ExecuteNonQuery();
                    }
                }

                // Gọi hàm FillData để cập nhật DataGridView
                FillData();

                // Hiển thị thông báo khi cập nhật thành công
                MessageBox.Show("Updated information successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("You want to escape ? ", "Chú ý ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                this.Hide();
                Form6 form6 = new Form6();
                form6.ShowDialog();
                this.Dispose();
            }
        }
    }    
              
}
    


















