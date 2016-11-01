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
    public class Cat_HorarioServicioController : Controller
    {
        private Entities db = new Entities();

        // GET: Cat_HorarioServicio
        public ActionResult Index()
        {
            var cat_HorarioServicio = db.Cat_HorarioServicio.Include(c => c.CM_Medico);
            return View(cat_HorarioServicio.ToList());
        }

        // GET: Cat_HorarioServicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat_HorarioServicio cat_HorarioServicio = db.Cat_HorarioServicio.Find(id);
            if (cat_HorarioServicio == null)
            {
                return HttpNotFound();
            }
            return View(cat_HorarioServicio);
        }

        // GET: Cat_HorarioServicio/Create
        public ActionResult Create()
        {
            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico");
            return View();
        }

        // POST: Cat_HorarioServicio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_Pk_idHoraServicio,i_Fk_idMedico,t_HoraInicio,t_HoraFinal,vc_DiaServicio")] Cat_HorarioServicio cat_HorarioServicio)
        {
            if (ModelState.IsValid)
            {
                try { 
                db.Cat_HorarioServicio.Add(cat_HorarioServicio);
                db.SaveChanges();
                }
                catch (Exception) { }
                return RedirectToAction("Index");
            }

            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico", cat_HorarioServicio.i_Fk_idMedico);
            return View(cat_HorarioServicio);
        }

        // GET: Cat_HorarioServicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat_HorarioServicio cat_HorarioServicio = db.Cat_HorarioServicio.Find(id);
            if (cat_HorarioServicio == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico", cat_HorarioServicio.i_Fk_idMedico);
            return View(cat_HorarioServicio);
        }

        // POST: Cat_HorarioServicio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_Pk_idHoraServicio,i_Fk_idMedico,t_HoraInicio,t_HoraFinal,vc_DiaServicio")] Cat_HorarioServicio cat_HorarioServicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cat_HorarioServicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico", cat_HorarioServicio.i_Fk_idMedico);
            return View(cat_HorarioServicio);
        }

        // GET: Cat_HorarioServicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat_HorarioServicio cat_HorarioServicio = db.Cat_HorarioServicio.Find(id);
            if (cat_HorarioServicio == null)
            {
                return HttpNotFound();
            }
            return View(cat_HorarioServicio);
        }

        // POST: Cat_HorarioServicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cat_HorarioServicio cat_HorarioServicio = db.Cat_HorarioServicio.Find(id);
            db.Cat_HorarioServicio.Remove(cat_HorarioServicio);
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
