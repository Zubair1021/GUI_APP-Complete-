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
    public partial class ViewStockEmpl : Form
    {
        public ViewStockEmpl()
        {
            InitializeComponent();
            dataGridView1.DataSource = stockDl.stock;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Fun page = new Employee_Fun();
            page.Show();
            Visible = true;
        }
    }
}
