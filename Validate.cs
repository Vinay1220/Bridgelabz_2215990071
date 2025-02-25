using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class CSVValidate
{
    static void Main()
    {
        string filePath = "contacts.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var emailPattern = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        var phonePattern = new Regex(@"^\d{10}$");

        var records = File.ReadAllLines(filePath).Skip(1)
                         .Select((line, index) =>
                         {
                             var data = line.Split(',');
                             if (data.Length >= 4)
                             {
                                 bool isValidEmail = emailPattern.IsMatch(data[2]);
                                 bool isValidPhone = phonePattern.IsMatch(data[3]);

                                 if (!isValidEmail || !isValidPhone)
                                 {
                                     return new { Line = line, IsValid = false, Error = $"Invalid Email: {isValidEmail}, Invalid Phone: {isValidPhone}" };
                                 }
                             }
                             return new { Line = line, IsValid = true, Error = string.Empty };
                         });

        foreach (var record in records)
        {
            if (!record.IsValid)
            {
                Console.WriteLine("Invalid row: " + record.Line);
                Console.WriteLine("Error: " + record.Error);
                Console.WriteLine("----------------------");
            }
        }
    }
}