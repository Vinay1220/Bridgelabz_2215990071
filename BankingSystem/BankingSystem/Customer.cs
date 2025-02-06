using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace BankingSystem
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        private List<Account> accounts = new List<Account>();

        public Customer(int customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void ViewAccounts()
        {
            if (accounts.Count == 0)
            {
                Console.WriteLine("  No Accounts Available.");
                return;
            }

            Console.WriteLine("  Accounts:");
            foreach (var account in accounts)
            {
                Console.WriteLine($"    Account ID: {account.AccountId}, Balance: {account.Balance:C}");
            }
        }
    }
}
