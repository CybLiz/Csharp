using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    public enum OperationType
    {
        Deposit,
        Withdrawal
    }
    internal class Operations
    {
        private static int compteur = 1;
        public int Number { get; set; }
        public OperationType Type { get; set; }
        public double Amount { get; set; }

        public Operations(OperationType type, double amount)
        {
            Number = compteur++;
            Type = type;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Operation #{Number}: {Type} of {Amount} €";
        }
    }
}
