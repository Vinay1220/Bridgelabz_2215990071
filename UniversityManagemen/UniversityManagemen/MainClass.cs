using System;

namespace UniversityManagement
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            University university = new University("Global University");

            while (true)
            {
                Console.WriteLine("\nUniversity Management System:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Professor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Assign Professor to Course");
                Console.WriteLine("6. View Students");
                Console.WriteLine("7. View Professors");
                Console.WriteLine("8. View Courses");
                Console.WriteLine("9. Remove Student");
                Console.WriteLine("10. Remove Professor");
                Console.WriteLine("11. Remove Course");
                Console.WriteLine("12. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student ID: ");
                        int studentId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string studentName = Console.ReadLine();
                        university.AddStudent(new Student(studentId, studentName));
                        Console.WriteLine("Student Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Professor ID: ");
                        int professorId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Professor Name: ");
                        string professorName = Console.ReadLine();
                        university.AddProfessor(new Professor(professorId, professorName));
                        Console.WriteLine("Professor Added Successfully.");
                        break;

                    case 3:
                        Console.Write("Enter Course ID: ");
                        int courseId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course Name: ");
                        string courseName = Console.ReadLine();
                        university.AddCourse(new Course(courseId, courseName));
                        Console.WriteLine("Course Added Successfully.");
                        break;

                    case 4:
                        Console.Write("Enter Student ID: ");
                        int enrollStudentId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course ID: ");
                        int enrollCourseId = int.Parse(Console.ReadLine());
                        university.EnrollStudentInCourse(enrollStudentId, enrollCourseId);
                        break;

                    case 5:
                        Console.Write("Enter Professor ID: ");
                        int assignProfessorId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course ID: ");
                        int assignCourseId = int.Parse(Console.ReadLine());
                        university.AssignProfessorToCourse(assignProfessorId, assignCourseId);
                        break;

                    case 6:
                        university.ViewStudents();
                        break;

                    case 7:
                        university.ViewProfessors();
                        break;

                    case 8:
                        university.ViewCourses();
                        break;

                    case 9:
                        Console.Write("Enter Student ID to remove: ");
                        int removeStudentId = int.Parse(Console.ReadLine());
                        university.RemoveStudent(removeStudentId);
                        break;

                    case 10:
                        Console.Write("Enter Professor ID to remove: ");
                        int removeProfessorId = int.Parse(Console.ReadLine());
                        university.RemoveProfessor(removeProfessorId);
                        break;

                    case 11:
                        Console.Write("Enter Course ID to remove: ");
                        int removeCourseId = int.Parse(Console.ReadLine());
                        university.RemoveCourse(removeCourseId);
                        break;

                    case 12:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
