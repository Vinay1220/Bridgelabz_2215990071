using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        private List<Student> enrolledStudents = new List<Student>();

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        public void AddStudent(Student student)
        {
            enrolledStudents.Add(student);
        }

        public void ViewEnrolledStudents()
        {
            Console.WriteLine($"Course: {CourseName}, ID: {CourseId}");
            if (enrolledStudents.Count == 0)
            {
                Console.WriteLine("  No Students Enrolled.");
                return;
            }

            Console.WriteLine("  Enrolled Students:");
            foreach (var student in enrolledStudents)
            {
                Console.WriteLine($"    - {student.Name} (ID: {student.StudentId})");
            }
        }
    }
}
