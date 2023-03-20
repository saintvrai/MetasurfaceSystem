using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MySystem
{
    public class Material
    {
        private string materialName;
        private string type;
        private double electicConductivity;
        private double magneticConductivity;
        private Color color;

        public static string MaterialName { get; set; }
        public static string Type { get; set; }
        public static double ElectricalConductivity { get; set; }
        public static double MagneticConductivity { get; set; }
        public static Color Color { get; set; }
        public static double Rho { get; set; }
        public static double ThermalConductivity { get; set; }
        public static double HeatCapacity { get; set; }
       // public static double Diffusivity { get; set; }
        public static double YoungModulus { get; set; }
        public static double PoissonRatio { get; set; }
        public static double ThermalExpansionCoefficient { get; set; }

        public Material(string materialName, string type, double electricalConductivity, double magneticConductivity,
                    Color color, double rho, double thermalConductivity, double heatCapacity,
                    double youngModulus, double poissonRatio, double thermalExpansionCoefficient)
        {
            MaterialName = materialName;
            Type = type;
            ElectricalConductivity = electricalConductivity;
            MagneticConductivity = magneticConductivity;
            Color = color;
            Rho = rho;
            ThermalConductivity = thermalConductivity;
            HeatCapacity = heatCapacity;
            //Diffusivity = diffusivity;
            YoungModulus = youngModulus;
            PoissonRatio = poissonRatio;
            ThermalExpansionCoefficient = thermalExpansionCoefficient;
        }

        public Material(string materialName, string type, double electicConductivity, double magneticConductivity, Color color)
        {
            this.materialName = materialName;
            this.type = type;
            this.electicConductivity = electicConductivity;
            this.magneticConductivity = magneticConductivity;
            this.color = color;
        }
    }
}

