//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiftlikOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hayvan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hayvan()
        {
            this.StokHareket = new HashSet<StokHareket>();
            this.SutUretim = new HashSet<SutUretim>();
        }
    
        public int HayvanID { get; set; }
        public string KupeNo { get; set; }
        public int CinsId { get; set; }
        public decimal Agirlik { get; set; }
        public System.DateTime OlcumTarihi { get; set; }
    
        public virtual Cins Cins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StokHareket> StokHareket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SutUretim> SutUretim { get; set; }
    }
}
