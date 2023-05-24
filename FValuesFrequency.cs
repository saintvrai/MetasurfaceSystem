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
    public partial class FValuesFrequency : Form
    {
        public FValuesFrequency()
        {
            InitializeComponent();
        }

        private void txtMaxFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Блокировка ввода символов, отличных от цифр и управляющих символов (например, Backspace)
                MessageBox.Show("Пожалуйста, введите целочисленное значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMinFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Блокировка ввода символов, отличных от цифр и управляющих символов (например, Backspace)
                MessageBox.Show("Пожалуйста, введите целочисленное значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
