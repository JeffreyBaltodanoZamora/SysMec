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
    public class Exp_GinecoObstreticosController : Controller
    {
        private Entities db = new Entities();

        // GET: Exp_GinecoObstreticos
        public ActionResult Index()
        {
            return View(db.Exp_GinecoObstreticos.ToList());
        }

        // GET: Exp_GinecoObstreticos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_GinecoObstreticos exp_GinecoObstreticos = db.Exp_GinecoObstreticos.Find(id);
            if (exp_GinecoObstreticos == null)
            {
                return HttpNotFound();
            }
            return View(exp_GinecoObstreticos);
        }

        // GET: Exp_GinecoObstreticos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exp_GinecoObstreticos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_Pk_idGinObste,vc_Menarca,vc_Fur,b_RelacionesSexuales,b_Planificar,b_Ritmo,vc_Metodo,vc_Duracion,b_PartosEutocicos,b_Forceps,b_Cesareas,b_Flujos,vc_SangradoAnormal,b_Pap,d_pap,vc_resultado")] Exp_GinecoObstreticos exp_GinecoObstreticos)
        {
            if (ModelState.IsValid)
            {
                db.Exp_GinecoObstreticos.Add(exp_GinecoObstreticos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exp_GinecoObstreticos);
        }

        // GET: Exp_GinecoObstreticos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_GinecoObstreticos exp_GinecoObstreticos = db.Exp_GinecoObstreticos.Find(id);
            if (exp_GinecoObstreticos == null)
            {
                return HttpNotFound();
            }
            return View(exp_GinecoObstreticos);
        }

        // POST: Exp_GinecoObstreticos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_Pk_idGinObste,vc_Menarca,vc_Fur,b_RelacionesSexuales,b_Planificar,b_Ritmo,vc_Metodo,vc_Duracion,b_PartosEutocicos,b_Forceps,b_Cesareas,b_Flujos,vc_SangradoAnormal,b_Pap,d_pap,vc_resultado")] Exp_GinecoObstreticos exp_GinecoObstreticos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exp_GinecoObstreticos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exp_GinecoObstreticos);
        }

        // GET: Exp_GinecoObstreticos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_GinecoObstreticos exp_GinecoObstreticos = db.Exp_GinecoObstreticos.Find(id);
            if (exp_GinecoObstreticos == null)
            {
                return HttpNotFound();
            }
            return View(exp_GinecoObstreticos);
        }

        // POST: Exp_GinecoObstreticos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exp_GinecoObstreticos exp_GinecoObstreticos = db.Exp_GinecoObstreticos.Find(id);
            db.Exp_GinecoObstreticos.Remove(exp_GinecoObstreticos);
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
