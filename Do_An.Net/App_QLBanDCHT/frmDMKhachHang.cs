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
    public partial class frmDMKhachHang : Form
    {
        DataTable KH; //Bảng khách hàng
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        private void frmDMKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from KhachHang";
            KH = Functions.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvKhachhang.DataSource = KH; //Hiển thị vào dataGridView
            dgvKhachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachhang.Columns[3].HeaderText = "Điện thoại";
            dgvKhachhang.Columns[0].Width = 200;
            dgvKhachhang.Columns[1].Width = 200;
            dgvKhachhang.Columns[2].Width = 150;
            dgvKhachhang.Columns[3].Width = 150;
            dgvKhachhang.AllowUserToAddRows = false;
            dgvKhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvKhachhang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (KH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKhachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvKhachhang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDiachi.Text = dgvKhachhang.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbDienthoai.Text = dgvKhachhang.CurrentRow.Cells["DienThoai"].Value.ToString();
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
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
        }
        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiachi.Text = "";
            mtbDienthoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienthoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienthoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT MaKH FROM KhachHang WHERE MaKH=N'" + txtMaKH.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO KhachHang VALUES (N'" + txtMaKH.Text.Trim() +
                "',N'" + txtTenKH.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mtbDienthoai.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (KH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienthoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienthoai.Focus();
                return;
            }
            sql = "UPDATE KhachHang SET TenKH=N'" + txtTenKH.Text.Trim().ToString() + "',DiaChi=N'" + txtDiachi.Text.Trim().ToString() + "',DienThoai='" + mtbDienthoai.Text.ToString() +"' WHERE MaKH=N'" + txtMaKH.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (KH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhach WHERE MaKhach=N'" + txtMaKH.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKH.Enabled = false;
        }

        private void txtMaKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenKH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mtbDienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
