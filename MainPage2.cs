using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessAppGUI.DL;
using BussinessAppGUI.BL;

using System.Windows.Forms;

namespace BussinessAppGUI
{
    public partial class MainPage2 : Form
    {
        public MainPage2()
        {
            InitializeComponent();

        }

        private void MainPage2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Main adminpage = new Admin_Main();
            adminpage.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empl_Main emplpage = new Empl_Main();
            emplpage.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainBuyer page = new MainBuyer();
            page.Show();
            Visible=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.Show();
            Visible = false;
        }
    }
}
