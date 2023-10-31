namespace QLBanPiano.GUI.SubForm
{
    partial class ThemSanPham
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtMa = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            txtGia = new TextBox();
            label5 = new Label();
            ptbAnh = new PictureBox();
            label6 = new Label();
            cbbThuongHieu = new ComboBox();
            label7 = new Label();
            cbbLoai = new ComboBox();
            label8 = new Label();
            txtDacDiem = new TextBox();
            txtMoTa = new TextBox();
            label9 = new Label();
            btnThem = new Button();
            btnNhapLai = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnNhapLai);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtMoTa);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtDacDiem);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbbLoai);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbbThuongHieu);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ptbAnh);
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 454);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 88);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(213, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 41);
            label2.TabIndex = 1;
            label2.Text = "Thêm Sản Phẩm";
            // 
            // txtID
            // 
            txtID.Location = new Point(76, 81);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(104, 27);
            txtID.TabIndex = 2;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(234, 81);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(126, 27);
            txtMa.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 88);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(122, 133);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(238, 27);
            txtTen.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 136);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(76, 223);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(104, 27);
            txtGia.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 226);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 7;
            label5.Text = "Giá:";
            // 
            // ptbAnh
            // 
            ptbAnh.Location = new Point(366, 81);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(270, 173);
            ptbAnh.TabIndex = 9;
            ptbAnh.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 182);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 10;
            label6.Text = "Thương Hiệu:";
            // 
            // cbbThuongHieu
            // 
            cbbThuongHieu.FormattingEnabled = true;
            cbbThuongHieu.Location = new Point(122, 179);
            cbbThuongHieu.Name = "cbbThuongHieu";
            cbbThuongHieu.Size = new Size(238, 28);
            cbbThuongHieu.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 226);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 12;
            label7.Text = "Loại:";
            // 
            // cbbLoai
            // 
            cbbLoai.FormattingEnabled = true;
            cbbLoai.Location = new Point(232, 222);
            cbbLoai.Name = "cbbLoai";
            cbbLoai.Size = new Size(128, 28);
            cbbLoai.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 278);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 14;
            label8.Text = "Đặc Điểm:";
            // 
            // txtDacDiem
            // 
            txtDacDiem.Location = new Point(108, 275);
            txtDacDiem.Multiline = true;
            txtDacDiem.Name = "txtDacDiem";
            txtDacDiem.Size = new Size(211, 94);
            txtDacDiem.TabIndex = 15;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(385, 275);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(251, 94);
            txtMoTa.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(325, 278);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 16;
            label9.Text = "Mô Tả:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Lime;
            btnThem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(385, 387);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 53);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnNhapLai
            // 
            btnNhapLai.BackColor = Color.Yellow;
            btnNhapLai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapLai.Location = new Point(255, 387);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(105, 53);
            btnNhapLai.TabIndex = 19;
            btnNhapLai.Text = "Nhập Lại";
            btnNhapLai.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Red;
            btnThoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(121, 387);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 53);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // ThemSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 460);
            Controls.Add(panel1);
            Name = "ThemSanPham";
            Text = "ThemSanPham";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtTen;
        private Label label4;
        private TextBox txtMa;
        private Label label3;
        private TextBox txtID;
        private TextBox txtGia;
        private Label label5;
        private PictureBox ptbAnh;
        private Label label6;
        private ComboBox cbbThuongHieu;
        private Label label7;
        private ComboBox cbbLoai;
        private Label label8;
        private TextBox txtDacDiem;
        private TextBox txtMoTa;
        private Label label9;
        private Button btnThem;
        private Button btnNhapLai;
        private Button btnThoat;
    }
}