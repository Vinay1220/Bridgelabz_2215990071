using System;
using System.Collections.Generic;

class TwoSumFinder
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i }; // Return indices
            }

            numIndices[nums[i]] = i; // Store index of current number
        }

        return new int[] { -1, -1 }; // Return invalid indices if no pair is found
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        Console.WriteLine("Input Array: " + string.Join(", ", nums));
        Console.WriteLine("Target Sum: " + target);

        int[] result = TwoSumFinder.FindTwoSum(nums, target);

        if (result[0] != -1)
            Console.WriteLine(String.Format("Indices: ({0}, {1})", result[0], result[1]));
        else
            Console.WriteLine("No valid pair found.");
    }
}
