using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        var wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        try
        {
            string text = File.ReadAllText(filePath);
            string[] words = Regex.Split(text.ToLower(), @"\W+");

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        return wordCount;
    }

    static void Main(string[] args)
    {
        string filePath = "input.txt";
        var result = CountWordFrequency(filePath);

        foreach (var item in result)
            Console.WriteLine(item.Key + ": " + item.Value);
    }
}