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
    public partial class addstock : Form
    {
        
        public addstock()
        {
            InitializeComponent();

            dataGridView1.DataSource = stockDl.stock;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Field Never Empty");
                
            }
            if (textBox2.Text == "0")
            {
                MessageBox.Show("Price of item Never Zero");
            }

            else
            {
                string itemname;
                int itemprice;
                string itemrack;
               itemname = textBox1.Text ;
               itemprice= int.Parse(textBox2.Text) ;
                itemrack= textBox3.Text ;
                stock s = new stock(itemname, itemprice, itemrack);
                stockDl.stock.Add(s);
                MessageBox.Show("New Item Added Successfully");
                textBox1.Clear();
                textBox2.Text="0";
                textBox3.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = stockDl.stock;
                dataGridView1.Refresh();

            }
            

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            AdminFunc admainpage = new AdminFunc();
            admainpage.Show();
            Visible = false;
        }

        private void addstock_Load(object sender, EventArgs e)
        {

        }
    }
}
