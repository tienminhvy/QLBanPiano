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
            btnGioiThieu = new ToolStripButton();
            dangXuatBtn = new ToolStripButton();
            mainPanel = new Panel();
            statusStrip1 = new StatusStrip();
            lblThongTinDangNhap = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            pianoToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            hoáĐơnToolStripMenuItem = new ToolStripMenuItem();
            vaiTròToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            mainPanel.SuspendLayout();
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
            mainPanel.Size = new Size(800, 423);
            mainPanel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThongTinDangNhap });
            statusStrip1.Location = new Point(0, 397);
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
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { pianoToolStripMenuItem, kháchHàngToolStripMenuItem, nhânViênToolStripMenuItem, phiếuNhậpToolStripMenuItem, hoáĐơnToolStripMenuItem, vaiTròToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(123, 24);
            toolStripDropDownButton1.Text = "Xem danh sách";
            // 
            // pianoToolStripMenuItem
            // 
            pianoToolStripMenuItem.Name = "pianoToolStripMenuItem";
            pianoToolStripMenuItem.Size = new Size(224, 26);
            pianoToolStripMenuItem.Text = "Piano";
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(224, 26);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            phiếuNhậpToolStripMenuItem.Size = new Size(224, 26);
            phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // hoáĐơnToolStripMenuItem
            // 
            hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            hoáĐơnToolStripMenuItem.Size = new Size(224, 26);
            hoáĐơnToolStripMenuItem.Text = "Hoá đơn";
            // 
            // vaiTròToolStripMenuItem
            // 
            vaiTròToolStripMenuItem.Name = "vaiTròToolStripMenuItem";
            vaiTròToolStripMenuItem.Size = new Size(224, 26);
            vaiTròToolStripMenuItem.Text = "Vai trò";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(75, 24);
            toolStripButton1.Text = "Bán hàng";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripButton dangXuatBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblThongTinDangNhap;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem pianoToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem hoáĐơnToolStripMenuItem;
        private ToolStripMenuItem vaiTròToolStripMenuItem;
        private ToolStripButton toolStripButton1;
    }
}