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
            panel5 = new Panel();
            panel6 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            hoaDonGridView = new DataGridView();
            createBtn = new Button();
            fixBtn = new Button();
            printBtn = new Button();
            filterBtn = new Button();
            panel7 = new Panel();
            searchBtn = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).BeginInit();
            panel7.SuspendLayout();
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
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 161);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(556, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(460, 108);
            panel5.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(filterBtn);
            panel6.Controls.Add(printBtn);
            panel6.Controls.Add(createBtn);
            panel6.Controls.Add(fixBtn);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(460, 50);
            panel6.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 31);
            textBox1.TabIndex = 4;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 83);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 46);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn :";
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
            // createBtn
            // 
            createBtn.Location = new Point(0, 0);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(110, 50);
            createBtn.TabIndex = 9;
            createBtn.Text = "Tạo mới";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // fixBtn
            // 
            fixBtn.Location = new Point(116, 0);
            fixBtn.Name = "fixBtn";
            fixBtn.Size = new Size(110, 50);
            fixBtn.TabIndex = 14;
            fixBtn.Text = "Chỉnh sửa ";
            fixBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(232, 0);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(110, 50);
            printBtn.TabIndex = 15;
            printBtn.Text = "In hóa đơn";
            printBtn.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            filterBtn.Location = new Point(350, 0);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(110, 50);
            filterBtn.TabIndex = 16;
            filterBtn.Text = "Lọc";
            filterBtn.UseVisualStyleBackColor = true;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(556, 122);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 9;
            label6.Text = "Tổng tiền :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(658, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(280, 31);
            textBox4.TabIndex = 10;
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
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hoaDonGridView).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Button createBtn;
        private Button fixBtn;
        private Button printBtn;
        private Button filterBtn;
        private Panel panel7;
        private Button searchBtn;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
    }
}