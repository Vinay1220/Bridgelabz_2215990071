using System;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + result);
    }

    static string RemoveDuplicates(string str)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();

        foreach (char ch in str)
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}
