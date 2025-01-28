using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // Count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        // Store the factors in the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors; // Return the array of factors
    }

    // Method to find the greatest factor of a number using the factors array
    public static int FindGreatestFactor(int[] factors)
    {
        return factors[factors.Length - 1]; // The last element is the greatest factor
    }

    // Method to find the sum of the factors using the factors array
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor; // Accumulate the sum
        }
        return sum; // Return the total sum
    }

    // Method to find the product of the factors using the factors array
    public static int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor; // Multiply to get the product
        }
        return product; // Return the total product
    }

    // Method to find the product of the cube of the factors using the factors array
    public static double ProductOfCubesOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3); // Multiply the cube of each factor
        }
        return product; // Return the product of cubes
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // Exclude the number itself
        return sum == number; // Check if the sum of proper divisors equals the number
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // Exclude the number itself
        return sum > number; // Check if the sum of proper divisors is greater than the number
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number)
    {
        int[] factors = FindFactors(number);
        int sum = SumOfFactors(factors) - number; // Exclude the number itself
        return sum < number; // Check if the sum of proper divisors is less than the number
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number)
    {
        int originalNumber = number;
        int sumOfFactorials = 0;

        // Calculate the sum of the factorial of its digits
        while (number > 0)
        {
            int digit = number % 10; // Get the last digit
            sumOfFactorials += Factorial(digit); // Add the factorial of the digit
            number /= 10; // Remove the last digit
        }

        return sumOfFactorials == originalNumber; // Check if the sum equals the original number
    }

    // Helper method to calculate factorial
    private static int Factorial(int n)
    {
        if (n == 0 || n == 1) return 1; // Base case
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i; // Calculate factorial
        }
        return result; // Return the factorial
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find factors
        int[] factors = NumberChecker.FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // Find the greatest factor
        int greatestFactor = NumberChecker.FindGreatestFactor(factors);
        Console.WriteLine("Greatest Factor: " + greatestFactor);

        // Find the sum of the factors
        int sumOfFactors = NumberChecker.SumOfFactors(factors);
        Console.WriteLine("Sum of Factors: " + sumOfFactors);

        // Find the product of the factors
        int productOfFactors = NumberChecker.ProductOfFactors(factors);
        Console.WriteLine("Product of Factors: " + productOfFactors);

        // Find the product of the cubes of the factors
        double productOfCubes = NumberChecker.ProductOfCubesOfFactors(factors);
        Console.WriteLine("Product of Cubes of Factors: " + productOfCubes);

        // Check if the number is a perfect number
        bool isPerfect = NumberChecker.IsPerfectNumber(number);
        Console.WriteLine("Is Perfect Number: " + isPerfect);

        // Check if the number is an abundant number
        bool isAbundant = NumberChecker.IsAbundantNumber(number);
        Console.WriteLine("Is Abundant Number: " + isAbundant);

        // Check if the number is a deficient number
        bool isDeficient = NumberChecker.IsDeficientNumber(number);
        Console.WriteLine("Is Deficient Number: " + isDeficient);

        // Check if the number is a strong number
        bool isStrong = NumberChecker.IsStrongNumber(number);
        Console.WriteLine("Is Strong Number: " + isStrong);
    }
}