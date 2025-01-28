using System;

class CalendarDisplay
{
    // Method to get the name of the month
    static string GetMonthName(int month)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[month - 1];
    }

    // Method to check if a year is a leap year
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Method to get the number of days in a month
    static int GetDaysInMonth(int month, int year)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYear(year))
        {
            return 29; // February in a leap year
        }

        return daysInMonth[month - 1];
    }

    // Method to calculate the first day of the month using the Gregorian calendar formula
    static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        return (1 + x + (31 * m0) / 12) % 7; // 0 = Sunday, 1 = Monday, ..., 6 = Saturday
    }

    // Method to display the calendar
    static void DisplayCalendar(int month, int year)
    {
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        // Print the header
        Console.WriteLine("\n" + string.Format("  {0} {1}", GetMonthName(month), year).PadLeft(20));
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Print leading spaces for the first row
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        // Print the days of the month
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(string.Format("{0,3} ", day));
            if ((firstDay + day) % 7 == 0) // Move to the next line after Saturday
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }

    // Main method
    static void Main(string[] args)
    {
        // Input month and year
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        // Display the calendar
        DisplayCalendar(month, year);
    }
}
