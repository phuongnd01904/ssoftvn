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
    
    public partial class Hotel_DatPhong_ChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_DatPhong { get; set; }
        public Nullable<System.Guid> ID_LoaiPhong { get; set; }
        public System.DateTime ThoiGianDen { get; set; }
        public Nullable<System.DateTime> ThoiGianDi { get; set; }
        public Nullable<System.Guid> ID_LoaiGia { get; set; }
        public double DonGia { get; set; }
        public int SoLuong_Nguoi { get; set; }
        public double ChietKhau { get; set; }
        public double PTChietKhau { get; set; }
        public double ThanhToan { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> TheoNgay { get; set; }
        public Nullable<System.Guid> ID_Phong { get; set; }
        public Nullable<bool> TheoDoi { get; set; }
    }
}
