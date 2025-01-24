using System;

class EvenOddNumber
{
    static void Main()
    {
        // Define an array to store 5 numbers
        int[] numbers = new int[5];

        // Loop to take input for 5 numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check each number for positive, negative, or zero and even/odd
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                // Check if positive number is even or odd
                Console.WriteLine(numbers[i] + " is positive and " + (numbers[i] % 2 == 0 ? "even." : "odd."));
            }
            else if (numbers[i] < 0)
                Console.WriteLine(numbers[i] + " is negative.");
            else
                Console.WriteLine("The number is zero.");
        }

        // Compare the first and last elements of the array
        if (numbers[0] > numbers[4])
            Console.WriteLine("The first number is greater than the last.");
        else if (numbers[0] < numbers[4])
            Console.WriteLine("The first number is less than the last.");
        else
            Console.WriteLine("The first and last numbers are equal.");
    }
}
