using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhaHang.Models;
namespace NhaHang.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NhaHangEntities NhaHang = new NhaHangEntities();
            MonAnQuery ListMonAn = new MonAnQuery();
            ListMonAn.MonAnList = (from MA in NhaHang.MonAns
                             join LM in NhaHang.LoaiMons on MA.Idloaimon equals LM.Idloaimon
                             select new MonAnQuery()
                             {
                                 TenMon = MA.Tenmon,
                                 Gia = MA.Gia,
                                 LoaiMon = LM.Tenloaimon,
                             }).Take(10000).ToList();
            return View(ListMonAn);
        }
    }
}