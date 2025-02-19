using System;
using System.Collections.Generic;

class BinaryNumbersGenerator
{
    static List<string> GenerateBinaryNumbers(int n)
    {
        Queue<string> queue = new Queue<string>();
        List<string> result = new List<string>();

        queue.Enqueue("1"); // Start with "1"

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            result.Add(current);

            // Generate the next binary numbers and enqueue them
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }

        return result;
    }

    static void Main(string[] args)
    {
        int n = 5; // Number of binary numbers to generate
        List<string> binaryNumbers = GenerateBinaryNumbers(n);

        Console.WriteLine("First " + n + " binary numbers: " + string.Join(", ", binaryNumbers));
    }
}