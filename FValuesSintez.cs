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
    public partial class FValuesSintez : Form
    {
        public FValuesSintez()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int populationNumber;
            double mutationChance;
            double crossingChance;

            if (!int.TryParse(txtPopulationNumber.Text, out populationNumber))
            {
                MessageBox.Show("Пожалуйста, введите целочисленное значение для поля - Размер популяции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            if (!double.TryParse(txtMutationChance.Text, out mutationChance) || mutationChance < 0 || mutationChance > 1)
            {
                MessageBox.Show("Пожалуйста, введите числовое значение от 0 до 1 для поля - Вероятность мутации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            if (!double.TryParse(txtCrossingChance.Text, out crossingChance) || crossingChance < 0 || crossingChance > 1)
            {
                MessageBox.Show("Пожалуйста, введите числовое значение от 0 до 1 для поля - Вероятность скрещивания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            // Продолжение выполнения сохранения после проверки данных

            Project.PopulationNumber = populationNumber;
            Project.MutationChance = mutationChance;
            Project.CrossingChance = crossingChance;

            // Запись данных в файл
            string filePath = Project.Path;

            string populationNumberLine = $"PopulationNumber={populationNumber}";
            string mutationChanceLine = $"MutationChance={mutationChance}";
            string crossingChanceLine = $"CrossingChance={crossingChance}";

            // Чтение содержимого файла
            string[] lines = File.ReadAllLines(filePath);

            // Поиск строк с нужными значениями
            bool foundPopulationNumber = false;
            bool foundMutationChance = false;
            bool foundCrossingChance = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("PopulationNumber="))
                {
                    // Замена строки
                    lines[i] = populationNumberLine;
                    foundPopulationNumber = true;
                }
                else if (lines[i].StartsWith("MutationChance="))
                {
                    // Замена строки
                    lines[i] = mutationChanceLine;
                    foundMutationChance = true;
                }
                else if (lines[i].StartsWith("CrossingChance="))
                {
                    // Замена строки
                    lines[i] = crossingChanceLine;
                    foundCrossingChance = true;
                }
            }

            // Если строки не найдены, добавляем их в конец файла
            if (!foundPopulationNumber)
            {
                List<string> updatedLines = new List<string>(lines);
                updatedLines.Add(populationNumberLine);
                lines = updatedLines.ToArray();
            }
            if (!foundMutationChance)
            {
                List<string> updatedLines = new List<string>(lines);
                updatedLines.Add(mutationChanceLine);
                lines = updatedLines.ToArray();
            }
            if (!foundCrossingChance)
            {
                List<string> updatedLines = new List<string>(lines);
                updatedLines.Add(crossingChanceLine);
                lines = updatedLines.ToArray();
            }

            // Запись изменений в файл
            File.WriteAllLines(filePath, lines);

            DialogResult = DialogResult.OK;
        }

        private void LoadData()
        {
            string filePath = Project.Path;

            // Проверка существования файла
            if (File.Exists(filePath))
            {
                // Чтение содержимого файла
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (line.StartsWith("PopulationNumber="))
                    {
                        string populationNumberStr = line.Substring("PopulationNumber=".Length);
                        if (int.TryParse(populationNumberStr, out int populationNumber))
                        {
                            txtPopulationNumber.Text = populationNumber.ToString();
                        }
                    }
                    else if (line.StartsWith("MutationChance="))
                    {
                        string mutationChanceStr = line.Substring("MutationChance=".Length);
                        if (double.TryParse(mutationChanceStr, out double mutationChance))
                        {
                            txtMutationChance.Text = mutationChance.ToString();
                        }
                    }
                    else if (line.StartsWith("CrossingChance="))
                    {
                        string crossingChanceStr = line.Substring("CrossingChance=".Length);
                        if (double.TryParse(crossingChanceStr, out double crossingChance))
                        {
                            txtCrossingChance.Text = crossingChance.ToString();
                        }
                    }
                }
            }
        }
    }
}
