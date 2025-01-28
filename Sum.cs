using System;

class Sum
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSum(n);

        // Output
        Console.WriteLine("The sum of first " + n + " natural numbers is " + sum + ".");
    }

    static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        return sum;
    }
}
