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
    public partial class AdminFunc : Form
    {
        public AdminFunc()
        {
            InitializeComponent();
        }

        private void AdminFunc_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage2 mainpage = new MainPage2();
            mainpage.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                changepassAd page = new changepassAd();
                page.Show();
                Visible = false;
            }
           else if (textBox1.Text == "2")
            {
                ViewadminGred page = new ViewadminGred();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "7")
            {
                ViewStock page = new ViewStock();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "3")
            {
                addstock page = new addstock();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "4")
            {
                updatestock page = new updatestock();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "6")
            {
             DeleteProductForm page = new DeleteProductForm();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "9")
            {
                seeEmployee page = new seeEmployee();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "8")
            {
                updateEmpInfo page = new updateEmpInfo();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "10")
            {
               addEmpl page = new addEmpl();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "11")
            {
                seeEmpCred page = new seeEmpCred();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "12")
            {
                AddEmplCred page = new AddEmplCred();
                page.Show();
                Visible = false;
            }
            else if (textBox1.Text == "5")
            {
                LatestBuyerAdmin page = new LatestBuyerAdmin();
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
    }
}
