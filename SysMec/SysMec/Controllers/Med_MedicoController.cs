using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SysMec;

namespace SysMec.Controllers
{
    public class Med_MedicoController : Controller
    {
        private Entities db = new Entities();

        // GET: Med_Medico
        public ActionResult Index()
        {
            return View(db.Med_Medico.ToList());
        }

        // GET: Med_Medico/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Med_Medico med_Medico = db.Med_Medico.Find(id);
            if (med_Medico == null)
            {
                return HttpNotFound();
            }
            return View(med_Medico);
        }

        // GET: Med_Medico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Med_Medico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vc_id_medico,vc_Nombre_Medico,vc_Primer_Apellido,vc_Segundo_Apellido,vc_Especialidad")] Med_Medico med_Medico)
        {
            if (ModelState.IsValid)
            {
                db.Med_Medico.Add(med_Medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(med_Medico);
        }

        // GET: Med_Medico/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Med_Medico med_Medico = db.Med_Medico.Find(id);
            if (med_Medico == null)
            {
                return HttpNotFound();
            }
            return View(med_Medico);
        }

        // POST: Med_Medico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vc_id_medico,vc_Nombre_Medico,vc_Primer_Apellido,vc_Segundo_Apellido,vc_Especialidad")] Med_Medico med_Medico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(med_Medico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(med_Medico);
        }

        // GET: Med_Medico/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Med_Medico med_Medico = db.Med_Medico.Find(id);
            if (med_Medico == null)
            {
                return HttpNotFound();
            }
            return View(med_Medico);
        }

        // POST: Med_Medico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Med_Medico med_Medico = db.Med_Medico.Find(id);
            db.Med_Medico.Remove(med_Medico);
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
