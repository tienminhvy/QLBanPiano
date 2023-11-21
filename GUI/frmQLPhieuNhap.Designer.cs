namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLPhieuNhap));
            panel1 = new Panel();
            label1 = new Label();
            gridViewPanel = new Panel();
            phieuNhapGridView = new DataGridView();
            panel2 = new Panel();
            searchTextBox = new TextBox();
            filterBtn = new Button();
            searchBtn = new Button();
            createBtn = new Button();
            printBtn = new Button();
            panel3 = new Panel();
            dateTimePicker = new DateTimePicker();
            idNhanVienTxtBox = new TextBox();
            idPhieuNhapTxtBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            fixBtn = new Button();
            searchBarErrorProvider = new ErrorProvider(components);
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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 96);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(240, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Phiếu Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gridViewPanel
            // 
            gridViewPanel.Controls.Add(phieuNhapGridView);
            gridViewPanel.Dock = DockStyle.Bottom;
            gridViewPanel.Location = new Point(0, 225);
            gridViewPanel.Margin = new Padding(2, 2, 2, 2);
            gridViewPanel.Name = "gridViewPanel";
            gridViewPanel.Size = new Size(813, 287);
            gridViewPanel.TabIndex = 3;
            // 
            // phieuNhapGridView
            // 
            phieuNhapGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phieuNhapGridView.Dock = DockStyle.Fill;
            phieuNhapGridView.Location = new Point(0, 0);
            phieuNhapGridView.Margin = new Padding(2, 2, 2, 2);
            phieuNhapGridView.Name = "phieuNhapGridView";
            phieuNhapGridView.RowHeadersWidth = 62;
            phieuNhapGridView.RowTemplate.Height = 33;
            phieuNhapGridView.Size = new Size(813, 287);
            phieuNhapGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(filterBtn);
            panel2.Controls.Add(searchBtn);
            panel2.Controls.Add(createBtn);
            panel2.Controls.Add(printBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(fixBtn);
            panel2.Location = new Point(0, 96);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(813, 129);
            panel2.TabIndex = 4;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(446, 97);
            searchTextBox.Margin = new Padding(2, 2, 2, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(274, 27);
            searchTextBox.TabIndex = 18;
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(725, 0);
            filterBtn.Margin = new Padding(2, 2, 2, 2);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(88, 40);
            filterBtn.TabIndex = 17;
            filterBtn.Text = "Lọc ";
            filterBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBtn.Location = new Point(725, 89);
            searchBtn.Margin = new Padding(2, 2, 2, 2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(88, 40);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.TextAlign = ContentAlignment.MiddleRight;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(446, 0);
            createBtn.Margin = new Padding(2, 2, 2, 2);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(88, 40);
            createBtn.TabIndex = 0;
            createBtn.Text = "Tạo mới";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(632, 0);
            printBtn.Margin = new Padding(2, 2, 2, 2);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(88, 40);
            printBtn.TabIndex = 16;
            printBtn.Text = "In hóa đơn";
            printBtn.UseVisualStyleBackColor = true;
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
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 129);
            panel3.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(118, 50);
            dateTimePicker.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(235, 27);
            dateTimePicker.TabIndex = 5;
            // 
            // idNhanVienTxtBox
            // 
            idNhanVienTxtBox.Location = new Point(118, 84);
            idNhanVienTxtBox.Margin = new Padding(2, 2, 2, 2);
            idNhanVienTxtBox.Name = "idNhanVienTxtBox";
            idNhanVienTxtBox.ReadOnly = true;
            idNhanVienTxtBox.Size = new Size(235, 27);
            idNhanVienTxtBox.TabIndex = 4;
            // 
            // idPhieuNhapTxtBox
            // 
            idPhieuNhapTxtBox.Location = new Point(119, 11);
            idPhieuNhapTxtBox.Margin = new Padding(2, 2, 2, 2);
            idPhieuNhapTxtBox.Name = "idPhieuNhapTxtBox";
            idPhieuNhapTxtBox.ReadOnly = true;
            idPhieuNhapTxtBox.Size = new Size(234, 27);
            idPhieuNhapTxtBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày nhập :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu nhập :";
            // 
            // fixBtn
            // 
            fixBtn.Location = new Point(539, 0);
            fixBtn.Margin = new Padding(2, 2, 2, 2);
            fixBtn.Name = "fixBtn";
            fixBtn.Size = new Size(88, 40);
            fixBtn.TabIndex = 1;
            fixBtn.Text = "Chỉnh sửa ";
            fixBtn.UseVisualStyleBackColor = true;
            // 
            // searchBarErrorProvider
            // 
            searchBarErrorProvider.ContainerControl = this;
            // 
            // frmQLPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 512);
            Controls.Add(panel2);
            Controls.Add(gridViewPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmQLPhieuNhap";
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