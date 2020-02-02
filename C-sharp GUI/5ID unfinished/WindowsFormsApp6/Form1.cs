using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        //int numberofelements = 4; 
        string comText;
        int cPos;
        Dictionary<string, string> txtCollection = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            //textBox2.Text = numberofelements.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_keyPress(object sender, KeyPressEventArgs e)
        {// nai veroqtno comtext e pomoshtna promenliva na koqto se prisvoqva text ama zashto?
            if (comboBox1.Text == "") { comText = ""; }
            if (e.KeyChar == '\b') { return; }
            if (comboBox1.Text.Length == 15)
            {
                MessageBox.Show("фамилаиата е до 15 букви!", "въвеждане на фамилия");
                e.Handled = false;
                return;
            }
            if (e.KeyChar.ToString() != "\r")
            {
                if (e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar >= 'А' && e.KeyChar <= 'Я')
                {
                    comText = comText + e.KeyChar;
                    cPos = comText.Length - 1;
                }
                else { e.Handled = true; }
                if (comText == "") { }
                int index = comboBox1.FindString(comText);
                if (index < 0) { return; }
                comboBox1.SelectedIndex = index;
                comboBox1.Text = comboBox1.SelectedItem.ToString();
                comboBox1.SelectionStart = cPos;
                comboBox1.SelectionLength = comboBox1.Text.Length;
                e.Handled = true;
            }
            else {
                if (comboBox1.FindString(comText) < 0) {
                    comboBox1.Items.Add(comText);
                    comboBox1.Sorted = true;}
            }

            }

        private void txtegn_keypress(object sender, KeyPressEventArgs e)
        {if (textBox1.Text == "") { comText = ""; }
            if (e.KeyChar == '\b') { return; }
            if (textBox1.Text.Length >= 10) {
                MessageBox.Show("ЕГН е 10 Цифри", "въвеждане на ЕГН");
                textBox1.Text = "";
                e.Handled = false;
                return;
            }
            if (e.KeyChar.ToString() != "\r")
            {
                if (e.KeyChar >= '0' && e.KeyChar <= 9)
                {
                    comText = comText + e.KeyChar;
                    cPos = comText.Length - 1;
                }
                //else { e.Handled = true; }
                if (comText == "") { return; }
                int index = comboBox1.FindString(comText);
                if (index < 0) { return; }
                comboBox1.SelectedIndex = index;
                comboBox1.Text = comboBox1.SelectedItem.ToString();
                comboBox1.SelectionStart = cPos;
                comboBox1.SelectionLength = comboBox1.Text.Length;
                e.Handled = true;
            }
            else {
                if (comboBox1.FindString(comText) < 0) {
                    comboBox1.Items.Add(comText);
                    comboBox1.Sorted = true;
                }
            }

        }

        private void updateclick(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                MessageBox.Show("въведете ЕГН", "Актуализация");
                return;
            }
            if (textBox1.Text.Length < 10)
            {
                MessageBox.Show("въведете ЕГН е непълно", "Актуализация");
                return;
            }
            int i = 1;//Array.IndexOf(txtCollection.Keys.ToArray(), textBox1.Text);//1223456789
            if (i >= 0)
            {
                listView1.Items[i].Remove();
                txtCollection.Remove(textBox1.Text);
                string newName = comboBox1.Text;
                string newEGN = textBox1.Text;
                string[] row = {  newName ,newEGN };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                txtCollection.Add(newName, newEGN);
                comboBox1.Text = "";
                textBox1.Text = "";
                //numberofelements += 1;
                //textBox2.Text = numberofelements.ToString();
                return;
            }
            else
            {
                MessageBox.Show("Няма записани Фамилии" + Environment.NewLine, "Актуализация!");
            }
                return;
            }

        private void addnsurname(object sender, EventArgs e)
        {
            string[] row = {  comboBox1.Text ,textBox1.Text};
            var listViewItem = new ListViewItem(row);

            listView1.Items.Add(listViewItem);
            //numberofelements += 1;
            //textBox2.Text = numberofelements.ToString();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
    }