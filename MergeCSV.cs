using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }

    public Student(string id, string name, int age, int marks, string grade)
    {
        ID = id;
        Name = name;
        Age = age;
        Marks = marks;
        Grade = grade;
    }

    public string ToCsvString()
    {
        return ID + "," + Name + "," + Age + "," + Marks + "," + Grade;
    }
}

class MergeCSVFiles
{
    static void Main()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";

        Dictionary<string, Student> studentDict = new Dictionary<string, Student>();

        // Read the first CSV file (students1.csv)
        try
        {
            using (StreamReader reader = new StreamReader(file1))
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
                    if (data.Length == 3)
                    {
                        string id = data[0];
                        string name = data[1];
                        int age = int.Parse(data[2]);

                        studentDict[id] = new Student(id, name, age, 0, "");
                    }
                }
            }

            // Read the second CSV file (students2.csv) and merge data based on ID
            using (StreamReader reader = new StreamReader(file2))
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
                    if (data.Length == 3)
                    {
                        string id = data[0];
                        int marks = int.Parse(data[1]);
                        string grade = data[2];

                        if (studentDict.ContainsKey(id))
                        {
                            Student student = studentDict[id];
                            student.Marks = marks;
                            student.Grade = grade;
                        }
                    }
                }
            }

            // Write the merged data to a new CSV file
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");
                foreach (var student in studentDict.Values)
                {
                    writer.WriteLine(student.ToCsvString());
                }
            }

            Console.WriteLine("Merged CSV file created: " + outputFile);
        }
        catch (IOException e)
        {
            Console.WriteLine("Error reading or writing the file: " + e.Message);
        }
    }
}