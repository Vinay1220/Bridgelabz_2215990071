using System;

class FindSumUntilZero
{
    static void Main()
    {
        double total = 0;
        double number;

        do
        {
            Console.WriteLine("Enter a number (0 to stop):");
            number = double.Parse(Console.ReadLine());
            total += number;
        } while (number != 0);

        Console.WriteLine("Total sum: " + total);
    }
}
