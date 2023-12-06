using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVSTUDENTMANAGEMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NguyenDinhHieu" && textBox2.Text.Equals("BH01099"))
            {
                MessageBox.Show("Logged in successfully ");
                Form7 form7 = new Form7();
                this.Hide();
                form7.ShowDialog();
                this.Close();
            }
            else if (textBox1.Text == "NgoThiNgocAnh" && textBox2.Text.Equals("11112004"))
            {
                MessageBox.Show("Logged in successfully ");
                Form6 form6 = new Form6();
                this.Hide();
                form6.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password ");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to escape ?";
            string title = "Notification";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = (char)0;
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
            }
        
    

