using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVSTUDENTMANAGEMENT
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnview1_Click(object sender, EventArgs e)
        {
            FormStudent f = new FormStudent();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnview2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
