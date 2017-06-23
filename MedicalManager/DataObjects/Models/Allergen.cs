using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Models
{
    public class Allergen
    {
        public string AllergenName { get; set; }
        public string ReactionType { get; set; }
        public string PersonGUID { get; set; }
        public DateTime? FirstKnownEvent { get; set; }
        public string Symptoms { get; set; }

        public Allergen(string AName, string RType, DateTime? firstKnownReactionDate,string symptoms, string personGU)
        {
            AllergenName = AName;
            ReactionType = RType;
            FirstKnownEvent = firstKnownReactionDate;
            Symptoms = symptoms;
            PersonGUID = personGU;
        }

        public Patient Patient { get; set; }
    }



    public enum ReactionType
    {
        SEVERE,
        MILD,
        MODERATE,
        MINIMAL
    }
}
