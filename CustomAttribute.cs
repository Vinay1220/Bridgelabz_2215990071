using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("High", "Omendra")]
    public void CompleteTask()
    {
        Console.WriteLine("Task Completed");
    }
}

class Program
{
    static void Main()
    {
        TaskManager manager = new TaskManager();
        manager.CompleteTask();

        MethodInfo methodInfo = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute taskInfo = (TaskInfoAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(TaskInfoAttribute));

        if (taskInfo != null)
        {
            Console.WriteLine("Priority: " + taskInfo.Priority + ", Assigned To: " + taskInfo.AssignedTo);
        }
    }
}