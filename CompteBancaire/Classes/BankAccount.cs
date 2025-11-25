using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    internal abstract class BankAccount
    {
        public double Balance { get; protected set; }
        public Client Client { get; set; }
        public List<Operations> Operations { get; set; }
        public BankAccount( Client client, double initialBalance = 0)
        {
            Operations = new List<Operations>();
            Client = client;
            Balance = initialBalance;
        }
        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Operations.Add(new Operations("Deposit", amount, DateTime.Now));
            }

        }
        public virtual bool Withdraw(double amount) { 
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Operations.Add(new Operations("Withdraw", amount, DateTime.Now));
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"[BankAccount] Client: {Client.FirstName} {Client.LastName} | Balance: {Balance} €";
        }


    }



}
