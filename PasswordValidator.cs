using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class PasswordValidator {
    public bool IsValid(string password) {
        if (password.Length < 8) return false;
        if (!Regex.IsMatch(password, @"[A-Z]")) return false; // At least one uppercase letter
        if (!Regex.IsMatch(password, @"\d")) return false; // At least one digit
        return true;
    }
}

[TestFixture]
public class PasswordValidatorTests {
    private PasswordValidator validator;

    [SetUp]
    public void Setup() {
        validator = new PasswordValidator();
    }

    [Test]
    public void Password_Valid_ReturnsTrue() {
        Assert.IsTrue(validator.IsValid("StrongPass1"));
    }

    [Test]
    public void Password_TooShort_ReturnsFalse() {
        Assert.IsFalse(validator.IsValid("Short1"));
    }

    [Test]
    public void Password_MissingUppercase_ReturnsFalse() {
        Assert.IsFalse(validator.IsValid("weakpassword1"));
    }

    [Test]
    public void Password_MissingDigit_ReturnsFalse() {
        Assert.IsFalse(validator.IsValid("NoNumbersHere"));
    }

    [Test]
    public void Password_EmptyString_ReturnsFalse() {
        Assert.IsFalse(validator.IsValid(""));
    }
}
