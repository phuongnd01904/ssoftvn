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
    
    public partial class BH_DonMuaHang_ChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_DonMuaHang { get; set; }
        public Nullable<System.Guid> ID_Kho { get; set; }
        public System.Guid ID_HangHoa { get; set; }
        public System.Guid ID_DonViTinh { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
        public Nullable<System.Guid> ID_ThueSuat { get; set; }
        public double TienThueSuat { get; set; }
        public double TienPhaiTra { get; set; }
        public Nullable<int> SoThuTu { get; set; }
        public Nullable<System.Guid> ID_LoHang { get; set; }
        public string MaVach { get; set; }
        public bool TheoLo { get; set; }
        public double TienChietKhau { get; set; }
        public Nullable<System.Guid> ID_MaVach { get; set; }
        public double PTChietKhau { get; set; }
    
        public virtual BH_DonMuaHang BH_DonMuaHang { get; set; }
        public virtual DM_DonViTinh DM_DonViTinh { get; set; }
        public virtual DM_HangHoa DM_HangHoa { get; set; }
        public virtual DM_Kho DM_Kho { get; set; }
        public virtual DM_LoHang DM_LoHang { get; set; }
        public virtual DM_ThueSuat DM_ThueSuat { get; set; }
    }
}
