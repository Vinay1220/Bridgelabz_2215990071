using System;

class PrimeNumber
{
    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        // Numbers less than 2 are not prime
        if (number < 2)
        {
            return false;
        }

        // Check divisors up to the square root of the number
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false; // If divisible, it's not prime
            }
        }

        return true; // If no divisors found, it's prime
    }

    static void Main(string[] args)
    {
        // Take input from the user
        Console.WriteLine("Enter a number to check if it's a prime number:");
        int number = int.Parse(Console.ReadLine());

        // Call the IsPrime function and display the result
        if (IsPrime(number))
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}
