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
    
    public partial class KH_KiemKe
    {
        public KH_KiemKe()
        {
            this.KH_KiemKeChiTiet = new HashSet<KH_KiemKeChiTiet>();
        }
    
        public System.Guid ID { get; set; }
        public string SoChungTu { get; set; }
        public System.DateTime NgayChungTu { get; set; }
        public Nullable<System.Guid> ID_NhanVien { get; set; }
        public string DienGiai { get; set; }
        public System.Guid ID_DonVi { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayVaoSo { get; set; }
        public string UserLap { get; set; }
        public string UserSuaCuoi { get; set; }
    
        public virtual DM_DonVi DM_DonVi { get; set; }
        public virtual DM_NhanVien DM_NhanVien { get; set; }
        public virtual ICollection<KH_KiemKeChiTiet> KH_KiemKeChiTiet { get; set; }
    }
}
