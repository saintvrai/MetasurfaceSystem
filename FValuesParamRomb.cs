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
    public partial class FValuesParamRomb : Form
    {
        public FValuesParamRomb()
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Запрет ввода точки
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }

            // Цифры с плавающей запятой
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
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
                        RombStruct.SubstrateWidth = double.Parse(line.Substring("Ширина подложки W=".Length));
                    else if (line.StartsWith("Длина подложки S="))
                        RombStruct.SubstrateLength = double.Parse(line.Substring("Длина подложки S=".Length));
                    else if (line.StartsWith("Максимальная длина внешнего кольца L="))
                        RombStruct.Lupperbound = double.Parse(line.Substring("Максимальная длина внешнего кольца L=".Length));
                    else if (line.StartsWith("Минимальная длина внешнего кольца L="))
                        RombStruct.Llowerbound = double.Parse(line.Substring("Минимальная длина внешнего кольца L=".Length));
                    else if (line.StartsWith("Максимальная длина внутреннего кольца K="))
                        RombStruct.Kupperbound = double.Parse(line.Substring("Максимальная длина внутреннего кольца K=".Length));
                    else if (line.StartsWith("Минимальная длина внутреннего кольца K="))
                        RombStruct.Klowerbound = double.Parse(line.Substring("Минимальная длина внутреннего кольца K=".Length));
                    else if (line.StartsWith("Максимальный радиус внутреннего кольца I="))
                        RombStruct.O_inner = double.Parse(line.Substring("Максимальный радиус внутреннего кольца I=".Length));
                    else if (line.StartsWith("Минимальный радиус внутреннего кольца I="))
                        RombStruct.I_inner = double.Parse(line.Substring("Минимальный радиус внутреннего кольца I=".Length));

                }

                textBox1.Text = RombStruct.SubstrateWidth.ToString();
                textBox3.Text = RombStruct.SubstrateLength.ToString();
                textBox6.Text = RombStruct.Llowerbound.ToString();
                textBox7.Text = RombStruct.Lupperbound.ToString();
                textBox4.Text = RombStruct.Klowerbound.ToString();
                textBox5.Text = RombStruct.Kupperbound.ToString();
                textBox8.Text = RombStruct.I_inner.ToString();
                textBox9.Text = RombStruct.O_inner.ToString();

            }
        }

        // Сохранение в файл параметры структуры
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            // Проверка заполнения всех текстовых полей
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Заполните все текстовые поля", "Ошибка");
                return;
            }

            double substrateWidth;
            double substrateLength;
            double lLowerbound;
            double lUpperbound;
            double kLowerbound;
            double kUpperbound;
            double O_inner;
            double I_inner;

            // Проверка корректности введенных значений
            if (!double.TryParse(textBox1.Text, out substrateWidth) ||
                !double.TryParse(textBox3.Text, out substrateLength) ||
                !double.TryParse(textBox6.Text, out lLowerbound) ||
                !double.TryParse(textBox7.Text, out lUpperbound) ||
                !double.TryParse(textBox4.Text, out kLowerbound) ||
                !double.TryParse(textBox5.Text, out kUpperbound) ||
                !double.TryParse(textBox9.Text, out O_inner) ||
                !double.TryParse(textBox8.Text, out I_inner))
            {
                MessageBox.Show("Проверьте правильность введенных данных(Попробуйте вместо точки использовать запятую)", "Ошибка");
                return;
            }

            if (O_inner < I_inner)
            {
                MessageBox.Show("Значение радиуса большего кольца, должно быть строго больше)", "Ошибка");
                return;
            }


            // Проверка вписывания окружности в ромб
            double d1 = lLowerbound * 2; // первая диагональ ромба
            double d2 = kLowerbound * 2; // вторая диагональ ромба

            if (d1 > substrateWidth || d2 > substrateWidth)
            {
                MessageBox.Show("Диагонали ромба, не могут выходить за рамки подложки)", "Ошибка");
            
            }

            if (O_inner * 2 < Math.Min(d1, d2))
            {
                Project.MetascreenStructName = DataStruct.ResonatorType.ToString();
                RombStruct.SubstrateWidth = substrateWidth;

                // Проверка, что ни одно значение не превышает ширину подложки
                if (lLowerbound > substrateWidth || lUpperbound > substrateWidth ||
                    kLowerbound > substrateWidth || kUpperbound > substrateWidth ||
                    O_inner > substrateWidth || I_inner > substrateWidth)
                {
                    MessageBox.Show("Значения не могут быть больше Ширина подложки W", "Ошибка");
                    return;
                }

                RombStruct.SubstrateLength = substrateLength;
                RombStruct.Llowerbound = lLowerbound;
                RombStruct.Lupperbound = lUpperbound;
                RombStruct.Klowerbound = kLowerbound;
                RombStruct.Kupperbound = kUpperbound;
                RombStruct.I_inner = I_inner;
                RombStruct.O_inner = O_inner;

                using (StreamWriter writer = new StreamWriter(Project.Path, false))
                {
                    writer.WriteLine("Структура:" + Project.MetascreenStructName + "\n");
                    writer.WriteLine("Ширина подложки W=" + RombStruct.SubstrateWidth);
                    writer.WriteLine("Длина подложки S=" + RombStruct.SubstrateLength);
                    writer.WriteLine("Максимальная длина внешнего кольца L=" + RombStruct.Lupperbound);
                    writer.WriteLine("Минимальная длина внешнего кольца L=" + RombStruct.Llowerbound);
                    writer.WriteLine("Максимальная длина внутреннего кольца K=" + RombStruct.Kupperbound);
                    writer.WriteLine("Минимальная длина внутреннего кольца K=" + RombStruct.Klowerbound);
                    writer.WriteLine("Максимальный радиус внутреннего кольца I=" + RombStruct.O_inner);
                    writer.WriteLine("Минимальный радиус внутреннего кольца I=" + RombStruct.I_inner + "\n");

                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных и ограничения", "Ошибка");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
