using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    internal class CompteCourant : BankAccount
    {
        public CompteCourant(Client client, double initialBalance = 0) : base(client, initialBalance)
        {
        }
        public override string ToString()
        {
            return $"[CompteCourant] Client: {Client.FirstName} {Client.LastName} | Balance: {Balance} €";
        }
    }
}
