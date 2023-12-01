namespace QLBanPiano.GUI
{
    partial class frmQLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHoaDon));
            CalendarLabel = new Label();
            label9 = new Label();
            label1 = new Label();
            leftPanel = new Panel();
            panel7 = new Panel();
            ClockLabel = new Label();
            ExportBtn = new Button();
            ImportBtn = new Button();
            panel5 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            hoaDonCountTxtBox = new TextBox();
            resetBtn = new Button();
            panel4 = new Panel();
            searchBtn = new Button();
            txtTieuChi = new TextBox();
            panel3 = new Panel();
            cbbTieuChi = new ComboBox();
            label10 = new Label();
            rightPanel = new Panel();
            nv_nameTextBox = new TextBox();
            kh_nameTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            idTextbox = new TextBox();
            nv_idTextBox = new TextBox();
            label2 = new Label();
            kh_idTextBox = new TextBox();
            label3 = new Label();
            hoaDonGridView = new DataGridView();
            Clock = new System.Windows.Forms.Timer(components);
            leftPanel.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).BeginInit();
            SuspendLayout();
            // 
            // CalendarLabel
            // 
            CalendarLabel.AutoSize = true;
            CalendarLabel.Location = new Point(3, 46);
            CalendarLabel.Name = "CalendarLabel";
            CalendarLabel.Size = new Size(81, 25);
            CalendarLabel.TabIndex = 5;
            CalendarLabel.Text = "Calendar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 4;
            label9.Text = "@quanlibanpiano";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(401, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Hóa Đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.None;
            leftPanel.Controls.Add(panel7);
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel4);
            leftPanel.Controls.Add(panel3);
            leftPanel.Location = new Point(640, 0);
            leftPanel.Margin = new Padding(4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(447, 203);
            leftPanel.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(ClockLabel);
            panel7.Controls.Add(ExportBtn);
            panel7.Controls.Add(ImportBtn);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 96);
            panel7.Name = "panel7";
            panel7.Size = new Size(447, 48);
            panel7.TabIndex = 12;
            // 
            // ClockLabel
            // 
            ClockLabel.AutoSize = true;
            ClockLabel.Location = new Point(3, 12);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(55, 25);
            ClockLabel.TabIndex = 2;
            ClockLabel.Text = "Clock";
            // 
            // ExportBtn
            // 
            ExportBtn.Image = (Image)resources.GetObject("ExportBtn.Image");
            ExportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ExportBtn.Location = new Point(333, 0);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(114, 48);
            ExportBtn.TabIndex = 7;
            ExportBtn.Text = "   Xuất file";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            ExportBtn.KeyPress += ExportBtn_KeyPress;
            // 
            // ImportBtn
            // 
            ImportBtn.Image = (Image)resources.GetObject("ImportBtn.Image");
            ImportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ImportBtn.Location = new Point(213, 0);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(114, 48);
            ImportBtn.TabIndex = 6;
            ImportBtn.Text = "   Nhập file";
            ImportBtn.UseVisualStyleBackColor = true;
            ImportBtn.Click += ImportBtn_Click;
            ImportBtn.KeyPress += ImportBtn_KeyPress;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(resetBtn);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 155);
            panel5.Name = "panel5";
            panel5.Size = new Size(447, 48);
            panel5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 11);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 9;
            label6.Text = "Tổng số hóa đơn :";
            // 
            // panel6
            // 
            panel6.Controls.Add(hoaDonCountTxtBox);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(163, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(170, 48);
            panel6.TabIndex = 11;
            // 
            // hoaDonCountTxtBox
            // 
            hoaDonCountTxtBox.Anchor = AnchorStyles.None;
            hoaDonCountTxtBox.Enabled = false;
            hoaDonCountTxtBox.Location = new Point(4, 9);
            hoaDonCountTxtBox.Margin = new Padding(4);
            hoaDonCountTxtBox.Name = "hoaDonCountTxtBox";
            hoaDonCountTxtBox.ReadOnly = true;
            hoaDonCountTxtBox.Size = new Size(162, 31);
            hoaDonCountTxtBox.TabIndex = 10;
            hoaDonCountTxtBox.TabStop = false;
            // 
            // resetBtn
            // 
            resetBtn.Dock = DockStyle.Right;
            resetBtn.Image = (Image)resources.GetObject("resetBtn.Image");
            resetBtn.ImageAlign = ContentAlignment.MiddleLeft;
            resetBtn.Location = new Point(333, 0);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(114, 48);
            resetBtn.TabIndex = 12;
            resetBtn.Text = "    Làm mới";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            resetBtn.KeyPress += resetBtn_KeyPress;
            // 
            // panel4
            // 
            panel4.Controls.Add(searchBtn);
            panel4.Controls.Add(txtTieuChi);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(447, 48);
            panel4.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Dock = DockStyle.Right;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(378, 0);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(69, 48);
            searchBtn.TabIndex = 4;
            searchBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            searchBtn.KeyPress += searchBtn_KeyPress;
            // 
            // txtTieuChi
            // 
            txtTieuChi.Location = new Point(3, 8);
            txtTieuChi.Margin = new Padding(2);
            txtTieuChi.Name = "txtTieuChi";
            txtTieuChi.Size = new Size(359, 31);
            txtTieuChi.TabIndex = 3;
            txtTieuChi.KeyPress += txtTieuChi_KeyPress;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbbTieuChi);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 48);
            panel3.TabIndex = 0;
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Location = new Point(89, 9);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(273, 33);
            cbbTieuChi.TabIndex = 1;
            cbbTieuChi.SelectedIndexChanged += cbbTieuChi_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 12);
            label10.Name = "label10";
            label10.Size = new Size(80, 25);
            label10.TabIndex = 0;
            label10.Text = "Tiêu chí :";
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top;
            rightPanel.Controls.Add(nv_nameTextBox);
            rightPanel.Controls.Add(kh_nameTextBox);
            rightPanel.Controls.Add(label8);
            rightPanel.Controls.Add(label7);
            rightPanel.Controls.Add(label5);
            rightPanel.Controls.Add(dateTimePicker1);
            rightPanel.Controls.Add(label4);
            rightPanel.Controls.Add(idTextbox);
            rightPanel.Controls.Add(nv_idTextBox);
            rightPanel.Controls.Add(label2);
            rightPanel.Controls.Add(kh_idTextBox);
            rightPanel.Controls.Add(label3);
            rightPanel.Location = new Point(0, 0);
            rightPanel.Margin = new Padding(4);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(631, 203);
            rightPanel.TabIndex = 0;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(172, 112);
            nv_nameTextBox.Margin = new Padding(4);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(224, 31);
            nv_nameTextBox.TabIndex = 11;
            nv_nameTextBox.TabStop = false;
            // 
            // kh_nameTextBox
            // 
            kh_nameTextBox.Enabled = false;
            kh_nameTextBox.Location = new Point(172, 66);
            kh_nameTextBox.Margin = new Padding(4);
            kh_nameTextBox.Name = "kh_nameTextBox";
            kh_nameTextBox.ReadOnly = true;
            kh_nameTextBox.Size = new Size(224, 31);
            kh_nameTextBox.TabIndex = 10;
            kh_nameTextBox.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 119);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 9;
            label8.Text = "Tên nhân viên :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 72);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 8;
            label7.Text = "Tên khách hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 3;
            label5.Text = "Ngày mua hàng :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(172, 162);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 31);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // idTextbox
            // 
            idTextbox.Enabled = false;
            idTextbox.Location = new Point(172, 15);
            idTextbox.Margin = new Padding(4);
            idTextbox.Name = "idTextbox";
            idTextbox.ReadOnly = true;
            idTextbox.Size = new Size(224, 31);
            idTextbox.TabIndex = 4;
            idTextbox.TabStop = false;
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(562, 112);
            nv_idTextBox.Margin = new Padding(4);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(53, 31);
            nv_idTextBox.TabIndex = 6;
            nv_idTextBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // kh_idTextBox
            // 
            kh_idTextBox.Enabled = false;
            kh_idTextBox.Location = new Point(562, 66);
            kh_idTextBox.Margin = new Padding(4);
            kh_idTextBox.Name = "kh_idTextBox";
            kh_idTextBox.ReadOnly = true;
            kh_idTextBox.Size = new Size(53, 31);
            kh_idTextBox.TabIndex = 5;
            kh_idTextBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng :";
            // 
            // hoaDonGridView
            // 
            hoaDonGridView.BackgroundColor = Color.White;
            hoaDonGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonGridView.Dock = DockStyle.Fill;
            hoaDonGridView.Location = new Point(0, 0);
            hoaDonGridView.Margin = new Padding(2);
            hoaDonGridView.Name = "hoaDonGridView";
            hoaDonGridView.ReadOnly = true;
            hoaDonGridView.RowHeadersWidth = 62;
            hoaDonGridView.RowTemplate.Height = 33;
            hoaDonGridView.Size = new Size(1087, 363);
            hoaDonGridView.TabIndex = 0;
            hoaDonGridView.TabStop = false;
            hoaDonGridView.CellClick += hoaDonGridView_CellClick;
            hoaDonGridView.CellDoubleClick += hoaDonGridView_CellDoubleClick;
            // 
            // Clock
            // 
            Clock.Interval = 1;
            Clock.Tick += Clock_Tick;
            // 
            // frmQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 662);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLHoaDon";
            Text = "QLHD";
            Load += frmQLHoaDon_Load;
            leftPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox kh_idTextBox;
        private TextBox idTextbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView hoaDonGridView;
        private DateTimePicker dateTimePicker1;
        private TextBox nv_idTextBox;
        private Button searchBtn;
        private TextBox txtTieuChi;
        private TextBox hoaDonCountTxtBox;
        private Label label6;
        private Panel leftPanel;
        private Panel rightPanel;
        private TextBox nv_nameTextBox;
        private TextBox kh_nameTextBox;
        private Label label8;
        private Label label7;
        private Label label9;
        private ComboBox cbbTieuChi;
        private Label label10;
        private System.Windows.Forms.Timer Clock;
        private Button ExportBtn;
        private Button ImportBtn;
        private Label ClockLabel;
        private Label CalendarLabel;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private Button resetBtn;
        private Panel panel6;
    }
}