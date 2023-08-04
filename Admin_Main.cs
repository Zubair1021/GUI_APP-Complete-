using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessAppGUI.DL;
using BussinessAppGUI.BL;

namespace BussinessAppGUI
{
    

    public partial class Admin_Main : Form
    {


        public Admin_Main()
        {

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage2 mainpage = new MainPage2();
            mainpage.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDl a = new AdminDl();
            string name = textBox1.Text;
            string pass = textBox2.Text;
            bool result = AdminDl.check(name, pass);
            if(result==true)
            {
                AdminFunc admainpage = new AdminFunc();
               admainpage.Show();
                Visible = false;

            }
            else
            {
                MessageBox.Show("Your UserName And Password is Incorrect");
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.Black;
                textBox1.Clear();
                textBox2.Clear();

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void Admin_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
