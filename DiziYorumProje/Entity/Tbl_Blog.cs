//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiziYorumProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Blog()
        {
            this.Tbl_Yorum = new HashSet<Tbl_Yorum>();
        }
    
        public int BlogID { get; set; }
        public string BlogBaslik { get; set; }
        public string BlogIcerik { get; set; }
        public Nullable<System.DateTime> BlogTarih { get; set; }
        public string BlogGorsel { get; set; }
        public Nullable<int> BlogTur { get; set; }
        public Nullable<int> BlogKategori { get; set; }
    
        public virtual Tbl_Kategori Tbl_Kategori { get; set; }
        public virtual Tbl_Tur Tbl_Tur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Yorum> Tbl_Yorum { get; set; }
    }
}
