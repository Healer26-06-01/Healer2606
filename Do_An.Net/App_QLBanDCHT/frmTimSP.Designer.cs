
namespace App_QLBanDCHT
{
    partial class frmTimSP
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
            this.dgvTimSP = new System.Windows.Forms.DataGridView();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimSP
            // 
            this.dgvTimSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimSP.Location = new System.Drawing.Point(0, 300);
            this.dgvTimSP.Name = "dgvTimSP";
            this.dgvTimSP.RowHeadersWidth = 51;
            this.dgvTimSP.RowTemplate.Height = 24;
            this.dgvTimSP.Size = new System.Drawing.Size(1231, 251);
            this.dgvTimSP.TabIndex = 5;
            this.dgvTimSP.DoubleClick += new System.EventHandler(this.dgvTimSP_DoubleClick);
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(297, 119);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(227, 22);
            this.txtMaLoaiSP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã loại sản phẩm";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(838, 116);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(227, 22);
            this.txtSoluong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(838, 63);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(227, 22);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(297, 63);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(227, 22);
            this.txtMaSP.TabIndex = 4;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnTimlai);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 121);
            this.panel2.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(69, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(326, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nhấn đúp vào sản phẩm để hiện thông tin chi tiết  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGhichu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDongiaban);
            this.panel1.Controls.Add(this.txtDongianhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaLoaiSP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSoluong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 300);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đơn giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Đơn giá bán";
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(297, 182);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(227, 22);
            this.txtDongianhap.TabIndex = 14;
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(297, 234);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(227, 22);
            this.txtDongiaban.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ghi chú";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(838, 187);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(227, 86);
            this.txtGhichu.TabIndex = 17;
            // 
            // frmTimSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 672);
            this.Controls.Add(this.dgvTimSP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimSP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm sản phẩm";
            this.Load += new System.EventHandler(this.frmTimSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimSP;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtMaSP;
    }
}