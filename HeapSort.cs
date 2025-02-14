using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfDSA.Sorting
{
    public class HeapSort
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

        // Heap Sort function
        public void HSort(int[] arr)
        {
            int n = arr.Length;

            // Step 1: Build a Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Step 2: Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Swap the root (max element) with the last element
                Swap(arr, 0, i);

                // Heapify the reduced heap
                Heapify(arr, i, 0);
            }
        }

        // Heapify function to maintain max heap property
        public void Heapify(int[] arr, int n, int i)
        {
            int largest = i;     // Assume root (i) is the largest
            int left = 2 * i + 1; // Left child
            int right = 2 * i + 2; // Right child

            // If left child is larger than root
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // If right child is larger than the largest so far
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // If largest is not root, swap and heapify the affected subtree
            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
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
