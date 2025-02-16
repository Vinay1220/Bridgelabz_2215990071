using System;

class Program
{
    static void Main()
    {
        int[] nums = { 3, 4, -1, 1 };
        int missingNumber = FindFirstMissingPositive(nums);
        Console.WriteLine("First missing positive integer: " + missingNumber);
    }

    static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        // Step 1: Mark numbers outside the range [1, n] as 'n+1'
        for (int i = 0; i < n; i++)
        {
            if (nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = n + 1;
            }
        }

        // Step 2: Use negative marking to indicate presence
        for (int i = 0; i < n; i++)
        {
            int val = Math.Abs(nums[i]);
            if (val >= 1 && val <= n)
            {
                nums[val - 1] = -Math.Abs(nums[val - 1]); // Mark the index negative
            }
        }

        // Step 3: Find the first positive index
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0)
            {
                return i + 1; // The missing positive integer
            }
        }

        return n + 1; // If all numbers are present in sequence, return n+1
    }
}
