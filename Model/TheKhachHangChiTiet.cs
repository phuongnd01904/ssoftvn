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
    
    public partial class TheKhachHangChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_TheKhachHang { get; set; }
        public System.Guid ID_HangHoa { get; set; }
        public Nullable<double> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<double> PTChietKhau { get; set; }
        public Nullable<double> TienChietKhau { get; set; }
        public Nullable<double> ThanhToan { get; set; }
        public Nullable<System.Guid> ID_LopHoc { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> NgayTraLai { get; set; }
        public Nullable<double> SoLuongTang { get; set; }
        public Nullable<double> SoLuongTraLai { get; set; }
        public Nullable<double> TienDaSuDung { get; set; }
        public Nullable<bool> TraLaiHHDV { get; set; }
        public Nullable<System.Guid> ID_SanPhamChinh { get; set; }
        public Nullable<bool> LaTangKem { get; set; }
        public Nullable<double> SoLuongDaSuDung { get; set; }
    
        public virtual TheKhachHang TheKhachHang { get; set; }
    }
}
