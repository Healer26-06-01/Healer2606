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
    public partial class frmDMNhanvien : Form
    {
        DataTable NV; //Lưu dữ liệu bảng nhân viên

        public frmDMNhanvien()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienthoai.Focus();
                return;
            }

            if (chkNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaNV FROM NhanVien WHERE MaNV=N'" + txtManhanvien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO NhanVien(MaNV,TenNV,GioiTinh, DiaChi,DienThoai) VALUES (N'" + txtManhanvien.Text.Trim() + "',N'" + txtTennhanvien.Text.Trim() + "',N'" + gt + "',N'" + txtDiachi.Text.Trim() + "','" + mtbDienthoai.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (NV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mtbDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienthoai.Focus();
                return;
            }

            if (chkNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE NhanVien SET  TenNV=N'" + txtTennhanvien.Text.Trim().ToString() + "',DiaChi=N'" + txtDiachi.Text.Trim().ToString() + "',DienThoai='" + mtbDienthoai.Text.ToString() + "',GioiTinh=N'" + gt + "' WHERE MaNV=N'" + txtManhanvien.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (NV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNV=N'" + txtManhanvien.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
        }
        private void ResetValues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            chkNam.Checked = false;
            txtDiachi.Text = "";
            mtbDienthoai.Text = "";
          
        }
        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtbNgaysinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbDienthoai_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTennhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtManhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmDMNhanvien_Load(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNV,TenNV,GioiTinh,DiaChi,DienThoai FROM NhanVien";
            NV = Functions.GetDataToTable(sql); //lấy dữ liệu
            dgvNhanvien.DataSource = NV;
            dgvNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanvien.Columns[2].HeaderText = "Giới tính";
            dgvNhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns[4].HeaderText = "Điện thoại";
          
            dgvNhanvien.Columns[0].Width = 100;
            dgvNhanvien.Columns[1].Width = 150;
            dgvNhanvien.Columns[2].Width = 100;
            dgvNhanvien.Columns[3].Width = 150;
            dgvNhanvien.Columns[4].Width = 100;
         
            dgvNhanvien.AllowUserToAddRows = false;
            dgvNhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNhanvien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (NV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhanvien.Text = dgvNhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTennhanvien.Text = dgvNhanvien.CurrentRow.Cells["TenNV"].Value.ToString();
            if (dgvNhanvien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkNam.Checked = true;
            else chkNam.Checked = false;
            txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbDienthoai.Text = dgvNhanvien.CurrentRow.Cells["DienThoai"].Value.ToString();
          
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void txtManhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTennhanvien_KeyUp(object sender, KeyEventArgs e)
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

        private void mtbNgaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
