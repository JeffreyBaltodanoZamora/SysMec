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
    public class Us_UsuarioController : Controller
    {
        private Entities db = new Entities();

        // GET: Us_Usuario
        public ActionResult Index()
        {
            var us_Usuario = db.Us_Usuario.Include(u => u.Emp_Puesto);
            return View(us_Usuario.ToList());
        }

        // GET: Us_Usuario/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Us_Usuario us_Usuario = db.Us_Usuario.Find(id);
            if (us_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(us_Usuario);
        }

        // GET: Us_Usuario/Create
        public ActionResult Create()
        {
            ViewBag.vc_id_puesto = new SelectList(db.Emp_Puesto, "vc_PK_id_puesto", "vc_nombre_puesto");
            return View();
        }

        // POST: Us_Usuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "vc_Pk_id_usuario,vc_clave,vc_nombre,vc_apellido,vc_direccion,vc_telefono,dt_nacimiento,c_sexo,vc_email,vc_id_puesto,vc_estado_civil,vc_padre,vc_madre")] Us_Usuario us_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.Us_Usuario.Add(us_Usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.vc_id_puesto = new SelectList(db.Emp_Puesto, "vc_PK_id_puesto", "vc_nombre_puesto", us_Usuario.vc_id_puesto);
            return View(us_Usuario);
        }

        // GET: Us_Usuario/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Us_Usuario us_Usuario = db.Us_Usuario.Find(id);
            if (us_Usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.vc_id_puesto = new SelectList(db.Emp_Puesto, "vc_PK_id_puesto", "vc_nombre_puesto", us_Usuario.vc_id_puesto);
            return View(us_Usuario);
        }

        // POST: Us_Usuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "vc_Pk_id_usuario,vc_clave,vc_nombre,vc_apellido,vc_direccion,vc_telefono,dt_nacimiento,c_sexo,vc_email,vc_id_puesto,vc_estado_civil,vc_padre,vc_madre")] Us_Usuario us_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(us_Usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.vc_id_puesto = new SelectList(db.Emp_Puesto, "vc_PK_id_puesto", "vc_nombre_puesto", us_Usuario.vc_id_puesto);
            return View(us_Usuario);
        }

        // GET: Us_Usuario/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Us_Usuario us_Usuario = db.Us_Usuario.Find(id);
            if (us_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(us_Usuario);
        }

        // POST: Us_Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Us_Usuario us_Usuario = db.Us_Usuario.Find(id);
            db.Us_Usuario.Remove(us_Usuario);
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
