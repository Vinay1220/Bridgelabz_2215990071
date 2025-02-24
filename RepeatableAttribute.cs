using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class BugTracker
{
    [BugReport("Null reference exception in the user login.")]
    [BugReport("Performance issue when loading large datasets.")]
    public void ProcessData()
    {
        Console.WriteLine("Processing Data");
    }
}

class Program
{
    static void Main()
    {
        BugTracker tracker = new BugTracker();
        tracker.ProcessData();

        MethodInfo methodInfo = typeof(BugTracker).GetMethod("ProcessData");
        object[] bugReports = methodInfo.GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute bugReport in bugReports)
        {
            Console.WriteLine("Bug: " + bugReport.Description);
        }
    }
}