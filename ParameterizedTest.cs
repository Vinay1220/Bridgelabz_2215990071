using System;
using NUnit.Framework;

public class NumberUtils {
    public bool IsEven(int number) {
        return number % 2 == 0;
    }
}

[TestFixture]
public class NumberUtilsTests {
    private NumberUtils numUtils;

    [SetUp]
    public void Setup() {
        numUtils = new NumberUtils();
    }

    [TestCase(2, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = true)]
    [TestCase(6, ExpectedResult = true)]
    [TestCase(7, ExpectedResult = false)]
    [TestCase(9, ExpectedResult = false)]
    public bool IsEven_TestCases(int number) {
        return numUtils.IsEven(number);
    }
}
