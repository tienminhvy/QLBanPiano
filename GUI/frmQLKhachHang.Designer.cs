namespace QLBanPiano.GUI
{
    partial class frmQLKhachHang
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
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnCapNhat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtTen = new TextBox();
            txtHoLot = new TextBox();
            txtMaKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            cbbTimKiem = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            dgvKhachHang = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(1141, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(375, 18);
            label1.Name = "label1";
            label1.Size = new Size(422, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1141, 587);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtSoDienThoai);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(txtHoLot);
            groupBox2.Controls.Add(txtMaKH);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(459, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(671, 274);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng ";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(530, 192);
            button1.Name = "button1";
            button1.Size = new Size(120, 31);
            button1.TabIndex = 10;
            button1.Text = "Th&ống Kê";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.Location = new Point(404, 192);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 31);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "&Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(272, 192);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 31);
            btnSua.TabIndex = 8;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(137, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 31);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(11, 192);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 31);
            btnThem.TabIndex = 6;
            btnThem.Text = "T&hêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(448, 85);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(202, 33);
            txtSoDienThoai.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(419, 32);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(231, 33);
            txtDiaChi.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(317, 96);
            label8.Name = "label8";
            label8.Size = new Size(125, 22);
            label8.TabIndex = 9;
            label8.Text = "Số điện thoại: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(317, 43);
            label7.Name = "label7";
            label7.Size = new Size(79, 22);
            label7.TabIndex = 8;
            label7.Text = "Địa chỉ: ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(89, 136);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(187, 33);
            txtTen.TabIndex = 3;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(89, 85);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(187, 33);
            txtHoLot.TabIndex = 2;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(89, 37);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(187, 33);
            txtMaKH.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 136);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 0;
            label6.Text = "Tên: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 93);
            label5.Name = "label5";
            label5.Size = new Size(71, 22);
            label5.TabIndex = 0;
            label5.Text = "Họ lót: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 48);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 0;
            label4.Text = "Mã KH: ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(cbbTimKiem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 274);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(133, 192);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(111, 31);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(160, 90);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(249, 33);
            txtTimKiem.TabIndex = 2;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(160, 43);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(249, 33);
            cbbTimKiem.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 96);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 0;
            label3.Text = "Nhập dữ liệu: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 51);
            label2.Name = "label2";
            label2.Size = new Size(134, 22);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm theo: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvKhachHang);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 366);
            panel3.Name = "panel3";
            panel3.Size = new Size(1141, 292);
            panel3.TabIndex = 2;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.BackgroundColor = SystemColors.Control;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 0);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1141, 292);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
            // 
            // frmQLKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1141, 658);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQLKhachHang";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private ComboBox cbbTimKiem;
        private Label label3;
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private Label label8;
        private Label label7;
        private TextBox txtTen;
        private TextBox txtHoLot;
        private TextBox txtMaKH;
        private Button btnThem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button btnCapNhat;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel3;
        private DataGridView dgvKhachHang;
    }
}