namespace UniversityManagement
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }

        public Professor(int professorId, string professorName)
        {
            ProfessorId = professorId;
            ProfessorName = professorName;
        }
    }
}
