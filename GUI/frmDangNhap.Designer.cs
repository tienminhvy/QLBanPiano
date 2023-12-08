namespace QLBanPiano
{
    partial class frmDangNhap
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
            panel1 = new Panel();
            formPanel = new Panel();
            loginBtnPanel = new Panel();
            panel19 = new Panel();
            btnDangNhap = new Button();
            panel18 = new Panel();
            panel2 = new Panel();
            panel17 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            pwdPanel = new Panel();
            panel10 = new Panel();
            pwdTextBox = new TextBox();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            userNamePanel = new Panel();
            panel11 = new Panel();
            userTextBox = new TextBox();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            label2 = new Label();
            mainPanel = new Panel();
            rightPadding = new Panel();
            leftPadding = new Panel();
            botPadding = new Panel();
            topPadding = new Panel();
            formPanel.SuspendLayout();
            loginBtnPanel.SuspendLayout();
            panel19.SuspendLayout();
            panel17.SuspendLayout();
            pwdPanel.SuspendLayout();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            userNamePanel.SuspendLayout();
            panel11.SuspendLayout();
            panel16.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Logo128;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 145);
            panel1.TabIndex = 1;
            // 
            // formPanel
            // 
            formPanel.Anchor = AnchorStyles.None;
            formPanel.BackColor = Color.LightGray;
            formPanel.Controls.Add(loginBtnPanel);
            formPanel.Controls.Add(pwdPanel);
            formPanel.Controls.Add(userNamePanel);
            formPanel.Controls.Add(panel1);
            formPanel.Location = new Point(185, 139);
            formPanel.Margin = new Padding(2);
            formPanel.MaximumSize = new Size(444, 282);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(444, 282);
            formPanel.TabIndex = 5;
            // 
            // loginBtnPanel
            // 
            loginBtnPanel.Controls.Add(panel19);
            loginBtnPanel.Controls.Add(panel18);
            loginBtnPanel.Controls.Add(panel2);
            loginBtnPanel.Controls.Add(panel17);
            loginBtnPanel.Controls.Add(panel4);
            loginBtnPanel.Dock = DockStyle.Top;
            loginBtnPanel.Location = new Point(0, 227);
            loginBtnPanel.Margin = new Padding(2);
            loginBtnPanel.Name = "loginBtnPanel";
            loginBtnPanel.Size = new Size(444, 56);
            loginBtnPanel.TabIndex = 6;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnDangNhap);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(147, 8);
            panel19.Margin = new Padding(2);
            panel19.Name = "panel19";
            panel19.Size = new Size(150, 40);
            panel19.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SlateBlue;
            btnDangNhap.Dock = DockStyle.Fill;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.ButtonFace;
            btnDangNhap.Location = new Point(0, 0);
            btnDangNhap.Margin = new Padding(2);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(150, 40);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đă&ng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel18
            // 
            panel18.Dock = DockStyle.Bottom;
            panel18.Location = new Point(147, 48);
            panel18.Margin = new Padding(2);
            panel18.Name = "panel18";
            panel18.Size = new Size(150, 8);
            panel18.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(147, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 8);
            panel2.TabIndex = 6;
            // 
            // panel17
            // 
            panel17.Controls.Add(label3);
            panel17.Dock = DockStyle.Right;
            panel17.Location = new Point(297, 0);
            panel17.Margin = new Padding(2);
            panel17.Name = "panel17";
            panel17.Size = new Size(147, 56);
            panel17.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(28, 2);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 0;
            label3.Text = "&Quên mật khẩu?";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(147, 56);
            panel4.TabIndex = 6;
            // 
            // pwdPanel
            // 
            pwdPanel.Controls.Add(panel10);
            pwdPanel.Controls.Add(panel9);
            pwdPanel.Controls.Add(panel8);
            pwdPanel.Controls.Add(panel7);
            pwdPanel.Controls.Add(panel6);
            pwdPanel.Controls.Add(panel5);
            pwdPanel.Dock = DockStyle.Top;
            pwdPanel.Location = new Point(0, 186);
            pwdPanel.Margin = new Padding(2);
            pwdPanel.Name = "pwdPanel";
            pwdPanel.Size = new Size(444, 41);
            pwdPanel.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(pwdTextBox);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(134, 8);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(302, 25);
            panel10.TabIndex = 7;
            // 
            // pwdTextBox
            // 
            pwdTextBox.AcceptsTab = true;
            pwdTextBox.Dock = DockStyle.Fill;
            pwdTextBox.Location = new Point(0, 0);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.PasswordChar = '*';
            pwdTextBox.Size = new Size(302, 27);
            pwdTextBox.TabIndex = 0;
            pwdTextBox.Click += pwdTextBox_Click;
            pwdTextBox.Leave += pwdTextBox_Leave;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(134, 33);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(302, 8);
            panel9.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(134, 0);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(302, 8);
            panel8.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(436, 0);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(8, 41);
            panel7.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(128, 0);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(6, 41);
            panel6.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(128, 41);
            panel5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 4;
            label1.Text = "Mật khẩu";
            label1.Click += label1_Click;
            // 
            // userNamePanel
            // 
            userNamePanel.Controls.Add(panel11);
            userNamePanel.Controls.Add(panel12);
            userNamePanel.Controls.Add(panel13);
            userNamePanel.Controls.Add(panel14);
            userNamePanel.Controls.Add(panel15);
            userNamePanel.Controls.Add(panel16);
            userNamePanel.Dock = DockStyle.Top;
            userNamePanel.Location = new Point(0, 145);
            userNamePanel.Margin = new Padding(2);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(444, 41);
            userNamePanel.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.Controls.Add(userTextBox);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(134, 8);
            panel11.Margin = new Padding(2);
            panel11.Name = "panel11";
            panel11.Size = new Size(302, 25);
            panel11.TabIndex = 7;
            // 
            // userTextBox
            // 
            userTextBox.AcceptsTab = true;
            userTextBox.Dock = DockStyle.Fill;
            userTextBox.Location = new Point(0, 0);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(302, 27);
            userTextBox.TabIndex = 0;
            userTextBox.Click += userTextBox_Click;
            userTextBox.Leave += userTextBox_Leave;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(134, 33);
            panel12.Margin = new Padding(2);
            panel12.Name = "panel12";
            panel12.Size = new Size(302, 8);
            panel12.TabIndex = 7;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(134, 0);
            panel13.Margin = new Padding(2);
            panel13.Name = "panel13";
            panel13.Size = new Size(302, 8);
            panel13.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Right;
            panel14.Location = new Point(436, 0);
            panel14.Margin = new Padding(2);
            panel14.Name = "panel14";
            panel14.Size = new Size(8, 41);
            panel14.TabIndex = 7;
            // 
            // panel15
            // 
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(128, 0);
            panel15.Margin = new Padding(2);
            panel15.Name = "panel15";
            panel15.Size = new Size(6, 41);
            panel15.TabIndex = 7;
            // 
            // panel16
            // 
            panel16.Controls.Add(label2);
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(0, 0);
            panel16.Margin = new Padding(2);
            panel16.Name = "panel16";
            panel16.Size = new Size(128, 41);
            panel16.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 12);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 4;
            label2.Text = "Tên đăng nhập";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.LightGray;
            mainPanel.Controls.Add(formPanel);
            mainPanel.Controls.Add(rightPadding);
            mainPanel.Controls.Add(leftPadding);
            mainPanel.Controls.Add(botPadding);
            mainPanel.Controls.Add(topPadding);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(815, 560);
            mainPanel.TabIndex = 6;
            mainPanel.Resize += mainPanel_Resize;
            // 
            // rightPadding
            // 
            rightPadding.BackColor = Color.LightGray;
            rightPadding.Dock = DockStyle.Right;
            rightPadding.Location = new Point(631, 135);
            rightPadding.Margin = new Padding(2);
            rightPadding.Name = "rightPadding";
            rightPadding.Size = new Size(184, 290);
            rightPadding.TabIndex = 2;
            // 
            // leftPadding
            // 
            leftPadding.BackColor = Color.LightGray;
            leftPadding.Dock = DockStyle.Left;
            leftPadding.Location = new Point(0, 135);
            leftPadding.Margin = new Padding(2);
            leftPadding.Name = "leftPadding";
            leftPadding.Size = new Size(184, 290);
            leftPadding.TabIndex = 2;
            // 
            // botPadding
            // 
            botPadding.BackColor = Color.LightGray;
            botPadding.Dock = DockStyle.Bottom;
            botPadding.Location = new Point(0, 425);
            botPadding.Margin = new Padding(2);
            botPadding.Name = "botPadding";
            botPadding.Size = new Size(815, 135);
            botPadding.TabIndex = 1;
            // 
            // topPadding
            // 
            topPadding.BackColor = Color.LightGray;
            topPadding.Dock = DockStyle.Top;
            topPadding.Location = new Point(0, 0);
            topPadding.Margin = new Padding(2);
            topPadding.Name = "topPadding";
            topPadding.Size = new Size(815, 135);
            topPadding.TabIndex = 0;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 560);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(1557, 891);
            MinimizeBox = false;
            MinimumSize = new Size(833, 607);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += LoginForm_Load;
            ClientSizeChanged += LoginForm_ClientSizeChanged;
            KeyPress += frmDangNhap_KeyPress;
            Resize += LoginForm_Resize;
            formPanel.ResumeLayout(false);
            loginBtnPanel.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            pwdPanel.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            userNamePanel.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel formPanel;
        private TextBox pwdTextBox;
        private Panel pwdPanel;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Label label1;
        private Panel panel10;
        private Panel userNamePanel;
        private Panel panel11;
        private TextBox userTextBox;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Label label2;
        private Panel loginBtnPanel;
        private Panel panel4;
        private Panel panel17;
        private Panel panel19;
        private Panel panel18;
        private Panel panel2;
        private Button btnDangNhap;
        private Panel mainPanel;
        private Panel rightPadding;
        private Panel leftPadding;
        private Panel botPadding;
        private Panel topPadding;
        private Label label3;
    }
}