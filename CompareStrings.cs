using System;

class CompareStrings
{
    static void Main(string[] args)
    {
        // Enter the first string
        Console.WriteLine("Enter the first string:");
        string string1 = Console.ReadLine();

        // Enter the second string
        Console.WriteLine("Enter the second string:");
        string string2 = Console.ReadLine();

        // Compare the strings lexicographically
        int minLength = Math.Min(string1.Length, string2.Length);
        bool areEqual = true;

        for (int i = 0; i < minLength; i++)
        {
            if (string1[i] < string2[i])
            {
                Console.WriteLine("\"" + string1 + "\" comes before \"" + string2 + "\" in lexicographical order.");
                areEqual = false;
                break;
            }
            else if (string1[i] > string2[i])
            {
                Console.WriteLine("\"" + string1 + "\" comes after \"" + string2 + "\" in lexicographical order.");
                areEqual = false;
                break;
            }
        }

        if (areEqual)
        {
            if (string1.Length < string2.Length)
            {
                Console.WriteLine("\"" + string1 + "\" comes before \"" + string2 + "\" in lexicographical order.");
            }
            else if (string1.Length > string2.Length)
            {
                Console.WriteLine("\"" + string1 + "\" comes after \"" + string2 + "\" in lexicographical order.");
            }
            else
            {
                Console.WriteLine("\"" + string1 + "\" is equal to \"" + string2 + "\" lexicographically.");
            }
        }
    }
}
