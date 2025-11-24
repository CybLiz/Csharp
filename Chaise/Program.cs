using System;
using Chaise.Classes;

namespace ChaiseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair chaise1 = new Chair("Red", "Leather", 4);
            Chair chaise2 = new Chair("Blue", "Wood", 3);
            Chair chaise3 = new Chair("Green", "Plastic", 4);

            chaise1.DisplayChairInfo();
            chaise2.DisplayChairInfo();
            chaise3.DisplayChairInfo();
        }
    }
}
