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
    
    public partial class MonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAn()
        {
            this.ChiNhanhMonAns = new HashSet<ChiNhanhMonAn>();
            this.MonAnDonHangs = new HashSet<MonAnDonHang>();
        }
    
        public int Idmon { get; set; }
        public string Tenmon { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<int> Idloaimon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiNhanhMonAn> ChiNhanhMonAns { get; set; }
        public virtual LoaiMon LoaiMon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonAnDonHang> MonAnDonHangs { get; set; }
    }
}
