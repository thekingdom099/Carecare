using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ทะเบียนของท่าน", "คำเตือน");
                    textBox1.Focus();
                }
                else
                    textBox2.Focus();
            }
        }
        double a1, total, sum;
        double ton, totaltotal, find;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                a1 = double.Parse(textBox18.Text);
                a1 = 1350;
            }
            total = a1;
            textBox18.Text = total.ToString("#,#0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, D1, D2, D3, D4;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            D1 = 0;
            D2 = 0;
            D3 = 0;
            D4 = 0;
            if (checkBox1.Checked)
            {
                a = 2000;
            }
            if (checkBox2.Checked)
            {
                b = 250;
            }
            if (checkBox3.Checked)
            {
                c = 550;
            }
            if (checkBox4.Checked)
            {
                d = 1000;
            }
            if (checkBox5.Checked)
            {
                D1 = 45;
            }
            if (checkBox6.Checked)
            {
                D2 = 60;
            }
            if (checkBox7.Checked)
            {
                D3 = 75;
            }
            if (checkBox8.Checked)
            {
                D4 = 45;
            }
            sum = a + b + c + d + D1 + D2 + D3 + D4 + total;
            textBox18.Text = sum.ToString("#,#0.00");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox19.Text != "")
            {
                ton = double.Parse(textBox19.Text);
                find = sum;
                textBox18.Text = find.ToString("#,#0.00");
                totaltotal = ton - find;
                textBox20.Text = totaltotal.ToString("#,#0.00");
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                a1 = double.Parse(textBox18.Text);
                a1 = 500;
            }
            total = a1;
            textBox18.Text = total.ToString("#,#0.00");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a1 = double.Parse(textBox18.Text);
                a1 = 120;
            }
            total = a1;
            textBox18.Text = total.ToString("#,#0.00");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("กรุณาใส่ชื่อของท่าน", "คำเตือน");
                    textBox2.Focus();
                }
                else
                    maskedTextBox1.Focus();
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Text = textBox1.Text;
                textBox5.Text = textBox2.Text;
                textBox6.Text = maskedTextBox1.Text;
            }



        }
    }
}
