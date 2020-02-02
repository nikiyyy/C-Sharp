using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_textchange(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                //decimal suma = 0;
                decimal suma = System.Convert.ToDecimal(textBox1.Text) + System.Convert.ToDecimal(textBox2.Text) - System.Convert.ToDecimal(textBox3.Text);
                string str = suma.ToString("0");
                textBox4.Text = str;
            }
            else
            {
                textBox1.Text = "0";
            }

            

        }

        private void sum_textchange2(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                //decimal suma = 0;
                decimal suma = System.Convert.ToDecimal(textBox2.Text) + System.Convert.ToDecimal(textBox1.Text) - System.Convert.ToDecimal(textBox3.Text);
                string str = suma.ToString("0");
                textBox4.Text = str;
            }
            else
            {
                textBox2.Text = "0";
            }
        }

        private void sum_textchange3(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                //decimal suma = 0;
                decimal suma = System.Convert.ToDecimal(textBox2.Text) + System.Convert.ToDecimal(textBox1.Text) - System.Convert.ToDecimal(textBox3.Text);
                string str = suma.ToString("0");
                textBox4.Text = str;
            }
            else
            {
                textBox3.Text = "0";
            }
        }
    }
}
