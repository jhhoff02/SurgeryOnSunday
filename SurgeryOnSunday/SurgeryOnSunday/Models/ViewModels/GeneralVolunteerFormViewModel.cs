using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurgeryOnSunday.Models
{
    public class GeneralVolunteerFormViewModel
    {
        public int VolunteerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public DateTime BirthDate { get; set; }

        public string State { get; set; }

        public string Phone { get; set; }

        public string Employer { get; set; }

        public string Email { get; set; }

        public string Comments { get; set; }

        public string ShirtSize { get; set; }

        public string PersonalDescr { get; set; }

        public string VolAreas { get; set; }

        public string PreferredName { get; set; }
    }
}