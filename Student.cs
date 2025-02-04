using System;

class Student
{
    private static string UniversityName = "GLA University";
    private static int totalStudents = 0;
    private readonly int RollNumber;
    private string Name;
    private string Grade;

    public Student(int RollNumber, string Name, string Grade)
    {
        this.RollNumber = RollNumber;
        this.Name = Name;
        this.Grade = Grade;
        totalStudents++;
    }

    public void DisplayStudentDetails()
    {
        if (this is Student)
        {
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Grade: " + Grade);
        }
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student(75, "Vinay Pal", "A");
        student1.DisplayStudentDetails();
        
        Student.DisplayTotalStudents();
    }
}
