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
    
    public partial class PhieuChiChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_PhieuChi { get; set; }
        public Nullable<System.Guid> ID_KhoanThuChi { get; set; }
        public Nullable<System.Guid> ID_DoiTuong { get; set; }
        public string GhiChu { get; set; }
        public double TienChi { get; set; }
        public Nullable<int> LoaiCT { get; set; }
        public Nullable<System.Guid> ID_ChungTu { get; set; }
        public double TienGui { get; set; }
        public double TienMat { get; set; }
        public string DiaChi_DoiTuong { get; set; }
    
        public virtual DM_DoiTuong DM_DoiTuong { get; set; }
        public virtual KhoanThuChi KhoanThuChi { get; set; }
        public virtual PhieuChi PhieuChi { get; set; }
    }
}
