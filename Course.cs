using System;

// Base class (Superclass)
public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; } // Duration in weeks

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " weeks");
    }
}

// Subclass OnlineCourse (Inherits Course)
public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayCourseDetails()
    {
        base.DisplayCourseDetails();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + (IsRecorded ? "Yes" : "No"));
    }
}

// Subclass PaidOnlineCourse (Inherits OnlineCourse)
public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; } // Discount percentage

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayCourseDetails()
    {
        base.DisplayCourseDetails();
        Console.WriteLine("Course Fee: $" + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Final Price: $" + (Fee - (Fee * Discount / 100)));
    }
}

// Main class to test multilevel inheritance
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== General Course Details ===");
        Course course = new Course("Introduction to Programming", 8);
        course.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("=== Online Course Details ===");
        OnlineCourse onlineCourse = new OnlineCourse("Web Development", 10, "Udemy", true);
        onlineCourse.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("=== Paid Online Course Details ===");
        PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Advanced AI", 12, "Coursera", false, 500, 20);
        paidOnlineCourse.DisplayCourseDetails();
    }
}
