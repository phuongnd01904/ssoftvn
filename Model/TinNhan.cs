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
    
    public partial class TinNhan
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_NguoiDung { get; set; }
        public Nullable<System.Guid> ID_ChungTu { get; set; }
        public Nullable<System.Guid> ID_KhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string NoiDungTin { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public Nullable<System.DateTime> ThoiGianGui { get; set; }
        public Nullable<int> LoaiTinNhan { get; set; }
    
        public virtual DM_DoiTuong DM_DoiTuong { get; set; }
        public virtual sys_NguoiDung sys_NguoiDung { get; set; }
        public virtual TinNhan TinNhan1 { get; set; }
        public virtual TinNhan TinNhan2 { get; set; }
    }
}
