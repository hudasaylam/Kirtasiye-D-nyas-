//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KirtasiyeDunayasi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fatura()
        {
            this.Siparis = new HashSet<Sipari>();
        }
    
        public int FaturaID { get; set; }
        public Nullable<System.DateTime> faturaTarihi { get; set; }
        public Nullable<double> ToplamFiyat { get; set; }
        public int KisiID { get; set; }
    
        public virtual KULLANCILAR KULLANCILAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sipari> Siparis { get; set; }
    }
}