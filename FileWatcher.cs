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
            watcher.Path = @"C:\CST_Files\Kvadrat";
            watcher.Filter = "Final.txt";

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
