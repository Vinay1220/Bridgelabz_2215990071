using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public Student(string id, string name, int age, int marks)
    {
        ID = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}

class CSVToJavaObjects
{
    static void Main()
    {
        string filePath = "students.csv";
        List<Student> students = new List<Student>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isHeader = true;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] data = line.Split(',');
                    if (data.Length == 4)
                    {
                        string id = data[0];
                        string name = data[1];
                        int age = int.Parse(data[2]);
                        int marks = int.Parse(data[3]);

                        Student student = new Student(id, name, age, marks);
                        students.Add(student);
                    }
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Error reading the file: " + e.Message);
        }
    }
}