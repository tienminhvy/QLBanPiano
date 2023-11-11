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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            hoaDonGridView = new DataGridView();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(button1);
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
            // textBox2
            // 
            textBox2.Location = new Point(192, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 31);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 123);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 3;
            label5.Text = "Ngày mua hàng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 83);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 46);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 9);
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
            // textBox3
            // 
            textBox3.Location = new Point(192, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 31);
            textBox3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(192, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(935, 113);
            button1.Name = "button1";
            button1.Size = new Size(69, 42);
            button1.TabIndex = 8;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(562, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(367, 31);
            textBox4.TabIndex = 9;
            // 
            // QLHD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 640);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "QLHD";
            Text = "QLHD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private TextBox textBox4;
        private Button button1;
    }
}