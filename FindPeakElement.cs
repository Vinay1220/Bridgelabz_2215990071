using System;

class Program
{
    static void Main()
    {
        int[] nums = { 1, 3, 20, 4, 1, 0 };
        int peakIndex = FindPeakElement(nums);

        if (peakIndex != -1)
        {
            Console.WriteLine("Peak element found at index: " + peakIndex);
            Console.WriteLine("Peak element: " + nums[peakIndex]);
        }
        else
        {
            Console.WriteLine("No peak element found.");
        }
    }

    static int FindPeakElement(int[] nums)
    {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[mid + 1])
            {
                // Peak is in the left half
                right = mid;
            }
            else
            {
                // Peak is in the right half
                left = mid + 1;
            }
        }

        return left; // The peak index
    }
}
