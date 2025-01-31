using System;

class Factorial
{
    // Function to take input from the user
    static int GetInput()
    {
        Console.WriteLine("Enter a non-negative integer to calculate its factorial:");
        int number = int.Parse(Console.ReadLine());

        // Validate input to ensure it's non-negative
        while (number < 0)
        {
            Console.WriteLine("Please enter a non-negative integer:");
            number = int.Parse(Console.ReadLine());
        }

        return number;
    }

    // Recursive function to calculate the factorial
    static long CalculateFactorial(int number)
    {
        if (number == 0 || number == 1) // Base case
        {
            return 1;
        }

        return number * CalculateFactorial(number - 1); // Recursive case
    }

    // Function to display the result
    static void DisplayResult(int number, long factorial)
    {
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }

    static void Main(string[] args)
    {
        // Get input from the user
        int number = GetInput();

        // Calculate the factorial
        long result = CalculateFactorial(number);

        // Display the result
        DisplayResult(number, result);
    }
}
