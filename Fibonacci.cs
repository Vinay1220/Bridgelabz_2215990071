using System;
using System.Diagnostics;

public class FibonacciPerformance
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter Fibonacci term (N) or type 0 to exit:");
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;

            Console.WriteLine("\nFibonacci Computation Performance:");

            if (n <= 40) // Recursive becomes infeasible for large N
            {
                MeasureTime(() => FibonacciRecursive(n), "Recursive Fibonacci (Exponential)");
            }
            else
            {
                Console.WriteLine("Recursive Fibonacci skipped (too slow for large N)");
            }

            MeasureTime(() => FibonacciIterative(n), "Iterative Fibonacci (Linear)");
        }
    }

    static void MeasureTime(Func<int> fibonacciMethod, string methodName)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int result = fibonacciMethod();
        stopwatch.Stop();
        Console.WriteLine($"{methodName}: {stopwatch.ElapsedMilliseconds} ms (Result: {result})");
    }

    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    public static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
