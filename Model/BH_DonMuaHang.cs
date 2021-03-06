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
    
    public partial class BH_DonMuaHang
    {
        public BH_DonMuaHang()
        {
            this.BH_DonMuaHang_ChiTiet = new HashSet<BH_DonMuaHang_ChiTiet>();
            this.BH_MuaHang = new HashSet<BH_MuaHang>();
        }
    
        public System.Guid ID { get; set; }
        public string SoDonHang { get; set; }
        public System.DateTime NgayDonHang { get; set; }
        public Nullable<System.DateTime> NgayGiaoHang { get; set; }
        public Nullable<System.Guid> ID_DoiTuong { get; set; }
        public Nullable<System.Guid> ID_LienHe { get; set; }
        public Nullable<System.Guid> ID_VanChuyen { get; set; }
        public Nullable<System.Guid> ID_HinhThucThanhToan { get; set; }
        public Nullable<System.Guid> ID_NgoaiTe { get; set; }
        public double TyGia { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string DienGiai { get; set; }
        public double TongTienHang { get; set; }
        public double TongChietKhau { get; set; }
        public double TongTienThue { get; set; }
        public double TongPhaiTra { get; set; }
        public double TongChiPhi { get; set; }
        public System.Guid ID_DonVi { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayVaoSo { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
        public Nullable<System.Guid> ID_NhanVien { get; set; }
        public Nullable<int> ChuaDuyet_Duyet_Huy { get; set; }
    
        public virtual ICollection<BH_DonMuaHang_ChiTiet> BH_DonMuaHang_ChiTiet { get; set; }
        public virtual DM_DoiTuong DM_DoiTuong { get; set; }
        public virtual DM_DonVi DM_DonVi { get; set; }
        public virtual DM_HinhThucThanhToan DM_HinhThucThanhToan { get; set; }
        public virtual DM_HinhThucVanChuyen DM_HinhThucVanChuyen { get; set; }
        public virtual DM_LienHe DM_LienHe { get; set; }
        public virtual DM_NhanVien DM_NhanVien { get; set; }
        public virtual DM_TienTe DM_TienTe { get; set; }
        public virtual ICollection<BH_MuaHang> BH_MuaHang { get; set; }
    }
}
