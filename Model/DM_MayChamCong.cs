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
    
    public partial class DM_MayChamCong
    {
        public System.Guid ID { get; set; }
        public int MaMay { get; set; }
        public string TenMayChamCong { get; set; }
        public string IP { get; set; }
        public Nullable<int> Port { get; set; }
        public string TenMien { get; set; }
        public Nullable<int> COMPort { get; set; }
        public Nullable<int> KieuKetNoi { get; set; }
        public Nullable<int> BaudRate { get; set; }
        public Nullable<bool> SuDungTenMien { get; set; }
        public bool SuDung { get; set; }
    }
}