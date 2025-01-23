using System;

class Power
{
    static void Main()
    {
        // Input: Base number and power
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the power:");
        int power = int.Parse(Console.ReadLine());

        // Initialize result as 1
        int result = 1;

        // Loop to calculate the power
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        // Output
        Console.WriteLine("The result of " + number + " raised to the power " + power + " is " + result);
    }
}
