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
            mainPanel = new Panel();
            panel1 = new Panel();
            logoutBtn = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnTaoMoi, toolStripSplitButton1, thaoTactoolStripSplitButton, btnGioiThieu });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.DropDownItems.AddRange(new ToolStripItem[] { taoMoiPianoToolStripMenuItem, taoMoiPhieuNhapToolStripMenuItem, taoMoiKHToolStripMenuItem, taoMoiNVToolStripMenuItem });
            btnTaoMoi.Image = (Image)resources.GetObject("btnTaoMoi.Image");
            btnTaoMoi.ImageTransparentColor = Color.Magenta;
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(118, 29);
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.ToolTipText = "Tạo mới";
            // 
            // taoMoiPianoToolStripMenuItem
            // 
            taoMoiPianoToolStripMenuItem.Name = "taoMoiPianoToolStripMenuItem";
            taoMoiPianoToolStripMenuItem.Size = new Size(286, 34);
            taoMoiPianoToolStripMenuItem.Text = "Sản phẩm Piano";
            // 
            // taoMoiPhieuNhapToolStripMenuItem
            // 
            taoMoiPhieuNhapToolStripMenuItem.Name = "taoMoiPhieuNhapToolStripMenuItem";
            taoMoiPhieuNhapToolStripMenuItem.Size = new Size(286, 34);
            taoMoiPhieuNhapToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // taoMoiKHToolStripMenuItem
            // 
            taoMoiKHToolStripMenuItem.Name = "taoMoiKHToolStripMenuItem";
            taoMoiKHToolStripMenuItem.Size = new Size(286, 34);
            taoMoiKHToolStripMenuItem.Text = "Thông tin khách hàng";
            // 
            // taoMoiNVToolStripMenuItem
            // 
            taoMoiNVToolStripMenuItem.Name = "taoMoiNVToolStripMenuItem";
            taoMoiNVToolStripMenuItem.Size = new Size(286, 34);
            taoMoiNVToolStripMenuItem.Text = "Nhân viên";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { dsPianoToolStripMenuItem, dsPhieuNhapToolStripMenuItem, dsHDToolStripMenuItem, dsKHToolStripMenuItem1, dsNVToolStripMenuItem1 });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(174, 29);
            toolStripSplitButton1.Text = "Xem danh sách";
            // 
            // dsPianoToolStripMenuItem
            // 
            dsPianoToolStripMenuItem.Name = "dsPianoToolStripMenuItem";
            dsPianoToolStripMenuItem.Size = new Size(286, 34);
            dsPianoToolStripMenuItem.Text = "Sản phẩm Piano";
            // 
            // dsPhieuNhapToolStripMenuItem
            // 
            dsPhieuNhapToolStripMenuItem.Name = "dsPhieuNhapToolStripMenuItem";
            dsPhieuNhapToolStripMenuItem.Size = new Size(286, 34);
            dsPhieuNhapToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // dsHDToolStripMenuItem
            // 
            dsHDToolStripMenuItem.Name = "dsHDToolStripMenuItem";
            dsHDToolStripMenuItem.Size = new Size(286, 34);
            dsHDToolStripMenuItem.Text = "Hoá đơn";
            // 
            // dsKHToolStripMenuItem1
            // 
            dsKHToolStripMenuItem1.Name = "dsKHToolStripMenuItem1";
            dsKHToolStripMenuItem1.Size = new Size(286, 34);
            dsKHToolStripMenuItem1.Text = "Thông tin khách hàng";
            // 
            // dsNVToolStripMenuItem1
            // 
            dsNVToolStripMenuItem1.Name = "dsNVToolStripMenuItem1";
            dsNVToolStripMenuItem1.Size = new Size(286, 34);
            dsNVToolStripMenuItem1.Text = "Nhân viên";
            // 
            // thaoTactoolStripSplitButton
            // 
            thaoTactoolStripSplitButton.DropDownItems.AddRange(new ToolStripItem[] { nhapDuLieuToolStripMenuItem, xuatDuLieuToolStripMenuItem });
            thaoTactoolStripSplitButton.Image = (Image)resources.GetObject("thaoTactoolStripSplitButton.Image");
            thaoTactoolStripSplitButton.ImageTransparentColor = Color.Magenta;
            thaoTactoolStripSplitButton.Name = "thaoTactoolStripSplitButton";
            thaoTactoolStripSplitButton.Size = new Size(120, 29);
            thaoTactoolStripSplitButton.Text = "Thao tác";
            // 
            // nhapDuLieuToolStripMenuItem
            // 
            nhapDuLieuToolStripMenuItem.Name = "nhapDuLieuToolStripMenuItem";
            nhapDuLieuToolStripMenuItem.Size = new Size(216, 34);
            nhapDuLieuToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // xuatDuLieuToolStripMenuItem
            // 
            xuatDuLieuToolStripMenuItem.Name = "xuatDuLieuToolStripMenuItem";
            xuatDuLieuToolStripMenuItem.Size = new Size(216, 34);
            xuatDuLieuToolStripMenuItem.Text = "Xuất dữ liệu";
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.Image = (Image)resources.GetObject("btnGioiThieu.Image");
            btnGioiThieu.ImageTransparentColor = Color.Magenta;
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Size = new Size(111, 29);
            btnGioiThieu.Text = "Giới thiệu";
            btnGioiThieu.Click += btnGioiThieu_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImageLayout = ImageLayout.Center;
            mainPanel.Dock = DockStyle.Top;
            mainPanel.Location = new Point(0, 34);
            mainPanel.Margin = new Padding(4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1000, 488);
            mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(logoutBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(846, 522);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 40);
            panel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Fill;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 0);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(154, 40);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "    Đăng xuất";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 530);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(846, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(242, 25);
            toolStripStatusLabel1.Text = "Bạn đang đăng nhập với tên ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Phần mềm quản lý bán nhạc cụ Piano";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Button logoutBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}