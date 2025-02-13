using System;
using System.Collections.Generic;

// Class implementing Queue using two stacks
class StackQueue<T>
{
    private Stack<T> enqueueStack; // Stack for enqueue operations
    private Stack<T> dequeueStack; // Stack for dequeue operations

    public StackQueue()
    {
        enqueueStack = new Stack<T>();
        dequeueStack = new Stack<T>();
    }

    // Enqueue operation: Push to enqueueStack
    public void Enqueue(T item)
    {
        enqueueStack.Push(item);
        Console.WriteLine(String.Format("Enqueued: {0}", item));
    }

    // Dequeue operation: Transfer elements if needed and pop from dequeueStack
    public T Dequeue()
    {
        if (dequeueStack.Count == 0)
        {
            if (enqueueStack.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            // Move elements from enqueueStack to dequeueStack
            while (enqueueStack.Count > 0)
            {
                dequeueStack.Push(enqueueStack.Pop());
            }
        }

        return dequeueStack.Pop();
    }

    // Peek operation: Get the front element without removing it
    public T Peek()
    {
        if (dequeueStack.Count == 0)
        {
            if (enqueueStack.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            while (enqueueStack.Count > 0)
            {
                dequeueStack.Push(enqueueStack.Pop());
            }
        }

        return dequeueStack.Peek();
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return enqueueStack.Count == 0 && dequeueStack.Count == 0;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        StackQueue<int> queue = new StackQueue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine(String.Format("Dequeued: {0}", queue.Dequeue())); // Should return 10
        Console.WriteLine(String.Format("Front Element: {0}", queue.Peek())); // Should return 20
        Console.WriteLine(String.Format("Dequeued: {0}", queue.Dequeue())); // Should return 20

        queue.Enqueue(40);
        Console.WriteLine(String.Format("Dequeued: {0}", queue.Dequeue())); // Should return 30
        Console.WriteLine(String.Format("Dequeued: {0}", queue.Dequeue())); // Should return 40

        Console.WriteLine("Queue Empty: " + queue.IsEmpty()); // Should return true
    }
}
