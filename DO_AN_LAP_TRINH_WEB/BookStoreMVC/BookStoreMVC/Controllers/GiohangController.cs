using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMVC.Models;
namespace BookStoreMVC.Controllers
{
    public class GioHangController : Controller
    {
        //Tạo đối tượng data chứa dữ liệu từ model dbBansach đã tạo.
        dbQLBansachDataContext data = new dbQLBansachDataContext();
        //Lấy giỏ hàng
        public List<Giohang> Laygiohang()
        {
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang == null)
            {
                //Nếu giỏ hàng chưa tồn tại thì khởi tạo listGioHang
                lstGiohang = new List<Giohang>();
                Session["Giohang"] = lstGiohang;

            }
            return lstGiohang;
        }
        //Thêm hàng vào giỏ hàng
        public ActionResult ThemGiohang(int iMasach, string strURL)
        {
            //Lấy ra session giỏ hàng
            List<Giohang> lstGiohang = Laygiohang();
            //Kiểm tra sách này tồn tại trong session["GioHang"] chưa?
            Giohang sanpham = lstGiohang.Find(n => n.iMasach ==
            iMasach);
            if (sanpham == null)
            {
                sanpham = new Giohang(iMasach);
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
        }
        //Tổng số lượng
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<Giohang> lstGiohang = Session["GioHang"] as List<Giohang>;

            if (lstGiohang != null)
            {
                iTongSoLuong = lstGiohang.Sum(n => n.iSoluong);
            }
            return iTongSoLuong;
        }
        //Tổng tiền
        private double iTongTien()
        {
            double iTongTien = 0;
            List<Giohang> lstGiohang = Session["GioHang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                iTongTien = lstGiohang.Sum(n => n.dThanhtien);
            }
            return iTongTien;
        }
        //Xây dựng trang giỏ hàng
        public ActionResult GioHang()
        {
            List<Giohang> lstGiohang = Laygiohang();
            if (lstGiohang.Count == 0)
            {
                return RedirectToAction("Index", "BookStore");
            }
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = iTongTien();
            return View(lstGiohang);
        }
        public ActionResult GiohangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = iTongTien();
            return PartialView();
        }
        //Xóa giỏ hàng
        public ActionResult XoaGiohang(int iMaSP)
        {
            //Lay gio hang tu Session
            List<Giohang> lstGiohang = Laygiohang();
            // Kiểm tra sách đã có trong Session["Giohang"]
            Giohang sanpham = lstGiohang.SingleOrDefault(n =>
            n.iMasach == iMaSP);
            //Nếu tồn tại thì cho sửa Soluong
            if (sanpham != null)
            {
                lstGiohang.RemoveAll(n => n.iMasach == iMaSP);
                return RedirectToAction("GioHang");
            }
            if (lstGiohang.Count == 0)
            {

                return RedirectToAction("Index", "BookStore");
            }
            return RedirectToAction("Giohang");
        }
        //Cập nhật giỏ hàng
        public ActionResult CapnhatGiohang(int iMaSP, FormCollection f)
        {
            Sach sach = data.Saches.SingleOrDefault(n => n.MaSach == iMaSP);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lấy giỏ hàng từ Session
            List<Giohang> lstGiohang = Laygiohang();
            //Kiem tra sach da co trong Session["Giohang"]
            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.iMasach == iMaSP);
            //Nếu tồn tại thì sửa Soluong
            if (sanpham != null)
            {
                sanpham.iSoluong =
                int.Parse(f["txtSoluong"].ToString());
            }
            return RedirectToAction("Giohang");
        }
        //Xay dựng 1 view cho người dùng chỉnh sửa giỏ hàng
        public ActionResult Suagiohang()
        {
            if (Session["Giohang"] == null)
            {
                return RedirectToAction("Index", "BookStore");
            }
            List<Giohang> lstGiohang = Laygiohang();
            return View(lstGiohang);
        }
        public ActionResult XoaTatcaGiohang()
        {
            //Lay gio hang tu Session
            List<Giohang> lstGiohang = Laygiohang();
            lstGiohang.Clear();
            return RedirectToAction("Index", "BookStore");
        }
        public ActionResult DatHang()
        {
            //Kiem tra dang nhap
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("Dangnhap", "Nguoidung");

            }
            if (Session["Giohang"] == null)
            {
                return RedirectToAction("Index", "BookStore");
            }
            //Lay gio hang tu Session
            List<Giohang> lstGiohang = Laygiohang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = iTongTien();
            return View(lstGiohang);
        }
        public ActionResult DatHang(FormCollection collection)
        {
            //Them don hang
            DonDatHang ddh = new DonDatHang();
            KhachHang kh = (KhachHang)Session["Taikhoan"];
            List<Giohang> gh = Laygiohang();
            ddh.MaKH = kh.MaKH;
            ddh.NgayDH = DateTime.Now;
            var ngaygiao = String.Format("{0:MM/dd/yyyy}",
            collection["Ngaygiao"]);
            ddh.NgayGiao = DateTime.Parse(ngaygiao);
            ddh.TinhTrangGiaoHang = false;
            ddh.DaThanhToan = false;
            data.DonDatHangs.InsertOnSubmit(ddh);
            data.SubmitChanges();
            //Them chi tiet don hang
            foreach (var item in gh)
            {
                ChiTietDatHang ctdh = new ChiTietDatHang();
                ctdh.SoDH = ddh.SoDH;
                ctdh.MaSach = item.iMasach;
                ctdh.SoLuong = item.iSoluong;
                ctdh.DonGia = (decimal)item.dDongia;
                data.ChiTietDatHangs.InsertOnSubmit(ctdh);

            }
            data.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("Xacnhandonhang", "Giohang");
        }
        public ActionResult Xacnhandonhang()
        {
            return View();
        }

    }
}