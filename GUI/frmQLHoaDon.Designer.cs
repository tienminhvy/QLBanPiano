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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHoaDon));
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            leftPanel = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            searchBtn = new Button();
            txtTieuChi = new TextBox();
            panel6 = new Panel();
            label10 = new Label();
            cbbTieuChi = new ComboBox();
            panel4 = new Panel();
            totalTextBoxPanel = new Panel();
            hoaDonCountTxtBox = new TextBox();
            resetBtn = new Button();
            label6 = new Label();
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
            gridViewPanel = new Panel();
            hoaDonGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            leftPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            totalTextBoxPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            gridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 96);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(152, 25);
            label9.TabIndex = 4;
            label9.Text = "@quanlibanpiano";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
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
            // panel2
            // 
            panel2.Controls.Add(leftPanel);
            panel2.Controls.Add(rightPanel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 96);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1087, 201);
            panel2.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.None;
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel4);
            leftPanel.Location = new Point(640, 0);
            leftPanel.Margin = new Padding(4);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(447, 201);
            leftPanel.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(447, 108);
            panel5.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchBtn);
            panel7.Controls.Add(txtTieuChi);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 50);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(447, 50);
            panel7.TabIndex = 12;
            // 
            // searchBtn
            // 
            searchBtn.Dock = DockStyle.Right;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(378, 0);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(69, 50);
            searchBtn.TabIndex = 8;
            searchBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // txtTieuChi
            // 
            txtTieuChi.Location = new Point(15, 9);
            txtTieuChi.Margin = new Padding(2);
            txtTieuChi.Name = "txtTieuChi";
            txtTieuChi.Size = new Size(359, 31);
            txtTieuChi.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(label10);
            panel6.Controls.Add(cbbTieuChi);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(447, 50);
            panel6.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 10);
            label10.Name = "label10";
            label10.Size = new Size(80, 25);
            label10.TabIndex = 1;
            label10.Text = "Tiêu chí :";
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Location = new Point(101, 7);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(273, 33);
            cbbTieuChi.TabIndex = 0;
            cbbTieuChi.SelectedIndexChanged += cbbTieuChi_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(totalTextBoxPanel);
            panel4.Controls.Add(resetBtn);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 132);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(447, 69);
            panel4.TabIndex = 9;
            // 
            // totalTextBoxPanel
            // 
            totalTextBoxPanel.Controls.Add(hoaDonCountTxtBox);
            totalTextBoxPanel.Location = new Point(165, 0);
            totalTextBoxPanel.Margin = new Padding(4);
            totalTextBoxPanel.Name = "totalTextBoxPanel";
            totalTextBoxPanel.Size = new Size(170, 69);
            totalTextBoxPanel.TabIndex = 1;
            // 
            // hoaDonCountTxtBox
            // 
            hoaDonCountTxtBox.Anchor = AnchorStyles.None;
            hoaDonCountTxtBox.Enabled = false;
            hoaDonCountTxtBox.Location = new Point(5, 20);
            hoaDonCountTxtBox.Margin = new Padding(4);
            hoaDonCountTxtBox.Name = "hoaDonCountTxtBox";
            hoaDonCountTxtBox.ReadOnly = true;
            hoaDonCountTxtBox.Size = new Size(162, 31);
            hoaDonCountTxtBox.TabIndex = 10;
            // 
            // resetBtn
            // 
            resetBtn.Image = (Image)resources.GetObject("resetBtn.Image");
            resetBtn.ImageAlign = ContentAlignment.MiddleLeft;
            resetBtn.Location = new Point(337, 13);
            resetBtn.Margin = new Padding(4);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(110, 50);
            resetBtn.TabIndex = 16;
            resetBtn.Text = "    Làm mới";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 9;
            label6.Text = "Tổng số hóa đơn :";
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.None;
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
            rightPanel.Size = new Size(631, 201);
            rightPanel.TabIndex = 5;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(172, 109);
            nv_nameTextBox.Margin = new Padding(4);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(224, 31);
            nv_nameTextBox.TabIndex = 11;
            // 
            // kh_nameTextBox
            // 
            kh_nameTextBox.Enabled = false;
            kh_nameTextBox.Location = new Point(172, 59);
            kh_nameTextBox.Margin = new Padding(4);
            kh_nameTextBox.Name = "kh_nameTextBox";
            kh_nameTextBox.ReadOnly = true;
            kh_nameTextBox.Size = new Size(224, 31);
            kh_nameTextBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 109);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 9;
            label8.Text = "Tên nhân viên :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 65);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 25);
            label7.TabIndex = 8;
            label7.Text = "Tên khách hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 155);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 3;
            label5.Text = "Ngày mua hàng :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(172, 155);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(365, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // idTextbox
            // 
            idTextbox.Enabled = false;
            idTextbox.Location = new Point(172, 9);
            idTextbox.Margin = new Padding(4);
            idTextbox.Name = "idTextbox";
            idTextbox.ReadOnly = true;
            idTextbox.Size = new Size(224, 31);
            idTextbox.TabIndex = 4;
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(562, 109);
            nv_idTextBox.Margin = new Padding(4);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(53, 31);
            nv_idTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // kh_idTextBox
            // 
            kh_idTextBox.Enabled = false;
            kh_idTextBox.Location = new Point(562, 62);
            kh_idTextBox.Margin = new Padding(4);
            kh_idTextBox.Name = "kh_idTextBox";
            kh_idTextBox.ReadOnly = true;
            kh_idTextBox.Size = new Size(53, 31);
            kh_idTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng :";
            // 
            // gridViewPanel
            // 
            gridViewPanel.Controls.Add(hoaDonGridView);
            gridViewPanel.Dock = DockStyle.Fill;
            gridViewPanel.Location = new Point(0, 297);
            gridViewPanel.Margin = new Padding(4);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(1087, 287);
            gridViewPanel.TabIndex = 2;
            // 
            // hoaDonGridView
            // 
            hoaDonGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonGridView.Dock = DockStyle.Fill;
            hoaDonGridView.Location = new Point(0, 0);
            hoaDonGridView.Margin = new Padding(2);
            hoaDonGridView.Name = "hoaDonGridView";
            hoaDonGridView.RowHeadersWidth = 62;
            hoaDonGridView.RowTemplate.Height = 33;
            hoaDonGridView.Size = new Size(1087, 287);
            hoaDonGridView.TabIndex = 0;
            hoaDonGridView.CellClick += hoaDonGridView_CellClick;
            hoaDonGridView.CellDoubleClick += hoaDonGridView_CellDoubleClick;
            // 
            // frmQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 584);
            Controls.Add(gridViewPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLHoaDon";
            Text = "QLHD";
            Load += QLHD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            totalTextBoxPanel.ResumeLayout(false);
            totalTextBoxPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            gridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox kh_idTextBox;
        private TextBox idTextbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel gridViewPanel;
        private DataGridView hoaDonGridView;
        private DateTimePicker dateTimePicker1;
        private TextBox nv_idTextBox;
        private Panel panel5;
        private Panel panel6;
        private Button resetBtn;
        private Panel panel7;
        private Button searchBtn;
        private TextBox txtTieuChi;
        private TextBox hoaDonCountTxtBox;
        private Label label6;
        private Panel panel4;
        private Panel leftPanel;
        private Panel totalTextBoxPanel;
        private Panel rightPanel;
        private TextBox nv_nameTextBox;
        private TextBox kh_nameTextBox;
        private Label label8;
        private Label label7;
        private Label label9;
        private ComboBox cbbTieuChi;
        private Label label10;
    }
}