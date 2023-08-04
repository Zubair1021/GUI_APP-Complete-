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
    public partial class LatestBuyerEmpl : Form
    {
        public LatestBuyerEmpl()
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
            Employee_Fun page = new Employee_Fun();
            page.Show();
            Visible = true;
        }
    }
}
