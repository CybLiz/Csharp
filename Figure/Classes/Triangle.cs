using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Classes
{
    internal class Triangle : Figure
    {
        public double Base { get; set; }
        public double Hauteur { get; set; }
        public Triangle(Point origine, double baseLength, double hauteur) : base(origine)
        {
            Base = baseLength;
            Hauteur = hauteur;
        }
        public override string ToString()
        {
            return $"Triangle: Base = {Base}, Hauteur = {Hauteur}, {base.ToString()}";
        }
        public override void Deplacement(double dx, double dy)
        {
            Origine.posX += dx;
            Origine.posY += dy;
        }

    }
}
