using System;

class DigitFrequency
{
    static void Main()
    {
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Array to store frequency of digits (0-9)
        int[] frequency = new int[10];

        // Calculate the frequency of each digit
        while (number > 0)
        {
            int digit = number % 10; // Extract the last digit
            frequency[digit]++;     // Increment its frequency
            number /= 10;           // Remove the last digit
        }

        // Display the digit frequencies
        Console.WriteLine("\nDigit\tFrequency");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0) // Display only non-zero frequencies
            {
                Console.WriteLine(i + "\t" + frequency[i]);
            }
        }
    }
}
