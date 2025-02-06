using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityManagement
{
    public class University
    {
        public string UniversityName { get; set; }
        private List<Department> departments = new List<Department>();
        private List<Faculty> facultyMembers = new List<Faculty>();

        public University(string universityName)
        {
            UniversityName = universityName;
        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public void AddFaculty(Faculty faculty)
        {
            facultyMembers.Add(faculty);
        }

        public void AssignFacultyToDepartment(int facultyId, int departmentId)
        {
            var faculty = facultyMembers.FirstOrDefault(f => f.FacultyId == facultyId);
            var department = departments.FirstOrDefault(d => d.DepartmentId == departmentId);

            if (faculty != null && department != null)
            {
                department.AddFaculty(faculty);
                Console.WriteLine("Faculty Assigned to Department Successfully.");
            }
            else
            {
                Console.WriteLine("Invalid Faculty or Department ID.");
            }
        }

        public void ViewDepartments()
        {
            Console.WriteLine($"\nDepartments in {UniversityName}:");
            if (departments.Count == 0)
            {
                Console.WriteLine("  No Departments Available.");
                return;
            }

            foreach (var dept in departments)
            {
                Console.WriteLine($"  - {dept.DepartmentName} (ID: {dept.DepartmentId})");
            }
        }

        public void ViewFaculty()
        {
            Console.WriteLine($"\nFaculty Members in {UniversityName}:");
            if (facultyMembers.Count == 0)
            {
                Console.WriteLine("  No Faculty Members Available.");
                return;
            }

            foreach (var fac in facultyMembers)
            {
                Console.WriteLine($"  - {fac.FacultyName} (ID: {fac.FacultyId})");
            }
        }

        public void ViewFacultyInDepartment(int departmentId)
        {
            var department = departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                department.ViewFaculty();
            }
            else
            {
                Console.WriteLine("Department Not Found.");
            }
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

        public void RemoveFaculty(int facultyId)
        {
            var faculty = facultyMembers.FirstOrDefault(f => f.FacultyId == facultyId);
            if (faculty != null)
            {
                facultyMembers.Remove(faculty);
                Console.WriteLine("Faculty Member Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Faculty Not Found.");
            }
        }

        public void DeleteUniversity()
        {
            departments.Clear();
            Console.WriteLine("University Deleted. All Departments Removed.");
        }
    }
}
