//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NhaHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiNhanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiNhanh()
        {
            this.ChiNhanhMonAns = new HashSet<ChiNhanhMonAn>();
            this.ChiNhanhSdts = new HashSet<ChiNhanhSdt>();
            this.DonDatHangs = new HashSet<DonDatHang>();
            this.KhachHangs = new HashSet<KhachHang>();
            this.NhanViens = new HashSet<NhanVien>();
        }
    
        public int Idchinhanh { get; set; }
        public Nullable<int> Quanly { get; set; }
        public string Tenchinhanh { get; set; }
        public Nullable<System.DateTime> Ngaythanhlap { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual ChiNhanhDiaChi ChiNhanhDiaChi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiNhanhMonAn> ChiNhanhMonAns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiNhanhSdt> ChiNhanhSdts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
