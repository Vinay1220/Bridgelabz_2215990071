using System;
using System.Collections.Generic;
using System.Diagnostics;

public class FindTargetLargeDatase
{

    public static void Main(string[] args)
    {
        int size = 0;
        while (true)
        {
            Console.WriteLine("enter the size of array or type 0 for exit");
            size = int.Parse(Console.ReadLine());
            if (size == 0)
            {
                break;
            }
            int a = int.MaxValue;
            Console.WriteLine(a);
            int minValue = 0;
            int maxValue = size;
            Random rand = new Random();
            List<int> numbers = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                numbers.Add(rand.Next(minValue, maxValue));
            }

            int[] arr = numbers.ToArray();
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("enter target");
            int target = int.Parse(Console.ReadLine());

            stopwatch.Start();
            int linearResult = LinearSearch(arr, target);
            stopwatch.Stop();

            Console.WriteLine("Linear Search: " + (linearResult != -1 ? "Found at index " + linearResult : "Not found"));
            Console.WriteLine("Linear Search time: " + stopwatch.ElapsedMilliseconds + " ms");
            stopwatch.Reset();
            Console.WriteLine("enter target for binary");
            target = int.Parse(Console.ReadLine());

            stopwatch.Start();
            //Console.WriteLine("sorting");
            Array.Sort(arr);
            int binaryResult = BinarySearch(arr, target);
            stopwatch.Stop();

            Console.WriteLine("Binary Search: " + (binaryResult != -1 ? "Found at index " + binaryResult : "Not found"));
            Console.WriteLine("Binary Search time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}