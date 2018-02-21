using SurgeryOnSunday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurgeryOnSunday.Views
{
    public class GeneralVolunteerFormViewModelController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GeneralVolunteerFormViewModel
        public ActionResult Index()
        {
            return View(new GeneralVolunteerFormViewModel());
        }

        public ActionResult Index(GeneralVolunteerFormViewModel viewModel)
        {
            var volunteer = new VolunteerModel()
            {
                VolunteerID = viewModel.VolunteerID,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Address = viewModel.Address,
                City = viewModel.City,
                PostalCode = viewModel.PostalCode,
                BirthDate = viewModel.BirthDate,
                State = viewModel.State,
                Phone = viewModel.Phone,
                Employer = viewModel.Employer,
                Email = viewModel.Email,
                Comments = viewModel.Comments,
                ShirtSize = viewModel.ShirtSize,
                PersonalDescr = viewModel.PersonalDescr,
                VolAreas = viewModel.VolAreas,
                PreferredName = viewModel.PreferredName
            };

            db.Volunteers.Add(volunteer);

            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}