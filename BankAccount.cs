using System;
using NUnit.Framework;

public class BankAccount {
    private double balance;

    public BankAccount(double initialBalance = 0) {
        if (initialBalance < 0) {
            throw new ArgumentException("Initial balance cannot be negative.");
        }
        balance = initialBalance;
    }

    public void Deposit(double amount) {
        if (amount <= 0) {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        balance += amount;
    }

    public void Withdraw(double amount) {
        if (amount <= 0) {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > balance) {
            throw new InvalidOperationException("Insufficient funds.");
        }
        balance -= amount;
    }

    public double GetBalance() {
        return balance;
    }
}

[TestFixture]
public class BankAccountTests {
    private BankAccount account;

    [SetUp]
    public void Setup() {
        account = new BankAccount(100.0); // Start with an initial balance of $100
    }

    [Test]
    public void Deposit_ValidAmount_IncreasesBalance() {
        account.Deposit(50.0);
        Assert.AreEqual(150.0, account.GetBalance());
    }

    [Test]
    public void Withdraw_ValidAmount_DecreasesBalance() {
        account.Withdraw(40.0);
        Assert.AreEqual(60.0, account.GetBalance());
    }

    [Test]
    public void Withdraw_InsufficientFunds_ThrowsException() {
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(200.0));
    }

    [Test]
    public void Withdraw_NegativeAmount_ThrowsException() {
        Assert.Throws<ArgumentException>(() => account.Withdraw(-10.0));
    }

    [Test]
    public void Deposit_NegativeAmount_ThrowsException() {
        Assert.Throws<ArgumentException>(() => account.Deposit(-20.0));
    }

    [Test]
    public void InitialBalance_CannotBeNegative() {
        Assert.Throws<ArgumentException>(() => new BankAccount(-50.0));
    }
}
