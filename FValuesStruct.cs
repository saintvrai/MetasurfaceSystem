using System;
using System.Collections;
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
    public partial class FValuesStruct : Form
    {
        public FValuesStruct()
        {
            InitializeComponent();
        }
        //Кнопка сохранить и обработка ошибок
        public void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Выберите 1 структуру", "Ошибка");

            }
            else
            {
                Data.Value = listBox2.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Успешно");
                this.Close();
            }
        }

        //Загрузка фото со структурой из файла
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filepath = @"C:\CST_Files\structures\" + listBox2.SelectedItem.ToString().Trim() + ".jpg";
            if (File.Exists(filepath))
            {
                pictureBox1.ImageLocation = filepath;
                pictureBox1.Load(filepath);
                pictureBox1.Update();
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
            }
        }
    }
}
