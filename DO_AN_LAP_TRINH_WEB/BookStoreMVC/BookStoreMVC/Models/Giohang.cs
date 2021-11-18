using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreMVC.Models
{
    public class Giohang
    {
        //Tạo đối tượng data chứa dữ liệu từ model dbBansach đã tạo.
        dbQLBansachDataContext data = new dbQLBansachDataContext();
        public int iMasach { set; get; }
        public string sTensach { set; get; }
        public string sAnhbia { set; get; }
        public Double dDongia { set; get; }
        public int iSoluong { set; get; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        //Khởi tạo giở hàng theo Masach được truyền vào với Soluong mặc định là 1
        public Giohang(int Masach)
        {
            iMasach = Masach;
            Sach sach = data.Saches.Single(n => n.MaSach == iMasach);
            sTensach = sach.TenSach;
            sAnhbia = sach.AnhBia;
            dDongia = double.Parse(sach.GiaBan.ToString());
            iSoluong = 1;
        }
    }
}