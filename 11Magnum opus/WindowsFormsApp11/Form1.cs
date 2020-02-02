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
    
    public partial class Form1 : Form
    {
        public static string name = "";
        public static string surname = "";
        public static string famname = "";
        public static Boolean flag1 = false;

        public Form1()
        {
            InitializeComponent();

            DateTime d = DateTime.Now;
            toolStripStatusLabel2.Text = d.ToLongTimeString();
            toolStripStatusLabel3.Text = d.ToLongDateString();
        }

        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2.
            //filter za kilicia        X
            //glavna buckva kato nachalo   X
            //predskazvane
            //dll sus predskazvane   X
            //moje da go napravq s edna procedura poneje sa ednakvi
            //dinamichno generirane na sakratenpo ime

            //da ima poveche ot 1 padnali minuta ednoveremenno

            //намери е опенфиле диалог
            //саве саве филедиалог
            // техт
            //  2 дъщерни клетки нов текст и 
            Form Forma = new Form2();
            Forma.Show();

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
            //show dialogue otvaraqm froma
        }
        private void newtextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Forma3 = new Form3();
            Forma3.Show();
            Forma3.MdiParent = this;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == Forma3.GetType() && frm != Forma3)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }

        }

        private void StartextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Forma4 = new Form4();
            Forma4.Show();
            Forma4.MdiParent = this;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == Forma4.GetType() && frm != Forma4)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }

        }

        private void texthover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "изберете нов и/или стар текст";
        }

        private void hoverpoderdi(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "изберете подредба";
        }

        private void hoverifo(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "информация за производителя";
        }

        private void hoverend(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "прекратяване на програмата";
        }

        private void hoveravtor(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "избиране или създаване на нов автор";
        }

        private void ХоризонталноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
        private void ВертикалноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
        private void КаскадноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        private void ЗаПроизводителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Николай Иванов \n 17621301", "Изготвено от:");
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
        private void AuthorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            authorToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
        }

        private void ТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            текстToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
        }

        private void ПодредиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            подредиToolStripMenuItem.DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
        }

        private void НамериАвторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                filepath = openFileDialog1.FileName;

                using (TextReader reader = File.OpenText(filepath))
                {
                    string text = reader.ReadLine();
                    string[] vars = text.Split(' ');

                    name = vars[0];
                    surname = vars[1];
                    famname = vars[2];
                }
                MessageBox.Show(name+" "+ surname +" "+ famname, filepath.ToString());
                //flag1 = true;
                //Form Forma = new Form2();
                //Forma.Show();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
