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
    
    public partial class NS_PhuCapNhanVien
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_NhanVien { get; set; }
        public System.Guid ID_KhoanPhuCap { get; set; }
        public double PhuCap { get; set; }
        public bool LaPT { get; set; }
        public System.DateTime NgayApDung { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public string GhiChu { get; set; }
    }
}
