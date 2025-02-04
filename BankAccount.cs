using System;

class BankAccount
{
    private static string bankName = "SBI";
    private static int totalAccounts = 0;
    
    private readonly int accountNumber;
    private string accountHolderName;
    private double balance;

    public BankAccount(int accountNumber, string accountHolderName, double initialDeposit)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.balance = initialDeposit;
        totalAccounts++;
    }

    public void DisplayAccountDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolderName);
            Console.WriteLine("Balance: " + balance);
        }
    }

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts Created: " + totalAccounts);
    }
}

class Program
{
    static void Main(String[] args)
    {
		//Console.WriteLine("Write Your accountNumber: ");
		//int accountNumber = int.Parse(Console.ReadLine());
		
		//Console.WriteLine("Write Your accountHolderName: ");
		//string accountHolderName = Console.ReadLine();
		
		//Console.WriteLine("Write Your balance: ");
		//double balance = double.Parse(Console.ReadLine());
		
        BankAccount account1 = new BankAccount(01, "Vinay Pal", 450000);
        BankAccount account2 = new BankAccount(02, "Satendra", 500000);

        account1.DisplayAccountDetails();
        Console.WriteLine();
        account2.DisplayAccountDetails();
        Console.WriteLine();

        BankAccount.GetTotalAccounts();
    }
}
