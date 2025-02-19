using System;
using System.Collections;
using System.Collections.Generic;
class ReverseList
{
    static ArrayList ReverseArrayList(ArrayList arr)
    {
     int left = 0, right = arr.Count - 1;
            while (left < right)
            {
                int temp = (int)arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            return arr;
    }
    static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        var reverse = new LinkedList<int>();
        foreach (var item in list)
        {
            reverse.AddFirst(item);
        }
        return reverse;
    }
    

    static void Main(string[] args)
    {
        var linkedList = new LinkedList<int>();
        linkedList.AddLast(34);
        linkedList.AddLast(12);
        linkedList.AddLast(3);
        linkedList.AddLast(234);
        linkedList.AddLast(23);
        var arrayList = new ArrayList { 123, 32, 234, 32, 1, 3 };
        Console.WriteLine("Original form Linked List : ");
        foreach (var item in linkedList)
            Console.Write(item + " ");
        linkedList = ReverseLinkedList(linkedList);
        Console.WriteLine("\nreverse form Linked List : ");
        foreach (var item in linkedList)
            Console.Write(item + " ");
        Console.WriteLine("\nOriginal form Array List : ");
        foreach (var item in arrayList)
            Console.Write(item + " ");
        arrayList = ReverseArrayList(arrayList);
        Console.WriteLine("\nreverse form Array List : ");
        foreach (var item in arrayList)
            Console.Write(item+" ");
    }
}