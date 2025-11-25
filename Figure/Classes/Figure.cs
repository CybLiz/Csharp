using System;
using System.Collections.Generic;
using System.Text;
using Figure.Interfaces;

namespace Figure.Classes
{
    internal abstract class Figure : IDeplacable
    {
        public Point Origine { get; set; }
        public Figure(Point origine)
        {
            Origine = origine;
        }
        public abstract void Deplacement(double dx, double dy);
        public override string ToString()
        {
            return $"Origine: {Origine}";
        }

    }
}
