using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    internal class CompteEpargne : BankAccount
    {
        private const double InterestRate = 0.03; 
        public CompteEpargne(Client client, double initialBalance = 0) : base(client, initialBalance)
        {
        }
        public void ApplyInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;
            Operations.Add(new Operations("Interest", interest, DateTime.Now));
        }
        public override string ToString()
        {
            return $"[CompteEpargne] Client: {Client.FirstName} {Client.LastName} | Balance: {Balance} €";
        }
    }
}
