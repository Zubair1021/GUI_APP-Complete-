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
    public partial class DeleteProductForm : Form
    {
        int index;
        public DeleteProductForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = stockDl.stock;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int result = stockDl.checkitemavaliable(name);
            if (result !=-1)
            {
                stockDl.stock.RemoveAt(result);
                MessageBox.Show("Product Deleted SuccessFully");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = stockDl.stock;
                dataGridView1.Refresh();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter the Correct Name");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }
    }
}
