﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysMec
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ci_Cita> Ci_Cita { get; set; }
        public virtual DbSet<Diag_Diagnostico> Diag_Diagnostico { get; set; }
        public virtual DbSet<Emp_Empresa> Emp_Empresa { get; set; }
        public virtual DbSet<Emp_Puesto> Emp_Puesto { get; set; }
        public virtual DbSet<Ex_Examen_Diagnostico> Ex_Examen_Diagnostico { get; set; }
        public virtual DbSet<Exp_Expediente> Exp_Expediente { get; set; }
        public virtual DbSet<Fnc_Funcion> Fnc_Funcion { get; set; }
        public virtual DbSet<Med_Medico> Med_Medico { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Us_Usuario> Us_Usuario { get; set; }
        public virtual DbSet<Enc_Comprobante> Enc_Comprobante { get; set; }
    }
}
