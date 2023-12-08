namespace QLBanPiano.GUI
{
    partial class frmThemPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemPhieuNhap));
            groupBox1 = new GroupBox();
            txtIdNv = new TextBox();
            id_pnTextBox = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            CancelAddBtn = new Button();
            confirmAddBtn = new Button();
            ct_soLuongTextBox = new TextBox();
            label4 = new Label();
            totalTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            chiTietPhieuNhapGridView = new DataGridView();
            panel3 = new Panel();
            ct_addBtn = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chiTietPhieuNhapGridView).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdNv);
            groupBox1.Controls.Add(id_pnTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(441, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtIdNv
            // 
            txtIdNv.Enabled = false;
            txtIdNv.Location = new Point(170, 49);
            txtIdNv.Name = "txtIdNv";
            txtIdNv.Size = new Size(98, 27);
            txtIdNv.TabIndex = 7;
            // 
            // id_pnTextBox
            // 
            id_pnTextBox.Enabled = false;
            id_pnTextBox.Location = new Point(170, 83);
            id_pnTextBox.Margin = new Padding(2);
            id_pnTextBox.Name = "id_pnTextBox";
            id_pnTextBox.ReadOnly = true;
            id_pnTextBox.Size = new Size(96, 27);
            id_pnTextBox.TabIndex = 6;
            id_pnTextBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã phiếu nhập :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(170, 17);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã nhân viên   :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "Thời gian nhập :";
            // 
            // panel1
            // 
            panel1.Controls.Add(CancelAddBtn);
            panel1.Controls.Add(confirmAddBtn);
            panel1.Controls.Add(ct_soLuongTextBox);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(10, 363);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 40);
            panel1.TabIndex = 2;
            // 
            // CancelAddBtn
            // 
            CancelAddBtn.Image = (Image)resources.GetObject("CancelAddBtn.Image");
            CancelAddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelAddBtn.Location = new Point(85, 0);
            CancelAddBtn.Margin = new Padding(2);
            CancelAddBtn.Name = "CancelAddBtn";
            CancelAddBtn.Size = new Size(80, 40);
            CancelAddBtn.TabIndex = 1;
            CancelAddBtn.Text = "  Hủy";
            CancelAddBtn.UseVisualStyleBackColor = true;
            CancelAddBtn.Click += CancelAddBtn_Click;
            CancelAddBtn.KeyPress += CancelAddBtn_KeyPress;
            // 
            // confirmAddBtn
            // 
            confirmAddBtn.Image = (Image)resources.GetObject("confirmAddBtn.Image");
            confirmAddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            confirmAddBtn.Location = new Point(0, 0);
            confirmAddBtn.Margin = new Padding(2);
            confirmAddBtn.Name = "confirmAddBtn";
            confirmAddBtn.Size = new Size(80, 40);
            confirmAddBtn.TabIndex = 0;
            confirmAddBtn.Text = "   Thêm";
            confirmAddBtn.UseVisualStyleBackColor = true;
            confirmAddBtn.Click += confirmAddBtn_Click;
            confirmAddBtn.KeyPress += confirmAddBtn_KeyPress;
            // 
            // ct_soLuongTextBox
            // 
            ct_soLuongTextBox.Enabled = false;
            ct_soLuongTextBox.Location = new Point(307, 6);
            ct_soLuongTextBox.Margin = new Padding(2);
            ct_soLuongTextBox.Name = "ct_soLuongTextBox";
            ct_soLuongTextBox.ReadOnly = true;
            ct_soLuongTextBox.Size = new Size(134, 27);
            ct_soLuongTextBox.TabIndex = 3;
            ct_soLuongTextBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 10);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 2;
            label4.Text = "Số lượng (chi tiết ) :";
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(270, 8);
            totalTextBox.Margin = new Padding(2);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(172, 27);
            totalTextBox.TabIndex = 8;
            totalTextBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 10);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 7;
            label7.Text = "Tổng chi phí :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 406);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 3;
            label8.Text = "@quanlibanpiano";
            // 
            // panel2
            // 
            panel2.Controls.Add(chiTietPhieuNhapGridView);
            panel2.Location = new Point(10, 132);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 182);
            panel2.TabIndex = 4;
            // 
            // chiTietPhieuNhapGridView
            // 
            chiTietPhieuNhapGridView.AllowUserToAddRows = false;
            chiTietPhieuNhapGridView.AllowUserToDeleteRows = false;
            chiTietPhieuNhapGridView.BackgroundColor = Color.White;
            chiTietPhieuNhapGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chiTietPhieuNhapGridView.Dock = DockStyle.Fill;
            chiTietPhieuNhapGridView.GridColor = Color.White;
            chiTietPhieuNhapGridView.Location = new Point(0, 0);
            chiTietPhieuNhapGridView.Margin = new Padding(2);
            chiTietPhieuNhapGridView.Name = "chiTietPhieuNhapGridView";
            chiTietPhieuNhapGridView.ReadOnly = true;
            chiTietPhieuNhapGridView.RowHeadersWidth = 62;
            chiTietPhieuNhapGridView.RowTemplate.Height = 33;
            chiTietPhieuNhapGridView.Size = new Size(441, 182);
            chiTietPhieuNhapGridView.TabIndex = 0;
            chiTietPhieuNhapGridView.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(ct_addBtn);
            panel3.Controls.Add(totalTextBox);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(10, 318);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 40);
            panel3.TabIndex = 1;
            // 
            // ct_addBtn
            // 
            ct_addBtn.Image = (Image)resources.GetObject("ct_addBtn.Image");
            ct_addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ct_addBtn.Location = new Point(0, 0);
            ct_addBtn.Margin = new Padding(2);
            ct_addBtn.Name = "ct_addBtn";
            ct_addBtn.Size = new Size(165, 40);
            ct_addBtn.TabIndex = 0;
            ct_addBtn.Text = "       Thêm chi tiết ";
            ct_addBtn.TextAlign = ContentAlignment.MiddleLeft;
            ct_addBtn.UseVisualStyleBackColor = true;
            ct_addBtn.Click += ct_addBtn_Click;
            ct_addBtn.KeyPress += ct_addBtn_KeyPress;
            // 
            // frmThemPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 442);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(484, 489);
            MinimumSize = new Size(484, 489);
            Name = "frmThemPhieuNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm phiếu nhập";
            Load += ThemPhieuNhap_Load;
            KeyDown += frmThemPhieuNhap_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chiTietPhieuNhapGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label1;
        private TextBox id_pnTextBox;
        private Panel panel2;
        private DataGridView chiTietPhieuNhapGridView;
        private Label label7;
        private TextBox totalTextBox;
        private Panel panel3;
        private TextBox ct_soLuongTextBox;
        private Label label4;
        private Button ct_addBtn;
        private Button CancelAddBtn;
        private Button confirmAddBtn;
        private TextBox txtIdNv;
    }
}