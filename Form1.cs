﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Channels;
using System.Text;
using System.Text.RegularExpressions;
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
        private FileSystemWatcher watcher;
        private Timer timer;
        private string filePath;
        public Form1()
        {
            InitializeComponent();

            string filePath = @"C:\CST_Files\Results\Kvadrat\Final.txt";
            StartFileMonitoring(filePath);

        }
        private string connstring = String.Format("Server ={0};Port ={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres", "qwerty", "Diplom");

        private NpgsqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }


        #region Читает файл и выводит в RichTextBox

        private void StartFileMonitoring(string path)
        {
            filePath = path;

            // Создаем FileSystemWatcher
            watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(filePath);
            watcher.Filter = Path.GetFileName(filePath);
            watcher.NotifyFilter = NotifyFilters.LastWrite; // Мониторим только изменения записи
            watcher.EnableRaisingEvents = true;
            watcher.Changed += OnFileChanged;

            // Создаем Timer
            timer = new Timer();
            timer.Interval = 1000; // Интервал проверки, можно изменить по необходимости
            timer.Tick += OnTimerTick;
            timer.Start();
        }
        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            // При изменении файла останавливаем таймер
            timer.Stop();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            try
            {
                // Чтение содержимого файла
                string fileContent = File.ReadAllText(filePath);

                // Обновление содержимого элемента TextBox
                richTextBox1.Invoke((MethodInvoker)(() =>
                {
                    richTextBox1.Text = fileContent;
                }));
            }
            catch (IOException ex)
            {
                // Файл занят другим процессом, продолжаем ожидание
            }
        }
        #endregion

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

                    // Проверка наличия строки "Структура:" в файле и получение названия структуры

                    CheckStructureInFile(Project.Path);

                    // Загрузка формы в соответствии с названием структуры
                    // LoadStructureForm(structureName);

                    сохранитьToolStripMenuItem.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                }
            }

        }

        private void CheckStructureInFile(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            string structureKeyword = "Структура:";

            int keywordIndex = fileContent.IndexOf(structureKeyword);
            if (keywordIndex != -1)
            {
                int startIndex = keywordIndex + structureKeyword.Length;
                int endIndex = fileContent.IndexOf('\n', startIndex);

                if (endIndex != -1)
                {
                    DataStruct.ResonatorType = fileContent.Substring(startIndex, endIndex - startIndex).Trim();
                }
            }

            if (!string.IsNullOrEmpty(DataStruct.ResonatorType))
            {

                ввестиДанныеОСтруктуреToolStripMenuItem.Enabled = false;
                ввестиДанныеОПараметрахToolStripMenuItem.Enabled = true;


                // Здесь можно использовать значение DataStruct.ResonatorType для дальнейших операций
            }
            else
            {
                ввестиДанныеОСтруктуреToolStripMenuItem.Enabled = true;
            }
        }
        //TODO: сделать для круга и ромба, данные, параметры все дела
        private void LoadStructureForm(string structureName)
        {
            //if (structureName == "Квадратный резонатор")
            //{
            //    Form1 form = new Form1();
            //    form.Show();

            //    // Выделение структуры
            //    string imagePath = @"C:\CST_Files\structures\" + structureName.Trim() + ".jpg";
            //    if (File.Exists(imagePath))
            //    {
            //        form.pictureBox1.ImageLocation = imagePath;
            //        form.pictureBox1.Load(imagePath);
            //        form.pictureBox1.Update();
            //        form.pictureBox1.Refresh();
            //        form.pictureBox1.Visible = true;
            //    }
            //}
            //else if (structureName == "Круглый резонатор")
            //{
            //    Form2 form = new Form2();
            //    form.Show();

            //    // Выделение структуры
            //    string imagePath = @"C:\CST_Files\structures\" + structureName.Trim() + ".jpg";
            //    if (File.Exists(imagePath))
            //    {
            //        form.pictureBox1.ImageLocation = imagePath;
            //        form.pictureBox1.Load(imagePath);
            //        form.pictureBox1.Update();
            //        form.pictureBox1.Refresh();
            //        form.pictureBox1.Visible = true;
            //    }
            //}
            //else if (structureName == "Ромбовидный резонатор")
            //{
            //    Form3 form = new Form3();
            //    form.Show();

            //    // Выделение структуры
            //    string imagePath = @"C:\CST_Files\structures\" + structureName.Trim() + ".jpg";
            //    if (File.Exists(imagePath))
            //    {
            //        form.pictureBox1.ImageLocation = imagePath;
            //        form.pictureBox1.Load(imagePath);
            //        form.pictureBox1.Update();
            //        form.pictureBox1.Refresh();
            //        form.pictureBox1.Visible = true;
            //    }
            //}
            //else
            //{
            //    // Если название структуры не найдено или неизвестно, обработайте соответствующим образом
            //}
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


        // Анализируемый метаэлемент для метаэкрана

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
            else if (DataStruct.ResonatorType == "Ромбовидный резонатор")
            {
                FValuesParamRomb paramStructRomb = new FValuesParamRomb();
                paramStructRomb.StartPosition = FormStartPosition.CenterScreen;
                DialogResult dr = paramStructRomb.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    данныеОМатериалахToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Не удалось распознать тип структуры", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FValuesFrequency analysisStruct = new FValuesFrequency();
            analysisStruct.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dr = analysisStruct.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // данныеОМатериалахToolStripMenuItem.Enabled = true;
            }
        }

        //TODO: попробовать запустить скрипт

        private void RunVbsScript(string scriptPath)
        {
            try
            {
                var proc = new Process();
                proc.EnableRaisingEvents = true;
                proc.Exited += (s, ev) =>
                {
                    MessageBox.Show("Проектная процедура завершила работу. Испытание не пройдено",
                        "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                proc.StartInfo = new ProcessStartInfo("wscript", scriptPath);
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске скрипта: {ex.Message}",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string path = @"C:\CST_Files\Macros";

            string cmdLine = $@"{path}\kvadratik.vbs";


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
                    string projectFilePath = Path.Combine(folderPath, filePath);
                    Project.Path = projectFilePath;
                    Project.Name = Path.GetFileName(filePath);
                    txtProjectName.Text = Path.GetFileNameWithoutExtension(filePath);

                    using (StreamWriter writer = new StreamWriter(Project.Path, true))
                    {

                    }


                    ввестиДанныеОСтруктуреToolStripMenuItem.Enabled = true;
                    сохранитьToolStripMenuItem.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = true;
                }

            }
        }

        private void синтезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём новую форму ввода данных о параметрах метаэкрана 
            FValuesSintez sintezStruct = new FValuesSintez();
            sintezStruct.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dr = sintezStruct.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // данныеОМатериалахToolStripMenuItem.Enabled = true;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка наличия пути проекта
            if (string.IsNullOrEmpty(Project.Path))
            {
                MessageBox.Show("Путь проекта не указан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Формирование данных для сохранения
            string filePath = Project.Path;

            // Запись данных в файл
            try
            {
                string fileContent = File.ReadAllText(filePath); // Чтение текущего содержимого файла

                File.WriteAllText(filePath, fileContent); // Перезапись файла с обновленным содержимым

                MessageBox.Show("Файл успешно сохранен.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckKvadratStructData()
        {
            string filePath = Project.Path;

            string[] expectedLines = new string[]
            {
        "Структура:Квадратный резонатор",
        "Ширина подложки W=",
        "Длина подложки S=",
        "Максимальная длина внешнего кольца L=",
        "Минимальная длина внешнего кольца L=",
        "Минимальная длина внутреннего кольца K=",
        "Максимальная длина внутреннего кольца K=",
        "Минимальная длина вырезки кольца H=",
        "Максимальная длина вырезки кольца H=",
        "Solid.ChangeMaterial \"component1:Substrate\",",
        "Solid.ChangeMaterial \"component1:outter\",",
        "Solid.ChangeMaterial \"component1:inner\",",
        "Solver.FrequencyRange",
        "PopulationNumber=",
        "MutationChance=",
        "CrossingChance="
            };

            string[] fileLines = File.ReadAllLines(filePath);

            // Проверка построчно наличие ожидаемых строк
            for (int i = 0; i < expectedLines.Length; i++)
            {
                if (!fileLines.Any(line => line.Contains(expectedLines[i])))
                {
                    MessageBox.Show("Неправильно в строке" + expectedLines[i].ToString());
                    return false;
                }
            }
            MessageBox.Show("Все данные правильные");
            return true;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверка наличия пути проекта
            if (string.IsNullOrEmpty(Project.Path))
            {
                MessageBox.Show("Путь проекта не указан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подтверждение удаления файла
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить файл?", "Удаление файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Удаление файла
                    File.Delete(Project.Path);

                    MessageBox.Show("Файл успешно удален.", "Удаление файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtProjectName.Text = "Файл не выбран";
            Project.Path = null;
            Project.Name = txtProjectName.Text;

            ввестиДанныеОСтруктуреToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Enabled = false;
            удалитьToolStripMenuItem.Enabled = false;


        }

        //TODO: сделать правильные пути, а то они сейчас захордкодены, а также парсер параметров синтеза


        #region Работа с параметрами в целевом файле 
        //Работа с параметрами в файле
        private void ReplaceDataInFile()
        {
            string sourceFilePath = Project.Path;
            string targetFilePath = @"C:\CST_Files\Macros\Kvadrat\kvadrat_macros.txt"; // Укажите путь к целевому файлу

            // Чтение исходного файла
            string[] sourceLines = File.ReadAllLines(sourceFilePath);

            // Значения переменных
            string wValue = GetValueFromLine(sourceLines, "Ширина подложки W=");
            string sValue = GetValueFromLine(sourceLines, "Длина подложки S=");
            string lMaxValue = GetValueFromLine(sourceLines, "Максимальная длина внешнего кольца L=");
            string lMinValue = GetValueFromLine(sourceLines, "Минимальная длина внешнего кольца L=");
            string kMaxValue = GetValueFromLine(sourceLines, "Максимальная длина внутреннего кольца K=");
            string kMinValue = GetValueFromLine(sourceLines, "Минимальная длина внутреннего кольца K=");
            string hMinValue = GetValueFromLine(sourceLines, "Минимальная длина вырезки кольца H=");
            string hMaxValue = GetValueFromLine(sourceLines, "Максимальная длина вырезки кольца H=");

            // Чтение целевого файла
            string[] targetLines = File.ReadAllLines(targetFilePath);

            // Замена значений в целевом файле
            ReplaceValueInLine(targetLines, "W=", wValue.Replace(',', '.'));
            ReplaceValueInLine(targetLines, "S=", sValue.Replace(',', '.'));
            ReplaceValueInLine(targetLines, "upperboundL =", lMaxValue.Replace(',', '.'));
            ReplaceValueInLine(targetLines, "lowerboundL =", lMinValue.Replace(',', '.'));
            ReplaceValueInLine(targetLines, "lowerboundK =", kMinValue.Replace(',', '.'));
            ReplaceValueInLine(targetLines, "upperboundK =", kMaxValue.Replace(',', '.'));
            ReplaceValueInLine(targetLines, "lowerboundH =", hMinValue.Replace(',', '.'));
            ReplaceValueInLine(targetLines, "upperboundH =", hMaxValue.Replace(',', '.'));

            // Запись изменений в целевой файл
            File.WriteAllLines(targetFilePath, targetLines);
        }


        private string GetValueFromLine(string[] lines, string prefix)
        {
            foreach (string line in lines)
            {
                if (line.StartsWith(prefix))
                {
                    return line.Substring(prefix.Length);
                }
            }
            return string.Empty;
        }

        private void ReplaceValueInLine(string[] lines, string prefix, string newValue)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(prefix))
                {
                    lines[i] = prefix + newValue;
                    break;
                }
            }
        }
        #endregion

        #region Работа с материалами и частотой
        private void ReplaceDataInFileMat()
        {
            string targetFilePath;
            string sourceFilePath = Project.Path;
            if (DataStruct.ResonatorType == "Квадратный резонатор")
            {
                targetFilePath = @"C:\CST_Files\Macros\Kvadrat\kvadrat_macros.txt"; // Укажите путь к целевому файлу
            }
            else if (DataStruct.ResonatorType == "Круглый резонатор")
            {
                targetFilePath = @"C:\CST_Files\Macros\Krug\krug_macros.txt"; // Укажите путь к целевому файлу
            }
            else
            {
                targetFilePath = @"C:\CST_Files\Macros\Romb\romb_macros.txt";
            }


            // Чтение исходного файла
            string[] sourceLines = File.ReadAllLines(sourceFilePath);

            // Чтение целевого файла
            List<string> targetLines = new List<string>(File.ReadAllLines(targetFilePath));

            // Поиск индекса строки 'set the frequency range'
            int frequencyRangeIndex = targetLines.FindIndex(line => line.Contains("set the frequency range"));

            if (frequencyRangeIndex != -1)
            {
                // Замена строки Solver.FrequencyRange
                string frequencyRangeLine = GetFrequencyRangeLineFromSourceFile(sourceLines);
                targetLines[frequencyRangeIndex + 1] = frequencyRangeLine;
            }

            // Поиск индекса строки 'set new materials'
            int newMaterialsIndex = targetLines.FindIndex(line => line.Contains("set new materials"));

            if (newMaterialsIndex != -1)
            {
                // Определение индекса строки, после которой должны быть вставлены новые материалы
                int insertIndex = newMaterialsIndex + 1;

                // Удаление всех строк Solid.ChangeMaterial после 'set new materials'
                targetLines.RemoveAll(line => line.StartsWith("Solid.ChangeMaterial") && targetLines.IndexOf(line) > newMaterialsIndex);

                // Вставка новых материалов из файла Project.Path
                string[] materialLines = GetMaterialLinesFromSourceFile(sourceLines);
                targetLines.InsertRange(insertIndex, materialLines.Take(3)); // Берем только первые 3 записи

                // Дополняем недостающие строки, если количество записей меньше 3
                int remainingLines = 3 - materialLines.Length;
                if (remainingLines > 0)
                {
                    string lastLine = materialLines.LastOrDefault();
                    for (int i = 0; i < remainingLines; i++)
                    {
                        targetLines.Insert(insertIndex + materialLines.Length + i, lastLine);
                    }
                }
            }
            // Запись изменений в целевой файл
            File.WriteAllLines(targetFilePath, targetLines);
        }

        // Метод для получения строки с Solver.FrequencyRange из исходного файла
        private string GetFrequencyRangeLineFromSourceFile(string[] sourceLines)
        {
            foreach (string line in sourceLines)
            {
                if (line.StartsWith("Solver.FrequencyRange"))
                {
                    return line;
                }
            }

            return string.Empty;
        }

        // Метод для получения строк с материалами из исходного файла
        private string[] GetMaterialLinesFromSourceFile(string[] sourceLines)
        {
            List<string> materialLines = new List<string>();

            bool insertMaterials = false;

            foreach (string line in sourceLines)
            {
                if (insertMaterials && line.StartsWith("Solid.ChangeMaterial"))
                {
                    materialLines.Add(line);
                }
                else if (line.Contains("Solid.ChangeMaterial"))
                {
                    insertMaterials = true;
                    materialLines.Add(line);
                }
            }

            return materialLines.ToArray();
        }
        #endregion

        #region Работа с данными синтеза в скрипте
        private void ReplaceDataInFileSintez()
        {
            {
                string targetFilePath;
                string sourceFilePath = Project.Path;
                if (DataStruct.ResonatorType == "Квадратный резонатор")
                {
                    targetFilePath = @"C:\CST_Files\Macros\Kvadrat\kvadrat_macros.txt"; // Укажите путь к целевому файлу
                }
                else if (DataStruct.ResonatorType == "Круглый резонатор")
                {
                    targetFilePath = @"C:\CST_Files\Macros\Krug\krug_macros.txt"; // Укажите путь к целевому файлу
                }
                else
                {
                    targetFilePath = @"C:\CST_Files\Macros\Romb\romb_macros.txt";
                }

                // Чтение исходного файла
                string[] sourceLines = File.ReadAllLines(sourceFilePath);

                // Чтение целевого файла
                List<string> targetLines = new List<string>(File.ReadAllLines(targetFilePath));

                // Поиск строки "While (num_pop <= {currentValue})"
                int whileLoopIndex = targetLines.FindIndex(line => line.Contains("While (num_pop <="));

                if (whileLoopIndex != -1)
                {
                    // Поиск строки с значением PopulationNumber
                    string populationNumberLine = GetPopulationNumberLineFromSourceFile(sourceLines);

                    // Получение значения PopulationNumber
                    int populationNumber = ExtractPopulationNumber(populationNumberLine);

                    // Замена значения в строке While (num_pop <= {currentValue})
                    string whileLoopLine = ModifyWhileLoopLine(targetLines[whileLoopIndex], populationNumber);
                    targetLines[whileLoopIndex] = whileLoopLine;
                }

                // Запись изменений в целевой файл
                File.WriteAllLines(targetFilePath, targetLines);
            }
        }
        // Метод для получения строки с PopulationNumber из исходного файла
        private string GetPopulationNumberLineFromSourceFile(string[] sourceLines)
        {
            foreach (string line in sourceLines)
            {
                if (line.Contains("PopulationNumber="))
                {
                    return line;
                }
            }

            return string.Empty;
        }

        // Метод для извлечения значения PopulationNumber из строки
        private int ExtractPopulationNumber(string populationNumberLine)
        {
            // Извлечение значения после знака равенства
            int startIndex = populationNumberLine.IndexOf("=") + 1;
            string populationNumberString = populationNumberLine.Substring(startIndex).Trim();

            if (int.TryParse(populationNumberString, out int populationNumber))
            {
                return populationNumber;
            }

            return 0; // Значение по умолчанию
        }

        // Метод для замены значения в строке While (num_pop <= {currentValue})
        private string ModifyWhileLoopLine(string whileLoopLine, int populationNumber)
        {
            // Замена значения в строке
            string modifiedLine = Regex.Replace(whileLoopLine, @"(?<=<=\s+)\d+", populationNumber.ToString());
            return modifiedLine;
        }
        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            ReplaceDataInFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReplaceDataInFileMat();
            ReplaceDataInFileSintez();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string scriptPath = @"C:\Users\SaintvRAI\source\repos\MetasurfaceSystem\bin\Debug\CST\Screens\kvadrat.vbs";
            RunVbsScript(scriptPath);
        }
        //TODO: Попробовать сделать progress bar для скрипта
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (CheckKvadratStructData() == true)
            {
                var proc = new Process();
                proc.EnableRaisingEvents = true;
                proc.Exited += (s, ev) =>
                {
                    // Обновление ProgressBar после завершения скрипта
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = 100;
                        MessageBox.Show(
                            "Проектная процедура завершила работу." +
                            "Испытание пройдено",
                            "Готово!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }));
                };

                string path = @"C:\CST_Files\Macros\Kvadrat";
                string cmdLine = $@"{path}\kvadrat_struct.vbs";

                proc.StartInfo = new ProcessStartInfo("wscript", cmdLine);

                // Обновление ProgressBar во время выполнения скрипта
                proc.OutputDataReceived += (s, ev) =>
                {
                    if (!string.IsNullOrEmpty(ev.Data) && ev.Data.StartsWith("Progress:"))
                    {
                        string progressString = ev.Data.Substring("Progress:".Length).Trim();
                        int progressValue = int.Parse(progressString);
                        progressBar1.Invoke(new Action(() =>
                        {
                            progressBar1.Value = progressValue;
                        }));
                    }
                };

                proc.Start();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введеных всех данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}


