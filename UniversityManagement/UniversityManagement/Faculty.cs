namespace UniversityManagement
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }

        public Faculty(int facultyId, string facultyName)
        {
            FacultyId = facultyId;
            FacultyName = facultyName;
        }
    }
}
