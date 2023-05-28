using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public class FileWatcher
    {
        private FileSystemWatcher watcher;
        private RichTextBox outputTextBox;

        public FileWatcher(RichTextBox richTextBox)
        {
            outputTextBox = richTextBox;

            // Создание экземпляра FileSystemWatcher
            watcher = new FileSystemWatcher();

            if(DataStruct.ResonatorType == "Квадратный резонатор")
            {
                watcher.Path = @"C:\CST_Files\Results\Kvadrat";
                watcher.Filter = "Final.txt";
            }
            else if (DataStruct.ResonatorType == "Круглый резонатор")
            {
                watcher.Path = @"C:\CST_Files\Results\Krug";
                watcher.Filter = "Final.txt";
            }
            else if (DataStruct.ResonatorType == "Ромбовидный резонатор")
            {
                watcher.Path = @"C:\CST_Files\Results\Romb";
                watcher.Filter = "Final.txt";
            }
            else
            {
                MessageBox.Show("Не удалось запустить объект класса FileWathcer", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Настройка событий
            watcher.Changed += OnFileChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            // Чтение содержимого файла
            string fileContent = File.ReadAllText(e.FullPath);

            // Обновление содержимого элемента Windows Forms
            outputTextBox.Invoke((MethodInvoker)(() => {
                outputTextBox.Text = fileContent;
            }));
        }
    }
}
