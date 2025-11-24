using System;
using System.Collections.Generic;
using System.Text;

namespace Pendu.Classes
{
    internal class Game
    {
        public string WordToGuess { get; set; }
        public string Mask { get; set; }
        public int Attempts { get; set; }
        public Game(string wordToGuess)
        {
            WordToGuess = wordToGuess;
            Mask = new string('_', wordToGuess.Length);
            Attempts = 5; 
        }

        private string GenerateMask()
        {
            return new string('*', WordToGuess.Length);
        }
        private string TestChar(char c)
        {
            c = char.ToLower(c);
            if(WordToGuess.ToLower().Contains(c))
            {

       
            }
            else
            {
                Attempts--;
                return $"Sorry, '{c}' is not in the word. You have {Attempts} attempts left.";
            }
        }




    }
}
