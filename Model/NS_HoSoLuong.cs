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
    
    public partial class NS_HoSoLuong
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_NhanVien { get; set; }
        public System.DateTime NgayBD { get; set; }
        public Nullable<System.DateTime> NgayKT { get; set; }
        public double MucLuongCB { get; set; }
        public string GhiChu { get; set; }
        public string UserTao { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
    }
}