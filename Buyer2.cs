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
    public partial class Buyer2 : Form
    {
        public Buyer2()
        {
            InitializeComponent();
            dataGridView1.DataSource = stockDl.stock;
            
            // Due to a lot of Buyers we are unable to handle all Buyer data so we only store a very latest Buyer Record
            BuyerDL.shop.Clear();
            BuyerDL.db.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="")
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                dataGridView1.Visible = true;

            }
            else
            {
                MessageBox.Show("Please Enter Your Name ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainBuyer page = new MainBuyer();
            page.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty || textBox2.Text == string.Empty|| textBox3.Text == " ")
            {
                MessageBox.Show("Field Never Empty,Quantity must enter");
            }

            else
            {
                int Quan = int.Parse(textBox3.Text);
                String name = textBox2.Text;
                int sum = 0;

                int index = stockDl.checkitemavaliable(name);
                if (index >= 0)
                {

                    sum = Quan * stockDl.stock[index].itemprice;
                    Buyer b = new Buyer(name, Quan, sum);
                    BuyerDL.shop.Add(b);
                    MessageBox.Show("Product Added in Purchase List");

                }
                else
                {
                    MessageBox.Show("Product Not Found");
                }
            }

            textBox2.Clear();
            textBox3.Clear();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BuyerDL.shop .Count== 0)
            {
                MessageBox.Show("No Item Purchased");
            }
            else
            {
                float price = TotalPrice();
                string name = textBox1.Text;
               detailofBuyer buyerdetail = new detailofBuyer(name, price);
                BuyerDL.db.Add(buyerdetail);
                Buyer3 page = new Buyer3();
                page.Show();
                Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private float TotalPrice()
        {
            float sum=0;
            for (int x = 0; x < BuyerDL.shop.Count; x++)
            {
                sum = sum + BuyerDL.shop[x].price;
            }
            return sum;
        }
    }
}
