namespace QLBanPiano.GUI.QuanLyHoaDon_PhieuNhap
{
    partial class QLHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHD));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            rightPanel = new Panel();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            leftPanel = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            searchBtn = new Button();
            textBox5 = new TextBox();
            panel6 = new Panel();
            panel4 = new Panel();
            totalTextBoxPanel = new Panel();
            textBox4 = new TextBox();
            filterBtn = new Button();
            label6 = new Label();
            panel3 = new Panel();
            hoaDonGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            totalTextBoxPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 120);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(340, 33);
            label1.Name = "label1";
            label1.Size = new Size(334, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Hóa Đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(rightPanel);
            panel2.Controls.Add(leftPanel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 161);
            panel2.TabIndex = 1;
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.None;
            rightPanel.Controls.Add(label5);
            rightPanel.Controls.Add(dateTimePicker1);
            rightPanel.Controls.Add(label4);
            rightPanel.Controls.Add(textBox1);
            rightPanel.Controls.Add(textBox3);
            rightPanel.Controls.Add(label2);
            rightPanel.Controls.Add(textBox2);
            rightPanel.Controls.Add(label3);
            rightPanel.Location = new Point(3, 6);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(459, 161);
            rightPanel.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 124);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 3;
            label5.Text = "Ngày mua hàng :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 89);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 6);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(293, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 83);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(293, 31);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 12);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 46);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(293, 31);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 52);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng :";
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.None;
            leftPanel.Controls.Add(panel5);
            leftPanel.Controls.Add(panel4);
            leftPanel.Location = new Point(556, 0);
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
            panel5.Size = new Size(460, 108);
            panel5.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.Controls.Add(searchBtn);
            panel7.Controls.Add(textBox5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(460, 50);
            panel7.TabIndex = 12;
            // 
            // searchBtn
            // 
            searchBtn.Dock = DockStyle.Right;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(391, 0);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(69, 50);
            searchBtn.TabIndex = 8;
            searchBtn.TextAlign = ContentAlignment.MiddleLeft;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 9);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(367, 31);
            textBox5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(460, 50);
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
            totalTextBoxPanel.Controls.Add(textBox4);
            totalTextBoxPanel.Dock = DockStyle.Right;
            totalTextBoxPanel.Location = new Point(111, 0);
            totalTextBoxPanel.Name = "totalTextBoxPanel";
            totalTextBoxPanel.Size = new Size(280, 55);
            totalTextBoxPanel.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(0, 12);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(280, 31);
            textBox4.TabIndex = 10;
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 9;
            label6.Text = "Tổng tiền :";
            // 
            // panel3
            // 
            panel3.Controls.Add(hoaDonGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 359);
            panel3.TabIndex = 2;
            // 
            // hoaDonGridView
            // 
            hoaDonGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hoaDonGridView.Dock = DockStyle.Fill;
            hoaDonGridView.Location = new Point(0, 0);
            hoaDonGridView.Name = "hoaDonGridView";
            hoaDonGridView.RowHeadersWidth = 62;
            hoaDonGridView.RowTemplate.Height = 33;
            hoaDonGridView.Size = new Size(1016, 359);
            hoaDonGridView.TabIndex = 0;
            // 
            // QLHD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 640);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QLHD";
            Text = "QLHD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private DataGridView hoaDonGridView;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Panel panel5;
        private Panel panel6;
        private Button filterBtn;
        private Panel panel7;
        private Button searchBtn;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private Panel panel4;
        private Panel leftPanel;
        private Panel totalTextBoxPanel;
        private Panel rightPanel;
    }
}