using System;

class SubstringOccurrences
{
    static void Main(string[] args)
    {
        //enter the main string
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        //enter the substring
        Console.WriteLine("Enter the substring to count occurrences:");
        string substring = Console.ReadLine();

        // Initialize the count of occurrences
        int count = 0;
        int index = 0;

        // Use a loop to find all occurrences of the substring
        while ((index = mainString.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length; // Move the index forward to avoid overlapping
        }

        //count of occurrences
        Console.WriteLine("The substring '" + substring + "' occurs " + count + " times in the given string.");
    }
}
