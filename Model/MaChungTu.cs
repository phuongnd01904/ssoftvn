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
    
    public partial class MaChungTu
    {
        public System.Guid ID { get; set; }
        public System.Guid ID_DonVi { get; set; }
        public string LoaiChungTu { get; set; }
        public string TienTo { get; set; }
        public string NganCach1 { get; set; }
        public string NgayThangNam { get; set; }
        public string NganCach2 { get; set; }
        public int DoDaiSTT { get; set; }
        public Nullable<bool> SuDungUserName { get; set; }
        public Nullable<bool> SuDungMaDonVi { get; set; }
    }
}