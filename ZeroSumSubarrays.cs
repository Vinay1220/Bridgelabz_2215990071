using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static List<(int, int)> FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        List<(int, int)> result = new List<(int, int)>();

        int cumulativeSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            cumulativeSum += arr[i];

            // If cumulativeSum is 0, subarray (0 to i) is a valid zero-sum subarray
            if (cumulativeSum == 0)
            {
                result.Add((0, i));
            }

            // If cumulativeSum has been seen before, it means a subarray with sum zero exists
            if (sumMap.ContainsKey(cumulativeSum))
            {
                foreach (var startIndex in sumMap[cumulativeSum])
                {
                    result.Add((startIndex + 1, i));
                }
            }

            // Store index in map
            if (!sumMap.ContainsKey(cumulativeSum))
            {
                sumMap[cumulativeSum] = new List<int>();
            }
            sumMap[cumulativeSum].Add(i);
        }

        return result;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };

        Console.WriteLine("Input Array: " + string.Join(", ", arr));

        List<(int, int)> zeroSumSubarrays = ZeroSumSubarrays.FindZeroSumSubarrays(arr);

        Console.WriteLine("Zero Sum Subarrays:");
        foreach (var subarray in zeroSumSubarrays)
        {
            Console.WriteLine(String.Format("Start: {0}, End: {1}", subarray.Item1, subarray.Item2));
        }
    }
}
