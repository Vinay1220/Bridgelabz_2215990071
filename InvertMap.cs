using System;
using System.Collections.Generic;

class InvertMap
{
    static Dictionary<int, List<string>> Invert(Dictionary<string, int> input)
    {
        var invertedMap = new Dictionary<int, List<string>>();

        foreach (var pair in input)
        {
            if (!invertedMap.ContainsKey(pair.Value))
                invertedMap[pair.Value] = new List<string>();

            invertedMap[pair.Value].Add(pair.Key);
        }

        return invertedMap;
    }

    static void Main(string[] args)
    {
        var input = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 1 } };
        var result = Invert(input);

        foreach (var pair in result)
        {
            Console.Write(pair.Key + "=[");
            Console.Write(string.Join(", ", pair.Value));
            Console.WriteLine("]");
        }
    }
}