using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DeploymentPractice.Models;

namespace DeploymentPractice.Controllers
{
    public class DataExamplesController : Controller
    {
        private DeploymentPracticeContext db = new DeploymentPracticeContext();

        // GET: DataExamples
        public ActionResult Index()
        {
            return View(db.DataExamples.ToList());
        }

        // GET: DataExamples/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataExample dataExample = db.DataExamples.Find(id);
            if (dataExample == null)
            {
                return HttpNotFound();
            }
            return View(dataExample);
        }

        // GET: DataExamples/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DataExamples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NameType,Info")] DataExample dataExample)
        {
            if (ModelState.IsValid)
            {
                db.DataExamples.Add(dataExample);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dataExample);
        }

        // GET: DataExamples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataExample dataExample = db.DataExamples.Find(id);
            if (dataExample == null)
            {
                return HttpNotFound();
            }
            return View(dataExample);
        }

        // POST: DataExamples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NameType,Info")] DataExample dataExample)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataExample).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dataExample);
        }

        // GET: DataExamples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DataExample dataExample = db.DataExamples.Find(id);
            if (dataExample == null)
            {
                return HttpNotFound();
            }
            return View(dataExample);
        }

        // POST: DataExamples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataExample dataExample = db.DataExamples.Find(id);
            db.DataExamples.Remove(dataExample);
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
