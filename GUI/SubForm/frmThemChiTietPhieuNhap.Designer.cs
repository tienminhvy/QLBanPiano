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
            label1 = new Label();
            id_pnTextBox = new TextBox();
            nc_idComboBox = new ComboBox();
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
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(id_pnTextBox);
            groupBox2.Controls.Add(nc_idComboBox);
            groupBox2.Controls.Add(ct_priceTextBox);
            groupBox2.Controls.Add(ct_slTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(10, 10);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(443, 149);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 13;
            label1.Text = "Số phiếu :";
            // 
            // id_pnTextBox
            // 
            id_pnTextBox.Enabled = false;
            id_pnTextBox.Location = new Point(170, 20);
            id_pnTextBox.Margin = new Padding(2);
            id_pnTextBox.Name = "id_pnTextBox";
            id_pnTextBox.ReadOnly = true;
            id_pnTextBox.Size = new Size(47, 27);
            id_pnTextBox.TabIndex = 12;
            id_pnTextBox.TabStop = false;
            // 
            // nc_idComboBox
            // 
            nc_idComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nc_idComboBox.FormattingEnabled = true;
            nc_idComboBox.Location = new Point(170, 50);
            nc_idComboBox.Margin = new Padding(2);
            nc_idComboBox.Name = "nc_idComboBox";
            nc_idComboBox.Size = new Size(210, 28);
            nc_idComboBox.TabIndex = 0;
            nc_idComboBox.SelectedIndexChanged += nc_idComboBox_SelectedIndexChanged;
            // 
            // ct_priceTextBox
            // 
            ct_priceTextBox.Location = new Point(170, 81);
            ct_priceTextBox.Margin = new Padding(2);
            ct_priceTextBox.Name = "ct_priceTextBox";
            ct_priceTextBox.Size = new Size(210, 27);
            ct_priceTextBox.TabIndex = 1;
            ct_priceTextBox.TabStop = false;
            // 
            // ct_slTextBox
            // 
            ct_slTextBox.Location = new Point(170, 112);
            ct_slTextBox.Margin = new Padding(2);
            ct_slTextBox.MaxLength = 3;
            ct_slTextBox.Name = "ct_slTextBox";
            ct_slTextBox.PlaceholderText = " Tối đa 100 sản phẩm";
            ct_slTextBox.Size = new Size(210, 27);
            ct_slTextBox.TabIndex = 2;
            ct_slTextBox.TextChanged += ct_slTextBox_TextChanged;
            ct_slTextBox.KeyPress += ct_slTextBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 117);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 3;
            label6.Text = "Số lượng :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 2;
            label5.Text = "Chi phí  (1 sản phẩm):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 56);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 1;
            label4.Text = "Mã nhạc cụ :";
            // 
            // totalTextBox
            // 
            totalTextBox.Enabled = false;
            totalTextBox.Location = new Point(270, 6);
            totalTextBox.Margin = new Padding(2);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(172, 27);
            totalTextBox.TabIndex = 7;
            totalTextBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 10);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 6;
            label7.Text = "Tổng chi phí :";
            // 
            // panel1
            // 
            panel1.Controls.Add(CancelAddBtn);
            panel1.Controls.Add(ConfirmAddBtn);
            panel1.Controls.Add(totalTextBox);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(10, 163);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 40);
            panel1.TabIndex = 3;
            // 
            // CancelAddBtn
            // 
            CancelAddBtn.Image = (Image)resources.GetObject("CancelAddBtn.Image");
            CancelAddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CancelAddBtn.Location = new Point(0, 0);
            CancelAddBtn.Margin = new Padding(2);
            CancelAddBtn.Name = "CancelAddBtn";
            CancelAddBtn.Size = new Size(80, 40);
            CancelAddBtn.TabIndex = 1;
            CancelAddBtn.Text = "  Hủy";
            CancelAddBtn.UseVisualStyleBackColor = true;
            CancelAddBtn.Click += CancelAddBtn_Click;
            // 
            // ConfirmAddBtn
            // 
            ConfirmAddBtn.Image = (Image)resources.GetObject("ConfirmAddBtn.Image");
            ConfirmAddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConfirmAddBtn.Location = new Point(85, 0);
            ConfirmAddBtn.Margin = new Padding(2);
            ConfirmAddBtn.Name = "ConfirmAddBtn";
            ConfirmAddBtn.Size = new Size(80, 40);
            ConfirmAddBtn.TabIndex = 0;
            ConfirmAddBtn.Text = "   Thêm";
            ConfirmAddBtn.UseVisualStyleBackColor = true;
            ConfirmAddBtn.Click += ConfirmAddBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 206);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 4;
            label8.Text = "@quanlibanpiano";
            // 
            // frmThemChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 242);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(484, 289);
            MinimizeBox = false;
            MinimumSize = new Size(484, 289);
            Name = "frmThemChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm chi tiết phiếu nhập";
            KeyDown += frmThemChiTietPhieuNhap_KeyDown;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox nc_idComboBox;
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