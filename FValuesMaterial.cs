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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MySystem
{
    public partial class FValuesMaterial : Form
    {
        int index = 0;
        FAddNewMaterial addNewMaterial;

        public FValuesMaterial()
        {
            InitializeComponent();
            LoadMaterialsToListView(@"C:\CST_Files\Materials");
            LoadDataFromProjectFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewMaterial = new FAddNewMaterial();
            addNewMaterial.ShowDialog();

            if (addNewMaterial.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Add(Material.MaterialName);
                int i = 1;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(Material.MaterialName);
                item.SubItems.Add(Material.Type);
                item.SubItems.Add(Material.ElectricalConductivity.ToString());
                listView1.Items.Add(item);
                i++;
            }
        }
        // Загружаем все материалы из папки с материалами в таблицу
        private void LoadMaterialsToListView(string folderPath)
        {
            DirectoryInfo d = new DirectoryInfo(folderPath);
            foreach (var file in d.GetFiles("*.txt"))
            {
                string fileName = file.Name;
                string type = "";

                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Type"))
                        {
                            type = line.Substring(line.IndexOf("=") + 1).Trim();
                        }
                    }
                }

                ListViewItem item = new ListViewItem(new string[] { Path.GetFileNameWithoutExtension(file.Name) });
                item.SubItems.Add(type);
                item.SubItems.Add(folderPath);
                listView1.Items.Add(item);
            }

        }
        // Загружаем данные, если они есть в проекте

        private void LoadDataFromProjectFile()
        {
            string filePath = Project.Path; // Путь к файлу проекта

            // Чтение содержимого файла
            string[] lines = File.ReadAllLines(filePath);

            // Поиск строк с данными и их обработка
            foreach (string line in lines)
            {
                if (line.StartsWith("Solid.ChangeMaterial"))
                {
                    string[] parts = line.Split('\"');
                    string component = parts[1];
                    string material = parts[3];

                    // Заполнение TextBox'ов в зависимости от компонента
                    if (component == "component1:Substrate")
                    {
                        textBox2.Text = material;
                    }
                    else if (component == "component1:outter")
                    {
                        textBox3.Text = material;
                    }
                    else if (component == "component1:inner")
                    {
                        textBox4.Text = material;
                    }
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //apply your search only when pressing ENTER key
            {
                string searchName = textBox1.Text; // get the search name from the TextBox
                ListViewItem foundItem = listView1.FindItemWithText(searchName); // search for the item by its text property
                if (foundItem != null) // check if the item was found
                {
                    listView1.EnsureVisible(foundItem.Index);
                    foundItem.Selected = true; // select the found item
                    listView1.Focus(); // set focus to the ListView to show the selected item

                }
                else
                {
                    MessageBox.Show("Item not found."); // display an error message if the item was not found
                }
            }

        }

        // Поиск по выбранному материалу и загрузка его параметров
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folderPath = @"C:\CST_Files\Materials\";
            DirectoryInfo d = new DirectoryInfo(folderPath);
            // Check if any item is selected in the listview
            listBox1.Items.Clear();
            if (listView1.SelectedItems.Count > 0)
            {
                string fileName = listView1.SelectedItems[0].SubItems[0].Text;
                using (StreamReader reader = new StreamReader(folderPath + Path.GetFileName(fileName) + ".txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            string fileName = listView1.SelectedItems[0].SubItems[0].Text;

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter the name of the file to be deleted.");
                return;
            }

            string filePath = Path.Combine(@"C:\CST_Files\Materials", fileName);

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    MessageBox.Show("File deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Проверка, что выбран элемент в ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Получение выбранного элемента
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Получение названия материала
                string materialName = selectedItem.SubItems[0].Text;

                // Добавление названия материала в TextBox
                textBox2.Text = materialName;

                // Запись в файл
                string component = "component1:Substrate"; // Здесь нужно указать нужный компонент
                string material = materialName;
                WriteMaterialToFile(component, material);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Проверка, что выбран элемент в ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Получение выбранного элемента
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Получение названия материала
                string materialName = selectedItem.SubItems[0].Text;

                // Добавление названия материала в TextBox
                textBox3.Text = materialName;

                // Запись в файл
                string component = "component1:outter"; // Здесь нужно указать нужный компонент
                string material = materialName;
                WriteMaterialToFile(component, material);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Проверка, что выбран элемент в ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Получение выбранного элемента
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Получение названия материала
                string materialName = selectedItem.SubItems[0].Text;

                // Добавление названия материала в TextBox
                textBox4.Text = materialName;

                // Запись в файл
                string component = "component1:inner"; // Здесь нужно указать нужный компонент
                string material = materialName;
                WriteMaterialToFile(component, material);
            }
        }

        private void WriteMaterialToFile(string component, string material)
        {
            string filePath = Project.Path; // Путь к файлу проекта

            // Чтение содержимого файла
            string[] lines = File.ReadAllLines(filePath);

            bool componentFound = false;
            bool materialChanged = false;

            // Поиск строки с указанным компонентом
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(component))
                {
                    componentFound = true;
                    // Замена строки с материалом
                    lines[i] = $"Solid.ChangeMaterial \"{component}\", \"{material}\"";
                    materialChanged = true;
                    break;
                }
            }

            // Если строка с указанным компонентом не найдена, добавляем ее в конец файла
            if (!componentFound)
            {
                lines = lines.Append($"Solid.ChangeMaterial \"{component}\", \"{material}\"").ToArray();
                materialChanged = true;
            }

            // Запись изменений в файл, только если материал был изменен
            if (materialChanged)
            {
                File.WriteAllLines(filePath, lines);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                                                                 // Ваш код для обновления данных в переменной fileContent

                File.WriteAllText(filePath, fileContent); // Перезапись файла с обновленным содержимым

                MessageBox.Show("Файл успешно сохранен.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
