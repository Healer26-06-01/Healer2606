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
    public partial class frmDMSanPham : Form
    {
        DataTable SP; //Bảng sản phẩm
        public frmDMSanPham()
        {
            InitializeComponent();
        }

        private void frmDMSanPham_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from SanPham";
            txtMasanpham.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboMaloaiSP, "MaLoaiSp", "TenLoaiSP");
            cboMaloaiSP.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMasanpham.Text = "";
            txtTensanpham.Text = "";
            cboMaloaiSP.Text = "";
            txtSoluong.Text = "0";
            txtDongianhap.Text = "0";
            txtDongiaban.Text = "0";
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = false;
            txtDongiaban.Enabled = false;
            txtGhichu.Text = "";
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from SanPham";
            SP = Functions.GetDataToTable(sql);
            dgvSP.DataSource = SP;
            dgvSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSP.Columns[2].HeaderText = "Loại sản phẩm";
            dgvSP.Columns[3].HeaderText = "Số lượng";
            dgvSP.Columns[4].HeaderText = "Đơn giá nhập";
            dgvSP.Columns[5].HeaderText = "Đơn giá bán";
            dgvSP.Columns[6].HeaderText = "Ghi chú";
            dgvSP.Columns[0].Width = 80;
            dgvSP.Columns[2].Width = 80;
            dgvSP.Columns[3].Width = 80;
            dgvSP.Columns[4].Width = 100;
            dgvSP.Columns[5].Width = 100;       
            dgvSP.Columns[6].Width = 300;
            dgvSP.AllowUserToAddRows = false;
            dgvSP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvSP_Click(object sender, EventArgs e)
        {
            string MaLoaiSP;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (SP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMasanpham.Text = dgvSP.CurrentRow.Cells["MaSP"].Value.ToString();
            txtTensanpham.Text = dgvSP.CurrentRow.Cells["TenSP"].Value.ToString();
            MaLoaiSP = dgvSP.CurrentRow.Cells["MaLoaiSp"].Value.ToString();
            sql = "SELECT TenLoaiSP FROM LoaiSanPham WHERE MaLoaiSp=N'" + MaLoaiSP + "'";
            cboMaloaiSP.Text = Functions.GetFieldValues(sql);
            txtSoluong.Text = dgvSP.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDongianhap.Text = dgvSP.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDongiaban.Text = dgvSP.CurrentRow.Cells["DonGiaBan"].Value.ToString();                        
            sql = "SELECT GhiChu FROM SanPham WHERE MaSP = N'" + txtMasanpham.Text + "'";
            txtGhichu.Text = Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMasanpham.Enabled = true;
            txtMasanpham.Focus();
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMasanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (txtTensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sảm phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTensanpham.Focus();
                return;
            }
            if (cboMaloaiSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaloaiSP.Focus();
                return;
            }
            sql = "SELECT MaSP FROM SanPham WHERE MaSP=N'" + txtMasanpham.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại, bạn phải chọn mã sản phẩm khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            sql = "INSERT INTO SanPham(MaSP,TenSP,MaLoaiSP,SoLuong,DonGiaNhap, DonGiaBan,Ghichu) VALUES(N'"
                + txtMasanpham.Text.Trim() + "',N'" + txtTensanpham.Text.Trim() +
                "',N'" + cboMaloaiSP.SelectedValue.ToString() +
                "'," + txtSoluong.Text.Trim() + "," + txtDongianhap.Text +
                "," + txtDongiaban.Text + ",'"+ txtGhichu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMasanpham.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (SP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (txtTensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTensanpham.Focus();
                return;
            }
            if (cboMaloaiSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaloaiSP.Focus();
                return;
            }
            sql = "UPDATE SanPham SET TenSP=N'" + txtTensanpham.Text.Trim().ToString() +
                "',MaLoaiSp=N'" + cboMaloaiSP.SelectedValue.ToString() +
                "',SoLuong=" + txtSoluong.Text +
                "',Ghichu=N'" + txtGhichu.Text + "' WHERE MaSP=N'" + txtMasanpham.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (SP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE SanPham WHERE MaSP=N'" + txtMasanpham.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMasanpham.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMasanpham.Text == "") && (txtTensanpham.Text == "") && (cboMaloaiSP.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from SanPham WHERE 1=1";
            if (txtMasanpham.Text != "")
                sql += " AND MaSP LIKE N'%" + txtMasanpham.Text + "%'";
            if (txtTensanpham.Text != "")
                sql += " AND MaSP LIKE N'%" + txtTensanpham.Text + "%'";
            if (cboMaloaiSP.Text != "")
                sql += " AND MaLoaiSp LIKE N'%" + cboMaloaiSP.SelectedValue + "%'";
            SP = Functions.GetDataToTable(sql);
            if (SP.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + SP.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSP.DataSource = SP;
            ResetValues();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaSP,TenSP,MaLoaiSp,SoLuong,DonGiaNhap,DonGiaBan,Ghichu FROM SanPham";
            SP = Functions.GetDataToTable(sql);
            dgvSP.DataSource = SP;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
