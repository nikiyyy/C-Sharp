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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Width = (statusStrip1.Width / 2);
            toolStripStatusLabel2.Width = (toolStripStatusLabel1.Width / 2);
            toolStripStatusLabel3.Width = (toolStripStatusLabel1.Width / 2) - 20;

        }
        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void txtName_MouseMove(object sender, EventArgs e)
        {
            string s = "Enter name";
            toolStripStatusLabel1.Text = s;
        }

        private void txtName_MouseMove2(object sender, EventArgs e)
        {
            string s = "Enter surname";
            toolStripStatusLabel1.Text = s;
        }

        private void txtName_MouseMove3(object sender, EventArgs e)
        {
            string s = "Enter familyname";
            toolStripStatusLabel1.Text = s;
        }

        private void txtName_MouseMove4(object sender, EventArgs e)
        {
            string s = "Enter EGN";
            toolStripStatusLabel1.Text = s;
        }

        private void txtName_MouseMove5(object sender, EventArgs e)
        {
            string s = "Enter Adress";
            toolStripStatusLabel1.Text = s;
        }

        private void Action_proc(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            toolStripStatusLabel2.Text = d.ToLongTimeString();
            toolStripStatusLabel3.Text = d.ToLongDateString();

        }

        private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void name_kp(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!(Char.IsLetter(c)))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Въвеждайте само букви!", "Въвеждане на име, презиме и ФАМИЛИЯ", buttons);
                e.Handled = true;
            }


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            int pos = textBox1.SelectionStart;// първоначална позиция на курсора
            int TextL = textBox1.Text.Length;// дължина на въведения стринг
            if (TextL > 0)
            {
                string TextFirst = textBox1.Text.Substring(0, 1);// първа буква
                string TextEnd = textBox1.Text.Substring(1, TextL - 1);// всички останали
                textBox1.Text = TextFirst.ToUpper() + TextEnd.ToLower();
                textBox1.SelectionStart = pos;// възстановяване позицията на курсра
            }

        }

        private void txtName_TextChanged2(object sender, EventArgs e)
        {
            int pos = textBox2.SelectionStart;// първоначална позиция на курсора
            int TextL = textBox2.Text.Length;// дължина на въведения стринг
            if (TextL > 0)
            {
                string TextFirst = textBox2.Text.Substring(0, 1);// първа буква
                string TextEnd = textBox2.Text.Substring(1, TextL - 1);// всички останали
                textBox2.Text = TextFirst.ToUpper() + TextEnd.ToLower();
                textBox2.SelectionStart = pos;// възстановяване позицията на курсра
            }
        }

        private void txtName_TextChanged3(object sender, EventArgs e)
        {
            int pos = textBox3.SelectionStart;// първоначална позиция на курсора
            int TextL = textBox3.Text.Length;// дължина на въведения стринг
            if (TextL > 0)
            {
                string TextFirst = textBox3.Text.Substring(0, 1);// първа буква
                string TextEnd = textBox3.Text.Substring(1, TextL - 1);// всички останали
                textBox3.Text = TextFirst.ToUpper() + TextEnd.ToLower();
                textBox3.SelectionStart = pos;// възстановяване позицията на курсра
            }
        }

        private void egn_keypress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((Char.IsLetter(c)))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Въвеждайте само цифри!", "Въвеждане на ЕГН", buttons);
                e.Handled = true;
            }
        }

        private void adress_keypress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsPunctuation(c))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Въвеждайте само букви и цифри!", "Въвеждане на Адрес", buttons);
                e.Handled = true;
            }
        }

        private void name_kd(object sender, KeyEventArgs e)
        {
            textBox2.Focus();
        }

        private void prezim_down(object sender, KeyEventArgs e)
        {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        textBox1.Focus();
                        break;
                    case Keys.Down:
                        textBox3.Focus();
                        break;
                };

        }

        private void from3_mc(object sender, MouseEventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.ShowDialog();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
