using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
    public void LogExecutionTime(Action method)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        method();

        stopwatch.Stop();
        Console.WriteLine("Execution Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}

class PerformanceTracker
{
    [LogExecutionTime]
    public void MethodOne()
    {
        for (int i = 0; i < 1000000; i++) ;
    }

    [LogExecutionTime]
    public void MethodTwo()
    {
        for (int i = 0; i < 5000000; i++) ;
    }
}

class Program
{
    static void Main()
    {
        PerformanceTracker tracker = new PerformanceTracker();

        MethodInfo[] methods = typeof(PerformanceTracker).GetMethods();
        foreach (MethodInfo method in methods)
        {
            if (method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) != null)
            {
                LogExecutionTimeAttribute logExecutionTime = new LogExecutionTimeAttribute();
                logExecutionTime.LogExecutionTime(() => method.Invoke(tracker, null));
            }
        }
    }
}