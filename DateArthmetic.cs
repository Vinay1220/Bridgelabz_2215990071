using System;

class DateArthmetic
{
    static void Main()
    {
        // Date input from the user
        Console.WriteLine("Enter a date (yyyy-MM-dd):");
        string input = Console.ReadLine();
        DateTime inputDate;

        // Validate the date input
        if (DateTime.TryParse(input, out inputDate))
        {
            Console.WriteLine("Original Date: " + inputDate.ToString("yyyy-MM-dd"));

            // Add 7 days
            DateTime newDate = inputDate.AddDays(7);
            Console.WriteLine("After adding 7 days: " + newDate.ToString("yyyy-MM-dd"));

            // Add 1 month
            newDate = newDate.AddMonths(1);
            Console.WriteLine("After adding 1 month: " + newDate.ToString("yyyy-MM-dd"));

            // Add 2 years
            newDate = newDate.AddYears(2);
            Console.WriteLine("After adding 2 years: " + newDate.ToString("yyyy-MM-dd"));

            // Subtract 3 weeks (3 weeks = 21 days)
            newDate = newDate.AddDays(-21);
            Console.WriteLine("After subtracting 3 weeks: " + newDate.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
        }
    }
}
