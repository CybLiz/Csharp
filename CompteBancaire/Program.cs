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
            CompteCourant compteCourant = new CompteCourant(client1, 150);
            client1.Accounts.Add(compteCourant);
            compteCourant.Withdraw(100);

            //IHM
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(account1);
                        Console.WriteLine(account2);
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account1.Deposit(depositAmount);
                        Console.WriteLine("Deposit successful.");
                        break;
                    case 3:
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (account1.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine("Withdrawal successful.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        break;
                    case 4:
                         foreach (var op in account1.Operations)
                            {
                                Console.WriteLine(op);
                            }
                            break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }

    }
}