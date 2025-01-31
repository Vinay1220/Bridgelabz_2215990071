using System;

class DateComparison
{
    static void Main()
    {
        // Input the first date
        Console.WriteLine("Enter the first date (yyyy-MM-dd):");
        string firstInput = Console.ReadLine();
        DateTime firstDate;

        // Input the second date
        Console.WriteLine("Enter the second date (yyyy-MM-dd):");
        string secondInput = Console.ReadLine();
        DateTime secondDate;

        // Validate both date inputs
        if (DateTime.TryParse(firstInput, out firstDate) && DateTime.TryParse(secondInput, out secondDate))
        {
            // Compare the dates using DateTime.Compare
            int comparisonResult = DateTime.Compare(firstDate, secondDate);

            // Display the result
            if (comparisonResult < 0)
            {
                Console.WriteLine("The first date is before the second date.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("The first date is the same as the second date.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter dates in yyyy-MM-dd format.");
        }
    }
}
