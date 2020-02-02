using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary2
{
    
    public partial class UserControl1: UserControl
    {
        public override string Text
        {
            get { return textBox1.Text; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kp_textbox(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' & e.KeyChar <= '9')
                { }
            else
            if ((e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == Convert.ToChar(Keys.Enter)))
                { e.Handled = false; }
            else
            { e.Handled = true; }
                
        }

        private void click(object sender, MouseEventArgs e)
        {

        }
    }
}
