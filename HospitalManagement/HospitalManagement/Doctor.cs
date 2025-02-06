using System;
using System.Collections.Generic;

namespace HospitalManagement
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        private List<Patient> patientsList = new List<Patient>();

        public Doctor(int doctorId, string doctorName)
        {
            DoctorId = doctorId;
            DoctorName = doctorName;
        }

        public void AddPatient(Patient patient)
        {
            patientsList.Add(patient);
        }

        public void ViewPatients()
        {
            Console.WriteLine($"Patients under Dr. {DoctorName} (ID: {DoctorId}):");
            if (patientsList.Count == 0)
            {
                Console.WriteLine("  No Patients Assigned.");
                return;
            }

            foreach (var patient in patientsList)
            {
                Console.WriteLine($"  - {patient.PatientName} (ID: {patient.PatientId})");
            }
        }

        public void Consult(Patient patient)
        {
            Console.WriteLine($"Dr. {DoctorName} is consulting {patient.PatientName}.");
        }
    }
}
