using System;
using System.Collections.Generic;

class ComparisionTwoSets
{
    static void Operations(List<int> list1, List<int> list2)
    {
        var union = new List<int>();
        var intersection = new List<int>();
        union.AddRange(list1);
        int n = 0;
        while(n<list2.Count)
        {
            if (!union.Contains(list2[n]))
                union.Add(list2[n]);
            else
            {
                intersection.Add(list2[n]);
            }
            n++;
        }
        Console.Write("Union : ");
        foreach (var item in union)
            Console.Write(item+" ");
        Console.WriteLine();
        Console.Write("Intersection : ");
        foreach (var item in intersection)
            Console.Write(item+" ");
    }
    static void Main(string[] args)
    {
        var list1 = new List<int>() { 1, 2, 3 };
        var list2 = new List<int>() { 3, 4, 5 };
        Operations(list1, list2);       
    }
}