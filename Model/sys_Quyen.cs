//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class sys_Quyen
    {
        public sys_Quyen()
        {
            this.sys_QuyenNhom = new HashSet<sys_QuyenNhom>();
        }
    
        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string MoTa { get; set; }
        public string QuyenCha { get; set; }
        public Nullable<bool> DuocSuDung { get; set; }
    
        public virtual ICollection<sys_QuyenNhom> sys_QuyenNhom { get; set; }
    }
}
