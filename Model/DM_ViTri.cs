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
    
    public partial class DM_ViTri
    {
        public System.Guid ID { get; set; }
        public string MaViTri { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public System.Guid ID_KhuVuc { get; set; }
        public Nullable<double> DonGiaGio { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public string UserTao { get; set; }
        public byte[] Anh { get; set; }
        public Nullable<double> DonGiaNgay { get; set; }
        public Nullable<System.Guid> ID_LoaiPhong { get; set; }
        public Nullable<int> Tang { get; set; }
        public string TenViTri { get; set; }
    
        public virtual DM_KhuVuc DM_KhuVuc { get; set; }
    }
}
