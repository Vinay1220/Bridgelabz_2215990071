using System;
using System.Collections.Generic;

class FindElementAtTarget
{
    static string Find(LinkedList<string> ls , int n)
    {
        if (ls == null)
            return "list is null";
        var head = ls.First;
        var tail = ls.First;
        for (int i = 0; i < n; i++)
        {
            tail = tail.Next;
        }
        while (tail!=null)
        {
            head = head.Next;
            tail = tail.Next;
        }
        return head.Value;
    }
    static void Main(string[] args)
    {
        var linkedList = new LinkedList<string>();
        linkedList.AddLast("A");
        linkedList.AddLast("B");
        linkedList.AddLast("C");
        linkedList.AddLast("D");
        linkedList.AddLast("E");
        int n = 2; 
        var result = Find(linkedList,n);
        Console.WriteLine(result);
    }
}