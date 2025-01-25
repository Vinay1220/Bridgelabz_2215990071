using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find the number of digits
        int digitCount = number.ToString().Length;
        int[] digits = new int[digitCount];

        // Extract digits and store them in the array
        int index = 0;
        while (number > 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        // Display the digits in reverse orders
        Console.Write("Reversed number: ");
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
