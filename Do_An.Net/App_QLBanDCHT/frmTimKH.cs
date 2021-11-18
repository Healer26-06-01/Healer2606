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
    public partial class frmTimKH : Form
    {
        DataTable KH;
        public frmTimKH()
        {
            InitializeComponent();
        }

        private void frmTimKH_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKH.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaKH.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaKH.Text == "") && (txtTenKH.Text == "") && (txtDiachi.Text == "") &&
               (txtDienthoai.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM KhachHang WHERE 1=1";
            if (txtMaKH.Text != "")
                sql = sql + " AND MaKH Like N'%" + txtMaKH.Text + "%'";
            if (txtTenKH.Text != "")
                sql = sql + " AND TenKH Like N'%" + txtTenKH.Text + "%'";
            if (txtDiachi.Text != "")
                sql = sql + " AND DiaChi Like N'%" + txtDiachi.Text + "%'";
            if (txtDienthoai.Text != "")
                sql = sql + " AND DienThoai Like N'%" + txtDienthoai.Text + "%'";     
            KH = Functions.GetDataToTable(sql);
            if (KH.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + KH.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTimKH.DataSource = KH;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgvTimKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvTimKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvTimKH.Columns[2].HeaderText = "Địa chỉ";
            dgvTimKH.Columns[3].HeaderText = "Điện thoại";
            dgvTimKH.Columns[0].Width = 150;
            dgvTimKH.Columns[1].Width = 100;
            dgvTimKH.Columns[2].Width = 80;
            dgvTimKH.Columns[3].Width = 80;
            dgvTimKH.AllowUserToAddRows = false;
            dgvTimKH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKH.DataSource = null;
        }

        private void dgvTimKH_DoubleClick(object sender, EventArgs e)
        {
            string makh;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                makh = dgvTimKH.CurrentRow.Cells["MaKH"].Value.ToString();
                frmDMKhachHang frm = new frmDMKhachHang();
                frm.txtMaKH.Text = makh;
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
