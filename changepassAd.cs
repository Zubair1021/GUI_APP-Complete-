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
    public partial class changepassAd : Form
    {
        public changepassAd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == AdminDl.ainfo[0].username && password == AdminDl.ainfo[0].password)
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                button3.Visible = true;
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

        private void button3_Click(object sender, EventArgs e)
        {

                if (textBox3.Text == "")
                    MessageBox.Show("New UserName Field Is Empty");
                if (textBox4.Text == "")
                    MessageBox.Show("New Password Field Is Empty");

            else
            {
                Admin a = new Admin();
                a.username = textBox3.Text;
                a.password = textBox4.Text;

                AdminDl.ainfo.RemoveAt(0);
                AdminDl.ainfo.Insert(0, a);
                MessageBox.Show("Your UserName And Password is Changed SuccessFully");

            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
