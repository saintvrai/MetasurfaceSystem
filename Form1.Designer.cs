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
            components = new System.ComponentModel.Container();
            menuStrip2 = new System.Windows.Forms.MenuStrip();
            проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            проектныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ввестиДанныеОСтруктуреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ввестиДанныеОПараметрахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            данныеОМатериалахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            выполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            настройкаПараметровАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            синтезToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            руководствМПИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            txtProjectName = new System.Windows.Forms.TextBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { проектToolStripMenuItem, проектныеДанныеToolStripMenuItem, выполнитьToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip2.Location = new System.Drawing.Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip2.Size = new System.Drawing.Size(546, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // проектToolStripMenuItem
            // 
            проектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { открытьToolStripMenuItem, создатьToolStripMenuItem, сохранитьToolStripMenuItem, удалитьToolStripMenuItem });
            проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            проектToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            проектToolStripMenuItem.Text = "Проект";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            создатьToolStripMenuItem.Text = "Создать...";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить...";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Enabled = false;
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            удалитьToolStripMenuItem.Text = "Удалить...";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // проектныеДанныеToolStripMenuItem
            // 
            проектныеДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ввестиДанныеОСтруктуреToolStripMenuItem, ввестиДанныеОПараметрахToolStripMenuItem, данныеОМатериалахToolStripMenuItem });
            проектныеДанныеToolStripMenuItem.Name = "проектныеДанныеToolStripMenuItem";
            проектныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            проектныеДанныеToolStripMenuItem.Text = "Проектные данные";
            // 
            // ввестиДанныеОСтруктуреToolStripMenuItem
            // 
            ввестиДанныеОСтруктуреToolStripMenuItem.Enabled = false;
            ввестиДанныеОСтруктуреToolStripMenuItem.Name = "ввестиДанныеОСтруктуреToolStripMenuItem";
            ввестиДанныеОСтруктуреToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            ввестиДанныеОСтруктуреToolStripMenuItem.Text = "Данные о структуре метаэкрана";
            ввестиДанныеОСтруктуреToolStripMenuItem.Click += ввестиЗначенияПараметровToolStripMenuItem_Click;
            // 
            // ввестиДанныеОПараметрахToolStripMenuItem
            // 
            ввестиДанныеОПараметрахToolStripMenuItem.Enabled = false;
            ввестиДанныеОПараметрахToolStripMenuItem.Name = "ввестиДанныеОПараметрахToolStripMenuItem";
            ввестиДанныеОПараметрахToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            ввестиДанныеОПараметрахToolStripMenuItem.Text = "Данные о параметрах метаэкрана";
            ввестиДанныеОПараметрахToolStripMenuItem.Click += ввестиДанныеОПараметрахToolStripMenuItem_Click;
            // 
            // данныеОМатериалахToolStripMenuItem
            // 
            данныеОМатериалахToolStripMenuItem.Name = "данныеОМатериалахToolStripMenuItem";
            данныеОМатериалахToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            данныеОМатериалахToolStripMenuItem.Text = "Данные об используемых материалах";
            данныеОМатериалахToolStripMenuItem.Click += данныеОМатериалахToolStripMenuItem_Click;
            // 
            // выполнитьToolStripMenuItem
            // 
            выполнитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { настройкаПараметровАнализаToolStripMenuItem, синтезToolStripMenuItem, стартToolStripMenuItem });
            выполнитьToolStripMenuItem.Name = "выполнитьToolStripMenuItem";
            выполнитьToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            выполнитьToolStripMenuItem.Text = "Выполнить";
            // 
            // настройкаПараметровАнализаToolStripMenuItem
            // 
            настройкаПараметровАнализаToolStripMenuItem.Name = "настройкаПараметровАнализаToolStripMenuItem";
            настройкаПараметровАнализаToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            настройкаПараметровАнализаToolStripMenuItem.Text = "Настройка параметров анализа";
            настройкаПараметровАнализаToolStripMenuItem.Click += настройкаПараметровАнализаToolStripMenuItem_Click;
            // 
            // синтезToolStripMenuItem
            // 
            синтезToolStripMenuItem.Name = "синтезToolStripMenuItem";
            синтезToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            синтезToolStripMenuItem.Text = "Настройка параметров синтеза";
            синтезToolStripMenuItem.Click += синтезToolStripMenuItem_Click;
            // 
            // стартToolStripMenuItem
            // 
            стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            стартToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            стартToolStripMenuItem.Text = "Выполнить проектную процедуру";
            стартToolStripMenuItem.Click += стартToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { руководствМПИToolStripMenuItem, авторToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // руководствМПИToolStripMenuItem
            // 
            руководствМПИToolStripMenuItem.Name = "руководствМПИToolStripMenuItem";
            руководствМПИToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            руководствМПИToolStripMenuItem.Text = "Помощь";
            // 
            // авторToolStripMenuItem
            // 
            авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            авторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            авторToolStripMenuItem.Text = "Автор";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 15);
            label1.TabIndex = 6;
            label1.Text = "Выбранный проект:";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new System.Drawing.Point(141, 45);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.ReadOnly = true;
            txtProjectName.Size = new System.Drawing.Size(220, 23);
            txtProjectName.TabIndex = 7;
            txtProjectName.Text = "Файл не выбран";
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(256, 387);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(209, 23);
            progressBar1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(12, 90);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(505, 254);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "Запустите выполнение проектной операции для отображения результатов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(72, 391);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(178, 15);
            label2.TabIndex = 14;
            label2.Text = "Строка состояния программы:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(546, 422);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(progressBar1);
            Controls.Add(txtProjectName);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            Text = "Система автоматизированного проектирования метаэкрана";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиДанныеОСтруктуреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиДанныеОПараметрахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеОМатериалахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синтезToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствМПИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПараметровАнализаToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
    }
}

