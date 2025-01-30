using System;

class MostFrequentCharacter
{
    static void Main(string[] args)
    {
        // Enter a string
        Console.WriteLine("Enter a string to find the most frequent character:");
        string input = Console.ReadLine();

        // Initialize a dictionary to store character frequencies
        int[] charCounts = new int[256];

        // Count the occurrences of each character
        foreach (char c in input)
        {
            charCounts[(int)c]++;
        }

        // Find the most frequent character
        char mostFrequentChar = ' ';
        int maxCount = 0;

        for (int i = 0; i < charCounts.Length; i++)
        {
            if (charCounts[i] > maxCount)
            {
                maxCount = charCounts[i];
                mostFrequentChar = (char)i;
            }
        }

        // Most frequent character
        Console.WriteLine("Most Frequent Character: '" + mostFrequentChar + "'");
    }
}
