using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        public List<PictureBox> p = new List<PictureBox>();
        PictureBox pp = new PictureBox();
        public object sender1 = new object();
        public string senderName;
        Boolean parMove;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Cursor = new Cursor(Cursor.Current.Handle);

            PictureBox NewP = new PictureBox();
            NewP.Name = "p" + (p.Count + 1).ToString();
            NewP.Width = p0.Width;
            NewP.Height = p0.Height;

            NewP.Image = p0.Image;
            NewP.SizeMode = p0.SizeMode;
            
            NewP.ContextMenu = p0.ContextMenu;
            NewP.ContextMenuStrip = this.contextMenuStrip2;
            NewP.Visible = true;
            NewP.Left = Cursor.Position.X -23;
            NewP.Top = Cursor.Position.Y -25;
            
            NewP.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            NewP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P0_MouseDown);
            
            p.Add(NewP);
            this.Controls.Add(NewP);
            pictureBox1.SendToBack();
            

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pp in p)
            {
                pp.Visible = true;
                pp.Enabled = true;// деблокира обекти, ако има такива
            }
        }

        private void HideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pp in p)
            {
                pp.Visible = false;
                pp.Enabled = true;
            }
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void P0_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Left click
                    break;
                case MouseButtons.Right:
                    senderName = ((PictureBox)sender).Name;
                    break;
            }

        }

        private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pp in p)
            {
                if ((senderName == pp.Name))
                {
                    pp.Visible = false;
                    pp.Tag = 0;
                }
            }
        }

        private void move(object sender, EventArgs e)
        {
            parMove = true;
            
        }
        private void removeobj(object sender, EventArgs e)
        {
            foreach (PictureBox pp in p)
            {
                if ((senderName == pp.Name))
                {
                    pp.Visible = false;
                    p.Remove(pp);
                    break;

                }
            }
        }

        private void picmapmmove(object sender, MouseEventArgs e)
        {
            if (parMove == true) //Cursor.Position.X
            {
                foreach (PictureBox pp in p)
                {
                    if (senderName == pp.Name)
                    {
                        pp.Left = ((e.X + (pp.Width / 2) - (pp.Cursor.Size.Width / 2)));
                        pp.Top = ((e.Y + (pp.Height / 2) - (pp.Cursor.Size.Height / 2)));
                    }
                }

            }
        }

        private void stop(object sender, EventArgs e)
        {
            parMove = false;
        }
    }
}
