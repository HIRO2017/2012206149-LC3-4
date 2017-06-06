using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2012206149.ENT.Entidades;
using _2012206149.PER;

namespace _2012206149.MVC.Controllers
{
    public class TripulacionsController : Controller
    {
        private _2012206149Context db = new _2012206149Context();

        // GET: Tripulacions
        public ActionResult Index()
        {
            return View(db.Tripulacions.ToList());
        }

        // GET: Tripulacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulacions.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // GET: Tripulacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tripulacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tripulacionId")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                db.Tripulacions.Add(tripulacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tripulacion);
        }

        // GET: Tripulacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulacions.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // POST: Tripulacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tripulacionId")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tripulacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tripulacion);
        }

        // GET: Tripulacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulacions.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // POST: Tripulacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tripulacion tripulacion = db.Tripulacions.Find(id);
            db.Tripulacions.Remove(tripulacion);
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
