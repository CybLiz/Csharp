using System;
using System.Collections.Generic;
using System.Text;


namespace CompteBancaire.Classes
{
    internal class ComptePayant : BankAccount
    {
        private const double WithdrawalFee = 1.0;
        private const double DepositFee = 0.5;
        public ComptePayant(Client client, double initialBalance = 0) : base(client, initialBalance)
        {
        }
        public override void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            base.Deposit(amount);
            Balance -= DepositFee;
        }
        public override bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            double totalAmount = amount + WithdrawalFee;
            if (Balance >= totalAmount)
            {
                Balance -= totalAmount;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"[ComptePayant] Client: {Client.FirstName} {Client.LastName} | Balance: {Balance} €";
        }

    }
}
