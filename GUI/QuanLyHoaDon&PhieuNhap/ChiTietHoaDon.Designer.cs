namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
{
    partial class ChiTietHoaDon
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
            idHoaDon = new TextBox();
            label1 = new Label();
            dgvPanel = new Panel();
            cthdGridView = new DataGridView();
            panel2 = new Panel();
            label10 = new Label();
            returnTextBox = new TextBox();
            takeTextBox = new TextBox();
            totalTextBox = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            kh_idTextBox = new TextBox();
            nv_idTextBox = new TextBox();
            kh_nameTextBox = new TextBox();
            nv_nameTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            hoadonIdPanel.SuspendLayout();
            dgvPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cthdGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(hoadonIdPanel);
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 60);
            panel1.TabIndex = 0;
            // 
            // hoadonIdPanel
            // 
            hoadonIdPanel.Controls.Add(idHoaDon);
            hoadonIdPanel.Controls.Add(label1);
            hoadonIdPanel.Location = new Point(182, 12);
            hoadonIdPanel.Name = "hoadonIdPanel";
            hoadonIdPanel.Size = new Size(217, 35);
            hoadonIdPanel.TabIndex = 0;
            // 
            // idHoaDon
            // 
            idHoaDon.Enabled = false;
            idHoaDon.Location = new Point(82, 2);
            idHoaDon.Name = "idHoaDon";
            idHoaDon.ReadOnly = true;
            idHoaDon.Size = new Size(132, 31);
            idHoaDon.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Số HD :";
            // 
            // dgvPanel
            // 
            dgvPanel.Controls.Add(cthdGridView);
            dgvPanel.Location = new Point(5, 78);
            dgvPanel.Name = "dgvPanel";
            dgvPanel.Size = new Size(561, 208);
            dgvPanel.TabIndex = 1;
            // 
            // cthdGridView
            // 
            cthdGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cthdGridView.Dock = DockStyle.Fill;
            cthdGridView.Location = new Point(0, 0);
            cthdGridView.Name = "cthdGridView";
            cthdGridView.RowHeadersWidth = 62;
            cthdGridView.RowTemplate.Height = 33;
            cthdGridView.Size = new Size(561, 208);
            cthdGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(returnTextBox);
            panel2.Controls.Add(takeTextBox);
            panel2.Controls.Add(totalTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 144);
            panel2.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 83);
            label10.Name = "label10";
            label10.Size = new Size(116, 25);
            label10.TabIndex = 6;
            label10.Text = "Trả lại khách :";
            // 
            // returnTextBox
            // 
            returnTextBox.Enabled = false;
            returnTextBox.Location = new Point(408, 77);
            returnTextBox.Name = "returnTextBox";
            returnTextBox.ReadOnly = true;
            returnTextBox.Size = new Size(150, 31);
            returnTextBox.TabIndex = 5;
            // 
            // takeTextBox
            // 
            takeTextBox.Enabled = false;
            takeTextBox.Location = new Point(408, 43);
            takeTextBox.Name = "takeTextBox";
            takeTextBox.ReadOnly = true;
            takeTextBox.Size = new Size(150, 31);
            takeTextBox.TabIndex = 4;
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(408, 6);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(150, 31);
            totalTextBox.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(54, 111);
            label9.Name = "label9";
            label9.Size = new Size(450, 21);
            label9.TabIndex = 2;
            label9.Text = "Xin cảm ơn quý khách vì đã mua sản phẩm của cửa hàng !";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 49);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 1;
            label3.Text = "Khách trả :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 0;
            label2.Text = "Tổng số/Tổng cộng :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(kh_idTextBox);
            panel3.Controls.Add(nv_idTextBox);
            panel3.Controls.Add(kh_nameTextBox);
            panel3.Controls.Add(nv_nameTextBox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(5, 442);
            panel3.Name = "panel3";
            panel3.Size = new Size(561, 201);
            panel3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(230, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(325, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // kh_idTextBox
            // 
            kh_idTextBox.Enabled = false;
            kh_idTextBox.Location = new Point(230, 158);
            kh_idTextBox.Name = "kh_idTextBox";
            kh_idTextBox.ReadOnly = true;
            kh_idTextBox.Size = new Size(211, 31);
            kh_idTextBox.TabIndex = 8;
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(230, 84);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(211, 31);
            nv_idTextBox.TabIndex = 7;
            // 
            // kh_nameTextBox
            // 
            kh_nameTextBox.Enabled = false;
            kh_nameTextBox.Location = new Point(230, 118);
            kh_nameTextBox.Name = "kh_nameTextBox";
            kh_nameTextBox.ReadOnly = true;
            kh_nameTextBox.Size = new Size(325, 31);
            kh_nameTextBox.TabIndex = 6;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(230, 9);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(325, 31);
            nv_nameTextBox.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 164);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 4;
            label8.Text = "Mã khách :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 124);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 3;
            label7.Text = "Tên khách :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 90);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 2;
            label6.Text = "Mã nhân viên :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 53);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 1;
            label5.Text = "Thời gian :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 15);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 0;
            label4.Text = "Nhân viên : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 646);
            label11.Name = "label11";
            label11.Size = new Size(152, 25);
            label11.TabIndex = 7;
            label11.Text = "@quanlibanpiano";
            // 
            // ChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 674);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvPanel);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(600, 730);
            MinimizeBox = false;
            MinimumSize = new Size(500, 730);
            Name = "ChiTietHoaDon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChiTietHoaDon";
            panel1.ResumeLayout(false);
            hoadonIdPanel.ResumeLayout(false);
            hoadonIdPanel.PerformLayout();
            dgvPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cthdGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel hoadonIdPanel;
        private Label label1;
        private TextBox idHoaDon;
        private Panel dgvPanel;
        private DataGridView cthdGridView;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox kh_idTextBox;
        private TextBox nv_idTextBox;
        private TextBox kh_nameTextBox;
        private TextBox nv_nameTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private TextBox totalTextBox;
        private Label label10;
        private TextBox returnTextBox;
        private TextBox takeTextBox;
        private Label label11;
    }
}