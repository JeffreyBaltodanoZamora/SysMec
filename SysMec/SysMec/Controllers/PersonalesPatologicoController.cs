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
    public class PersonalesPatologicoController : Controller
    {
        private Entities db = new Entities();

        // GET: PersonalesPatologico
        public ActionResult Index()
        {
            var personales_Patologico = db.Personales_Patologico.Include(p => p.Estado);
            return View(personales_Patologico.ToList());
        }

        // GET: PersonalesPatologico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personales_Patologico personales_Patologico = db.Personales_Patologico.Find(id);
            if (personales_Patologico == null)
            {
                return HttpNotFound();
            }
            return View(personales_Patologico);
        }

        // GET: PersonalesPatologico/Create
        public ActionResult Create()
        {
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            return View();
        }

        // POST: PersonalesPatologico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_pk_antecents_patologicos,vc_piel,vc_aparato_resp,vc_aparato_digestivo,vc_aparato_geneto_U,vc_sistema_nervioso,vc_sistema_musc_esquele,vc_sistema_endocrinolo,vc_sistema_cariodv,vc_alergias,vc_proble_psicologicos,i_fk_estado")] Personales_Patologico personales_Patologico)
        {
            if (ModelState.IsValid)
            {
                db.Personales_Patologico.Add(personales_Patologico);
                db.SaveChanges();
                return RedirectToAction("Create", "AntecedentesPatologicos");
            }

            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", personales_Patologico.i_fk_estado);
            return View(personales_Patologico);
        }

        // GET: PersonalesPatologico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personales_Patologico personales_Patologico = db.Personales_Patologico.Find(id);
            if (personales_Patologico == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", personales_Patologico.i_fk_estado);
            return View(personales_Patologico);
        }

        // POST: PersonalesPatologico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_pk_antecents_patologicos,vc_piel,vc_aparato_resp,vc_aparato_digestivo,vc_aparato_geneto_U,vc_sistema_nervioso,vc_sistema_musc_esquele,vc_sistema_endocrinolo,vc_sistema_cariodv,vc_alergias,vc_proble_psicologicos,i_fk_estado")] Personales_Patologico personales_Patologico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personales_Patologico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", personales_Patologico.i_fk_estado);
            return View(personales_Patologico);
        }

        // GET: PersonalesPatologico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personales_Patologico personales_Patologico = db.Personales_Patologico.Find(id);
            if (personales_Patologico == null)
            {
                return HttpNotFound();
            }
            return View(personales_Patologico);
        }

        // POST: PersonalesPatologico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personales_Patologico personales_Patologico = db.Personales_Patologico.Find(id);
            db.Personales_Patologico.Remove(personales_Patologico);
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
