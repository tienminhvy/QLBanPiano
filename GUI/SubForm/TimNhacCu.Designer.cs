namespace QLBanPiano.GUI.SubForm
{
    partial class TimNhacCu
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
            groupBox1 = new GroupBox();
            btnTim = new Button();
            cbbTieuChi = new ComboBox();
            txtTieuChi = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(cbbTieuChi);
            groupBox1.Controls.Add(txtTieuChi);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 132);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm theo tiêu chí";
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.Location = new Point(200, 97);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // cbbTieuChi
            // 
            cbbTieuChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbTieuChi.FormattingEnabled = true;
            cbbTieuChi.Location = new Point(6, 26);
            cbbTieuChi.Name = "cbbTieuChi";
            cbbTieuChi.Size = new Size(288, 28);
            cbbTieuChi.TabIndex = 1;
            // 
            // txtTieuChi
            // 
            txtTieuChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTieuChi.Location = new Point(6, 60);
            txtTieuChi.Name = "txtTieuChi";
            txtTieuChi.PlaceholderText = "Nhập tiêu chí";
            txtTieuChi.Size = new Size(288, 27);
            txtTieuChi.TabIndex = 0;
            // 
            // TimNhacCu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 156);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TimNhacCu";
            Text = "Tìm nhạc cụ Piano";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTim;
        private ComboBox cbbTieuChi;
        private TextBox txtTieuChi;
    }
}