using System;

class ChocolateDistribution
{
    static void Main()
    {
        Console.Write("Enter the number of chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int children = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(chocolates, children);

        // Output
        Console.WriteLine("Each child gets: " + result[1] + " chocolates, Remaining chocolates: " + result[0]);
    }

    static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number % divisor, number / divisor };
    }
}
