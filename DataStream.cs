using System;
using System.IO;

class DataStream
{
    static string filePath = "student_data.bin";

    static void Main()
    {
        WriteStudentData();
        ReadStudentData();
    }

    static void WriteStudentData()
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(1); // Roll Number
                writer.Write("Alice"); // Name
                writer.Write(3.8); // GPA
                
                writer.Write(2);
                writer.Write("Bob");
                writer.Write(3.6);
            }
            Console.WriteLine("Student data written successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while writing: " + ex.Message);
        }
    }

    static void ReadStudentData()
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();
                    
                    Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", GPA: " + gpa);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred while reading: " + ex.Message);
        }
    }
}
