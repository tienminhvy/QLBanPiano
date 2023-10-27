namespace QLBanPiano.GUI.SubForm
{
    partial class ChonTuDanhSach
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
            dsDoiTuong = new ListBox();
            panel1 = new Panel();
            btnChon = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dsDoiTuong
            // 
            dsDoiTuong.Dock = DockStyle.Fill;
            dsDoiTuong.FormattingEnabled = true;
            dsDoiTuong.ItemHeight = 20;
            dsDoiTuong.Location = new Point(0, 0);
            dsDoiTuong.Name = "dsDoiTuong";
            dsDoiTuong.Size = new Size(282, 253);
            dsDoiTuong.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChon);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 51);
            panel1.TabIndex = 1;
            // 
            // btnChon
            // 
            btnChon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChon.Location = new Point(176, 10);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(94, 29);
            btnChon.TabIndex = 1;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Huỷ bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ChonTuDanhSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(panel1);
            Controls.Add(dsDoiTuong);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(300, 300);
            Name = "ChonTuDanhSach";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn từ danh sách";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox dsDoiTuong;
        private Panel panel1;
        private Button btnChon;
        private Button btnCancel;
    }
}