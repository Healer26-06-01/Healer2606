
namespace App_QLBanDCHT
{
    partial class frmTimKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.dgvTimKH = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(241, 77);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(227, 22);
            this.txtMaKH.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(241, 144);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(227, 22);
            this.txtTenKH.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điện thoại";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(783, 77);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(227, 22);
            this.txtDiachi.TabIndex = 10;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(783, 139);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(227, 22);
            this.txtDienthoai.TabIndex = 11;
            // 
            // dgvTimKH
            // 
            this.dgvTimKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKH.Location = new System.Drawing.Point(-44, 207);
            this.dgvTimKH.Name = "dgvTimKH";
            this.dgvTimKH.RowHeadersWidth = 51;
            this.dgvTimKH.RowTemplate.Height = 24;
            this.dgvTimKH.Size = new System.Drawing.Size(1335, 262);
            this.dgvTimKH.TabIndex = 12;
            this.dgvTimKH.DoubleClick += new System.EventHandler(this.dgvTimKH_DoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(79, 498);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(338, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Nhấn đúp vào khách hàng để hiện thông tin chi tiết  ";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimkiem.Location = new System.Drawing.Point(229, 576);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(120, 30);
            this.btnTimkiem.TabIndex = 31;
            this.btnTimkiem.Text = "&Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimlai.Location = new System.Drawing.Point(519, 576);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(120, 30);
            this.btnTimlai.TabIndex = 32;
            this.btnTimlai.Text = "&Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = false;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDong.Location = new System.Drawing.Point(817, 576);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 30);
            this.btnDong.TabIndex = 33;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmTimKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 676);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvTimKH);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKH";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm khách hàng";
            this.Load += new System.EventHandler(this.frmTimKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.DataGridView dgvTimKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnDong;
    }
}