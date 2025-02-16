using System;

class Program
{
    static void Main()
    {
        int[] nums = { 3, 4, -1, 1 };
        int target = 4;

        // Step 1: Sort the array
        Array.Sort(nums);

        // Step 2: Perform Binary Search
        int targetIndex = BinarySearch(nums, target);

        if (targetIndex != -1)
        {
            Console.WriteLine("Target " + target + " found at index: " + targetIndex);
        }
        else
        {
            Console.WriteLine("Target " + target + " not found.");
        }
    }

    static int BinarySearch(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid; // Target found, return index
            }
            else if (nums[mid] < target)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }
        return -1; // Target not found
    }
}
