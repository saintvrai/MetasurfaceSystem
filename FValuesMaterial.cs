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
    public partial class FValuesMaterial : Form
    {
        FAddNewMaterial addNewMaterial;

        public FValuesMaterial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewMaterial = new FAddNewMaterial();
            addNewMaterial.ShowDialog();
            if(addNewMaterial.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Add(Material.MaterialName);
            }
        }
    }
}
