using System;

class ToggleCase
{
    static void Main(string[] args)
    {
        //Enter a string
        Console.WriteLine("Enter a string to toggle case:");
        string input = Console.ReadLine();

        // Initialize a result string
        string result = "";

        // Loop through each character in the string
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                // Convert uppercase to lowercase
                result += char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                // Convert lowercase to uppercase
                result += char.ToUpper(c);
            }
            else
            {
                // Keep non-alphabetic characters unchanged
                result += c;
            }
        }

        //Result
        Console.WriteLine("Toggled case string: " + result);
    }
}
