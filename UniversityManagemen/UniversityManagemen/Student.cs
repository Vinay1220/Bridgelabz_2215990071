using System;
using System.Collections.Generic;

namespace UniversityManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        private List<Course> courses = new List<Course>();

        public Student(int studentId, string studentName)
        {
            StudentId = studentId;
            StudentName = studentName;
        }

        public void EnrollInCourse(Course course)
        {
            courses.Add(course);
        }

        public void ViewCourses()
        {
            Console.WriteLine($"Courses enrolled by {StudentName} (ID: {StudentId}):");
            foreach (var course in courses)
            {
                Console.WriteLine($"  - {course.CourseName} (ID: {course.CourseId})");
            }
        }
    }
}
