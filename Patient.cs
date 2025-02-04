using System;

class Patient
{
    private static string HospitalName = "City Hospital";
    private static int totalPatients = 0;
    private readonly int PatientID;
    private string Name;
    private int Age;
    private string Ailment;

    public Patient(int PatientID, string Name, int Age, string Ailment)
    {
        this.PatientID = PatientID;
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        totalPatients++;
    }

    public void DisplayPatientDetails()
    {
        if (this is Patient)
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient ID: " + PatientID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
        }
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }
}

class Program
{
    static void Main()
    {
        Patient patient1 = new Patient(101, "Boby", 45, "Flu");
        patient1.DisplayPatientDetails();
        
        Patient.GetTotalPatients();
    }
}
