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
    
    public partial class DinhLuongDichVu
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_DichVu { get; set; }
        public System.Guid ID_NguyenLieu { get; set; }
        public double SoLuong { get; set; }
        public System.Guid ID_DonViTinh { get; set; }
        public string GhiChu { get; set; }
        public Nullable<double> SoLuongDinhLuong { get; set; }
        public Nullable<int> STT { get; set; }
    
        public virtual DM_DonViTinh DM_DonViTinh { get; set; }
    }
}
