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
    
    public partial class DM_KhuVuc
    {
        public DM_KhuVuc()
        {
            this.DM_ViTri = new HashSet<DM_ViTri>();
        }
    
        public System.Guid ID { get; set; }
        public string MaKhuVuc { get; set; }
        public string TenKhuVuc { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> Tang { get; set; }
        public string UserTao { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string UserSuaCuoi { get; set; }
        public Nullable<System.DateTime> NgaySuaCuoi { get; set; }
        public byte[] SoDoKhuVuc { get; set; }
    
        public virtual ICollection<DM_ViTri> DM_ViTri { get; set; }
    }
}
