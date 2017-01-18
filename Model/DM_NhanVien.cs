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
    
    public partial class DM_NhanVien
    {
        public DM_NhanVien()
        {
            this.BH_DonBanHang = new HashSet<BH_DonBanHang>();
            this.BH_DonMuaHang = new HashSet<BH_DonMuaHang>();
            this.BH_MuaHang = new HashSet<BH_MuaHang>();
            this.ChietKhauMacDinh_NhanVien = new HashSet<ChietKhauMacDinh_NhanVien>();
            this.HangDoiTraLais = new HashSet<HangDoiTraLai>();
            this.HangTraLaiNhaCungCaps = new HashSet<HangTraLaiNhaCungCap>();
            this.HoaDonBans = new HashSet<HoaDonBan>();
            this.HoaDonBanLes = new HashSet<HoaDonBanLe>();
            this.KH_KiemKe = new HashSet<KH_KiemKe>();
            this.KH_NhapKho = new HashSet<KH_NhapKho>();
            this.KH_XuatKho = new HashSet<KH_XuatKho>();
            this.NhanVienThucHiens = new HashSet<NhanVienThucHien>();
            this.NhanVienTuVans = new HashSet<NhanVienTuVan>();
            this.NS_ChamCong_ChiTiet = new HashSet<NS_ChamCong_ChiTiet>();
            this.NS_QuaTrinhCongTac = new HashSet<NS_QuaTrinhCongTac>();
            this.PhieuChis = new HashSet<PhieuChi>();
            this.PhieuThus = new HashSet<PhieuThu>();
        }
    
        public System.Guid ID { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string NguyenQuan { get; set; }
        public string ThuongTru { get; set; }
        public string TamTru { get; set; }
        public string DienThoaiCoQuan { get; set; }
        public string DienThoaiNhaRieng { get; set; }
        public string DienThoaiDiDong { get; set; }
        public string SoFax { get; set; }
        public string DiaChiCoQuan { get; set; }
        public string SoCMND { get; set; }
        public string SoBHXH { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public byte[] Anh { get; set; }
        public Nullable<bool> CapTaiKhoan { get; set; }
        public string GhiChu { get; set; }
        public bool DaNghiViec { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
        public Nullable<bool> LaPTCK_The { get; set; }
        public Nullable<double> PT_TienCKBanThe { get; set; }
        public Nullable<bool> LaThoChinh { get; set; }
        public Nullable<System.DateTime> NgayCap { get; set; }
        public string NoiCap { get; set; }
        public Nullable<bool> LuongTuVanTheoDoanhThu { get; set; }
    
        public virtual ICollection<BH_DonBanHang> BH_DonBanHang { get; set; }
        public virtual ICollection<BH_DonMuaHang> BH_DonMuaHang { get; set; }
        public virtual ICollection<BH_MuaHang> BH_MuaHang { get; set; }
        public virtual ICollection<ChietKhauMacDinh_NhanVien> ChietKhauMacDinh_NhanVien { get; set; }
        public virtual ICollection<HangDoiTraLai> HangDoiTraLais { get; set; }
        public virtual ICollection<HangTraLaiNhaCungCap> HangTraLaiNhaCungCaps { get; set; }
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
        public virtual ICollection<HoaDonBanLe> HoaDonBanLes { get; set; }
        public virtual ICollection<KH_KiemKe> KH_KiemKe { get; set; }
        public virtual ICollection<KH_NhapKho> KH_NhapKho { get; set; }
        public virtual ICollection<KH_XuatKho> KH_XuatKho { get; set; }
        public virtual ICollection<NhanVienThucHien> NhanVienThucHiens { get; set; }
        public virtual ICollection<NhanVienTuVan> NhanVienTuVans { get; set; }
        public virtual ICollection<NS_ChamCong_ChiTiet> NS_ChamCong_ChiTiet { get; set; }
        public virtual ICollection<NS_QuaTrinhCongTac> NS_QuaTrinhCongTac { get; set; }
        public virtual ICollection<PhieuChi> PhieuChis { get; set; }
        public virtual ICollection<PhieuThu> PhieuThus { get; set; }
    }
}
