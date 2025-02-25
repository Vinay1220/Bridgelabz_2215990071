using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class JsonCsvConverter
{
    static void Main()
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";
        string jsonFromCsvFile = "students_from_csv.json";

        ConvertJsonToCsv(jsonFilePath, csvFilePath);
        ConvertCsvToJson(csvFilePath, jsonFromCsvFile);
    }

    public static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
    {
        try
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);

            using (StreamWriter writer = new StreamWriter(csvFilePath))
            {
                writer.WriteLine("ID,Name,Age,Marks");

                foreach (var student in students)
                {
                    writer.WriteLine(student.ID + "," + student.Name + "," + student.Age + "," + student.Marks);
                }
            }

            Console.WriteLine("JSON to CSV conversion successful. Output file: " + csvFilePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error converting JSON to CSV: " + e.Message);
        }
    }

    public static void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
    {
        try
        {
            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                string header = reader.ReadLine();  // Skip header
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    Student student = new Student
                    {
                        ID = data[0],
                        Name = data[1],
                        Age = int.Parse(data[2]),
                        Marks = int.Parse(data[3])
                    };

                    students.Add(student);
                }
            }

            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);

            Console.WriteLine("CSV to JSON conversion successful. Output file: " + jsonFilePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error converting CSV to JSON: " + e.Message);
        }
    }
}