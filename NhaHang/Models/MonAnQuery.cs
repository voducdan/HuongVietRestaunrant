using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NhaHang.Models
{
    public class MonAnQuery
    {
        public string TenMon { get; set; }
        public double? Gia { get; set; }
        public string LoaiMon { get; set; }
        public IList<MonAnQuery> MonAnList{get;set;}
}
}