namespace DoAn
{
    partial class Product
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            panel2 = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            btnNhapLai = new Button();
            btnThemSP = new Button();
            txtMoTaSP = new TextBox();
            label9 = new Label();
            txtDacDiemSP = new TextBox();
            label4 = new Label();
            cbbLoaiSP = new ComboBox();
            label7 = new Label();
            cbbThuongHieuSP = new ComboBox();
            label6 = new Label();
            ptbAnh = new PictureBox();
            txtGiaSP = new TextBox();
            label10 = new Label();
            txtTenSP = new TextBox();
            label11 = new Label();
            txtMaSP = new TextBox();
            label12 = new Label();
            txtIDSP = new TextBox();
            label13 = new Label();
            label14 = new Label();
            panel1 = new Panel();
            dgvSanPham = new DataGridView();
            headerPanel = new Panel();
            btnDatLai = new Button();
            btnTim = new Button();
            cbbThuongHieuTimKiem = new ComboBox();
            cbbGiaTimKiem = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtTenTimKiem = new TextBox();
            label1 = new Label();
            txtMaTimKiem = new TextBox();
            label2 = new Label();
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1259, 720);
            mainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnNhapLai);
            panel2.Controls.Add(btnThemSP);
            panel2.Controls.Add(txtMoTaSP);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtDacDiemSP);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cbbLoaiSP);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cbbThuongHieuSP);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ptbAnh);
            panel2.Controls.Add(txtGiaSP);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtTenSP);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtMaSP);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtIDSP);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(873, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 715);
            panel2.TabIndex = 2;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(143, 652);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 53);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(13, 652);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 53);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.BackColor = Color.FromArgb(128, 255, 255);
            btnNhapLai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapLai.Location = new Point(266, 503);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(105, 53);
            btnNhapLai.TabIndex = 19;
            btnNhapLai.Text = "Nhập Lại";
            btnNhapLai.UseVisualStyleBackColor = false;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // btnThemSP
            // 
            btnThemSP.BackColor = Color.Lime;
            btnThemSP.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemSP.Location = new Point(267, 652);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(105, 53);
            btnThemSP.TabIndex = 18;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = false;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // txtMoTaSP
            // 
            txtMoTaSP.Location = new Point(115, 403);
            txtMoTaSP.Multiline = true;
            txtMoTaSP.Name = "txtMoTaSP";
            txtMoTaSP.Size = new Size(255, 95);
            txtMoTaSP.TabIndex = 17;
            txtMoTaSP.KeyPress += txtMoTaSP_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 403);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 16;
            label9.Text = "Mô Tả:";
            // 
            // txtDacDiemSP
            // 
            txtDacDiemSP.Location = new Point(115, 287);
            txtDacDiemSP.Multiline = true;
            txtDacDiemSP.Name = "txtDacDiemSP";
            txtDacDiemSP.Size = new Size(255, 95);
            txtDacDiemSP.TabIndex = 15;
            txtDacDiemSP.KeyPress += txtDacDiemSP_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 291);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 14;
            label4.Text = "Đặc Điểm:";
            // 
            // cbbLoaiSP
            // 
            cbbLoaiSP.FormattingEnabled = true;
            cbbLoaiSP.Items.AddRange(new object[] { "điện", "Upright", "Grand" });
            cbbLoaiSP.Location = new Point(55, 215);
            cbbLoaiSP.Name = "cbbLoaiSP";
            cbbLoaiSP.Size = new Size(134, 28);
            cbbLoaiSP.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 219);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 12;
            label7.Text = "Loại:";
            // 
            // cbbThuongHieuSP
            // 
            cbbThuongHieuSP.FormattingEnabled = true;
            cbbThuongHieuSP.Location = new Point(115, 252);
            cbbThuongHieuSP.Name = "cbbThuongHieuSP";
            cbbThuongHieuSP.Size = new Size(255, 28);
            cbbThuongHieuSP.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 255);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 10;
            label6.Text = "Thương Hiệu:";
            // 
            // ptbAnh
            // 
            ptbAnh.Location = new Point(198, 73);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(173, 173);
            ptbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnh.TabIndex = 9;
            ptbAnh.TabStop = false;
            ptbAnh.MouseClick += ptbAnh_MouseClick;
            // 
            // txtGiaSP
            // 
            txtGiaSP.Location = new Point(55, 181);
            txtGiaSP.Name = "txtGiaSP";
            txtGiaSP.Size = new Size(134, 27);
            txtGiaSP.TabIndex = 8;
            txtGiaSP.KeyPress += txtGiaSP_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 185);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 7;
            label10.Text = "Giá:";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(55, 149);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(134, 27);
            txtTenSP.TabIndex = 6;
            txtTenSP.KeyPress += txtTenSP_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 152);
            label11.Name = "label11";
            label11.Size = new Size(35, 20);
            label11.TabIndex = 5;
            label11.Text = "Tên:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(54, 116);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(78, 27);
            txtMaSP.TabIndex = 4;
            txtMaSP.KeyPress += txtMaSP_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 119);
            label12.Name = "label12";
            label12.Size = new Size(33, 20);
            label12.TabIndex = 3;
            label12.Text = "Mã:";
            // 
            // txtIDSP
            // 
            txtIDSP.Location = new Point(55, 84);
            txtIDSP.Name = "txtIDSP";
            txtIDSP.ReadOnly = true;
            txtIDSP.Size = new Size(77, 27);
            txtIDSP.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(54, 0);
            label13.Name = "label13";
            label13.Size = new Size(273, 41);
            label13.TabIndex = 1;
            label13.Text = "Chi Tiết Sản Phẩm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 87);
            label14.Name = "label14";
            label14.Size = new Size(27, 20);
            label14.TabIndex = 0;
            label14.Text = "ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSanPham);
            panel1.Location = new Point(0, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 595);
            panel1.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(0, 0);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 29;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(867, 595);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.CellMouseClick += dgvSanPham_CellMouseClick;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(btnDatLai);
            headerPanel.Controls.Add(btnTim);
            headerPanel.Controls.Add(cbbThuongHieuTimKiem);
            headerPanel.Controls.Add(cbbGiaTimKiem);
            headerPanel.Controls.Add(label8);
            headerPanel.Controls.Add(label5);
            headerPanel.Controls.Add(label3);
            headerPanel.Controls.Add(txtTenTimKiem);
            headerPanel.Controls.Add(label1);
            headerPanel.Controls.Add(txtMaTimKiem);
            headerPanel.Controls.Add(label2);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(870, 125);
            headerPanel.TabIndex = 0;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // btnDatLai
            // 
            btnDatLai.Anchor = AnchorStyles.Left;
            btnDatLai.BackColor = Color.FromArgb(255, 255, 192);
            btnDatLai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatLai.Location = new Point(787, 68);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(83, 37);
            btnDatLai.TabIndex = 21;
            btnDatLai.Text = "Đặt Lại";
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Left;
            btnTim.BackColor = Color.FromArgb(192, 255, 192);
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTim.Location = new Point(711, 68);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(70, 37);
            btnTim.TabIndex = 20;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // cbbThuongHieuTimKiem
            // 
            cbbThuongHieuTimKiem.Anchor = AnchorStyles.Left;
            cbbThuongHieuTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbThuongHieuTimKiem.FormattingEnabled = true;
            cbbThuongHieuTimKiem.Location = new Point(554, 73);
            cbbThuongHieuTimKiem.Name = "cbbThuongHieuTimKiem";
            cbbThuongHieuTimKiem.Size = new Size(151, 28);
            cbbThuongHieuTimKiem.TabIndex = 19;
            cbbThuongHieuTimKiem.SelectedIndexChanged += cbThuongHieuTimKiem_SelectedIndexChanged;
            // 
            // cbbGiaTimKiem
            // 
            cbbGiaTimKiem.Anchor = AnchorStyles.Left;
            cbbGiaTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGiaTimKiem.FormattingEnabled = true;
            cbbGiaTimKiem.Items.AddRange(new object[] { "< 5 triệu", "5 đến 10 triệu", "10 đến 20 triệu", "> 20 triệu" });
            cbbGiaTimKiem.Location = new Point(337, 73);
            cbbGiaTimKiem.Name = "cbbGiaTimKiem";
            cbbGiaTimKiem.Size = new Size(107, 28);
            cbbGiaTimKiem.TabIndex = 18;
            cbbGiaTimKiem.SelectedIndexChanged += cbGiaTimKiem_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(423, 9);
            label8.Name = "label8";
            label8.Size = new Size(277, 41);
            label8.TabIndex = 17;
            label8.Text = "Quản Lý Sản Phẩm";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(450, 76);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "Thương Hiệu:";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(297, 76);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 6;
            label3.Text = "Giá:";
            label3.Click += label3_Click;
            // 
            // txtTenTimKiem
            // 
            txtTenTimKiem.Anchor = AnchorStyles.Left;
            txtTenTimKiem.Location = new Point(166, 73);
            txtTenTimKiem.Name = "txtTenTimKiem";
            txtTenTimKiem.Size = new Size(125, 27);
            txtTenTimKiem.TabIndex = 5;
            txtTenTimKiem.TextChanged += txtTenTimKiem_TextChanged;
            txtTenTimKiem.KeyPress += txtTenTimKiem_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(125, 76);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên:";
            label1.Click += label1_Click;
            // 
            // txtMaTimKiem
            // 
            txtMaTimKiem.Anchor = AnchorStyles.Left;
            txtMaTimKiem.Location = new Point(47, 73);
            txtMaTimKiem.Name = "txtMaTimKiem";
            txtMaTimKiem.Size = new Size(73, 27);
            txtMaTimKiem.TabIndex = 3;
            txtMaTimKiem.TextChanged += txtMaTimKiem_TextChanged;
            txtMaTimKiem.KeyPress += txtMaTimKiem_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(11, 76);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã:";
            label2.Click += label2_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 728);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1093, 764);
            Name = "Product";
            Text = "Quản Lý Sản Phẩm";
            mainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel headerPanel;
        private Label label2;
        private TextBox txtMaTimKiem;
        private TextBox txtTenTimKiem;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label8;
        private Panel panel1;
        private ComboBox cbbGiaTimKiem;
        private ComboBox cbbThuongHieuTimKiem;
        private Button btnTim;
        private Button btnDatLai;
        private Panel panel2;
        private Button btnXoa;
        private Button btnNhapLai;
        private Button btnThemSP;
        private TextBox txtMoTaSP;
        private Label label9;
        private TextBox txtDacDiemSP;
        private Label label4;
        private ComboBox cbbLoaiSP;
        private Label label7;
        private ComboBox cbbThuongHieuSP;
        private Label label6;
        private PictureBox ptbAnh;
        private TextBox txtGiaSP;
        private Label label10;
        private TextBox txtTenSP;
        private Label label11;
        private TextBox txtMaSP;
        private Label label12;
        private TextBox txtIDSP;
        private Label label13;
        private Label label14;
        private Button btnSua;
        private DataGridView dgvSanPham;
    }
}