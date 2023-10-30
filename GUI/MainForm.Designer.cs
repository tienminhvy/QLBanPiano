namespace QLBanPiano
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            btnTaoMoi = new ToolStripSplitButton();
            taoMoiPianoToolStripMenuItem = new ToolStripMenuItem();
            taoMoiPhieuNhapToolStripMenuItem = new ToolStripMenuItem();
            taoMoiKHToolStripMenuItem = new ToolStripMenuItem();
            taoMoiNVToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            dsPianoToolStripMenuItem = new ToolStripMenuItem();
            dsPhieuNhapToolStripMenuItem = new ToolStripMenuItem();
            dsHDToolStripMenuItem = new ToolStripMenuItem();
            dsKHToolStripMenuItem1 = new ToolStripMenuItem();
            dsNVToolStripMenuItem1 = new ToolStripMenuItem();
            thaoTactoolStripSplitButton = new ToolStripSplitButton();
            nhapDuLieuToolStripMenuItem = new ToolStripMenuItem();
            xuatDuLieuToolStripMenuItem = new ToolStripMenuItem();
            btnGioiThieu = new ToolStripButton();
            dangXuatBtn = new ToolStripButton();
            mainPanel = new Panel();
            statusStrip1 = new StatusStrip();
            lblThongTinDangNhap = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            mainPanel.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, btnTaoMoi, toolStripSplitButton1, thaoTactoolStripSplitButton, btnGioiThieu, dangXuatBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(827, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(75, 24);
            toolStripButton1.Text = "Bán hàng";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTaoMoi.DropDownItems.AddRange(new ToolStripItem[] { taoMoiPianoToolStripMenuItem, taoMoiPhieuNhapToolStripMenuItem, taoMoiKHToolStripMenuItem, taoMoiNVToolStripMenuItem });
            btnTaoMoi.Image = (Image)resources.GetObject("btnTaoMoi.Image");
            btnTaoMoi.ImageTransparentColor = Color.Magenta;
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(83, 24);
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.ToolTipText = "Tạo mới";
            // 
            // taoMoiPianoToolStripMenuItem
            // 
            taoMoiPianoToolStripMenuItem.Name = "taoMoiPianoToolStripMenuItem";
            taoMoiPianoToolStripMenuItem.Size = new Size(234, 26);
            taoMoiPianoToolStripMenuItem.Text = "Sản phẩm Piano";
            // 
            // taoMoiPhieuNhapToolStripMenuItem
            // 
            taoMoiPhieuNhapToolStripMenuItem.Name = "taoMoiPhieuNhapToolStripMenuItem";
            taoMoiPhieuNhapToolStripMenuItem.Size = new Size(234, 26);
            taoMoiPhieuNhapToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // taoMoiKHToolStripMenuItem
            // 
            taoMoiKHToolStripMenuItem.Name = "taoMoiKHToolStripMenuItem";
            taoMoiKHToolStripMenuItem.Size = new Size(234, 26);
            taoMoiKHToolStripMenuItem.Text = "Thông tin khách hàng";
            // 
            // taoMoiNVToolStripMenuItem
            // 
            taoMoiNVToolStripMenuItem.Name = "taoMoiNVToolStripMenuItem";
            taoMoiNVToolStripMenuItem.Size = new Size(234, 26);
            taoMoiNVToolStripMenuItem.Text = "Nhân viên";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { dsPianoToolStripMenuItem, dsPhieuNhapToolStripMenuItem, dsHDToolStripMenuItem, dsKHToolStripMenuItem1, dsNVToolStripMenuItem1 });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(128, 24);
            toolStripSplitButton1.Text = "Xem danh sách";
            // 
            // dsPianoToolStripMenuItem
            // 
            dsPianoToolStripMenuItem.Name = "dsPianoToolStripMenuItem";
            dsPianoToolStripMenuItem.Size = new Size(234, 26);
            dsPianoToolStripMenuItem.Text = "Sản phẩm Piano";
            dsPianoToolStripMenuItem.Click += dsPianoToolStripMenuItem_Click;
            // 
            // dsPhieuNhapToolStripMenuItem
            // 
            dsPhieuNhapToolStripMenuItem.Name = "dsPhieuNhapToolStripMenuItem";
            dsPhieuNhapToolStripMenuItem.Size = new Size(234, 26);
            dsPhieuNhapToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // dsHDToolStripMenuItem
            // 
            dsHDToolStripMenuItem.Name = "dsHDToolStripMenuItem";
            dsHDToolStripMenuItem.Size = new Size(234, 26);
            dsHDToolStripMenuItem.Text = "Hoá đơn";
            // 
            // dsKHToolStripMenuItem1
            // 
            dsKHToolStripMenuItem1.Name = "dsKHToolStripMenuItem1";
            dsKHToolStripMenuItem1.Size = new Size(234, 26);
            dsKHToolStripMenuItem1.Text = "Thông tin khách hàng";
            // 
            // dsNVToolStripMenuItem1
            // 
            dsNVToolStripMenuItem1.Name = "dsNVToolStripMenuItem1";
            dsNVToolStripMenuItem1.Size = new Size(234, 26);
            dsNVToolStripMenuItem1.Text = "Nhân viên";
            // 
            // thaoTactoolStripSplitButton
            // 
            thaoTactoolStripSplitButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            thaoTactoolStripSplitButton.DropDownItems.AddRange(new ToolStripItem[] { nhapDuLieuToolStripMenuItem, xuatDuLieuToolStripMenuItem });
            thaoTactoolStripSplitButton.Image = (Image)resources.GetObject("thaoTactoolStripSplitButton.Image");
            thaoTactoolStripSplitButton.ImageTransparentColor = Color.Magenta;
            thaoTactoolStripSplitButton.Name = "thaoTactoolStripSplitButton";
            thaoTactoolStripSplitButton.Size = new Size(85, 24);
            thaoTactoolStripSplitButton.Text = "Thao tác";
            // 
            // nhapDuLieuToolStripMenuItem
            // 
            nhapDuLieuToolStripMenuItem.Name = "nhapDuLieuToolStripMenuItem";
            nhapDuLieuToolStripMenuItem.Size = new Size(178, 26);
            nhapDuLieuToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // xuatDuLieuToolStripMenuItem
            // 
            xuatDuLieuToolStripMenuItem.Name = "xuatDuLieuToolStripMenuItem";
            xuatDuLieuToolStripMenuItem.Size = new Size(178, 26);
            xuatDuLieuToolStripMenuItem.Text = "Xuất dữ liệu";
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGioiThieu.Image = (Image)resources.GetObject("btnGioiThieu.Image");
            btnGioiThieu.ImageTransparentColor = Color.Magenta;
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Size = new Size(77, 24);
            btnGioiThieu.Text = "Giới thiệu";
            btnGioiThieu.Click += btnGioiThieu_Click;
            // 
            // dangXuatBtn
            // 
            dangXuatBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            dangXuatBtn.Image = (Image)resources.GetObject("dangXuatBtn.Image");
            dangXuatBtn.ImageTransparentColor = Color.Magenta;
            dangXuatBtn.Name = "dangXuatBtn";
            dangXuatBtn.Size = new Size(81, 24);
            dangXuatBtn.Text = "Đăng xuất";
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImageLayout = ImageLayout.Center;
            mainPanel.Controls.Add(statusStrip1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 27);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(827, 423);
            mainPanel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongTinDangNhap });
            statusStrip1.Location = new Point(0, 397);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(827, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThongTinDangNhap
            // 
            lblThongTinDangNhap.Name = "lblThongTinDangNhap";
            lblThongTinDangNhap.Size = new Size(200, 20);
            lblThongTinDangNhap.Text = "Bạn đang đăng nhập với tên ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 450);
            Controls.Add(mainPanel);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "Phần mềm quản lý bán nhạc cụ Piano";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGioiThieu;
        private Panel mainPanel;
        private ToolStripSplitButton btnTaoMoi;
        private ToolStripMenuItem taoMoiPianoToolStripMenuItem;
        private ToolStripMenuItem taoMoiPhieuNhapToolStripMenuItem;
        private ToolStripMenuItem taoMoiKHToolStripMenuItem;
        private ToolStripMenuItem taoMoiNVToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem dsPianoToolStripMenuItem;
        private ToolStripMenuItem dsPhieuNhapToolStripMenuItem;
        private ToolStripMenuItem dsHDToolStripMenuItem;
        private ToolStripMenuItem dsKHToolStripMenuItem1;
        private ToolStripMenuItem dsNVToolStripMenuItem1;
        private ToolStripSplitButton thaoTactoolStripSplitButton;
        private ToolStripMenuItem nhapDuLieuToolStripMenuItem;
        private ToolStripMenuItem xuatDuLieuToolStripMenuItem;
        private ToolStripButton dangXuatBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThongTinDangNhap;
        private ToolStripButton toolStripButton1;
    }
}