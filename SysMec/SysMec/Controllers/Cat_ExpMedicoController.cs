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
    public class Cat_ExpMedicoController : Controller
    {
        private Entities db = new Entities();

        // GET: Cat_ExpMedico
        public ActionResult Index(string id_expediente)
        {
            //la busqueda debe ser por la cedula del usuario y debe buscar en funcionarios y usuario externo
            int id_expedienteNum = -1;
            var busqueda = from s in db.Cat_ExpMedico where s.i_PK_ExpMedico == id_expedienteNum select s;
            if (!String.IsNullOrEmpty(id_expediente))
            {
                try
                {
                    var usuarioExterno = from s in db.CM_UsuarioExterno where s.vc_Cedula == id_expediente select s.i_Pk_idUsuExterno;
                    
                    if (usuarioExterno != null)
                    {
                        int Pk_usuarioExterno = Convert.ToInt32(usuarioExterno);
                        busqueda = from ex in db.Cat_ExpMedico where ex.i_FK_idUsuExterno == Pk_usuarioExterno select ex;
                    }
                    else
                    {
                        var usuarioFuncionario = from m in db.Funcionarios where m.vc_Cedula == id_expediente select m.i_Pk_Funcionario;
                        if (usuarioFuncionario != null)
                        {
                            int Pk_usuarioFuncionario = Convert.ToInt32(usuarioFuncionario);
                            busqueda = from ex in db.Cat_ExpMedico where ex.i_FK_idFuncionario == Pk_usuarioFuncionario select ex;

                        }
                    }
                }
                catch (Exception) { }
            }
            return View(busqueda);
        }

        // GET: Cat_ExpMedico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat_ExpMedico cat_ExpMedico = db.Cat_ExpMedico.Find(id);
            if (cat_ExpMedico == null)
            {
                return HttpNotFound();
            }
            return View(cat_ExpMedico);
        }

        // GET: Cat_ExpMedico/Create
        public ActionResult Create()
        {
            ViewBag.i_FK_idUsuExterno = new SelectList(db.CM_UsuarioExterno, "i_Pk_idUsuExterno", "vc_Cedula");
            ViewBag.i_fk_QuirTrauma = new SelectList(db.Exp_AnteQuirurTrauma, "i_Pk_QuirurTrauma", "vc_FracDonde");
            ViewBag.i_fk_AntPatoPersonales = new SelectList(db.Exp_AntPersoPatolog, "i_Pk_AntPatologicos", "vc_Piel");
            ViewBag.i_fk_GineObstetricos = new SelectList(db.Exp_GinecoObstreticos, "i_Pk_idGinObste", "vc_Menarca");
            ViewBag.i_fk_HereFamiliar = new SelectList(db.Exp_HeredoFamiliar, "i_Pk_HereFamiliar", "vc_Piel");
            ViewBag.i_FK_idFuncionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula");
            return View();
        }

        // POST: Cat_ExpMedico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "i_PK_ExpMedico,i_FK_idFuncionario,i_FK_idUsuExterno,d_ExpMedico,i_fk_GineObstetricos,i_fk_HereFamiliar,i_fk_QuirTrauma,i_fk_AntPatoPersonales,b_Estado")] Cat_ExpMedico cat_ExpMedico)
        {
            if (ModelState.IsValid)
            {
                db.Cat_ExpMedico.Add(cat_ExpMedico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.i_FK_idUsuExterno = new SelectList(db.CM_UsuarioExterno, "i_Pk_idUsuExterno", "vc_Cedula", cat_ExpMedico.i_FK_idUsuExterno);
            ViewBag.i_fk_QuirTrauma = new SelectList(db.Exp_AnteQuirurTrauma, "i_Pk_QuirurTrauma", "vc_FracDonde", cat_ExpMedico.i_fk_QuirTrauma);
            ViewBag.i_fk_AntPatoPersonales = new SelectList(db.Exp_AntPersoPatolog, "i_Pk_AntPatologicos", "vc_Piel", cat_ExpMedico.i_fk_AntPatoPersonales);
            ViewBag.i_fk_GineObstetricos = new SelectList(db.Exp_GinecoObstreticos, "i_Pk_idGinObste", "vc_Menarca", cat_ExpMedico.i_fk_GineObstetricos);
            ViewBag.i_fk_HereFamiliar = new SelectList(db.Exp_HeredoFamiliar, "i_Pk_HereFamiliar", "vc_Piel", cat_ExpMedico.i_fk_HereFamiliar);
            ViewBag.i_FK_idFuncionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula", cat_ExpMedico.i_FK_idFuncionario);
            return View(cat_ExpMedico);
        }

        // GET: Cat_ExpMedico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat_ExpMedico cat_ExpMedico = db.Cat_ExpMedico.Find(id);
            if (cat_ExpMedico == null)
            {
                return HttpNotFound();
            }
            ViewBag.i_FK_idUsuExterno = new SelectList(db.CM_UsuarioExterno, "i_Pk_idUsuExterno", "vc_Cedula", cat_ExpMedico.i_FK_idUsuExterno);
            ViewBag.i_fk_QuirTrauma = new SelectList(db.Exp_AnteQuirurTrauma, "i_Pk_QuirurTrauma", "vc_FracDonde", cat_ExpMedico.i_fk_QuirTrauma);
            ViewBag.i_fk_AntPatoPersonales = new SelectList(db.Exp_AntPersoPatolog, "i_Pk_AntPatologicos", "vc_Piel", cat_ExpMedico.i_fk_AntPatoPersonales);
            ViewBag.i_fk_GineObstetricos = new SelectList(db.Exp_GinecoObstreticos, "i_Pk_idGinObste", "vc_Menarca", cat_ExpMedico.i_fk_GineObstetricos);
            ViewBag.i_fk_HereFamiliar = new SelectList(db.Exp_HeredoFamiliar, "i_Pk_HereFamiliar", "vc_Piel", cat_ExpMedico.i_fk_HereFamiliar);
            ViewBag.i_FK_idFuncionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula", cat_ExpMedico.i_FK_idFuncionario);
            return View(cat_ExpMedico);
        }

        // POST: Cat_ExpMedico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "i_PK_ExpMedico,i_FK_idFuncionario,i_FK_idUsuExterno,d_ExpMedico,i_fk_GineObstetricos,i_fk_HereFamiliar,i_fk_QuirTrauma,i_fk_AntPatoPersonales,b_Estado")] Cat_ExpMedico cat_ExpMedico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cat_ExpMedico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.i_FK_idUsuExterno = new SelectList(db.CM_UsuarioExterno, "i_Pk_idUsuExterno", "vc_Cedula", cat_ExpMedico.i_FK_idUsuExterno);
            ViewBag.i_fk_QuirTrauma = new SelectList(db.Exp_AnteQuirurTrauma, "i_Pk_QuirurTrauma", "vc_FracDonde", cat_ExpMedico.i_fk_QuirTrauma);
            ViewBag.i_fk_AntPatoPersonales = new SelectList(db.Exp_AntPersoPatolog, "i_Pk_AntPatologicos", "vc_Piel", cat_ExpMedico.i_fk_AntPatoPersonales);
            ViewBag.i_fk_GineObstetricos = new SelectList(db.Exp_GinecoObstreticos, "i_Pk_idGinObste", "vc_Menarca", cat_ExpMedico.i_fk_GineObstetricos);
            ViewBag.i_fk_HereFamiliar = new SelectList(db.Exp_HeredoFamiliar, "i_Pk_HereFamiliar", "vc_Piel", cat_ExpMedico.i_fk_HereFamiliar);
            ViewBag.i_FK_idFuncionario = new SelectList(db.Funcionarios, "i_Pk_Funcionario", "vc_Cedula", cat_ExpMedico.i_FK_idFuncionario);
            return View(cat_ExpMedico);
        }

        // GET: Cat_ExpMedico/Delete/5
        public ActionResult Delete(int? id)
        {
            Cat_ExpMedico exp_Medico = db.Cat_ExpMedico.Find(id);

            var r = from b in db.Cat_ExpMedico
                    where b.i_PK_ExpMedico == id
                    select b;

            foreach (var t in r)
            {
                if (t.b_Estado == true)//valida si esta desactivado; 2 es la llave primaria de la tabla estado, representa "Desactivado"
                    t.b_Estado = false; // 3 representa "desactivado"
                else
                    t.b_Estado = true;
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Cat_ExpMedico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cat_ExpMedico cat_ExpMedico = db.Cat_ExpMedico.Find(id);
            db.Cat_ExpMedico.Remove(cat_ExpMedico);
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
