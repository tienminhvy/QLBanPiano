namespace QLBanPiano.GUI.SubForm
{
    partial class frmThongKeThuongHieu
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
            pvThuongHieu = new OxyPlot.WindowsForms.PlotView();
            panel2 = new Panel();
            lvThuongHieu = new ListView();
            cbbChonThang = new ComboBox();
            label2 = new Label();
            cbbChonNam = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pvThuongHieu);
            panel1.Location = new Point(1, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 637);
            panel1.TabIndex = 0;
            // 
            // pvThuongHieu
            // 
            pvThuongHieu.Dock = DockStyle.Fill;
            pvThuongHieu.Enabled = false;
            pvThuongHieu.Location = new Point(0, 0);
            pvThuongHieu.Name = "pvThuongHieu";
            pvThuongHieu.PanCursor = Cursors.Hand;
            pvThuongHieu.Size = new Size(811, 637);
            pvThuongHieu.TabIndex = 0;
            pvThuongHieu.ZoomHorizontalCursor = Cursors.SizeWE;
            pvThuongHieu.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvThuongHieu.ZoomVerticalCursor = Cursors.SizeNS;
            pvThuongHieu.Click += plotView1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lvThuongHieu);
            panel2.Location = new Point(820, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 637);
            panel2.TabIndex = 1;
            // 
            // lvThuongHieu
            // 
            lvThuongHieu.Dock = DockStyle.Fill;
            lvThuongHieu.Location = new Point(0, 0);
            lvThuongHieu.Name = "lvThuongHieu";
            lvThuongHieu.Size = new Size(239, 637);
            lvThuongHieu.TabIndex = 0;
            lvThuongHieu.UseCompatibleStateImageBehavior = false;
            lvThuongHieu.View = View.Details;
            lvThuongHieu.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // cbbChonThang
            // 
            cbbChonThang.FormattingEnabled = true;
            cbbChonThang.Items.AddRange(new object[] { "Cả Năm", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbChonThang.Location = new Point(914, 6);
            cbbChonThang.Name = "cbbChonThang";
            cbbChonThang.Size = new Size(142, 28);
            cbbChonThang.TabIndex = 11;
            cbbChonThang.SelectedIndexChanged += cbbChonThang_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(820, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 10;
            label2.Text = "Chọn Tháng";
            // 
            // cbbChonNam
            // 
            cbbChonNam.FormattingEnabled = true;
            cbbChonNam.Location = new Point(661, 6);
            cbbChonNam.Name = "cbbChonNam";
            cbbChonNam.Size = new Size(151, 28);
            cbbChonNam.TabIndex = 9;
            cbbChonNam.SelectedIndexChanged += cbbChonNam_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(576, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 8;
            label1.Text = "Chọn Năm";
            // 
            // frmThongKeThuongHieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 706);
            Controls.Add(cbbChonThang);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(cbbChonNam);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmThongKeThuongHieu";
            Text = "frmThongKeThuongHieucs";
            Load += frmThongKeThuongHieucs_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private OxyPlot.WindowsForms.PlotView pvThuongHieu;
        private ListView lvThuongHieu;
        private ComboBox cbbChonThang;
        private Label label2;
        private ComboBox cbbChonNam;
        private Label label1;
    }
}