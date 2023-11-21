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
            button1 = new Button();
            panel18 = new Panel();
            panel2 = new Panel();
            panel17 = new Panel();
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 181);
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
            formPanel.Location = new Point(230, 169);
            formPanel.MaximumSize = new Size(555, 353);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(555, 353);
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
            loginBtnPanel.Location = new Point(0, 283);
            loginBtnPanel.Name = "loginBtnPanel";
            loginBtnPanel.Size = new Size(555, 70);
            loginBtnPanel.TabIndex = 6;
            // 
            // panel19
            // 
            panel19.Controls.Add(button1);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(184, 10);
            panel19.Name = "panel19";
            panel19.Size = new Size(187, 50);
            panel19.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(187, 50);
            button1.TabIndex = 6;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel18
            // 
            panel18.Dock = DockStyle.Bottom;
            panel18.Location = new Point(184, 60);
            panel18.Name = "panel18";
            panel18.Size = new Size(187, 10);
            panel18.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(184, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 10);
            panel2.TabIndex = 6;
            // 
            // panel17
            // 
            panel17.Dock = DockStyle.Right;
            panel17.Location = new Point(371, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(184, 70);
            panel17.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 70);
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
            pwdPanel.Location = new Point(0, 232);
            pwdPanel.Name = "pwdPanel";
            pwdPanel.Size = new Size(555, 51);
            pwdPanel.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(pwdTextBox);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(168, 10);
            panel10.Name = "panel10";
            panel10.Size = new Size(377, 31);
            panel10.TabIndex = 7;
            // 
            // pwdTextBox
            // 
            pwdTextBox.AcceptsTab = true;
            pwdTextBox.Dock = DockStyle.Fill;
            pwdTextBox.Location = new Point(0, 0);
            pwdTextBox.Margin = new Padding(4);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.Size = new Size(377, 31);
            pwdTextBox.TabIndex = 6;
            pwdTextBox.Click += pwdTextBox_Click;
            pwdTextBox.Leave += pwdTextBox_Leave;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(168, 41);
            panel9.Name = "panel9";
            panel9.Size = new Size(377, 10);
            panel9.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(168, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(377, 10);
            panel8.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(545, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 51);
            panel7.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(160, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(8, 51);
            panel6.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 51);
            panel5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 29);
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
            userNamePanel.Location = new Point(0, 181);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(555, 51);
            userNamePanel.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.Controls.Add(userTextBox);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(168, 10);
            panel11.Name = "panel11";
            panel11.Size = new Size(377, 31);
            panel11.TabIndex = 7;
            // 
            // userTextBox
            // 
            userTextBox.AcceptsTab = true;
            userTextBox.Dock = DockStyle.Fill;
            userTextBox.Location = new Point(0, 0);
            userTextBox.Margin = new Padding(4);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(377, 31);
            userTextBox.TabIndex = 6;
            userTextBox.Click += userTextBox_Click;
            userTextBox.Leave += userTextBox_Leave;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(168, 41);
            panel12.Name = "panel12";
            panel12.Size = new Size(377, 10);
            panel12.TabIndex = 7;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(168, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(377, 10);
            panel13.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Right;
            panel14.Location = new Point(545, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(10, 51);
            panel14.TabIndex = 7;
            // 
            // panel15
            // 
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(160, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(8, 51);
            panel15.TabIndex = 7;
            // 
            // panel16
            // 
            panel16.Controls.Add(label2);
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(160, 51);
            panel16.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 29);
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
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1015, 691);
            mainPanel.TabIndex = 6;
            mainPanel.Resize += mainPanel_Resize;
            // 
            // rightPadding
            // 
            rightPadding.BackColor = Color.LightGray;
            rightPadding.Dock = DockStyle.Right;
            rightPadding.Location = new Point(785, 169);
            rightPadding.Name = "rightPadding";
            rightPadding.Size = new Size(230, 353);
            rightPadding.TabIndex = 3;
            // 
            // leftPadding
            // 
            leftPadding.BackColor = Color.LightGray;
            leftPadding.Dock = DockStyle.Left;
            leftPadding.Location = new Point(0, 169);
            leftPadding.Name = "leftPadding";
            leftPadding.Size = new Size(230, 353);
            leftPadding.TabIndex = 2;
            // 
            // botPadding
            // 
            botPadding.BackColor = Color.LightGray;
            botPadding.Dock = DockStyle.Bottom;
            botPadding.Location = new Point(0, 522);
            botPadding.Name = "botPadding";
            botPadding.Size = new Size(1015, 169);
            botPadding.TabIndex = 1;
            // 
            // topPadding
            // 
            topPadding.BackColor = Color.LightGray;
            topPadding.Dock = DockStyle.Top;
            topPadding.Location = new Point(0, 0);
            topPadding.Name = "topPadding";
            topPadding.Size = new Size(1015, 169);
            topPadding.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 691);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximumSize = new Size(1942, 1102);
            MinimumSize = new Size(1037, 747);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += LoginForm_Load;
            ClientSizeChanged += LoginForm_ClientSizeChanged;
            Resize += LoginForm_Resize;
            formPanel.ResumeLayout(false);
            loginBtnPanel.ResumeLayout(false);
            panel19.ResumeLayout(false);
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
        private Button button1;
        private Panel mainPanel;
        private Panel rightPadding;
        private Panel leftPadding;
        private Panel botPadding;
        private Panel topPadding;
    }
}