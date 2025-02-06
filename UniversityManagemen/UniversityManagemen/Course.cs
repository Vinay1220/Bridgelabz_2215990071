using System;

namespace UniversityManagement
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Professor CourseProfessor { get; set; }

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        public void AssignProfessor(Professor professor)
        {
            CourseProfessor = professor;
        }

        public void ViewProfessor()
        {
            if (CourseProfessor != null)
            {
                Console.WriteLine($"Course {CourseName} is taught by Professor {CourseProfessor.ProfessorName}");
            }
            else
            {
                Console.WriteLine($"No professor assigned to Course {CourseName}");
            }
        }
    }
}
