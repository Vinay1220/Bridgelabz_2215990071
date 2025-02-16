using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] words = { "Hello", "World"};

        string result = ConcatenateStrings(words);
        Console.WriteLine("Concatenated String: " + result);
    }

    static string ConcatenateStrings(string[] strings)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string str in strings)
        {
            sb.Append(str);
            sb.Append(" "); // Adding space between words
        }

        if (sb.Length > 0)
        {
            sb.Length--; // Remove the last extra space
        }

        return sb.ToString();
    }
}
