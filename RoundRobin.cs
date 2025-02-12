using System;

class ProcessNode
{
    public int ProcessID;
    public int BurstTime;
    public int Priority;
    public ProcessNode Next;

    public ProcessNode(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head;
    private ProcessNode tail;

    public void AddProcess(int processID, int burstTime, int priority)
    {
        ProcessNode newProcess = new ProcessNode(processID, burstTime, priority);
        if (head == null)
        {
            head = tail = newProcess;
            tail.Next = head;
        }
        else
        {
            tail.Next = newProcess;
            newProcess.Next = head;
            tail = newProcess;
        }
    }

    public void RemoveProcess(int processID)
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        ProcessNode temp = head;
        ProcessNode prev = null;

        do
        {
            if (temp.ProcessID == processID)
            {
                if (temp == head && temp == tail)
                {
                    head = tail = null;
                }
                else if (temp == head)
                {
                    head = head.Next;
                    tail.Next = head;
                }
                else if (temp == tail)
                {
                    prev.Next = head;
                    tail = prev;
                }
                else
                {
                    prev.Next = temp.Next;
                }

                Console.WriteLine("Process " + processID + " has been removed.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Process not found.");
    }

    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in the queue.");
            return;
        }

        ProcessNode temp = head;
        do
        {
            Console.WriteLine("Process ID: " + temp.ProcessID + ", Burst Time: " + temp.BurstTime + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }

    public void ExecuteProcesses(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes to execute.");
            return;
        }

        int totalTime = 0;
        int waitingTimeSum = 0;
        int turnAroundTimeSum = 0;
        int processCount = 0;

        ProcessNode temp = head;
        do
        {
            processCount++;
            temp = temp.Next;
        } while (temp != head);

        while (head != null)
        {
            ProcessNode current = head;
            int executedProcesses = 0;
            do
            {
                if (current.BurstTime > 0)
                {
                    int executedTime = Math.Min(current.BurstTime, timeQuantum);
                    current.BurstTime -= executedTime;
                    totalTime += executedTime;

                    if (current.BurstTime == 0)
                    {
                        turnAroundTimeSum += totalTime;
                        waitingTimeSum += totalTime - executedTime;
                        RemoveProcess(current.ProcessID);
                    }
                    executedProcesses++;
                }
                current = current.Next;
            } while (current != head && executedProcesses > 0);

            DisplayProcesses();
        }

        Console.WriteLine("Average Waiting Time: " + (double)waitingTimeSum / processCount);
        Console.WriteLine("Average Turnaround Time: " + (double)turnAroundTimeSum / processCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nRound Robin Scheduling Menu:");
            Console.WriteLine("1 - Add Process");
            Console.WriteLine("2 - Remove Process");
            Console.WriteLine("3 - Display Processes");
            Console.WriteLine("4 - Execute Processes");
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
                    Console.Write("Enter Process ID: ");
                    int processID = int.Parse(Console.ReadLine());
                    Console.Write("Enter Burst Time: ");
                    int burstTime = int.Parse(Console.ReadLine());
                    Console.Write("Enter Priority: ");
                    int priority = int.Parse(Console.ReadLine());
                    scheduler.AddProcess(processID, burstTime, priority);
                    break;

                case 2:
                    Console.Write("Enter Process ID to Remove: ");
                    int removeID = int.Parse(Console.ReadLine());
                    scheduler.RemoveProcess(removeID);
                    break;

                case 3:
                    scheduler.DisplayProcesses();
                    break;

                case 4:
                    Console.Write("Enter Time Quantum: ");
                    int timeQuantum = int.Parse(Console.ReadLine());
                    scheduler.ExecuteProcesses(timeQuantum);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
