using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Classes
{
    internal class Rectangle : Figure
    {
        public double Largeur { get; set; }
        public double Hauteur { get; set; }
        public Rectangle(Point origine, double largeur, double hauteur) : base(origine)
        {
            Largeur = largeur;
            Hauteur = hauteur;
        }
        public override string ToString()
        {
            return $"Rectangle: Largeur = {Largeur}, Hauteur = {Hauteur}, {base.ToString()}";
        }
        public override void Deplacement(double dx, double dy)
        {
            Origine.posX += dx;
            Origine.posY += dy;
        }
    }
}
