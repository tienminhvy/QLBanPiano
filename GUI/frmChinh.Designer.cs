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
            toolStripButton1 = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            pianoToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            phieuNhapToolStripMenuItem = new ToolStripMenuItem();
            hoaDonToolStripMenuItem = new ToolStripMenuItem();
            vaiTroToolStripMenuItem = new ToolStripMenuItem();
            btnGioiThieu = new ToolStripButton();
            dangXuatBtn = new ToolStripButton();
            mainPanel = new Panel();
            statusStrip1 = new StatusStrip();
            lblThongTinDangNhap = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripDropDownButton1, btnGioiThieu, dangXuatBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
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
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { pianoToolStripMenuItem, kháchHàngToolStripMenuItem, nhanVienToolStripMenuItem, phieuNhapToolStripMenuItem, hoaDonToolStripMenuItem, vaiTroToolStripMenuItem });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(123, 24);
            toolStripDropDownButton1.Text = "Xem danh sách";
            // 
            // pianoToolStripMenuItem
            // 
            pianoToolStripMenuItem.Name = "pianoToolStripMenuItem";
            pianoToolStripMenuItem.Size = new Size(169, 26);
            pianoToolStripMenuItem.Text = "Piano";
            pianoToolStripMenuItem.Click += pianoToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(169, 26);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
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
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 423);
            mainPanel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongTinDangNhap });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThongTinDangNhap
            // 
            lblThongTinDangNhap.Name = "lblThongTinDangNhap";
            lblThongTinDangNhap.Size = new Size(200, 20);
            lblThongTinDangNhap.Text = "Bạn đang đăng nhập với tên ";
            // 
            // frmChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(mainPanel);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "frmChinh";
            Text = "Phần mềm quản lý bán nhạc cụ Piano";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem pianoToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem phieuNhapToolStripMenuItem;
        private ToolStripMenuItem hoaDonToolStripMenuItem;
        private ToolStripMenuItem vaiTroToolStripMenuItem;
        private ToolStripButton toolStripButton1;
    }
}