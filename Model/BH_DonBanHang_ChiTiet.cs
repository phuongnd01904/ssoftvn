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
    
    public partial class BH_DonBanHang_ChiTiet
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_DonBanHang { get; set; }
        public Nullable<int> SoThuTu { get; set; }
        public Nullable<System.Guid> ID_Kho { get; set; }
        public System.Guid ID_HangHoa { get; set; }
        public Nullable<System.Guid> ID_MaVach { get; set; }
        public string MaVach { get; set; }
        public Nullable<System.Guid> ID_LoHang { get; set; }
        public System.Guid ID_DonViTinh { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
        public double PTChietKhau { get; set; }
        public double TienChietKhau { get; set; }
        public double PTThue { get; set; }
        public double TienThueSuat { get; set; }
        public double TienPhaiTra { get; set; }
        public Nullable<bool> TraLaiVatTuThayThe { get; set; }
        public string GhiChu { get; set; }
        public Nullable<double> SoLuong_YeuCau { get; set; }
    
        public virtual BH_DonBanHang BH_DonBanHang { get; set; }
        public virtual DM_DonViTinh DM_DonViTinh { get; set; }
        public virtual DM_HangHoa DM_HangHoa { get; set; }
        public virtual DM_Kho DM_Kho { get; set; }
        public virtual DM_LoHang DM_LoHang { get; set; }
    }
}
