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
    public partial class MainBuyer : Form
    {
        public MainBuyer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage2 page = new MainPage2();
            page.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buyer2 page = new Buyer2();
            page.Show();
            Visible = false;
        }

        private void MainBuyer_Load(object sender, EventArgs e)
        {

        }
    }
}
