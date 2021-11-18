namespace App_QLBanDCHT
{
    partial class frmDMSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.txtMasanpham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cboMaloaiSP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(191, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(41, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(295, 157);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(289, 22);
            this.txtTensanpham.TabIndex = 1;
            // 
            // txtMasanpham
            // 
            this.txtMasanpham.Location = new System.Drawing.Point(295, 90);
            this.txtMasanpham.Name = "txtMasanpham";
            this.txtMasanpham.Size = new System.Drawing.Size(289, 22);
            this.txtMasanpham.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(424, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(1095, 33);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 40);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBoqua.Location = new System.Drawing.Point(645, 33);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(90, 40);
            this.btnBoqua.TabIndex = 4;
            this.btnBoqua.Text = "&Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.Location = new System.Drawing.Point(494, 33);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 40);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Location = new System.Drawing.Point(344, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSP.Location = new System.Drawing.Point(0, 362);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(1295, 251);
            this.dgvSP.TabIndex = 8;
            this.dgvSP.Click += new System.EventHandler(this.dgvSP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboMaloaiSP);
            this.panel2.Controls.Add(this.txtGhichu);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDongiaban);
            this.panel2.Controls.Add(this.txtDongianhap);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSoluong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTensanpham);
            this.panel2.Controls.Add(this.txtMasanpham);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1295, 362);
            this.panel2.TabIndex = 7;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(883, 226);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(289, 86);
            this.txtGhichu.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ghi chú";
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(883, 155);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(289, 22);
            this.txtDongiaban.TabIndex = 10;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(883, 88);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(289, 22);
            this.txtDongianhap.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(690, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đơn giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(690, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đơn giá nhập";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(295, 288);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(289, 22);
            this.txtSoluong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã loại sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHienthi);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 106);
            this.panel1.TabIndex = 6;
            // 
            // btnHienthi
            // 
            this.btnHienthi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienthi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHienthi.Location = new System.Drawing.Point(944, 33);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(90, 40);
            this.btnHienthi.TabIndex = 7;
            this.btnHienthi.Text = "&Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = false;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimkiem.Location = new System.Drawing.Point(797, 33);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(90, 40);
            this.btnTimkiem.TabIndex = 6;
            this.btnTimkiem.Text = "&Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cboMaloaiSP
            // 
            this.cboMaloaiSP.FormattingEnabled = true;
            this.cboMaloaiSP.Location = new System.Drawing.Point(295, 224);
            this.cboMaloaiSP.Name = "cboMaloaiSP";
            this.cboMaloaiSP.Size = new System.Drawing.Size(289, 24);
            this.cboMaloaiSP.TabIndex = 13;
            // 
            // frmDMSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 719);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDMSanPham";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmDMSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTensanpham;
        public System.Windows.Forms.TextBox txtMasanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cboMaloaiSP;
    }
}