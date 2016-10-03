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
    public class Emp_PuestoController : Controller
    {
        private Entities db = new Entities();

        // GET: Emp_Puesto
        public ActionResult Index()
        {
            var emp_Puesto = db.Emp_Puesto.Include(e => e.Emp_Empresa);
            return View(emp_Puesto.ToList());
        }

        // GET: Emp_Puesto/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Puesto emp_Puesto = db.Emp_Puesto.Find(id);
            if (emp_Puesto == null)
            {
                return HttpNotFound();
            }
            return View(emp_Puesto);
        }

        // GET: Emp_Puesto/Create
        public ActionResult Create()
        {
            ViewBag.vc_id_empresa = new SelectList(db.Emp_Empresa, "vc_PK_id_empresa", "vc_nombre_empresa");
            return View();
        }

        // POST: Emp_Puesto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vc_PK_id_puesto,vc_nombre_puesto,vc_id_empresa")] Emp_Puesto emp_Puesto)
        {
            if (ModelState.IsValid)
            {
                db.Emp_Puesto.Add(emp_Puesto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.vc_id_empresa = new SelectList(db.Emp_Empresa, "vc_PK_id_empresa", "vc_nombre_empresa", emp_Puesto.vc_id_empresa);
            return View(emp_Puesto);
        }

        // GET: Emp_Puesto/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Puesto emp_Puesto = db.Emp_Puesto.Find(id);
            if (emp_Puesto == null)
            {
                return HttpNotFound();
            }
            ViewBag.vc_id_empresa = new SelectList(db.Emp_Empresa, "vc_PK_id_empresa", "vc_nombre_empresa", emp_Puesto.vc_id_empresa);
            return View(emp_Puesto);
        }

        // POST: Emp_Puesto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vc_PK_id_puesto,vc_nombre_puesto,vc_id_empresa")] Emp_Puesto emp_Puesto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp_Puesto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.vc_id_empresa = new SelectList(db.Emp_Empresa, "vc_PK_id_empresa", "vc_nombre_empresa", emp_Puesto.vc_id_empresa);
            return View(emp_Puesto);
        }

        // GET: Emp_Puesto/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Puesto emp_Puesto = db.Emp_Puesto.Find(id);
            if (emp_Puesto == null)
            {
                return HttpNotFound();
            }
            return View(emp_Puesto);
        }

        // POST: Emp_Puesto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Emp_Puesto emp_Puesto = db.Emp_Puesto.Find(id);
            db.Emp_Puesto.Remove(emp_Puesto);
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
