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
    
    public partial class GiaoCaLamViec
    {
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.Guid> ID_NhanVienGiaoCa { get; set; }
        public Nullable<System.Guid> ID_NhanVien { get; set; }
        public Nullable<System.DateTime> NgayGioKetThuc { get; set; }
        public Nullable<System.Guid> ID_NhanVienKetThuc { get; set; }
        public Nullable<double> SoTienGiaoCa { get; set; }
        public Nullable<double> SoTienHoaDon { get; set; }
        public Nullable<double> SoTienKetThucCa { get; set; }
        public Nullable<bool> KetThucCa { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
    }
}