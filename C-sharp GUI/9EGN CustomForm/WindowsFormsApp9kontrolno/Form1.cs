using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9kontrolno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (userControl11.Text.Length == 10)
            {
                string value = userControl11.Text;
                char third = value[2];// moje da 0 ili 1
                char forth = value[3];// moje da 0 do 9 ama i devete ne mogat da sa 0
                char fifth = value[4];// moje da e ot 0 do 3
                char sixth = value[5];// moje da e ot 0 do 9 obache ako fifth
                if (!(third != '0' && third != '1' && third != '3' && third != '4') && ((forth != '0' && third != '0') || forth != '0'))
                {
                    if (!(fifth != '0' && fifth != '1' && fifth != '3'))
                    {
                        label1.Text = userControl11.Text;
                    }
                    else
                    {
                        MessageBox.Show("ЕГН не валидно", "EGN");
                    }
                }
                else
                {
                    MessageBox.Show("ЕГН трябва да е 10 символа", "EGN");
                }
            }
            else
            {
                MessageBox.Show("ЕГН трябва да е 10 символа", "EGN");
            }
        }
    }
}