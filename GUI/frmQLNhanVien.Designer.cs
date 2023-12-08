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
            btn_link_acc = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            txt_address = new TextBox();
            label_address = new Label();
            txt_sdt = new MaskedTextBox();
            label_phoneNum = new Label();
            label_input = new Label();
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
            dtpNgayVaoLam = new DateTimePicker();
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
            // btn_link_acc
            // 
            btn_link_acc.Location = new Point(440, 218);
            btn_link_acc.Name = "btn_link_acc";
            btn_link_acc.Size = new Size(160, 35);
            btn_link_acc.TabIndex = 15;
            btn_link_acc.Text = "&Liên kết tài khoản";
            btn_link_acc.UseVisualStyleBackColor = true;
            btn_link_acc.Click += btn_link_acc_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(297, 218);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(114, 35);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "&Xoá";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(161, 218);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(114, 35);
            btn_update.TabIndex = 13;
            btn_update.Text = "&Sửa";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(13, 218);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(114, 35);
            btn_add.TabIndex = 12;
            btn_add.Text = "T&hêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(350, 160);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(250, 30);
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
            // txt_sdt
            // 
            txt_sdt.Location = new Point(350, 96);
            txt_sdt.Mask = "000-000-0000";
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(202, 27);
            txt_sdt.TabIndex = 9;
            txt_sdt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label_phoneNum
            // 
            label_phoneNum.AutoSize = true;
            label_phoneNum.Location = new Point(231, 99);
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
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(227, 36);
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
            txt_midName.Size = new Size(150, 27);
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
            btnSearch.Location = new Point(182, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "&Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbbTypeSearch
            // 
            cbbTypeSearch.DisplayMember = "ID";
            cbbTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeSearch.FormattingEnabled = true;
            cbbTypeSearch.Items.AddRange(new object[] { "Xem tất cả", "ID", "Họ lót", "Tên", "Địa chỉ", "SDT", "Ngày vào làm" });
            cbbTypeSearch.Location = new Point(129, 36);
            cbbTypeSearch.Name = "cbbTypeSearch";
            cbbTypeSearch.Size = new Size(182, 28);
            cbbTypeSearch.TabIndex = 3;
            cbbTypeSearch.SelectedIndexChanged += cbbTypeSearch_SelectedIndexChanged;
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
            groupBoxInfor.Controls.Add(dtpNgayVaoLam);
            groupBoxInfor.Controls.Add(btn_link_acc);
            groupBoxInfor.Controls.Add(btn_delete);
            groupBoxInfor.Controls.Add(btn_update);
            groupBoxInfor.Controls.Add(btn_add);
            groupBoxInfor.Controls.Add(txt_address);
            groupBoxInfor.Controls.Add(label_address);
            groupBoxInfor.Controls.Add(txt_sdt);
            groupBoxInfor.Controls.Add(label_phoneNum);
            groupBoxInfor.Controls.Add(label_date);
            groupBoxInfor.Controls.Add(txt_name);
            groupBoxInfor.Controls.Add(label1);
            groupBoxInfor.Controls.Add(txt_midName);
            groupBoxInfor.Controls.Add(label_midName);
            groupBoxInfor.Controls.Add(txt_id);
            groupBoxInfor.Controls.Add(label_id);
            groupBoxInfor.Location = new Point(349, 48);
            groupBoxInfor.Name = "groupBoxInfor";
            groupBoxInfor.Size = new Size(649, 268);
            groupBoxInfor.TabIndex = 6;
            groupBoxInfor.TabStop = false;
            groupBoxInfor.Text = "Thông tin nhân viên";
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Location = new Point(350, 31);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(250, 27);
            dtpNgayVaoLam.TabIndex = 16;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top;
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Controls.Add(cbbTypeSearch);
            groupBoxSearch.Controls.Add(label_type);
            groupBoxSearch.Controls.Add(txtSearch);
            groupBoxSearch.Controls.Add(label_input);
            groupBoxSearch.Location = new Point(0, 48);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(335, 268);
            groupBoxSearch.TabIndex = 5;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // label_title
            // 
            label_title.Anchor = AnchorStyles.Top;
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Blue;
            label_title.Location = new Point(349, 9);
            label_title.Margin = new Padding(4, 0, 4, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(335, 28);
            label_title.TabIndex = 4;
            label_title.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvNhanVien);
            panel1.Controls.Add(label_title);
            panel1.Controls.Add(groupBoxInfor);
            panel1.Controls.Add(groupBoxSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 600);
            panel1.TabIndex = 7;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(3, 322);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(998, 266);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // frmQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 600);
            Controls.Add(panel1);
            MinimumSize = new Size(1013, 600);
            Name = "frmQLNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeFrm";
            groupBoxInfor.ResumeLayout(false);
            groupBoxInfor.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_link_acc;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private TextBox txt_address;
        private Label label_address;
        private MaskedTextBox txt_sdt;
        private Label label_phoneNum;
        private Label label_input;
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
        private DateTimePicker dtpNgayVaoLam;
    }
}