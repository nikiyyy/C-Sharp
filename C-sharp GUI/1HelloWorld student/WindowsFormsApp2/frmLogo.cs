using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp2
{

    
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void FrmLogo_Load(object sender, EventArgs e)
        {
            GraphicsPath MyGraphicsPath;
            MyGraphicsPath = new GraphicsPath();
            MyGraphicsPath.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new Region(MyGraphicsPath);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            timer1.Enabled = true;
            timer1.Interval = 1000;

            /*
            
            while (progressBar1.Value <= progressBar1.Maximum && timer1.Enabled != false)
            {
                progressBar1.Value = 0;
                //progressBar1.Value += 1;
                if ((progressBar1.Value == progressBar1.Maximum))
                {

                    timer1.Enabled = false;
                    //this.Hide();
                    //this.Close();
                    Form2 Form2 = new Form2();
                    Form2.Show();
                    
                }
                else
                {
                    progressBar1.Value +=1;
                    //this.Opacity = (this.Opacity + 0.05);
                }
            }*/
        }

        private void thicc(object sender, EventArgs e)
        {
            if ((progressBar1.Value == progressBar1.Maximum))
            {
                timer1.Enabled = false;
                this.Hide();
               
                this.Close();
                Form2 Form2 = new Form2();
                Form2.Show();
            }
            else
            {
                progressBar1.Value = (progressBar1.Value + 5);
                this.Opacity = (this.Opacity + 0.05);
            }

        }
    }
    }

