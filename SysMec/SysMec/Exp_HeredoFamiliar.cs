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
    
    public partial class Exp_HeredoFamiliar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exp_HeredoFamiliar()
        {
            this.Cat_ExpMedico = new HashSet<Cat_ExpMedico>();
        }
    
        public int i_Pk_HereFamiliar { get; set; }
        public string vc_Piel { get; set; }
        public string vc_ApaRespiratorio { get; set; }
        public string vc_ApaDigestivo { get; set; }
        public string vc_ApaGenetoUrinario { get; set; }
        public string vc_SisNervioso { get; set; }
        public string vc_SisMuscoEsque { get; set; }
        public string vc_SisEndocrino { get; set; }
        public string vc_SisCardio { get; set; }
        public string vc_Alergias { get; set; }
        public string vc_Cancer { get; set; }
        public string vc_ProbPsicosomaticos { get; set; }
        public string vc_PadeActual { get; set; }
        public string vc_otros { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_ExpMedico> Cat_ExpMedico { get; set; }
    }
}
