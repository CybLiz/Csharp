using System;
using System.Collections.Generic;
using System.Text;

namespace CompteBancaire.Classes
{
    internal class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int idClient { get; set; }
        public string PhoneNumber { get; set; }
        public List<BankAccount> Accounts { get; set; }
        public Client(string firstname, string lastName, int idClient, string phoneNumber) {
            FirstName = firstname;
            LastName = lastName;
            this.idClient = idClient;
            PhoneNumber = phoneNumber;
            Accounts = new List<BankAccount>();

        }
    }
}
