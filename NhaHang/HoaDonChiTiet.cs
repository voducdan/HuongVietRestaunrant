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
    
    public partial class HoaDonChiTiet
    {
        public int Idhoadonchitiet { get; set; }
        public Nullable<int> Idhoadon { get; set; }
        public string Tenmonan { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<double> Dongia { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
    }
}
