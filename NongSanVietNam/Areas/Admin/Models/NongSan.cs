//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NongSanVietNam.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NongSan
    {
        public int ID { get; set; }
        public string TenNS { get; set; }
        public int IDLoaiNS { get; set; }
        public string MoTaNgan { get; set; }
        public string MotaChiTiet { get; set; }
        public System.DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public string HinhAnhDaiDien { get; set; }
    
        public virtual LoaiN LoaiN { get; set; }
    }
}
