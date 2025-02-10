using System;
using System.Collections.Generic;

// Abstract class Patient
abstract class Patient
{
    private int patientId;
    private string name;
    private int age;

    protected double billAmount;

    public int PatientId { get { return patientId; } }
    public string Name { get { return name; } }
    public int Age { get { return age; } }

    public Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Total Bill: $" + CalculateBill());
    }
}

// Interface for medical records
interface IMedicalRecord
{
    void AddRecord(string record);
    string ViewRecords();
}

// InPatient Class (Hospital Stay)
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyCharge;
    private List<string> medicalRecords = new List<string>();

    public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge)
        : base(patientId, name, age)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill()
    {
        billAmount = daysAdmitted * dailyCharge;
        return billAmount;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public string ViewRecords()
    {
        return "Medical Records: " + string.Join(", ", medicalRecords);
    }
}

// OutPatient Class (Consultation Only)
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;
    private List<string> medicalRecords = new List<string>();

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        billAmount = consultationFee;
        return billAmount;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public string ViewRecords()
    {
        return "Medical Records: " + string.Join(", ", medicalRecords);
    }
}

// Main Program
class Program
{
    static void ProcessPatients(List<Patient> patients)
    {
        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();
            
            // Handle medical record functionality dynamically
            IMedicalRecord medicalRecord = patient as IMedicalRecord;
            if (medicalRecord != null)
            {
                Console.WriteLine(medicalRecord.ViewRecords());
            }

            Console.WriteLine("----------------------");
        }
    }

    static void Main()
    {
        List<Patient> hospitalPatients = new List<Patient>();

        InPatient inPatient1 = new InPatient(101, "Vinay", 45, 5, 200);
        OutPatient outPatient1 = new OutPatient(102, "Boby", 30, 50);

        // Adding medical records
        inPatient1.AddRecord("Diabetes Treatment");
        outPatient1.AddRecord("Routine Checkup");

        hospitalPatients.Add(inPatient1);
        hospitalPatients.Add(outPatient1);

        ProcessPatients(hospitalPatients);
    }
}
