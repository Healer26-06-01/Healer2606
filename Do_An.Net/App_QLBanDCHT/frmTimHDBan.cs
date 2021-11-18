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
    public partial class frmTimHDBan : Form
    {
        DataTable HDB; //Hoá đơn bán
        public frmTimHDBan()
        {
            InitializeComponent();
        }

        private void frmTimHDBan_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimhoadon.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMahoadon.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahoadon.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtManhanvien.Text == "") && (txtMakhachhang.Text == "") &&
               (txtTongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM HoaDonBan WHERE 1=1";
            if (txtMahoadon.Text != "")
                sql = sql + " AND MaHDB Like N'%" + txtMahoadon.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(NgayBan) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(NgayBan) =" + txtNam.Text;
            if (txtManhanvien.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtManhanvien.Text + "%'";
            if (txtMakhachhang.Text != "")
                sql = sql + " AND MaKH Like N'%" + txtMakhachhang.Text + "%'";
            if (txtTongtien.Text != "")
                sql = sql + " AND TongTien <=" + txtTongtien.Text;
            HDB = Functions.GetDataToTable(sql);
            if (HDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + HDB.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTimhoadon.DataSource = HDB;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgvTimhoadon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvTimhoadon.Columns[1].HeaderText = "Mã nhân viên";
            dgvTimhoadon.Columns[2].HeaderText = "Ngày bán";
            dgvTimhoadon.Columns[3].HeaderText = "Mã khách hàng";
            dgvTimhoadon.Columns[4].HeaderText = "Tổng tiền";
            dgvTimhoadon.Columns[0].Width = 150;
            dgvTimhoadon.Columns[1].Width = 100;
            dgvTimhoadon.Columns[2].Width = 80;
            dgvTimhoadon.Columns[3].Width = 80;
            dgvTimhoadon.Columns[4].Width = 80;
            dgvTimhoadon.AllowUserToAddRows = false;
            dgvTimhoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimhoadon.DataSource = null;
        }

        private void txtTongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvTimhoadon_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgvTimhoadon.CurrentRow.Cells["MaHDBan"].Value.ToString();
                frmHoaDonBan frm = new frmHoaDonBan();
                frm.txtMahoadon.Text = mahd;
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
