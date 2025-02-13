using System;
using System.Collections.Generic;

class StockSpanCalculator
{
    public static int[] CalculateStockSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>(); // Stack to store indices

        for (int i = 0; i < n; i++)
        {
            // Pop elements while stack is not empty and prices at stack top is ≤ current price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // If stack is empty, span is entire length from start (i+1)
            // Else, span is difference between current index and last higher price index
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

            // Push current index onto stack
            stack.Push(i);
        }

        return span;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int[] stockPrices = { 100, 80, 60, 70, 60, 75, 85 };
        
        Console.WriteLine("Stock Prices: " + string.Join(", ", stockPrices));

        int[] spans = StockSpanCalculator.CalculateStockSpan(stockPrices);

        Console.WriteLine("Stock Spans:  " + string.Join(", ", spans));
    }
}
