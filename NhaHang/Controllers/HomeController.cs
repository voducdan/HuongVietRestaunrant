using NhaHang.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using NhaHang.Models.Home;

namespace NhaHang.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {
            NhaHangEntities NhaHang = new NhaHangEntities();
            MonAnQuery ListMonAn = new MonAnQuery();
            HomeModel homeModel = new HomeModel();
            int pageSize = 1000;
            int pageNumber = (page ?? 1);
            homeModel.MonAnQueries = (from MA in NhaHang.MonAns
                                   join LM in NhaHang.LoaiMons on MA.Idloaimon equals LM.Idloaimon
                                   select new MonAnQuery()
                                   {
                                       Idmon = MA.Idmon,
                                       TenMon = MA.Tenmon,
                                       Gia = MA.Gia,
                                       LoaiMon = LM.Tenloaimon,
                                   }).OrderBy(MonAn => MonAn.Gia).ToPagedList(pageNumber, pageSize);
            homeModel.LoaiMons = (from LM in NhaHang.LoaiMons select LM).ToList();
            return View(homeModel);
        }
    }
}



