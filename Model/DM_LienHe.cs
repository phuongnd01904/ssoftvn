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
    
    public partial class DM_LienHe
    {
        public DM_LienHe()
        {
            this.BH_DonBanHang = new HashSet<BH_DonBanHang>();
            this.BH_DonMuaHang = new HashSet<BH_DonMuaHang>();
            this.HangTraLaiNhaCungCaps = new HashSet<HangTraLaiNhaCungCap>();
            this.HoaDonBans = new HashSet<HoaDonBan>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid ID_DoiTuong { get; set; }
        public string MaLienHe { get; set; }
        public string TenLienHe { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
        public string DiaChi { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string CanNang { get; set; }
        public string ChieuCao { get; set; }
    
        public virtual ICollection<BH_DonBanHang> BH_DonBanHang { get; set; }
        public virtual ICollection<BH_DonMuaHang> BH_DonMuaHang { get; set; }
        public virtual DM_DoiTuong DM_DoiTuong { get; set; }
        public virtual ICollection<HangTraLaiNhaCungCap> HangTraLaiNhaCungCaps { get; set; }
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}
