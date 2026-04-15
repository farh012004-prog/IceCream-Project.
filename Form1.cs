using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icecream123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correctUserName = "IecCream";
            string correctPassword = "IC123";

            string enteredUserName = textBox1.Text;
            string enteredPassword = textBox2.Text;

            if (enteredUserName == correctUserName && enteredPassword == correctPassword)
            {
                label1.Text = "ok";
                label1.ForeColor = Color.Green;

                label2.Text = "ok";
                label2.ForeColor = Color.Green;

                Form4 FO4 = new Form4();
                FO4.Show();

            }
            else
            {
                if (enteredUserName != correctUserName)
                {
                    label1.Text = "no";
                    label1.ForeColor = Color.Red;
                }else
                { label1.Text = "ok";
                label1.ForeColor = Color.Green;}

                    if (enteredPassword != correctPassword)
                
                    {
                        label2.Text = "no";
                        label2.ForeColor = Color.Red;
                }
                else
                {
                    label2.Text = "ok";
                    label2.ForeColor = Color.Green;
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.ShowDialog();
        
    }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
