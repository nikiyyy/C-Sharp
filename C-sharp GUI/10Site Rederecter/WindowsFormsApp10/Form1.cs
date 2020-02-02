using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public static string myVar2 = "https://www.google.com";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }
        
        private void gg(object sender, EventArgs e)
        {
            myVar2 = "https://www.google.com";
            Form Forma = new Form2();
            Forma.Show();

        }

        private void bb(object sender, EventArgs e)
        {
            myVar2 = "https://duckduckgo.com/";
            Form Forma = new Form2();
            Forma.Show();

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void clicked2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://duckduckgo.com/");
        }

        private void clicked3(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            myVar2 = "https://www.bing.com/";
            Form Forma = new Form2();
            Forma.Show();
        }
    }
}
