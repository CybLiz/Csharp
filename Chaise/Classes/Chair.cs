using System;
using System.Collections.Generic;
using System.Text;

namespace Chaise.Classes
{
    internal class Chair
    {
        
        public string Color { get; set; }
        public string Material { get; set; }
        public int Feet { get; set; }
        public Chair(string color, string material, int feet)
        {
            Color = color;
            Material = material;
            Feet = feet;
        }
        public void DisplayChairInfo()
        {
            Console.WriteLine($"Chaise Details: Color : {Color}, Material : {Material} and Has {Feet} feet");
        }

    }
}
