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
    
    public partial class ThuDienTu
    {
        public System.Guid ID { get; set; }
        public string DiaChiGui { get; set; }
        public string DiaChiNhan { get; set; }
        public System.DateTime ThoiGian { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public Nullable<bool> DaDoc { get; set; }
        public Nullable<bool> QuanTrong { get; set; }
        public Nullable<bool> FileDinhKem { get; set; }
        public string UserLap { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSua { get; set; }
        public Nullable<System.DateTime> NgaySua { get; set; }
        public int LoaiThu { get; set; }
    }
}
