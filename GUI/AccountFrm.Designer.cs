namespace QLBanPiano.GUI.SubForm
{
    partial class AccountFrm
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
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            btn_Delete = new Button();
            btn_update = new Button();
            groupBox_account = new GroupBox();
            btn_add = new Button();
            txt_pass = new TextBox();
            label_pass = new Label();
            txt_username = new TextBox();
            label_username = new Label();
            txt_id = new TextBox();
            label_id = new Label();
            txt_input = new TextBox();
            label_input = new Label();
            comboBox_type = new ComboBox();
            btnSearch = new Button();
            groupBox_search = new GroupBox();
            label_type = new Label();
            label_title = new Label();
            groupBox_account.SuspendLayout();
            groupBox_search.SuspendLayout();
            SuspendLayout();
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mật khẩu";
            columnHeader3.Width = 300;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 200;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.Location = new Point(7, 276);
            listView1.Name = "listView1";
            listView1.Size = new Size(869, 217);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên đăng nhập";
            columnHeader2.Width = 300;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(392, 155);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(122, 31);
            btn_Delete.TabIndex = 8;
            btn_Delete.Text = "Xoá";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(392, 95);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(122, 31);
            btn_update.TabIndex = 7;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // groupBox_account
            // 
            groupBox_account.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_account.Controls.Add(btn_Delete);
            groupBox_account.Controls.Add(btn_update);
            groupBox_account.Controls.Add(btn_add);
            groupBox_account.Controls.Add(txt_pass);
            groupBox_account.Controls.Add(label_pass);
            groupBox_account.Controls.Add(txt_username);
            groupBox_account.Controls.Add(label_username);
            groupBox_account.Controls.Add(txt_id);
            groupBox_account.Controls.Add(label_id);
            groupBox_account.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_account.Location = new Point(315, 51);
            groupBox_account.Name = "groupBox_account";
            groupBox_account.Size = new Size(558, 219);
            groupBox_account.TabIndex = 6;
            groupBox_account.TabStop = false;
            groupBox_account.Text = "Thông tin tài khoản";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(392, 41);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(122, 31);
            btn_add.TabIndex = 6;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(143, 155);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(154, 30);
            txt_pass.TabIndex = 5;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.Location = new Point(6, 155);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(86, 23);
            label_pass.TabIndex = 4;
            label_pass.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(143, 99);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(167, 30);
            txt_username.TabIndex = 3;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(9, 99);
            label_username.Name = "label_username";
            label_username.Size = new Size(128, 23);
            label_username.TabIndex = 2;
            label_username.Text = "Tên đăng nhập:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(143, 42);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(129, 30);
            txt_id.TabIndex = 1;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(13, 45);
            label_id.Name = "label_id";
            label_id.Size = new Size(31, 23);
            label_id.TabIndex = 0;
            label_id.Text = "ID:";
            // 
            // txt_input
            // 
            txt_input.Location = new Point(134, 78);
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(162, 30);
            txt_input.TabIndex = 3;
            // 
            // label_input
            // 
            label_input.AutoSize = true;
            label_input.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_input.Location = new Point(8, 79);
            label_input.Name = "label_input";
            label_input.Size = new Size(113, 23);
            label_input.TabIndex = 2;
            label_input.Text = "Nhập dữ liệu:";
            // 
            // comboBox_type
            // 
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Items.AddRange(new object[] { "ID", "Tên đăng nhập", "Mật khẩu" });
            comboBox_type.Location = new Point(134, 28);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(163, 31);
            comboBox_type.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(85, 138);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 33);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox_search
            // 
            groupBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_search.Controls.Add(btnSearch);
            groupBox_search.Controls.Add(txt_input);
            groupBox_search.Controls.Add(label_input);
            groupBox_search.Controls.Add(comboBox_type);
            groupBox_search.Controls.Add(label_type);
            groupBox_search.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_search.Location = new Point(6, 51);
            groupBox_search.Name = "groupBox_search";
            groupBox_search.Size = new Size(303, 219);
            groupBox_search.TabIndex = 5;
            groupBox_search.TabStop = false;
            groupBox_search.Text = "Tìm kiếm";
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_type.Location = new Point(6, 29);
            label_type.Name = "label_type";
            label_type.Size = new Size(123, 23);
            label_type.TabIndex = 0;
            label_type.Text = "Tìm kiếm theo:";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Blue;
            label_title.Location = new Point(324, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(214, 28);
            label_title.TabIndex = 4;
            label_title.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // AccountFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(listView1);
            Controls.Add(groupBox_account);
            Controls.Add(groupBox_search);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AccountFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountFrm";
            groupBox_account.ResumeLayout(false);
            groupBox_account.PerformLayout();
            groupBox_search.ResumeLayout(false);
            groupBox_search.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private Button btn_Delete;
        private Button btn_update;
        private GroupBox groupBox_account;
        private Button btn_add;
        private TextBox txt_pass;
        private Label label_pass;
        private TextBox txt_username;
        private Label label_username;
        private TextBox txt_id;
        private Label label_id;
        private TextBox txt_input;
        private Label label_input;
        private ComboBox comboBox_type;
        private Button btnSearch;
        private GroupBox groupBox_search;
        private Label label_type;
        private Label label_title;
    }
}