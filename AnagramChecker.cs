using System;

class AnagramChecker
{
    static void Main(string[] args)
    {
        // Enter the first string
        Console.WriteLine("Enter the first string:");
        string string1 = Console.ReadLine();

        // Enter the second string
        Console.WriteLine("Enter the second string:");
        string string2 = Console.ReadLine();

        // Check if the two strings are anagrams
        if (IsAnagram(string1, string2))
        {
            Console.WriteLine("The two strings are anagrams of each other.");
        }
        else
        {
            Console.WriteLine("The two strings are not anagrams of each other.");
        }
    }

    static bool IsAnagram(string str1, string str2)
    {
        // Remove whitespace and convert to lowercase
        char[] charArray1 = str1.Replace(" ", "").ToLower().ToCharArray();
        char[] charArray2 = str2.Replace(" ", "").ToLower().ToCharArray();

        // Sort the character arrays
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        // Compare the sorted arrays
        return new string(charArray1) == new string(charArray2);
    }
}
