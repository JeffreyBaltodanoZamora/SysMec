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
            var med_Medico = db.Med_Medico.Include(m => m.Estado);
            return View(med_Medico.ToList());
        }

        // GET: Med_Medico/Details/5
        public ActionResult Details(int? id)
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
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            return View();
        }

        // POST: Med_Medico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_pk_id_medico,vc_Nombre_medico,vc_primer_apellido,vc_segundo_apellido,vc_Especialidad,dt_turno_inicio,dt_turno_fin,i_fk_estado")] Med_Medico med_Medico)
        {
            if (ModelState.IsValid)
            {
                db.Med_Medico.Add(med_Medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", med_Medico.i_fk_estado);
            return View(med_Medico);
        }

        // GET: Med_Medico/Edit/5
        public ActionResult Edit(int? id)
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
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", med_Medico.i_fk_estado);
            return View(med_Medico);
        }

        // POST: Med_Medico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_pk_id_medico,vc_Nombre_medico,vc_primer_apellido,vc_segundo_apellido,vc_Especialidad,dt_turno_inicio,dt_turno_fin,i_fk_estado")] Med_Medico med_Medico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(med_Medico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", med_Medico.i_fk_estado);
            return View(med_Medico);
        }

        // GET: Med_Medico/Delete/5
        public ActionResult Delete(int? id)
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
        public ActionResult DeleteConfirmed(int id)
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
