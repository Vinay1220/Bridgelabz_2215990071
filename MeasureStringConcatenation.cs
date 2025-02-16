using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int iterations = 100000;
        string text = "Hello";

        Console.WriteLine("Comparing performance...");

        long stringTime = MeasureStringConcatenation(text, iterations);
        long stringBuilderTime = MeasureStringBuilderConcatenation(text, iterations);

        Console.WriteLine("String concatenation time: " + stringTime + " ms");
        Console.WriteLine("StringBuilder concatenation time: " + stringBuilderTime + " ms");
    }

    static long MeasureStringConcatenation(string text, int count)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        string result = "";

        for (int i = 0; i < count; i++)
        {
            result += text; // Creates a new string each time
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static long MeasureStringBuilderConcatenation(string text, int count)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append(text); // Efficiently appends to the same buffer
        }

        string result = sb.ToString();
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}
