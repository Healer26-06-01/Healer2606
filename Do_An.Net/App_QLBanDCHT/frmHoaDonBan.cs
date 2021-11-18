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
    public partial class frmHoaDonBan : Form
    {
        DataTable CTHDB; //Bảng chi tiết hóa đơn bán
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from ChiTietHoaDonBan";
            txtMahoadon.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboMaSP, "MaSP", "TenSP");
            cboMaSP.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMahoadon.Text = "";
            cboMaSP.Text = "";
            txtSoluong.Text = "0";
            txtDongia.Text = "0";
            txtGiamgia.Text = "0";
            txtThanhtien.Text = "0";
            txtSoluong.Enabled = true;
            txtDongia.Enabled = false;
            txtGiamgia.Enabled = false;
            txtThanhtien.Enabled = false;
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from ChiTietHoaDonBan";
            CTHDB = Functions.GetDataToTable(sql);
            dgvCTHDB.DataSource = CTHDB;
            dgvCTHDB.Columns[0].HeaderText = "Mã hóa đơn";
            dgvCTHDB.Columns[1].HeaderText = "Mã sản phẩm";
            dgvCTHDB.Columns[2].HeaderText = "Số lượng";
            dgvCTHDB.Columns[3].HeaderText = "Đơn giá";
            dgvCTHDB.Columns[4].HeaderText = "Giảm giá";
            dgvCTHDB.Columns[5].HeaderText = "Thành tiền";
            dgvCTHDB.Columns[0].Width = 80;
            dgvCTHDB.Columns[1].Width = 140;
            dgvCTHDB.Columns[2].Width = 80;
            dgvCTHDB.Columns[3].Width = 80;
            dgvCTHDB.Columns[4].Width = 100;
            dgvCTHDB.Columns[5].Width = 100;
            dgvCTHDB.AllowUserToAddRows = false;
            dgvCTHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvCTHDB_Click(object sender, EventArgs e)
        {
            string MaSP;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahoadon.Focus();
                return;
            }
            if (CTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMahoadon.Text = dgvCTHDB.CurrentRow.Cells["MaHDB"].Value.ToString();
            MaSP = dgvCTHDB.CurrentRow.Cells["MaSP"].Value.ToString();
            sql = "SELECT TenSP FROM SanPham WHERE MaSP=N'" + MaSP + "'";
            cboMaSP.Text = Functions.GetFieldValues(sql);
            txtSoluong.Text = dgvCTHDB.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDongia.Text = dgvCTHDB.CurrentRow.Cells["DonGia"].Value.ToString();
            txtGiamgia.Text = dgvCTHDB.CurrentRow.Cells["GiamGia"].Value.ToString();
            txtThanhtien.Text = dgvCTHDB.CurrentRow.Cells["ThanhTien"].Value.ToString();
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
            txtMahoadon.Enabled = true;
            txtMahoadon.Focus();
            txtSoluong.Enabled = true;
            txtDongia.Enabled = true;
            txtGiamgia.Enabled = true;
            txtThanhtien.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMahoadon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahoadon.Focus();
                return;
            }
            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSP.Focus();
                return;
            }
            if (txtSoluong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            }
            if (txtDongia.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongia.Focus();
                return;
            }
            if (txtGiamgia.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamgia.Focus();
                return;
            }
            if (txtThanhtien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thành tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThanhtien.Focus();
                return;
            }
            sql = "SELECT MaHDB FROM ChiTietHoaDonBan WHERE MaHDB=N'" + txtMahoadon.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại, bạn phải chọn mã hóa đơn khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahoadon.Focus();
                return;
            }
            sql = "INSERT INTO ChiTietHoaDonBan(MaHDB,MaSP,SoLuong,DonGia,GiamGia,ThanhTien) VALUES(N'"+ txtMahoadon.Text.Trim() +
                "',N'" + cboMaSP.SelectedValue.ToString() +
                "'," + txtSoluong.Text + "," + txtDongia.Text +
                "," + txtGiamgia.Text + ",'" + txtThanhtien.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMahoadon.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (CTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMahoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahoadon.Focus();
                return;
            }
            if (cboMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSP.Focus();
                return;
            }
            sql = "UPDATE ChiTietHoaDonBan SET MaSP=N'" + cboMaSP.SelectedValue.ToString() +
                "',SoLuong=" + txtSoluong.Text + "',DonGia=" + txtDongia.Text + "',GiamGia=" + txtGiamgia.Text +
                 "',ThanhTien=" + txtThanhtien.Text + "' WHERE MaHDB=N'" + txtMahoadon.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (CTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMahoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE ChiTietHoaDonBan WHERE MaHDB=N'" + txtMahoadon.Text + "'";
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
            txtMahoadon.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
