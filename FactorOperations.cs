using System;

class FactorOperations
{
    static void Main()
    {
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = GetFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        int sum = GetSumOfFactors(factors);
        Console.WriteLine("Sum of Factors: " + sum);

        int product = GetProductOfFactors(factors);
        Console.WriteLine("Product of Factors: " + product);

        int sumOfSquares = GetSumOfSquaresOfFactors(factors);
        Console.WriteLine("Sum of Squares of Factors: " + sumOfSquares);
    }

    static int[] GetFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }
        return factors;
    }

    static int GetSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    static int GetProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    static int GetSumOfSquaresOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += (int)Math.Pow(factor, 2);
        }
        return sum;
    }
}
