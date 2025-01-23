using System;

class FacUsingForLoop
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int factorial = 1;

        if (number >= 0)
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial: " + factorial);
        }
        else
        {
            Console.WriteLine("Number must be non-negative.");
        }
    }
}
