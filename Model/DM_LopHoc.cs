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
    
    public partial class DM_LopHoc
    {
        public System.Guid ID { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public Nullable<System.DateTime> NgayBD { get; set; }
        public Nullable<System.DateTime> NgayKT { get; set; }
        public Nullable<System.DateTime> GioBD { get; set; }
        public Nullable<System.DateTime> GioKT { get; set; }
        public string NgayTrongTuan { get; set; }
        public Nullable<System.Guid> GiaoVienPhuTrach { get; set; }
        public System.Guid ID_DonVi { get; set; }
        public string GhiChu { get; set; }
        public string UserLap { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string UserSuaCuoi { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<double> ChietKhau_GiaoVienPhuTrach { get; set; }
        public Nullable<bool> LaPhanTram_CKGV { get; set; }
    }
}
