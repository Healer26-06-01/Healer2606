using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMVC.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace BookStoreMVC.Controllers
{
    public class AdminController : Controller
    {
        dbQLBansachDataContext db = new dbQLBansachDataContext();
        // GET: Admin
        public ActionResult Trangchu()
        {
            return View();
        }
        public ActionResult Sach(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            return View(db.Saches.ToList().OrderBy(n => n.MaSach).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Themmoisach()
        {
            ViewBag.MaCD = new SelectList(db.ChuDes.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe");
            ViewBag.MaNXB = new SelectList(db.NhaXuatBans.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themmoisach(Sach sach, HttpPostedFileBase fileupload)
        {
            ViewBag.MaCD = new SelectList(db.ChuDes.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe");
            ViewBag.MaNXB = new SelectList(db.NhaXuatBans.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB");
            if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chon ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/images"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    sach.AnhBia = "/images/" + fileName;
                    db.Saches.InsertOnSubmit(sach);
                    db.SubmitChanges();
                    return View();
                }
                return RedirectToAction("Sach");
            }
        }
        public ActionResult Chitietsach(int id)
        {
            Sach sach = db.Saches.SingleOrDefault(n => n.MaSach == id);
            ViewBag.MaSach = sach.MaSach;
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sach);
        }
        [HttpGet]
        public ActionResult Xoasach(int id)
        {
            Sach sach = db.Saches.SingleOrDefault(n => n.MaSach == id);
            ViewBag.MaSach = sach.MaSach;
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sach);
        }

        [HttpPost, ActionName("Xoasach")]
        public ActionResult Xacnhanxoasach(int id)
        {
            Sach sach = db.Saches.SingleOrDefault(n => n.MaSach == id);
            ViewBag.MaSach = sach.MaSach;
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.Saches.DeleteOnSubmit(sach);
            db.SubmitChanges();
            return RedirectToAction("Sach");
        }
        [HttpGet]
        public ActionResult Suasach(int id)
        {
            Sach sach = db.Saches.SingleOrDefault(n => n.MaSach == id);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaCD = new SelectList(db.ChuDes.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe", sach.MaCD);
            ViewBag.MaNXB = new SelectList(db.NhaXuatBans.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB", sach.MaNXB);
            return View(sach);
        }
        [HttpPost, ActionName("Suasach")]
        [ValidateInput(false)]
        public ActionResult Xacnhansuasach(int id, HttpPostedFileBase fileupload)
        {
            Sach sach = db.Saches.SingleOrDefault(n => n.MaSach == id);
            ViewBag.MaCD = new SelectList(db.ChuDes.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe", sach.MaCD);
            ViewBag.MaNXB = new SelectList(db.NhaXuatBans.ToList().OrderBy(n => n.TenNXB), "MaNXB", "TenNXB", sach.MaNXB);

            if (fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/images"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    sach.AnhBia = "/images/" + fileName;
                    UpdateModel(sach);
                    db.SubmitChanges();
                    return RedirectToAction("Sach");
                }
                return View(sach);
            }

        }
        public ActionResult Chude(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            return View(db.ChuDes.ToList().OrderBy(n => n.MaCD).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Themmoichude()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themmoichude(ChuDe chude)
        {
            if (chude.TenChuDe == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập tên chủ đề";
                return View();
            }
            else
            {
                db.ChuDes.InsertOnSubmit(chude);
                db.SubmitChanges();
            }
            return RedirectToAction("Chude");
        }
        public ActionResult Chitietchude(int id)
        {
            ChuDe chude = db.ChuDes.SingleOrDefault(n => n.MaCD == id);
            ViewBag.MaCD = chude.MaCD;
            if (chude == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chude);
        }

        [HttpGet]
        public ActionResult Xoachude(int id)
        {
            ChuDe chude = db.ChuDes.SingleOrDefault(n => n.MaCD == id);
            ViewBag.MaCD = chude.MaCD;
            if (chude == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chude);
        }

        [HttpPost, ActionName("Xoachude")]
        public ActionResult Xacnhanxoachude(int id)
        {
            ChuDe chude = db.ChuDes.SingleOrDefault(n => n.MaCD == id);
            ViewBag.MaCD = chude.MaCD;
            if (chude == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.ChuDes.DeleteOnSubmit(chude);
            db.SubmitChanges();
            return RedirectToAction("Chude");
        }



        [HttpGet]
        public ActionResult Suachude(int id)
        {
            ChuDe chude = db.ChuDes.SingleOrDefault(n => n.MaCD == id);
            if (chude == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chude);
        }
        [HttpPost, ActionName("Suachude")]
        [ValidateInput(false)]
        public ActionResult Xacnhansuachude(int id)
        {
            ChuDe chude = db.ChuDes.SingleOrDefault(n => n.MaCD == id);

            if (chude == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            UpdateModel(chude);
            db.SubmitChanges();
            return RedirectToAction("Chude");
        }
        public ActionResult Nhaxuatban(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            return View(db.NhaXuatBans.ToList().OrderBy(n => n.MaNXB).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Themmoinhaxuatban()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themmoinhaxuatban(NhaXuatBan nhaxuatban)
        {
            if (nhaxuatban.TenNXB == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập tên nhà xuất bản";
                return View();
            }
            else
            {
                db.NhaXuatBans.InsertOnSubmit(nhaxuatban);
                db.SubmitChanges();
            }
            return RedirectToAction("Nhaxuatban");
        }
        public ActionResult Chitietnhaxuatban(int id)
        {
            NhaXuatBan nhaxuatban = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == id);
            ViewBag.MaNXB = nhaxuatban.MaNXB;
            if (nhaxuatban == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(nhaxuatban);
        }

        [HttpGet]
        public ActionResult Xoanhaxuatban(int id)
        {
            NhaXuatBan nhaxuatban = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == id);
            ViewBag.MaNXB = nhaxuatban.MaNXB;
            if (nhaxuatban == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(nhaxuatban);
        }

        [HttpPost, ActionName("Xoanhaxuatban")]
        public ActionResult Xacnhanxoanhaxuatban(int id)
        {
            NhaXuatBan nhaxuatban = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == id);
            ViewBag.MaNXB = nhaxuatban.MaNXB;
            if (nhaxuatban == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.NhaXuatBans.DeleteOnSubmit(nhaxuatban);
            db.SubmitChanges();
            return RedirectToAction("Nhaxuatban");
        }


        [HttpGet]
        public ActionResult Suanhaxuatban(int id)
        {
            NhaXuatBan nhaxuatban = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == id);
            if (nhaxuatban == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(nhaxuatban);
        }
        [HttpPost, ActionName("Suanhaxuatban")]
        [ValidateInput(false)]
        public ActionResult Xacnhansuanhaxuatban(int id)
        {
            NhaXuatBan nhaxuatban = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == id);

            if (nhaxuatban == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            UpdateModel(nhaxuatban);
            db.SubmitChanges();
            return RedirectToAction("Nhaxuatban");
        }

        public ActionResult Khachhang(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            return View(db.KhachHangs.ToList().OrderBy(n => n.MaKH).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Themmoikhachhang()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themmoikhachhang(KhachHang khachhang)
        {
            if (khachhang.HoTen == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập tên";
                return View();
            }
            if (khachhang.TaiKhoan == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập tên tài khoản";
                return View();
            }
            if (khachhang.DiachiKH == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập địa chỉ";
                return View();
            }
            if (khachhang.DienThoaiKH == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập số điện thoại";
                return View();
            }
            if (khachhang.Email == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập địa chỉ email";
                return View();
            }
            if (khachhang.MatKhau == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập mật khẩu";
                return View();
            }
            if (khachhang.NgaySinh == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập ngày tháng năm sinh";
                return View();
            }
            else
            {
                db.KhachHangs.InsertOnSubmit(khachhang);
                db.SubmitChanges();
            }
            return RedirectToAction("Khachhang");
        }
        public ActionResult Chitietkhachhang(int id)
        {
            KhachHang khachhang = db.KhachHangs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = khachhang.MaKH;
            if (khachhang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(khachhang);
        }

        [HttpGet]
        public ActionResult Xoakhachhang(int id)
        {
            KhachHang khachhang = db.KhachHangs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = khachhang.MaKH;
            if (khachhang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(khachhang);
        }

        [HttpPost, ActionName("Xoakhachhang")]
        public ActionResult Xacnhanxoakhachhang(int id)
        {
            KhachHang khachhang = db.KhachHangs.SingleOrDefault(n => n.MaKH == id);
            ViewBag.MaKH = khachhang.MaKH;
            if (khachhang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.KhachHangs.DeleteOnSubmit(khachhang);
            db.SubmitChanges();
            return RedirectToAction("Khachhang");
        }


        [HttpGet]
        public ActionResult Suakhachhang(int id)
        {
            KhachHang khachhang = db.KhachHangs.SingleOrDefault(n => n.MaKH == id);
            if (khachhang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(khachhang);
        }
        [HttpPost, ActionName("Suakhachhang")]
        [ValidateInput(false)]
        public ActionResult Xacnhansuakhachhang(int id)
        {
            KhachHang khachhang = db.KhachHangs.SingleOrDefault(n => n.MaKH == id);

            if (khachhang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            UpdateModel(khachhang);
            db.SubmitChanges();
            return RedirectToAction("Khachhang");
        }



        public ActionResult Tacgia(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            return View(db.TacGias.ToList().OrderBy(n => n.MaTG).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Themmoitacgia()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themmoitacgia(TacGia tacgia)
        {
            if (tacgia.TenTG == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập tên";
                return View();
            }
            if (tacgia.TieuSu == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập tiểu sử";
                return View();
            }
            if (tacgia.DiaChi == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập địa chỉ";
                return View();
            }
            if (tacgia.DienThoai == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập điện thoại";
                return View();
            }
            else
            {
                db.TacGias.InsertOnSubmit(tacgia);
                db.SubmitChanges();
            }
            return RedirectToAction("Tacgia");
        }
        public ActionResult Chitiettacgia(int id)
        {
            TacGia tacgia = db.TacGias.SingleOrDefault(n => n.MaTG == id);
            ViewBag.MaTG = tacgia.MaTG;
            if (tacgia == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tacgia);
        }

        [HttpGet]
        public ActionResult Xoatacgia(int id)
        {
            TacGia tacgia = db.TacGias.SingleOrDefault(n => n.MaTG == id);
            ViewBag.MaTG = tacgia.MaTG;
            if (tacgia == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tacgia);
        }

        [HttpPost, ActionName("Xoatacgia")]
        public ActionResult Xacnhanxoatacgia(int id)
        {
            TacGia tacgia = db.TacGias.SingleOrDefault(n => n.MaTG == id);
            ViewBag.MaTG = tacgia.MaTG;
            if (tacgia == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.TacGias.DeleteOnSubmit(tacgia);
            db.SubmitChanges();
            return RedirectToAction("Tacgia");
        }


        [HttpGet]
        public ActionResult Suatacgia(int id)
        {
            TacGia tacgia = db.TacGias.SingleOrDefault(n => n.MaTG == id);

            if (tacgia == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tacgia);
        }
        [HttpPost, ActionName("Suatacgia")]
        [ValidateInput(false)]
        public ActionResult Xacnhansuatacgia(int id)
        {
            TacGia tacgia = db.TacGias.SingleOrDefault(n => n.MaTG == id);

            if (tacgia == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            UpdateModel(tacgia);
            db.SubmitChanges();
            return RedirectToAction("Tacgia");
        }



        public ActionResult Ddh(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            return View(db.DonDatHangs.ToList().OrderBy(n => n.SoDH).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult Themmoiddh()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themmoiddh(DonDatHang ddh)
        {
            if (ddh.NgayDH == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập ngày đơn hàng";
                return View();
            }
            if (ddh.NgayGiao == null)
            {
                ViewBag.Thongbao = "Vui lòng nhập ngày giao";
                return View();
            }

            else
            {
                db.DonDatHangs.InsertOnSubmit(ddh);
                db.SubmitChanges();
            }
            return RedirectToAction("Ddh");
        }
        public ActionResult Chitietddh(int id)
        {
            DonDatHang ddh = db.DonDatHangs.SingleOrDefault(n => n.SoDH == id);
            ViewBag.SoDH = ddh.SoDH;
            if (ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ddh);
        }

        [HttpGet]
        public ActionResult Xoaddh(int id)
        {
            DonDatHang ddh = db.DonDatHangs.SingleOrDefault(n => n.SoDH == id);
            ViewBag.SoDH = ddh.SoDH;
            if (ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ddh);
        }

        [HttpPost, ActionName("Xoaddh")]
        public ActionResult Xacnhanxoaddh(int id)
        {
            DonDatHang ddh = db.DonDatHangs.SingleOrDefault(n => n.SoDH == id);
            ViewBag.SoDH = ddh.SoDH;
            if (ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.DonDatHangs.DeleteOnSubmit(ddh);
            db.SubmitChanges();
            return RedirectToAction("Ddh");
        }


        [HttpGet]
        public ActionResult Suaddh(int id)
        {
            DonDatHang ddh = db.DonDatHangs.SingleOrDefault(n => n.SoDH == id);

            if (ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ddh);
        }
        [HttpPost, ActionName("Suaddh")]
        [ValidateInput(false)]
        public ActionResult Xacnhansuaddh(int id)
        {
            DonDatHang ddh = db.DonDatHangs.SingleOrDefault(n => n.SoDH == id);

            if (ddh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            UpdateModel(ddh);
            db.SubmitChanges();
            return RedirectToAction("Ddh");
        }









        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["password"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Bạn phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Bạn phải nhập mật khẩu";
            }
            else
            {
                Admin ad = db.Admins.SingleOrDefault(n => n.UserAdmin == tendn && n.PassAdmin == matkhau);
                if (ad != null)
                {
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("Trangchu", "Admin");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng!!!";
            }
            return View();
        }

    }
}