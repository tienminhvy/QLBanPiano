namespace QLBanPiano
{
    partial class frmBanHang
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
            panel4 = new Panel();
            txtTienThoiLai = new TextBox();
            label22 = new Label();
            btnXoaHet = new Button();
            btnXoa = new Button();
            btnThanhToan = new Button();
            txtTongTienNhan = new TextBox();
            label25 = new Label();
            txtTongTien = new TextBox();
            label27 = new Label();
            txtTongSoSP = new TextBox();
            label28 = new Label();
            lvSanPhamDaChon = new ListView();
            ID = new ColumnHeader();
            TenSanPham = new ColumnHeader();
            Gia = new ColumnHeader();
            SoLuong = new ColumnHeader();
            label29 = new Label();
            panel3 = new Panel();
            txtLoaiSP = new TextBox();
            label23 = new Label();
            cbbSoLuongMua = new ComboBox();
            label21 = new Label();
            txtMoTaSP = new TextBox();
            label20 = new Label();
            txtDacDiemSP = new TextBox();
            label19 = new Label();
            ptbAnh = new PictureBox();
            txtSoLuongCon = new TextBox();
            label15 = new Label();
            txtGiaSP = new TextBox();
            label12 = new Label();
            txtMaSP = new TextBox();
            label18 = new Label();
            btnTimSanPham = new Button();
            txtTimKiemSanPham = new TextBox();
            label10 = new Label();
            label11 = new Label();
            cbbTieuChiSanPham = new ComboBox();
            btnChonSanPham = new Button();
            txtThuongHieuSP = new TextBox();
            label13 = new Label();
            txtTenSP = new TextBox();
            label14 = new Label();
            txtIDSP = new TextBox();
            label16 = new Label();
            lvSanPham = new ListView();
            IDSP = new ColumnHeader();
            MaSP = new ColumnHeader();
            TenSP = new ColumnHeader();
            ThuongHieuSP = new ColumnHeader();
            LoaiSP = new ColumnHeader();
            GiaSP = new ColumnHeader();
            label17 = new Label();
            panel2 = new Panel();
            btnTimKhachHang = new Button();
            txtTimKiemKhachHang = new TextBox();
            label9 = new Label();
            label8 = new Label();
            cbbTieuChiKhachHang = new ComboBox();
            btnThemKhachHang = new Button();
            txtSDTKH = new TextBox();
            label7 = new Label();
            txtDiaChiKH = new TextBox();
            label6 = new Label();
            txtTenKH = new TextBox();
            label5 = new Label();
            txtHoLotKH = new TextBox();
            label4 = new Label();
            txtIDKH = new TextBox();
            label3 = new Label();
            lvKhachHang = new ListView();
            IDKH = new ColumnHeader();
            HoLotKH = new ColumnHeader();
            TenKH = new ColumnHeader();
            SDTKH = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 757);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.Controls.Add(txtTienThoiLai);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(btnXoaHet);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(btnThanhToan);
            panel4.Controls.Add(txtTongTienNhan);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(txtTongTien);
            panel4.Controls.Add(label27);
            panel4.Controls.Add(txtTongSoSP);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(lvSanPhamDaChon);
            panel4.Controls.Add(label29);
            panel4.Location = new Point(916, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 625);
            panel4.TabIndex = 19;
            // 
            // txtTienThoiLai
            // 
            txtTienThoiLai.Enabled = false;
            txtTienThoiLai.Location = new Point(151, 505);
            txtTienThoiLai.Name = "txtTienThoiLai";
            txtTienThoiLai.ReadOnly = true;
            txtTienThoiLai.Size = new Size(125, 27);
            txtTienThoiLai.TabIndex = 22;
            txtTienThoiLai.Text = "0";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(9, 512);
            label22.Name = "label22";
            label22.Size = new Size(96, 20);
            label22.TabIndex = 21;
            label22.Text = "Tiền Thối Lại:";
            // 
            // btnXoaHet
            // 
            btnXoaHet.BackColor = Color.DarkGray;
            btnXoaHet.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaHet.Location = new Point(268, 82);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(111, 48);
            btnXoaHet.TabIndex = 20;
            btnXoaHet.Text = "Xóa Hết";
            btnXoaHet.UseVisualStyleBackColor = false;
            btnXoaHet.Click += btnXoaHet_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 192, 128);
            btnXoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(21, 82);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(111, 48);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = SystemColors.ActiveCaption;
            btnThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(151, 553);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(155, 48);
            btnThanhToan.TabIndex = 18;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtTongTienNhan
            // 
            txtTongTienNhan.Location = new Point(151, 460);
            txtTongTienNhan.MaxLength = 12;
            txtTongTienNhan.Name = "txtTongTienNhan";
            txtTongTienNhan.Size = new Size(125, 27);
            txtTongTienNhan.TabIndex = 9;
            txtTongTienNhan.TextChanged += txtTongTienNhan_TextChanged;
            txtTongTienNhan.KeyPress += txtTongTienNhan_KeyPress;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(9, 464);
            label25.Name = "label25";
            label25.Size = new Size(117, 20);
            label25.TabIndex = 8;
            label25.Text = "Tổng Tiền Nhận:";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(151, 410);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 5;
            txtTongTien.Text = "0";
            txtTongTien.TextChanged += txtTongTien_TextChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(9, 417);
            label27.Name = "label27";
            label27.Size = new Size(78, 20);
            label27.TabIndex = 4;
            label27.Text = "Tổng Tiền:";
            // 
            // txtTongSoSP
            // 
            txtTongSoSP.Enabled = false;
            txtTongSoSP.Location = new Point(151, 371);
            txtTongSoSP.Name = "txtTongSoSP";
            txtTongSoSP.ReadOnly = true;
            txtTongSoSP.Size = new Size(125, 27);
            txtTongSoSP.TabIndex = 3;
            txtTongSoSP.Text = "0";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(9, 374);
            label28.Name = "label28";
            label28.Size = new Size(136, 20);
            label28.TabIndex = 2;
            label28.Text = "Tổng Số Sản Phẩm:";
            // 
            // lvSanPhamDaChon
            // 
            lvSanPhamDaChon.Columns.AddRange(new ColumnHeader[] { ID, TenSanPham, Gia, SoLuong });
            lvSanPhamDaChon.FullRowSelect = true;
            lvSanPhamDaChon.GridLines = true;
            lvSanPhamDaChon.Location = new Point(3, 161);
            lvSanPhamDaChon.Name = "lvSanPhamDaChon";
            lvSanPhamDaChon.Size = new Size(401, 175);
            lvSanPhamDaChon.TabIndex = 1;
            lvSanPhamDaChon.UseCompatibleStateImageBehavior = false;
            lvSanPhamDaChon.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // TenSanPham
            // 
            TenSanPham.Text = "Tên Sản Phẩm";
            TenSanPham.TextAlign = HorizontalAlignment.Center;
            TenSanPham.Width = 120;
            // 
            // Gia
            // 
            Gia.Text = "Giá Tiền";
            Gia.TextAlign = HorizontalAlignment.Center;
            Gia.Width = 150;
            // 
            // SoLuong
            // 
            SoLuong.Text = "Số Lượng";
            SoLuong.Width = 70;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(89, 14);
            label29.Name = "label29";
            label29.Size = new Size(217, 31);
            label29.TabIndex = 0;
            label29.Text = "Sản Phẩm Đã Chọn";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.PowderBlue;
            panel3.Controls.Add(txtLoaiSP);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(cbbSoLuongMua);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(txtMoTaSP);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(txtDacDiemSP);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(ptbAnh);
            panel3.Controls.Add(txtSoLuongCon);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(txtGiaSP);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtMaSP);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(btnTimSanPham);
            panel3.Controls.Add(txtTimKiemSanPham);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cbbTieuChiSanPham);
            panel3.Controls.Add(btnChonSanPham);
            panel3.Controls.Add(txtThuongHieuSP);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtTenSP);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtIDSP);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(lvSanPham);
            panel3.Controls.Add(label17);
            panel3.Location = new Point(410, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 625);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // txtLoaiSP
            // 
            txtLoaiSP.Enabled = false;
            txtLoaiSP.Location = new Point(379, 492);
            txtLoaiSP.Name = "txtLoaiSP";
            txtLoaiSP.ReadOnly = true;
            txtLoaiSP.Size = new Size(111, 27);
            txtLoaiSP.TabIndex = 32;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(331, 495);
            label23.Name = "label23";
            label23.Size = new Size(40, 20);
            label23.TabIndex = 31;
            label23.Text = "Loại:";
            // 
            // cbbSoLuongMua
            // 
            cbbSoLuongMua.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSoLuongMua.FormattingEnabled = true;
            cbbSoLuongMua.Location = new Point(303, 578);
            cbbSoLuongMua.Name = "cbbSoLuongMua";
            cbbSoLuongMua.Size = new Size(62, 28);
            cbbSoLuongMua.TabIndex = 30;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(189, 581);
            label21.Name = "label21";
            label21.Size = new Size(108, 20);
            label21.TabIndex = 29;
            label21.Text = "Số Lượng Mua:";
            // 
            // txtMoTaSP
            // 
            txtMoTaSP.Enabled = false;
            txtMoTaSP.Location = new Point(113, 513);
            txtMoTaSP.Multiline = true;
            txtMoTaSP.Name = "txtMoTaSP";
            txtMoTaSP.ReadOnly = true;
            txtMoTaSP.Size = new Size(209, 59);
            txtMoTaSP.TabIndex = 28;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(9, 516);
            label20.Name = "label20";
            label20.Size = new Size(54, 20);
            label20.TabIndex = 27;
            label20.Text = "Mô Tả:";
            // 
            // txtDacDiemSP
            // 
            txtDacDiemSP.Enabled = false;
            txtDacDiemSP.Location = new Point(113, 448);
            txtDacDiemSP.Multiline = true;
            txtDacDiemSP.Name = "txtDacDiemSP";
            txtDacDiemSP.ReadOnly = true;
            txtDacDiemSP.Size = new Size(209, 59);
            txtDacDiemSP.TabIndex = 26;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(9, 451);
            label19.Name = "label19";
            label19.Size = new Size(78, 20);
            label19.TabIndex = 25;
            label19.Text = "Đặc Điểm:";
            // 
            // ptbAnh
            // 
            ptbAnh.BorderStyle = BorderStyle.FixedSingle;
            ptbAnh.Enabled = false;
            ptbAnh.Location = new Point(328, 342);
            ptbAnh.Name = "ptbAnh";
            ptbAnh.Size = new Size(162, 142);
            ptbAnh.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnh.TabIndex = 24;
            ptbAnh.TabStop = false;
            // 
            // txtSoLuongCon
            // 
            txtSoLuongCon.Enabled = false;
            txtSoLuongCon.Location = new Point(113, 578);
            txtSoLuongCon.Name = "txtSoLuongCon";
            txtSoLuongCon.ReadOnly = true;
            txtSoLuongCon.Size = new Size(70, 27);
            txtSoLuongCon.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(9, 581);
            label15.Name = "label15";
            label15.Size = new Size(105, 20);
            label15.TabIndex = 22;
            label15.Text = "Số Lượng Còn:";
            // 
            // txtGiaSP
            // 
            txtGiaSP.Enabled = false;
            txtGiaSP.Location = new Point(379, 525);
            txtGiaSP.Name = "txtGiaSP";
            txtGiaSP.ReadOnly = true;
            txtGiaSP.Size = new Size(111, 27);
            txtGiaSP.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(331, 528);
            label12.Name = "label12";
            label12.Size = new Size(34, 20);
            label12.TabIndex = 20;
            label12.Text = "Giá:";
            // 
            // txtMaSP
            // 
            txtMaSP.Enabled = false;
            txtMaSP.Location = new Point(133, 346);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(84, 27);
            txtMaSP.TabIndex = 19;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(94, 349);
            label18.Name = "label18";
            label18.Size = new Size(33, 20);
            label18.TabIndex = 18;
            label18.Text = "Mã:";
            // 
            // btnTimSanPham
            // 
            btnTimSanPham.BackColor = Color.White;
            btnTimSanPham.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimSanPham.Location = new Point(356, 82);
            btnTimSanPham.Name = "btnTimSanPham";
            btnTimSanPham.Size = new Size(111, 48);
            btnTimSanPham.TabIndex = 17;
            btnTimSanPham.Text = "Tìm";
            btnTimSanPham.UseVisualStyleBackColor = false;
            btnTimSanPham.Click += btnTimSanPham_Click;
            // 
            // txtTimKiemSanPham
            // 
            txtTimKiemSanPham.Location = new Point(91, 120);
            txtTimKiemSanPham.MaxLength = 30;
            txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            txtTimKiemSanPham.Size = new Size(239, 27);
            txtTimKiemSanPham.TabIndex = 16;
            txtTimKiemSanPham.KeyPress += txtTimKiemSanPham_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 123);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 15;
            label10.Text = "Nội Dung:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 71);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 14;
            label11.Text = "Tiêu Chí:";
            // 
            // cbbTieuChiSanPham
            // 
            cbbTieuChiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTieuChiSanPham.FormattingEnabled = true;
            cbbTieuChiSanPham.Items.AddRange(new object[] { "ID", "Mã", "Tên", "Thương Hiệu", "Loại" });
            cbbTieuChiSanPham.Location = new Point(89, 68);
            cbbTieuChiSanPham.Name = "cbbTieuChiSanPham";
            cbbTieuChiSanPham.Size = new Size(241, 28);
            cbbTieuChiSanPham.TabIndex = 13;
            // 
            // btnChonSanPham
            // 
            btnChonSanPham.BackColor = Color.FromArgb(128, 255, 255);
            btnChonSanPham.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChonSanPham.Location = new Point(379, 558);
            btnChonSanPham.Name = "btnChonSanPham";
            btnChonSanPham.Size = new Size(111, 48);
            btnChonSanPham.TabIndex = 12;
            btnChonSanPham.Text = "Chọn";
            btnChonSanPham.UseVisualStyleBackColor = false;
            btnChonSanPham.Click += btnChonSanPham_Click;
            // 
            // txtThuongHieuSP
            // 
            txtThuongHieuSP.Enabled = false;
            txtThuongHieuSP.Location = new Point(113, 414);
            txtThuongHieuSP.Name = "txtThuongHieuSP";
            txtThuongHieuSP.ReadOnly = true;
            txtThuongHieuSP.Size = new Size(209, 27);
            txtThuongHieuSP.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 418);
            label13.Name = "label13";
            label13.Size = new Size(98, 20);
            label13.TabIndex = 8;
            label13.Text = "Thương Hiệu:";
            // 
            // txtTenSP
            // 
            txtTenSP.Enabled = false;
            txtTenSP.Location = new Point(113, 381);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.ReadOnly = true;
            txtTenSP.Size = new Size(209, 27);
            txtTenSP.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 384);
            label14.Name = "label14";
            label14.Size = new Size(35, 20);
            label14.TabIndex = 6;
            label14.Text = "Tên:";
            // 
            // txtIDSP
            // 
            txtIDSP.Enabled = false;
            txtIDSP.Location = new Point(40, 346);
            txtIDSP.Name = "txtIDSP";
            txtIDSP.ReadOnly = true;
            txtIDSP.Size = new Size(48, 27);
            txtIDSP.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(9, 349);
            label16.Name = "label16";
            label16.Size = new Size(27, 20);
            label16.TabIndex = 2;
            label16.Text = "ID:";
            // 
            // lvSanPham
            // 
            lvSanPham.Columns.AddRange(new ColumnHeader[] { IDSP, MaSP, TenSP, ThuongHieuSP, LoaiSP, GiaSP });
            lvSanPham.FullRowSelect = true;
            lvSanPham.GridLines = true;
            lvSanPham.Location = new Point(3, 161);
            lvSanPham.Name = "lvSanPham";
            lvSanPham.Size = new Size(494, 175);
            lvSanPham.TabIndex = 1;
            lvSanPham.UseCompatibleStateImageBehavior = false;
            lvSanPham.View = View.Details;
            lvSanPham.SelectedIndexChanged += lvSanPham_SelectedIndexChanged;
            // 
            // IDSP
            // 
            IDSP.Text = "ID";
            IDSP.Width = 35;
            // 
            // MaSP
            // 
            MaSP.Text = "Mã";
            MaSP.TextAlign = HorizontalAlignment.Center;
            MaSP.Width = 70;
            // 
            // TenSP
            // 
            TenSP.Text = "Tên";
            TenSP.TextAlign = HorizontalAlignment.Center;
            TenSP.Width = 100;
            // 
            // ThuongHieuSP
            // 
            ThuongHieuSP.Text = "Thương Hiệu";
            ThuongHieuSP.TextAlign = HorizontalAlignment.Center;
            ThuongHieuSP.Width = 90;
            // 
            // LoaiSP
            // 
            LoaiSP.Text = "Loại";
            LoaiSP.TextAlign = HorizontalAlignment.Center;
            // 
            // GiaSP
            // 
            GiaSP.Text = "Giá";
            GiaSP.TextAlign = HorizontalAlignment.Center;
            GiaSP.Width = 130;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(189, 14);
            label17.Name = "label17";
            label17.Size = new Size(120, 31);
            label17.TabIndex = 0;
            label17.Text = "Sản Phẩm";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(btnTimKhachHang);
            panel2.Controls.Add(txtTimKiemKhachHang);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cbbTieuChiKhachHang);
            panel2.Controls.Add(btnThemKhachHang);
            panel2.Controls.Add(txtSDTKH);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDiaChiKH);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtTenKH);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtHoLotKH);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtIDKH);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lvKhachHang);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 85);
            panel2.MinimumSize = new Size(404, 625);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 625);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnTimKhachHang
            // 
            btnTimKhachHang.BackColor = Color.White;
            btnTimKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKhachHang.Location = new Point(282, 55);
            btnTimKhachHang.Name = "btnTimKhachHang";
            btnTimKhachHang.Size = new Size(111, 48);
            btnTimKhachHang.TabIndex = 17;
            btnTimKhachHang.Text = "Tìm";
            btnTimKhachHang.UseVisualStyleBackColor = false;
            btnTimKhachHang.Click += btnTimKhachHang_Click;
            // 
            // txtTimKiemKhachHang
            // 
            txtTimKiemKhachHang.Location = new Point(91, 120);
            txtTimKiemKhachHang.MaxLength = 30;
            txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            txtTimKiemKhachHang.Size = new Size(171, 27);
            txtTimKiemKhachHang.TabIndex = 16;
            txtTimKiemKhachHang.KeyPress += txtTimKiemKhachHang_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 123);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 15;
            label9.Text = "Nội Dung:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 71);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 14;
            label8.Text = "Tiêu Chí:";
            // 
            // cbbTieuChiKhachHang
            // 
            cbbTieuChiKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTieuChiKhachHang.FormattingEnabled = true;
            cbbTieuChiKhachHang.Items.AddRange(new object[] { "ID", "SDT", "Tên" });
            cbbTieuChiKhachHang.Location = new Point(89, 68);
            cbbTieuChiKhachHang.Name = "cbbTieuChiKhachHang";
            cbbTieuChiKhachHang.Size = new Size(173, 28);
            cbbTieuChiKhachHang.TabIndex = 13;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.FromArgb(128, 255, 128);
            btnThemKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemKhachHang.Location = new Point(282, 109);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(111, 48);
            btnThemKhachHang.TabIndex = 12;
            btnThemKhachHang.Text = "Thêm Mới";
            btnThemKhachHang.UseVisualStyleBackColor = false;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // txtSDTKH
            // 
            txtSDTKH.Enabled = false;
            txtSDTKH.Location = new Point(268, 367);
            txtSDTKH.Name = "txtSDTKH";
            txtSDTKH.ReadOnly = true;
            txtSDTKH.Size = new Size(125, 27);
            txtSDTKH.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 370);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 10;
            label7.Text = "SDT:";
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Enabled = false;
            txtDiaChiKH.Location = new Point(75, 461);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.ReadOnly = true;
            txtDiaChiKH.Size = new Size(190, 27);
            txtDiaChiKH.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 464);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 8;
            label6.Text = "Địa Chỉ:";
            // 
            // txtTenKH
            // 
            txtTenKH.Enabled = false;
            txtTenKH.Location = new Point(268, 414);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(125, 27);
            txtTenKH.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 417);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 6;
            label5.Text = "Tên:";
            // 
            // txtHoLotKH
            // 
            txtHoLotKH.Enabled = false;
            txtHoLotKH.Location = new Point(75, 414);
            txtHoLotKH.Name = "txtHoLotKH";
            txtHoLotKH.ReadOnly = true;
            txtHoLotKH.Size = new Size(125, 27);
            txtHoLotKH.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 417);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Họ Lót:";
            // 
            // txtIDKH
            // 
            txtIDKH.Enabled = false;
            txtIDKH.Location = new Point(75, 371);
            txtIDKH.Name = "txtIDKH";
            txtIDKH.ReadOnly = true;
            txtIDKH.Size = new Size(57, 27);
            txtIDKH.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 374);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // lvKhachHang
            // 
            lvKhachHang.Columns.AddRange(new ColumnHeader[] { IDKH, HoLotKH, TenKH, SDTKH });
            lvKhachHang.FullRowSelect = true;
            lvKhachHang.GridLines = true;
            lvKhachHang.Location = new Point(3, 161);
            lvKhachHang.Name = "lvKhachHang";
            lvKhachHang.Size = new Size(398, 175);
            lvKhachHang.TabIndex = 1;
            lvKhachHang.UseCompatibleStateImageBehavior = false;
            lvKhachHang.View = View.Details;
            lvKhachHang.SelectedIndexChanged += lvKhachHang_SelectedIndexChanged;
            // 
            // IDKH
            // 
            IDKH.Text = "ID";
            IDKH.Width = 35;
            // 
            // HoLotKH
            // 
            HoLotKH.Text = "Họ Lót";
            HoLotKH.TextAlign = HorizontalAlignment.Center;
            HoLotKH.Width = 125;
            // 
            // TenKH
            // 
            TenKH.Text = "Tên";
            TenKH.TextAlign = HorizontalAlignment.Center;
            TenKH.Width = 80;
            // 
            // SDTKH
            // 
            SDTKH.Text = "SDT";
            SDTKH.TextAlign = HorizontalAlignment.Center;
            SDTKH.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 14);
            label2.Name = "label2";
            label2.Size = new Size(144, 31);
            label2.TabIndex = 0;
            label2.Text = "Khách Hàng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(577, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 0;
            label1.Text = "Bán Hàng";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 757);
            Controls.Add(panel1);
            Name = "frmBanHang";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnh).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ListView lvKhachHang;
        private Label label3;
        private TextBox txtIDKH;
        private TextBox txtHoLotKH;
        private Label label4;
        private TextBox txtTenKH;
        private Label label5;
        private TextBox txtDiaChiKH;
        private Label label6;
        private TextBox txtSDTKH;
        private Label label7;
        private Button btnThemKhachHang;
        private ComboBox cbbTieuChiKhachHang;
        private Label label8;
        private Label label9;
        private TextBox txtTimKiemKhachHang;
        private Button btnTimKhachHang;
        private Panel panel3;
        private Button btnTimSanPham;
        private TextBox txtTimKiemSanPham;
        private Label label10;
        private Label label11;
        private ComboBox cbbTieuChiSanPham;
        private Button btnChonSanPham;
        private TextBox txtThuongHieuSP;
        private Label label13;
        private TextBox txtTenSP;
        private Label label14;
        private TextBox txtIDSP;
        private Label label16;
        private ListView lvSanPham;
        private Label label17;
        private TextBox txtMaSP;
        private Label label18;
        private TextBox txtGiaSP;
        private Label label12;
        private TextBox txtSoLuongCon;
        private Label label15;
        private PictureBox ptbAnh;
        private TextBox txtDacDiemSP;
        private Label label19;
        private TextBox txtMoTaSP;
        private Label label20;
        private Label label21;
        private ComboBox cbbSoLuongMua;
        private Panel panel4;
        private Button btnThanhToan;
        private TextBox txtTongTienNhan;
        private Label label25;
        private TextBox txtTongTien;
        private Label label27;
        private TextBox txtTongSoSP;
        private Label label28;
        private ListView lvSanPhamDaChon;
        private Label label29;
        private Button btnXoaHet;
        private Button btnXoa;
        private TextBox txtTienThoiLai;
        private Label label22;
        private ColumnHeader ID;
        private ColumnHeader TenSanPham;
        private ColumnHeader Gia;
        private ColumnHeader SoLuong;
        private TextBox txtLoaiSP;
        private Label label23;
        private ColumnHeader IDKH;
        private ColumnHeader HoLotKH;
        private ColumnHeader TenKH;
        private ColumnHeader SDTKH;
        private ColumnHeader IDSP;
        private ColumnHeader MaSP;
        private ColumnHeader TenSP;
        private ColumnHeader GiaSP;
        private ColumnHeader ThuongHieuSP;
        private ColumnHeader LoaiSP;
    }
}