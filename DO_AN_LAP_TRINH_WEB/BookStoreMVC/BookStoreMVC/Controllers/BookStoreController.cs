using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMVC.Models;
using PagedList.Mvc;
using PagedList;
namespace BookStoreMVC.Controllers
{
    public class BookStoreController : Controller
    {
        dbQLBansachDataContext data = new dbQLBansachDataContext();
        private List<Sach> Laysachmoi(int count)
        {
            return data.Saches.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }
        // GET: BookStore
        public ActionResult Index(int? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var sachmoi = Laysachmoi(15);
            return View(sachmoi.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Chude()
        {
            var chude = from cd in data.ChuDes select cd;
            return PartialView(chude);
        }
        public ActionResult Nhaxuatban()
        {
            var nhaxuatban = from nxb in data.NhaXuatBans select nxb;
            return PartialView(nhaxuatban);
        }
        public ActionResult SPTheochude(int id, int? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var sach = from s in data.Saches where s.MaCD == id select s;
            return View(sach.ToPagedList(pageNum, pageSize));
        }
        public ActionResult SPTheoNXB(int id, int? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            var sach = from s in data.Saches where s.MaNXB == id select s;
            return View(sach.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Details(int id)
        {
            var sach = from s in data.Saches
                       where s.MaSach == id
                       select s;
            return View(sach.Single());
        }
    }
}