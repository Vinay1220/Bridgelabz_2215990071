using System;

class UniversityManag
{
    public int rollNumber;   // Public: Can be accessed anywhere
    protected string name;   // Protected: Accessible in subclass
    private double CGPA;     // Private: Accessible only within the class

    // Constructor
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public method to get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to update CGPA
    public void UpdateCGPA(double newCGPA)
    {
        CGPA = newCGPA;
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", CGPA: " + CGPA);
    }
}

// Subclass demonstrating access to protected member
class PostgraduateStudent : Student
{
    private string researchTopic;

    public PostgraduateStudent(int rollNumber, string name, double CGPA, string researchTopic) 
        : base(rollNumber, name, CGPA)
    {
        this.researchTopic = researchTopic;
    }

    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber + ", Name: " + name + ", Research Topic: " + researchTopic);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Student student1 = new Student(101, "Alice", 3.8);
        student1.DisplayStudent();
        student1.UpdateCGPA(3.9);
        Console.WriteLine("Updated CGPA: " + student1.GetCGPA());

        PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Bob", 4.0, "Machine Learning");
        pgStudent.DisplayPostgraduateDetails();
    }
}
