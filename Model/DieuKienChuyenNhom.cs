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
    
    public partial class DieuKienChuyenNhom
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_NhomMoi { get; set; }
        public System.Guid ID_NhomHT { get; set; }
        public double Diem_Min { get; set; }
        public Nullable<double> Diem_Max { get; set; }
        public bool CongDonDiem { get; set; }
        public double DoanhThu_Min { get; set; }
        public Nullable<double> DoanhThu_Max { get; set; }
        public bool CongDonDoanhThu { get; set; }
        public Nullable<double> ThoiGianTinhDoanhSo { get; set; }
    }
}
