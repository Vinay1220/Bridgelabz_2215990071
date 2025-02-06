using System;
using System.Collections.Generic;

namespace HospitalManagement
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        private List<Doctor> doctorsList = new List<Doctor>();

        public Patient(int patientId, string patientName)
        {
            PatientId = patientId;
            PatientName = patientName;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctorsList.Add(doctor);
        }

        public void ViewDoctors()
        {
            Console.WriteLine($"Doctors for {PatientName} (ID: {PatientId}):");
            foreach (var doc in doctorsList)
            {
                Console.WriteLine($"  - Dr. {doc.DoctorName} (ID: {doc.DoctorId})");
            }
        }
    }
}
