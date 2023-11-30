namespace QLBanPiano
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            toolStrip1 = new ToolStrip();
            banHangtoolStripButton = new ToolStripButton();
            dstoolStripDropDownButton = new ToolStripDropDownButton();
            pianoToolStripMenuItem = new ToolStripMenuItem();
            khachHangToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            phieuNhapToolStripMenuItem = new ToolStripMenuItem();
            hoaDonToolStripMenuItem = new ToolStripMenuItem();
            vaiTroToolStripMenuItem = new ToolStripMenuItem();
            btnGioiThieu = new ToolStripButton();
            dangXuatBtn = new ToolStripButton();
            mainPanel = new Panel();
            statusStrip1 = new StatusStrip();
            lblThongTinDangNhap = new ToolStripStatusLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { banHangtoolStripButton, dstoolStripDropDownButton, btnGioiThieu, dangXuatBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1348, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // banHangtoolStripButton
            // 
            banHangtoolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            banHangtoolStripButton.Image = (Image)resources.GetObject("banHangtoolStripButton.Image");
            banHangtoolStripButton.ImageTransparentColor = Color.Magenta;
            banHangtoolStripButton.Name = "banHangtoolStripButton";
            banHangtoolStripButton.Size = new Size(75, 24);
            banHangtoolStripButton.Text = "Bán hàng";
            banHangtoolStripButton.Click += toolStripButton1_Click;
            // 
            // dstoolStripDropDownButton
            // 
            dstoolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            dstoolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { pianoToolStripMenuItem, khachHangToolStripMenuItem, nhanVienToolStripMenuItem, phieuNhapToolStripMenuItem, hoaDonToolStripMenuItem, vaiTroToolStripMenuItem });
            dstoolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            dstoolStripDropDownButton.Name = "dstoolStripDropDownButton";
            dstoolStripDropDownButton.Size = new Size(123, 24);
            dstoolStripDropDownButton.Text = "Xem danh sách";
            // 
            // pianoToolStripMenuItem
            // 
            pianoToolStripMenuItem.Name = "pianoToolStripMenuItem";
            pianoToolStripMenuItem.Size = new Size(169, 26);
            pianoToolStripMenuItem.Text = "Piano";
            pianoToolStripMenuItem.Click += pianoToolStripMenuItem_Click;
            // 
            // khachHangToolStripMenuItem
            // 
            khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            khachHangToolStripMenuItem.Size = new Size(169, 26);
            khachHangToolStripMenuItem.Text = "Khách hàng";
            khachHangToolStripMenuItem.Click += khachHangToolStripMenuItem_Click;
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(169, 26);
            nhanVienToolStripMenuItem.Text = "Nhân viên";
            nhanVienToolStripMenuItem.Click += nhanVienToolStripMenuItem_Click;
            // 
            // phieuNhapToolStripMenuItem
            // 
            phieuNhapToolStripMenuItem.Name = "phieuNhapToolStripMenuItem";
            phieuNhapToolStripMenuItem.Size = new Size(169, 26);
            phieuNhapToolStripMenuItem.Text = "Phiếu nhập";
            phieuNhapToolStripMenuItem.Click += phieuNhapToolStripMenuItem_Click;
            // 
            // hoaDonToolStripMenuItem
            // 
            hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            hoaDonToolStripMenuItem.Size = new Size(169, 26);
            hoaDonToolStripMenuItem.Text = "Hoá đơn";
            hoaDonToolStripMenuItem.Click += hoaDonToolStripMenuItem_Click;
            // 
            // vaiTroToolStripMenuItem
            // 
            vaiTroToolStripMenuItem.Name = "vaiTroToolStripMenuItem";
            vaiTroToolStripMenuItem.Size = new Size(169, 26);
            vaiTroToolStripMenuItem.Text = "Vai trò";
            vaiTroToolStripMenuItem.Click += vaiTroToolStripMenuItem_Click;
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
            dangXuatBtn.ImageTransparentColor = Color.Magenta;
            dangXuatBtn.Name = "dangXuatBtn";
            dangXuatBtn.Size = new Size(81, 24);
            dangXuatBtn.Text = "Đăng xuất";
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImageLayout = ImageLayout.None;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 27);
            mainPanel.MinimumSize = new Size(1366, 900);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1366, 900);
            mainPanel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongTinDangNhap });
            statusStrip1.Location = new Point(0, 3);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1348, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThongTinDangNhap
            // 
            lblThongTinDangNhap.Name = "lblThongTinDangNhap";
            lblThongTinDangNhap.Size = new Size(200, 20);
            lblThongTinDangNhap.Text = "Bạn đang đăng nhập với tên ";
            // 
            // panel1
            // 
            panel1.Controls.Add(statusStrip1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 692);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 29);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 682);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 10);
            panel2.TabIndex = 3;
            // 
            // frmChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(1366, 768);
            Name = "frmChinh";
            Text = "Phần mềm quản lý bán nhạc cụ Piano";
            FormClosing += frmChinh_FormClosing;
            FormClosed += frmChinh_FormClosed;
            Load += frmChinh_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGioiThieu;
        private Panel mainPanel;
        private ToolStripButton dangXuatBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThongTinDangNhap;
        private ToolStripDropDownButton dstoolStripDropDownButton;
        private ToolStripMenuItem pianoToolStripMenuItem;
        private ToolStripMenuItem khachHangToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem phieuNhapToolStripMenuItem;
        private ToolStripMenuItem hoaDonToolStripMenuItem;
        private ToolStripMenuItem vaiTroToolStripMenuItem;
        private ToolStripButton banHangtoolStripButton;
        private Panel panel1;
        private Panel panel2;
    }
}