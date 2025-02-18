using System;
using System.Collections.Generic;

// Abstract base class for job roles
public abstract class JobRole
{
    public string RoleName { get; private set; }

    protected JobRole(string roleName)
    {
        RoleName = roleName;
    }
}

// Specific job roles
public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer() : base("Software Engineer") { }
}

public class DataScientist : JobRole
{
    public DataScientist() : base("Data Scientist") { }
}

// Generic Resume class restricted to JobRole
public class Resume<T> where T : JobRole
{
    public string CandidateName { get; private set; }
    public T JobCategory { get; private set; }
    public int ExperienceYears { get; private set; }

    public Resume(string candidateName, int experienceYears, T jobCategory)
    {
        CandidateName = candidateName;
        ExperienceYears = experienceYears;
        JobCategory = jobCategory;
    }

    public override string ToString()
    {
        return "Candidate: " + CandidateName + " | Role: " + JobCategory.RoleName + " | Experience: " + ExperienceYears + " years";
    }
}

// Resume Screening System
public class ResumeScreening<T> where T : JobRole
{
    private readonly List<Resume<T>> resumes = new List<Resume<T>>();

    public void AddResume(Resume<T> resume)
    {
        if (resume != null)
        {
            resumes.Add(resume);
        }
    }

    public void DisplayResumes()
    {
        if (resumes.Count == 0)
        {
            Console.WriteLine("No resumes available.");
            return;
        }

        foreach (var resume in resumes)
        {
            Console.WriteLine(resume);
        }
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        ResumeScreening<SoftwareEngineer> seScreening = new ResumeScreening<SoftwareEngineer>();
        ResumeScreening<DataScientist> dsScreening = new ResumeScreening<DataScientist>();

        var resume1 = new Resume<SoftwareEngineer>("Vinay Pal", 5, new SoftwareEngineer());
        var resume2 = new Resume<SoftwareEngineer>("Shivansh", 3, new SoftwareEngineer());
        var resume3 = new Resume<DataScientist>("Prashant", 4, new DataScientist());
        var resume4 = new Resume<DataScientist>("Omendra", 6, new DataScientist());

        seScreening.AddResume(resume1);
        seScreening.AddResume(resume2);
        dsScreening.AddResume(resume3);
        dsScreening.AddResume(resume4);

        Console.WriteLine("Software Engineer Resumes:");
        seScreening.DisplayResumes();

        Console.WriteLine("\nData Scientist Resumes:");
        dsScreening.DisplayResumes();
    }
}