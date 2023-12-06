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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnview1_Click(object sender, EventArgs e)
        {
            FormTeacher f = new FormTeacher();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnview2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
