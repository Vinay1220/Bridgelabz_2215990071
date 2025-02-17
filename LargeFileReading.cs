using System;
using System.Diagnostics;
using System.IO;
using System.Text;

public class LargeFileReadingPerformance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the file path to test:");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Please provide a valid path.");
            return;
        }

        Console.WriteLine("\nFile Reading Performance:");

        // StreamReader (Character-based reading)
        MeasureTime(() =>
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.Read() != -1) { } // Read character by character
            }
        }, "StreamReader (Character-Based)");

        // FileStream (Byte-based reading)
        MeasureTime(() =>
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[4096]; // Read in 4KB chunks
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
        }, "FileStream (Byte-Based)");
    }

    static void MeasureTime(Action operation, string methodName)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        operation();
        stopwatch.Stop();
        Console.WriteLine($"{methodName}: {stopwatch.ElapsedMilliseconds} ms");
    }
}
