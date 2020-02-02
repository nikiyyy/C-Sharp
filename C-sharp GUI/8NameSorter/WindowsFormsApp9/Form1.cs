using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ";
            for (int i = 0; i < alphabet.Length; i++)
            {
                TabPage tp = new TabPage();
                tp.Text = alphabet[i].ToString();
                tabControl1.TabPages.Add(tp);
                //ColumnHeader ch = new ColumnHeader();
                ListView lv = new ListView();
                lv.Dock = System.Windows.Forms.DockStyle.Fill;
                lv.FullRowSelect = true;
                lv.GridLines =true;
                foreach (var element in listBox1.Items) {
                    string temp = element.ToString();
                    if (alphabet[i].ToString() == temp[0].ToString())
                    {
                        lv.Items.Add(element.ToString());
                        
                    }
                }
                //sus filtur proverqvam purvata bukva ot veseki element(for i in) ot listbox ,posle dobavaqm listview v tp.conntrol
                tp.Controls.Add(lv);
            }
            //listBox1.Items


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
