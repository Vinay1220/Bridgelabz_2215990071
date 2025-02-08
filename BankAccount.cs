using System; 
 
// Base class representing a Bank Account 
public class BankAccount 
{ 
    public int AccountNumber { get; set; } 
    public double Balance { get; set; } 
 
    public BankAccount(int accountNumber, double balance) 
    { 
        AccountNumber = accountNumber; 
        Balance = balance; 
    } 
 
    public virtual void DisplayAccountType() 
    { 
        Console.WriteLine("Generic Bank Account"); 
    } 
} 
 
// Subclass SavingsAccount 
public class SavingsAccount : BankAccount 
{ 
    public double InterestRate { get; set; } 
 
    public SavingsAccount(int accountNumber, double balance, double 
interestRate) : base(accountNumber, balance) 
    { 
        InterestRate = interestRate; 
    } 
 
    public override void DisplayAccountType() 
    { 
        Console.WriteLine("Savings Account with Interest Rate: {0}%", 
InterestRate); 
    } 
} 
 
// Subclass CheckingAccount 
public class CheckingAccount : BankAccount 
{ 
    public double WithdrawalLimit { get; set; } 
 
    public CheckingAccount(int accountNumber, double balance, double 
withdrawalLimit) : base(accountNumber, balance) 
    { 
        WithdrawalLimit = withdrawalLimit; 
    } 
 
    public override void DisplayAccountType() 
    { 
        Console.WriteLine("Checking Account with Withdrawal Limit: {0}", 
WithdrawalLimit); 
    } 
} 
 
// Subclass FixedDepositAccount 
public class FixedDepositAccount : BankAccount 
{ 
    public int DepositTerm { get; set; } 
 
    public FixedDepositAccount(int accountNumber, double balance, int 
depositTerm) : base(accountNumber, balance) 
    { 
        DepositTerm = depositTerm; 
    } 
 
    public override void DisplayAccountType() 
    { 
        Console.WriteLine("Fixed Deposit Account with Term: {0} months", 
DepositTerm); 
    } 
} 
 
// Main Program 
public class Program 
{ 
    public static void Main() 
    { 
        // Testing BankAccount hierarchy 
        BankAccount savings = new SavingsAccount(1001, 5000, 3.5); 
        BankAccount checking = new CheckingAccount(1002, 3000, 1000); 
        BankAccount fixedDeposit = new FixedDepositAccount(1003, 10000, 
12); 
         
        savings.DisplayAccountType(); 
        checking.DisplayAccountType(); 
        fixedDeposit.DisplayAccountType(); 
    } 
} 