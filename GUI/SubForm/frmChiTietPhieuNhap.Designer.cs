namespace QLBanPiano.GUI
{
    partial class frmChiTietPhieuNhap
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
            hoadonIdPanel = new Panel();
            idPhieuNhap = new TextBox();
            label1 = new Label();
            dgvPanel = new Panel();
            ctpnGridView = new DataGridView();
            panel2 = new Panel();
            nv_nameTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            totalTextBox = new TextBox();
            nv_idTextBox = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            hoadonIdPanel.SuspendLayout();
            dgvPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ctpnGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(hoadonIdPanel);
            panel1.Location = new Point(4, 10);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 48);
            panel1.TabIndex = 1;
            // 
            // hoadonIdPanel
            // 
            hoadonIdPanel.Controls.Add(idPhieuNhap);
            hoadonIdPanel.Controls.Add(label1);
            hoadonIdPanel.Location = new Point(131, 10);
            hoadonIdPanel.Margin = new Padding(2, 2, 2, 2);
            hoadonIdPanel.Name = "hoadonIdPanel";
            hoadonIdPanel.Size = new Size(191, 28);
            hoadonIdPanel.TabIndex = 0;
            // 
            // idPhieuNhap
            // 
            idPhieuNhap.Enabled = false;
            idPhieuNhap.Location = new Point(83, 1);
            idPhieuNhap.Margin = new Padding(2, 2, 2, 2);
            idPhieuNhap.Name = "idPhieuNhap";
            idPhieuNhap.ReadOnly = true;
            idPhieuNhap.Size = new Size(106, 27);
            idPhieuNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Số Phiếu :";
            // 
            // dgvPanel
            // 
            dgvPanel.Controls.Add(ctpnGridView);
            dgvPanel.Location = new Point(4, 62);
            dgvPanel.Margin = new Padding(2, 2, 2, 2);
            dgvPanel.Name = "dgvPanel";
            dgvPanel.Size = new Size(449, 304);
            dgvPanel.TabIndex = 2;
            // 
            // ctpnGridView
            // 
            ctpnGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ctpnGridView.Dock = DockStyle.Fill;
            ctpnGridView.Location = new Point(0, 0);
            ctpnGridView.Margin = new Padding(2, 2, 2, 2);
            ctpnGridView.Name = "ctpnGridView";
            ctpnGridView.RowHeadersWidth = 62;
            ctpnGridView.RowTemplate.Height = 33;
            ctpnGridView.Size = new Size(449, 304);
            ctpnGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(nv_nameTextBox);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(totalTextBox);
            panel2.Controls.Add(nv_idTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(4, 371);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 138);
            panel2.TabIndex = 3;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(186, 36);
            nv_nameTextBox.Margin = new Padding(2, 2, 2, 2);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(261, 27);
            nv_nameTextBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(186, 96);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 0;
            label4.Text = "Nhân viên  : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 101);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 1;
            label5.Text = "Thời gian :";
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(326, 7);
            totalTextBox.Margin = new Padding(2, 2, 2, 2);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(121, 27);
            totalTextBox.TabIndex = 4;
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(278, 66);
            nv_idTextBox.Margin = new Padding(2, 2, 2, 2);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(170, 27);
            nv_idTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Tổng chi phí :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 71);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 2;
            label6.Text = "Mã nhân viên :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 512);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(127, 20);
            label11.TabIndex = 8;
            label11.Text = "@quanlibanpiano";
            // 
            // frmChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 546);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(dgvPanel);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MaximumSize = new Size(484, 593);
            MinimizeBox = false;
            MinimumSize = new Size(484, 593);
            Name = "frmChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết phiếu nhập";
            panel1.ResumeLayout(false);
            hoadonIdPanel.ResumeLayout(false);
            hoadonIdPanel.PerformLayout();
            dgvPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ctpnGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel hoadonIdPanel;
        private TextBox idPhieuNhap;
        private Label label1;
        private Panel dgvPanel;
        private DataGridView ctpnGridView;
        private Panel panel2;
        private Label label11;
        private Label label2;
        private TextBox totalTextBox;
        private TextBox nv_idTextBox;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox nv_nameTextBox;
        private Label label5;
        private Label label4;
    }
}