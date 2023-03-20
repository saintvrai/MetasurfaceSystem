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
    public partial class FAddNewMaterial : Form
    {
        public FAddNewMaterial()
        {
            InitializeComponent();
            txtMaterialColor.BackColor = colorDialog1.Color;
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
            double electricConductivity = double.Parse(txtElectricConductivity.Text);
            double magneticConductivity = double.Parse(txtMagneticConductivity.Text);
            Color color = txtMaterialColor.BackColor;
            string type = txtMaterialType.Text;
            double rho = double.Parse(txtMaterialRho.Text); 
            double thermalConductivity = double.Parse(txtMaterialThermalConductivity.Text);
            double heatCapacity = double.Parse(txtMaterialHeatCapacity.Text);
            double youngModulus = double.Parse(txtMaterialYoungModulus.Text);
            double poissonRatio = double.Parse(txtMaterialPoissonRatio.Text);
            double thermalExpansionCoefficient = double.Parse(txtMaterialThermalExpansionCoefficient.Text);

            Material material1 = new Material(materialName, type, electricConductivity, magneticConductivity, color,rho,thermalConductivity,heatCapacity,youngModulus,poissonRatio,thermalExpansionCoefficient);
            string fileName = @"C:\CST_Files\Materials\" + materialName + ".txt";
            using (StreamWriter sw = File.AppendText(fileName))
            {
                
                if (!string.IsNullOrEmpty(materialName))
                    sw.WriteLine("MaterialName: " + materialName);
                if (!string.IsNullOrEmpty(type))
                    sw.WriteLine("Type: " + type);
                if (electricConductivity != 0)
                    sw.WriteLine("ElectricalConductivity: " + electricConductivity);
                if (magneticConductivity != 0)
                    sw.WriteLine("MagneticConductivity: " + magneticConductivity);
                //if (material1.Color != null)
                //    sw.WriteLine("Color: " + material1.Color.Name);
                if (rho != 0)
                    sw.WriteLine("Rho: " + rho);
                if (thermalConductivity != 0)
                    sw.WriteLine("ThermalConductivity: " + thermalConductivity);
                if (heatCapacity != 0)
                    sw.WriteLine("HeatCapacity: " + heatCapacity);
                if (youngModulus != 0)
                    sw.WriteLine("YoungModulus: " + youngModulus);
                if (poissonRatio != 0)
                    sw.WriteLine("PoissonRatio: " + poissonRatio);
                if (thermalExpansionCoefficient != 0)
                    sw.WriteLine("ThermalExpansionCoefficient: " + thermalExpansionCoefficient);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
