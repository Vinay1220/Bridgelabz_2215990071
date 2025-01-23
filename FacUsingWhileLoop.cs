using System;

class FacUsingWhileLoop
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int factorial = 1;

        if (number >= 0)
        {
            int i = 1;
            while (i <= number)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine("Factorial: " + factorial);
        }
        else
        {
            Console.WriteLine("Number must be non-negative.");
        }
    }
}
