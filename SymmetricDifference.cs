using System;
using System.Collections.Generic;

class SymmetricDifference
{
    static void Operations(List<int> list1, List<int> list2)
    {
        var symmetricDifference = new List<int>();
        int n = list1.Count,m = list2.Count;
        int i = 0;
        while (i<n)
        {
            if (!list2.Contains(list1[i]))
                symmetricDifference.Add(list1[i]);
            i++;
        }
        i = 0;
        while (i < m)
        {
            if (!list1.Contains(list2[i]))
                symmetricDifference.Add(list2[i]);
            i++;
        }
        Console.Write("Symmetric Difference : ");
        foreach (var item in symmetricDifference)
            Console.Write(item + " ");
    }
    static void Main(string[] args)
    {
        var list1 = new List<int>() { 1, 2, 3 };
        var list2 = new List<int>() { 3, 4, 5 };
        Operations(list1, list2);
    }
}