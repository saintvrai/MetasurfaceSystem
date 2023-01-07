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
    public partial class Form1 : Form
    {
        public TextBox txb;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 100;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            ввестиЗначенияПараметровToolStripMenuItem.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

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


        //TODO: значения форм с одной на другую формы

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
        
        
        private void ввестиДанныеОПараметрахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаём новую форму ввода данных о параметрах метаэкрана 
            FValuesParam paramStruct = new FValuesParam();
            paramStruct.StartPosition = FormStartPosition.CenterScreen;
            DialogResult dr = paramStruct.ShowDialog();
            if (dr == DialogResult.OK)
            {
                данныеОМатериалахToolStripMenuItem.Enabled = true;
            }
            
        }

    }
}
