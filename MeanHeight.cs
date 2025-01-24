using System;

class MeanHeight
{
    static void Main()
    {
        // Define an array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0;

        // Loop to take input for each player's height
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter height of player " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i]; // Add height to the sum
        }

        // Calculate and display the mean height
        double mean = sum / heights.Length;
        Console.WriteLine("Mean height of the team: " + mean);
    }
}
