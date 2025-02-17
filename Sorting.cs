using System;
using System.Diagnostics;

public class SortingComparison
{
    public static void Main(string[] args)
    {
        int size;
        while (true)
        {
            Console.WriteLine("Enter the size of the array or type 0 to exit:");
            size = int.Parse(Console.ReadLine());
            if (size == 0) break;

            int[] arr = GenerateRandomArray(size);

            Console.WriteLine("\nSorting Algorithms Performance:");

            // Bubble Sort
            if (size <= 10000) // Bubble sort is impractical for large datasets
            {
                int[] bubbleArr = (int[])arr.Clone();
                MeasureTime(() => BubbleSort(bubbleArr), "Bubble Sort");
            }
            else
            {
                Console.WriteLine("Bubble Sort skipped (inefficient for large data)");
            }

            // Merge Sort
            int[] mergeArr = (int[])arr.Clone();
            MeasureTime(() => MergeSort(mergeArr, 0, size - 1), "Merge Sort");

            // Quick Sort
            int[] quickArr = (int[])arr.Clone();
            MeasureTime(() => QuickSort(quickArr, 0, size - 1), "Quick Sort");
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(0, size);
        }
        return arr;
    }

    static void MeasureTime(Action sortingMethod, string methodName)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        sortingMethod();
        stopwatch.Stop();
        Console.WriteLine($"{methodName}: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;
        int[] leftArr = new int[leftSize];
        int[] rightArr = new int[rightSize];

        Array.Copy(arr, left, leftArr, 0, leftSize);
        Array.Copy(arr, mid + 1, rightArr, 0, rightSize);

        int i = 0, j = 0, k = left;
        while (i < leftSize && j < rightSize)
        {
            if (leftArr[i] <= rightArr[j])
                arr[k++] = leftArr[i++];
            else
                arr[k++] = rightArr[j++];
        }
        while (i < leftSize) arr[k++] = leftArr[i++];
        while (j < rightSize) arr[k++] = rightArr[j++];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }
        Swap(ref arr[i + 1], ref arr[high]);
        return i + 1;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
