using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt"; // Change to your file path
        string wordToFind = "test"; // Change to the word you want to count

        try
        {
            int wordCount = CountWordOccurrences(filePath, wordToFind);
            Console.WriteLine("The word \"" + wordToFind + "\" appears " + wordCount + " times in the file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred: " + ex.Message);
        }
    }

    static int CountWordOccurrences(string filePath, string word)
    {
        int count = 0;
        
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string w in words)
                {
                    if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}
