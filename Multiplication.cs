using System;

class Multiplication
{
    static void Main()
    {
        // Get a number from the user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Array to store multiplication results
        int[] table = new int[10];

        // Loop to calculate and display the multiplication table
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = number * (i + 1);
            Console.WriteLine(number + " * " + (i + 1) + " = " + table[i]);
        }
    }
}
