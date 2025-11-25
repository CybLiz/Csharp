using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Classes
{
    internal class Point
    {
        public double posX { get; set; }
        public double posY { get; set; }
        public Point(double x, double y)
        {
            posX = x;
            posY = y;
        }
        public override string ToString()
        {
            return $"({posX}, {posY})";
        }

    }
}
