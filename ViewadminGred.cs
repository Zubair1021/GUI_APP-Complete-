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
    public partial class ViewadminGred : Form
    {
        public ViewadminGred()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewadminGred_Load(object sender, EventArgs e)
        {
            textBox1.Text = AdminDl.ainfo[0].username;
            textBox1.Enabled = false;
            textBox2.Text = AdminDl.ainfo[0].password;
            textBox1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
