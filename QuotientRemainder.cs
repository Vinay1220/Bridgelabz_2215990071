using System;

class QuotientRemainder
{
    static void Main()
    {
        Console.Write("Enter dividend: ");
        int dividend = int.Parse(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(dividend, divisor);

        // Output
        Console.WriteLine("Quotient: " + result[1] + ", Remainder: " + result[0]);
    }

    static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number % divisor, number / divisor };
    }
}
