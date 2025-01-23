using System;

class CountDigits
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        while (number != 0)
        {
            number /= 10; // Remove last digit
            count++;      // Increment digit count
        }

        Console.WriteLine("The number of digits is: " + count);
    }
}
