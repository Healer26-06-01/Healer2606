using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using App_QLBanDCHT.Class;

namespace App_QLBanDCHT
{
    public partial class frmTimSP : Form
    {
        DataTable SP;
        public frmTimSP()
        {
            InitializeComponent();
        }

        private void frmTimSP_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimSP.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaSP.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaSP.Text == "") && (txtTenSP.Text == "") && (txtMaLoaiSP.Text == "") &&
               (txtSoluong.Text == "") && (txtDongianhap.Text == "") &&
               (txtDongiaban.Text == "") && (txtGhichu.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM SanPham WHERE 1=1";
            if (txtMaSP.Text != "")
                sql = sql + " AND MaSP Like N'%" + txtMaSP.Text + "%'";
            if (txtTenSP.Text != "")
                sql = sql + " AND TenSP Like N'%" + txtTenSP.Text + "%'";
            if (txtMaLoaiSP.Text != "")
                sql = sql + " AND MaLoaiSp Like N'%" + txtMaLoaiSP.Text + "%'";
            if (txtSoluong.Text != "")
                sql = sql + " AND SoLuong Like N'%" + txtSoluong.Text + "%'";
            if (txtDongianhap.Text != "")
                sql = sql + " AND DonGiaNhap Like N'%" + txtDongianhap.Text + "%'";
            if (txtDongiaban.Text != "")
                sql = sql + " AND DonGiaBan Like N'%" + txtDongiaban.Text + "%'";
            if (txtGhichu.Text != "")
                sql = sql + " AND GhiChu Like N'%" + txtGhichu.Text + "%'";
            SP = Functions.GetDataToTable(sql);
            if (SP.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + SP.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTimSP.DataSource = SP;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgvTimSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvTimSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvTimSP.Columns[2].HeaderText = "Mã loại sản phẩm";
            dgvTimSP.Columns[3].HeaderText = "Số lượng";
            dgvTimSP.Columns[4].HeaderText = "Đơn giá nhập";
            dgvTimSP.Columns[5].HeaderText = "Đơn giá bán";
            dgvTimSP.Columns[6].HeaderText = "Ghi chú";
            dgvTimSP.Columns[0].Width = 150;
            dgvTimSP.Columns[1].Width = 100;
            dgvTimSP.Columns[2].Width = 80;
            dgvTimSP.Columns[3].Width = 80;
            dgvTimSP.Columns[4].Width = 80;
            dgvTimSP.Columns[5].Width = 80;
            dgvTimSP.Columns[6].Width = 80;
            dgvTimSP.AllowUserToAddRows = false;
            dgvTimSP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimSP.DataSource = null;
        }

        private void dgvTimSP_DoubleClick(object sender, EventArgs e)
        {
            string masp;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masp = dgvTimSP.CurrentRow.Cells["MaSP"].Value.ToString();
                frmDMSanPham frm = new frmDMSanPham();
                frm.txtMasanpham.Text = masp;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
