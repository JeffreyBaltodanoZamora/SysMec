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
    public class HeredoFamiliarController : Controller
    {
        private Entities db = new Entities();

        // GET: HeredoFamiliar
        public ActionResult Index()
        {
            var heredo_familiar = db.Heredo_familiar.Include(h => h.Estado);
            return View(heredo_familiar.ToList());
        }

        // GET: HeredoFamiliar/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Heredo_familiar heredo_familiar = db.Heredo_familiar.Find(id);
            if (heredo_familiar == null)
            {
                return HttpNotFound();
            }
            return View(heredo_familiar);
        }

        // GET: HeredoFamiliar/Create
        public ActionResult Create()
        {
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            return View();
        }

        // POST: HeredoFamiliar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_pk_heredo_famili,vc_piel,vc_aparato_respiratorio,vc_aparato_digestivo,vc_aparato_geneto_urinario,vc_sistema_nervioso,vc_sistema_musco_esque,vc_sistema_endocrino,vc_sistema_cardio,vc_alergias,vc_cancer,vc_problemas_psicosomaticos,vc_padecimiento_actual,i_fk_estado")] Heredo_familiar heredo_familiar)
        {
            if (ModelState.IsValid)
            {
                db.Heredo_familiar.Add(heredo_familiar);
                db.SaveChanges();
                return RedirectToAction("Create","AntecedentesPatologicos");
            }

            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", heredo_familiar.i_fk_estado);
            return View(heredo_familiar);
        }

        // GET: HeredoFamiliar/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Heredo_familiar heredo_familiar = db.Heredo_familiar.Find(id);
            if (heredo_familiar == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", heredo_familiar.i_fk_estado);
            return View(heredo_familiar);
        }

        // POST: HeredoFamiliar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_pk_heredo_famili,vc_piel,vc_aparato_respiratorio,vc_aparato_digestivo,vc_aparato_geneto_urinario,vc_sistema_nervioso,vc_sistema_musco_esque,vc_sistema_endocrino,vc_sistema_cardio,vc_alergias,vc_cancer,vc_problemas_psicosomaticos,vc_padecimiento_actual,i_fk_estado")] Heredo_familiar heredo_familiar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(heredo_familiar).State = EntityState.Modified;
                db.SaveChanges();
                var item = heredo_familiar.i_pk_heredo_famili;
                return RedirectToAction("Edit", "AntecedentesPatologicos", new { id = item });
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", heredo_familiar.i_fk_estado);
            return View(heredo_familiar);
        }

        // GET: HeredoFamiliar/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Heredo_familiar heredo_familiar = db.Heredo_familiar.Find(id);
            if (heredo_familiar == null)
            {
                return HttpNotFound();
            }
            return View(heredo_familiar);
        }

        // POST: HeredoFamiliar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Heredo_familiar heredo_familiar = db.Heredo_familiar.Find(id);
            db.Heredo_familiar.Remove(heredo_familiar);
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
