//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NongSanVietNam.Models.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinTuc
    {
        public int IDTinTuc { get; set; }
        public string TieuDe { get; set; }
        public string MotaNgan { get; set; }
        public string BaiVietChiTiet { get; set; }
        public int UserID { get; set; }
        public System.DateTime NgayTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string HinhAnhDaiDien { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
