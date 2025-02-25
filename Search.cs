using System;
using System.IO;
using System.Linq;

class CSVSearch
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();

        var record = File.ReadAllLines(filePath).Skip(1)
                         .Select(line => line.Split(','))
                         .FirstOrDefault(data => data.Length >= 4 && data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (record != null)
        {
            Console.WriteLine("Department: " + record[2]);
            Console.WriteLine("Salary: " + record[3]);
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}