using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurgeryOnSunday.Models
{
    public class Volunteer
    {
        public int VolunteerID { get; set; }

        public string FirstName { get; set; }
        [Display(Name = "First Name")]

        public string LastName { get; set; }
        [Display(Name = "Last Name")]

        public string PreferredName { get; set; }
        [Display(Name = "Preferred Name")]

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }
        [Display(Name = "Postal Code")]

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }
        [Display(Name = "Birth Date")]

        public string MedSpecialty { get; set; }
        [Display(Name = "Medical Specialty")]

        public string AlmaMater { get; set; }
        [Display(Name = "Alma Mater")]

        public DateTime GradDate { get; set; }
        [Display(Name = "Graduation Date")]

        public string LicenseNum { get; set; }
        [Display(Name = "License Number")]

        public string LicenseState { get; set; }
        [Display(Name = "States Licensed")]

        public string Upload { get; set; }

        public string ShirtSize { get; set; }
        [Display(Name = "Shirt Size")]

        public string ProfTitle { get; set; }
        [Display(Name = "Professional Title")]

        public string Employer { get; set; }

        public string PersonalDescr { get; set; }
        [Display(Name = "Personal Description")]

        public string VolAreas { get; set; }
        [Display(Name = "Volunteer Areas")]

        public string Languages { get; set; }

        public string Comments { get; set; }
    }
    }
