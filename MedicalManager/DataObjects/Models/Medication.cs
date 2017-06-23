using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Models
{
   public class Medication
    {
        public string MedicationName { get; set; }
        public string MedicationDose { get; set; }
        public string MedicationFrequency { get; set; }
        public string MedicationPharmacy { get; set; }
        public string MedicalPersonGUID { get; set; }
        public string DoctorPrescribed { get; set; }
        public bool ShouldDelete { get; set; }

        public Medication()
        {

        }
        public Medication(string medName, string medDose, string medFreq, string medPharmacy, string drPrescribed)
        {
            MedicationName = medName;
            MedicationFrequency = medFreq;
            MedicationDose = medDose;
            MedicationPharmacy = medPharmacy;
            DoctorPrescribed = drPrescribed;
        }

        public Patient Patient { get; set; }
    }
}
