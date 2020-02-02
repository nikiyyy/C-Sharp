using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmMenu : Form
    {
        public string[,] MainText = new string[,] { { "Файл", "Редактор", "Покажи", "Помощ" }, { "File", "Edit", "View", "Help" } };
        public string[,] FileItems = new string[,] { { "Нов", "Отвори", "Затвори", " ", "Край" }, { "New", "Open", "Close", " ", "Exit" } };
        bool pozremember = true;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (menuStrip1.Items.Count - 1)); i++)
            {
                menuStrip1.Items[i].Text = MainText[0, i];

            }
            for (i = 0; (i <= (toolStripMenuItem1.DropDownItems.Count - 1)); i++)
            {
                toolStripMenuItem1.DropDownItems[i].Text = FileItems[0, i];
            }
            pozremember = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; (i <= (menuStrip1.Items.Count - 1)); i++)
            {
                menuStrip1.Items[i].Text = MainText[1, i];

            }
            for (i = 0; (i <= (toolStripMenuItem1.DropDownItems.Count - 1)); i++)
            {
                toolStripMenuItem1.DropDownItems[i].Text = FileItems[1, i];
            }
            pozremember = true;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.menuStrip1.Visible == true)
            {
                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
            }
            else
            {
                menuStrip1.Visible = true;
                menuStrip2.Visible = false;
            }
            
        }
        public void Filemenunul()
        {
            newToolStripMenuItem.Checked = false;
            openToolStripMenuItem.Checked = false;
            closeToolStripMenuItem.Checked = false;
            endToolStripMenuItem.Checked = false;
        }
        private void newcclick(object sender, EventArgs e)
        {
            if (newToolStripMenuItem.Checked != true)
            {
                Filemenunul();
                newToolStripMenuItem.Checked = true;
            }
            else
            {
                newToolStripMenuItem.Checked = false;
            }
        }
        private void openclick(object sender, EventArgs e)
        {
            if (openToolStripMenuItem.Checked != true)
            {
                Filemenunul();
                openToolStripMenuItem.Checked = true;
            }
            else
            {
                openToolStripMenuItem.Checked = false;
            }
        }
        private void closeclick(object sender, EventArgs e)
        {
            if (closeToolStripMenuItem.Checked != true)
            {
                Filemenunul();
                closeToolStripMenuItem.Checked = true;
            }
            else
            {
                closeToolStripMenuItem.Checked = false;
            }
        }
        private void endclick(object sender, EventArgs e)
        {
            if (endToolStripMenuItem.Checked != true)
            {
                Filemenunul();
                endToolStripMenuItem.Checked = true;
            }
            else
            {
                endToolStripMenuItem.Checked = false;
            }
        }

        private void ЕдитToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.menuStrip1.Visible == true && toolStripMenuItem3.DropDownItems.Count==0)
            {
                ToolStripMenuItem CodeToolStripMenuItem = new ToolStripMenuItem();
                ToolStripMenuItem FormToolStripMenuItem = new ToolStripMenuItem();
                CodeToolStripMenuItem.Text = "Code";
                FormToolStripMenuItem.Text = "Form";
                toolStripMenuItem3.DropDownItems.Add(CodeToolStripMenuItem);
                toolStripMenuItem3.DropDownItems.Add(FormToolStripMenuItem);
                CodeToolStripMenuItem.Click += new System.EventHandler(this.CodeToolStripMenuItem_Click);
                FormToolStripMenuItem.Click += new System.EventHandler(this.FormToolStripMenuItem_Click);
            }
        }

        private void CodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Позиция code", "нови позиции");
        }
        private void FormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Позиция form", "нови форми");
        }
    }
}
