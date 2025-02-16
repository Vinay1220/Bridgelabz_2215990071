using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "user_input.txt"; // File to store user input

        try
        {
            // Writing user input to file
            Console.WriteLine("Enter text (type 'exit' to stop):");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    writer.WriteLine(input);
                }
            }

            // Reading from file and displaying content
            Console.WriteLine("\nContents of the file:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
