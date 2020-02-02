namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намериАвторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.крайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подредиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хоризонталноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикалноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заПроизводителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.подредиToolStripMenuItem,
            this.заПроизводителяToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новToolStripMenuItem,
            this.намериАвторToolStripMenuItem,
            this.toolStripSeparator1,
            this.крайToolStripMenuItem});
            this.authorToolStripMenuItem.Image = global::WindowsFormsApp11.Properties.Resources.brain_3_xxl;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.authorToolStripMenuItem.Text = "Автор";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click_1);
            this.authorToolStripMenuItem.MouseHover += new System.EventHandler(this.hoveravtor);
            // 
            // новToolStripMenuItem
            // 
            this.новToolStripMenuItem.Name = "новToolStripMenuItem";
            this.новToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.новToolStripMenuItem.Text = "Нов автор";
            this.новToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click);
            // 
            // намериАвторToolStripMenuItem
            // 
            this.намериАвторToolStripMenuItem.Name = "намериАвторToolStripMenuItem";
            this.намериАвторToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.намериАвторToolStripMenuItem.Text = "намери автор";
            this.намериАвторToolStripMenuItem.Click += new System.EventHandler(this.НамериАвторToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // крайToolStripMenuItem
            // 
            this.крайToolStripMenuItem.Name = "крайToolStripMenuItem";
            this.крайToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.крайToolStripMenuItem.Text = "край";
            this.крайToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новТекстToolStripMenuItem,
            this.startextToolStripMenuItem});
            this.текстToolStripMenuItem.Image = global::WindowsFormsApp11.Properties.Resources.toilet_paper_2_xxl;
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            this.текстToolStripMenuItem.Click += new System.EventHandler(this.ТекстToolStripMenuItem_Click);
            this.текстToolStripMenuItem.MouseHover += new System.EventHandler(this.texthover);
            // 
            // новТекстToolStripMenuItem
            // 
            this.новТекстToolStripMenuItem.Name = "новТекстToolStripMenuItem";
            this.новТекстToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.новТекстToolStripMenuItem.Text = "нов текст";
            this.новТекстToolStripMenuItem.Click += new System.EventHandler(this.newtextToolStripMenuItem_Click);
            // 
            // startextToolStripMenuItem
            // 
            this.startextToolStripMenuItem.Name = "startextToolStripMenuItem";
            this.startextToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.startextToolStripMenuItem.Text = "стар текст";
            this.startextToolStripMenuItem.Click += new System.EventHandler(this.StartextToolStripMenuItem_Click);
            // 
            // подредиToolStripMenuItem
            // 
            this.подредиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хоризонталноToolStripMenuItem,
            this.вертикалноToolStripMenuItem,
            this.каскадноToolStripMenuItem});
            this.подредиToolStripMenuItem.Image = global::WindowsFormsApp11.Properties.Resources.activity_feed_xxl;
            this.подредиToolStripMenuItem.Name = "подредиToolStripMenuItem";
            this.подредиToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.подредиToolStripMenuItem.Text = "Подреди";
            this.подредиToolStripMenuItem.Click += new System.EventHandler(this.ПодредиToolStripMenuItem_Click);
            this.подредиToolStripMenuItem.MouseHover += new System.EventHandler(this.hoverpoderdi);
            // 
            // хоризонталноToolStripMenuItem
            // 
            this.хоризонталноToolStripMenuItem.Name = "хоризонталноToolStripMenuItem";
            this.хоризонталноToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.хоризонталноToolStripMenuItem.Text = "Хоризонтално";
            this.хоризонталноToolStripMenuItem.Click += new System.EventHandler(this.ХоризонталноToolStripMenuItem_Click);
            // 
            // вертикалноToolStripMenuItem
            // 
            this.вертикалноToolStripMenuItem.Name = "вертикалноToolStripMenuItem";
            this.вертикалноToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.вертикалноToolStripMenuItem.Text = "Вертикално";
            this.вертикалноToolStripMenuItem.Click += new System.EventHandler(this.ВертикалноToolStripMenuItem_Click);
            // 
            // каскадноToolStripMenuItem
            // 
            this.каскадноToolStripMenuItem.Name = "каскадноToolStripMenuItem";
            this.каскадноToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.каскадноToolStripMenuItem.Text = "Каскадно";
            this.каскадноToolStripMenuItem.Click += new System.EventHandler(this.КаскадноToolStripMenuItem_Click);
            // 
            // заПроизводителяToolStripMenuItem
            // 
            this.заПроизводителяToolStripMenuItem.Image = global::WindowsFormsApp11.Properties.Resources.chair_8_xxl;
            this.заПроизводителяToolStripMenuItem.Name = "заПроизводителяToolStripMenuItem";
            this.заПроизводителяToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.заПроизводителяToolStripMenuItem.Text = "За производителя";
            this.заПроизводителяToolStripMenuItem.Click += new System.EventHandler(this.ЗаПроизводителяToolStripMenuItem_Click);
            this.заПроизводителяToolStripMenuItem.MouseHover += new System.EventHandler(this.hoverifo);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::WindowsFormsApp11.Properties.Resources.login_xxl;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.closeToolStripMenuItem.Text = "край";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            this.closeToolStripMenuItem.MouseHover += new System.EventHandler(this.hoverend);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "текстов редактор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem новToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намериАвторToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem крайToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подредиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хоризонталноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикалноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заПроизводителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

