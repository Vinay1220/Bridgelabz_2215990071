using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyManagement
{
    public class Company
    {
        public string CompanyName { get; set; }
        private List<Department> departments = new List<Department>();

        public Company(string companyName)
        {
            CompanyName = companyName;
        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public void RemoveDepartment(int departmentId)
        {
            var department = departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                departments.Remove(department);
                Console.WriteLine("Department Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Department Not Found.");
            }
        }

        public void AddEmployeeToDepartment(int departmentId, Employee employee)
        {
            var department = departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                department.AddEmployee(employee);
                Console.WriteLine("Employee Added Successfully.");
            }
            else
            {
                Console.WriteLine("Department Not Found.");
            }
        }

        public void RemoveEmployee(int departmentId, int employeeId)
        {
            var department = departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                department.RemoveEmployee(employeeId);
            }
            else
            {
                Console.WriteLine("Department Not Found.");
            }
        }

        public void ViewCompanyDetails()
        {
            Console.WriteLine($"\nCompany: {CompanyName}");
            if (departments.Count == 0)
            {
                Console.WriteLine("No Departments Available.");
                return;
            }

            foreach (var department in departments)
            {
                department.ViewDepartmentDetails();
            }
        }

        public void DeleteCompany()
        {
            departments.Clear();
        }
    }
}
