using System;
using System.Collections.Generic;

namespace UniversityManagement
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            University university = new University("Tech University");

            while (true)
            {
                Console.WriteLine("\nUniversity Management System:");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Add Faculty Member");
                Console.WriteLine("3. Assign Faculty to Department");
                Console.WriteLine("4. View Departments");
                Console.WriteLine("5. View Faculty Members");
                Console.WriteLine("6. View Faculty in a Department");
                Console.WriteLine("7. Remove Department");
                Console.WriteLine("8. Remove Faculty Member");
                Console.WriteLine("9. Delete University (Deletes All Departments)");
                Console.WriteLine("10. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Department ID: ");
                        int deptId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Department Name: ");
                        string deptName = Console.ReadLine();
                        university.AddDepartment(new Department(deptId, deptName));
                        Console.WriteLine("Department Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Faculty ID: ");
                        int facultyId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Faculty Name: ");
                        string facultyName = Console.ReadLine();
                        university.AddFaculty(new Faculty(facultyId, facultyName));
                        Console.WriteLine("Faculty Member Added Successfully.");
                        break;

                    case 3:
                        Console.Write("Enter Faculty ID: ");
                        int fId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Department ID: ");
                        int dId = int.Parse(Console.ReadLine());
                        university.AssignFacultyToDepartment(fId, dId);
                        break;

                    case 4:
                        university.ViewDepartments();
                        break;

                    case 5:
                        university.ViewFaculty();
                        break;

                    case 6:
                        Console.Write("Enter Department ID: ");
                        int depId = int.Parse(Console.ReadLine());
                        university.ViewFacultyInDepartment(depId);
                        break;

                    case 7:
                        Console.Write("Enter Department ID to remove: ");
                        int removeDepId = int.Parse(Console.ReadLine());
                        university.RemoveDepartment(removeDepId);
                        break;

                    case 8:
                        Console.Write("Enter Faculty ID to remove: ");
                        int removeFacId = int.Parse(Console.ReadLine());
                        university.RemoveFaculty(removeFacId);
                        break;

                    case 9:
                        university.DeleteUniversity();
                        return;

                    case 10:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
