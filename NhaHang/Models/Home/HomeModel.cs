using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;


namespace NhaHang.Models.Home
{
    public class HomeModel
    {
        public IList<LoaiMon> LoaiMons { get; set; }
        public PagedList.IPagedList<MonAnQuery> MonAnQueries { get; set; }
    }
}