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
    
    public partial class DM_TichDiem
    {
        public System.Guid ID { get; set; }
        public string MaTichDiem { get; set; }
        public System.DateTime NgayBatDauApDung { get; set; }
        public double TienThuVe_Min { get; set; }
        public Nullable<double> TienThuVe_Max { get; set; }
        public double DiemQuyDoi { get; set; }
        public double MucDiem { get; set; }
        public double TienThanhToanQuyDoi { get; set; }
        public double DiemToiThieu { get; set; }
        public double TienToiThieu { get; set; }
        public string ID_DonVi { get; set; }
        public string NhomKhachHang { get; set; }
        public string ChungTu { get; set; }
        public string ThuTrongTuan { get; set; }
        public bool ApDung { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string UserLap { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public string UserSuaCuoi { get; set; }
        public Nullable<bool> ApDung_NguoiGioiThieu { get; set; }
    }
}
