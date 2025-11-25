using System;
using System.Collections.Generic;
using System.Text;

namespace Pile.Classes
{
    internal class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
  
        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }
        public override string ToString()
        {
            return $"Nom: {Nom}, Prénom: {Prenom}, Âge: {Age}";
        }
    }
}
