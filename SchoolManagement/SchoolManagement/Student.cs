using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        private List<Course> enrolledCourses = new List<Course>();

        public Student(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        public void EnrollInCourse(Course course)
        {
            enrolledCourses.Add(course);
        }

        public void ViewEnrolledCourses()
        {
            Console.WriteLine($"Student: {Name}, ID: {StudentId}");
            if (enrolledCourses.Count == 0)
            {
                Console.WriteLine("  No Courses Enrolled.");
                return;
            }

            Console.WriteLine("  Enrolled Courses:");
            foreach (var course in enrolledCourses)
            {
                Console.WriteLine($"    - {course.CourseName} (ID: {course.CourseId})");
            }
        }
    }
}
