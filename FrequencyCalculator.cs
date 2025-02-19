using System;
using System.Collections.Generic;

class FrequencyCalculator
{
    static Dictionary<string,int> Calculate(List<string> list)
    {
        var dic = new Dictionary<string, int>();
        
        foreach (var item in list)
        {
            if (dic.ContainsKey(item))
            {
                dic[item]++;
            }
            else
            {
                dic.Add(item, 1);
            }
        }
        return dic;
    }
    static void Main(string[] args)
    {
        var input = new List<string> { "apple", "banana", "apple", "orange" };
        var result = Calculate(input);
        foreach (var item in result)
            Console.Write("{0}:{1}\n", item.Key, item.Value);
    }
}