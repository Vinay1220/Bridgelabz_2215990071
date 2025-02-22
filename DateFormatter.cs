using System;
using System.Globalization;
using NUnit.Framework;

public class DateFormatter {
    public string FormatDate(string inputDate) {
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", 
                                   CultureInfo.InvariantCulture, 
                                   DateTimeStyles.None, out DateTime date)) {
            return date.ToString("dd-MM-yyyy");
        }
        throw new ArgumentException("Invalid date format. Expected format: yyyy-MM-dd");
    }
}

[TestFixture]
public class DateFormatterTests {
    private DateFormatter formatter;

    [SetUp]
    public void Setup() {
        formatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidDate_ReturnsFormattedDate() {
        Assert.AreEqual("05-07-2023", formatter.FormatDate("2023-07-05"));
        Assert.AreEqual("01-01-2000", formatter.FormatDate("2000-01-01"));
    }

    [Test]
    public void FormatDate_InvalidDateFormat_ThrowsException() {
        Assert.Throws<ArgumentException>(() => formatter.FormatDate("07-05-2023"));
        Assert.Throws<ArgumentException>(() => formatter.FormatDate("05/07/2023"));
        Assert.Throws<ArgumentException>(() => formatter.FormatDate("July 5, 2023"));
    }

    [Test]
    public void FormatDate_EmptyString_ThrowsException() {
        Assert.Throws<ArgumentException>(() => formatter.FormatDate(""));
    }

    [Test]
    public void FormatDate_NullInput_ThrowsException() {
        Assert.Throws<ArgumentException>(() => formatter.FormatDate(null));
    }
}
