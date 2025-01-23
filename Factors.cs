using System;

class Factors
{
    static void Main()
    {
        // Input Number to find the factors
        Console.WriteLine("Enter the number to find its factors:");
        int number = int.Parse(Console.ReadLine());

        // Factors
        Console.WriteLine("Factors of " + number + " are:");
        
        // Loop to find and print factors
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
