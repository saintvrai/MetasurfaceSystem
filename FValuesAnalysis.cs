using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public partial class FValuesAnalysis : Form
    {
        public FValuesAnalysis()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                label4.Text = "Расстояние:";
                textBox3.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label10.Enabled = false;
            }
            else
            {
                label4.Text = "Нижнее Х:";
                textBox3.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox10.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                label10.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked) 
            {
                label16.Text = "Тип:";
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                label9.Enabled = false;
                label11.Enabled =false;
                label12.Enabled =false;
                label13.Enabled =false;
                label14.Enabled =false;
            }
            else 
            {
                label16.Text = "Хмин:";
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;
                label9.Enabled = true;
                label11.Enabled = true;
                label12.Enabled = true;
                label13.Enabled = true;
                label14.Enabled = true;

            }
            // TODO: попробовать добавить базу и кнопку помощи при наведении сделать
        }
    }
}
