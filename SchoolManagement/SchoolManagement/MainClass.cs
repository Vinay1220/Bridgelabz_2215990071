using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            School school = new School("Global High School");

            while (true)
            {
                Console.WriteLine("\nSchool Management System:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Enroll Student in Course");
                Console.WriteLine("4. View Student Courses");
                Console.WriteLine("5. View Course Enrolled Students");
                Console.WriteLine("6. Remove Student");
                Console.WriteLine("7. Remove Course");
                Console.WriteLine("8. View School Details");
                Console.WriteLine("9. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student ID: ");
                        int studentId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string studentName = Console.ReadLine();

                        school.AddStudent(new Student(studentId, studentName));
                        Console.WriteLine("Student Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Course ID: ");
                        int courseId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course Name: ");
                        string courseName = Console.ReadLine();

                        school.AddCourse(new Course(courseId, courseName));
                        Console.WriteLine("Course Added Successfully.");
                        break;

                    case 3:
                        Console.Write("Enter Student ID: ");
                        int sId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Course ID: ");
                        int cId = int.Parse(Console.ReadLine());

                        school.EnrollStudentInCourse(sId, cId);
                        break;

                    case 4:
                        Console.Write("Enter Student ID: ");
                        int studId = int.Parse(Console.ReadLine());
                        school.ViewStudentCourses(studId);
                        break;

                    case 5:
                        Console.Write("Enter Course ID: ");
                        int crsId = int.Parse(Console.ReadLine());
                        school.ViewCourseStudents(crsId);
                        break;

                    case 6:
                        Console.Write("Enter Student ID to remove: ");
                        int removeStudentId = int.Parse(Console.ReadLine());
                        school.RemoveStudent(removeStudentId);
                        break;

                    case 7:
                        Console.Write("Enter Course ID to remove: ");
                        int removeCourseId = int.Parse(Console.ReadLine());
                        school.RemoveCourse(removeCourseId);
                        break;

                    case 8:
                        school.ViewSchoolDetails();
                        break;

                    case 9:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
