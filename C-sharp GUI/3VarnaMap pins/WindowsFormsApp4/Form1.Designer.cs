namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скеийОбектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преместиОбектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сприПреместванетоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отстарниОбектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.endToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 92);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newToolStripMenuItem.Text = "Нов обект";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.viewToolStripMenuItem.Text = "Покажи";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.hideToolStripMenuItem.Text = "Скрий";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.HideToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.endToolStripMenuItem.Text = "Край";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.EndToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скеийОбектToolStripMenuItem,
            this.преместиОбектToolStripMenuItem,
            this.сприПреместванетоToolStripMenuItem,
            this.отстарниОбектToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(190, 92);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip2_Opening);
            // 
            // скеийОбектToolStripMenuItem
            // 
            this.скеийОбектToolStripMenuItem.Name = "скеийОбектToolStripMenuItem";
            this.скеийОбектToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.скеийОбектToolStripMenuItem.Text = "Скрий Обект";
            this.скеийОбектToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // преместиОбектToolStripMenuItem
            // 
            this.преместиОбектToolStripMenuItem.Name = "преместиОбектToolStripMenuItem";
            this.преместиОбектToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.преместиОбектToolStripMenuItem.Text = "Примести Обект";
            this.преместиОбектToolStripMenuItem.Click += new System.EventHandler(this.move);
            // 
            // сприПреместванетоToolStripMenuItem
            // 
            this.сприПреместванетоToolStripMenuItem.Name = "сприПреместванетоToolStripMenuItem";
            this.сприПреместванетоToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.сприПреместванетоToolStripMenuItem.Text = "Спри преместването";
            this.сприПреместванетоToolStripMenuItem.Click += new System.EventHandler(this.stop);
            // 
            // отстарниОбектToolStripMenuItem
            // 
            this.отстарниОбектToolStripMenuItem.Name = "отстарниОбектToolStripMenuItem";
            this.отстарниОбектToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.отстарниОбектToolStripMenuItem.Text = "Отстарни обект";
            this.отстарниОбектToolStripMenuItem.Click += new System.EventHandler(this.removeobj);
            // 
            // p0
            // 
            this.p0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p0.ContextMenuStrip = this.contextMenuStrip2;
            this.p0.Image = global::WindowsFormsApp4.Properties.Resources.flag_64x64;
            this.p0.Location = new System.Drawing.Point(57, 76);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(22, 20);
            this.p0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p0.TabIndex = 1;
            this.p0.TabStop = false;
            this.p0.Visible = false;
            this.p0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P0_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Map_of_Varna;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picmapmmove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 392);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.p0);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox p0;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem скеийОбектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преместиОбектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сприПреместванетоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отстарниОбектToolStripMenuItem;
    }
}

