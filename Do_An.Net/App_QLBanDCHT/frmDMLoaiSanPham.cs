using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using App_QLBanDCHT.Class; //Sử dụng class Functions.cs


namespace App_QLBanDCHT
{
    public partial class frmDMLoaiSanPham : Form
    {
        DataTable LSP; //Chứa dữ liệu bảng loại sản phẩm
        public frmDMLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmDMLoaiSanPham_Load(object sender, EventArgs e)
        {
            txtMaloaisanpham.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng loại sản phẩm
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaLoaiSp, TenLoaiSP FROM LoaiSanPham";
            LSP = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvLoaisanpham.DataSource = LSP; //Nguồn dữ liệu            
            dgvLoaisanpham.Columns[0].HeaderText = "Mã loại sản phẩm";
            dgvLoaisanpham.Columns[1].HeaderText = "Tên loại sản phẩm";
            dgvLoaisanpham.Columns[0].Width = 200;
            dgvLoaisanpham.Columns[1].Width = 300;
            dgvLoaisanpham.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvLoaisanpham.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvLoaisanpham_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaloaisanpham.Focus();
                return;
            }
            if (LSP.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaloaisanpham.Text = dgvLoaisanpham.CurrentRow.Cells["MaLoaiSp"].Value.ToString();
            txtTenloaisanpham.Text = dgvLoaisanpham.CurrentRow.Cells["TenLoaiSP"].Value.ToString();
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
            ResetValue(); //Xoá trắng các textbox
            txtMaloaisanpham.Enabled = true; //cho phép nhập mới
            txtMaloaisanpham.Focus();
        }
        private void ResetValue()
        {
            txtMaloaisanpham.Text = "";
            txtTenloaisanpham.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                string sql; //Lưu lệnh sql
                if (txtMaloaisanpham.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
                {
                    MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaloaisanpham.Focus();
                    return;
                }
                if (txtTenloaisanpham.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
                {
                    MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenloaisanpham.Focus();
                    return;
                }
                sql = "Select MaLoaiSp From LoaiSanPham where MaLoaiSp=N'" + txtMaloaisanpham.Text.Trim() + "'";
                if (Class.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaloaisanpham.Focus();
                    return;
                }

                sql = "INSERT INTO LoaiSanPham VALUES(N'" +txtMaloaisanpham.Text + "',N'" + txtTenloaisanpham.Text + "')";
                Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
                LoadDataGridView(); //Nạp lại DataGridView
                ResetValue();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoqua.Enabled = false;
                btnLuu.Enabled = false;
                txtMaloaisanpham.Enabled = false;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (LSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloaisanpham.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenloaisanpham.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE LoaiSanPham SET TenLoaiSP=N'" +txtTenloaisanpham.Text.ToString() +"' WHERE MaLoaiSp=N'" + txtMaloaisanpham.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (LSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaloaisanpham.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE LoaiSanPham WHERE MaLoaiSp=N'" + txtMaloaisanpham.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaloaisanpham.Enabled = false;
        }

        private void txtMaloaisanpham_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenloaisanpham_KeyUp(object sender, KeyEventArgs e)
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
