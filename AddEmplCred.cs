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
    public partial class AddEmplCred : Form
    {
        public AddEmplCred()
        {
            InitializeComponent();
            dataGridView1.DataSource = EmployeeDl.ec;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Field Never Empty");

            }

            else
            {
                string name;
                string password;
                name = textBox1.Text;
                password = textBox2.Text;
                EmployeeCRed s = new EmployeeCRed(name,password);
                EmployeeDl.ec.Add(s);
                MessageBox.Show("New Employee Credentials Added Successfully");
                textBox1.Clear();
                textBox2.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = EmployeeDl.ec;
                dataGridView1.Refresh();

            }
        }
    }
}
