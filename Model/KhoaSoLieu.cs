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
    
    public partial class KhoaSoLieu
    {
        public System.Guid ID { get; set; }
        public System.DateTime DenNgay { get; set; }
        public Nullable<System.Guid> ID_DonVi { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayVaoSo { get; set; }
        public string UserLap { get; set; }
        public string UserSuaCuoi { get; set; }
        public Nullable<bool> XemDuLieuDaKhoa { get; set; }
    }
}
