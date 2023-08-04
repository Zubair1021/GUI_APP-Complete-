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
    public partial class updateEmpInfo : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public updateEmpInfo()
        {
            InitializeComponent();
            dataGridView1.DataSource = EmployeeDl.emp ;
        }

        private void updateEmpInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;
            string name = textBox1.Text;


            for (int x = 0; x < EmployeeDl.emp.Count; x++)
            {
                if (name == EmployeeDl.emp[x].employeename)
                {
                    int salary = int.Parse(textBox2.Text);
                    string shift = textBox3.Text;
                    int Phone = int.Parse(textBox4.Text);
                    Employee empl = new Employee(name, salary, shift,Phone);

                    EmployeeDl.emp.RemoveAt(x);
                    EmployeeDl.emp.Insert(x, empl);
                    MessageBox.Show("Employee Information Updated SuccessFully");
                    break;
                }
            }
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
