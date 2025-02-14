using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfDSA.Sorting
{
    public class CountingSort
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

        public void CountSort(int[] arr, int minAge, int maxAge)
        {
            int range = maxAge - minAge + 1;
            int[] count = new int[range];  // Count array
            int[] output = new int[arr.Length]; // Output array

            // Step 1: Count occurrences of each age
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - minAge]++;
            }

            // Step 2: Compute cumulative count (prefix sum)
            for (int i = 1; i < range; i++)
            {
                count[i] += count[i - 1];
            }

            // Step 3: Place elements in the correct order in the output array
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - minAge] - 1] = arr[i];
                count[arr[i] - minAge]--;
            }

            // Step 4: Copy sorted elements back to original array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
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
