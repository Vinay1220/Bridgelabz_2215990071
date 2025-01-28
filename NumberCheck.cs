using System;

class NumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = CheckNumber(number);

        // Output
        if (result == 1) Console.WriteLine("The number is positive.");
        else if (result == -1) Console.WriteLine("The number is negative.");
        else Console.WriteLine("The number is zero.");
    }

    static int CheckNumber(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }
}
