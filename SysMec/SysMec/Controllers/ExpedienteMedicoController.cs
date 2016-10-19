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
    public class ExpedienteMedicoController : Controller
    {
        private Entities db = new Entities();

        // GET: ExpedienteMedico
        public ActionResult Index(string id_expediente)
        {
            int id_expedienteNum = -1;
            var usuario_encontrado = from s in db.Exp_Medico where s.i_PK_ExpMedico == id_expedienteNum select s;
            if (!String.IsNullOrEmpty(id_expediente))
            {
                try
                {
                    id_expedienteNum = Convert.ToInt32(id_expediente);
                    usuario_encontrado = usuario_encontrado.Where(j => j.i_PK_ExpMedico == id_expedienteNum);
                }
                catch (Exception) { }
            }
            return View(usuario_encontrado);
        }

        // GET: ExpedienteMedico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_Medico exp_Medico = db.Exp_Medico.Find(id);
            if (exp_Medico == null)
            {
                return HttpNotFound();
            }
            return View(exp_Medico);
        }

        // GET: ExpedienteMedico/Create
        public ActionResult Create()
        {
            ViewBag.i_fk_antecents_patologicos_personales = new SelectList(db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS, "i_pk_antecents_patologicos", "vc_piel");
            ViewBag.i_fk_quirurgicos_traumati = new SelectList(db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS, "i_pk_quirurgicos_traumati", "vc_fracturas");
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion");
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel");
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel");
            ViewBag.i_fk_id_medico = new SelectList(db.Med_Medico, "i_pk_id_medico", "vc_Nombre_medico");
            ViewBag.i_FK_id_usuario = new SelectList(db.Us_UsuarioExterno, "i_PK_id_usuario", "vc_nombre");
            return View();
        }

        // POST: ExpedienteMedico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_PK_ExpMedico,i_FK_id_usuario,i_fk_id_medico,dt_expMedico,i_fk_estado,i_fk_antecents_patologicos,i_fk_gineco_obstetricos,i_fk_heredo_famili,i_fk_quirurgicos_traumati,i_fk_antecents_patologicos_personales")] Exp_Medico exp_Medico)
        {
            if (ModelState.IsValid)
            {
                db.Exp_Medico.Add(exp_Medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.i_fk_antecents_patologicos_personales = new SelectList(db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS, "i_pk_antecents_patologicos", "vc_piel", exp_Medico.i_fk_antecents_patologicos_personales);
            ViewBag.i_fk_quirurgicos_traumati = new SelectList(db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS, "i_pk_quirurgicos_traumati", "vc_fracturas", exp_Medico.i_fk_quirurgicos_traumati);
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", exp_Medico.i_fk_estado);
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel", exp_Medico.i_fk_heredo_famili);
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel", exp_Medico.i_fk_heredo_famili);
            ViewBag.i_fk_id_medico = new SelectList(db.Med_Medico, "i_pk_id_medico", "vc_Nombre_medico", exp_Medico.i_fk_id_medico);
            ViewBag.i_FK_id_usuario = new SelectList(db.Us_UsuarioExterno, "i_PK_id_usuario", "vc_nombre", exp_Medico.i_FK_id_usuario);
            return View(exp_Medico);
        }

        // GET: ExpedienteMedico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_Medico exp_Medico = db.Exp_Medico.Find(id);
            if (exp_Medico == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_fk_antecents_patologicos_personales = new SelectList(db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS, "i_pk_antecents_patologicos", "vc_piel", exp_Medico.i_fk_antecents_patologicos_personales);
            ViewBag.i_fk_quirurgicos_traumati = new SelectList(db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS, "i_pk_quirurgicos_traumati", "vc_fracturas", exp_Medico.i_fk_quirurgicos_traumati);
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", exp_Medico.i_fk_estado);
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel", exp_Medico.i_fk_heredo_famili);
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel", exp_Medico.i_fk_heredo_famili);
            ViewBag.i_fk_id_medico = new SelectList(db.Med_Medico, "i_pk_id_medico", "vc_Nombre_medico", exp_Medico.i_fk_id_medico);
            ViewBag.i_FK_id_usuario = new SelectList(db.Us_UsuarioExterno, "i_PK_id_usuario", "vc_nombre", exp_Medico.i_FK_id_usuario);
            return View(exp_Medico);
        }

        // POST: ExpedienteMedico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_PK_ExpMedico,i_FK_id_usuario,i_fk_id_medico,dt_expMedico,i_fk_estado,i_fk_antecents_patologicos,i_fk_gineco_obstetricos,i_fk_heredo_famili,i_fk_quirurgicos_traumati,i_fk_antecents_patologicos_personales")] Exp_Medico exp_Medico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exp_Medico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_fk_antecents_patologicos_personales = new SelectList(db.CM_CAT_ANTECEDENTES_PER_PATOLOGICOS, "i_pk_antecents_patologicos", "vc_piel", exp_Medico.i_fk_antecents_patologicos_personales);
            ViewBag.i_fk_quirurgicos_traumati = new SelectList(db.CM_EXP_ANTECEDENTES_QUIRURGICOS_TRAUMATICOS, "i_pk_quirurgicos_traumati", "vc_fracturas", exp_Medico.i_fk_quirurgicos_traumati);
            ViewBag.i_fk_estado = new SelectList(db.Estado, "i_pk_estado", "vc_descripcion", exp_Medico.i_fk_estado);
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel", exp_Medico.i_fk_heredo_famili);
            ViewBag.i_fk_heredo_famili = new SelectList(db.Heredo_familiar, "i_pk_heredo_famili", "vc_piel", exp_Medico.i_fk_heredo_famili);
            ViewBag.i_fk_id_medico = new SelectList(db.Med_Medico, "i_pk_id_medico", "vc_Nombre_medico", exp_Medico.i_fk_id_medico);
            ViewBag.i_FK_id_usuario = new SelectList(db.Us_UsuarioExterno, "i_PK_id_usuario", "vc_nombre", exp_Medico.i_FK_id_usuario);
            return View(exp_Medico);
        }

        // GET: ExpedienteMedico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exp_Medico exp_Medico = db.Exp_Medico.Find(id);
            if (exp_Medico == null)
            {
                return HttpNotFound();
            }
            return View(exp_Medico);
        }

        // POST: ExpedienteMedico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exp_Medico exp_Medico = db.Exp_Medico.Find(id);
            db.Exp_Medico.Remove(exp_Medico);
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
