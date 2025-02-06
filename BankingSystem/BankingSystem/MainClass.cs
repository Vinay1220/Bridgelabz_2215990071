using System;
using System.Collections.Generic;

namespace BankingSystem
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("SBI Bank");

            while (true)
            {
                Console.WriteLine("\nBanking System:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Open Account for Customer");
                Console.WriteLine("3. View Customer Details");
                Console.WriteLine("4. Remove Customer");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Customer ID: ");
                        int customerId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Customer Name: ");
                        string name = Console.ReadLine();

                        Customer newCustomer = new Customer(customerId, name);
                        bank.AddCustomer(newCustomer);
                        Console.WriteLine("Customer Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Customer ID: ");
                        int custId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Account ID: ");
                        int accountId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Initial Balance: ");
                        double balance = double.Parse(Console.ReadLine());

                        bank.OpenAccount(custId, accountId, balance);
                        break;

                    case 3:
                        bank.ViewCustomers();
                        break;

                    case 4:
                        Console.Write("Enter Customer ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        bank.RemoveCustomer(removeId);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
