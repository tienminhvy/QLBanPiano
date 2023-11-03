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
            listView1 = new ListView();
            clnMaKH = new ColumnHeader();
            clnHoLot = new ColumnHeader();
            clnTen = new ColumnHeader();
            clnDiaChi = new ColumnHeader();
            clnSdt = new ColumnHeader();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnThongKe = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtSdt = new TextBox();
            txtDiaChi = new TextBox();
            txtTen = new TextBox();
            txtHoLot = new TextBox();
            txtMaKh = new TextBox();
            lbSdt = new Label();
            lbDiaChi = new Label();
            lbTen = new Label();
            lnHoLot = new Label();
            lbMaKH = new Label();
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            txtNhapDuLieu = new TextBox();
            cbTimKiem = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 25);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clnMaKH, clnHoLot, clnTen, clnDiaChi, clnSdt });
            listView1.Dock = DockStyle.Bottom;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 271);
            listView1.Name = "listView1";
            listView1.Size = new Size(904, 232);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // clnMaKH
            // 
            clnMaKH.Text = "Mã KH";
            clnMaKH.Width = 100;
            // 
            // clnHoLot
            // 
            clnHoLot.Text = "Họ lót";
            clnHoLot.TextAlign = HorizontalAlignment.Center;
            clnHoLot.Width = 200;
            // 
            // clnTen
            // 
            clnTen.Text = "Tên";
            clnTen.TextAlign = HorizontalAlignment.Center;
            clnTen.Width = 100;
            // 
            // clnDiaChi
            // 
            clnDiaChi.Text = "Địa chỉ";
            clnDiaChi.TextAlign = HorizontalAlignment.Center;
            clnDiaChi.Width = 300;
            // 
            // clnSdt
            // 
            clnSdt.Text = "Số điện thoại";
            clnSdt.Width = 200;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 204);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThongKe);
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtSdt);
            groupBox2.Controls.Add(txtDiaChi);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(txtHoLot);
            groupBox2.Controls.Add(txtMaKh);
            groupBox2.Controls.Add(lbSdt);
            groupBox2.Controls.Add(lbDiaChi);
            groupBox2.Controls.Add(lbTen);
            groupBox2.Controls.Add(lnHoLot);
            groupBox2.Controls.Add(lbMaKH);
            groupBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(341, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(539, 189);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(428, 155);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(90, 27);
            btnThongKe.TabIndex = 12;
            btnThongKe.Text = "Th&ống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(327, 155);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(85, 27);
            btnCapNhat.TabIndex = 11;
            btnCapNhat.Text = "&Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(220, 155);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 27);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(115, 155);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 27);
            btnSua.TabIndex = 9;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(14, 155);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 27);
            btnThem.TabIndex = 8;
            btnThem.Text = "T&hêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(402, 76);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(125, 27);
            txtSdt.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(364, 42);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(163, 27);
            txtDiaChi.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(88, 110);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 5;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(88, 76);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(201, 27);
            txtHoLot.TabIndex = 4;
            // 
            // txtMaKh
            // 
            txtMaKh.Location = new Point(88, 42);
            txtMaKh.Name = "txtMaKh";
            txtMaKh.Size = new Size(125, 27);
            txtMaKh.TabIndex = 3;
            // 
            // lbSdt
            // 
            lbSdt.AutoSize = true;
            lbSdt.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbSdt.Location = new Point(295, 84);
            lbSdt.Name = "lbSdt";
            lbSdt.Size = new Size(104, 19);
            lbSdt.TabIndex = 4;
            lbSdt.Text = "Số điện thoại:";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbDiaChi.Location = new Point(295, 45);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(63, 19);
            lbDiaChi.TabIndex = 3;
            lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTen.Location = new Point(14, 118);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(43, 19);
            lbTen.TabIndex = 2;
            lbTen.Text = "Tên :";
            // 
            // lnHoLot
            // 
            lnHoLot.AutoSize = true;
            lnHoLot.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lnHoLot.Location = new Point(14, 87);
            lnHoLot.Name = "lnHoLot";
            lnHoLot.Size = new Size(62, 19);
            lnHoLot.TabIndex = 1;
            lnHoLot.Text = "Họ lót: ";
            // 
            // lbMaKH
            // 
            lbMaKH.AutoSize = true;
            lbMaKH.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaKH.Location = new Point(14, 45);
            lbMaKH.Name = "lbMaKH";
            lbMaKH.Size = new Size(68, 19);
            lbMaKH.TabIndex = 0;
            lbMaKH.Text = "Mã KH: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtNhapDuLieu);
            groupBox1.Controls.Add(cbTimKiem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(91, 154);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(97, 28);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtNhapDuLieu
            // 
            txtNhapDuLieu.Location = new Point(135, 79);
            txtNhapDuLieu.Name = "txtNhapDuLieu";
            txtNhapDuLieu.Size = new Size(164, 27);
            txtNhapDuLieu.TabIndex = 1;
            // 
            // cbTimKiem
            // 
            cbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimKiem.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbTimKiem.FormattingEnabled = true;
            cbTimKiem.Location = new Point(135, 37);
            cbTimKiem.Name = "cbTimKiem";
            cbTimKiem.Size = new Size(164, 27);
            cbTimKiem.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 87);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 0;
            label3.Text = "Nhập dữ liệu: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 45);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm theo:";
            // 
            // CustomerGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(904, 503);
            Controls.Add(panel2);
            Controls.Add(listView1);
            Controls.Add(panel1);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListView listView1;
        private ColumnHeader clnMaKH;
        private ColumnHeader clnHoLot;
        private ColumnHeader clnTen;
        private ColumnHeader clnDiaChi;
        private ColumnHeader clnSdt;
        private Panel panel2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtNhapDuLieu;
        private ComboBox cbTimKiem;
        private Button btnTimKiem;
        private Label lbSdt;
        private Label lbDiaChi;
        private Label lbTen;
        private Label lnHoLot;
        private Label lbMaKH;
        private TextBox txtSdt;
        private TextBox txtDiaChi;
        private TextBox txtTen;
        private TextBox txtHoLot;
        private TextBox txtMaKh;
        private Button btnThongKe;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}