namespace QLBanPiano.GUI.SubForm
{
    partial class frmTimNhanVien
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
            groupBox2 = new GroupBox();
            dateDenNgay = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dateTuNgay = new DateTimePicker();
            btnTimTheoNgay = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateDenNgay);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTuNgay);
            groupBox2.Controls.Add(btnTimTheoNgay);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 182);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm theo ngày vào làm";
            // 
            // dateDenNgay
            // 
            dateDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateDenNgay.Location = new Point(6, 109);
            dateDenNgay.Name = "dateDenNgay";
            dateDenNgay.Size = new Size(302, 27);
            dateDenNgay.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(236, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 4;
            label1.Text = "Từ ngày";
            // 
            // dateTuNgay
            // 
            dateTuNgay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTuNgay.Location = new Point(6, 46);
            dateTuNgay.Name = "dateTuNgay";
            dateTuNgay.Size = new Size(302, 27);
            dateTuNgay.TabIndex = 3;
            // 
            // btnTimTheoNgay
            // 
            btnTimTheoNgay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTimTheoNgay.Location = new Point(214, 147);
            btnTimTheoNgay.Name = "btnTimTheoNgay";
            btnTimTheoNgay.Size = new Size(94, 29);
            btnTimTheoNgay.TabIndex = 2;
            btnTimTheoNgay.Text = "Tìm";
            btnTimTheoNgay.UseVisualStyleBackColor = true;
            btnTimTheoNgay.Click += btnTimTheoNgay_Click;
            // 
            // frmTimNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 205);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmTimNhanVien";
            Text = "Tìm nhân viên";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DateTimePicker dateDenNgay;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTuNgay;
        private Button btnTimTheoNgay;
    }
}