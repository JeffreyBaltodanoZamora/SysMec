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
    
    public partial class Exp_AnteQuirurTrauma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exp_AnteQuirurTrauma()
        {
            this.Cat_ExpMedico = new HashSet<Cat_ExpMedico>();
        }
    
        public int i_Pk_QuirurTrauma { get; set; }
        public Nullable<bool> b_Fracturas { get; set; }
        public Nullable<System.DateTime> d_Fractura { get; set; }
        public string vc_FracDonde { get; set; }
        public Nullable<bool> b_Cirugias { get; set; }
        public Nullable<System.DateTime> d_Cirugia { get; set; }
        public string vc_CiruDonde { get; set; }
        public string vc_AcciNoLaborales { get; set; }
        public string vc_AcciLaborales { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_ExpMedico> Cat_ExpMedico { get; set; }
    }
}
