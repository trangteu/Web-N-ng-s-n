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
    
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            this.TinTucs = new HashSet<TinTuc>();
        }
    
        public int UserID { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string TenDayDu { get; set; }
        public Nullable<int> GioiTinh { get; set; }
        public string Phone { get; set; }
        public string DiaChi { get; set; }
        public string NguoiTao { get; set; }
        public System.DateTime NgayTao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TinTuc> TinTucs { get; set; }
    }
}
