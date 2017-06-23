using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Models
{
    public class Doctor : Person
    {
        public Doctor(string fName, string mName, string lName, string suffix, string gender, string docType)
            : base(fName, mName, lName, suffix, gender)
        {
            FirstName = fName;
            LastName = lName;
            MiddleName = mName;
            Suffix = suffix;
            Gender = gender;
            DoctorType = docType;
            PersonGUID = new Guid();
        }

        public string DoctorRating { get; set; }
        public string DoctorType { get; set; }

        public Patient Patient { get; set; }
    }

    public enum DoctorType
    {
        PRIMARY_CARE_PHYSICIAN,
        ALLERGY,
        GASTRONOLOGY,
        IMMUNE,
        SPECIALTY,
        EYE_DOCTOR,
        PULMONOLGY,
        THERAPIST
    }

    public enum DoctorRating
    {
        FIVE_STAR,
        FOUR_STAR,
        THREE_STAR,
        TWO_STAR,
        ONE_STAR
    }
}
