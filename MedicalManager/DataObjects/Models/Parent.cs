using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Models
{
    public class Parent : Person
    {
        public Parent(string fName, string mName, string lName, string suffix, string gender, string patGU, string role)
            : base(fName, mName, lName, suffix, gender)
        {
            FirstName = fName;
            LastName = lName;
            MiddleName = mName;
            PatientGUID = patGU;
            GuardianRole = role;
        }

        public string PatientGUID { get; set; }
        public string GuardianRole { get; set; }
    }

    public enum GuardianRole
    {
        STEP_FATHER,
        FATHER,
        MOTHER,
        STEP_MOTHER,
        FOSTER_DAD,
        FOSTER_MOTHER,
        STATE_APPOINTED_GUARDIAN
    }
}
