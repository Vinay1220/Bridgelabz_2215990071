using System;

class Program
{
    static void Main()
    {
        string[] sentences = {
            "The sun is shining brightly.",
            "I love programming in C#.",
            "Linear search is simple but slow.",
            "Searching for a word in a list is useful.",
            "This is an example of a search algorithm."
        };

        Console.Write("Enter the word to search for: ");
        string searchWord = Console.ReadLine();

        int index = FindSentenceContainingWord(sentences, searchWord);

        if (index != -1)
        {
            Console.WriteLine("First sentence containing \"" + searchWord + "\":");
            Console.WriteLine(sentences[index]);
        }
        else
        {
            Console.WriteLine("No sentence contains the word \"" + searchWord + "\".");
        }
    }

    static int FindSentenceContainingWord(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return i; // Return the index of the first matching sentence
            }
        }
        return -1; // Word not found in any sentence
    }
}
