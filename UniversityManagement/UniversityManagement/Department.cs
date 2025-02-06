using System;
using System.Collections.Generic;

namespace UniversityManagement
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        private List<Faculty> facultyList = new List<Faculty>();

        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        public void AddFaculty(Faculty faculty)
        {
            facultyList.Add(faculty);
        }

        public void ViewFaculty()
        {
            Console.WriteLine($"Faculty in {DepartmentName} (ID: {DepartmentId}):");
            if (facultyList.Count == 0)
            {
                Console.WriteLine("  No Faculty Members Assigned.");
                return;
            }

            foreach (var faculty in facultyList)
            {
                Console.WriteLine($"  - {faculty.FacultyName} (ID: {faculty.FacultyId})");
            }
        }
    }
}
