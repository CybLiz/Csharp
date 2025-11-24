// Animal.cs
using System;

namespace CsharpTest.Entity
{
    internal class Animal
    {
        public string Nom { get; set; }
        public string Espece { get; set; }
        public int Age { get; set; }

        public Animal(string nom, string espece, int age)
        {
            Nom = nom;
            Espece = espece;
            Age = age;
        }

        public void Manger() => Console.WriteLine($"{Nom} est en train de manger.");
        public void Dormir() => Console.WriteLine($"{Nom} dort.");
    }
}
