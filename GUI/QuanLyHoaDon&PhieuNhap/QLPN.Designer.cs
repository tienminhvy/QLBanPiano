namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
{
    partial class QLPN
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPN));
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            phieuNhapGridView = new DataGridView();
            panel3 = new Panel();
            nv_nameTextBox = new TextBox();
            label5 = new Label();
            dateTimePicker = new DateTimePicker();
            idNhanVienTextBox = new TextBox();
            idPhieuNhapTxtBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            addBtn = new Button();
            panel7 = new Panel();
            searchTextBox = new TextBox();
            searchBtn = new Button();
            panel6 = new Panel();
            label6 = new Label();
            ResetBtn = new Button();
            cbbTieuChi = new ComboBox();
            gridViewPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phieuNhapGridView).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            gridViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 120);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(152, 25);
            label9.TabIndex = 5;
            label9.Text = "@quanlibanpiano";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(322, 37);
            label1.Name = "label1";
            label1.Size = new Size(384, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Phiếu Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phieuNhapGridView
            // 
            phieuNhapGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            phieuNhapGridView.DefaultCellStyle = dataGridViewCellStyle2;
            phieuNhapGridView.Dock = DockStyle.Fill;
            phieuNhapGridView.Location = new Point(0, 0);
            phieuNhapGridView.Name = "phieuNhapGridView";
            phieuNhapGridView.RowHeadersWidth = 62;
            phieuNhapGridView.RowTemplate.Height = 33;
            phieuNhapGridView.Size = new Size(1016, 359);
            phieuNhapGridView.TabIndex = 0;
            phieuNhapGridView.CellClick += phieuNhapGridView_CellClick;
            phieuNhapGridView.CellDoubleClick += phieuNhapGridView_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(nv_nameTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(idNhanVienTextBox);
            panel3.Controls.Add(idPhieuNhapTxtBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 161);
            panel3.TabIndex = 0;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(322, 105);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(183, 31);
            nv_nameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 108);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 6;
            label5.Text = "Tên nhân viên :";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Enabled = false;
            dateTimePicker.Location = new Point(136, 62);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(369, 31);
            dateTimePicker.TabIndex = 5;
            // 
            // idNhanVienTextBox
            // 
            idNhanVienTextBox.Enabled = false;
            idNhanVienTextBox.Location = new Point(136, 105);
            idNhanVienTextBox.Name = "idNhanVienTextBox";
            idNhanVienTextBox.ReadOnly = true;
            idNhanVienTextBox.Size = new Size(46, 31);
            idNhanVienTextBox.TabIndex = 4;
            // 
            // idPhieuNhapTxtBox
            // 
            idPhieuNhapTxtBox.Enabled = false;
            idPhieuNhapTxtBox.Location = new Point(136, 20);
            idPhieuNhapTxtBox.Name = "idPhieuNhapTxtBox";
            idPhieuNhapTxtBox.ReadOnly = true;
            idPhieuNhapTxtBox.Size = new Size(292, 31);
            idPhieuNhapTxtBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 67);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 1;
            label3.Text = "Ngày nhập :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu nhập :";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 161);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(508, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(508, 161);
            panel4.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Controls.Add(addBtn);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(508, 61);
            panel5.TabIndex = 12;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(398, 5);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(110, 51);
            addBtn.TabIndex = 0;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchTextBox);
            panel7.Controls.Add(searchBtn);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(508, 50);
            panel7.TabIndex = 11;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.None;
            searchTextBox.Location = new Point(6, 10);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(386, 31);
            searchTextBox.TabIndex = 18;
            // 
            // searchBtn
            // 
            searchBtn.Dock = DockStyle.Right;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBtn.Location = new Point(398, 0);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(110, 50);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.TextAlign = ContentAlignment.MiddleRight;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Controls.Add(ResetBtn);
            panel6.Controls.Add(cbbTieuChi);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(508, 50);
            panel6.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 14);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 12;
            label6.Text = "Tiêu chí :";
            // 
            // ResetBtn
            // 
            ResetBtn.Dock = DockStyle.Right;
            ResetBtn.Image = (Image)resources.GetObject("ResetBtn.Image");
            ResetBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ResetBtn.Location = new Point(398, 0);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(110, 50);
            ResetBtn.TabIndex = 11;
            ResetBtn.Text = "Làm mới";
            ResetBtn.TextAlign = ContentAlignment.MiddleRight;
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Location = new Point(92, 6);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(300, 33);
            cbbTieuChi.TabIndex = 10;
            cbbTieuChi.SelectedIndexChanged += cbbTieuChi_SelectedIndexChanged;
            // 
            // gridViewPanel
            // 
            gridViewPanel.Controls.Add(phieuNhapGridView);
            gridViewPanel.Dock = DockStyle.Fill;
            gridViewPanel.Location = new Point(0, 281);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(1016, 359);
            gridViewPanel.TabIndex = 5;
            // 
            // QLPN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 640);
            Controls.Add(gridViewPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QLPN";
            Text = "QLPN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phieuNhapGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            gridViewPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView phieuNhapGridView;
        private Label label9;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dateTimePicker;
        private TextBox idNhanVienTextBox;
        private TextBox idPhieuNhapTxtBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox nv_nameTextBox;
        private Label label5;
        private Panel gridViewPanel;
        private Panel panel4;
        private Panel panel6;
        private Label label6;
        private Button ResetBtn;
        private ComboBox cbbTieuChi;
        private Panel panel7;
        private TextBox searchTextBox;
        private Button searchBtn;
        private Panel panel5;
        private Button addBtn;
    }
}