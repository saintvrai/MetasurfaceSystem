using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem
{
    public class Material 
    {
        public static string MaterialName { get; set; }
        public static string Type { get; set; }
        public static double ElectricalConductivity { get; set; }
        public static double MagneticConductivity { get; set; }
        public static Color Color { get; set; }

        public Material(string materialName, string type, double electricalPermeability, double permeability, Color color)
        {
            MaterialName = materialName;
            Type = type;
            ElectricalConductivity = electricalPermeability;
            MagneticConductivity = permeability;
            Color = color;
        }
    }
}

