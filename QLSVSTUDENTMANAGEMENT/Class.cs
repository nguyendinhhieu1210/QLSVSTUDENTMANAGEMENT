using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSVSTUDENTMANAGEMENT
{
    public partial class Class : Form
    {
        SqlCommand command;
        SqlConnection connection;
        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();

        string str = @"Data Source=LAPTOP-Q9UR7MOA\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True";

        public Class()
        {
            InitializeComponent();
        }

        void FillData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from classes";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Class_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            FillData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into classes values('"+txtClassID.Text+"', '"+txtClassName.Text+"')";
            command.ExecuteNonQuery();
            FillData();
        }
    }
}
