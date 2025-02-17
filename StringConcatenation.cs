using System;
using System.Diagnostics;
using System.Text;

public class StringConcatenationPerformance
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the number of concatenations or type 0 to exit:");
            int count = int.Parse(Console.ReadLine());
            if (count == 0) break;

            Console.WriteLine("\nConcatenation Performance:");

            // String Concatenation (Inefficient)
            MeasureTime(() =>
            {
                string result = "";
                for (int i = 0; i < count; i++)
                {
                    result += "a";
                }
            }, "String (Immutable)");

            // StringBuilder Concatenation (Efficient)
            MeasureTime(() =>
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    sb.Append("a");
                }
            }, "StringBuilder (Efficient)");
        }
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
