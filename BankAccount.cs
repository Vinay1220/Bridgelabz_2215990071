using System;

class BankAccount
{
    public int accountNumber;       // Public: Accessible anywhere
    protected string accountHolder; // Protected: Accessible in subclass
    private double balance;         // Private: Accessible only within the class

    // Constructor
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public method to get balance
    public double GetBalance()
    {
        return balance;
    }

    // Public method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount + ", New Balance: " + balance);
        }
    }

    // Public method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount + ", New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }
}

// Subclass demonstrating access to accountNumber and accountHolder
class SavingsAccount : BankAccount
{
    private double interestRate;

    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        this.interestRate = interestRate;
    }

    public void DisplaySavingsAccount()
    {
        Console.WriteLine("Account Number: " + accountNumber + ", Account Holder: " + accountHolder + ", Interest Rate: " + interestRate + "%");
    }
}

// Test Program
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1001, "Vinay", 5000);
        account.Deposit(1500);
        account.Withdraw(2000);
        Console.WriteLine("Final Balance: " + account.GetBalance());

        SavingsAccount savings = new SavingsAccount(1002, "Satendra", 10000, 2.5);
        savings.DisplaySavingsAccount();
    }
}
