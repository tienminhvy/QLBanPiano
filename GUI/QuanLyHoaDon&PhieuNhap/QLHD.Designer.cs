namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
{
    partial class QLHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHD));
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            panel2 = new Panel();
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
            leftPanel = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            searchBtn = new Button();
            textBox5 = new TextBox();
            panel6 = new Panel();
            panel4 = new Panel();
            totalTextBoxPanel = new Panel();
            hoaDonCountTxtBox = new TextBox();
            filterBtn = new Button();
            label6 = new Label();
            gridViewPanel = new Panel();
            hoaDonGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            totalTextBoxPanel.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 120);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
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
            label1.Location = new Point(340, 33);
            label1.Name = "label1";
            label1.Size = new Size(334, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Hóa Đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(rightPanel);
            panel2.Controls.Add(leftPanel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 161);
            panel2.TabIndex = 1;
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
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(559, 161);
            rightPanel.TabIndex = 5;
            // 
            // nv_nameTextBox
            // 
            nv_nameTextBox.Enabled = false;
            nv_nameTextBox.Location = new Point(166, 87);
            nv_nameTextBox.Name = "nv_nameTextBox";
            nv_nameTextBox.ReadOnly = true;
            nv_nameTextBox.Size = new Size(180, 31);
            nv_nameTextBox.TabIndex = 11;
            // 
            // kh_nameTextBox
            // 
            kh_nameTextBox.Enabled = false;
            kh_nameTextBox.Location = new Point(166, 46);
            kh_nameTextBox.Name = "kh_nameTextBox";
            kh_nameTextBox.ReadOnly = true;
            kh_nameTextBox.Size = new Size(180, 31);
            kh_nameTextBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 87);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 9;
            label8.Text = "Tên nhân viên :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 52);
            label7.Name = "label7";
            label7.Size = new Size(143, 25);
            label7.TabIndex = 8;
            label7.Text = "Tên khách hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 124);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 3;
            label5.Text = "Ngày mua hàng :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(166, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 90);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // idTextbox
            // 
            idTextbox.Enabled = false;
            idTextbox.Location = new Point(166, 6);
            idTextbox.Name = "idTextbox";
            idTextbox.ReadOnly = true;
            idTextbox.Size = new Size(180, 31);
            idTextbox.TabIndex = 4;
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(507, 87);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(43, 31);
            nv_idTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 12);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // kh_idTextBox
            // 
            kh_idTextBox.Enabled = false;
            kh_idTextBox.Location = new Point(507, 46);
            kh_idTextBox.Name = "kh_idTextBox";
            kh_idTextBox.ReadOnly = true;
            kh_idTextBox.Size = new Size(43, 31);
            kh_idTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 52);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng :";
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.None;
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel4);
            leftPanel.Location = new Point(556, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(460, 161);
            leftPanel.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(460, 108);
            panel5.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchBtn);
            panel7.Controls.Add(textBox5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(460, 50);
            panel7.TabIndex = 12;
            // 
            // searchBtn
            // 
            searchBtn.Dock = DockStyle.Right;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(391, 0);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(69, 50);
            searchBtn.TabIndex = 8;
            searchBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 9);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(367, 31);
            textBox5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(460, 50);
            panel6.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(totalTextBoxPanel);
            panel4.Controls.Add(filterBtn);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 55);
            panel4.TabIndex = 9;
            // 
            // totalTextBoxPanel
            // 
            totalTextBoxPanel.Controls.Add(hoaDonCountTxtBox);
            totalTextBoxPanel.Dock = DockStyle.Right;
            totalTextBoxPanel.Location = new Point(176, 0);
            totalTextBoxPanel.Name = "totalTextBoxPanel";
            totalTextBoxPanel.Size = new Size(215, 55);
            totalTextBoxPanel.TabIndex = 1;
            // 
            // hoaDonCountTxtBox
            // 
            hoaDonCountTxtBox.Anchor = AnchorStyles.None;
            hoaDonCountTxtBox.Enabled = false;
            hoaDonCountTxtBox.Location = new Point(3, 15);
            hoaDonCountTxtBox.Name = "hoaDonCountTxtBox";
            hoaDonCountTxtBox.ReadOnly = true;
            hoaDonCountTxtBox.Size = new Size(143, 31);
            hoaDonCountTxtBox.TabIndex = 10;
            // 
            // filterBtn
            // 
            filterBtn.Dock = DockStyle.Right;
            filterBtn.Location = new Point(391, 0);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(69, 55);
            filterBtn.TabIndex = 16;
            filterBtn.Text = "Lọc";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += filterBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 18);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 9;
            label6.Text = "Tổng số hóa đơn :";
            // 
            // gridViewPanel
            // 
            gridViewPanel.Controls.Add(hoaDonGridView);
            gridViewPanel.Dock = DockStyle.Fill;
            gridViewPanel.Location = new Point(0, 281);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(1016, 351);
            gridViewPanel.TabIndex = 2;
            // 
            // hoaDonGridView
            // 
            hoaDonGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hoaDonGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonGridView.Location = new Point(0, 0);
            hoaDonGridView.Name = "hoaDonGridView";
            hoaDonGridView.RowHeadersWidth = 62;
            hoaDonGridView.RowTemplate.Height = 33;
            hoaDonGridView.Size = new Size(1016, 351);
            hoaDonGridView.TabIndex = 0;
            hoaDonGridView.CellClick += hoaDonGridView_CellClick;
            hoaDonGridView.CellDoubleClick += hoaDonGridView_CellDoubleClick;
            // 
            // QLHD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 632);
            Controls.Add(gridViewPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QLHD";
            Text = "QLHD";
            Load += QLHD_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            totalTextBoxPanel.ResumeLayout(false);
            totalTextBoxPanel.PerformLayout();
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
        private Button filterBtn;
        private Panel panel7;
        private Button searchBtn;
        private TextBox textBox5;
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
    }
}