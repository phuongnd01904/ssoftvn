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
    
    public partial class PhieuThuChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_PhieuThu { get; set; }
        public System.Guid ID_KhoanThu { get; set; }
        public Nullable<System.Guid> ID_KhachHang { get; set; }
        public string GhiChu { get; set; }
        public double TienThu { get; set; }
        public Nullable<System.Guid> ID_TheThoanhToan { get; set; }
        public double ThuTuThe { get; set; }
        public double TienGui { get; set; }
        public double TienMat { get; set; }
        public Nullable<System.Guid> ID_ChungTu { get; set; }
        public Nullable<int> LoaiCT { get; set; }
        public Nullable<double> ChiPhiNganHang { get; set; }
        public Nullable<System.Guid> ID_NganHang { get; set; }
        public Nullable<bool> LaPTChiPhiNganHang { get; set; }
        public string DiaChi_KhachHang { get; set; }
        public Nullable<bool> ThuPhiTienGui { get; set; }
    
        public virtual DM_DoiTuong DM_DoiTuong { get; set; }
        public virtual KhoanThuChi KhoanThuChi { get; set; }
        public virtual PhieuThu PhieuThu { get; set; }
    }
}
