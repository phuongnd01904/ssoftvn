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
    
    public partial class SoTichDiem
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_KhachHang { get; set; }
        public Nullable<int> LoaiChungTu { get; set; }
        public Nullable<System.Guid> ID_ChungTu { get; set; }
        public System.Guid ID_PhieuThu { get; set; }
        public System.Guid ID_PhieuThuChiTiet { get; set; }
        public System.DateTime NgayPhieuThu { get; set; }
        public double SoTienPhieuThu { get; set; }
        public Nullable<double> SoDiemTuongUng { get; set; }
        public double SoTienQuyDoi { get; set; }
        public Nullable<System.Guid> ID_TichDiem { get; set; }
        public string UserTao { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<bool> LaNguoiGioiThieu { get; set; }
    }
}
