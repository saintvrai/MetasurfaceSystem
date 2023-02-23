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
    public partial class FAddNewMaterial : Form
    {
        public FAddNewMaterial()
        {
            InitializeComponent();
            txtMaterialColor.BackColor = colorDialog1.Color;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void основныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label11.Text = "" + trackBar1.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string materialName = txtMaterialName.Text;
            double electicConductivity = double.Parse(txtElectricConductivity.Text);
            double magneticConductivity = double.Parse(txtMagneticConductivity.Text);
            Color color = txtMaterialColor.BackColor;
            string type = txtMaterialType.Text;
            //Material material1 = new Material();

            //Material.MaterialName = txtMaterialName.Text;
            //Material.ElectricalConductivity = double.Parse(txtElectricConductivity.Text);
            //Material.MagneticConductivity = double.Parse(txtMagneticConductivity.Text);
            //Material.Color = txtMaterialColor.BackColor;
            //Material.Type = txtMaterialType.Text;


            Material material1 = new Material(materialName, type, electicConductivity, magneticConductivity, color);
            //FValuesMaterial f = new FValuesMaterial();
            //f.listBox1.Items.Add(Material);
        }
    }
}
