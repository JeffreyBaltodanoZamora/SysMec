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
    public class UsuarioExternoController : Controller
    {
        private Entities db = new Entities();

        // GET: UsuarioExterno
        public ActionResult Index(String cedula)
        {
            int cedulaNum = -1;
            var usuario_encontrado = from s in db.Us_UsuarioExterno where s.i_PK_id_usuario == cedulaNum select s;
            if (!String.IsNullOrEmpty(cedula))
            {
                try { 
                cedulaNum = Convert.ToInt32(cedula);
                usuario_encontrado = usuario_encontrado.Where(j => j.i_PK_id_usuario == cedulaNum);
                }
                catch (Exception) { }
            }
            return View(usuario_encontrado);
        }

        [HttpPost]
        public ActionResult mostrarTodos()
        {
            var us_UsuarioExterno = db.Us_UsuarioExterno.Include(u => u.Estado);
            return View(us_UsuarioExterno.ToList());
        }

        // GET: UsuarioExterno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Us_UsuarioExterno us_UsuarioExterno = db.Us_UsuarioExterno.Find(id);
            if (us_UsuarioExterno == null)
            {
                return HttpNotFound();
            }
            return View(us_UsuarioExterno);
        }

        // GET: UsuarioExterno/Create
        public ActionResult Create()
        {
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            return View();
        }

        // POST: UsuarioExterno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_PK_id_usuario,vc_nombre,vc_apellido1,vc_apellido2,vc_direccion,vc_telefono,dt_nacimiento,vc_sexo,vc_email,vc_puesto,i_fk_estado")] Us_UsuarioExterno us_UsuarioExterno)
        {
            if (ModelState.IsValid)
            {
                db.Us_UsuarioExterno.Add(us_UsuarioExterno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", us_UsuarioExterno.i_fk_estado);
            return View(us_UsuarioExterno);
        }

        // GET: UsuarioExterno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Us_UsuarioExterno us_UsuarioExterno = db.Us_UsuarioExterno.Find(id);
            if (us_UsuarioExterno == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", us_UsuarioExterno.i_fk_estado);
            return View(us_UsuarioExterno);
        }

        // POST: UsuarioExterno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_PK_id_usuario,vc_nombre,vc_apellido1,vc_apellido2,vc_direccion,vc_telefono,dt_nacimiento,vc_sexo,vc_email,vc_puesto,i_fk_estado")] Us_UsuarioExterno us_UsuarioExterno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(us_UsuarioExterno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", us_UsuarioExterno.i_fk_estado);
            return View(us_UsuarioExterno);
        }

        // GET: UsuarioExterno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Us_UsuarioExterno us_UsuarioExterno = db.Us_UsuarioExterno.Find(id);
            if (us_UsuarioExterno == null)
            {
                return HttpNotFound();
            }
            return View(us_UsuarioExterno);
        }

        // POST: UsuarioExterno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Us_UsuarioExterno us_UsuarioExterno = db.Us_UsuarioExterno.Find(id);
            db.Us_UsuarioExterno.Remove(us_UsuarioExterno);
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
