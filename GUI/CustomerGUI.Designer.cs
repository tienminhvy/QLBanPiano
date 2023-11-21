namespace QLBanPiano.GUI
{
    partial class CustomerGUI
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
            dataGridView1 = new DataGridView();
            colMaKH = new DataGridViewTextBoxColumn();
            colHoLot = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(359, 21);
            label1.Name = "label1";
            label1.Size = new Size(422, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(7, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 274);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox2.Location = new Point(452, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(659, 259);
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
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(cbbTimKiem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 259);
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
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.Location = new Point(160, 85);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(147, 33);
            txtTimKiem.TabIndex = 2;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(160, 40);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(147, 33);
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
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(7, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(1122, 292);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaKH, colHoLot, colTen, colDiaChi, colSoDienThoai });
            dataGridView1.Location = new Point(5, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1106, 286);
            dataGridView1.TabIndex = 0;
            // 
            // colMaKH
            // 
            colMaKH.DataPropertyName = "id";
            colMaKH.HeaderText = "Mã khách hàng";
            colMaKH.MinimumWidth = 6;
            colMaKH.Name = "colMaKH";
            colMaKH.ReadOnly = true;
            colMaKH.Width = 150;
            // 
            // colHoLot
            // 
            colHoLot.DataPropertyName = "hoLot";
            colHoLot.HeaderText = "Họ lót";
            colHoLot.MinimumWidth = 6;
            colHoLot.Name = "colHoLot";
            colHoLot.ReadOnly = true;
            colHoLot.Width = 180;
            // 
            // colTen
            // 
            colTen.DataPropertyName = "ten";
            colTen.HeaderText = "Tên";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            colTen.ReadOnly = true;
            colTen.Width = 125;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "diaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            colDiaChi.Width = 250;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.DataPropertyName = "soDienThoai";
            colSoDienThoai.HeaderText = "Số điện thoại";
            colSoDienThoai.MinimumWidth = 6;
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            colSoDienThoai.Width = 180;
            // 
            // CustomerGUI
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
            Name = "CustomerGUI";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaKH;
        private DataGridViewTextBoxColumn colHoLot;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colSoDienThoai;
    }
}