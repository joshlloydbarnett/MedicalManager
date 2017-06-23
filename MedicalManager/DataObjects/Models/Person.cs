using System;
using System.Collections.Generic;

namespace DataObjects.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Guid PersonGUID { get; set; }

       public  Person(string fName, string mName, string lName, string suffix, string gender)
        {
            FirstName = fName;
            LastName = lName;
            MiddleName = mName;
            Suffix = suffix;
            Gender = gender;
            PersonGUID = new Guid();
        }


        public ICollection<Patient> Patients { get; set; }

    }
}
