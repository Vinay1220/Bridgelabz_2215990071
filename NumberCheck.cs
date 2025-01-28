using System;

public class NumberCheck
{
    // Method to check if number is positive or negative
    public static string CheckPositiveNegative(int number)
    {
        if (number < 0)
            return "Negative";
        return "Positive";
    }

    // Method to check if number is even or odd
    public static string CheckEvenOdd(int number)
    {
        if (number % 2 == 0)
            return "Even";
        return "Odd";
    }

    // Method to compare two numbers
    public static int CompareNumbers(int num1, int num2)
    {
        if (num1 > num2)
            return 1;
        if (num1 == num2)
            return 0;
        return -1;
    }

    public static void Main()
    {
        int[] numbers = new int[5];

        // Taking user input for 5 numbers
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            string result = CheckPositiveNegative(numbers[i]);
            Console.WriteLine("Number {0} is {1}.", numbers[i], result);

            if (numbers[i] >= 0)
            {
                string evenOdd = CheckEvenOdd(numbers[i]);
                Console.WriteLine("Number {0} is {1}.", numbers[i], evenOdd);
            }
        }

        // Comparing first and last numbers
        int comparison = CompareNumbers(numbers[0], numbers[4]);
        if (comparison == 1)
            Console.WriteLine("First number is greater than last number.");
        else if (comparison == 0)
            Console.WriteLine("First number is equal to last number.");
        else
            Console.WriteLine("First number is less than last number.");
    }
}
