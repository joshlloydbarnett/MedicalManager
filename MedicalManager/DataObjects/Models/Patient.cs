using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Models
{
    public class Patient : Person
    {
        public string PatientGUID { get; set; }
        public Patient(string fName, string mName, string lName, string suffix, string gender) : base(fName, mName, lName, suffix, gender)
        {

        }

        public Person person { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Allergen> Allergies { get; set; }
        public ICollection<Medication> Medications { get; set; }
        public ICollection<Parent> Parents { get; set; }
    }
}
