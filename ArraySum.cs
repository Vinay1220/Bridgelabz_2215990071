using System;

class ArraySum
{
    static void Main()
    {
        // Define an array and variables to store numbers and their sum
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        // Infinite loop to take user input until a negative number or 0 is entered
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double num = double.Parse(Console.ReadLine());

            // Break the loop if input is 0 or negative or array limit is reached
            if (num <= 0 || index == 10) break;

            // Store the number in the array and increment the index
            numbers[index++] = num;
        }

        // Loop to calculate the sum of the entered numbers
        for (int i = 0; i < index; i++)
            total += numbers[i];

        // total sum
        Console.WriteLine("Sum of entered numbers: " + total);
    }
}
