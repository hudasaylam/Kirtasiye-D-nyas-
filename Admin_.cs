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
    
    public partial class Admin_
    {
        public int KisiID { get; set; }
        public int AdminID { get; set; }
    
        public virtual KISI KISI { get; set; }
    }
}
