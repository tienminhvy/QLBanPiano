namespace QLBanPiano.GUI.SubForm
{
    partial class frmLienKetTK
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
            btnThaoTac = new Button();
            btnCapNhat = new Button();
            label_pass = new Label();
            label_username = new Label();
            label_stateResult = new Label();
            label_state = new Label();
            label_title = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            cbVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThaoTac
            // 
            btnThaoTac.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnThaoTac.Location = new Point(374, 259);
            btnThaoTac.Name = "btnThaoTac";
            btnThaoTac.Size = new Size(143, 42);
            btnThaoTac.TabIndex = 1;
            btnThaoTac.Text = "Khoá/Mở khoá";
            btnThaoTac.UseVisualStyleBackColor = true;
            btnThaoTac.Click += btnThaoTac_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCapNhat.Location = new Point(150, 259);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(143, 42);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Tạo/Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_pass.Location = new Point(14, 94);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(86, 23);
            label_pass.TabIndex = 14;
            label_pass.Text = "Mật khẩu:";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_username.Location = new Point(14, 56);
            label_username.Name = "label_username";
            label_username.Size = new Size(128, 23);
            label_username.TabIndex = 12;
            label_username.Text = "Tên đăng nhập:";
            // 
            // label_stateResult
            // 
            label_stateResult.AutoSize = true;
            label_stateResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_stateResult.Location = new Point(188, 23);
            label_stateResult.Name = "label_stateResult";
            label_stateResult.Size = new Size(56, 23);
            label_stateResult.TabIndex = 11;
            label_stateResult.Text = "Result";
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_state.Location = new Point(14, 23);
            label_state.Name = "label_state";
            label_state.Size = new Size(151, 23);
            label_state.TabIndex = 10;
            label_state.Text = "Trạng thái liên kết:";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Blue;
            label_title.Location = new Point(211, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(240, 28);
            label_title.TabIndex = 9;
            label_title.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbVaiTro);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label_state);
            groupBox1.Controls.Add(label_stateResult);
            groupBox1.Controls.Add(label_username);
            groupBox1.Controls.Add(label_pass);
            groupBox1.Location = new Point(136, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 200);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 136);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 19;
            label1.Text = "Vai trò:";
            // 
            // cbVaiTro
            // 
            cbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVaiTro.FormattingEnabled = true;
            cbVaiTro.Location = new Point(188, 136);
            cbVaiTro.Name = "cbVaiTro";
            cbVaiTro.Size = new Size(193, 28);
            cbVaiTro.TabIndex = 2;
            cbVaiTro.SelectedIndexChanged += cbVaiTro_SelectedIndexChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(188, 93);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(193, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(188, 55);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(193, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // frmLienKetTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 341);
            Controls.Add(groupBox1);
            Controls.Add(btnThaoTac);
            Controls.Add(btnCapNhat);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLienKetTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liên kết tài khoản";
            KeyDown += frmLienKetTK_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThaoTac;
        private Button btnCapNhat;
        private Label label_pass;
        private Label label_username;
        private Label label_stateResult;
        private Label label_state;
        private Label label_title;
        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private ComboBox cbVaiTro;
        private Label label1;
    }
}