using System;

class FizzBuzz
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        // Validate the input
        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        // Create a string array to store the results
        string[] results = new string[number + 1];

        // Loop to calculate FizzBuzz results
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                results[i] = "FizzBuzz";
            else if (i % 3 == 0)
                results[i] = "Fizz";
            else if (i % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = i.ToString();
        }

        // Display the results with position information
        Console.WriteLine("FizzBuzz Results:");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + results[i]);
        }
    }
}
