using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem
{
    public static class Project
    {
        public static string Name { get; set; }
        public static string Path { get; set; }
        public static string MetascreenStructName { get; set; }
        public static int MinFrequency { get; set; }
        public static int MaxFrequency { get; set; }
        public static int PopulationNumber {get; set;}
        public static double MutationChance { get; set; }
        public static double CrossingChance { get; set; }

    }
}
