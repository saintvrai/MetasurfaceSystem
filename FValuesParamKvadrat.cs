using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public partial class FValuesParamKvadrat : Form
    {
        public FValuesParamKvadrat()
        {
            InitializeComponent();
            textBox2.Text = DataStruct.ResonatorType;

            //Загрузка фото по структуре метаэкрана со схемой
            string filepath = @"C:\CST_Files\schemas\" + textBox2.Text + ".jpg";
            if (File.Exists(filepath))
            {
                pictureBox1.ImageLocation = filepath;
                pictureBox1.Load(filepath);
                pictureBox1.Update();
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
            }

            // Загружаем данные из проекта, если они есть
            LoadData();
        }


        private void check_buttuns(ref object sender, ref KeyPressEventArgs e)
        {
            // Проверка на ctrl и на букву
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Цифры с плавающей запятой
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }

        // Загружаем данные о проекте в форму, если там они есть
        private void LoadData()
        {
            

            using (StreamReader reader = new StreamReader(Project.Path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Ширина подложки W="))
                        KvadratStruct.SubstrateWidth = double.Parse(line.Substring("Ширина подложки W=".Length));
                    else if (line.StartsWith("Длина подложки S="))
                        KvadratStruct.SubstrateLength = double.Parse(line.Substring("Длина подложки S=".Length));
                    else if (line.StartsWith("Максимальная длина внешнего кольца L="))
                        KvadratStruct.Lupperbound = double.Parse(line.Substring("Максимальная длина внешнего кольца L=".Length));
                    else if (line.StartsWith("Минимальная длина внешнего кольца L="))
                        KvadratStruct.Llowerbound = double.Parse(line.Substring("Минимальная длина внешнего кольца L=".Length));
                    else if (line.StartsWith("Минимальная длина внутреннего кольца K="))
                        KvadratStruct.Klowerbound = double.Parse(line.Substring("Минимальная длина внутреннего кольца K=".Length));
                    else if (line.StartsWith("Максимальная длина внутреннго кольца K="))
                        KvadratStruct.Kupperbound = double.Parse(line.Substring("Максимальная длина внутреннго кольца K=".Length));
                    else if (line.StartsWith("Минимальная длина вырезки кольца H="))
                        KvadratStruct.Hlowerbound = double.Parse(line.Substring("Минимальная длина вырезки кольца H=".Length));
                    else if (line.StartsWith("Максимальная длина вырезки кольца H="))
                        KvadratStruct.Hupperbound = double.Parse(line.Substring("Максимальная длина вырезки кольца H=".Length));
                }

                textBox1.Text = KvadratStruct.SubstrateWidth.ToString();
                textBox3.Text = KvadratStruct.SubstrateLength.ToString();
                textBox6.Text = KvadratStruct.Llowerbound.ToString();
                textBox7.Text = KvadratStruct.Lupperbound.ToString();
                textBox4.Text = KvadratStruct.Klowerbound.ToString();
                textBox5.Text = KvadratStruct.Kupperbound.ToString();
                textBox8.Text = KvadratStruct.Hlowerbound.ToString();
                textBox9.Text = KvadratStruct.Hupperbound.ToString();

            }
        }

        // Сохранение в файл параметры структуры
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Project.MetascreenStructName = DataStruct.ResonatorType.ToString();
            KvadratStruct.SubstrateWidth = double.Parse(textBox1.Text);
            KvadratStruct.SubstrateLength = double.Parse(textBox3.Text);
            KvadratStruct.Llowerbound = double.Parse(textBox6.Text);
            KvadratStruct.Lupperbound = double.Parse(textBox7.Text);
            KvadratStruct.Klowerbound = double.Parse(textBox4.Text);
            KvadratStruct.Kupperbound = double.Parse(textBox5.Text);
            KvadratStruct.Hlowerbound = double.Parse(textBox8.Text);
            KvadratStruct.Hupperbound = double.Parse(textBox9.Text);

            using (StreamWriter writer = new StreamWriter(Project.Path, false))
            {
                writer.WriteLine("Структура:" + Project.MetascreenStructName + "\n");
                writer.WriteLine("Ширина подложки W=" + KvadratStruct.SubstrateWidth);
                writer.WriteLine("Длина подложки S=" + KvadratStruct.SubstrateLength);
                writer.WriteLine("Максимальная длина внешнего кольца L=" + KvadratStruct.Lupperbound);
                writer.WriteLine("Минимальная длина внешнего кольца L=" + KvadratStruct.Llowerbound);
                writer.WriteLine("Минимальная длина внутреннего кольца K=" + KvadratStruct.Klowerbound);
                writer.WriteLine("Максимальная длина внутреннго кольца K=" + KvadratStruct.Kupperbound);
                writer.WriteLine("Минимальная длина вырезки кольца H=" + KvadratStruct.Hlowerbound);
                writer.WriteLine("Максимальная длина вырезки кольца H=" + KvadratStruct.Hupperbound);

            }
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
