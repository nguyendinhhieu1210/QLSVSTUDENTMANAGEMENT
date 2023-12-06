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
    public partial class FormStudent : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public FormStudent()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loatdata();

        }

        void loatdata()
        {


            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Students";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("You want to escape ? ", "Chú ý ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }
    }
}
