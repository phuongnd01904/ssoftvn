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
    
    public partial class DM_KhuyenMai_ChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_KhuyenMai { get; set; }
        public System.Guid IDNhomHang_IDHangHoa { get; set; }
        public double SoLuong { get; set; }
        public double TiLe { get; set; }
        public double TienGiam { get; set; }
        public double GiaCu { get; set; }
        public Nullable<System.Guid> ID_DonViTinh { get; set; }
        public bool LaNhomHang { get; set; }
    
        public virtual DM_KhuyenMai DM_KhuyenMai { get; set; }
    }
}
