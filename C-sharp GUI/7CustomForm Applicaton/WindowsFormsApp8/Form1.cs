using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (niI176213011.parLang == true) {
                niI176213011.parLang = false;
                label2.Text = "ENGLISH";
            }

            else {
                niI176213011.parLang = true;
                label2.Text = "BULGARIAN"; }

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = niI176213011.Text;
        }
    }
}
