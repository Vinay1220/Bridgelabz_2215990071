using System;
using System.Collections.Generic;

class RecursiveStackSorter
{
    // Function to sort a stack using recursion
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            // Pop the top element
            int top = stack.Pop();

            // Recursively sort the remaining stack
            SortStack(stack);

            // Insert the popped element in the correct position
            InsertSorted(stack, top);
        }
    }

    // Function to insert an element into the sorted stack
    private static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
        }
        else
        {
            // Pop the top element
            int temp = stack.Pop();

            // Recursively find the correct position for value
            InsertSorted(stack, value);

            // Push back the popped element
            stack.Push(temp);
        }
    }

    // Function to print the stack (Top to Bottom)
    public static void PrintStack(Stack<int> stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(30);
        stack.Push(10);
        stack.Push(50);
        stack.Push(20);
        stack.Push(40);

        Console.WriteLine("Original Stack:");
        RecursiveStackSorter.PrintStack(stack);

        RecursiveStackSorter.SortStack(stack);

        Console.WriteLine("\nSorted Stack:");
        RecursiveStackSorter.PrintStack(stack);
    }
}
