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
    public partial class Form5 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loatdata()
        {


            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Grades"; 
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        void FillcBoxStudent()
        {
            command = connection.CreateCommand();
            command.CommandText = "select StudentID from students";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxStudent.DataSource = dt;
            cBoxStudent.DisplayMember = "StudentID";
            cBoxStudent.ValueMember = "StudentID";
        }
        void FillcBoxSubject()
        {
            command = connection.CreateCommand();
            command.CommandText = "select SubjectID from Subject";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxSubject.DataSource = dt;
            cBoxSubject.DisplayMember = "SubjectID";
            cBoxSubject.ValueMember = "SubjectID";
        }

        void FillcBoxTeacher()
        {
            command = connection.CreateCommand();
            command.CommandText = "select TeacherID from Teachers";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxTeacher.DataSource = dt;
            cBoxTeacher.DisplayMember = "TeacherID";
            cBoxTeacher.ValueMember = "TeacherID";
        }

        void FillcBoxClass()
        {
            command = connection.CreateCommand();
            command.CommandText = "select ClassID from classes";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxClass.DataSource = dt;
            cBoxClass.DisplayMember = "ClassID";
            cBoxClass.ValueMember = "ClassID";
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loatdata();
            FillcBoxStudent();
            FillcBoxClass();
            FillcBoxTeacher();
            FillcBoxSubject();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Grades set ClassID = '" + cBoxClass.Text + "', TeacherID = '" + cBoxTeacher.Text + "', SubjectID = '" + cBoxSubject.Text + "', ExamCount = '" + txtExamCount.Text + "', ExamSorce='" + txtExamSorce.Text + "'where StudentID='" + cBoxStudent.Text + "'";
            command.ExecuteNonQuery();
            loatdata();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Grades values ('" + cBoxClass.Text + "','" + cBoxTeacher.Text + "','" + cBoxStudent.Text + "','" + cBoxSubject.Text + "','" + txtExamCount.Text + "','" + txtExamSorce.Text + "')";
            command.ExecuteNonQuery();
            loatdata();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Grades where StudentID = '" + cBoxStudent.Text + "'";
            command.ExecuteNonQuery();
            loatdata();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Grades set ClassID = '" + cBoxClass.Text + "', TeacherID = '" + cBoxTeacher.Text + "', SubjectID = '" + cBoxSubject.Text + "', ExamCount = '" + txtExamCount.Text + "', ExamSorce='" + txtExamSorce.Text + "'where StudentID='" + cBoxStudent.Text + "'";
            command.ExecuteNonQuery();
            loatdata();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            cBoxClass.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cBoxTeacher.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cBoxStudent.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cBoxSubject.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtExamCount.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txtExamSorce.Text = dgv.Rows[i].Cells[5].Value.ToString();
        }
    }
}

