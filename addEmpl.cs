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
    public partial class addEmpl : Form
    {
        public addEmpl()
        {
            InitializeComponent();
            dataGridView1.DataSource = EmployeeDl.emp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""|| textBox4.Text == "")
            {
                MessageBox.Show("Field Never Empty");

            }
            else
            {
                if (textBox2.Text == "0" || textBox3.Text == "0")
                {
                    MessageBox.Show("Employee Salary And Phone no of Employee Never Zero");
                }
                else
                {
                    string name;
                    int salary;
                    string shift;
                    int phone;
                    name = textBox1.Text;
                    salary = int.Parse(textBox2.Text);
                    shift = textBox3.Text;
                    phone = int.Parse(textBox4.Text);
                    Employee empl = new Employee(name, salary, shift, phone);
                    EmployeeDl.emp.Add(empl);
                    MessageBox.Show("New Item Added Successfully");
                    textBox1.Clear();
                    textBox2.Text = "0";
                    textBox3.Clear();
                    textBox4.Text = "0";
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = EmployeeDl.emp;
                    dataGridView1.Refresh();

                }
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
