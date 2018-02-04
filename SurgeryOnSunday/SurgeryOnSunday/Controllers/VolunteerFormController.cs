using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurgeryOnSunday.Controllers
{
    public class VolunteerFormController : Controller
    {
        // GET: VolunteerForm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PhysVolForm()
        {
            return View();
        }

        public ActionResult NonPhysClinicalVolForm()
        {
            return View();
        }

        public ActionResult GeneralForm()
        {
            return View();
        }

        public ActionResult MedicalInterpreterForm()
        {
            return View();
        }

        public ActionResult VolunteerCommentForm()
        {
            return View();
        }

    }
}
    
