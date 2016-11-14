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
    public class Exp_HeredoFamiliarController : Controller
    {
        private Entities db = new Entities();

        // GET: Exp_HeredoFamiliar
        public ActionResult Index()
        {
            return View(db.Exp_HeredoFamiliar.ToList());
        }

        // GET: Exp_HeredoFamiliar/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat_ExpMedico expediente = db.Cat_ExpMedico.Find(id);
            Exp_HeredoFamiliar exp_HeredoFamiliar = db.Exp_HeredoFamiliar.Find(expediente.i_fk_HereFamiliar);

            if (exp_HeredoFamiliar == null)
            {
                return HttpNotFound();
            }
            return View(exp_HeredoFamiliar);
        }

        // GET: Exp_HeredoFamiliar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exp_HeredoFamiliar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_Pk_HereFamiliar,vc_Piel,vc_ApaRespiratorio,vc_ApaDigestivo,vc_ApaGenetoUrinario,vc_SisNervioso,vc_SisMuscoEsque,vc_SisEndocrino,vc_SisCardio,vc_Alergias,vc_Cancer,vc_ProbPsicosomaticos,vc_PadeActual,vc_otros")] Exp_HeredoFamiliar exp_HeredoFamiliar)
        {
            if (ModelState.IsValid)
            {
                db.Exp_HeredoFamiliar.Add(exp_HeredoFamiliar);
                db.SaveChanges();
                return RedirectToAction("Index", "Cat_ExpMedico");
            }

            return View(exp_HeredoFamiliar);
        }

        // GET: Exp_HeredoFamiliar/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat_ExpMedico expediente = db.Cat_ExpMedico.Find(id);
            Exp_HeredoFamiliar exp_HeredoFamiliar = db.Exp_HeredoFamiliar.Find(expediente.i_fk_HereFamiliar);

            if (exp_HeredoFamiliar == null)
            {
                return HttpNotFound();
            }
            return View(exp_HeredoFamiliar);
        }

        // POST: Exp_HeredoFamiliar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_Pk_HereFamiliar,vc_Piel,vc_ApaRespiratorio,vc_ApaDigestivo,vc_ApaGenetoUrinario,vc_SisNervioso,vc_SisMuscoEsque,vc_SisEndocrino,vc_SisCardio,vc_Alergias,vc_Cancer,vc_ProbPsicosomaticos,vc_PadeActual,vc_otros")] Exp_HeredoFamiliar exp_HeredoFamiliar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exp_HeredoFamiliar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Cat_ExpMedico");
            }
            return View(exp_HeredoFamiliar);
        }

        // GET: Exp_HeredoFamiliar/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_HeredoFamiliar exp_HeredoFamiliar = db.Exp_HeredoFamiliar.Find(id);
            if (exp_HeredoFamiliar == null)
            {
                return HttpNotFound();
            }
            return View(exp_HeredoFamiliar);
        }

        // POST: Exp_HeredoFamiliar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exp_HeredoFamiliar exp_HeredoFamiliar = db.Exp_HeredoFamiliar.Find(id);
            db.Exp_HeredoFamiliar.Remove(exp_HeredoFamiliar);
            db.SaveChanges();
            return RedirectToAction("Index", "Cat_ExpMedico");
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
