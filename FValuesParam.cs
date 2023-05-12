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
    public partial class FValuesParam : Form
    {
        public FValuesParam()
        {
            InitializeComponent();
            textBox2.Text = DataStruct.ResonatorType;
            var sqauareResonator = new SquareResonator();
            sqauareResonator.OuterWidth = 50f;
            var fields = sqauareResonator.GetType().GetFields();
            foreach(var field in fields)
            {
                var newTextBox = new TextBox();
                newTextBox.Text = field.GetValue(sqauareResonator).ToString();
                fieldTable.Controls.Add(newTextBox);
                fieldTable.SetColumn(newTextBox, 0);
                fieldTable.SetRow(newTextBox, 0);
            }
            
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
        }
        private void copyControl(TextBox sourceControl, TextBox targetControl)
        {
            // make sure these are the same
            if (sourceControl.GetType() != targetControl.GetType())
            {
                throw new Exception("Incorrect control types");
            }

            foreach (PropertyInfo sourceProperty in sourceControl.GetType().GetProperties())
            {
                object newValue = sourceProperty.GetValue(sourceControl, null);

                MethodInfo mi = sourceProperty.GetSetMethod(true);
                if (mi != null)
                {
                    sourceProperty.SetValue(targetControl, newValue, null);
                }
            }
        }

        private void check_buttuns(ref object sender,ref KeyPressEventArgs e)
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
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            check_buttuns(ref sender, ref e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
