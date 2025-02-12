using System;

class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public TaskNode Next;

    public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler
{
    private TaskNode head = null;
    private TaskNode currentTask = null;

    public void AddFirst(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head;
            currentTask = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        newTask.Next = head;
        head = newTask;
        temp.Next = head;
    }

    public void AddLast(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        if (head == null)
        {
            head = newTask;
            head.Next = head;
            currentTask = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newTask;
        newTask.Next = head;
    }

    public void AddAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }

        TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
        if (position == 1)
        {
            AddFirst(taskId, taskName, priority, dueDate);
            return;
        }

        TaskNode temp = head;
        for (int i = 1; i < position - 1 && temp.Next != head; i++)
            temp = temp.Next;

        newTask.Next = temp.Next;
        temp.Next = newTask;
    }

    public void RemoveTask(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to remove.");
            return;
        }

        TaskNode temp = head, prev = null;

        if (head.TaskID == taskId)
        {
            if (head.Next == head)
            {
                head = null;
                currentTask = null;
                return;
            }

            TaskNode last = head;
            while (last.Next != head)
                last = last.Next;

            head = head.Next;
            last.Next = head;
            return;
        }

        do
        {
            prev = temp;
            temp = temp.Next;
        } while (temp != head && temp.TaskID != taskId);

        if (temp == head)
        {
            Console.WriteLine("Task ID not found!");
            return;
        }

        prev.Next = temp.Next;
    }

    public void ViewCurrentTask()
    {
        if (currentTask == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("Current Task -> ID: {0}, Name: {1}, Priority: {2}, Due Date: {3}", currentTask.TaskID, currentTask.TaskName, currentTask.Priority, currentTask.DueDate);
        currentTask = currentTask.Next;
    }

    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to display.");
            return;
        }

        TaskNode temp = head;
        do
        {
            Console.WriteLine("ID: {0}, Name: {1}, Priority: {2}, Due Date: {3}", temp.TaskID, temp.TaskName, temp.Priority, temp.DueDate);
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        TaskNode temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine("Task Found -> ID: {0}, Name: {1}, Due Date: {2}", temp.TaskID, temp.TaskName, temp.DueDate);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No tasks with the given priority.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskScheduler scheduler = new TaskScheduler();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nTask Scheduler Menu:");
            Console.WriteLine("1 - Add Task at Beginning");
            Console.WriteLine("2 - Add Task at End");
            Console.WriteLine("3 - Add Task at Position");
            Console.WriteLine("4 - Remove Task by ID");
            Console.WriteLine("5 - View Current Task and Move to Next");
            Console.WriteLine("6 - Display All Tasks");
            Console.WriteLine("7 - Search Task by Priority");
            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 0:
                    running = false;
                    break;

                case 1:
                case 2:
                case 3:
                    Console.Write("Enter Task ID: ");
                    int taskId;
                    while (!int.TryParse(Console.ReadLine(), out taskId))
                        Console.Write("Invalid input! Enter a valid Task ID: ");

                    Console.Write("Enter Task Name: ");
                    string taskName = Console.ReadLine();

                    Console.Write("Enter Priority: ");
                    int priority;
                    while (!int.TryParse(Console.ReadLine(), out priority))
                        Console.Write("Invalid input! Enter a valid Priority: ");

                    Console.Write("Enter Due Date (yyyy-MM-dd): ");
                    DateTime dueDate;
                    while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
                        Console.Write("Invalid input! Enter a valid date (yyyy-MM-dd): ");

                    if (choice == 1)
                        scheduler.AddFirst(taskId, taskName, priority, dueDate);
                    else if (choice == 2)
                        scheduler.AddLast(taskId, taskName, priority, dueDate);
                    else
                    {
                        Console.Write("Enter Position: ");
                        int position;
                        while (!int.TryParse(Console.ReadLine(), out position) || position < 1)
                            Console.Write("Invalid input! Enter a valid position: ");

                        scheduler.AddAtPosition(taskId, taskName, priority, dueDate, position);
                    }
                    break;

                case 4:
                    Console.Write("Enter Task ID to Remove: ");
                    int removeTaskId;
                    while (!int.TryParse(Console.ReadLine(), out removeTaskId))
                        Console.Write("Invalid input! Enter a valid Task ID: ");

                    scheduler.RemoveTask(removeTaskId);
                    break;

                case 5:
                    scheduler.ViewCurrentTask();
                    break;

                case 6:
                    scheduler.DisplayTasks();
                    break;

                case 7:
                    Console.Write("Enter Priority to Search: ");
                    int searchPriority;
                    while (!int.TryParse(Console.ReadLine(), out searchPriority))
                        Console.Write("Invalid input! Enter a valid Priority: ");

                    scheduler.SearchByPriority(searchPriority);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
