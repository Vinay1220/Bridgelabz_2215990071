using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HospitalManagement
{
    public class Hospital
    {
        public string HospitalName { get; set; }
        private List<Doctor> doctors = new List<Doctor>();
        private List<Patient> patients = new List<Patient>();

        public Hospital(string hospitalName)
        {
            HospitalName = hospitalName;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void AssignPatientToDoctor(int doctorId, int patientId)
        {
            var doctor = doctors.FirstOrDefault(d => d.DoctorId == doctorId);
            var patient = patients.FirstOrDefault(p => p.PatientId == patientId);

            if (doctor != null && patient != null)
            {
                doctor.AddPatient(patient);
                patient.AddDoctor(doctor);
                Console.WriteLine($"Patient {patient.PatientName} assigned to Doctor {doctor.DoctorName}.");
            }
            else
            {
                Console.WriteLine("Invalid Doctor or Patient ID.");
            }
        }

        public void ViewDoctors()
        {
            Console.WriteLine($"\nDoctors in {HospitalName}:");
            if (doctors.Count == 0)
            {
                Console.WriteLine("  No Doctors Available.");
                return;
            }

            foreach (var doc in doctors)
            {
                Console.WriteLine($"  - {doc.DoctorName} (ID: {doc.DoctorId})");
            }
        }

        public void ViewPatients()
        {
            Console.WriteLine($"\nPatients in {HospitalName}:");
            if (patients.Count == 0)
            {
                Console.WriteLine("  No Patients Available.");
                return;
            }

            foreach (var pat in patients)
            {
                Console.WriteLine($"  - {pat.PatientName} (ID: {pat.PatientId})");
            }
        }

        public void ViewPatientsOfDoctor(int doctorId)
        {
            var doctor = doctors.FirstOrDefault(d => d.DoctorId == doctorId);
            if (doctor != null)
            {
                doctor.ViewPatients();
            }
            else
            {
                Console.WriteLine("Doctor Not Found.");
            }
        }

        public void ViewDoctorsOfPatient(int patientId)
        {
            var patient = patients.FirstOrDefault(p => p.PatientId == patientId);
            if (patient != null)
            {
                patient.ViewDoctors();
            }
            else
            {
                Console.WriteLine("Patient Not Found.");
            }
        }

        public void RemoveDoctor(int doctorId)
        {
            var doctor = doctors.FirstOrDefault(d => d.DoctorId == doctorId);
            if (doctor != null)
            {
                doctors.Remove(doctor);
                Console.WriteLine("Doctor Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Doctor Not Found.");
            }
        }

        public void RemovePatient(int patientId)
        {
            var patient = patients.FirstOrDefault(p => p.PatientId == patientId);
            if (patient != null)
            {
                patients.Remove(patient);
                Console.WriteLine("Patient Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Patient Not Found.");
            }
        }
    }
}
