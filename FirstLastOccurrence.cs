using System;

public class FirstLastOccurrence
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the sorted array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the sorted elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the target value to search: ");
        int target = int.Parse(Console.ReadLine());

        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);

        if (first == -1)
            Console.WriteLine("Target not found in the array.");
        else
            Console.WriteLine($"First occurrence: {first}, Last occurrence: {last}");
    }

    public static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid; // Possible first occurrence
                right = mid - 1; // Keep searching on the left side
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    public static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid; // Possible last occurrence
                left = mid + 1; // Keep searching on the right side
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}
