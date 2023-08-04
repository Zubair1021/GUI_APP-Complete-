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
    public partial class EmplPassChange : Form
    {
        int result;
        public EmplPassChange()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Fun page = new Employee_Fun();
            page.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
             result = EmployeeDl.checkEmplavaliable(username, password);
            if(result>=0)
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
                EmployeeCRed a = new EmployeeCRed();
                a.username = textBox3.Text;
                a.password = textBox4.Text;

                EmployeeDl.ec.RemoveAt(result);
                EmployeeDl.ec.Insert(result, a);
                MessageBox.Show("Your UserName And Password is Changed SuccessFully");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
