using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] stringrray;
            List<string> temp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            string[] stringArray = new string[] { };
            stringArray = txtText.Text.Split(' ');
            for (int i = 0; i < stringArray.Count(); i++) {
                if (stringArray[i].Trim() != "") {
                    listBox1.Items.Add(stringArray[i].Trim().ToLower() );
                }
            }
        }

        private void BtnUnique_Click(object sender, EventArgs e)
        {
            
                List<string> temp = new List<string>();
                string itemP = listBox1.Items[0].ToString();
                for (int i = 1; i < listBox1.Items.Count; i++) {
                    string item = listBox1.Items[i].ToString();
                    if (item.Contains(itemP))
                    {
                        temp.Add(item);
                    }
                    else {
                        itemP = listBox1.Items[i].ToString();
                    }

                }
                foreach (string item in temp)
                {
                    listBox1.Items.Remove(item);
                }
            
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted=true;
        }

        private void BtnWords_Click(object sender, EventArgs e)
        {
            txtText.Text = txtText.Text.Replace("!", " ");
            txtText.Text = txtText.Text.Replace(";", " ");
            txtText.Text = txtText.Text.Replace(".", " ");
            txtText.Text = txtText.Text.Replace(",", " ");
            txtText.Text = txtText.Text.Replace("(", " ");
            txtText.Text = txtText.Text.Replace(")", " ");
        }
    }
}
