using System;

class LeapYearChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Year must be >= 1582.");
            return;
        }

        bool isLeap = IsLeapYear(year);
        Console.WriteLine("Year " + year + (isLeap ? " is a Leap Year." : " is not a Leap Year."));
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
