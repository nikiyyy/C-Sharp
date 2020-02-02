namespace WindowsFormsControlLibrary3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Абаджиев",
            "Аврамов",
            "Агура",
            "Арабаджиев",
            "Арнаудова",
            "Асенов",
            "Атанасов",
            "Бальови",
            "Божинов",
            "Бояджиев",
            "Ванчев",
            "Велешки",
            "Виденов",
            "Вълчев",
            "Гемеджиев",
            "Герасимов",
            "Гошев",
            "Георгиева",
            "Григориев",
            "Груев",
            "Гълъбов",
            "Гюзелев",
            "Дамянов",
            "Димитрова",
            "Добрев",
            "Драганов",
            "Дюлгеров",
            "Драганов",
            "Желев",
            "Живков",
            "Зангочев",
            "Иванова",
            "Ивков",
            "Измирлиев",
            "Инджов",
            "Йорданов",
            "Йосифов",
            "Каменов",
            "Каравелов",
            "Карастоянов",
            "Кескинов",
            "Коджа",
            "Константинов",
            "Кочев",
            "Кръстев",
            "Куюмджиев",
            "Лефтеров",
            "Марангозов",
            "Марангозов",
            "Митов",
            "Михов",
            "Москов",
            "Николов",
            "Орлов",
            "Паница",
            "Петков",
            "Петрова",
            "Плачков",
            "Попова",
            "Радев",
            "Русев",
            "Самарджиеви",
            "Симеонов",
            "Солаков",
            "Спасов",
            "Стайков",
            "Станев",
            "Стойков",
            "Стоянов",
            "Стоянова",
            "Такев",
            "Танчев",
            "Терзиев",
            "Тодоров",
            "Тошев",
            "Трифонов",
            "Тунчев",
            "Хаджиев",
            "Христов",
            "Фучеджиев",
            "Цветанов",
            "Цеков",
            "Чекови",
            "Червенков",
            "Чешмеджиев",
            "Шейтанов",
            "Яворов"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.tc);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(99, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}
