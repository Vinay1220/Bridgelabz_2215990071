using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    public static int FindLongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // Check if num is the start of a sequence (num - 1 is missing)
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Count the length of the sequence
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        
        Console.WriteLine("Input Array: " + string.Join(", ", nums));

        int longestSequence = LongestConsecutiveSequence.FindLongestConsecutive(nums);

        Console.WriteLine(String.Format("Longest Consecutive Sequence Length: {0}", longestSequence));
    }
}
