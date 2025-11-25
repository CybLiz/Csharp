using System;
using Pile.Classes;

class Program
{
    static void Main()
    {
        PileGenerique<decimal> pileDecimal = new PileGenerique<decimal>();
        PileGenerique<string> pileString = new PileGenerique<string>();
        PileGenerique<Personne> pilePersonne = new PileGenerique<Personne>();

        bool next = true;

        while (next)
        {
            Console.WriteLine("\n=== MENU DES PILES ===");
            Console.WriteLine("1 - Empiler");
            Console.WriteLine("2 - Dépiler");
            Console.WriteLine("3 - Récupérer par index");
            Console.WriteLine("0 - Quitter");
            Console.Write("Votre choix : ");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Console.Write("Entrez une valeur décimale à empiler : ");
                    string input = Console.ReadLine();

                    if (decimal.TryParse(input, out decimal valeur))
                    {
                        pileDecimal.Empiler(valeur);
                        Console.WriteLine($"{valeur} a été ajouté à la pile décimale.");
                    }
                    else
                    {
                        Console.WriteLine("Valeur non valide.");
                    }
                    break;

                case "2":
                    try
                    {
                        decimal depile = pileDecimal.Depiler();
                        Console.WriteLine($"Dernière valeur dépilée : {depile}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "3":
                    Console.Write("Veuillez donner un indice : ");
                    string idxString = Console.ReadLine();

                    if (int.TryParse(idxString, out int index))
                    {
                        try
                        {
                            decimal elem = pileDecimal.RetirerElementParIndex(index);
                            Console.WriteLine($"Valeur retirée à l'index {index} : {elem}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index invalide.");
                    }
                    break;

                case "0":
                    next = false;
                    break;

                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }
        }
    }
}
