using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("new clicked", "new");
        }
        int parPos = 1;
        public void btnDock_Click(Object sender, System.EventArgs e)
        {
            if (parPos > 4) {
                parPos = 1;
            }
            switch (parPos)
            {
                case 1:
                    {

                        menuStrip1.Dock = DockStyle.Right;
                        break;
                    }
                case 2:
                    {
                        menuStrip1.Dock = DockStyle.Bottom;
                        break;
                    }
                case 3:
                    {
                        menuStrip1.Dock = DockStyle.Left;
                        break;
                    }
                case 4:
                    {
                        menuStrip1.Dock = DockStyle.Top;
                        break;
                    }
            }
            parPos++;
        }

        public void generating_Button()
        {   
            Button btnDock = new Button();
            btnDock.Text = "Spin menu";
            btnDock.Left = this.Width / 2;
            btnDock.Top = this.Height / 2;
            btnDock.Click += new System.EventHandler(this.btnDock_Click);
            Controls.Add(btnDock);
        }

        /////
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("edit clicked", "edit");
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("view clicked", "view");
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("help clicked", "help");
        }
        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void endToolStripMenuItem_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("end clicked", "end");
            this.Close();
        }
        ///

        public void generating_menustrip()
        {
            //file opci
            ToolStripMenuItem fileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.Items.Add(fileToolStripMenuItem);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);// suzdai funkciq sus fileToolStripMenuItem_Click ime

            ToolStripMenuItem newToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem.Text = "New";
            fileToolStripMenuItem.DropDownItems.Add(newToolStripMenuItem);
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);

            ToolStripMenuItem openToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem.Text = "Open";
            fileToolStripMenuItem.DropDownItems.Add(openToolStripMenuItem);

            ToolStripMenuItem closeToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem.Text = "Close";
            fileToolStripMenuItem.DropDownItems.Add(closeToolStripMenuItem);

            ToolStripMenuItem eToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem.Text = "End";
            fileToolStripMenuItem.DropDownItems.Add(eToolStripMenuItem);
            eToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click2);
            //

            ToolStripMenuItem editToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem viewToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem helpToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem endToolStripMenuItem = new ToolStripMenuItem();
            endToolStripMenuItem.BackColor = Color.Red;


            //dobavq poziciq
            menuStrip1.Items.Add(editToolStripMenuItem);
            menuStrip1.Items.Add(viewToolStripMenuItem);
            menuStrip1.Items.Add(helpToolStripMenuItem);
            menuStrip1.Items.Add(endToolStripMenuItem);

            //nadpis instanciq
            editToolStripMenuItem.Text = "Edit";
            viewToolStripMenuItem.Text = "View";
            helpToolStripMenuItem.Text = "Help";
            endToolStripMenuItem.Text = "End";

            editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);

            this.MainMenuStrip = menuStrip1;
            Controls.Add(MainMenuStrip);
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Left = 500;
            this.Top = 300;
            generating_menustrip();
            generating_Button();
            //MainMenu.BackColor = Color.Red;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

       

    }
}


/*
 public void generating_menustrip(){
 ToolStripMenuItem fileToolStripMenuItem= new ToolStripMenuItem();
 MainMenu.Items.Add(fileToolStripMenuItem);
 fileToolStripMenuItem.Text= "File";
 fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
 ///t
 ToolStripMenuItem fileToolStripMenuItem= new ToolStripMenuItem();
 newToolStripMenuItem.Text= "File";
 fileToolStripMenuItem.DropDownItems.Add(newToolStripMenuItem);
 newToolStripMenuIte.Click+= new System.EventHandler(this.newToolStripMenuItem_Click);

 ToolStripMenuItem editToolStripMenuItem = new ToolstripMenuItem()
 ToolStripMenuItem viewToolStripMenuItem = new ToolstripMenuItem()
 ToolStripMenuItem helpToolStripMenuItem = new ToolstripMenuItem()
 ToolStripMenuItem endToolStripMenuItem = new ToolstripMenuItem()
 editToolStripMenuItem.BlackColor = Color.Red;

    //dobavq poziciq
 MainMenu.items.Add(editToolStripMenuItem);
 MainMenu.items.Add(viewToolStripMenuItem);
 MainMenu.items.Add(helpToolStripMenuItem);
 MainMenu.items.Add(endToolStripMenuItem);

    //nadpis instanciq
 editToolStripMenuItem.Text = "Edit"
 viewToolStripMenuItem.Text = "View"
 helpToolStripMenuItem.Text = "Help"
 endToolStripMenuItem.Text = "End"

    //subitini proceduri
 editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
 viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
 helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
 endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);

 this.MainMenuStrip = MainMenu;
 Controls.Add(MainMenu);
 
 //install button

 public void generating_Button(){
     Button btnDock= new Button();
     btnDock.Text="zavarti menuto";
     btnDock.Left = this.width/2;
     btnDock.top = this.Height/2;
     btnDock.Click += new System.EventHandler(this.btnDock_Click);
     Controls.Add(btnDock);
    }

 public void btnDock_Click(Object sender, System.EventArgs e){
 switch(parPos){
    case 0:{
        MainMenu.Dock= DockStyle.Right;
        break;
    }
    case 1:{
        MainMenu.Dock = DockStyle.Bottom;
        break;
    }
    }
    }


 */
