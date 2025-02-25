using System;
using System.IO;
using System.Linq;

class CSVUpdate
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var lines = File.ReadAllLines(inputFile);
        var updatedLines = lines.Select((line, index) =>
        {
            if (index == 0)
                return line;

            var data = line.Split(',');
            if (data.Length >= 4 && data[2].Equals("IT", StringComparison.OrdinalIgnoreCase) && int.TryParse(data[3], out int salary))
            {
                data[3] = ((int)(salary * 1.1)).ToString();
            }
            return string.Join(",", data);
        });

        File.WriteAllLines(outputFile, updatedLines);
        Console.WriteLine("Updated file saved as " + outputFile);
    }
}