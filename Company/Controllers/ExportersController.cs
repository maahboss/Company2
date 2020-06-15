using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Company.Models;
using WebApplication2.Models;

namespace Company.Controllers
{
    [Authorize]
    public class ExportersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Exporters
        public ActionResult Index()
        {
            return View(db.Exporters.ToList());
        }

        // GET: Exporters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exporter exporter = db.Exporters.Find(id);
            if (exporter == null)
            {
                return HttpNotFound();
            }
            return View(exporter);
        }

        // GET: Exporters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exporters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Note")] Exporter exporter)
        {
            if (ModelState.IsValid)
            {
                db.Exporters.Add(exporter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exporter);
        }

        // GET: Exporters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exporter exporter = db.Exporters.Find(id);
            if (exporter == null)
            {
                return HttpNotFound();
            }
            return View(exporter);
        }

        // POST: Exporters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Exporter exporter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exporter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exporter);
        }

        // GET: Exporters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exporter exporter = db.Exporters.Find(id);
            if (exporter == null)
            {
                return HttpNotFound();
            }
            return View(exporter);
        }

        // POST: Exporters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exporter exporter = db.Exporters.Find(id);
            db.Exporters.Remove(exporter);
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
