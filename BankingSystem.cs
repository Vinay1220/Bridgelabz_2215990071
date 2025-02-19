using System;
using System.Collections.Generic;

public class BankingSystem
{
    // Dictionary to store account balances (account number -> balance)
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>();

    // Queue to process withdrawal requests (FIFO order)
    private Queue<int> withdrawalRequests = new Queue<int>();

    // Method to create an account with an initial balance
    public void CreateAccount(int accountNumber, double initialBalance)
    {
        if (!accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] = initialBalance;
            Console.WriteLine("Account " + accountNumber + " created with balance: " + initialBalance);
        }
        else
        {
            Console.WriteLine("Account already exists.");
        }
    }

    // Method to deposit money into an account
    public void Deposit(int accountNumber, double amount)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            accountBalances[accountNumber] += amount;
            Console.WriteLine("Deposited " + amount + " into account " + accountNumber);
        }
        else
        {
            Console.WriteLine("Account does not exist.");
        }
    }

    // Method to initiate a withdrawal request (request is added to the queue)
    public void RequestWithdrawal(int accountNumber)
    {
        if (accountBalances.ContainsKey(accountNumber))
        {
            withdrawalRequests.Enqueue(accountNumber);
            Console.WriteLine("Withdrawal requested for account " + accountNumber);
        }
        else
        {
            Console.WriteLine("Account does not exist.");
        }
    }

    // Method to process withdrawal requests (FIFO order)
    public void ProcessWithdrawals()
    {
        while (withdrawalRequests.Count > 0)
        {
            int accountNumber = withdrawalRequests.Dequeue();
            double balance = accountBalances[accountNumber];

            // Simulate a withdrawal processing (for simplicity, withdrawing fixed amount)
            double withdrawalAmount = 100;  // Example withdrawal amount

            if (balance >= withdrawalAmount)
            {
                accountBalances[accountNumber] -= withdrawalAmount;
                Console.WriteLine("Processed withdrawal of " + withdrawalAmount + " from account " + accountNumber);
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal from account " + accountNumber);
            }
        }
    }

    // Method to display accounts sorted by balance
    public void DisplaySortedAccounts()
    {
        var sortedAccounts = new SortedDictionary<double, List<int>>();

        foreach (var account in accountBalances)
        {
            if (!sortedAccounts.ContainsKey(account.Value))
            {
                sortedAccounts[account.Value] = new List<int>();
            }
            sortedAccounts[account.Value].Add(account.Key);
        }

        Console.WriteLine("Accounts sorted by balance:");
        foreach (var balance in sortedAccounts)
        {
            foreach (var accountNumber in balance.Value)
            {
                Console.WriteLine("Account: " + accountNumber + ", Balance: " + balance.Key);
            }
        }
    }
}

// Test the BankingSystem
public class Program
{
    public static void Main()
    {
        BankingSystem bank = new BankingSystem();

        // Create some accounts
        bank.CreateAccount(1001, 500.0);
        bank.CreateAccount(1002, 300.0);
        bank.CreateAccount(1003, 700.0);

        // Deposit money into accounts
        bank.Deposit(1001, 200.0);
        bank.Deposit(1002, 50.0);

        // Request some withdrawals
        bank.RequestWithdrawal(1001);
        bank.RequestWithdrawal(1002);
        bank.RequestWithdrawal(1003);

        // Process withdrawals
        bank.ProcessWithdrawals();

        // Display sorted accounts by balance
        Console.WriteLine("\nSorted Account Balances:");
        bank.DisplaySortedAccounts();
    }
}