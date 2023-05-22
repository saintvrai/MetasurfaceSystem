﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySystem.Data.Tables;
using Npgsql;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using File = System.IO.File;

namespace MySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connstring = String.Format("Server ={0};Port ={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres", "qwerty", "Diplom");

        private NpgsqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }


        //DB TEST
        // добавление данных


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string projectPath = Application.StartupPath;
            string folderPath = Path.Combine(projectPath, "CST", "Projects");

            // Создает папку "CST/Projects", если ее не существует
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (OpenFileDialog saveFileDialog = new OpenFileDialog())
            {
                saveFileDialog.InitialDirectory = folderPath;
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = saveFileDialog.FileName;
                    txtProjectName.Text = Path.GetFileNameWithoutExtension(filePath);
                    Project.Path = filePath;
                    Project.Name = txtProjectName.Text;

                    // Чтение файла и поиск записи о структуре
                    string fileContent = File.ReadAllText(filePath);
                    string structureName = "Квадратный резонатор"; // Название структуры, которую нужно найти

                    // Загрузка формы в соответствии с названием структуры
                    LoadStructureForm(structureName);
                }
            }

            ввестиЗначенияПараметровToolStripMenuItem.Enabled = true;

        }
    


        private void LoadStructureForm(string structureName)
        {
            if (structureName == "Квадратный резонатор")
            {
                Form1 form = new Form1();
                form.Show();

                // Выделение структуры
                string imagePath = @"C:\CST_Files\structures\" + structureName.Trim() + ".jpg";
                if (File.Exists(imagePath))
                {
                    form.pictureBox1.ImageLocation = imagePath;
                    form.pictureBox1.Load(imagePath);
                    form.pictureBox1.Update();
                    form.pictureBox1.Refresh();
                    form.pictureBox1.Visible = true;
                }
            }
            else if (structureName == "Круглый резонатор")
            {
                Form2 form = new Form2();
                form.Show();

                // Выделение структуры
                string imagePath = @"C:\CST_Files\structures\" + structureName.Trim() + ".jpg";
                if (File.Exists(imagePath))
                {
                    form.pictureBox1.ImageLocation = imagePath;
                    form.pictureBox1.Load(imagePath);
                    form.pictureBox1.Update();
                    form.pictureBox1.Refresh();
                    form.pictureBox1.Visible = true;
                }
            }
            else if (structureName == "Ромбовидный резонатор")
            {
                Form3 form = new Form3();
                form.Show();

                // Выделение структуры
                string imagePath = @"C:\CST_Files\structures\" + structureName.Trim() + ".jpg";
                if (File.Exists(imagePath))
                {
                    form.pictureBox1.ImageLocation = imagePath;
                    form.pictureBox1.Load(imagePath);
                    form.pictureBox1.Update();
                    form.pictureBox1.Refresh();
                    form.pictureBox1.Visible = true;
                }
            }
            else
            {
                // Если название структуры не найдено или неизвестно, обработайте соответствующим образом
            }
        }

        private void ввестиЗначенияПараметровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём новую форму ввода данных о структуре 
            FValuesStruct valStruct = new FValuesStruct();
            valStruct.StartPosition = FormStartPosition.CenterScreen;

            DialogResult dr = valStruct.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ввестиДанныеОПараметрахToolStripMenuItem.Enabled = true;
            }

        }

        //private void timer1_Tick_1(object sender, EventArgs e)
        //{
        //    progressBar1.PerformStep();
        //}
        // Анализируемый мнтаэлемкнт для метаэкрана

        private void ввестиДанныеОПараметрахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём новую форму ввода данных о параметрах метаэкрана 
            if (DataStruct.ResonatorType == "Квадратный резонатор")
            {
                FValuesParamKvadrat paramStructKvadrat = new FValuesParamKvadrat();
                paramStructKvadrat.StartPosition = FormStartPosition.CenterScreen;
                DialogResult dr = paramStructKvadrat.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    данныеОМатериалахToolStripMenuItem.Enabled = true;
                }
            }
            else if (DataStruct.ResonatorType == "Круглый резонатор")
            {
                FValuesParamKrug paramStructKrug = new FValuesParamKrug();
                paramStructKrug.StartPosition = FormStartPosition.CenterScreen;
                DialogResult dr = paramStructKrug.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    данныеОМатериалахToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                FValuesParamRomb paramStructRomb = new FValuesParamRomb();
                paramStructRomb.StartPosition = FormStartPosition.CenterScreen;
                DialogResult dr = paramStructRomb.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    данныеОМатериалахToolStripMenuItem.Enabled = true;
                }
            }


        }

        private void данныеОМатериалахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём новую форму ввода данных о параметрах метаэкрана 
            FValuesMaterial materialStruct = new FValuesMaterial();
            materialStruct.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dr = materialStruct.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // данныеОМатериалахToolStripMenuItem.Enabled = true;
            }
        }

        private void настройкаПараметровАнализаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём новую форму ввода данных о параметрах метаэкрана 
            FValuesAnalysis analysisStruct = new FValuesAnalysis();
            analysisStruct.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dr = analysisStruct.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // данныеОМатериалахToolStripMenuItem.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var proc = new Process();
            proc.EnableRaisingEvents = true;
            proc.Exited += (s, ev) => MessageBox.Show(
                "Проектная процедура завершила работу." +
                "Испытание не пройдено",
                "Готово!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
             );

            string path = $@"C:\Users\Airat\source\repos\MetasurfaceProgram\bin\Debug\CST\Screens";

            string cmdLine = $@"{path}\kvadrat.vbs";      // BPLA
            //string cmdLine = $@"{path}\copter\COPTER_macro.vbs";    // COPTER

            proc.StartInfo = new ProcessStartInfo("wscript", cmdLine);
            proc.Start();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string projectPath = Application.StartupPath;
            string folderPath = Path.Combine(projectPath, "CST", "Projects");

            // Создает папку "CST/Projects", если ее не существует
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = folderPath;
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string projectPath2 = Path.GetDirectoryName(Application.StartupPath);
                    string projectFilePath2 = Path.Combine(projectPath2, filePath);
                    Project.Path = projectFilePath2;
                    Project.Name = Path.GetFileName(filePath);
                    txtProjectName.Text = Path.GetFileNameWithoutExtension(filePath);


                    using (StreamWriter writer = new StreamWriter(filePath))
                    {

                        writer.WriteLine("Путь проекта: " + projectFilePath2);
                        writer.WriteLine("Название файла: " + Path.GetFileName(filePath));
                    }
                }
            }


            ввестиЗначенияПараметровToolStripMenuItem.Enabled = true;
        }

    }
}

