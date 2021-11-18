
namespace App_QLBanDCHT
{
    partial class frmTimHDBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvTimhoadon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtManhanvien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTongtien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.txtMakhachhang);
            this.panel1.Controls.Add(this.txtMahoadon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 300);
            this.panel1.TabIndex = 0;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(297, 205);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(227, 22);
            this.txtManhanvien.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã nhân viên";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(838, 122);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(227, 22);
            this.txtTongtien.TabIndex = 9;
            this.txtTongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongtien_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(665, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng tiền";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(424, 122);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 22);
            this.txtNam.TabIndex = 7;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(229, 123);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 22);
            this.txtThang.TabIndex = 6;
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Location = new System.Drawing.Point(838, 63);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(227, 22);
            this.txtMakhachhang.TabIndex = 5;
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(297, 63);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(227, 22);
            this.txtMahoadon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnTimlai);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 597);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 121);
            this.panel2.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDong.Location = new System.Drawing.Point(726, 53);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 30);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimlai.Location = new System.Drawing.Point(502, 53);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(120, 30);
            this.btnTimlai.TabIndex = 31;
            this.btnTimlai.Text = "&Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = false;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimkiem.Location = new System.Drawing.Point(269, 53);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(120, 30);
            this.btnTimkiem.TabIndex = 30;
            this.btnTimkiem.Text = "&Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(69, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(316, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nhấn đúp vào hóa đơn để hiện thông tin chi tiết  ";
            // 
            // dgvTimhoadon
            // 
            this.dgvTimhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimhoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimhoadon.Location = new System.Drawing.Point(0, 300);
            this.dgvTimhoadon.Name = "dgvTimhoadon";
            this.dgvTimhoadon.RowHeadersWidth = 51;
            this.dgvTimhoadon.RowTemplate.Height = 24;
            this.dgvTimhoadon.Size = new System.Drawing.Size(1247, 297);
            this.dgvTimhoadon.TabIndex = 2;
            this.dgvTimhoadon.DoubleClick += new System.EventHandler(this.dgvTimhoadon_DoubleClick);
            // 
            // frmTimHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 718);
            this.Controls.Add(this.dgvTimhoadon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimHDBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm hóa đơn";
            this.Load += new System.EventHandler(this.frmTimHDBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimhoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtMakhachhang;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTimhoadon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnTimkiem;
    }
}