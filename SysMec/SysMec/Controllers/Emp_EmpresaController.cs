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
    public class Emp_EmpresaController : Controller
    {
        private Entities db = new Entities();

        // GET: Emp_Empresa
        public ActionResult Index()
        {
            return View(db.Emp_Empresa.ToList());
        }

        // GET: Emp_Empresa/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Empresa emp_Empresa = db.Emp_Empresa.Find(id);
            if (emp_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(emp_Empresa);
        }

        // GET: Emp_Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp_Empresa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vc_PK_id_empresa,vc_nombre_empresa,i_telefono")] Emp_Empresa emp_Empresa)
        {
            if (ModelState.IsValid)
            {
                db.Emp_Empresa.Add(emp_Empresa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp_Empresa);
        }

        // GET: Emp_Empresa/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Empresa emp_Empresa = db.Emp_Empresa.Find(id);
            if (emp_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(emp_Empresa);
        }

        // POST: Emp_Empresa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vc_PK_id_empresa,vc_nombre_empresa,i_telefono")] Emp_Empresa emp_Empresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp_Empresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp_Empresa);
        }

        // GET: Emp_Empresa/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Empresa emp_Empresa = db.Emp_Empresa.Find(id);
            if (emp_Empresa == null)
            {
                return HttpNotFound();
            }
            return View(emp_Empresa);
        }

        // POST: Emp_Empresa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Emp_Empresa emp_Empresa = db.Emp_Empresa.Find(id);
            db.Emp_Empresa.Remove(emp_Empresa);
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
