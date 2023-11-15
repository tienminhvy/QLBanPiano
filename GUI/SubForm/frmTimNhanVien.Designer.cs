namespace QLBanPiano.GUI.SubForm
{
    partial class frmTimNhanVien
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
            groupBox2 = new GroupBox();
            dateDenNgay = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dateTuNgay = new DateTimePicker();
            btnTimTheoNgay = new Button();
            groupBox1 = new GroupBox();
            btnTim = new Button();
            cbbTieuChi = new ComboBox();
            txtTieuChi = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateDenNgay);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTuNgay);
            groupBox2.Controls.Add(btnTimTheoNgay);
            groupBox2.Location = new Point(12, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 182);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm theo ngày";
            // 
            // dateDenNgay
            // 
            dateDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateDenNgay.Location = new Point(6, 109);
            dateDenNgay.Name = "dateDenNgay";
            dateDenNgay.Size = new Size(302, 27);
            dateDenNgay.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(236, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 4;
            label1.Text = "Từ ngày";
            // 
            // dateTuNgay
            // 
            dateTuNgay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTuNgay.Location = new Point(6, 46);
            dateTuNgay.Name = "dateTuNgay";
            dateTuNgay.Size = new Size(302, 27);
            dateTuNgay.TabIndex = 3;
            // 
            // btnTimTheoNgay
            // 
            btnTimTheoNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimTheoNgay.Location = new Point(214, 147);
            btnTimTheoNgay.Name = "btnTimTheoNgay";
            btnTimTheoNgay.Size = new Size(94, 29);
            btnTimTheoNgay.TabIndex = 2;
            btnTimTheoNgay.Text = "Tìm";
            btnTimTheoNgay.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(cbbTieuChi);
            groupBox1.Controls.Add(txtTieuChi);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 132);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm theo tiêu chí";
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.Location = new Point(214, 97);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Location = new Point(6, 26);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(302, 28);
            cbbTieuChi.TabIndex = 1;
            // 
            // txtTieuChi
            // 
            txtTieuChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTieuChi.Location = new Point(6, 60);
            txtTieuChi.Name = "txtTieuChi";
            txtTieuChi.PlaceholderText = "Nhập tiêu chí";
            txtTieuChi.Size = new Size(302, 27);
            txtTieuChi.TabIndex = 0;
            // 
            // TimNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 341);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TimNhanVien";
            Text = "Tìm nhân viên";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DateTimePicker dateDenNgay;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTuNgay;
        private Button btnTimTheoNgay;
        private GroupBox groupBox1;
        private Button btnTim;
        private ComboBox cbbTieuChi;
        private TextBox txtTieuChi;
    }
}