using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfDSA.Sorting
{
    internal class InsertionSort
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

        public void Insertion(int[] arr, int n)
        {
            for (int i = 1; i <n; i++)
            {
                int curr = arr[i];
                int prev = i-1;

                while (prev>=0 && arr[prev]>curr)
                {
                    arr[prev + 1] = arr[prev];
                    prev--;
                }

                arr[prev+1] = curr;


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
