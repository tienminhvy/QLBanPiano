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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTimTK = new TextBox();
            btnTimTK = new Button();
            dsVaiTro = new ListBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // dsVaiTro
            // 
            dsVaiTro.Dock = DockStyle.Fill;
            dsVaiTro.FormattingEnabled = true;
            dsVaiTro.ItemHeight = 20;
            dsVaiTro.Location = new Point(0, 36);
            dsVaiTro.Name = "dsVaiTro";
            dsVaiTro.Size = new Size(250, 414);
            dsVaiTro.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 450);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(6, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách quyền";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(23, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Bán hàng";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(23, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(155, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Quản lý nhập hàng";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(23, 95);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(140, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Quản lý hoá đơn";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(23, 125);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(176, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Quản lý nhạc cụ Piano";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(23, 155);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(224, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Quản lý thông tin khách hàng";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(23, 185);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(319, 24);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Quản lý thông tin nhân viên (kèm tài khoản)";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(23, 215);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(149, 24);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Nhập xuất dữ liệu";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(456, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button button1;
        private Label label1;
    }
}