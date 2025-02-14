using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfDSA.Sorting
{
    public class BubbleSort
    {
        public int[] TakeInput()
        {
            Console.WriteLine("Enter your array size:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter your array number:");
            string[] inputs = Console.ReadLine().Split(); // Reading input as a string array

            for (int i = 0; i < n; i++)
            {
                 arr[i] = int.Parse(inputs[i]); // Converting each string element to an integer
            }
            return arr;
        }

        public void Sort(int[] arr, int n)
        {

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        public void Display(int[] arr, int n)
        {
            Console.Write("[");
            for (int i = 0; i < n; i++)
            {
             
                Console.Write(arr[i]+",");
            }
            Console.Write("]");
        }

    
    }
}
