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
    
    public partial class DM_NhomHangHoa
    {
        public DM_NhomHangHoa()
        {
            this.ChietKhauMacDinh_NhanVien = new HashSet<ChietKhauMacDinh_NhanVien>();
            this.DM_HangHoa = new HashSet<DM_HangHoa>();
        }
    
        public System.Guid ID { get; set; }
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.Guid> ID_Parent { get; set; }
        public bool LaNhomHangHoa { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
        public Nullable<bool> HienThi_Chinh { get; set; }
        public Nullable<bool> HienThi_Phu { get; set; }
        public string MayIn { get; set; }
        public Nullable<System.Guid> ID_Kho { get; set; }
        public Nullable<bool> HienThi_BanThe { get; set; }
        public Nullable<int> MauHienThi { get; set; }
        public string ID_DonVis { get; set; }
        public string TenDonVis { get; set; }
    
        public virtual ICollection<ChietKhauMacDinh_NhanVien> ChietKhauMacDinh_NhanVien { get; set; }
        public virtual ICollection<DM_HangHoa> DM_HangHoa { get; set; }
    }
}