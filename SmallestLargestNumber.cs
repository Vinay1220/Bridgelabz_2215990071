using System;

class SmallestLargestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int[] result = FindSmallestAndLargest(num1, num2, num3);

        // Output
        Console.WriteLine("Smallest: " + result[0] + ", Largest: " + result[1]);
    }

    static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));
        return new int[] { smallest, largest };
    }
}
