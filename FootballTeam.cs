using System;

class FootballTeam
{
    // Method to generate random heights for players
    public int[] GenerateRandomHeights(int size)
    {
        Random random = new Random();
        int[] heights = new int[size];

        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(150, 251); // Generate random height between 150 and 250 cm
        }

        return heights; // Return the array of heights
    }

    // Method to find the sum of all elements in the array
    public int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height; // Accumulate the sum
        }
        return sum; // Return the total sum
    }

    // Method to find the mean height of the players
    public double FindMeanHeight(int[] heights)
    {
        int sum = FindSum(heights); // Get the sum of heights
        return (double)sum / heights.Length; // Calculate and return the mean
    }

    // Method to find the shortest height of the players
    public int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0]; // Assume the first height is the shortest
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height; // Update shortest if a smaller height is found
            }
        }
        return shortest; // Return the shortest height
    }

    // Method to find the tallest height of the players
    public int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0]; // Assume the first height is the tallest
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height; // Update tallest if a larger height is found
            }
        }
        return tallest; // Return the tallest height
    }
}

class Program
{
    static void Main(string[] args)
    {
        FootballTeam team = new FootballTeam();

        // Create an array of heights for 11 players
        int[] heights = team.GenerateRandomHeights(11);

        // Display the generated heights
        Console.WriteLine("Heights of the players (in cm):");
        foreach (int height in heights)
        {
            Console.WriteLine(height);
        }

        // Calculate the mean, shortest, and tallest heights
        double meanHeight = team.FindMeanHeight(heights);
        int shortestHeight = team.FindShortestHeight(heights);
        int tallestHeight = team.FindTallestHeight(heights);

        // Display the results
        Console.WriteLine($"Mean height: {meanHeight:F2} cm");
        Console.WriteLine($"Shortest height: {shortestHeight} cm");
        Console.WriteLine($"Tallest height: {tallestHeight} cm");
    }
}