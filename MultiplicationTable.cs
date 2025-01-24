using System;

class MultiplicationTable
{
    static void Main()
    {
        // Get a number from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Array to store multiplication results
        int[] multiplicationResult = new int[4];

        // Loop to calculate the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
            Console.WriteLine(number + " * " + i + " = " + multiplicationResult[i - 6]);
        }
    }
}
