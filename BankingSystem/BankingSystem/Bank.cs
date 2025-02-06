using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace BankingSystem
{
    public class Bank
    {
        public string BankName { get; set; }
        private List<Customer> customers = new List<Customer>();

        public Bank(string bankName)
        {
            BankName = bankName;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(int customerId)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine("Customer Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Customer Not Found.");
            }
        }

        public void OpenAccount(int customerId, int accountId, double initialBalance)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                customer.AddAccount(new Account(accountId, initialBalance));
                Console.WriteLine("Account Opened Successfully.");
            }
            else
            {
                Console.WriteLine("Customer Not Found. Please Add Customer First.");
            }
        }

        public void ViewCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customers Available.");
                return;
            }

            Console.WriteLine($"\nCustomers of {BankName}:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.Name}");
                customer.ViewAccounts();
            }
        }
    }
}
