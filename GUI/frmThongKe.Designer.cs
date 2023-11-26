namespace QLBanPiano.GUI
{
    partial class frmThongKe
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
            pvDoanhThu = new OxyPlot.WindowsForms.PlotView();
            lvDoanhThu = new ListView();
            Thang = new ColumnHeader();
            TongThu = new ColumnHeader();
            TongChi = new ColumnHeader();
            LoiNhuan = new ColumnHeader();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            cbbChonNam = new ComboBox();
            cbbChonThang = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pvDoanhThu
            // 
            pvDoanhThu.Dock = DockStyle.Fill;
            pvDoanhThu.Enabled = false;
            pvDoanhThu.Location = new Point(0, 0);
            pvDoanhThu.Name = "pvDoanhThu";
            pvDoanhThu.PanCursor = Cursors.Hand;
            pvDoanhThu.Size = new Size(1124, 566);
            pvDoanhThu.TabIndex = 0;
            pvDoanhThu.Text = "pvDoanhThu";
            pvDoanhThu.ZoomHorizontalCursor = Cursors.SizeWE;
            pvDoanhThu.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvDoanhThu.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // lvDoanhThu
            // 
            lvDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvDoanhThu.Columns.AddRange(new ColumnHeader[] { Thang, TongThu, TongChi, LoiNhuan });
            lvDoanhThu.Location = new Point(3, 3);
            lvDoanhThu.Name = "lvDoanhThu";
            lvDoanhThu.Size = new Size(1118, 145);
            lvDoanhThu.TabIndex = 1;
            lvDoanhThu.UseCompatibleStateImageBehavior = false;
            lvDoanhThu.View = View.Details;
            // 
            // Thang
            // 
            Thang.Text = "Tháng";
            // 
            // TongThu
            // 
            TongThu.Text = "Tổng Thu";
            TongThu.TextAlign = HorizontalAlignment.Center;
            TongThu.Width = 350;
            // 
            // TongChi
            // 
            TongChi.Text = "Tổng Chi";
            TongChi.TextAlign = HorizontalAlignment.Center;
            TongChi.Width = 350;
            // 
            // LoiNhuan
            // 
            LoiNhuan.Text = "Lợi Nhuận";
            LoiNhuan.TextAlign = HorizontalAlignment.Center;
            LoiNhuan.Width = 270;
            // 
            // panel1
            // 
            panel1.Controls.Add(pvDoanhThu);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 735);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lvDoanhThu);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 566);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 169);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 154);
            panel4.Name = "panel4";
            panel4.Size = new Size(1124, 12);
            panel4.TabIndex = 4;
            panel4.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(607, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Chọn Năm";
            // 
            // cbbChonNam
            // 
            cbbChonNam.Anchor = AnchorStyles.Top;
            cbbChonNam.FormattingEnabled = true;
            cbbChonNam.Location = new Point(692, 12);
            cbbChonNam.Name = "cbbChonNam";
            cbbChonNam.Size = new Size(151, 28);
            cbbChonNam.TabIndex = 5;
            cbbChonNam.SelectedIndexChanged += cbbChonNam_SelectedIndexChanged;
            // 
            // cbbChonThang
            // 
            cbbChonThang.Anchor = AnchorStyles.Top;
            cbbChonThang.FormattingEnabled = true;
            cbbChonThang.Items.AddRange(new object[] { "Cả Năm", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbChonThang.Location = new Point(945, 12);
            cbbChonThang.Name = "cbbChonThang";
            cbbChonThang.Size = new Size(142, 28);
            cbbChonThang.TabIndex = 7;
            cbbChonThang.SelectedIndexChanged += cbbChonThang_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(851, 15);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 6;
            label2.Text = "Chọn Tháng";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cbbChonThang);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbbChonNam);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1124, 52);
            panel3.TabIndex = 8;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 735);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "frmThongKe";
            Text = "ThongKe";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView pvDoanhThu;
        private ListView lvDoanhThu;
        private Panel panel1;
        private Panel panel2;
        private ColumnHeader Thang;
        private ColumnHeader TongThu;
        private ColumnHeader TongChi;
        private ColumnHeader LoiNhuan;
        private Label label1;
        private ComboBox cbbChonNam;
        private ComboBox cbbChonThang;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
    }
}