using System;

class YoungestTallestFriends
{
    static void Main()
    {
        // Define arrays for age and height of 3 friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Get input for age and height of the three friends
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter details for friend " + (i + 1) + ":");
            Console.Write("Enter age: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest and tallest friend
        int youngestAge = ages[0];
        double tallestHeight = heights[0];
        int youngestIndex = 0, tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestIndex = i;
            }

            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestIndex = i;
            }
        }

        // Display the youngest and tallest friends
        Console.WriteLine("The youngest friend is " + GetFriendName(youngestIndex) + " with age " + youngestAge + ".");
        Console.WriteLine("The tallest friend is " + GetFriendName(tallestIndex) + " with height " + tallestHeight + ".");
    }

    static string GetFriendName(int index)
    {
        if (index == 0) return "Amar";
        if (index == 1) return "Akbar";
        return "Anthony"; // Default case
    }
}
