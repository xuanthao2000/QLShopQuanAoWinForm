//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnNhomQLBH
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.CTDHs = new HashSet<CTDH>();
        }
    
        public int MaDH { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<System.DateTime> NgayLapHD { get; set; }
        public Nullable<System.DateTime> NgayGiaoHang { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDH> CTDHs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
    }
}
