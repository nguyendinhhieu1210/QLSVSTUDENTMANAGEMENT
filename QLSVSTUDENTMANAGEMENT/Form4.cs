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
    public partial class Form4 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-Q9UR7MOA\\NGUYENDHINHHIEU;Initial Catalog=STUDENTMANAGEMENT1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
         
            
                connection = new SqlConnection(str);
                connection.Open();
                loatdata();

            

        }
        private void loatdata()
        {
           


                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Grades";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("You want to escape ? ", "Chú ý ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }
    }
}
