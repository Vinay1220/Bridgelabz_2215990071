using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

public class MethodExecutionTimer
{
    public static void MeasureExecutionTime(object obj)
    {
        Type type = obj.GetType();
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var method in methods)
        {
            if (method.IsSpecialName) continue;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            method.Invoke(obj, null);

            stopwatch.Stop();
            Console.WriteLine("Method " + method.Name + " executed in " + stopwatch.ElapsedMilliseconds + " ms.");
        }
    }
}

public class ExampleClass
{
    public void Method1()
    {
        System.Threading.Thread.Sleep(500);
    }

    public void Method2()
    {
        System.Threading.Thread.Sleep(300);
    }
}

class Program
{
    static void Main()
    {
        ExampleClass example = new ExampleClass();
        MethodExecutionTimer.MeasureExecutionTime(example);
    }
}