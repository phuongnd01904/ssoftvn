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
    
    public partial class Gara_TinhTrangXe_QTSuaChua
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_QuaTrinhSuaChua { get; set; }
        public Nullable<System.Guid> ID_PhanLoai { get; set; }
        public string TinhTrang { get; set; }
        public string PhuongAn { get; set; }
        public double SoLuong { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.Guid> ID_DichVuHangHoa { get; set; }
    }
}
