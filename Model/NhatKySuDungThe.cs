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
    
    public partial class NhatKySuDungThe
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_TheKhachHang { get; set; }
        public int LoaiChungTu { get; set; }
        public System.Guid ID_ChungTu { get; set; }
        public System.Guid ID_ChiTietChungTu { get; set; }
        public Nullable<double> SoLuong { get; set; }
        public Nullable<double> SoTien { get; set; }
        public Nullable<System.Guid> ID_NhanVien { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string UserName { get; set; }
        public Nullable<bool> LaSoLuongDuocTang { get; set; }
        public Nullable<System.Guid> ID_HangHoaDichVu { get; set; }
    
        public virtual TheKhachHang TheKhachHang { get; set; }
    }
}
