using System;
using System.Collections.Generic;

class PairSumChecker
{
    public static bool FindPairWithSum(int[] arr, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in arr)
        {
            int complement = target - num;

            if (seenNumbers.Contains(complement))
            {
                Console.WriteLine(String.Format("Pair found: ({0}, {1})", complement, num));
                return true;
            }

            seenNumbers.Add(num);
        }

        Console.WriteLine("No pair found.");
        return false;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int[] arr = { 10, 15, 3, 7 };
        int target = 17;

        Console.WriteLine("Input Array: " + string.Join(", ", arr));
        Console.WriteLine("Target Sum: " + target);

        PairSumChecker.FindPairWithSum(arr, target);
    }
}
