using System;
using System.Collections.Generic;

class SlidingWindowMax
{
    public static int[] FindMaxInSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0)
            return new int[0];

        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>(); // Stores indices

        for (int i = 0; i < nums.Length; i++)
        {
            // Remove elements that are out of this window
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }

            // Remove elements smaller than current element from the back
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
            {
                deque.RemoveLast();
            }

            // Add current element index
            deque.AddLast(i);

            // First k elements do not form a complete window
            if (i >= k - 1)
            {
                result.Add(nums[deque.First.Value]); // Maximum of current window
            }
        }

        return result.ToArray();
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        
        Console.WriteLine("Input Array: " + string.Join(", ", nums));
        Console.WriteLine("Window Size: " + k);

        int[] maxSlidingWindow = SlidingWindowMax.FindMaxInSlidingWindow(nums, k);

        Console.WriteLine("Sliding Window Maximums: " + string.Join(", ", maxSlidingWindow));
    }
}
