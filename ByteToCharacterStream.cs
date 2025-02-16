using System;
using System.IO;
using System.Text;

public class ByteToCharacterStream
{
    static void Main()
    {
        string filePath = "sample.txt"; // Sample file to read

        try
        {
            // Ensure the file exists before reading
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File '{filePath}' not found. Creating a sample file...");
                File.WriteAllText(filePath, "Hello, this is a sample text file!");
            }

            // Open file and read as character stream using StreamReader
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8)) // UTF-8 encoding
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }
}
