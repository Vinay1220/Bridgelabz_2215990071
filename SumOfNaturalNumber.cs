using System;

class SumOfNaturalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a natural number:");
        int n = int.Parse(Console.ReadLine());

        if (n >= 0)
        {
            int sumFormula = n * (n + 1) / 2;

            // Compute sum using while loop
			int sumWhile = 0, i = 1;
			while (i <= n)
			{
				sumWhile += i;
				i++;
			}

            Console.WriteLine("Sum using formula: " + sumFormula);
            Console.WriteLine("Sum using WhileLoop: " + sumWhile);
			Console.WriteLine("Both are same");

        }
        else
        {
            Console.WriteLine("Not a natural number.");
        }
    }
}
