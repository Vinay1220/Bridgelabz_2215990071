using System;
using System.Collections.Generic;

class RotateElements
{
    static List<int> Rotate(List<int> ls, int times)
    {
        int n = ls.Count;
        times = times % n;
        List<int> tempLS = new List<int>();
        tempLS.AddRange(ls.GetRange(times,n-times));
        tempLS.AddRange(ls.GetRange(0,times));
        return tempLS;
    }
    static void Main(string[] args)
    {
        var list = new List<int>() { 10, 20, 30, 40, 50 };
        int times = 2;
        list = Rotate(list, times);
        foreach (var item in list) 
            Console.Write(item +" ");
    }
}