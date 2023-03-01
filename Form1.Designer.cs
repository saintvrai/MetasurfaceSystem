namespace MySystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиЗначенияПараметровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиДанныеОПараметрахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеОМатериалахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПараметровАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синтезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствМПИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.проектныеДанныеToolStripMenuItem,
            this.выполнитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(600, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.переименоватьToolStripMenuItem});
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.проектToolStripMenuItem.Text = "Проект";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.создатьToolStripMenuItem.Text = "Создать...";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Enabled = false;
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.переименоватьToolStripMenuItem.Text = "Удалить...";
            // 
            // проектныеДанныеToolStripMenuItem
            // 
            this.проектныеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ввестиЗначенияПараметровToolStripMenuItem,
            this.ввестиДанныеОПараметрахToolStripMenuItem,
            this.данныеОМатериалахToolStripMenuItem});
            this.проектныеДанныеToolStripMenuItem.Name = "проектныеДанныеToolStripMenuItem";
            this.проектныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.проектныеДанныеToolStripMenuItem.Text = "Проектные данные";
            // 
            // ввестиЗначенияПараметровToolStripMenuItem
            // 
            this.ввестиЗначенияПараметровToolStripMenuItem.Name = "ввестиЗначенияПараметровToolStripMenuItem";
            this.ввестиЗначенияПараметровToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.ввестиЗначенияПараметровToolStripMenuItem.Text = "Данные о структуре метаэкрана";
            this.ввестиЗначенияПараметровToolStripMenuItem.Click += new System.EventHandler(this.ввестиЗначенияПараметровToolStripMenuItem_Click);
            // 
            // ввестиДанныеОПараметрахToolStripMenuItem
            // 
            this.ввестиДанныеОПараметрахToolStripMenuItem.Name = "ввестиДанныеОПараметрахToolStripMenuItem";
            this.ввестиДанныеОПараметрахToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.ввестиДанныеОПараметрахToolStripMenuItem.Text = "Данные о параметрах метаэкрана";
            this.ввестиДанныеОПараметрахToolStripMenuItem.Click += new System.EventHandler(this.ввестиДанныеОПараметрахToolStripMenuItem_Click);
            // 
            // данныеОМатериалахToolStripMenuItem
            // 
            this.данныеОМатериалахToolStripMenuItem.Name = "данныеОМатериалахToolStripMenuItem";
            this.данныеОМатериалахToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.данныеОМатериалахToolStripMenuItem.Text = "Данные об используемых материалах";
            this.данныеОМатериалахToolStripMenuItem.Click += new System.EventHandler(this.данныеОМатериалахToolStripMenuItem_Click);
            // 
            // выполнитьToolStripMenuItem
            // 
            this.выполнитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаПараметровАнализаToolStripMenuItem,
            this.анализToolStripMenuItem,
            this.синтезToolStripMenuItem});
            this.выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            this.выполнитьToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.выполнитьToolStripMenuItem.Text = "Выполнить";
            // 
            // настройкаПараметровАнализаToolStripMenuItem
            // 
            this.настройкаПараметровАнализаToolStripMenuItem.Name = "настройкаПараметровАнализаToolStripMenuItem";
            this.настройкаПараметровАнализаToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.настройкаПараметровАнализаToolStripMenuItem.Text = "Настройка параметров анализа";
            this.настройкаПараметровАнализаToolStripMenuItem.Click += new System.EventHandler(this.настройкаПараметровАнализаToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.Enabled = false;
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.анализToolStripMenuItem.Text = "Настройка параметров синтеза";
            // 
            // синтезToolStripMenuItem
            // 
            this.синтезToolStripMenuItem.Enabled = false;
            this.синтезToolStripMenuItem.Name = "синтезToolStripMenuItem";
            this.синтезToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.синтезToolStripMenuItem.Text = "Выполнить проектную операцию";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.руководствМПИToolStripMenuItem,
            this.авторToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // руководствМПИToolStripMenuItem
            // 
            this.руководствМПИToolStripMenuItem.Name = "руководствМПИToolStripMenuItem";
            this.руководствМПИToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.руководствМПИToolStripMenuItem.Text = "Помощь";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.авторToolStripMenuItem.Text = "Автор";
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(212, 336);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 19);
            this.progressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Система автоматизированного проектирования метаэкрана";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиЗначенияПараметровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиДанныеОПараметрахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеОМатериалахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синтезToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствМПИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПараметровАнализаToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

