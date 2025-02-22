using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class UserRegistration {
    public bool RegisterUser(string username, string email, string password) {
        if (string.IsNullOrWhiteSpace(username) || username.Length < 5)
            throw new ArgumentException("Username must be at least 5 characters long.");
        
        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Invalid email format.");
        
        if (password.Length < 8 || 
            !Regex.IsMatch(password, @"[A-Z]") || 
            !Regex.IsMatch(password, @"\d"))
            throw new ArgumentException("Password must be at least 8 characters long, contain an uppercase letter and a number.");
        
        return true; // Simulating successful registration
    }
}

[TestFixture]
public class UserRegistrationTests {
    private UserRegistration userReg;

    [SetUp]
    public void Setup() {
        userReg = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInput_ReturnsTrue() {
        Assert.IsTrue(userReg.RegisterUser("ValidUser", "user@example.com", "StrongPass1"));
    }

    [Test]
    public void RegisterUser_ShortUsername_ThrowsException() {
        Assert.Throws<ArgumentException>(() => userReg.RegisterUser("usr", "user@example.com", "StrongPass1"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ThrowsException() {
        Assert.Throws<ArgumentException>(() => userReg.RegisterUser("ValidUser", "invalid-email", "StrongPass1"));
    }

    [Test]
    public void RegisterUser_WeakPassword_ThrowsException() {
        Assert.Throws<ArgumentException>(() => userReg.RegisterUser("ValidUser", "user@example.com", "weakpass"));
    }

    [Test]
    public void RegisterUser_PasswordWithoutNumber_ThrowsException() {
        Assert.Throws<ArgumentException>(() => userReg.RegisterUser("ValidUser", "user@example.com", "NoNumbersHere"));
    }

    [Test]
    public void RegisterUser_EmptyFields_ThrowsException() {
        Assert.Throws<ArgumentException>(() => userReg.RegisterUser("", "user@example.com", "StrongPass1"));
        Assert.Throws<ArgumentException>(() => userReg.RegisterUser("ValidUser", "", "StrongPass1"));
        Assert.Throws<ArgumentException>(() => userReg.RegisterUser("ValidUser", "user@example.com", ""));
    }
}
