using System;

class NumberChecker
{
    // Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false; // Numbers less than or equal to 1 are not prime
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false; // Found a divisor, not prime
        }
        return true; // No divisors found, it is prime
    }

    // Method to check if a number is a neon number
    public static bool IsNeon(int number)
    {
        int square = number * number; // Calculate the square of the number
        int sumOfDigits = 0;

        // Calculate the sum of the digits of the square
        while (square > 0)
        {
            sumOfDigits += square % 10; // Add the last digit
            square /= 10; // Remove the last digit
        }

        return sumOfDigits == number; // Check if the sum of digits equals the original number
    }

    // Method to check if a number is a spy number
    public static bool IsSpy(int number)
    {
        int sum = 0;
        int product = 1;

        // Calculate the sum and product of the digits
        while (number > 0)
        {
            int digit = number % 10; // Get the last digit
            sum += digit; // Add to sum
            product *= digit; // Multiply to product
            number /= 10; // Remove the last digit
        }

        return sum == product; // Check if sum equals product
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number; // Calculate the square of the number
        string squareStr = square.ToString();
        string numberStr = number.ToString();

        return squareStr.EndsWith(numberStr); // Check if the square ends with the original number
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7; // Check if divisible by 7 or ends with 7
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is prime
        bool isPrime = NumberChecker.IsPrime(number);
        Console.WriteLine("Is Prime: " + isPrime);

        // Check if the number is a neon number
        bool isNeon = NumberChecker.IsNeon(number);
        Console.WriteLine("Is Neon: " + isNeon);

        // Check if the number is a spy number
        bool isSpy = NumberChecker.IsSpy(number);
        Console.WriteLine("Is Spy: " + isSpy);

        // Check if the number is an automorphic number
        bool isAutomorphic = NumberChecker.IsAutomorphic(number);
        Console.WriteLine("Is Automorphic: " + isAutomorphic);

        // Check if the number is a buzz number
        bool isBuzz = NumberChecker.IsBuzz(number);
        Console.WriteLine("Is Buzz: " + isBuzz);
    }
}