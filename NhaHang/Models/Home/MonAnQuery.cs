using System.Collections.Generic;
namespace NhaHang.Models
{
    public class MonAnQuery
    {
        public int Idmon { get; set; }
        public string TenMon { get; set; }
        public double? Gia { get; set; }
        public string LoaiMon { get; set; }
        public IList<MonAnQuery> MonAnList { get; set; }
    }
}