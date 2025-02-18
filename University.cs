using System;
using System.Collections.Generic;

// Abstract base class for course types
public abstract class CourseType
{
    public string TypeName { get; private set; }

    protected CourseType(string typeName)
    {
        TypeName = typeName;
    }
}

// Specific course types
public class ExamCourse : CourseType
{
    public ExamCourse() : base("Exam-Based Course") { }
}

public class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("Assignment-Based Course") { }
}

// Generic Course class restricted to CourseType
public class Course<T> where T : CourseType
{
    public string CourseName { get; private set; }
    public string Instructor { get; private set; }
    public T CourseCategory { get; private set; }

    public Course(string courseName, string instructor, T courseCategory)
    {
        CourseName = courseName;
        Instructor = instructor;
        CourseCategory = courseCategory;
    }

    public override string ToString()
    {
        return "Course: " + CourseName + " | Instructor: " + Instructor + " | Type: " + CourseCategory.TypeName;
    }
}

// Generic Course Catalog
public class CourseCatalog<T> where T : CourseType
{
    private readonly List<Course<T>> courses = new List<Course<T>>();

    public void AddCourse(Course<T> course)
    {
        if (course != null)
        {
            courses.Add(course);
        }
    }

    public void DisplayCourses()
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("No courses available.");
            return;
        }

        foreach (var course in courses)
        {
            Console.WriteLine(course);
        }
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        CourseCatalog<ExamCourse> examCourseCatalog = new CourseCatalog<ExamCourse>();
        CourseCatalog<AssignmentCourse> assignmentCourseCatalog = new CourseCatalog<AssignmentCourse>();

        var course1 = new Course<ExamCourse>("Data Structures", "Dr. Smith", new ExamCourse());
        var course2 = new Course<ExamCourse>("Algorithms", "Prof. Johnson", new ExamCourse());
        var course3 = new Course<AssignmentCourse>("Software Engineering", "Dr. White", new AssignmentCourse());
        var course4 = new Course<AssignmentCourse>("Machine Learning", "Prof. Lee", new AssignmentCourse());

        examCourseCatalog.AddCourse(course1);
        examCourseCatalog.AddCourse(course2);
        assignmentCourseCatalog.AddCourse(course3);
        assignmentCourseCatalog.AddCourse(course4);

        Console.WriteLine("Exam Courses:");
        examCourseCatalog.DisplayCourses();

        Console.WriteLine("\nAssignment Courses:");
        assignmentCourseCatalog.DisplayCourses();
    }
}