using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class NII17621301: UserControl
    {
        public override string Text
        {
            get { return textBox1.Text; }
        }
        public NII17621301()
        {
            InitializeComponent();
        }
        private bool parLangValue = true;
        public bool parLang
        {
            get {
                return parLangValue;
            }
            set {
                parLangValue = value;
            }
        }
        private void KP_textb(object sender, KeyPressEventArgs e)
        {
                    
        }

        private void KP_textb2(object sender, KeyPressEventArgs e)
        {
            if (parLang == true)
            {
                if ((e.KeyChar >= 'а' & e.KeyChar <= 'я') || (e.KeyChar >= 'А' & e.KeyChar <= 'Я'))
                { }
                else
                    if ((e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == Convert.ToChar(Keys.Enter)))
                { e.Handled = false; }
                else
                { e.Handled = true; }
            }
            else
            {
                if ((e.KeyChar >= 'a' & e.KeyChar <= 'z') || (e.KeyChar >= 'A' & e.KeyChar <= 'Z'))
                { }
                else
                    if ((e.KeyChar == Convert.ToChar(Keys.Back)) || (e.KeyChar == Convert.ToChar(Keys.Enter)))
                { e.Handled = false; }
                else
                { e.Handled = true; }
            }
        }
    }
}
