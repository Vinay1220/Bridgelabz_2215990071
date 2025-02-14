using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfDSA.Sorting
{
    internal class QuickSort
    {

        public int[] TakeInput()
        {
            Console.WriteLine("Enter your array size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter your array's Elemengt");

            string[] str = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            return arr;
        }

        // Quick Sort function
        public void QSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort elements before and after partition
                QSort(arr, low, pivotIndex - 1);
                QSort(arr, pivotIndex + 1, high);
            }
        }

        // Partition function to place the pivot at the correct position
        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Choosing the last element as the pivot
            int i = low - 1; // Pointer for the smaller element

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot) // If element is smaller than pivot, swap it
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            // Swap the pivot to its correct position
            Swap(arr, i + 1, high);
            return i + 1;
        }

        // Swap function
        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void Display(int[] arr, int n)
        {
            Console.Write("[");
            for (int i = 0; i < n; i++)
            {

                Console.Write(arr[i] + ",");
            }
            Console.Write("]");
        }
    }
}
