//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CM_Cita
    {
        public int i_Pk_idCita { get; set; }
        public Nullable<int> i_Fk_Funcionario { get; set; }
        public Nullable<int> i_FK_idUsuExterno { get; set; }
        public int i_Fk_idMedico { get; set; }
        public System.DateTime d_fechaCita { get; set; }
        public System.TimeSpan dt_HoraInicio { get; set; }
        public Nullable<System.TimeSpan> dt_HoraFin { get; set; }
        public Nullable<int> i_Fk_idEstCita { get; set; }
        public string vc_Obervacion { get; set; }
        public bool b_PrimeraVez { get; set; }
    
        public virtual Cat_EstadoCita Cat_EstadoCita { get; set; }
        public virtual CM_Medico CM_Medico { get; set; }
        public virtual CM_UsuarioExterno CM_UsuarioExterno { get; set; }
        public virtual Funcionarios Funcionarios { get; set; }
    }
}
