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
    public class CM_UsuarioExternoController : Controller
    {
        private Entities db = new Entities();

        // GET: CM_UsuarioExterno
        public ActionResult Index(String cedula)
        {
            String cedulaNum =" ";
            var usuario_encontrado = from s in db.CM_UsuarioExterno where s.vc_Cedula == cedulaNum select s;
            if (!String.IsNullOrEmpty(cedula))
            {
                try
                {
                    
                    usuario_encontrado = usuario_encontrado.Where(j => j.vc_Cedula == cedulaNum);
                }
                catch (Exception) { }
            }
            return View(usuario_encontrado);
            
        }

        [HttpPost]
        public ActionResult mostrarTodos()
        {
            var us_UsuarioExterno = db.CM_UsuarioExterno.Include(u => u.vc_Cedula);
            return View(us_UsuarioExterno.ToList());
        }



        // GET: CM_UsuarioExterno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_UsuarioExterno cM_UsuarioExterno = db.CM_UsuarioExterno.Find(id);
            if (cM_UsuarioExterno == null)
            {
                return HttpNotFound();
            }
            return View(cM_UsuarioExterno);
        }

        // GET: CM_UsuarioExterno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CM_UsuarioExterno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_Pk_idUsuExterno,vc_Cedula,vc_Nombre,vc_PriApellido,vc_SegApellido,vc_Telefono,vc_Movil,vc_Sexo,vc_Email,vc_Empresa")] CM_UsuarioExterno cM_UsuarioExterno)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.CM_UsuarioExterno.Add(cM_UsuarioExterno);
                    db.SaveChanges();
                }
                catch (Exception) { }
                return RedirectToAction("Index");
            }

            return View(cM_UsuarioExterno);
        }

        // GET: CM_UsuarioExterno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_UsuarioExterno cM_UsuarioExterno = db.CM_UsuarioExterno.Find(id);
            if (cM_UsuarioExterno == null)
            {
                return HttpNotFound();
            }
            return View(cM_UsuarioExterno);
        }

        // POST: CM_UsuarioExterno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_Pk_idUsuExterno,vc_Cedula,vc_Nombre,vc_PriApellido,vc_SegApellido,vc_Telefono,vc_Movil,vc_Sexo,vc_Email,vc_Empresa")] CM_UsuarioExterno cM_UsuarioExterno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cM_UsuarioExterno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cM_UsuarioExterno);
        }

        // GET: CM_UsuarioExterno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_UsuarioExterno cM_UsuarioExterno = db.CM_UsuarioExterno.Find(id);
            if (cM_UsuarioExterno == null)
            {
                return HttpNotFound();
            }
            return View(cM_UsuarioExterno);
        }

        // POST: CM_UsuarioExterno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CM_UsuarioExterno cM_UsuarioExterno = db.CM_UsuarioExterno.Find(id);
            db.CM_UsuarioExterno.Remove(cM_UsuarioExterno);
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
