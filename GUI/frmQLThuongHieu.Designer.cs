namespace QLBanPiano.GUI
{
    partial class frmQLThuongHieu
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
            dgvThuongHieu = new DataGridView();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtMoTa = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnTim = new Button();
            label5 = new Label();
            txtTieuChi = new TextBox();
            cbTimKiem = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvThuongHieu
            // 
            dgvThuongHieu.AllowUserToAddRows = false;
            dgvThuongHieu.AllowUserToDeleteRows = false;
            dgvThuongHieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThuongHieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuongHieu.Location = new Point(2, 236);
            dgvThuongHieu.Name = "dgvThuongHieu";
            dgvThuongHieu.ReadOnly = true;
            dgvThuongHieu.RowHeadersWidth = 51;
            dgvThuongHieu.RowTemplate.Height = 29;
            dgvThuongHieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThuongHieu.Size = new Size(797, 211);
            dgvThuongHieu.TabIndex = 0;
            dgvThuongHieu.CellContentClick += dgvThuongHieu_CellContentClick;
            dgvThuongHieu.SelectionChanged += dgvThuongHieu_SelectionChanged;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(70, 62);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(171, 27);
            txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(70, 95);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(171, 27);
            txtTen.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(247, 26);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(187, 149);
            txtMoTa.TabIndex = 3;
            txtMoTa.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 65);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(70, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(171, 27);
            txtId.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 98);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 125);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 8;
            label4.Text = "Mô tả:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(140, 181);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(240, 181);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(340, 181);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(335, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 218);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTieuChi);
            groupBox2.Controls.Add(cbTimKiem);
            groupBox2.Location = new Point(12, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 143);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(214, 98);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 12;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 65);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 2;
            label5.Text = "Tiêu chí";
            // 
            // txtTieuChi
            // 
            txtTieuChi.Location = new Point(107, 62);
            txtTieuChi.Name = "txtTieuChi";
            txtTieuChi.Size = new Size(201, 27);
            txtTieuChi.TabIndex = 1;
            // 
            // cbTimKiem
            // 
            cbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimKiem.FormattingEnabled = true;
            cbTimKiem.Items.AddRange(new object[] { "Xem tất cả", "ID", "Mã", "Tên" });
            cbTimKiem.Location = new Point(6, 25);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(302, 28);
            cbTimKiem.TabIndex = 0;
            cbTimKiem.SelectedIndexChanged += cbTimKiem_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 192, 192);
            label6.Location = new Point(41, 30);
            label6.Name = "label6";
            label6.Size = new Size(257, 35);
            label6.TabIndex = 14;
            label6.Text = "Quản lý thương hiệu";
            // 
            // frmQLThuongHieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvThuongHieu);
            Name = "frmQLThuongHieu";
            Text = "frmQLThuongHieu";
            Load += frmQLThuongHieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThuongHieu;
        private TextBox txtMa;
        private TextBox txtTen;
        private RichTextBox txtMoTa;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private Label label4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnTim;
        private Label label5;
        private TextBox txtTieuChi;
        private ComboBox cbTimKiem;
        private Label label6;
    }
}