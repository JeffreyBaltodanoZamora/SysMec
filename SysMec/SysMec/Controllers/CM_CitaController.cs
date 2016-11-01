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
    public class CM_CitaController : Controller
    {
        private Entities db = new Entities();

        // GET: CM_Cita
        public ActionResult Index(string cedula)
        {
            //la busqueda debe ser por cedula y buscar tanto en funcionarios como en usuario externo
            int cedulaNum = -1;
            var usuario_encontrado = from s in db.CM_Cita where s.i_Fk_Funcionario == cedulaNum select s;
            
            if (!String.IsNullOrEmpty(cedula))
            {
                try
                {
                    var usuarioTemp = from u in db.Funcionarios where u.vc_Cedula == cedula select u;

                    foreach (var s in usuarioTemp)
                    {
                        usuario_encontrado = from p in db.CM_Cita where p.i_Fk_Funcionario == s.i_Pk_Funcionario select p;
                    }

                    if (usuarioTemp.Count() == 0)
                    {
                        var usuarioTemp2 = from a in db.CM_UsuarioExterno where a.vc_Cedula == cedula select a;

                        foreach (var s in usuarioTemp2)
                        {
                            usuario_encontrado = from p in db.CM_Cita where p.i_FK_idUsuExterno == s.i_Pk_idUsuExterno select p;
                        }
                    }
                }
                catch (Exception) { }
            }
            return View(usuario_encontrado);
        }

        // GET: CM_Cita/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_Cita cM_Cita = db.CM_Cita.Find(id);
            if (cM_Cita == null)
            {
                return HttpNotFound();
            }
            return View(cM_Cita);
        }

        // GET: CM_Cita/Create
        public ActionResult Create()
        {
            ViewBag.i_Fk_idEstCita = new SelectList(db.Cat_EstadoCita, "i_PK_idEstadoCita", "vc_DescEstado");
            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico");
            ViewBag.i_Fk_Funcionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula");
            ViewBag.vc_Nombre = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Nombre");
            ViewBag.vc_PrimerApellido = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_PrimerApellido");
            ViewBag.vc_SegundoApellido = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_SegundoApellido");
            return View();
        }

        // POST: CM_Cita/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_Pk_idCita,i_Fk_Funcionario,i_FK_idUsuExterno,i_Fk_idMedico,d_fechaCita,dt_HoraInicio,dt_HoraFin,i_Fk_idEstCita,vc_Obervacion,b_PrimeraVez")] CM_Cita cM_Cita)
        {
            if (ModelState.IsValid)
            {
                try { 
                    db.CM_Cita.Add(cM_Cita);
                    db.SaveChanges();
                }
                catch (Exception) { }
                return RedirectToAction("Index");
            }

            ViewBag.i_Fk_idEstCita = new SelectList(db.Cat_EstadoCita, "i_PK_idEstadoCita", "vc_DescEstado", cM_Cita.i_Fk_idEstCita);
            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico", cM_Cita.i_Fk_idMedico);
            ViewBag.i_FK_idUsuExterno = new SelectList(db.CM_UsuarioExterno, "i_Pk_idUsuExterno", "vc_Cedula", cM_Cita.i_FK_idUsuExterno);
            ViewBag.i_Fk_Funcionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula", cM_Cita.i_Fk_Funcionario);
            return View(cM_Cita);
        }

        // GET: CM_Cita/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_Cita cM_Cita = db.CM_Cita.Find(id);
            if (cM_Cita == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_Fk_idEstCita = new SelectList(db.Cat_EstadoCita, "i_PK_idEstadoCita", "vc_DescEstado", cM_Cita.i_Fk_idEstCita);
            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico", cM_Cita.i_Fk_idMedico);
            ViewBag.i_FK_idUsuExterno = new SelectList(db.CM_UsuarioExterno, "i_Pk_idUsuExterno", "vc_Cedula", cM_Cita.i_FK_idUsuExterno);
            ViewBag.i_Fk_Funcionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula", cM_Cita.i_Fk_Funcionario);
            return View(cM_Cita);
        }

        // POST: CM_Cita/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_Pk_idCita,i_Fk_Funcionario,i_FK_idUsuExterno,i_Fk_idMedico,d_fechaCita,dt_HoraInicio,dt_HoraFin,i_Fk_idEstCita,vc_Obervacion,b_PrimeraVez")] CM_Cita cM_Cita)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cM_Cita).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_Fk_idEstCita = new SelectList(db.Cat_EstadoCita, "i_PK_idEstadoCita", "vc_DescEstado", cM_Cita.i_Fk_idEstCita);
            ViewBag.i_Fk_idMedico = new SelectList(db.CM_Medico, "i_Pk_idMedico", "i_Pk_idMedico", cM_Cita.i_Fk_idMedico);
            ViewBag.i_FK_idUsuExterno = new SelectList(db.CM_UsuarioExterno, "i_Pk_idUsuExterno", "vc_Cedula", cM_Cita.i_FK_idUsuExterno);
            ViewBag.i_Fk_Funcionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula", cM_Cita.i_Fk_Funcionario);
            return View(cM_Cita);
        }

        // GET: CM_Cita/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CM_Cita cM_Cita = db.CM_Cita.Find(id);
            if (cM_Cita == null)
            {
                return HttpNotFound();
            }
            return View(cM_Cita);
        }

        // POST: CM_Cita/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CM_Cita cM_Cita = db.CM_Cita.Find(id);
            db.CM_Cita.Remove(cM_Cita);
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
