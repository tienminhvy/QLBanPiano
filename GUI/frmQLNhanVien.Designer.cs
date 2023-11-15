namespace QLBanPiano.GUI.SubForm
{
    partial class frmQLNhanVien
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
            btn_reset = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            txt_address = new TextBox();
            label_address = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label_phoneNum = new Label();
            label_input = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label_date = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            txt_midName = new TextBox();
            label_midName = new Label();
            txt_id = new TextBox();
            label_id = new Label();
            btnSearch = new Button();
            cbbTypeSearch = new ComboBox();
            label_type = new Label();
            txtSearch = new TextBox();
            groupBoxInfor = new GroupBox();
            groupBoxSearch = new GroupBox();
            label_title = new Label();
            panel1 = new Panel();
            dgvNhanVien = new DataGridView();
            groupBoxInfor.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(440, 218);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(160, 35);
            btn_reset.TabIndex = 15;
            btn_reset.Text = "Liên kết tài khoản";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(297, 218);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(114, 35);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Xoá";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(161, 218);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(114, 35);
            btn_update.TabIndex = 13;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(13, 218);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(114, 35);
            btn_add.TabIndex = 12;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(399, 162);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(181, 30);
            txt_address.TabIndex = 11;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(273, 165);
            label_address.Name = "label_address";
            label_address.Size = new Size(58, 20);
            label_address.TabIndex = 10;
            label_address.Text = "Địa chỉ:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(399, 92);
            maskedTextBox2.Mask = "000-000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(202, 27);
            maskedTextBox2.TabIndex = 9;
            // 
            // label_phoneNum
            // 
            label_phoneNum.AutoSize = true;
            label_phoneNum.Location = new Point(273, 99);
            label_phoneNum.Name = "label_phoneNum";
            label_phoneNum.Size = new Size(100, 20);
            label_phoneNum.TabIndex = 8;
            label_phoneNum.Text = "Số điện thoại:";
            // 
            // label_input
            // 
            label_input.AutoSize = true;
            label_input.Location = new Point(6, 88);
            label_input.Name = "label_input";
            label_input.Size = new Size(98, 20);
            label_input.TabIndex = 0;
            label_input.Text = "Nhập dữ liệu:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(398, 33);
            maskedTextBox1.Mask = "00/00/0000 90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(202, 27);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(273, 36);
            label_date.Name = "label_date";
            label_date.Size = new Size(104, 20);
            label_date.TabIndex = 6;
            label_date.Text = "Ngày vào làm:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(73, 162);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 165);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên:";
            // 
            // txt_midName
            // 
            txt_midName.Location = new Point(73, 96);
            txt_midName.Name = "txt_midName";
            txt_midName.Size = new Size(181, 27);
            txt_midName.TabIndex = 3;
            // 
            // label_midName
            // 
            label_midName.AutoSize = true;
            label_midName.Location = new Point(6, 99);
            label_midName.Name = "label_midName";
            label_midName.Size = new Size(54, 20);
            label_midName.TabIndex = 2;
            label_midName.Text = "Họ lót:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(73, 33);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(125, 27);
            txt_id.TabIndex = 1;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(16, 36);
            label_id.Name = "label_id";
            label_id.Size = new Size(27, 20);
            label_id.TabIndex = 0;
            label_id.Text = "ID:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(103, 144);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbbTypeSearch
            // 
            cbbTypeSearch.DisplayMember = "ID";
            cbbTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeSearch.FormattingEnabled = true;
            cbbTypeSearch.Items.AddRange(new object[] { "ID", "Họ lót", "Tên", "Số điện thoại", "Địa chỉ" });
            cbbTypeSearch.Location = new Point(129, 36);
            cbbTypeSearch.Name = "cbbTypeSearch";
            cbbTypeSearch.Size = new Size(182, 28);
            cbbTypeSearch.TabIndex = 3;
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Location = new Point(6, 36);
            label_type.Name = "label_type";
            label_type.Size = new Size(107, 20);
            label_type.TabIndex = 2;
            label_type.Text = "Tìm kiếm theo:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(129, 85);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(182, 27);
            txtSearch.TabIndex = 1;
            // 
            // groupBoxInfor
            // 
            groupBoxInfor.Anchor = AnchorStyles.Top;
            groupBoxInfor.Controls.Add(btn_reset);
            groupBoxInfor.Controls.Add(btn_delete);
            groupBoxInfor.Controls.Add(btn_update);
            groupBoxInfor.Controls.Add(btn_add);
            groupBoxInfor.Controls.Add(txt_address);
            groupBoxInfor.Controls.Add(label_address);
            groupBoxInfor.Controls.Add(maskedTextBox2);
            groupBoxInfor.Controls.Add(label_phoneNum);
            groupBoxInfor.Controls.Add(maskedTextBox1);
            groupBoxInfor.Controls.Add(label_date);
            groupBoxInfor.Controls.Add(txt_name);
            groupBoxInfor.Controls.Add(label1);
            groupBoxInfor.Controls.Add(txt_midName);
            groupBoxInfor.Controls.Add(label_midName);
            groupBoxInfor.Controls.Add(txt_id);
            groupBoxInfor.Controls.Add(label_id);
            groupBoxInfor.Location = new Point(369, 49);
            groupBoxInfor.Name = "groupBoxInfor";
            groupBoxInfor.Size = new Size(607, 268);
            groupBoxInfor.TabIndex = 6;
            groupBoxInfor.TabStop = false;
            groupBoxInfor.Text = "Thông tin nhân viên";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top;
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Controls.Add(cbbTypeSearch);
            groupBoxSearch.Controls.Add(label_type);
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Controls.Add(label_input);
            groupBoxSearch.Location = new Point(22, 61);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(335, 256);
            groupBoxSearch.TabIndex = 5;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // label_title
            // 
            label_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Blue;
            label_title.Location = new Point(317, 9);
            label_title.Margin = new Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(335, 28);
            label_title.TabIndex = 4;
            label_title.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvNhanVien);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 209);
            panel1.TabIndex = 7;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(995, 209);
            dgvNhanVien.TabIndex = 0;
            // 
            // EmployeeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 553);
            Controls.Add(panel1);
            Controls.Add(groupBoxInfor);
            Controls.Add(groupBoxSearch);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1013, 600);
            Name = "EmployeeFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeFrm";
            groupBoxInfor.ResumeLayout(false);
            groupBoxInfor.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_reset;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private TextBox txt_address;
        private Label label_address;
        private MaskedTextBox maskedTextBox2;
        private Label label_phoneNum;
        private Label label_input;
        private MaskedTextBox maskedTextBox1;
        private Label label_date;
        private TextBox txt_name;
        private Label label1;
        private TextBox txt_midName;
        private Label label_midName;
        private TextBox txt_id;
        private Label label_id;
        private Button btnSearch;
        private ComboBox cbbTypeSearch;
        private Label label_type;
        private TextBox txtSearch;
        private GroupBox groupBoxInfor;
        private GroupBox groupBoxSearch;
        private Label label_title;
        private Panel panel1;
        private DataGridView dgvNhanVien;
    }
}