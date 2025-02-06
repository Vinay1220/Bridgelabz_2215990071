using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityManagement
{
    public class University
    {
        public string UniversityName { get; set; }
        private List<Student> students = new List<Student>();
        private List<Professor> professors = new List<Professor>();
        private List<Course> courses = new List<Course>();

        public University(string universityName)
        {
            UniversityName = universityName;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
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
                Console.WriteLine($"Student {student.StudentName} enrolled in Course {course.CourseName}.");
            }
            else
            {
                Console.WriteLine("Invalid Student or Course ID.");
            }
        }

        public void AssignProfessorToCourse(int professorId, int courseId)
        {
            var professor = professors.FirstOrDefault(p => p.ProfessorId == professorId);
            var course = courses.FirstOrDefault(c => c.CourseId == courseId);

            if (professor != null && course != null)
            {
                course.AssignProfessor(professor);
                Console.WriteLine($"Professor {professor.ProfessorName} assigned to Course {course.CourseName}.");
            }
            else
            {
                Console.WriteLine("Invalid Professor or Course ID.");
            }
        }

        public void ViewStudents()
        {
            Console.WriteLine("\nStudents in the University:");
            if (students.Count == 0)
            {
                Console.WriteLine("  No Students Available.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"  - {student.StudentName} (ID: {student.StudentId})");
            }
        }

        public void ViewProfessors()
        {
            Console.WriteLine("\nProfessors in the University:");
            if (professors.Count == 0)
            {
                Console.WriteLine("  No Professors Available.");
                return;
            }

            foreach (var professor in professors)
            {
                Console.WriteLine($"  - {professor.ProfessorName} (ID: {professor.ProfessorId})");
            }
        }

        public void ViewCourses()
        {
            Console.WriteLine("\nCourses in the University:");
            if (courses.Count == 0)
            {
                Console.WriteLine("  No Courses Available.");
                return;
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"  - {course.CourseName} (ID: {course.CourseId})");
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

        public void RemoveProfessor(int professorId)
        {
            var professor = professors.FirstOrDefault(p => p.ProfessorId == professorId);
            if (professor != null)
            {
                professors.Remove(professor);
                Console.WriteLine("Professor Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Professor Not Found.");
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
    }
}
