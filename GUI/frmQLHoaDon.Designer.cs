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
            label9 = new Label();
            label1 = new Label();
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
            hoaDonGridView = new DataGridView();
            gridViewPanel = new Panel();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            totalTextBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).BeginInit();
            gridViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
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
            label1.Location = new Point(396, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Hóa Đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            rightPanel.Location = new Point(29, 66);
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
            nv_nameTextBox.Size = new Size(180, 27);
            nv_nameTextBox.TabIndex = 11;
            // 
            // kh_nameTextBox
            // 
            kh_nameTextBox.Enabled = false;
            kh_nameTextBox.Location = new Point(166, 46);
            kh_nameTextBox.Name = "kh_nameTextBox";
            kh_nameTextBox.ReadOnly = true;
            kh_nameTextBox.Size = new Size(180, 27);
            kh_nameTextBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 87);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 9;
            label8.Text = "Tên nhân viên :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 52);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 8;
            label7.Text = "Tên khách hàng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 124);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 3;
            label5.Text = "Ngày mua hàng :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(166, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 90);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // idTextbox
            // 
            idTextbox.Enabled = false;
            idTextbox.Location = new Point(166, 6);
            idTextbox.Name = "idTextbox";
            idTextbox.ReadOnly = true;
            idTextbox.Size = new Size(180, 27);
            idTextbox.TabIndex = 4;
            // 
            // nv_idTextBox
            // 
            nv_idTextBox.Enabled = false;
            nv_idTextBox.Location = new Point(507, 87);
            nv_idTextBox.Name = "nv_idTextBox";
            nv_idTextBox.ReadOnly = true;
            nv_idTextBox.Size = new Size(43, 27);
            nv_idTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 12);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // kh_idTextBox
            // 
            kh_idTextBox.Enabled = false;
            kh_idTextBox.Location = new Point(507, 46);
            kh_idTextBox.Name = "kh_idTextBox";
            kh_idTextBox.ReadOnly = true;
            kh_idTextBox.Size = new Size(43, 27);
            kh_idTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 52);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng :";
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top;
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel4);
            leftPanel.Location = new Point(594, 66);
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
            panel5.Size = new Size(460, 86);
            panel5.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchBtn);
            panel7.Controls.Add(textBox5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 40);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(460, 40);
            panel7.TabIndex = 12;
            // 
            // searchBtn
            // 
            searchBtn.Dock = DockStyle.Right;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(405, 0);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(55, 40);
            searchBtn.TabIndex = 8;
            searchBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 7);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(294, 27);
            textBox5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(460, 40);
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
            hoaDonCountTxtBox.Size = new Size(143, 27);
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
            label6.Size = new Size(128, 20);
            label6.TabIndex = 9;
            label6.Text = "Tổng số hóa đơn :";
            // 
            // hoaDonGridView
            // 
            hoaDonGridView.AllowUserToAddRows = false;
            hoaDonGridView.AllowUserToDeleteRows = false;
            hoaDonGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hoaDonGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonGridView.Location = new Point(2, 295);
            hoaDonGridView.Margin = new Padding(2);
            hoaDonGridView.Name = "hoaDonGridView";
            hoaDonGridView.ReadOnly = true;
            hoaDonGridView.RowHeadersWidth = 62;
            hoaDonGridView.RowTemplate.Height = 33;
            hoaDonGridView.Size = new Size(1065, 335);
            hoaDonGridView.TabIndex = 0;
            hoaDonGridView.CellClick += hoaDonGridView_CellClick;
            hoaDonGridView.CellDoubleClick += hoaDonGridView_CellDoubleClick;
            // 
            // gridViewPanel
            // 
            gridViewPanel.Controls.Add(label9);
            gridViewPanel.Controls.Add(leftPanel);
            gridViewPanel.Controls.Add(label1);
            gridViewPanel.Controls.Add(rightPanel);
            gridViewPanel.Controls.Add(hoaDonGridView);
            gridViewPanel.Dock = DockStyle.Fill;
            gridViewPanel.Location = new Point(0, 0);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(1069, 632);
            gridViewPanel.TabIndex = 2;
            // 
            // frmQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 632);
            Controls.Add(gridViewPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLHoaDon";
            Text = "QLHD";
            Load += QLHD_Load;
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
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).EndInit();
            gridViewPanel.ResumeLayout(false);
            gridViewPanel.PerformLayout();
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
        private Panel gridViewPanel;
    }
}