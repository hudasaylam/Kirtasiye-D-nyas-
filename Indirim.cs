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
    
    public partial class Indirim
    {
        public int IndirimNo { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> YeniFiyat { get; set; }
    
        public virtual Urun Urun { get; set; }
    }
}
