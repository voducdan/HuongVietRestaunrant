using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using PagedList;
using System.Web.Mvc;
using NhaHang.Models.QuanLy;
using System.Data;

namespace NhaHang.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        public ActionResult Index()
        {
            return View();
        }
        // get ban
        public ActionResult Ban(int? page)
        {
            NhaHangEntities NhaHang_Ban = new NhaHangEntities();
            BanModel banModel = new BanModel();
            int pageSize = 1000;
            int pageNumber = page ?? 1;
            banModel.BanModels = (from B in NhaHang_Ban.Bans
                                  select B).OrderBy(b=>b.Idban).ToPagedList(pageNumber,pageSize);
            return View(banModel);
        }
        // edit ban
        public bool EditBan(int id, int soghe, int flag)
        {
            var idBan = new SqlParameter();
            idBan.ParameterName = "@idban";
            idBan.SqlDbType = SqlDbType.Int;
            idBan.SqlValue = id;
            var ghe = new SqlParameter();
            ghe.ParameterName = "@soghe";
            ghe.SqlDbType = SqlDbType.Int;
            ghe.SqlValue = soghe;
            NhaHangEntities NhaHang = new NhaHangEntities();
            if (flag == 1)
            {
                try
                {
                   NhaHang.Database.ExecuteSqlCommand("exec sp_EditTableWait @idban, @soghe", idBan, ghe);
                    return true;
                }
                catch (SqlException err)
                {
                    return false;
                }
            }
            try
            {
                NhaHang.Database.ExecuteSqlCommand("exec sp_EditTable @idban, @soghe", idBan, ghe);
                return true;

            }
            catch (SqlException err)
            {
                return false;
            }
        }
        // delete ban
        public string DelBan(string id)
        {
            return id;
        }
        // get nhan vien
        public ActionResult NhanVien(int? page)
        {
            NhaHangEntities NhaHang = new NhaHangEntities();
            var NhanVien = NhaHang.Database.SqlQuery<NhanVienModel>("exec sp_ListAllNhanVien").ToPagedList(page ?? 1, 1000);
            return View(NhanVien);
        }
        // get ma giam gia
        public ActionResult MaGiamGia(int? page)
        {
            NhaHangEntities NhaHang_Ban = new NhaHangEntities();
            MaGiamGiaModel maGiamGiaModel= new MaGiamGiaModel();
            int pageSize = 1000;
            int pageNumber = page ?? 1;
            maGiamGiaModel.MaGiamGiaModels = (from MGG in NhaHang_Ban.MaGiamGias
                                  select MGG).OrderBy(mgg => mgg.Magiamgia1).ToPagedList(pageNumber, pageSize);
            return View(maGiamGiaModel);
        }
        // edit ma giam gia
        public bool EditMgg(string Mgg, int solan, int flag)
        {
            var mgg = new SqlParameter();
            mgg.ParameterName = "@Magiamgia";
            mgg.SqlDbType = SqlDbType.VarChar;
            mgg.Size = 10;
            mgg.SqlValue = Mgg;
            var soLan = new SqlParameter();
            soLan.ParameterName = "@Soluong";
            soLan.SqlDbType = SqlDbType.Int;
            soLan.SqlValue = solan;
            NhaHangEntities NhaHang = new NhaHangEntities();
            if (flag == 1)
            {
                try
                {
                    NhaHang.Database.ExecuteSqlCommand("exec sp_CapNhatMaGiamGia_Truoc @Magiamgia, @Soluong", mgg, soLan);
                    
                    return true;
                }
                catch (SqlException err)
                {
                    Console.Write(err);
                    return false;
                }
            }
            try
            {
                NhaHang.Database.ExecuteSqlCommand("exec sp_CapNhatMaGiamGia_Sau @Magiamgia, @Soluong", mgg, soLan);
                return true;

            }
            catch (SqlException err)
            {
                Console.Write(err);
                return false;
            }
        }
        // edit mon an
        public bool EditMonAn(int monan, int gia, int flag)
        {
            var monAn = new SqlParameter();
            monAn.ParameterName = "@Idmon";
            monAn.SqlDbType = SqlDbType.VarChar;
            monAn.SqlValue = monan;
            var Gia = new SqlParameter();
            Gia.ParameterName = "@Gia";
            Gia.SqlDbType = SqlDbType.Int;
            Gia.SqlValue = gia;
            NhaHangEntities NhaHang = new NhaHangEntities();
            if (flag == 1)
            {
                try
                {
                    NhaHang.Database.ExecuteSqlCommand("exec sp_CapNhatGiaMonAn_Truoc @Idmon, @Gia", monAn, Gia);

                    return true;
                }
                catch (SqlException err)
                {
                    Console.Write(err);
                    return false;
                }
            }
            try
            {
                NhaHang.Database.ExecuteSqlCommand("exec sp_CapNhatGiaMonAn_Sau @Idmon, @Gia", monAn, Gia);
                return true;

            }
            catch (SqlException err)
            {
                Console.Write(err);
                return false;
            }
        }
        // get hoa don
        public ActionResult HoaDon(int? page)
        {
            NhaHangEntities NhaHang = new NhaHangEntities();
            HoaDonModel hoaDonModels = new HoaDonModel();
            int pageSize = 1000;
            int pageNumber = page ?? 1;
            hoaDonModels.HoaDonModels = (from HD in NhaHang.HoaDons
                                              select HD).OrderBy(hd => hd.Idhoadon).ToPagedList(pageNumber, pageSize);
            return View(hoaDonModels);
        }
        // update hoa don
        public bool UpdateHoaDon(int id)
        {
            var hoaDon = new SqlParameter();
            hoaDon.ParameterName = "@Idhoadon";
            hoaDon.SqlValue = id;
            NhaHangEntities NhaHang = new NhaHangEntities();
            try
            {
                NhaHang.Database.ExecuteSqlCommand("exec DocThongTinHoaDon_Truoc @Idhoadon", hoaDon);
                return true;
            }
            catch (SqlException err)
            {
                Console.Write(err);
                return false;
            }
        }
        // edit hoa don
        public bool EditHoaDon(int id, int ca)
        {
            var hoaDon = new SqlParameter();
            hoaDon.ParameterName = "@Idhoadon";
            hoaDon.SqlValue = id;
            var Ca = new SqlParameter();
            Ca.ParameterName = "@Ca";
            Ca.SqlValue = ca;
            NhaHangEntities NhaHang = new NhaHangEntities();
            try
            {
                NhaHang.Database.ExecuteSqlCommand("exec CapnhatHoaDon_Sau @Idhoadon, @Ca", hoaDon,Ca);
                return true;
            }
            catch (SqlException err)
            {
                Console.Write(err);
                return false;
            }
        }
    }
}