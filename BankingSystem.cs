using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException() : base("Insufficient balance!") { }
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException();
        }
        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: "+balance);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(initialBalance);

            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}
