//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneBlog.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_YORUM
    {
        public int YORUMID { get; set; }
        public string KULLANICIAD { get; set; }
        public string MAIL { get; set; }
        public string YORUMICERIK { get; set; }
        public Nullable<int> YORUMBLOG { get; set; }
    
        public virtual TBL_BLOG TBL_BLOG { get; set; }
    }
}
