using System;

class NaturalNumberSumcsc 
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a natural number greater than 0.");
            return;
        }

        int sumRecursive = SumUsingRecursion(n);
        int sumFormula = n * (n + 1) / 2;

        Console.WriteLine("Sum using recursion: " + sumRecursive);
        Console.WriteLine("Sum using formula: " + sumFormula);

        Console.WriteLine("Both results match: " + (sumRecursive == sumFormula));
    }

    static int SumUsingRecursion(int n)
    {
        if (n == 1) return 1;
        return n + SumUsingRecursion(n - 1);
    }
}
