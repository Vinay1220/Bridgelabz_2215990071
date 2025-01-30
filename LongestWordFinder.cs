using System;

class LongestWordFinder
{
    static void Main(string[] args)
    {
        //enter a sentence
        Console.WriteLine("Enter a sentence to find the longest word:");
        string sentence = Console.ReadLine();

        // Split the sentence into words
        string[] words = sentence.Split(' ');

        // Initialize variables to store the longest word and its length
        string longestWord = string.Empty;
        int maxLength = 0;

        // Loop through each word in the array
        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                longestWord = word;
                maxLength = word.Length;
            }
        }

        // longest word
        Console.WriteLine("The longest word is: " + longestWord);
    }
}
