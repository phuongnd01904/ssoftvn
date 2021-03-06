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
    
    public partial class DM_DonVi
    {
        public DM_DonVi()
        {
            this.BH_DonBanHang = new HashSet<BH_DonBanHang>();
            this.BH_DonMuaHang = new HashSet<BH_DonMuaHang>();
            this.BH_MuaHang = new HashSet<BH_MuaHang>();
            this.ChietKhauMacDinh_NhanVien = new HashSet<ChietKhauMacDinh_NhanVien>();
            this.DieuChuyenKhoes = new HashSet<DieuChuyenKho>();
            this.DM_GiaBan = new HashSet<DM_GiaBan>();
            this.DM_KhuyenMai = new HashSet<DM_KhuyenMai>();
            this.HangDoiTraLais = new HashSet<HangDoiTraLai>();
            this.HangTraLaiNhaCungCaps = new HashSet<HangTraLaiNhaCungCap>();
            this.HoaDonBans = new HashSet<HoaDonBan>();
            this.HoaDonBanLes = new HashSet<HoaDonBanLe>();
            this.KH_KiemKe = new HashSet<KH_KiemKe>();
            this.KH_NhapKho = new HashSet<KH_NhapKho>();
            this.KH_XuatKho = new HashSet<KH_XuatKho>();
            this.NS_QuaTrinhCongTac = new HashSet<NS_QuaTrinhCongTac>();
            this.PhieuChis = new HashSet<PhieuChi>();
            this.PhieuThus = new HashSet<PhieuThu>();
            this.TonQuyKhoiTaos = new HashSet<TonQuyKhoiTao>();
        }
    
        public System.Guid ID { get; set; }
        public string MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public Nullable<System.Guid> ID_Parent { get; set; }
        public string DiaChi { get; set; }
        public string Website { get; set; }
        public string MaSoThue { get; set; }
        public string SoTaiKhoan { get; set; }
        public Nullable<System.Guid> ID_NganHang { get; set; }
        public string SoDienThoai { get; set; }
        public string SoFax { get; set; }
        public string KiTuDanhMa { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
        public Nullable<bool> HienThi_Chinh { get; set; }
        public Nullable<bool> HienThi_Phu { get; set; }
    
        public virtual ICollection<BH_DonBanHang> BH_DonBanHang { get; set; }
        public virtual ICollection<BH_DonMuaHang> BH_DonMuaHang { get; set; }
        public virtual ICollection<BH_MuaHang> BH_MuaHang { get; set; }
        public virtual ICollection<ChietKhauMacDinh_NhanVien> ChietKhauMacDinh_NhanVien { get; set; }
        public virtual ICollection<DieuChuyenKho> DieuChuyenKhoes { get; set; }
        public virtual ICollection<DM_GiaBan> DM_GiaBan { get; set; }
        public virtual ICollection<DM_KhuyenMai> DM_KhuyenMai { get; set; }
        public virtual ICollection<HangDoiTraLai> HangDoiTraLais { get; set; }
        public virtual ICollection<HangTraLaiNhaCungCap> HangTraLaiNhaCungCaps { get; set; }
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
        public virtual ICollection<HoaDonBanLe> HoaDonBanLes { get; set; }
        public virtual ICollection<KH_KiemKe> KH_KiemKe { get; set; }
        public virtual ICollection<KH_NhapKho> KH_NhapKho { get; set; }
        public virtual ICollection<KH_XuatKho> KH_XuatKho { get; set; }
        public virtual ICollection<NS_QuaTrinhCongTac> NS_QuaTrinhCongTac { get; set; }
        public virtual ICollection<PhieuChi> PhieuChis { get; set; }
        public virtual ICollection<PhieuThu> PhieuThus { get; set; }
        public virtual ICollection<TonQuyKhoiTao> TonQuyKhoiTaos { get; set; }
    }
}
