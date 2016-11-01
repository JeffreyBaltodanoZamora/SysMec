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
    public class Exp_AnteQuirurTraumaController : Controller
    {
        private Entities db = new Entities();

        // GET: Exp_AnteQuirurTrauma
        public ActionResult Index()
        {
            return View(db.Exp_AnteQuirurTrauma.ToList());
        }

        // GET: Exp_AnteQuirurTrauma/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_AnteQuirurTrauma exp_AnteQuirurTrauma = db.Exp_AnteQuirurTrauma.Find(id);
            if (exp_AnteQuirurTrauma == null)
            {
                return HttpNotFound();
            }
            return View(exp_AnteQuirurTrauma);
        }

        // GET: Exp_AnteQuirurTrauma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exp_AnteQuirurTrauma/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_Pk_QuirurTrauma,b_Fracturas,d_Fractura,vc_FracDonde,b_Cirugias,d_Cirugia,vc_CiruDonde,vc_AcciNoLaborales,vc_AcciLaborales")] Exp_AnteQuirurTrauma exp_AnteQuirurTrauma)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Exp_AnteQuirurTrauma.Add(exp_AnteQuirurTrauma);
                    db.SaveChanges();
                }
                catch (Exception) { }
            return RedirectToAction("Create", "Exp_GinecoObstreticos");
            }

            return View(exp_AnteQuirurTrauma);
        }

        // GET: Exp_AnteQuirurTrauma/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_AnteQuirurTrauma exp_AnteQuirurTrauma = db.Exp_AnteQuirurTrauma.Find(id);
            if (exp_AnteQuirurTrauma == null)
            {
                return HttpNotFound();
            }
            return View(exp_AnteQuirurTrauma);
        }

        // POST: Exp_AnteQuirurTrauma/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_Pk_QuirurTrauma,b_Fracturas,d_Fractura,vc_FracDonde,b_Cirugias,d_Cirugia,vc_CiruDonde,vc_AcciNoLaborales,vc_AcciLaborales")] Exp_AnteQuirurTrauma exp_AnteQuirurTrauma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exp_AnteQuirurTrauma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exp_AnteQuirurTrauma);
        }

        // GET: Exp_AnteQuirurTrauma/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_AnteQuirurTrauma exp_AnteQuirurTrauma = db.Exp_AnteQuirurTrauma.Find(id);
            if (exp_AnteQuirurTrauma == null)
            {
                return HttpNotFound();
            }
            return View(exp_AnteQuirurTrauma);
        }

        // POST: Exp_AnteQuirurTrauma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exp_AnteQuirurTrauma exp_AnteQuirurTrauma = db.Exp_AnteQuirurTrauma.Find(id);
            db.Exp_AnteQuirurTrauma.Remove(exp_AnteQuirurTrauma);
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
