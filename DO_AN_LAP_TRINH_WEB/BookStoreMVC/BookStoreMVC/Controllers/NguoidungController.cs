using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMVC.Models;
namespace BookStoreMVC.Controllers
{
    public class NguoidungController : Controller
    {
        dbQLBansachDataContext db = new dbQLBansachDataContext();
        //
        // GET: /Nguoidung/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Dangky()
        {
            return View();
        }
        //post: Hàm Dangky(post) Nhận dữ liệu từ trang Dangky và thực hiện việc tạo mới dữ liệu
        [HttpPost]
        public ActionResult Dangky(FormCollection collection, KhachHang kh)
        {
            //Gán các giá trị người dùng nhập liệu cho các biến
            var hoten = collection["HoTenKH"];
            var tendn = collection["TenDN"];
            var matkhau = collection["MatKhau"];
            var nhaplaimatkhau = collection["NhapLaiMatKhau"];
            var diachi = collection["DiaChi"];
            var email = collection["Email"];
            var dienthoai = collection["DienThoai"];
            var ngaysinh = String.Format("{0:MM/dd/yyyy}", collection["NgaySinh"]);
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ tên khách hàng không được để trống";
            }
            else if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi2"] = "Phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Phải nhập mật khẩu";
            }

            else if (String.IsNullOrEmpty(nhaplaimatkhau))
            {
                ViewData["Loi4"] = "Phải nhập lại mật khẩu";
            }
            if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Email không được bỏ trống";
            }
            if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi6"] = "Phải nhập điện thoại";
            }
            else
            {
                //Gán giá trị cho đối tượng được tạo mới (kh)
                kh.HoTen = hoten;
                kh.TaiKhoan = tendn;
                kh.MatKhau = matkhau;
                kh.Email = email;
                kh.DiachiKH = diachi;
                kh.DienThoaiKH = dienthoai;
                kh.NgaySinh = DateTime.Parse(ngaysinh);
                db.KhachHangs.InsertOnSubmit(kh);

                db.SubmitChanges();
                return RedirectToAction("DangNhap");
            }
            return this.Dangky();
        }
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        public ActionResult Dangnhap(FormCollection collection)
        {
            //Gán giá trị người dùng nhập liệu cho các biến
            var tendn = collection["TenDN"];
            var matkhau = collection["MatKhau"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mạt khẩu";
            }
            else
            {
                //gán giá trị cho các đối tượng được tạo mới(kh)
                KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == tendn && n.MatKhau == matkhau);
                if (kh != null)
                {
                    ViewBag.Thongbao = "Chúc mừng đăng nhập thành công";
                    Session["TaiKhoan"] = kh;
                }
                else
                    ViewBag.Thongbao = "tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }
    }
}