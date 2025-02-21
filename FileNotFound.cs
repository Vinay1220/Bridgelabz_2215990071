using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.txt";

        try
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Contents:\n" + content);
            }
            else
            {
                throw new IOException();
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
