using System;

class NumberChecker
{
    // Method to check whether the number is positive or negative
    public static bool IsPositive(int number)
    {
        return number >= 0; // Returns true if the number is positive or zero
    }

    // Method to check whether the number is even or odd
    public static string IsEven(int number)
    {
        return (number % 2 == 0) ? "even" : "odd"; // Returns "even" or "odd"
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1; // number1 is greater
        else if (number1 < number2)
            return -1; // number1 is less
        else
            return 0; // both are equal
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Array to store 5 numbers
        int[] numbers = new int[5];

        // Input for 5 numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive or negative
            if (NumberChecker.IsPositive(numbers[i]))
            {
                Console.WriteLine($"{numbers[i]} is positive and it is {NumberChecker.IsEven(numbers[i])}.");
            }
            else
            {
                Console.WriteLine($"{numbers[i]} is negative.");
            }
        }

        // Compare the first and last elements of the array
        int comparisonResult = NumberChecker.Compare(numbers[0], numbers[numbers.Length - 1]);

        // Display the comparison result
        if (comparisonResult == 1)
        {
            Console.WriteLine($"The first number {numbers[0]} is greater than the last number {numbers[numbers.Length - 1]}.");
        }
        else if (comparisonResult == -1)
        {
            Console.WriteLine($"The first number {numbers[0]} is less than the last number {numbers[numbers.Length - 1]}.");
        }
        else
        {
            Console.WriteLine($"The first number {numbers[0]} is equal to the last number {numbers[numbers.Length - 1]}.");
        }
    }
}