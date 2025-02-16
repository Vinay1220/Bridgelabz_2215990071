using System;

public class RotationPointSearch
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the rotated sorted array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int rotationIndex = FindRotationPoint(arr);

        Console.WriteLine($"The smallest element is at index: {rotationIndex}");
    }

    public static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[right])
                left = mid + 1;  // Smallest element must be in the right half
            else
                right = mid;  // Smallest element is at mid or to the left
        }

        return left; // Index of the smallest element
    }
}
