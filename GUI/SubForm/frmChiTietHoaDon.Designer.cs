namespace QLBanPiano.GUI
{
    partial class frmChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietHoaDon));
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
            exportBillBtn = new Button();
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
            panel1.Location = new Point(4, 10);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 48);
            panel1.TabIndex = 0;
            // 
            // hoadonIdPanel
            // 
            hoadonIdPanel.Controls.Add(idHoaDon);
            hoadonIdPanel.Controls.Add(label1);
            hoadonIdPanel.Location = new Point(146, 10);
            hoadonIdPanel.Margin = new Padding(2);
            hoadonIdPanel.Name = "hoadonIdPanel";
            hoadonIdPanel.Size = new Size(174, 28);
            hoadonIdPanel.TabIndex = 0;
            // 
            // idHoaDon
            // 
            idHoaDon.Enabled = false;
            idHoaDon.Location = new Point(66, 2);
            idHoaDon.Margin = new Padding(2);
            idHoaDon.Name = "idHoaDon";
            idHoaDon.ReadOnly = true;
            idHoaDon.Size = new Size(106, 27);
            idHoaDon.TabIndex = 1;
            idHoaDon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Số HD :";
            // 
            // dgvPanel
            // 
            dgvPanel.Controls.Add(cthdGridView);
            dgvPanel.Location = new Point(4, 62);
            dgvPanel.Margin = new Padding(2);
            dgvPanel.Name = "dgvPanel";
            dgvPanel.Size = new Size(449, 166);
            dgvPanel.TabIndex = 1;
            // 
            // cthdGridView
            // 
            cthdGridView.AllowUserToAddRows = false;
            cthdGridView.AllowUserToDeleteRows = false;
            cthdGridView.BackgroundColor = Color.White;
            cthdGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cthdGridView.Dock = DockStyle.Fill;
            cthdGridView.Location = new Point(0, 0);
            cthdGridView.Margin = new Padding(2);
            cthdGridView.Name = "cthdGridView";
            cthdGridView.ReadOnly = true;
            cthdGridView.RowHeadersWidth = 62;
            cthdGridView.RowTemplate.Height = 33;
            cthdGridView.Size = new Size(449, 166);
            cthdGridView.TabIndex = 0;
            cthdGridView.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(returnTextBox);
            panel2.Controls.Add(takeTextBox);
            panel2.Controls.Add(totalTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(4, 234);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 115);
            panel2.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 66);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 6;
            label10.Text = "Trả lại khách :";
            label10.Visible = false;
            // 
            // returnTextBox
            // 
            returnTextBox.Enabled = false;
            returnTextBox.Location = new Point(326, 62);
            returnTextBox.Margin = new Padding(2);
            returnTextBox.Name = "returnTextBox";
            returnTextBox.ReadOnly = true;
            returnTextBox.Size = new Size(121, 27);
            returnTextBox.TabIndex = 5;
            returnTextBox.TabStop = false;
            returnTextBox.Visible = false;
            // 
            // takeTextBox
            // 
            takeTextBox.Enabled = false;
            takeTextBox.Location = new Point(326, 34);
            takeTextBox.Margin = new Padding(2);
            takeTextBox.Name = "takeTextBox";
            takeTextBox.ReadOnly = true;
            takeTextBox.Size = new Size(121, 27);
            takeTextBox.TabIndex = 4;
            takeTextBox.TabStop = false;
            takeTextBox.Visible = false;
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(326, 5);
            totalTextBox.Margin = new Padding(2);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(121, 27);
            totalTextBox.TabIndex = 3;
            totalTextBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 39);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 1;
            label3.Text = "Khách trả :";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
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
            panel3.Location = new Point(4, 354);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 161);
            panel3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(184, 38);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.TabStop = false;
            // 
            // kh_idTextBox
            // 
            kh_idTextBox.Enabled = false;
            kh_idTextBox.Location = new Point(184, 126);
            kh_idTextBox.Margin = new Padding(2);
            kh_idTextBox.Name = "kh_idTextBox";
            kh_idTextBox.ReadOnly = true;
            kh_idTextBox.Size = new Size(170, 27);
            kh_idTextBox.TabIndex = 8;
            kh_idTextBox.TabStop = false;
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(184, 67);
            nv_idTextBox.Margin = new Padding(2);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(170, 27);
            nv_idTextBox.TabIndex = 7;
            nv_idTextBox.TabStop = false;
            // 
            // kh_nameTextBox
            // 
            kh_nameTextBox.Enabled = false;
            kh_nameTextBox.Location = new Point(184, 94);
            kh_nameTextBox.Margin = new Padding(2);
            kh_nameTextBox.Name = "kh_nameTextBox";
            kh_nameTextBox.ReadOnly = true;
            kh_nameTextBox.Size = new Size(261, 27);
            kh_nameTextBox.TabIndex = 6;
            kh_nameTextBox.TabStop = false;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(184, 7);
            nv_nameTextBox.Margin = new Padding(2);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(261, 27);
            nv_nameTextBox.TabIndex = 5;
            nv_nameTextBox.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 131);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 4;
            label8.Text = "Mã khách :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 99);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 3;
            label7.Text = "Tên khách :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 72);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 2;
            label6.Text = "Mã nhân viên :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 42);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 1;
            label5.Text = "Thời gian :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 12);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 0;
            label4.Text = "Nhân viên : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 552);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(127, 20);
            label11.TabIndex = 7;
            label11.Text = "@quanlibanpiano";
            // 
            // exportBillBtn
            // 
            exportBillBtn.Image = (Image)resources.GetObject("exportBillBtn.Image");
            exportBillBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exportBillBtn.Location = new Point(150, 519);
            exportBillBtn.Margin = new Padding(2);
            exportBillBtn.Name = "exportBillBtn";
            exportBillBtn.Size = new Size(147, 42);
            exportBillBtn.TabIndex = 8;
            exportBillBtn.Text = "   Xuất hóa đơn";
            exportBillBtn.UseVisualStyleBackColor = true;
            exportBillBtn.Click += exportFileBtn_Click;
            exportBillBtn.KeyPress += exportFileBtn_KeyPress;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 586);
            Controls.Add(exportBillBtn);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvPanel);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(484, 633);
            MinimizeBox = false;
            MinimumSize = new Size(484, 633);
            Name = "frmChiTietHoaDon";
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
        private TextBox totalTextBox;
        private Label label11;
        private Label label10;
        private TextBox returnTextBox;
        private TextBox takeTextBox;
        private Label label3;
        private Button exportBillBtn;
    }
}