namespace QLBanPiano.GUI.SubForm
{
    partial class frmThuongHieu
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
            txtTenThuongHieu = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTenThuongHieu
            // 
            txtTenThuongHieu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenThuongHieu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenThuongHieu.Location = new Point(12, 66);
            txtTenThuongHieu.Name = "txtTenThuongHieu";
            txtTenThuongHieu.PlaceholderText = "Nhập tên thương hiệu";
            txtTenThuongHieu.Size = new Size(314, 27);
            txtTenThuongHieu.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(232, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Tạo/xoá";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 28);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 4;
            label1.Text = "Chọn thương hiệu";
            // 
            // ThuongHieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 143);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(txtTenThuongHieu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ThuongHieu";
            Text = "Thương hiệu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenThuongHieu;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
    }
}