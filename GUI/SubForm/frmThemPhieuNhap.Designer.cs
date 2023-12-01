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
            id_pnTextBox = new TextBox();
            label1 = new Label();
            nv_idComboBox = new ComboBox();
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
            groupBox1.Controls.Add(id_pnTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nv_idComboBox);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // id_pnTextBox
            // 
            id_pnTextBox.Enabled = false;
            id_pnTextBox.Location = new Point(212, 104);
            id_pnTextBox.Name = "id_pnTextBox";
            id_pnTextBox.ReadOnly = true;
            id_pnTextBox.Size = new Size(119, 31);
            id_pnTextBox.TabIndex = 6;
            id_pnTextBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 110);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 5;
            label1.Text = "Mã phiếu nhập :";
            // 
            // nv_idComboBox
            // 
            nv_idComboBox.FormattingEnabled = true;
            nv_idComboBox.Location = new Point(212, 65);
            nv_idComboBox.Name = "nv_idComboBox";
            nv_idComboBox.Size = new Size(333, 33);
            nv_idComboBox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(212, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 31);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 73);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 2;
            label3.Text = "Mã nhân viên   :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 27);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Thời gian nhập :";
            // 
            // panel1
            // 
            panel1.Controls.Add(CancelAddBtn);
            panel1.Controls.Add(confirmAddBtn);
            panel1.Controls.Add(ct_soLuongTextBox);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 454);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 50);
            panel1.TabIndex = 2;
            // 
            // CancelAddBtn
            // 
            CancelAddBtn.Image = (Image)resources.GetObject("CancelAddBtn.Image");
            CancelAddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelAddBtn.Location = new Point(106, 0);
            CancelAddBtn.Name = "CancelAddBtn";
            CancelAddBtn.Size = new Size(100, 50);
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
            confirmAddBtn.Name = "confirmAddBtn";
            confirmAddBtn.Size = new Size(100, 50);
            confirmAddBtn.TabIndex = 0;
            confirmAddBtn.Text = "   Thêm";
            confirmAddBtn.UseVisualStyleBackColor = true;
            confirmAddBtn.Click += confirmAddBtn_Click;
            confirmAddBtn.KeyPress += confirmAddBtn_KeyPress;
            // 
            // ct_soLuongTextBox
            // 
            ct_soLuongTextBox.Enabled = false;
            ct_soLuongTextBox.Location = new Point(384, 7);
            ct_soLuongTextBox.Name = "ct_soLuongTextBox";
            ct_soLuongTextBox.ReadOnly = true;
            ct_soLuongTextBox.Size = new Size(167, 31);
            ct_soLuongTextBox.TabIndex = 3;
            ct_soLuongTextBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 13);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 2;
            label4.Text = "Số lượng (chi tiết ) :";
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(337, 10);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(214, 31);
            totalTextBox.TabIndex = 8;
            totalTextBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 13);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 7;
            label7.Text = "Tổng chi phí :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 507);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 3;
            label8.Text = "@quanlibanpiano";
            // 
            // panel2
            // 
            panel2.Controls.Add(chiTietPhieuNhapGridView);
            panel2.Location = new Point(12, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 227);
            panel2.TabIndex = 4;
            // 
            // chiTietPhieuNhapGridView
            // 
            chiTietPhieuNhapGridView.BackgroundColor = Color.White;
            chiTietPhieuNhapGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chiTietPhieuNhapGridView.Dock = DockStyle.Fill;
            chiTietPhieuNhapGridView.GridColor = Color.White;
            chiTietPhieuNhapGridView.Location = new Point(0, 0);
            chiTietPhieuNhapGridView.Name = "chiTietPhieuNhapGridView";
            chiTietPhieuNhapGridView.RowHeadersWidth = 62;
            chiTietPhieuNhapGridView.RowTemplate.Height = 33;
            chiTietPhieuNhapGridView.Size = new Size(551, 227);
            chiTietPhieuNhapGridView.TabIndex = 0;
            chiTietPhieuNhapGridView.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(ct_addBtn);
            panel3.Controls.Add(totalTextBox);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(12, 398);
            panel3.Name = "panel3";
            panel3.Size = new Size(554, 50);
            panel3.TabIndex = 1;
            // 
            // ct_addBtn
            // 
            ct_addBtn.Image = (Image)resources.GetObject("ct_addBtn.Image");
            ct_addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ct_addBtn.Location = new Point(0, 0);
            ct_addBtn.Name = "ct_addBtn";
            ct_addBtn.Size = new Size(206, 50);
            ct_addBtn.TabIndex = 1;
            ct_addBtn.Text = "       Thêm chi tiết ";
            ct_addBtn.TextAlign = ContentAlignment.MiddleLeft;
            ct_addBtn.UseVisualStyleBackColor = true;
            ct_addBtn.Click += ct_addBtn_Click;
            ct_addBtn.KeyPress += ct_addBtn_KeyPress;
            // 
            // frmThemPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 544);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "frmThemPhieuNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ThemPhieuNhap";
            Load += ThemPhieuNhap_Load;
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
        private ComboBox nv_idComboBox;
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
    }
}