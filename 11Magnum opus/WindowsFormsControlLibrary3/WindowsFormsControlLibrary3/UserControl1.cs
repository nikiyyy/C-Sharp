using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary3
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
        private void tc(object sender, EventArgs e)
        {

            if (textBox1.Text.Length <= 1)
            {
                textBox1.CharacterCasing = CharacterCasing.Normal;
            }
            if (textBox1.Text.Length <= 0)
            {
                textBox1.CharacterCasing = CharacterCasing.Upper;
            }

        }
        //avtomatichno generiran string
        private void keypress(object sender, KeyPressEventArgs e)
        {

                if ((e.KeyChar >= 'а' & e.KeyChar <= 'я') || (e.KeyChar >= 'А' & e.KeyChar <= 'Я'))
                {
                if ((e.KeyChar >= 'А' & e.KeyChar <= 'Я') & textBox1.Text.Length >=1) {
                    e.Handled = true;
                }
                }
                else
                     if ((e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == Convert.ToChar(Keys.Enter)))
                {
                e.Handled = false;
                }
                else
                {
                e.Handled = true;
                }


            }




        }
    }

