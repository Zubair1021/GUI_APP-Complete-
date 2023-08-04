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
    public partial class LatestBuyerAdmin : Form
    {
        public LatestBuyerAdmin()
        {
            InitializeComponent();
            dataGridView1.DataSource = BuyerDL.shop;
            if (BuyerDL.db.Count == 0)
            {
                textBox1.Text = " No Buyer Yet";
                textBox2.Text = " No Buyer Yet";
            }
            else
            {
                textBox1.Text = BuyerDL.db[0].name;
                textBox2.Text = BuyerDL.db[0].finalamount.ToString();
                textBox2.ForeColor = Color.DarkOrange;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }
    }
}
