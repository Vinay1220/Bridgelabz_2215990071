using System;

class Multiples
{
    static void Main()
    {
        // Input Number to find its multiples below 100
        Console.WriteLine("Enter a number to find its multiples below 100:");
        int number = int.Parse(Console.ReadLine());

        // multiples of the number below 100
        Console.WriteLine("Multiples of " + number + " below 100 are:");

        // Loop from 100 down to 1 to check for multiples
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
