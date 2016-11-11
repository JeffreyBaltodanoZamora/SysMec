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
    public class Exp_AntPersoPatologController : Controller
    {
        private Entities db = new Entities();

        // GET: Exp_AntPersoPatolog
        public ActionResult Index()
        {
            return View(db.Exp_AntPersoPatolog.ToList());
        }

        // GET: Exp_AntPersoPatolog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_AntPersoPatolog exp_AntPersoPatolog = db.Exp_AntPersoPatolog.Find(id);
            if (exp_AntPersoPatolog == null)
            {
                return HttpNotFound();
            }
            return View(exp_AntPersoPatolog);
        }

        // GET: Exp_AntPersoPatolog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exp_AntPersoPatolog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_Pk_AntPatologicos,vc_Piel,vc_ApaDigestivo,vc_ApaGeneUrinario,vc_SisNervioso,vc_SisMuscEsquele,vc_SisEndocri,vc_SisCardio,vc_Alergias,vc_ProblemPsicolo,vc_otros")] Exp_AntPersoPatolog exp_AntPersoPatolog)
        {
            if (ModelState.IsValid)
            {
                db.Exp_AntPersoPatolog.Add(exp_AntPersoPatolog);
                db.SaveChanges();
                return RedirectToAction("Index", "Cat_ExpMedico");
            }

            return View(exp_AntPersoPatolog);
        }

        // GET: Exp_AntPersoPatolog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_AntPersoPatolog exp_AntPersoPatolog = db.Exp_AntPersoPatolog.Find(id);
            if (exp_AntPersoPatolog == null)
            {
                return HttpNotFound();
            }
            return View(exp_AntPersoPatolog);
        }

        // POST: Exp_AntPersoPatolog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_Pk_AntPatologicos,vc_Piel,vc_ApaDigestivo,vc_ApaGeneUrinario,vc_SisNervioso,vc_SisMuscEsquele,vc_SisEndocri,vc_SisCardio,vc_Alergias,vc_ProblemPsicolo,vc_otros")] Exp_AntPersoPatolog exp_AntPersoPatolog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exp_AntPersoPatolog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","Cat_ExpMedico");
            }
            return View(exp_AntPersoPatolog);
        }

        // GET: Exp_AntPersoPatolog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_AntPersoPatolog exp_AntPersoPatolog = db.Exp_AntPersoPatolog.Find(id);
            if (exp_AntPersoPatolog == null)
            {
                return HttpNotFound();
            }
            return View(exp_AntPersoPatolog);
        }

        // POST: Exp_AntPersoPatolog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exp_AntPersoPatolog exp_AntPersoPatolog = db.Exp_AntPersoPatolog.Find(id);
            db.Exp_AntPersoPatolog.Remove(exp_AntPersoPatolog);
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
