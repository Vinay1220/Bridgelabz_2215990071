using System;
using System.IO;
using System.Linq;

class CSVFilter
{
    static void Main()
    {
        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var records = File.ReadAllLines(filePath).Skip(1)
                         .Select(line => line.Split(','))
                         .Where(data => data.Length >= 4 && int.TryParse(data[3], out int marks) && marks > 80);

        foreach (var data in records)
        {
            Console.WriteLine("ID: " + data[0]);
            Console.WriteLine("Name: " + data[1]);
            Console.WriteLine("Age: " + data[2]);
            Console.WriteLine("Marks: " + data[3]);
            Console.WriteLine("----------------------");
        }
    }
}