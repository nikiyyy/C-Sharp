namespace WindowsFormsApp9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            " Абаджиев",
            "Аврамов",
            "Агура",
            "Андреев",
            "Арабаджиев",
            "Арнаудов",
            "Арнаудова",
            "Асенов",
            "Атанасов",
            "Атанасова",
            "Бальови",
            "Богоев",
            "Божинов",
            "Бонев",
            "Борисов",
            "Бояджиев",
            "Бонев",
            "Борисов",
            "Бояджиев",
            "Ванчев",
            "Вачков",
            "Велешки",
            "Велчев",
            "Венедикови",
            "Виденов",
            "Витяков",
            "Вълканов",
            "Вълчанов",
            "Вълчев",
            "Гемеджиев",
            "Георгиев",
            "Георгиева",
            "Герасимов",
            "Гоцев",
            "Гошев",
            "Ивков",
            "Игнатов",
            "Измирлиев",
            "Инджов",
            "Йорданов",
            "Йосифов",
            "Каменов",
            "Кантарджиев",
            "Каравелов",
            "Караджов",
            "Карастоянов",
            "Касабов",
            "Ковачев",
            "Колчагови",
            "Котев",
            "Кочев",
            "Кушев",
            "Кънев",
            "Кьосев",
            "Лефтеров",
            "Мавродиев",
            "Марангозов",
            "Маринов",
            "Минков",
            "Минчев",
            "Попова",
            "Първанов",
            "Радев",
            "Радославов",
            "Русева",
            "Самарджиеви",
            "Симеонов",
            "Соколов",
            "Солаков",
            "Ставрев",
            "Стамов",
            "Станев",
            "Стойков",
            "Стоянов",
            "Такев",
            "Танев",
            "Терзиев",
            "Томов",
            "Тошев",
            "Туджаров"});
            this.listBox1.Location = new System.Drawing.Point(596, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 381);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(39, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 368);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

