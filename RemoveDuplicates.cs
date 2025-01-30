using System;

class RemoveDuplicates
{
    static void Main(string[] args)
    {
        // enter a string
        Console.WriteLine("Enter a string to remove duplicates:");
        string str = Console.ReadLine();

        // Create a new string to store unique characters
        string result = string.Empty;

        // Loop through each character in the input string
        foreach (char c in str)
        {
            // Add the character to the result if it is not already present
            if (!result.Contains(c))
            {
                result += c;
            }
        }

        // Display the modified string
        Console.WriteLine("String after removing duplicates: " + result);
    }
}