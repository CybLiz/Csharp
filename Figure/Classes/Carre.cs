using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Classes
{
    internal class Carre : Figure
    {
        public double Cote { get; set; }
        public Carre(Point origine, double cote) : base(origine)
        {
            Cote = cote;
        }
        public override string ToString()
        {
            return $"Carré: Côté = {Cote}, {base.ToString()}";
        }
        public override void Deplacement(double dx, double dy)
        {
            Origine.posX += dx;
            Origine.posY += dy;
        }
    }
}
