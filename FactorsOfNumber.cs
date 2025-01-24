using System;

class FactorsOfNumber
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize the maximum size for the factors array
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Loop to find the factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                // Check if array needs resizing
                if (index == maxFactor)
                {
                    // Double the size of the factors array
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }

                // Add the factor to the array
                factors[index++] = i;
            }
        }

        // Display the factors of the number
        Console.WriteLine("Factors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + ",");
        }
    }
}
