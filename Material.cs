using System.Drawing;

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

        public Material(string materialName, string type, double electricalConductivity, double magneticConductivity,
                    Color color)
        {
            MaterialName = materialName;
            Type = type;
            ElectricalConductivity = electricalConductivity;
            MagneticConductivity = magneticConductivity;
            Color = color;
           
        }

       
    }
}

