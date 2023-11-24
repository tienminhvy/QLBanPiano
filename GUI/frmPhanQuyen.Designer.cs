namespace QLBanPiano.GUI
{
    partial class frmPhanQuyen
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
            dsVaiTro = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTimTK = new TextBox();
            btnTimTK = new Button();
            panel2 = new Panel();
            btnXoa = new Button();
            btnTaoMoi = new Button();
            label1 = new Label();
            btnCapNhat = new Button();
            gbDSQuyen = new GroupBox();
            ckNhapXuat = new CheckBox();
            ckQLNhanVien = new CheckBox();
            ckQLKhachHang = new CheckBox();
            ckQLNhacCu = new CheckBox();
            ckQLHoaDon = new CheckBox();
            ckQLNhapHang = new CheckBox();
            ckBanHang = new CheckBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            gbDSQuyen.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dsVaiTro);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // dsVaiTro
            // 
            dsVaiTro.Dock = DockStyle.Fill;
            dsVaiTro.FormattingEnabled = true;
            dsVaiTro.ItemHeight = 20;
            dsVaiTro.Location = new Point(0, 36);
            dsVaiTro.Name = "dsVaiTro";
            dsVaiTro.Size = new Size(250, 414);
            dsVaiTro.TabIndex = 1;
            dsVaiTro.SelectedIndexChanged += dsVaiTro_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.6F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Controls.Add(txtTimTK, 0, 0);
            tableLayoutPanel1.Controls.Add(btnTimTK, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(250, 36);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTimTK
            // 
            txtTimTK.Dock = DockStyle.Fill;
            txtTimTK.Location = new Point(3, 3);
            txtTimTK.Name = "txtTimTK";
            txtTimTK.PlaceholderText = "Tên vai trò cần tìm";
            txtTimTK.Size = new Size(158, 27);
            txtTimTK.TabIndex = 0;
            // 
            // btnTimTK
            // 
            btnTimTK.Location = new Point(167, 3);
            btnTimTK.Name = "btnTimTK";
            btnTimTK.Size = new Size(80, 29);
            btnTimTK.TabIndex = 1;
            btnTimTK.Text = "Tìm";
            btnTimTK.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnTaoMoi);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCapNhat);
            panel2.Controls.Add(gbDSQuyen);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 450);
            panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.Location = new Point(356, 391);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá vai trò";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTaoMoi.Location = new Point(446, 5);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(104, 29);
            btnTaoMoi.TabIndex = 3;
            btnTaoMoi.Text = "Thêm vai trò";
            btnTaoMoi.UseVisualStyleBackColor = true;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 2;
            label1.Text = "Vai trò đang chọn: ";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapNhat.Location = new Point(456, 391);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // gbDSQuyen
            // 
            gbDSQuyen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbDSQuyen.Controls.Add(ckNhapXuat);
            gbDSQuyen.Controls.Add(ckQLNhanVien);
            gbDSQuyen.Controls.Add(ckQLKhachHang);
            gbDSQuyen.Controls.Add(ckQLNhacCu);
            gbDSQuyen.Controls.Add(ckQLHoaDon);
            gbDSQuyen.Controls.Add(ckQLNhapHang);
            gbDSQuyen.Controls.Add(ckBanHang);
            gbDSQuyen.Location = new Point(6, 38);
            gbDSQuyen.Name = "gbDSQuyen";
            gbDSQuyen.Size = new Size(553, 347);
            gbDSQuyen.TabIndex = 0;
            gbDSQuyen.TabStop = false;
            gbDSQuyen.Text = "Danh sách quyền";
            // 
            // ckNhapXuat
            // 
            ckNhapXuat.AutoSize = true;
            ckNhapXuat.Location = new Point(23, 215);
            ckNhapXuat.Name = "ckNhapXuat";
            ckNhapXuat.Size = new Size(149, 24);
            ckNhapXuat.TabIndex = 6;
            ckNhapXuat.Text = "Nhập xuất dữ liệu";
            ckNhapXuat.UseVisualStyleBackColor = true;
            // 
            // ckQLNhanVien
            // 
            ckQLNhanVien.AutoSize = true;
            ckQLNhanVien.Location = new Point(23, 185);
            ckQLNhanVien.Name = "ckQLNhanVien";
            ckQLNhanVien.Size = new Size(319, 24);
            ckQLNhanVien.TabIndex = 5;
            ckQLNhanVien.Text = "Quản lý thông tin nhân viên (kèm tài khoản)";
            ckQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // ckQLKhachHang
            // 
            ckQLKhachHang.AutoSize = true;
            ckQLKhachHang.Location = new Point(23, 155);
            ckQLKhachHang.Name = "ckQLKhachHang";
            ckQLKhachHang.Size = new Size(224, 24);
            ckQLKhachHang.TabIndex = 4;
            ckQLKhachHang.Text = "Quản lý thông tin khách hàng";
            ckQLKhachHang.UseVisualStyleBackColor = true;
            // 
            // ckQLNhacCu
            // 
            ckQLNhacCu.AutoSize = true;
            ckQLNhacCu.Location = new Point(23, 125);
            ckQLNhacCu.Name = "ckQLNhacCu";
            ckQLNhacCu.Size = new Size(176, 24);
            ckQLNhacCu.TabIndex = 3;
            ckQLNhacCu.Text = "Quản lý nhạc cụ Piano";
            ckQLNhacCu.UseVisualStyleBackColor = true;
            // 
            // ckQLHoaDon
            // 
            ckQLHoaDon.AutoSize = true;
            ckQLHoaDon.Location = new Point(23, 95);
            ckQLHoaDon.Name = "ckQLHoaDon";
            ckQLHoaDon.Size = new Size(140, 24);
            ckQLHoaDon.TabIndex = 2;
            ckQLHoaDon.Text = "Quản lý hoá đơn";
            ckQLHoaDon.UseVisualStyleBackColor = true;
            // 
            // ckQLNhapHang
            // 
            ckQLNhapHang.AutoSize = true;
            ckQLNhapHang.Location = new Point(23, 65);
            ckQLNhapHang.Name = "ckQLNhapHang";
            ckQLNhapHang.Size = new Size(155, 24);
            ckQLNhapHang.TabIndex = 1;
            ckQLNhapHang.Text = "Quản lý nhập hàng";
            ckQLNhapHang.UseVisualStyleBackColor = true;
            // 
            // ckBanHang
            // 
            ckBanHang.AutoSize = true;
            ckBanHang.Location = new Point(23, 35);
            ckBanHang.Name = "ckBanHang";
            ckBanHang.Size = new Size(93, 24);
            ckBanHang.TabIndex = 0;
            ckBanHang.Text = "Bán hàng";
            ckBanHang.UseVisualStyleBackColor = true;
            // 
            // frmPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPhanQuyen";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gbDSQuyen.ResumeLayout(false);
            gbDSQuyen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTimTK;
        private Button btnTimTK;
        private ComboBox cbbTieuChi;
        private ListBox dsVaiTro;
        private Panel panel2;
        private GroupBox gbDSQuyen;
        private CheckBox ckBanHang;
        private CheckBox ckNhapXuat;
        private CheckBox ckQLNhanVien;
        private CheckBox ckQLKhachHang;
        private CheckBox ckQLNhacCu;
        private CheckBox ckQLHoaDon;
        private CheckBox ckQLNhapHang;
        private Button btnCapNhat;
        private Label label1;
        private Button btnXoa;
        private Button btnTaoMoi;
    }
}