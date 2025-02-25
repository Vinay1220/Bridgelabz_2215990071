using System;
using System.IO;
using System.Linq;

class CSVSort
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var records = File.ReadAllLines(filePath).Skip(1)
                         .Select(line => line.Split(','))
                         .Where(data => data.Length >= 4 && int.TryParse(data[3], out _))
                         .OrderByDescending(data => int.Parse(data[3]))
                         .Take(5);

        foreach (var data in records)
        {
            Console.WriteLine("ID: " + data[0]);
            Console.WriteLine("Name: " + data[1]);
            Console.WriteLine("Department: " + data[2]);
            Console.WriteLine("Salary: " + data[3]);
            Console.WriteLine("----------------------");
        }
    }
}