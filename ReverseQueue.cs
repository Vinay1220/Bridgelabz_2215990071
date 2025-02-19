using System;
using System.Collections.Generic;

class ReverseQueue
{
    static Queue<int> Reverse(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        // Step 1: Dequeue all elements and push them onto the stack
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        // Step 2: Pop all elements from the stack and enqueue them back
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Original Queue: " + string.Join(", ", queue));

        queue = Reverse(queue);

        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
    }
}