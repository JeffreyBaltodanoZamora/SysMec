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
    public class AntecedentesQuirurgicosTraumaticosController : Controller
    {
        private Entities db = new Entities();

        // GET: AntecedentesQuirurgicosTraumaticos
        public ActionResult Index()
        {
            var cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS = db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.Include(c => c.Estado);
            return View(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.ToList());
        }

        // GET: AntecedentesQuirurgicosTraumaticos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS = db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.Find(id);
            if (cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS == null)
            {
                return HttpNotFound();
            }
            return View(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS);
        }

        // GET: AntecedentesQuirurgicosTraumaticos/Create
        public ActionResult Create()
        {
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            return View();
        }

        // POST: AntecedentesQuirurgicosTraumaticos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_pk_quirurgicos_traumati,vc_fracturas,vc_donde,dt_fractura,vc_cirugias,vc_cirugias_donde,dt_cirugia,vc_acci_no_laborales,vc_acci_laborales,i_fk_estado")] CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS)
        {
            if (ModelState.IsValid)
            {
                db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.Add(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS);
                db.SaveChanges();
                return RedirectToAction("Create", "GinecoObstreticos");
            }

            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.i_fk_estado);
            return View(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS);
        }

        // GET: AntecedentesQuirurgicosTraumaticos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS = db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.Find(id);
            if (cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.i_fk_estado);
            return View(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS);
        }

        // POST: AntecedentesQuirurgicosTraumaticos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_pk_quirurgicos_traumati,vc_fracturas,vc_donde,dt_fractura,vc_cirugias,vc_cirugias_donde,dt_cirugia,vc_acci_no_laborales,vc_acci_laborales,i_fk_estado")] CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS).State = EntityState.Modified;
                db.SaveChanges();
                var item = cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.i_pk_quirurgicos_traumati;
                return RedirectToAction("Edit", "GinecoObstreticos", new { id = item });
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.i_fk_estado);
            return View(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS);
        }

        // GET: AntecedentesQuirurgicosTraumaticos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS = db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.Find(id);
            if (cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS == null)
            {
                return HttpNotFound();
            }
            return View(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS);
        }

        // POST: AntecedentesQuirurgicosTraumaticos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS = db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.Find(id);
            db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS.Remove(cM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS);
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
