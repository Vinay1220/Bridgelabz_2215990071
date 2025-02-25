using System;
using System.IO;

class CSVWriter
{
    static void Main()
    {
        string filePath = "employees.csv";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("ID,Name,Department,Salary");
            writer.WriteLine("201,John Doe,HR,50000");
            writer.WriteLine("202,Jane Smith,IT,60000");
            writer.WriteLine("203,Michael Brown,Finance,55000");
            writer.WriteLine("204,Emily Davis,Marketing,52000");
            writer.WriteLine("205,David Wilson,Operations,58000");
        }

        Console.WriteLine("CSV file created successfully.");
    }
} 