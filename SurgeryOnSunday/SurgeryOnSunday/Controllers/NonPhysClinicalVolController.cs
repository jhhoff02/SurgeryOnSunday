using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SurgeryOnSunday.Models;

namespace SurgeryOnSunday.Controllers
{
    public class NonPhysClinicalVolController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NonPhysClinicalVol
        public ActionResult Index()
        {
            return View(db.NonPhysClinicalVol.ToList());
        }

        // GET: NonPhysClinicalVol/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonPhysClinicalVol nonPhysClinicalVol = db.NonPhysClinicalVol.Find(id);
            if (nonPhysClinicalVol == null)
            {
                return HttpNotFound();
            }
            return View(nonPhysClinicalVol);
        }

        // GET: NonPhysClinicalVol/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NonPhysClinicalVol/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NonPhysClinicalVolID,FirstName,LastName,Address,City,PostalCode,State,Phone,LicenseNum,Email,ShirtSize,ProfTitle,PreferredName,BirthDate")] NonPhysClinicalVol nonPhysClinicalVol)
        {
            if (ModelState.IsValid)
            {
                db.NonPhysClinicalVol.Add(nonPhysClinicalVol);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nonPhysClinicalVol);
        }

        // GET: NonPhysClinicalVol/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonPhysClinicalVol nonPhysClinicalVol = db.NonPhysClinicalVol.Find(id);
            if (nonPhysClinicalVol == null)
            {
                return HttpNotFound();
            }
            return View(nonPhysClinicalVol);
        }

        // POST: NonPhysClinicalVol/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NonPhysClinicalVolID,FirstName,LastName,Address,City,PostalCode,State,Phone,LicenseNum,Email,ShirtSize,ProfTitle,PreferredName,BirthDate")] NonPhysClinicalVol nonPhysClinicalVol)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nonPhysClinicalVol).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nonPhysClinicalVol);
        }

        // GET: NonPhysClinicalVol/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NonPhysClinicalVol nonPhysClinicalVol = db.NonPhysClinicalVol.Find(id);
            if (nonPhysClinicalVol == null)
            {
                return HttpNotFound();
            }
            return View(nonPhysClinicalVol);
        }

        // POST: NonPhysClinicalVol/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NonPhysClinicalVol nonPhysClinicalVol = db.NonPhysClinicalVol.Find(id);
            db.NonPhysClinicalVol.Remove(nonPhysClinicalVol);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
