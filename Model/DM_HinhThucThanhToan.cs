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
    
    public partial class DM_HinhThucThanhToan
    {
        public DM_HinhThucThanhToan()
        {
            this.BH_DonBanHang = new HashSet<BH_DonBanHang>();
            this.BH_DonMuaHang = new HashSet<BH_DonMuaHang>();
        }
    
        public System.Guid ID { get; set; }
        public string MaHinhThuc { get; set; }
        public string TenHinhThuc { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
    
        public virtual ICollection<BH_DonBanHang> BH_DonBanHang { get; set; }
        public virtual ICollection<BH_DonMuaHang> BH_DonMuaHang { get; set; }
    }
}
