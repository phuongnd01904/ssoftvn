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
    
    public partial class KhoanThuChi
    {
        public KhoanThuChi()
        {
            this.PhieuChiChiTiets = new HashSet<PhieuChiChiTiet>();
            this.PhieuThuChiTiets = new HashSet<PhieuThuChiTiet>();
        }
    
        public System.Guid ID { get; set; }
        public string MaKhoanThuChi { get; set; }
        public string NoiDungThuChi { get; set; }
        public string GhiChu { get; set; }
        public bool LaKhoanThu { get; set; }
        public bool BuTruCongNo { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
        public Nullable<bool> TinhLuong { get; set; }
    
        public virtual ICollection<PhieuChiChiTiet> PhieuChiChiTiets { get; set; }
        public virtual ICollection<PhieuThuChiTiet> PhieuThuChiTiets { get; set; }
    }
}
