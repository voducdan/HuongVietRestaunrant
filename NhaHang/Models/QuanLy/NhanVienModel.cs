using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NhaHang.Models.QuanLy
{
    public class NhanVienModel
    {

        public int Idnhanvien { get; set; }
        public string Ten { get; set; }
        public Nullable<int> Idchinhanh { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public Nullable<double> Luong { get; set; }
        public string Chucvu { get; set; }
        public string Tenchinhanh { get; set; }
    }
}