using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icecream123
{
    public partial class Form3 : Form
    {
        double totalPrice = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            listBox1.Items.Add("Coffee ");
            listBox1.Items.Add("OreoCookie ");
            listBox1.Items.Add("Blueberry ");
            listBox1.Items.Add("Mango&Orange ");
            listBox1.Items.Add("Rose ");
            listBox1.Items.Add("BooBoo ");
            listBox1.Items.Add("Matcha ");
            listBox1.Items.Add("Vanilla ");


            listBox2.Items.Add("12");
            listBox2.Items.Add("13");
            listBox2.Items.Add("10");
            listBox2.Items.Add("9");
            listBox2.Items.Add("11");
            listBox2.Items.Add("12");
            listBox2.Items.Add("14");
            listBox2.Items.Add("10");


            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 100;
             
            textBox1.Multiline = true;

         

            listBox2.Visible = false;
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            totalPrice =0 ;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("يرجى تحديد صنف من القائمة");
                return;

            }

            int quantity = (int)numericUpDown1.Value;
            foreach (int index in listBox1.SelectedIndices)
            { 

                string itemName = listBox1.SelectedItem.ToString();
            double Price = double.Parse(listBox2.Items[index].ToString());


            double itemTotal = Price * quantity;
            totalPrice += itemTotal;

            textBox1.AppendText($"{itemName} *{quantity}={itemTotal:0.00}$" + Environment.NewLine); 
            }
            label1.Text = $"Total:{totalPrice:0.00}$";









            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
