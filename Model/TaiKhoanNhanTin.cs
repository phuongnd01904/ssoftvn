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
    
    public partial class TaiKhoanNhanTin
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_NguoiDung { get; set; }
        public double SoTienNap { get; set; }
        public System.DateTime NgayNap { get; set; }
        public string NguoiNap { get; set; }
    
        public virtual sys_NguoiDung sys_NguoiDung { get; set; }
    }
}
