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
    public partial class FValuesParamKrug : Form
    {
        public FValuesParamKrug()
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
        //TODO: поработать над кругом, вроде параметры то он пишет, но не записывает

        // Загружаем данные о проекте в форму, если там они есть
        private void LoadData()
        {
            using (StreamReader reader = new StreamReader(Project.Path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Ширина подложки W="))
                        KrugStruct.SubstrateWidth = double.Parse(line.Substring("Ширина подложки W=".Length));
                    else if (line.StartsWith("Длина подложки S="))
                        KrugStruct.SubstrateLength = double.Parse(line.Substring("Длина подложки S=".Length));
                    else if (line.StartsWith("Максимальный радиус внешнего кольца O="))
                        KrugStruct.O_outter = double.Parse(line.Substring("Максимальный радиус внешнего кольца O=".Length));
                    else if (line.StartsWith("Минимальный радиус внешнего кольца O="))
                        KrugStruct.I_outter = double.Parse(line.Substring("Минимальный радиус внешнего кольца O=".Length));
                    else if (line.StartsWith("Максимальный радиус внутреннего кольца I="))
                        KrugStruct.O_inner = double.Parse(line.Substring("Максимальный радиус внутреннего кольца I=".Length));
                    else if (line.StartsWith("Минимальный радиус внутреннего кольца I="))
                        KrugStruct.I_inner = double.Parse(line.Substring("Минимальный радиус внутреннего кольца I=".Length));
                    else if (line.StartsWith("Максимальная длина вырезки кольца H="))
                        KrugStruct.Hupperbound = double.Parse(line.Substring("Максимальная длина вырезки кольца H=".Length));
                    else if (line.StartsWith("Минимальная длина вырезки кольца H="))
                        KrugStruct.Hlowerbound = double.Parse(line.Substring("Минимальная длина вырезки кольца H=".Length));

                }

                textBox1.Text = KrugStruct.SubstrateWidth.ToString();
                textBox3.Text = KrugStruct.SubstrateLength.ToString();
                textBox6.Text = KrugStruct.I_outter.ToString();
                textBox7.Text = KrugStruct.O_outter.ToString();
                textBox4.Text = KrugStruct.I_inner.ToString();
                textBox5.Text = KrugStruct.O_inner.ToString();
                textBox8.Text = KrugStruct.Hlowerbound.ToString();
                textBox9.Text = KrugStruct.Hupperbound.ToString();

            }
        }

        // Сохранение в файл параметры структуры
        //private void btn_Save_Click(object sender, EventArgs e)
        //{
        //    // Проверка заполнения всех текстовых полей
        //    if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) ||
        //        string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
        //        string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) ||
        //        string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
        //    {
        //        MessageBox.Show("Заполните все текстовые поля", "Ошибка");
        //        return;
        //    }

        //    double I_outter;
        //    double O_outter;
        //    double I_inner;
        //    double O_inner;
        //    double substrateWidth;
        //    double substrateLength;
        //    double hLowerbound;
        //    double hUpperbound;

        //    // Проверка корректности введенных значений
        //    if (!double.TryParse(textBox1.Text, out substrateWidth) ||
        //        !double.TryParse(textBox3.Text, out substrateLength) ||
        //        !double.TryParse(textBox6.Text, out I_outter) ||
        //        !double.TryParse(textBox7.Text, out O_outter) ||
        //        !double.TryParse(textBox4.Text, out I_inner) ||
        //        !double.TryParse(textBox5.Text, out O_inner) ||
        //        !double.TryParse(textBox8.Text, out hLowerbound) ||
        //        !double.TryParse(textBox9.Text, out hUpperbound))
        //    {
        //        MessageBox.Show("Проверьте правильность введенных данных(Попробуйте вместо точки использовать запятую)", "Ошибка");
        //        return;
        //    }

        //    // Проверка перекрещивания внешнего и внутреннего кольца
        //    if (O_inner >= I_outter || O_outter <= I_inner)
        //    {
        //        MessageBox.Show("Малое кольцо не должно перекрываться с большим кольцом", "Ошибка");
        //        return;
        //    }

        //    // Проверка значений радиусов кольцевых структур
        //    if (O_outter <= I_outter || O_inner <= I_inner)
        //    {
        //        MessageBox.Show("Максимальный радиус кольца должен быть больше минимального радиуса кольца", "Ошибка");
        //        return;
        //    }

        //    // Проверка, что ни одно значение не превышает ширину подложки
        //    if (I_outter > substrateWidth || O_outter > substrateWidth ||
        //        I_inner > substrateWidth || O_inner > substrateWidth ||
        //        hLowerbound > substrateWidth || hUpperbound > substrateWidth)
        //    {
        //        Project.MetascreenStructName = DataStruct.ResonatorType.ToString();
        //        KrugStruct.SubstrateLength = substrateLength;
        //        KrugStruct.I_inner = I_inner;
        //        KrugStruct.O_inner = O_inner;
        //        KrugStruct.O_outter = O_outter;
        //        KrugStruct.I_outter = I_outter;
        //        KrugStruct.Hlowerbound = hLowerbound;
        //        KrugStruct.Hupperbound = hUpperbound;


        //        using (StreamWriter writer = new StreamWriter(Project.Path, false))
        //        {
        //            writer.WriteLine("Структура:" + Project.MetascreenStructName + "\n");
        //            writer.WriteLine("Ширина подложки W=" + KrugStruct.SubstrateWidth);
        //            writer.WriteLine("Длина подложки S=" + KrugStruct.SubstrateLength);
        //            writer.WriteLine("Максимальный радиус внешнего кольца O=" + KrugStruct.O_outter);
        //            writer.WriteLine("Минимальный радиус внешнего кольца O=" + KrugStruct.I_outter);
        //            writer.WriteLine("Максимальный радиус внутреннего кольца I=" + KrugStruct.O_inner);
        //            writer.WriteLine("Минимальный радиус внутреннего кольца I=" + KrugStruct.I_inner);
        //            writer.WriteLine("Максимальная длина вырезки кольца H=" + KrugStruct.Hupperbound);
        //            writer.WriteLine("Минимальная длина вырезки кольца H=" + KrugStruct.Hlowerbound + "\n");
        //        }
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Значения не могут быть больше Ширина подложки W", "Ошибка");
        //        return;
        //    }
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

            double I_outter;
            double O_outter;
            double I_inner;
            double O_inner;
            double substrateWidth;
            double substrateLength;
            double hLowerbound;
            double hUpperbound;

            // Проверка корректности введенных значений
            if (!double.TryParse(textBox1.Text, out substrateWidth) ||
                !double.TryParse(textBox3.Text, out substrateLength) ||
                !double.TryParse(textBox6.Text, out I_outter) ||
                !double.TryParse(textBox7.Text, out O_outter) ||
                !double.TryParse(textBox4.Text, out I_inner) ||
                !double.TryParse(textBox5.Text, out O_inner) ||
                !double.TryParse(textBox8.Text, out hLowerbound) ||
                !double.TryParse(textBox9.Text, out hUpperbound))
            {
                MessageBox.Show("Проверьте правильность введенных данных(Попробуйте вместо точки использовать запятую)", "Ошибка");
                return;
            }

            // Проверка перекрещивания внешнего и внутреннего кольца
            if (O_inner >= I_outter || O_outter <= I_inner)
            {
                MessageBox.Show("Малое кольцо не должно перекрываться с большим кольцом", "Ошибка");
                return;
            }

            // Проверка значений радиусов кольцевых структур
            if (O_outter <= I_outter || O_inner <= I_inner)
            {
                MessageBox.Show("Максимальный радиус кольца должен быть больше минимального радиуса кольца", "Ошибка");
                return;
            }

            // Проверка, что ни одно значение не превышает ширину подложки
            if (I_outter > substrateWidth || O_outter > substrateWidth ||
                I_inner > substrateWidth || O_inner > substrateWidth ||
                hLowerbound > substrateWidth || hUpperbound > substrateWidth)
            {
                MessageBox.Show("Значения не могут быть больше Ширина подложки W", "Ошибка");
               
            }
            else
            {
                Project.MetascreenStructName = DataStruct.ResonatorType.ToString();
                KrugStruct.SubstrateWidth = substrateWidth;
                KrugStruct.SubstrateLength = substrateLength;
                KrugStruct.I_inner = I_inner;
                KrugStruct.O_inner = O_inner;
                KrugStruct.O_outter = O_outter;
                KrugStruct.I_outter = I_outter;
                KrugStruct.Hlowerbound = hLowerbound;
                KrugStruct.Hupperbound = hUpperbound;


                using (StreamWriter writer = new StreamWriter(Project.Path, false))
                {
                    writer.WriteLine("Структура:" + Project.MetascreenStructName + "\n");
                    writer.WriteLine("Ширина подложки W=" + KrugStruct.SubstrateWidth);
                    writer.WriteLine("Длина подложки S=" + KrugStruct.SubstrateLength);
                    writer.WriteLine("Максимальный радиус внешнего кольца O=" + KrugStruct.O_outter);
                    writer.WriteLine("Минимальный радиус внешнего кольца O=" + KrugStruct.I_outter);
                    writer.WriteLine("Максимальный радиус внутреннего кольца I=" + KrugStruct.O_inner);
                    writer.WriteLine("Минимальный радиус внутреннего кольца I=" + KrugStruct.I_inner);
                    writer.WriteLine("Максимальная длина вырезки кольца H=" + KrugStruct.Hupperbound);
                    writer.WriteLine("Минимальная длина вырезки кольца H=" + KrugStruct.Hlowerbound + "\n");
                }
                this.Close();
            }
        }
    }
}
