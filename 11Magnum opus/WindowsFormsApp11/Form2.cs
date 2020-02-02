using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        string name_loc;
        string surname_loc;
        string famname_loc;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void UserControl11_Load(object sender, EventArgs e)
        {

        }

        private void pls(object sender, EventArgs e)
        {
            //label4.Text = userControl11.Text + " " + userControl12.Text+". "+ userControl13.Text;
            string minis = "";
            if (userControl12.Text.Length != 0)
            {
                minis = userControl12.Text[0].ToString() + ".";
            }
            label4.Text = userControl11.Text + " " + minis + " " + userControl13.Text;
        }

        private void pls2(object sender, EventArgs e)
        {
            string minis="";
            if (userControl12.Text.Length != 0) {
                minis = userControl12.Text[0].ToString()+".";
            }
            label4.Text = userControl11.Text + " " + minis + " " + userControl13.Text;
        }

        private void pls3(object sender, EventArgs e)
        {
            //label4.Text = userControl11.Text + " " + userControl12.Text + ". " + userControl13.Text;
            string minis = "";
            if (userControl12.Text.Length != 0)
            {
                minis = userControl12.Text[0].ToString() + ".";
            }
            label4.Text = userControl11.Text + " " + minis + " " + userControl13.Text;
        }

        void DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.Cancel == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fILEToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            editToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            userControl11.Text = "";
            userControl12.Text = "";
            userControl13.Text = "";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter stw = new StreamWriter(s))
                {
                    stw.Write(userControl11.Text + " ");
                    stw.Write(userControl12.Text + " ");
                    stw.Write(userControl13.Text + " ");
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;

                using (TextReader reader = File.OpenText(filepath))
                {
                    string text = reader.ReadLine();
                    string[] vars = text.Split(' ');

                    name_loc = vars[0];
                    surname_loc = vars[1];
                    famname_loc = vars[2];
                }
                
                label4.Text = name_loc + " " + surname_loc[0] + ". " + famname_loc;
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Forma = new Form2();
            Forma.Show();
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                label4.ForeColor = colorDialog1.Color;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label4.Font = fontDialog1.Font;
            }
        }

        private void HideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
