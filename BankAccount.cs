using System;
using System.Collections.Generic;

// Abstract class BankAccount
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    protected double balance;

    public string AccountNumber { get { return accountNumber; } }
    public string HolderName { get { return holderName; } }
    public double Balance { get { return balance; } }

    public BankAccount(string accNumber, string name, double initialBalance)
    {
        accountNumber = accNumber;
        holderName = name;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine(holderName + " deposited " + amount + ". New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine(holderName + " withdrew " + amount + ". New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public abstract double CalculateInterest();

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}

// Interface for loan-related functionality
interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate;

    public SavingsAccount(string accNumber, string name, double initialBalance, double rate) 
        : base(accNumber, name, initialBalance)
    {
        interestRate = rate;
    }

    public override double CalculateInterest()
    {
        return Balance * (interestRate / 100);
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine(HolderName + " applied for a loan of " + amount);
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 2; // Loan eligibility is 2x the balance
    }
}

// Current Account
class CurrentAccount : BankAccount
{
    public CurrentAccount(string accNumber, string name, double initialBalance) 
        : base(accNumber, name, initialBalance) { }

    public override double CalculateInterest()
    {
        return 0; // No interest for current accounts
    }

    public override void Withdraw(double amount)
    {
        if (amount > 0)
        {
            balance -= amount;
            Console.WriteLine(HolderName + " withdrew " + amount + " (Overdraft allowed). New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }
}

// Main Program
class Program
{
    static void ProcessAccounts(List<BankAccount> accounts)
    {
        foreach (BankAccount account in accounts)
        {
            account.DisplayDetails();
            Console.WriteLine("Interest Earned: " + account.CalculateInterest());

            if (account is ILoanable)
            {
                ILoanable loanableAccount = (ILoanable)account;
                Console.WriteLine("Loan Eligibility: " + loanableAccount.CalculateLoanEligibility());
            }

            Console.WriteLine("----------------------");
        }
    }

    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        accounts.Add(new SavingsAccount("SA12345", "Vinay", 10000, 5));
        accounts.Add(new CurrentAccount("CA67890", "Rajesh", 5000));

        ProcessAccounts(accounts);
    }
}
