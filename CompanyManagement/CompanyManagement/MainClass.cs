using System;
using System.Collections.Generic;

namespace CompanyManagement
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Company company = new Company("Tech Solutions");

            while (true)
            {
                Console.WriteLine("\nCompany Management System:");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Add Employee to Department");
                Console.WriteLine("3. View Company Details");
                Console.WriteLine("4. Remove Department");
                Console.WriteLine("5. Remove Employee");
                Console.WriteLine("6. Delete Company");
                Console.WriteLine("7. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Department ID: ");
                        int deptId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Department Name: ");
                        string deptName = Console.ReadLine();

                        company.AddDepartment(new Department(deptId, deptName));
                        Console.WriteLine("Department Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Department ID: ");
                        int depId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee ID: ");
                        int empId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee Name: ");
                        string empName = Console.ReadLine();
                        Console.Write("Enter Employee Position: ");
                        string position = Console.ReadLine();

                        company.AddEmployeeToDepartment(depId, new Employee(empId, empName, position));
                        break;

                    case 3:
                        company.ViewCompanyDetails();
                        break;

                    case 4:
                        Console.Write("Enter Department ID to remove: ");
                        int removeDepId = int.Parse(Console.ReadLine());
                        company.RemoveDepartment(removeDepId);
                        break;

                    case 5:
                        Console.Write("Enter Department ID: ");
                        int dId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee ID to remove: ");
                        int removeEmpId = int.Parse(Console.ReadLine());

                        company.RemoveEmployee(dId, removeEmpId);
                        break;

                    case 6:
                        company.DeleteCompany();
                        Console.WriteLine("Company and all departments & employees deleted.");
                        return;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
