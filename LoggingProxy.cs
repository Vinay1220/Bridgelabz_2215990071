using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello();
}

public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello, world!");
    }
}

public class LoggingProxy : System.Reflection.DispatchProxy
{
    private object _target;

    public static T Create<T>(T target)
    {
        object proxy = Create<T, LoggingProxy>();
        ((LoggingProxy)proxy)._target = target;
        return (T)proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine("Method " + targetMethod.Name + " is called.");
        return targetMethod.Invoke(_target, args);
    }
}

class Program
{
    static void Main()
    {
        IGreeting greeting = new Greeting();
        IGreeting proxy = LoggingProxy.Create(greeting);

        proxy.SayHello();
    }
}