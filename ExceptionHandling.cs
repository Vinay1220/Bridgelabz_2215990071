using System;
using NUnit.Framework;

public class MathOperations {
    public int Divide(int a, int b) {
        if (b == 0) {
            throw new ArithmeticException("Cannot divide by zero.");
        }
        return a / b;
    }
}

[TestFixture]
public class MathOperationsTests {
    private MathOperations mathOps;

    [SetUp]
    public void Setup() {
        mathOps = new MathOperations();
    }

    [Test]
    public void Divide_ValidNumbers_ReturnsCorrectQuotient() {
        Assert.AreEqual(5, mathOps.Divide(10, 2));
    }

    [Test]
    public void Divide_ByZero_ThrowsArithmeticException() {
        Assert.Throws<ArithmeticException>(() => mathOps.Divide(10, 0));
    }

    [Test]
    public void Divide_NegativeNumber_ReturnsCorrectResult() {
        Assert.AreEqual(-5, mathOps.Divide(-10, 2));
    }

    [Test]
    public void Divide_ZeroDividend_ReturnsZero() {
        Assert.AreEqual(0, mathOps.Divide(0, 5));
    }
}
