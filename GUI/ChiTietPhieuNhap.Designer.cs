namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
{
    partial class ChiTietPhieuNhap
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
            label11 = new Label();
            label2 = new Label();
            totalTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            nv_nameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            nv_idTextBox = new TextBox();
            label6 = new Label();
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
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 60);
            panel1.TabIndex = 1;
            // 
            // hoadonIdPanel
            // 
            hoadonIdPanel.Controls.Add(idPhieuNhap);
            hoadonIdPanel.Controls.Add(label1);
            hoadonIdPanel.Location = new Point(164, 12);
            hoadonIdPanel.Name = "hoadonIdPanel";
            hoadonIdPanel.Size = new Size(239, 35);
            hoadonIdPanel.TabIndex = 0;
            // 
            // idPhieuNhap
            // 
            idPhieuNhap.Enabled = false;
            idPhieuNhap.Location = new Point(104, 1);
            idPhieuNhap.Name = "idPhieuNhap";
            idPhieuNhap.ReadOnly = true;
            idPhieuNhap.Size = new Size(132, 31);
            idPhieuNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 4);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Số Phiếu :";
            // 
            // dgvPanel
            // 
            dgvPanel.Controls.Add(ctpnGridView);
            dgvPanel.Location = new Point(5, 78);
            dgvPanel.Name = "dgvPanel";
            dgvPanel.Size = new Size(561, 380);
            dgvPanel.TabIndex = 2;
            // 
            // ctpnGridView
            // 
            ctpnGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ctpnGridView.Dock = DockStyle.Fill;
            ctpnGridView.Location = new Point(0, 0);
            ctpnGridView.Name = "ctpnGridView";
            ctpnGridView.RowHeadersWidth = 62;
            ctpnGridView.RowTemplate.Height = 33;
            ctpnGridView.Size = new Size(561, 380);
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
            panel2.Location = new Point(5, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 173);
            panel2.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 640);
            label11.Name = "label11";
            label11.Size = new Size(152, 25);
            label11.TabIndex = 8;
            label11.Text = "@quanlibanpiano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 0;
            label2.Text = "Tổng chi phí :";
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(408, 9);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(150, 31);
            totalTextBox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(233, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(325, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(233, 45);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(325, 31);
            nv_nameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 126);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 1;
            label5.Text = "Thời gian :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 48);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 0;
            label4.Text = "Nhân viên  : ";
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(347, 83);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(211, 31);
            nv_idTextBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 89);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 2;
            label6.Text = "Mã nhân viên :";
            // 
            // ChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 674);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(dgvPanel);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(600, 730);
            MinimizeBox = false;
            MinimumSize = new Size(600, 730);
            Name = "ChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChiTietPhieuNhap";
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