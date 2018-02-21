using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurgeryOnSunday.Models
{
    public class VolunteerModel
    {
        public int VolunteerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PreferredName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }

        public string MedSpecialty { get; set; }

        public string AlmaMater { get; set; }

        public DateTime GradDate { get; set; }

        public string LicenseNum { get; set; }

        public string LicenseState { get; set; }

        public string Upload { get; set; }

        public string ShirtSize { get; set; }

        public string ProfTitle { get; set; }

        public string Employer { get; set; }

        public string PersonalDescr { get; set; }

        public string VolAreas { get; set; }

        public string Languages { get; set; }

        public string Comments { get; set; }

    }
}