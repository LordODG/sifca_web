//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIFCA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LINEAINVENTARIO
    {
        public LINEAINVENTARIO()
        {
            this.LINEAINVENTARIOVARIABLE = new HashSet<LINEAINVENTARIOVARIABLE>();
            this.ESPECIE = new HashSet<ESPECIE>();
        }
    
        public System.Guid NROLINEAINVENTARIO { get; set; }
        public System.Guid NROFORMULARIO { get; set; }
        public System.Guid NROTIPOLINEAINV { get; set; }
    
        public virtual FORMULARIO FORMULARIO { get; set; }
        public virtual TIPOLINEAINVENTARIO TIPOLINEAINVENTARIO { get; set; }
        public virtual ICollection<LINEAINVENTARIOVARIABLE> LINEAINVENTARIOVARIABLE { get; set; }
        public virtual ICollection<ESPECIE> ESPECIE { get; set; }
    }
}