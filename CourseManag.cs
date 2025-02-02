using System;

class CourseManag
{
    private string courseName;
    private int duration; // In months
    private double fee;
    private static string instituteName = "ABC Institute"; // Class variable

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + courseName + ", Duration: " + duration + " months, Fee: " + fee + ", Institute: " + instituteName);
    }

    // Class method to update the institute name
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
        Console.WriteLine("Institute Name updated to: " + instituteName);
    }
}

// Test Program
class Program
{
    static void Main()
    {
        Course c1 = new Course("C# Programming", 3, 500.0);
        c1.DisplayCourseDetails();

        Course c2 = new Course("Python Programming", 4, 600.0);
        c2.DisplayCourseDetails();

        Course.UpdateInstituteName("XYZ Academy"); // Update class variable

        // Display again after update
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }
}
