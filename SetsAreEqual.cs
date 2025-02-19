using System;
using System.Collections.Generic;

class ComparisionTwoSets
{
    static bool Compare(List<int> list1, List<int> list2)
    {
        if (list1.Count != list2.Count) 
            return false;
        int i = 0;
        while(i<list1.Count)
        {
            if (!list2.Contains(list1[i]))
                return false;
            i++;
        }
        return true;
    }
    static void Main(string[] args)
    {
        var list1 = new List<int>() { 1,2,3};
        var list2 = new List<int>() {3,2,1};
        bool result = Compare(list1,list2);
        Console.WriteLine(result);
    }
}