namespace QLBanPiano.GUI.SubForm
{
    partial class frmTimHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimHoaDon));
            groupBox1 = new GroupBox();
            btnTim = new Button();
            cbbTieuChi = new ComboBox();
            txtTieuChi = new TextBox();
            groupBox2 = new GroupBox();
            dateDenNgay = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dateTuNgay = new DateTimePicker();
            btnTimTheoNgay = new Button();
            groupBox3 = new GroupBox();
            btnTimTheoKH = new Button();
            btnTimKH = new Button();
            groupBox4 = new GroupBox();
            btnTimTheoNV = new Button();
            btnTimNV = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(cbbTieuChi);
            groupBox1.Controls.Add(txtTieuChi);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(392, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm theo tiêu chí";
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.Image = (Image)resources.GetObject("btnTim.Image");
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(295, 121);
            btnTim.Margin = new Padding(4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(91, 44);
            btnTim.TabIndex = 2;
            btnTim.Text = "   Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbTieuChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Location = new Point(8, 32);
            cbbTieuChi.Margin = new Padding(4);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(376, 33);
            cbbTieuChi.TabIndex = 1;
            cbbTieuChi.SelectedIndexChanged += cbbTieuChi_SelectedIndexChanged;
            // 
            // txtTieuChi
            // 
            txtTieuChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTieuChi.ForeColor = SystemColors.InactiveBorder;
            txtTieuChi.Location = new Point(8, 75);
            txtTieuChi.Margin = new Padding(4);
            txtTieuChi.Name = "txtTieuChi";
            txtTieuChi.Size = new Size(376, 31);
            txtTieuChi.TabIndex = 0;
            txtTieuChi.MouseClick += txtTieuChi_MouseClick;
            txtTieuChi.Leave += txtTieuChi_Leave;
            txtTieuChi.MouseLeave += txtTieuChi_MouseLeave;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateDenNgay);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTuNgay);
            groupBox2.Controls.Add(btnTimTheoNgay);
            groupBox2.Location = new Point(15, 188);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(392, 228);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm theo ngày";
            // 
            // dateDenNgay
            // 
            dateDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateDenNgay.Location = new Point(8, 136);
            dateDenNgay.Margin = new Padding(4);
            dateDenNgay.Name = "dateDenNgay";
            dateDenNgay.Size = new Size(376, 31);
            dateDenNgay.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(295, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 4;
            label1.Text = "Từ ngày";
            // 
            // dateTuNgay
            // 
            dateTuNgay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTuNgay.Location = new Point(8, 58);
            dateTuNgay.Margin = new Padding(4);
            dateTuNgay.Name = "dateTuNgay";
            dateTuNgay.Size = new Size(376, 31);
            dateTuNgay.TabIndex = 3;
            // 
            // btnTimTheoNgay
            // 
            btnTimTheoNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimTheoNgay.Image = (Image)resources.GetObject("btnTimTheoNgay.Image");
            btnTimTheoNgay.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimTheoNgay.Location = new Point(295, 178);
            btnTimTheoNgay.Margin = new Padding(4);
            btnTimTheoNgay.Name = "btnTimTheoNgay";
            btnTimTheoNgay.Size = new Size(91, 44);
            btnTimTheoNgay.TabIndex = 2;
            btnTimTheoNgay.Text = "   Tìm";
            btnTimTheoNgay.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnTimTheoKH);
            groupBox3.Controls.Add(btnTimKH);
            groupBox3.Location = new Point(15, 422);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(392, 89);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chọn theo khách hàng";
            // 
            // btnTimTheoKH
            // 
            btnTimTheoKH.Image = (Image)resources.GetObject("btnTimTheoKH.Image");
            btnTimTheoKH.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimTheoKH.Location = new Point(295, 32);
            btnTimTheoKH.Margin = new Padding(4);
            btnTimTheoKH.Name = "btnTimTheoKH";
            btnTimTheoKH.Size = new Size(91, 44);
            btnTimTheoKH.TabIndex = 2;
            btnTimTheoKH.Text = "   Tìm";
            btnTimTheoKH.UseVisualStyleBackColor = true;
            // 
            // btnTimKH
            // 
            btnTimKH.Location = new Point(8, 32);
            btnTimKH.Margin = new Padding(4);
            btnTimKH.Name = "btnTimKH";
            btnTimKH.Size = new Size(178, 44);
            btnTimKH.TabIndex = 1;
            btnTimKH.Text = "Chọn khách hàng";
            btnTimKH.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnTimTheoNV);
            groupBox4.Controls.Add(btnTimNV);
            groupBox4.Location = new Point(15, 519);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(392, 89);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chọn theo nhân viên";
            // 
            // btnTimTheoNV
            // 
            btnTimTheoNV.Image = (Image)resources.GetObject("btnTimTheoNV.Image");
            btnTimTheoNV.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimTheoNV.Location = new Point(295, 32);
            btnTimTheoNV.Margin = new Padding(4);
            btnTimTheoNV.Name = "btnTimTheoNV";
            btnTimTheoNV.Size = new Size(91, 44);
            btnTimTheoNV.TabIndex = 2;
            btnTimTheoNV.Text = "   Tìm";
            btnTimTheoNV.UseVisualStyleBackColor = true;
            // 
            // btnTimNV
            // 
            btnTimNV.Location = new Point(8, 32);
            btnTimNV.Margin = new Padding(4);
            btnTimNV.Name = "btnTimNV";
            btnTimNV.Size = new Size(178, 44);
            btnTimNV.TabIndex = 1;
            btnTimNV.Text = "Chọn nhân viên";
            btnTimNV.UseVisualStyleBackColor = true;
            // 
            // TimHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 630);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4);
            Name = "TimHoaDon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tìm hoá đơn";
            FormClosed += TimHoaDon_FormClosed;
            Load += TimHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTim;
        private ComboBox cbbTieuChi;
        private TextBox txtTieuChi;
        private GroupBox groupBox2;
        private Button btnTimTheoNgay;
        private DateTimePicker dateDenNgay;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTuNgay;
        private GroupBox groupBox3;
        private Button btnTimTheoKH;
        private Button btnTimKH;
        private GroupBox groupBox4;
        private Button btnTimTheoNV;
        private Button btnTimNV;
    }
}