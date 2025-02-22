using System;
using NUnit.Framework;

public class StringUtils {
    public string Reverse(string str) {
        if (str == null) return null;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public bool IsPalindrome(string str) {
        if (str == null) return false;
        string reversed = Reverse(str);
        return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str) {
        return str?.ToUpper();
    }
}

[TestFixture] 
public class StringUtilsTests {
    private StringUtils utils;

    [SetUp]
    public void Setup() {
        utils = new StringUtils();
    }

    [Test]
    public void Reverse_ValidString_ReturnsReversedString() {
        Assert.AreEqual("olleH", utils.Reverse("Hello"));
    }

    [Test]
    public void Reverse_EmptyString_ReturnsEmptyString() {
        Assert.AreEqual("", utils.Reverse(""));
    }

    [Test]
    public void Reverse_NullString_ReturnsNull() {
        Assert.IsNull(utils.Reverse(null));
    }

    [Test]
    public void IsPalindrome_PalindromeString_ReturnsTrue() {
        Assert.IsTrue(utils.IsPalindrome("madam"));
    }

    [Test]
    public void IsPalindrome_NonPalindromeString_ReturnsFalse() {
        Assert.IsFalse(utils.IsPalindrome("hello"));
    }

    [Test]
    public void IsPalindrome_CaseInsensitivePalindrome_ReturnsTrue() {
        Assert.IsTrue(utils.IsPalindrome("MadAm"));
    }

    [Test]
    public void IsPalindrome_NullString_ReturnsFalse() {
        Assert.IsFalse(utils.IsPalindrome(null));
    }

    [Test]
    public void ToUpperCase_ValidString_ReturnsUppercase() {
        Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
    }

    [Test]
    public void ToUpperCase_AlreadyUppercase_ReturnsSameString() {
        Assert.AreEqual("WORLD", utils.ToUpperCase("WORLD"));
    }

    [Test]
    public void ToUpperCase_EmptyString_ReturnsEmptyString() {
        Assert.AreEqual("", utils.ToUpperCase(""));
    }

    [Test]
    public void ToUpperCase_NullString_ReturnsNull() {
        Assert.IsNull(utils.ToUpperCase(null));
    }
}
