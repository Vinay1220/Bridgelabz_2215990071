using System;

class SumOfNaturalNumberForLoop
{
    static void Main()
    {
        Console.WriteLine("Enter a natural number:");
        int n = int.Parse(Console.ReadLine());

        if (n >= 0)
        {
            int sumFormula = n * (n + 1) / 2;

            int sumLoop = 0;
            for (int i = 1; i <= n; i++)
            {
                sumLoop += i;
            }

            Console.WriteLine("Sum using formula: " + sumFormula);
            Console.WriteLine("Sum using loop: " + sumLoop);
			Console.WriteLine("Both are same");
        }
        else
        {
            Console.WriteLine("Not a natural number.");
        }
    }
}
