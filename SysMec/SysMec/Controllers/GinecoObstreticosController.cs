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
    public class GinecoObstreticosController : Controller
    {
        private Entities db = new Entities();

        // GET: GinecoObstreticos
        public ActionResult Index()
        {
            var gineco_Obstreticos = db.Gineco_Obstreticos.Include(g => g.Estado);
            return View(gineco_Obstreticos.ToList());
        }

        // GET: GinecoObstreticos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gineco_Obstreticos gineco_Obstreticos = db.Gineco_Obstreticos.Find(id);
            if (gineco_Obstreticos == null)
            {
                return HttpNotFound();
            }
            return View(gineco_Obstreticos);
        }

        // GET: GinecoObstreticos/Create
        public ActionResult Create()
        {
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            return View();
        }

        // POST: GinecoObstreticos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_pk_gineco_obstetricos,vc_menarca,vc_fur,vc_relaciones_sexuales,vc_planificar,vc_ritmo,vc_metodo,vc_duracion,vc_partos_eutocicos,vc_forceps,vc_cesareas,vc_flujos,vc_sangrados_anormales,vc_pap,dt_pap,vc_resultado,i_fk_estado")] Gineco_Obstreticos gineco_Obstreticos)
        {
            if (ModelState.IsValid)
            {
                db.Gineco_Obstreticos.Add(gineco_Obstreticos);
                db.SaveChanges();
                return RedirectToAction("Create", "ExpedienteMedico");
            }

            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", gineco_Obstreticos.i_fk_estado);
            return View(gineco_Obstreticos);
        }

        // GET: GinecoObstreticos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gineco_Obstreticos gineco_Obstreticos = db.Gineco_Obstreticos.Find(id);
            if (gineco_Obstreticos == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", gineco_Obstreticos.i_fk_estado);
            return View(gineco_Obstreticos);
        }

        // POST: GinecoObstreticos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_pk_gineco_obstetricos,vc_menarca,vc_fur,vc_relaciones_sexuales,vc_planificar,vc_ritmo,vc_metodo,vc_duracion,vc_partos_eutocicos,vc_forceps,vc_cesareas,vc_flujos,vc_sangrados_anormales,vc_pap,dt_pap,vc_resultado,i_fk_estado")] Gineco_Obstreticos gineco_Obstreticos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gineco_Obstreticos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", gineco_Obstreticos.i_fk_estado);
            return View(gineco_Obstreticos);
        }

        // GET: GinecoObstreticos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gineco_Obstreticos gineco_Obstreticos = db.Gineco_Obstreticos.Find(id);
            if (gineco_Obstreticos == null)
            {
                return HttpNotFound();
            }
            return View(gineco_Obstreticos);
        }

        // POST: GinecoObstreticos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gineco_Obstreticos gineco_Obstreticos = db.Gineco_Obstreticos.Find(id);
            db.Gineco_Obstreticos.Remove(gineco_Obstreticos);
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
