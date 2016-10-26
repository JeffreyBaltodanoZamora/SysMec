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
    public class AntecedentesPatologicosController : Controller
    {
        private Entities db = new Entities();

        // GET: AntecedentesPatologicos
        public ActionResult Index()
        {
            var cM_CAT_ANTECEDENTES_PER_PATOLOGICOS = db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS.Include(c => c.Estado);
            return View(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS.ToList());
        }

        // GET: AntecedentesPatologicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_CAT_ANTECEDENTES_PER_PATOLOGICOS cM_CAT_ANTECEDENTES_PER_PATOLOGICOS = db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS.Find(id);
            if (cM_CAT_ANTECEDENTES_PER_PATOLOGICOS == null)
            {
                return HttpNotFound();
            }
            return View(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS);
        }

        // GET: AntecedentesPatologicos/Create
        public ActionResult Create()
        {
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            return View();
        }

        // POST: AntecedentesPatologicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_pk_antecents_patologicos,vc_piel,vc_aparato_digestivo,vc_aparato_gene_urinario,vc_sist_nervioso,vc_sist_musc_esquele,vc_sistem_endocri,vc_sistm_cardio,vc_alergias,vc_Problems_psicolo,i_fk_estado")] CM_CAT_ANTECEDENTES_PER_PATOLOGICOS cM_CAT_ANTECEDENTES_PER_PATOLOGICOS)
        {
            if (ModelState.IsValid)
            {
                db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS.Add(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS);
                db.SaveChanges();
                return RedirectToAction("Create", "AntecedentesQuirurgicosTraumaticos");
            }

            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", cM_CAT_ANTECEDENTES_PER_PATOLOGICOS.i_fk_estado);
            return View(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS);
        }

        // GET: AntecedentesPatologicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_CAT_ANTECEDENTES_PER_PATOLOGICOS cM_CAT_ANTECEDENTES_PER_PATOLOGICOS = db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS.Find(id);
            if (cM_CAT_ANTECEDENTES_PER_PATOLOGICOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", cM_CAT_ANTECEDENTES_PER_PATOLOGICOS.i_fk_estado);
            return View(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS);
        }

        // POST: AntecedentesPatologicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_pk_antecents_patologicos,vc_piel,vc_aparato_digestivo,vc_aparato_gene_urinario,vc_sist_nervioso,vc_sist_musc_esquele,vc_sistem_endocri,vc_sistm_cardio,vc_alergias,vc_Problems_psicolo,i_fk_estado")] CM_CAT_ANTECEDENTES_PER_PATOLOGICOS cM_CAT_ANTECEDENTES_PER_PATOLOGICOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS).State = EntityState.Modified;
                db.SaveChanges();
                var item = cM_CAT_ANTECEDENTES_PER_PATOLOGICOS.i_pk_antecents_patologicos;
                return RedirectToAction("Edit", "AntecedentesQuirurgicosTraumaticos", new { id = item });
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", cM_CAT_ANTECEDENTES_PER_PATOLOGICOS.i_fk_estado);
            return View(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS);
        }

        // GET: AntecedentesPatologicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_CAT_ANTECEDENTES_PER_PATOLOGICOS cM_CAT_ANTECEDENTES_PER_PATOLOGICOS = db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS.Find(id);
            if (cM_CAT_ANTECEDENTES_PER_PATOLOGICOS == null)
            {
                return HttpNotFound();
            }
            return View(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS);
        }

        // POST: AntecedentesPatologicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CM_CAT_ANTECEDENTES_PER_PATOLOGICOS cM_CAT_ANTECEDENTES_PER_PATOLOGICOS = db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS.Find(id);
            db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS.Remove(cM_CAT_ANTECEDENTES_PER_PATOLOGICOS);
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
