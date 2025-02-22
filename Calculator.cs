using System;
using NUnit.Framework;

public class Calculator {
    public int Add(int a, int b) {
        return a + b;
    }

    public int Subtract(int a, int b) {
        return a - b;
    }

    public int Multiply(int a, int b) {
        return a * b;
    }

    public double Divide(int a, int b) {
        if (b == 0) {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return (double)a / b;
    }
}

[TestFixture]
public class CalculatorTests {
    private Calculator calc;

    [SetUp]
    public void Setup() {
        calc = new Calculator();
    }

    [Test]
    public void Add_TwoNumbers_ReturnsCorrectSum() {
        Assert.AreEqual(10, calc.Add(4, 6));
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference() {
        Assert.AreEqual(3, calc.Subtract(8, 5));
    }

    [Test]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct() {
        Assert.AreEqual(20, calc.Multiply(4, 5));
    }

    [Test]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient() {
        Assert.AreEqual(2.5, calc.Divide(5, 2), 0.001);
    }

    [Test]
    public void Divide_ByZero_ThrowsException() {
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }
}
