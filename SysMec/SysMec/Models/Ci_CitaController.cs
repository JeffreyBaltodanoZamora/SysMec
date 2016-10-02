using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SysMec;

namespace SysMec.Models
{
    public class Ci_CitaController : Controller
    {
        private Entities db = new Entities();

        // GET: Ci_Cita
        public ActionResult Index()
        {
            var ci_Cita = db.Ci_Cita.Include(c => c.Med_Medico).Include(c => c.Us_Usuario);
            return View(ci_Cita.ToList());
        }

        // GET: Ci_Cita/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ci_Cita ci_Cita = db.Ci_Cita.Find(id);
            if (ci_Cita == null)
            {
                return HttpNotFound();
            }
            return View(ci_Cita);
        }

        // GET: Ci_Cita/Create
        public ActionResult Create()
        {
            ViewBag.vc_id_medico = new SelectList(db.Med_Medico, "vc_id_medico", "vc_Nombre_Medico");
            ViewBag.vc_id_usuario = new SelectList(db.Us_Usuario, "vc_Pk_id_usuario", "vc_clave");
            return View();
        }

        // POST: Ci_Cita/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_PK_id_cita,vc_id_usuario,vc_id_medico,dt_hora_inicio,dt_hora_fin")] Ci_Cita ci_Cita)
        {
            if (ModelState.IsValid)
            {
                db.Ci_Cita.Add(ci_Cita);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.vc_id_medico = new SelectList(db.Med_Medico, "vc_id_medico", "vc_Nombre_Medico", ci_Cita.vc_id_medico);
            ViewBag.vc_id_usuario = new SelectList(db.Us_Usuario, "vc_Pk_id_usuario", "vc_clave", ci_Cita.vc_id_usuario);
            return View(ci_Cita);
        }

        // GET: Ci_Cita/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ci_Cita ci_Cita = db.Ci_Cita.Find(id);
            if (ci_Cita == null)
            {
                return HttpNotFound();
            }
            ViewBag.vc_id_medico = new SelectList(db.Med_Medico, "vc_id_medico", "vc_Nombre_Medico", ci_Cita.vc_id_medico);
            ViewBag.vc_id_usuario = new SelectList(db.Us_Usuario, "vc_Pk_id_usuario", "vc_clave", ci_Cita.vc_id_usuario);
            return View(ci_Cita);
        }

        // POST: Ci_Cita/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_PK_id_cita,vc_id_usuario,vc_id_medico,dt_hora_inicio,dt_hora_fin")] Ci_Cita ci_Cita)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ci_Cita).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.vc_id_medico = new SelectList(db.Med_Medico, "vc_id_medico", "vc_Nombre_Medico", ci_Cita.vc_id_medico);
            ViewBag.vc_id_usuario = new SelectList(db.Us_Usuario, "vc_Pk_id_usuario", "vc_clave", ci_Cita.vc_id_usuario);
            return View(ci_Cita);
        }

        // GET: Ci_Cita/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ci_Cita ci_Cita = db.Ci_Cita.Find(id);
            if (ci_Cita == null)
            {
                return HttpNotFound();
            }
            return View(ci_Cita);
        }

        // POST: Ci_Cita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ci_Cita ci_Cita = db.Ci_Cita.Find(id);
            db.Ci_Cita.Remove(ci_Cita);
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
