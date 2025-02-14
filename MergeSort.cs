using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfDSA.Sorting
{
    public class MergeSort
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

        // Merge Sort function
        public void MergeS(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                // Recursively divide the array
                MergeS(arr, left, mid);
                MergeS(arr, mid + 1, right);

                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        // Merge function to combine two sorted halves
        public void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Create temporary arrays
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            // Copy data to temp arrays
            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[mid + 1 + j];

            // Merge the temp arrays back into arr[]
            int iLeft = 0, iRight = 0, k = left;

            while (iLeft < n1 && iRight < n2)
            {
                if (leftArr[iLeft] <= rightArr[iRight])
                {
                    arr[k] = leftArr[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = rightArr[iRight];
                    iRight++;
                }
                k++;
            }

            // Copy remaining elements of leftArr[], if any
            while (iLeft < n1)
            {
                arr[k] = leftArr[iLeft];
                iLeft++;
                k++;
            }

            // Copy remaining elements of rightArr[], if any
            while (iRight < n2)
            {
                arr[k] = rightArr[iRight];
                iRight++;
                k++;
            }
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
