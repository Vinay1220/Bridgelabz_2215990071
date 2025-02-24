using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class CacheResultAttribute : Attribute
{
    public static Dictionary<string, object> Cache = new Dictionary<string, object>();

    public static object GetCacheKey(params object[] args)
    {
        return string.Join(",", args);
    }
}

class ExpensiveComputation
{
    [CacheResult]
    public int ComputeExpensiveResult(int number)
    {
        string cacheKey = CacheResultAttribute.GetCacheKey(number);

        if (CacheResultAttribute.Cache.ContainsKey(cacheKey))
        {
            Console.WriteLine("Returning cached result.");
            return (int)CacheResultAttribute.Cache[cacheKey];
        }

        int result = number * number; // Simulate expensive computation
        CacheResultAttribute.Cache[cacheKey] = result;
        Console.WriteLine("Computing result.");
        return result;
    }
}

class Program
{
    static void Main()
    {
        ExpensiveComputation computation = new ExpensiveComputation();

        Console.WriteLine("Result: " + computation.ComputeExpensiveResult(5));
        Console.WriteLine("Result: " + computation.ComputeExpensiveResult(5)); // This should return the cached result
        Console.WriteLine("Result: " + computation.ComputeExpensiveResult(10));
    }
}