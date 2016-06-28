using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Curriculum.Models;

namespace Curriculum.Controllers
{
    public class LenguajesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lenguajes
        public ActionResult Index()
        {
            return View(db.Lenguajes.ToList());
        }

        // GET: Lenguajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lenguaje lenguaje = db.Lenguajes.Find(id);
            if (lenguaje == null)
            {
                return HttpNotFound();
            }
            return View(lenguaje);
        }

        // GET: Lenguajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lenguajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name_lenguaje")] Lenguaje lenguaje)
        {
            if (ModelState.IsValid)
            {
                db.Lenguajes.Add(lenguaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lenguaje);
        }

        // GET: Lenguajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lenguaje lenguaje = db.Lenguajes.Find(id);
            if (lenguaje == null)
            {
                return HttpNotFound();
            }
            return View(lenguaje);
        }

        // POST: Lenguajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name_lenguaje")] Lenguaje lenguaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lenguaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lenguaje);
        }

        // GET: Lenguajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lenguaje lenguaje = db.Lenguajes.Find(id);
            if (lenguaje == null)
            {
                return HttpNotFound();
            }
            return View(lenguaje);
        }

        // POST: Lenguajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lenguaje lenguaje = db.Lenguajes.Find(id);
            db.Lenguajes.Remove(lenguaje);
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
