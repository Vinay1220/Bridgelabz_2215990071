using System;

class FriendInfo
{
    // Method to find the youngest friend
    public static int FindYoungest(int[] ages)
    {
        int youngestIndex = 0; // Start with the first friend
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i; // Update the index of the youngest friend
            }
        }
        return youngestIndex; // Return the index of the youngest friend
    }

    // Method to find the tallest friend
    public static int FindTallest(double[] heights)
    {
        int tallestIndex = 0; // Start with the first friend
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i; // Update the index of the tallest friend
            }
        }
        return tallestIndex; // Return the index of the tallest friend
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Arrays to store ages and heights of the friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input for ages and heights of 3 friends
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of friend {i + 1} (Amar, Akbar, Anthony): ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter the height of friend {i + 1} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Find the youngest and tallest friends
        int youngestIndex = FriendInfo.FindYoungest(ages);
        int tallestIndex = FriendInfo.FindTallest(heights);

        // Display results
        string[] friends = { "Amar", "Akbar", "Anthony" };
        Console.WriteLine($"The youngest friend is {friends[youngestIndex]} with age {ages[youngestIndex]}.");
        Console.WriteLine($"The tallest friend is {friends[tallestIndex]} with height {heights[tallestIndex]} cm.");
    }
}