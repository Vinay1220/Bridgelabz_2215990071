using System;
using System.Collections.Generic;

class RemoveDuplicate
{
    static List<int> Remove(List<int> ls)
    {
        List<int> tempLS = new List<int> ();
        foreach (int i in ls)
        {
            if(!tempLS.Contains (i))
                tempLS.Add (i);
        }
        return tempLS;
    }
    static void Main(string[] args)
    {
        var list = new List<int>() { 3, 1, 2, 2, 3, 4 };
        list = Remove(list);
        foreach (var item in list)
            Console.Write(item + " ");
    }
}