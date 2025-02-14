using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfDSA.Sorting
{
    public class SelectionSort
    {
        public int[] TakeInput()
        {
            Console.WriteLine("Enter your array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter your Array's Elemnets");
            string[] str = Console.ReadLine().Split();

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            return arr;
        }

        public void Sort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                // Assume the first element of unsorted part is the minimum
                int minIndex = i;

                // Find the index of the minimum element in the remaining array
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                   int temp = arr[minIndex];
                   arr[minIndex] = arr[i];
                   arr[i] = temp;
                
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
