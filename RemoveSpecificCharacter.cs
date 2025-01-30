using System;

class RemoveSpecificCharacter
{
    static void Main(string[] args)
    {
        // Enter a string
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Enter the character to remove
        Console.WriteLine("Enter the character to remove:");
        char charToRemove = Console.ReadLine()[0];

        // Create a new string without the specified character
        string result = "";

        foreach (char c in input)
        {
            if (c != charToRemove)
            {
                result += c;
            }
        }

        // Modified string
        Console.WriteLine("Modified String: " + result);
    }
}
