using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicApp.Models
{
    public class PatientViewModel
    {
        public ObservableCollection<Patient> Patients { get; set; }

        public PatientViewModel()
        {
            Patients = new ObservableCollection<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }
    }
}
