﻿namespace QLBanPiano.GUI.SubForm
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
            btnThem = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colMaKH = new DataGridViewTextBoxColumn();
            colHoLot = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSoDienThoat = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(401, 13);
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
            groupBox1.Location = new Point(719, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 379);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(158, 249);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(231, 34);
            txtSoDienThoai.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(158, 196);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(231, 34);
            txtDiaChi.TabIndex = 4;
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
            txtTen.TabIndex = 3;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(158, 97);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(231, 34);
            txtHoLot.TabIndex = 2;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(158, 40);
            txtMaKH.Name = "txtMaKH";
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
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(27, 328);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 31);
            btnThem.TabIndex = 6;
            btnThem.Text = "T&hêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(158, 328);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 31);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(284, 328);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 31);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(692, 540);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMaKH, colHoLot, colTen, colDiaChi, colSoDienThoat });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(686, 537);
            dataGridView1.TabIndex = 0;
            // 
            // colMaKH
            // 
            colMaKH.DataPropertyName = "id";
            colMaKH.HeaderText = "Mã khách hàng ";
            colMaKH.MinimumWidth = 6;
            colMaKH.Name = "colMaKH";
            // 
            // colHoLot
            // 
            colHoLot.DataPropertyName = "hoLot";
            colHoLot.HeaderText = "Họ lót";
            colHoLot.MinimumWidth = 6;
            colHoLot.Name = "colHoLot";
            colHoLot.Width = 125;
            // 
            // colTen
            // 
            colTen.DataPropertyName = "ten";
            colTen.HeaderText = "Tên";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "diaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.Resizable = DataGridViewTriState.True;
            colDiaChi.Width = 125;
            // 
            // colSoDienThoat
            // 
            colSoDienThoat.DataPropertyName = "soDienThoai";
            colSoDienThoat.HeaderText = "Số điện thoại";
            colSoDienThoat.MinimumWidth = 6;
            colSoDienThoat.Name = "colSoDienThoat";
            colSoDienThoat.Width = 150;
            // 
            // frmThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 658);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmThemKhachHang";
            Text = "Thêm khách hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaKH;
        private DataGridViewTextBoxColumn colHoLot;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colSoDienThoat;
    }
}