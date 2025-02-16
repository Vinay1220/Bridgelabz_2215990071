using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt"; // Change to your file path

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
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
}
