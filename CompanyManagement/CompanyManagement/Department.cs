using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyManagement
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        private List<Employee> employees = new List<Employee>();

        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(int employeeId)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Employee Not Found.");
            }
        }

        public void ViewDepartmentDetails()
        {
            Console.WriteLine($"Department ID: {DepartmentId}, Name: {DepartmentName}");

            if (employees.Count == 0)
            {
                Console.WriteLine("  No Employees Available.");
                return;
            }

            Console.WriteLine("  Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"    ID: {employee.EmployeeId}, Name: {employee.Name}, Position: {employee.Position}");
            }
        }
    }
}
