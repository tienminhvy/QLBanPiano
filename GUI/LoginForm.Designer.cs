namespace QLBanPiano
{
    partial class LoginForm
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
            txtUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Logo128;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 180);
            panel1.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Location = new Point(156, 12);
            txtUserName.Margin = new Padding(4, 4, 4, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(462, 31);
            txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtUserName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 180);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 61);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 241);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(638, 59);
            panel3.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(156, 11);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(462, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(15, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 300);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(638, 82);
            panel4.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.98969F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.01031F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(638, 82);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(164, 4);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(318, 74);
            button1.TabIndex = 0;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(154, 76);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(489, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(146, 76);
            panel6.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 382);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox txtUserName;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TextBox textBox1;
        private Panel panel5;
        private Panel panel6;
    }
}