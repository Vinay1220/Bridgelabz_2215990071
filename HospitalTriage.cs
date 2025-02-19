using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; }
    public int Severity { get; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }
}

class SeverityComparer : IComparer<Patient>
{
    public int Compare(Patient x, Patient y)
    {
        return y.Severity.CompareTo(x.Severity); // Higher severity first
    }
}

class HospitalTriage
{
    static void Main(string[] args)
    {
        PriorityQueue<Patient, Patient> triageQueue = new PriorityQueue<Patient, Patient>(new SeverityComparer());

        // Adding patients (name, severity)
        triageQueue.Enqueue(new Patient("John", 3), new Patient("John", 3));
        triageQueue.Enqueue(new Patient("Alice", 5), new Patient("Alice", 5));
        triageQueue.Enqueue(new Patient("Bob", 2), new Patient("Bob", 2));

        Console.WriteLine("Treatment Order:");
        while (triageQueue.Count > 0)
        {
            Patient patient = triageQueue.Dequeue();
            Console.WriteLine(patient.Name);
        }
    }
}