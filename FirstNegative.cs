using System;

public class FirstNegativeNumberSearch
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int firstNegative = FindFirstNegative(arr);

        if (firstNegative != int.MaxValue)
            Console.WriteLine($"First negative number found: {firstNegative}");
        else
            Console.WriteLine("No negative number found in the array.");
    }

    public static int FindFirstNegative(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num < 0)
            {
                return num; // Return the first negative number found
            }
        }
        return int.MaxValue; // If no negative number is found
    }
}
