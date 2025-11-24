using System;
using System.Collections.Generic;
using System.Text;

namespace Pendu.Classes
{
    internal class WordGenerator
    {
        private static readonly List<string> Words = new List<string>
        {
            "programming",
            "computer",
            "developer",
            "interface",
            "application",
            "framework",
            "function",
            "variable",
            "algorithm"
        };
        private static readonly Random Random = new Random();
        public static string GetRandomWord()
        {
            int index = Random.Next(Words.Count);
            return Words[index];
        }
    }
}
