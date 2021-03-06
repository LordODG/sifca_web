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
    
    public partial class ESPECIE
    {
        public ESPECIE()
        {
            this.IMAGEN = new HashSet<IMAGEN>();
            this.LINEAINVENTARIO = new HashSet<LINEAINVENTARIO>();
            this.PROYECTO = new HashSet<PROYECTO>();
        }
    
        public System.Guid CODESP { get; set; }
        public string GRUPOCOM { get; set; }
        public string NOMCOMUN { get; set; }
        public string NOMCIENTIFICO { get; set; }
        public string FAMILIA { get; set; }
        public string ZONAGEOGRAFICA { get; set; }
        public string ZONADEVIDA { get; set; }
        public Nullable<double> DIAMMINCORTE { get; set; }
        public string GRUPOECOLOGICO { get; set; }
    
        public virtual GRUPOCOMERCIAL GRUPOCOMERCIAL { get; set; }
        public virtual ICollection<IMAGEN> IMAGEN { get; set; }
        public virtual ICollection<LINEAINVENTARIO> LINEAINVENTARIO { get; set; }
        public virtual ICollection<PROYECTO> PROYECTO { get; set; }
    }
}
