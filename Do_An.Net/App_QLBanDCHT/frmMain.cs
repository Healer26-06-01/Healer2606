using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QLBanDCHT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmDMLoaiSanPham frmLoaiSanPham = new frmDMLoaiSanPham(); //Khởi tạo đối tượng
            frmLoaiSanPham.ShowDialog(); //Hiển thị
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanvien frmNV = new frmDMNhanvien(); //Khởi tạo đối tượng
            frmNV.ShowDialog(); //Hiển thị
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frmKH= new frmDMKhachHang(); //Khởi tạo đối tượng
            frmKH.ShowDialog(); //Hiển thị
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmDMSanPham frmSP = new frmDMSanPham(); //Khởi tạo đối tượng
            frmSP.ShowDialog(); //Hiển thị
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHDB = new frmHoaDonBan(); //Khởi tạo đối tượng
            frmHDB.ShowDialog(); //Hiển thị
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan frmTHD = new frmTimHDBan(); //Khởi tạo đối tượng
            frmTHD.ShowDialog(); //Hiển thị
        }

        private void mnuFindSanPham_Click(object sender, EventArgs e)
        {
            frmTimSP frmTSP = new frmTimSP(); //Khởi tạo đối tượng
            frmTSP.ShowDialog(); //Hiển thị
        }

        private void mnuBCSanPham_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuFindKhachHang_Click(object sender, EventArgs e)
        {
            frmTimKH frmTKH = new frmTimKH(); //Khởi tạo đối tượng
            frmTKH.ShowDialog(); //Hiển thị
        }

        private void mnuHienTroGiup_Click(object sender, EventArgs e)
        {
            frmTrogiup frmTg = new frmTrogiup(); //Khởi tạo đối tượng
            frmTg.ShowDialog(); //Hiển thị
        }
    }
}
