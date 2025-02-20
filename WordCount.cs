using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main()
    {
        string filePath = "textfile.txt";

        try
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = Regex.Split(line.ToLower(), "\\W+");
                    foreach (string word in words)
                    {
                        if (!string.IsNullOrWhiteSpace(word))
                        {
                            if (wordFrequency.ContainsKey(word))
                            {
                                wordFrequency[word]++;
                            }
                            else
                            {
                                wordFrequency[word] = 1;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Total Words: " + wordFrequency.Values.Sum());
            Console.WriteLine("Top 5 Most Frequent Words:");
            foreach (var item in wordFrequency.OrderByDescending(x => x.Value).Take(5))
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }
    }
}
