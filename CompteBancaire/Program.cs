using CompteBancaire.Classes;
using System;

namespace CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("liza", "bahloul", 1010, "010203040506");
            Client client2 = new Client("Jane", "Smith", 1234, "1234567890");
            BankAccount account1 = new ComptePayant(client1, 100);
            BankAccount account2 = new CompteEpargne(client2, 200);
            account1.Deposit(50);
            account1.Withdraw(30);
            Console.WriteLine(account1);
            account2.Deposit(100);
            ((CompteEpargne)account2).ApplyInterest();
            Console.WriteLine(account2);


        }

    }
}