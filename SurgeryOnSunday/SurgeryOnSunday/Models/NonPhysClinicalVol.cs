using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurgeryOnSunday.Models
{
    public class NonPhysClinicalVol
    {
        public int NonPhysClinicalVolID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string State { get; set; }

        public string Phone { get; set; }

        public string LicenseNum { get; set; }

        public string Email { get; set; }

        public string ShirtSize { get; set; }

        public string ProfTitle { get; set; }

        public string PreferredName { get; set; }

        public DateTime BirthDate { get; set; }

    }
}