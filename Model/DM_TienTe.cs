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
    
    public partial class DM_TienTe
    {
        public DM_TienTe()
        {
            this.BH_DonBanHang = new HashSet<BH_DonBanHang>();
            this.BH_DonMuaHang = new HashSet<BH_DonMuaHang>();
            this.BH_MuaHang = new HashSet<BH_MuaHang>();
            this.DieuChuyenKhoes = new HashSet<DieuChuyenKho>();
            this.DM_TyGia = new HashSet<DM_TyGia>();
            this.HangDoiTraLais = new HashSet<HangDoiTraLai>();
            this.HangTraLaiNhaCungCaps = new HashSet<HangTraLaiNhaCungCap>();
            this.HoaDonBans = new HashSet<HoaDonBan>();
            this.HoaDonBanLes = new HashSet<HoaDonBanLe>();
            this.KH_NhapKho = new HashSet<KH_NhapKho>();
            this.KH_XuatKho = new HashSet<KH_XuatKho>();
            this.PhieuChis = new HashSet<PhieuChi>();
            this.PhieuThus = new HashSet<PhieuThu>();
            this.TheKhachHangs = new HashSet<TheKhachHang>();
            this.TonQuyKhoiTaos = new HashSet<TonQuyKhoiTao>();
        }
    
        public System.Guid ID { get; set; }
        public string MaNgoaiTe { get; set; }
        public string TenNgoaiTe { get; set; }
        public string GhiChu { get; set; }
        public System.Guid ID_QuocGia { get; set; }
        public bool LaNoiTe { get; set; }
        public string UserTao { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
    
        public virtual ICollection<BH_DonBanHang> BH_DonBanHang { get; set; }
        public virtual ICollection<BH_DonMuaHang> BH_DonMuaHang { get; set; }
        public virtual ICollection<BH_MuaHang> BH_MuaHang { get; set; }
        public virtual ICollection<DieuChuyenKho> DieuChuyenKhoes { get; set; }
        public virtual DM_QuocGia DM_QuocGia { get; set; }
        public virtual ICollection<DM_TyGia> DM_TyGia { get; set; }
        public virtual ICollection<HangDoiTraLai> HangDoiTraLais { get; set; }
        public virtual ICollection<HangTraLaiNhaCungCap> HangTraLaiNhaCungCaps { get; set; }
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
        public virtual ICollection<HoaDonBanLe> HoaDonBanLes { get; set; }
        public virtual ICollection<KH_NhapKho> KH_NhapKho { get; set; }
        public virtual ICollection<KH_XuatKho> KH_XuatKho { get; set; }
        public virtual ICollection<PhieuChi> PhieuChis { get; set; }
        public virtual ICollection<PhieuThu> PhieuThus { get; set; }
        public virtual ICollection<TheKhachHang> TheKhachHangs { get; set; }
        public virtual ICollection<TonQuyKhoiTao> TonQuyKhoiTaos { get; set; }
    }
}
