
﻿using System;
using System.Collections;

class Program
{
    static void Main()
    {
#pragma warning disable 0618 // Suppress warning for using non-generic ArrayList
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("Hello");
        list.Add(3.14);
#pragma warning restore 0618 // Re-enable warnings

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
