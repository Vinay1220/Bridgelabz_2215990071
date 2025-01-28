using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10; // Remove the last digit
            count++; // Increment the count
        }
        return count; // Return the count of digits
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number); // Get the count of digits
        int[] digits = new int[count]; // Create an array to store the digits

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10; // Extract the last digit
            number /= 10; // Remove the last digit
        }

        return digits; // Return the array of digits
    }

    // Method to find the sum of the digits of a number using the digits array
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit; // Accumulate the sum
        }
        return sum; // Return the total sum
    }

    // Method to find the sum of the squares of the digits of a number using the digits array
    public static double SumOfSquaresOfDigits(int[] digits)
    {
        double sumOfSquares = 0;
        foreach (int digit in digits)
        {
            sumOfSquares += Math.Pow(digit, 2); // Calculate the square and accumulate
        }
        return sumOfSquares; // Return the total sum of squares
    }

    // Method to check if a number is a Harshad number
    public static bool IsHarshadNumber(int number)
    {
        int[] digits = StoreDigits(number); // Store the digits
        int sum = SumOfDigits(digits); // Get the sum of the digits
        return number % sum == 0; // Check if the number is divisible by the sum of its digits
    }

    // Method to find the frequency of each digit in the number
    public static int[,] DigitFrequency(int number)
    {
        int[] digits = StoreDigits(number); // Store the digits
        int[,] frequency = new int[10, 2]; // Create a 2D array for frequency (0-9)

        // Initialize frequency array
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; // First column: digit
            frequency[i, 1] = 0; // Second column: frequency
        }

        // Count the frequency of each digit
        foreach (int digit in digits)
        {
            frequency[digit, 1]++; // Increment the frequency for the digit
        }

        return frequency; // Return the frequency array
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Count the digits
        int count = NumberChecker.CountDigits(number);
        Console.WriteLine("Count of digits: " + count);

        // Store the digits in an array
        int[] digits = NumberChecker.StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));

        // Find the sum of the digits
        int sumOfDigits = NumberChecker.SumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sumOfDigits);

        // Find the sum of the squares of the digits
        double sumOfSquares = NumberChecker.SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);

        // Check if it's a Harshad number
        bool isHarshad = NumberChecker.IsHarshadNumber(number);
        Console.WriteLine("Is Harshad number: " + isHarshad);

        // Find the frequency of each digit
        int[,] frequency = NumberChecker.DigitFrequency(number);
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < frequency.GetLength(0); i++)
        {
            if (frequency[i, 1] > 0) // Only display digits that appear in the number
            {
                Console.WriteLine("Digit " + frequency[i, 0] + ": " + frequency[i, 1]);
            }
        }
    }
}