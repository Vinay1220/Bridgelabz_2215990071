using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagement
{
    public class School
    {
        public string SchoolName { get; set; }
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();

        public School(string schoolName)
        {
            SchoolName = schoolName;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            var student = students.FirstOrDefault(s => s.StudentId == studentId);
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);

            if (student != null && course != null)
            {
                student.EnrollInCourse(course);
                course.AddStudent(student);
                Console.WriteLine("Student Enrolled in Course Successfully.");
            }
            else
            {
                Console.WriteLine("Invalid Student or Course ID.");
            }
        }

        public void ViewStudentCourses(int studentId)
        {
            var student = students.FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.ViewEnrolledCourses();
            }
            else
            {
                Console.WriteLine("Student Not Found.");
            }
        }

        public void ViewCourseStudents(int courseId)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course != null)
            {
                course.ViewEnrolledStudents();
            }
            else
            {
                Console.WriteLine("Course Not Found.");
            }
        }

        public void RemoveStudent(int studentId)
        {
            var student = students.FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Student Not Found.");
            }
        }

        public void RemoveCourse(int courseId)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);
            if (course != null)
            {
                courses.Remove(course);
                Console.WriteLine("Course Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Course Not Found.");
            }
        }

        public void ViewSchoolDetails()
        {
            Console.WriteLine($"\nSchool: {SchoolName}");
            Console.WriteLine($"Total Students: {students.Count}");
            Console.WriteLine($"Total Courses: {courses.Count}");
        }
    }
}
