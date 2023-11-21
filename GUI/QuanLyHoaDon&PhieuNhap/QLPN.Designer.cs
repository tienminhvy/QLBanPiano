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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPN));
            panel1 = new Panel();
            label1 = new Label();
            gridViewPanel = new Panel();
            phieuNhapGridView = new DataGridView();
            panel2 = new Panel();
            searchBtn = new Button();
            panel3 = new Panel();
            fixBtn = new Button();
            createBtn = new Button();
            searchBarErrorProvider = new ErrorProvider(components);
            printBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idPhieuNhapTxtBox = new TextBox();
            idNhanVienTxtBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            filterBtn = new Button();
            searchTextBox = new TextBox();
            panel1.SuspendLayout();
            gridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phieuNhapGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchBarErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 120);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(322, 31);
            label1.Name = "label1";
            label1.Size = new Size(384, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Phiếu Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridViewPanel
            // 
            gridViewPanel.Controls.Add(phieuNhapGridView);
            gridViewPanel.Dock = DockStyle.Bottom;
            gridViewPanel.Location = new Point(0, 281);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(1016, 359);
            gridViewPanel.TabIndex = 3;
            // 
            // phieuNhapGridView
            // 
            phieuNhapGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phieuNhapGridView.Dock = DockStyle.Fill;
            phieuNhapGridView.Location = new Point(0, 0);
            phieuNhapGridView.Name = "phieuNhapGridView";
            phieuNhapGridView.RowHeadersWidth = 62;
            phieuNhapGridView.RowTemplate.Height = 33;
            phieuNhapGridView.Size = new Size(1016, 359);
            phieuNhapGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(filterBtn);
            panel2.Controls.Add(searchBtn);
            panel2.Controls.Add(createBtn);
            panel2.Controls.Add(printBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(fixBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 161);
            panel2.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBtn.Location = new Point(906, 111);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(110, 50);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.TextAlign = ContentAlignment.MiddleRight;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(idNhanVienTxtBox);
            panel3.Controls.Add(idPhieuNhapTxtBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 161);
            panel3.TabIndex = 0;
            // 
            // fixBtn
            // 
            fixBtn.Location = new Point(674, 0);
            fixBtn.Name = "fixBtn";
            fixBtn.Size = new Size(110, 50);
            fixBtn.TabIndex = 1;
            fixBtn.Text = "Chỉnh sửa ";
            fixBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(558, 0);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(110, 50);
            createBtn.TabIndex = 0;
            createBtn.Text = "Tạo mới";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // searchBarErrorProvider
            // 
            searchBarErrorProvider.ContainerControl = this;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(790, 0);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(110, 50);
            printBtn.TabIndex = 16;
            printBtn.Text = "In hóa đơn";
            printBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 62);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 1;
            label3.Text = "Ngày nhập :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 108);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // idPhieuNhapTxtBox
            // 
            idPhieuNhapTxtBox.Location = new Point(149, 14);
            idPhieuNhapTxtBox.Name = "idPhieuNhapTxtBox";
            idPhieuNhapTxtBox.ReadOnly = true;
            idPhieuNhapTxtBox.Size = new Size(292, 31);
            idPhieuNhapTxtBox.TabIndex = 3;
            // 
            // idNhanVienTxtBox
            // 
            idNhanVienTxtBox.Location = new Point(148, 105);
            idNhanVienTxtBox.Name = "idNhanVienTxtBox";
            idNhanVienTxtBox.ReadOnly = true;
            idNhanVienTxtBox.Size = new Size(293, 31);
            idNhanVienTxtBox.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(148, 62);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(293, 31);
            dateTimePicker.TabIndex = 5;
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(906, 0);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(110, 50);
            filterBtn.TabIndex = 17;
            filterBtn.Text = "Lọc ";
            filterBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(558, 121);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(342, 31);
            searchTextBox.TabIndex = 18;
            // 
            // QLPN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 640);
            Controls.Add(panel2);
            Controls.Add(gridViewPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QLPN";
            Text = "QLPN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)phieuNhapGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchBarErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel gridViewPanel;
        private DataGridView phieuNhapGridView;
        private Panel panel2;
        private Panel panel3;
        private Button searchBtn;
        private Button fixBtn;
        private Button createBtn;
        private ErrorProvider searchBarErrorProvider;
        private Button printBtn;
        private DateTimePicker dateTimePicker;
        private TextBox idNhanVienTxtBox;
        private TextBox idPhieuNhapTxtBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox searchTextBox;
        private Button filterBtn;
    }
}