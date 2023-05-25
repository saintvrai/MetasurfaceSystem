using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public partial class FValuesFrequency : Form
    {
        public FValuesFrequency()
        {
            InitializeComponent();
            LoadData();
            RestrictToIntegerInput(txtMaxFrequency);
            RestrictToIntegerInput(txtMinFrequency);
        }

        private void RestrictToIntegerInput(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Блокировка ввода символов, отличных от цифр и управляющих символов (например, Backspace)
                    MessageBox.Show("Пожалуйста, введите целочисленное значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Получение значений из текстовых полей
            int maxFrequency = 0;
            int minFrequency = 0;

            if (!int.TryParse(txtMaxFrequency.Text, out maxFrequency) || !int.TryParse(txtMinFrequency.Text, out minFrequency))
            {
                MessageBox.Show("Пожалуйста, введите целочисленные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            // Проверка условия maxFrequency > minFrequency
            if (maxFrequency <= minFrequency)
            {
                MessageBox.Show("Значение в поле Max Frequency должно быть больше значения в поле Min Frequency.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            // Запись значений в переменные класса Project
            Project.MaxFrequency = maxFrequency;
            Project.MinFrequency = minFrequency;

            // Запись данных в файл
            string filePath = Project.Path;

            string frequencyLine = $"Solver.FrequencyRange \"{minFrequency}\", \"{maxFrequency}\"";

            // Чтение содержимого файла
            string[] lines = File.ReadAllLines(filePath);

            // Поиск строки с Solver.FrequencyRange
            bool foundFrequencyRange = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("Solver.FrequencyRange"))
                {
                    // Замена строки
                    lines[i] = frequencyLine;
                    foundFrequencyRange = true;
                    break;
                }
            }

            // Если строка Solver.FrequencyRange не найдена, добавляем ее в конец файла
            if (!foundFrequencyRange)
            {
                List<string> updatedLines = new List<string>(lines);
                updatedLines.Add(frequencyLine);
                lines = updatedLines.ToArray();
            }

            // Запись изменений в файл
            File.WriteAllLines(filePath, lines);

            DialogResult = DialogResult.OK;
        }

        // Загрузка данных с файла
        private void LoadData()
        {
            string filePath = Project.Path;

            // Чтение содержимого файла
            string[] lines = File.ReadAllLines(filePath);

            // Поиск строки с Solver.FrequencyRange
            string frequencyLine = null;
            foreach (string line in lines)
            {
                if (line.Contains("Solver.FrequencyRange"))
                {
                    frequencyLine = line;
                    break;
                }
            }

            if (frequencyLine != null)
            {
                // Извлечение значений минимальной и максимальной частоты
                string[] frequencies = frequencyLine.Split('\"');
                if (frequencies.Length >= 3)
                {
                    string minFrequency = frequencies[1];
                    string maxFrequency = frequencies[3];

                    // Вставка значений в текстовые поля
                    txtMinFrequency.Text = minFrequency;
                    txtMaxFrequency.Text = maxFrequency;
                }
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
