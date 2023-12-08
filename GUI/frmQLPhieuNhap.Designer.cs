namespace QLBanPiano.GUI
{
    partial class frmQLPhieuNhap
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLPhieuNhap));
            panel1 = new Panel();
            CalendarLabel = new Label();
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
            leftPanel = new Panel();
            panel5 = new Panel();
            ClockLabel = new Label();
            importFileBtn = new Button();
            exportFileBtn = new Button();
            addBtn = new Button();
            panel7 = new Panel();
            searchTextBox = new TextBox();
            searchBtn = new Button();
            panel6 = new Panel();
            label6 = new Label();
            ResetBtn = new Button();
            cbbTieuChi = new ComboBox();
            gridViewPanel = new Panel();
            Timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phieuNhapGridView).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            leftPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            gridViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CalendarLabel);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 77);
            panel1.TabIndex = 1;
            // 
            // CalendarLabel
            // 
            CalendarLabel.AutoSize = true;
            CalendarLabel.Location = new Point(2, 38);
            CalendarLabel.Margin = new Padding(2, 0, 2, 0);
            CalendarLabel.Name = "CalendarLabel";
            CalendarLabel.Size = new Size(68, 20);
            CalendarLabel.TabIndex = 6;
            CalendarLabel.Text = "Calendar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 5;
            label9.Text = "@quanlibanpiano";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(271, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Phiếu Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phieuNhapGridView
            // 
            phieuNhapGridView.AllowUserToAddRows = false;
            phieuNhapGridView.AllowUserToDeleteRows = false;
            phieuNhapGridView.BackgroundColor = SystemColors.Control;
            phieuNhapGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            phieuNhapGridView.DefaultCellStyle = dataGridViewCellStyle1;
            phieuNhapGridView.Dock = DockStyle.Fill;
            phieuNhapGridView.Location = new Point(0, 0);
            phieuNhapGridView.Margin = new Padding(2);
            phieuNhapGridView.Name = "phieuNhapGridView";
            phieuNhapGridView.ReadOnly = true;
            phieuNhapGridView.RowHeadersWidth = 62;
            phieuNhapGridView.RowTemplate.Height = 33;
            phieuNhapGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            phieuNhapGridView.Size = new Size(835, 170);
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
            panel3.Location = new Point(0, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 131);
            panel3.TabIndex = 0;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(258, 84);
            nv_nameTextBox.Margin = new Padding(2);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(147, 27);
            nv_nameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 6;
            label5.Text = "Tên nhân viên :";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Enabled = false;
            dateTimePicker.Location = new Point(109, 50);
            dateTimePicker.Margin = new Padding(2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(296, 27);
            dateTimePicker.TabIndex = 5;
            // 
            // idNhanVienTextBox
            // 
            idNhanVienTextBox.Enabled = false;
            idNhanVienTextBox.Location = new Point(109, 84);
            idNhanVienTextBox.Margin = new Padding(2);
            idNhanVienTextBox.Name = "idNhanVienTextBox";
            idNhanVienTextBox.ReadOnly = true;
            idNhanVienTextBox.Size = new Size(38, 27);
            idNhanVienTextBox.TabIndex = 4;
            // 
            // idPhieuNhapTxtBox
            // 
            idPhieuNhapTxtBox.Enabled = false;
            idPhieuNhapTxtBox.Location = new Point(109, 16);
            idPhieuNhapTxtBox.Margin = new Padding(2);
            idPhieuNhapTxtBox.Name = "idPhieuNhapTxtBox";
            idPhieuNhapTxtBox.ReadOnly = true;
            idPhieuNhapTxtBox.Size = new Size(234, 27);
            idPhieuNhapTxtBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 54);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày nhập :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu nhập :";
            // 
            // panel2
            // 
            panel2.Controls.Add(leftPanel);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 77);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(835, 133);
            panel2.TabIndex = 4;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.None;
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel7);
            leftPanel.Controls.Add(panel6);
            leftPanel.Location = new Point(429, 2);
            leftPanel.Margin = new Padding(2);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(406, 129);
            leftPanel.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Controls.Add(ClockLabel);
            panel5.Controls.Add(importFileBtn);
            panel5.Controls.Add(exportFileBtn);
            panel5.Controls.Add(addBtn);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 80);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(406, 51);
            panel5.TabIndex = 2;
            // 
            // ClockLabel
            // 
            ClockLabel.AutoSize = true;
            ClockLabel.Location = new Point(-5, 15);
            ClockLabel.Margin = new Padding(2, 0, 2, 0);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(45, 20);
            ClockLabel.TabIndex = 3;
            ClockLabel.Text = "Clock";
            // 
            // importFileBtn
            // 
            importFileBtn.Image = (Image)resources.GetObject("importFileBtn.Image");
            importFileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            importFileBtn.Location = new Point(85, 5);
            importFileBtn.Margin = new Padding(2);
            importFileBtn.Name = "importFileBtn";
            importFileBtn.Size = new Size(105, 41);
            importFileBtn.TabIndex = 0;
            importFileBtn.Text = "  &Nhập file";
            importFileBtn.UseVisualStyleBackColor = true;
            importFileBtn.Click += importFileBtn_Click;
            // 
            // exportFileBtn
            // 
            exportFileBtn.Image = (Image)resources.GetObject("exportFileBtn.Image");
            exportFileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            exportFileBtn.Location = new Point(194, 5);
            exportFileBtn.Margin = new Padding(2);
            exportFileBtn.Name = "exportFileBtn";
            exportFileBtn.Size = new Size(107, 41);
            exportFileBtn.TabIndex = 1;
            exportFileBtn.Text = "  &Xuất file";
            exportFileBtn.UseVisualStyleBackColor = true;
            exportFileBtn.Click += exportFileBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBtn.Location = new Point(305, 5);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(101, 41);
            addBtn.TabIndex = 2;
            addBtn.Text = "     &Tạo mới";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchTextBox);
            panel7.Controls.Add(searchBtn);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 40);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(406, 40);
            panel7.TabIndex = 1;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.None;
            searchTextBox.Location = new Point(5, 8);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(296, 27);
            searchTextBox.TabIndex = 0;
            // 
            // searchBtn
            // 
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBtn.Location = new Point(305, 0);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(101, 40);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Tì&m kiếm";
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
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(406, 40);
            panel6.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 11);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 12;
            label6.Text = "Tiêu chí :";
            // 
            // ResetBtn
            // 
            ResetBtn.Dock = DockStyle.Right;
            ResetBtn.Image = (Image)resources.GetObject("ResetBtn.Image");
            ResetBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ResetBtn.Location = new Point(305, 0);
            ResetBtn.Margin = new Padding(2);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(101, 40);
            ResetBtn.TabIndex = 1;
            ResetBtn.Text = "&Làm mới";
            ResetBtn.TextAlign = ContentAlignment.MiddleRight;
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Location = new Point(74, 5);
            cbbTieuChi.Margin = new Padding(2);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(227, 28);
            cbbTieuChi.TabIndex = 0;
            cbbTieuChi.SelectedIndexChanged += cbbTieuChi_SelectedIndexChanged;
            // 
            // gridViewPanel
            // 
            gridViewPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewPanel.Controls.Add(phieuNhapGridView);
            gridViewPanel.Location = new Point(0, 210);
            gridViewPanel.Margin = new Padding(2);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(835, 170);
            gridViewPanel.TabIndex = 5;
            // 
            // Timer
            // 
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            // 
            // frmQLPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 512);
            Controls.Add(gridViewPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLPhieuNhap";
            Text = "QLPN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phieuNhapGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel leftPanel;
        private Panel panel6;
        private Label label6;
        private Button ResetBtn;
        private ComboBox cbbTieuChi;
        private Panel panel7;
        private TextBox searchTextBox;
        private Button searchBtn;
        private Panel panel5;
        private Button addBtn;
        private Button exportFileBtn;
        private Button importFileBtn;
        private Label CalendarLabel;
        private Label ClockLabel;
        private System.Windows.Forms.Timer Timer;
    }
}