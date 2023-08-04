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
    public partial class updatestock : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public updatestock()
        {
            InitializeComponent();
            dataGridView1.DataSource = stockDl.stock;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
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
            string name = textBox1.Text;
            

            for (int x = 0; x < stockDl.stock.Count; x++)
            {
                if (name == stockDl.stock[x].itemname)
                {
                    int price = int.Parse(textBox2.Text);
                    string rack = textBox3.Text;
                    stock s = new stock(name, price, rack);
                    
                    stockDl.stock.RemoveAt(x);
                    stockDl.stock.Insert(x, s);
                    MessageBox.Show("Product Updated SuccessFully");
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
    }
}
