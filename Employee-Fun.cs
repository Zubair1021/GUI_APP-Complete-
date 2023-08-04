using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessAppGUI
{
    public partial class Employee_Fun : Form
    {
        public Employee_Fun()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                EmplPassChange page = new EmplPassChange();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "2")
            {
                ViewStockEmpl page = new ViewStockEmpl();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "3")
            {
                LatestBuyerEmpl page = new LatestBuyerEmpl();
                page.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Please Select the Correct Option ");
                textBox1.BackColor = Color.Red;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empl_Main page = new Empl_Main();
            page.Show();
            Visible = false;
        }
    }
}
