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
    
    public partial class Tbl_Yorum
    {
        public int YorumID { get; set; }
        public string KullaniciAd { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public Nullable<int> YorumBlog { get; set; }
    
        public virtual Tbl_Blog Tbl_Blog { get; set; }
    }
}
