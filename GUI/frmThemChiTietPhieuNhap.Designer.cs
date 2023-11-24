namespace QLBanPiano.GUI
{
    partial class frmThemChiTietPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemChiTietPhieuNhap));
            groupBox2 = new GroupBox();
            ct_idComboBox = new ComboBox();
            searchBtn = new Button();
            ct_priceTextBox = new TextBox();
            ct_slTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            totalTextBox = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            CancelAddBtn = new Button();
            ConfirmAddBtn = new Button();
            label8 = new Label();
            label1 = new Label();
            id_pnTextBox = new TextBox();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(id_pnTextBox);
            groupBox2.Controls.Add(ct_idComboBox);
            groupBox2.Controls.Add(searchBtn);
            groupBox2.Controls.Add(ct_priceTextBox);
            groupBox2.Controls.Add(ct_slTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 186);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // ct_idComboBox
            // 
            ct_idComboBox.FormattingEnabled = true;
            ct_idComboBox.Location = new Point(212, 62);
            ct_idComboBox.Name = "ct_idComboBox";
            ct_idComboBox.Size = new Size(200, 33);
            ct_idComboBox.TabIndex = 11;
            // 
            // searchBtn
            // 
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(418, 61);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(55, 34);
            searchBtn.TabIndex = 10;
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // ct_priceTextBox
            // 
            ct_priceTextBox.Enabled = false;
            ct_priceTextBox.Location = new Point(212, 101);
            ct_priceTextBox.Name = "ct_priceTextBox";
            ct_priceTextBox.ReadOnly = true;
            ct_priceTextBox.Size = new Size(261, 31);
            ct_priceTextBox.TabIndex = 5;
            ct_priceTextBox.TabStop = false;
            // 
            // ct_slTextBox
            // 
            ct_slTextBox.Location = new Point(212, 140);
            ct_slTextBox.Name = "ct_slTextBox";
            ct_slTextBox.Size = new Size(261, 31);
            ct_slTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 146);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 3;
            label6.Text = "Số lượng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 107);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 2;
            label5.Text = "Chi phí  (1 sản phẩm):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 70);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 1;
            label4.Text = "Mã nhạc cụ :";
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(337, 7);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(214, 31);
            totalTextBox.TabIndex = 7;
            totalTextBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 13);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 6;
            label7.Text = "Tổng chi phí :";
            // 
            // panel1
            // 
            panel1.Controls.Add(CancelAddBtn);
            panel1.Controls.Add(ConfirmAddBtn);
            panel1.Controls.Add(totalTextBox);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 50);
            panel1.TabIndex = 3;
            // 
            // CancelAddBtn
            // 
            CancelAddBtn.Image = (Image)resources.GetObject("CancelAddBtn.Image");
            CancelAddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelAddBtn.Location = new Point(0, 0);
            CancelAddBtn.Name = "CancelAddBtn";
            CancelAddBtn.Size = new Size(100, 50);
            CancelAddBtn.TabIndex = 1;
            CancelAddBtn.Text = "  Hủy";
            CancelAddBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmAddBtn
            // 
            ConfirmAddBtn.Image = (Image)resources.GetObject("ConfirmAddBtn.Image");
            ConfirmAddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConfirmAddBtn.Location = new Point(106, 0);
            ConfirmAddBtn.Name = "ConfirmAddBtn";
            ConfirmAddBtn.Size = new Size(100, 50);
            ConfirmAddBtn.TabIndex = 0;
            ConfirmAddBtn.Text = "   Thêm";
            ConfirmAddBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 257);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 4;
            label8.Text = "@quanlibanpiano";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 31);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 13;
            label1.Text = "Số phiếu :";
            // 
            // id_pnTextBox
            // 
            id_pnTextBox.Enabled = false;
            id_pnTextBox.Location = new Point(212, 25);
            id_pnTextBox.Name = "id_pnTextBox";
            id_pnTextBox.ReadOnly = true;
            id_pnTextBox.Size = new Size(58, 31);
            id_pnTextBox.TabIndex = 12;
            // 
            // ThemChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 294);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MaximumSize = new Size(600, 350);
            MinimumSize = new Size(600, 350);
            Name = "ThemChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ThemChiTietPhieuNhapcs";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox ct_idComboBox;
        private Button searchBtn;
        private TextBox totalTextBox;
        private Label label7;
        private TextBox ct_priceTextBox;
        private TextBox ct_slTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Button CancelAddBtn;
        private Button ConfirmAddBtn;
        private Label label8;
        private Label label1;
        private TextBox id_pnTextBox;
    }
}