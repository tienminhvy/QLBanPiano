namespace QLBanPiano.GUI.SubForm
{
    partial class frmThemKhachHang
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
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnReset = new Button();
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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(133, 19);
            label1.Name = "label1";
            label1.Size = new Size(291, 38);
            label1.TabIndex = 0;
            label1.Text = "Thêm khách hàng ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtHoLot);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(284, 328);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 31);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(158, 328);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 31);
            btnReset.TabIndex = 5;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(27, 328);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 31);
            btnThem.TabIndex = 4;
            btnThem.Text = "T&hêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(158, 249);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(231, 34);
            txtSoDienThoai.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(158, 196);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(231, 34);
            txtDiaChi.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 261);
            label8.Name = "label8";
            label8.Size = new Size(125, 22);
            label8.TabIndex = 0;
            label8.Text = "Số điện thoại: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 208);
            label7.Name = "label7";
            label7.Size = new Size(79, 22);
            label7.TabIndex = 0;
            label7.Text = "Địa chỉ: ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(158, 148);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(231, 34);
            txtTen.TabIndex = 1;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(158, 97);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(231, 34);
            txtHoLot.TabIndex = 0;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(158, 40);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(127, 34);
            txtMaKH.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 154);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 0;
            label6.Text = "Tên: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 103);
            label5.Name = "label5";
            label5.Size = new Size(71, 22);
            label5.TabIndex = 0;
            label5.Text = "Họ lót: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 46);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 0;
            label4.Text = "Mã KH: ";
            // 
            // frmThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 491);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmThemKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm khách hàng";
            KeyDown += frmThemKhachHang_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private Label label8;
        private Label label7;
        private TextBox txtTen;
        private TextBox txtHoLot;
        private TextBox txtMaKH;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnThoat;
        private Button btnReset;
        private Button btnThem;
    }
}