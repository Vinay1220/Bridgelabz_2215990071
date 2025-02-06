using System;
using System.Collections.Generic;
using System.Numerics;

namespace HospitalManagement
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital("City Hospital");

            while (true)
            {
                Console.WriteLine("\nHospital Management System:");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. Assign Patient to Doctor");
                Console.WriteLine("4. View Doctors");
                Console.WriteLine("5. View Patients");
                Console.WriteLine("6. View Patients of a Doctor");
                Console.WriteLine("7. View Doctors of a Patient");
                Console.WriteLine("8. Remove Doctor");
                Console.WriteLine("9. Remove Patient");
                Console.WriteLine("10. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Doctor ID: ");
                        int docId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Doctor Name: ");
                        string docName = Console.ReadLine();
                        hospital.AddDoctor(new Doctor(docId, docName));
                        Console.WriteLine("Doctor Added Successfully.");
                        break;

                    case 2:
                        Console.Write("Enter Patient ID: ");
                        int patId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Patient Name: ");
                        string patName = Console.ReadLine();
                        hospital.AddPatient(new Patient(patId, patName));
                        Console.WriteLine("Patient Added Successfully.");
                        break;

                    case 3:
                        Console.Write("Enter Doctor ID: ");
                        int dId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Patient ID: ");
                        int pId = int.Parse(Console.ReadLine());
                        hospital.AssignPatientToDoctor(dId, pId);
                        break;

                    case 4:
                        hospital.ViewDoctors();
                        break;

                    case 5:
                        hospital.ViewPatients();
                        break;

                    case 6:
                        Console.Write("Enter Doctor ID: ");
                        int docViewId = int.Parse(Console.ReadLine());
                        hospital.ViewPatientsOfDoctor(docViewId);
                        break;

                    case 7:
                        Console.Write("Enter Patient ID: ");
                        int patViewId = int.Parse(Console.ReadLine());
                        hospital.ViewDoctorsOfPatient(patViewId);
                        break;

                    case 8:
                        Console.Write("Enter Doctor ID to remove: ");
                        int removeDocId = int.Parse(Console.ReadLine());
                        hospital.RemoveDoctor(removeDocId);
                        break;

                    case 9:
                        Console.Write("Enter Patient ID to remove: ");
                        int removePatId = int.Parse(Console.ReadLine());
                        hospital.RemovePatient(removePatId);
                        break;

                    case 10:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try Again.");
                        break;
                }
            }
        }
    }
}
