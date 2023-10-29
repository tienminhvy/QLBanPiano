namespace QLBanPiano.GUI.SubForm
{
    partial class LinkAccount
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
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label_pass = new Label();
            label_userResult = new Label();
            label_username = new Label();
            label_stateResult = new Label();
            label_state = new Label();
            label_title = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(332, 273);
            button2.Name = "button2";
            button2.Size = new Size(143, 42);
            button2.TabIndex = 17;
            button2.Text = "Khoá/Mở khoá";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(150, 273);
            button1.Name = "button1";
            button1.Size = new Size(143, 42);
            button1.TabIndex = 16;
            button1.Text = "Tạo";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(365, 219);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 15;
            label3.Text = "Result";
            // 
            // label_pass
            // 
            label_pass.AutoSize = true;
            label_pass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_pass.Location = new Point(150, 219);
            label_pass.Name = "label_pass";
            label_pass.Size = new Size(86, 23);
            label_pass.TabIndex = 14;
            label_pass.Text = "Mật khẩu:";
            // 
            // label_userResult
            // 
            label_userResult.AutoSize = true;
            label_userResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_userResult.Location = new Point(365, 168);
            label_userResult.Name = "label_userResult";
            label_userResult.Size = new Size(56, 23);
            label_userResult.TabIndex = 13;
            label_userResult.Text = "Result";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_username.Location = new Point(150, 168);
            label_username.Name = "label_username";
            label_username.Size = new Size(86, 23);
            label_username.TabIndex = 12;
            label_username.Text = "Tài khoản:";
            // 
            // label_stateResult
            // 
            label_stateResult.AutoSize = true;
            label_stateResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_stateResult.Location = new Point(365, 115);
            label_stateResult.Name = "label_stateResult";
            label_stateResult.Size = new Size(56, 23);
            label_stateResult.TabIndex = 11;
            label_stateResult.Text = "Result";
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_state.Location = new Point(150, 115);
            label_state.Name = "label_state";
            label_state.Size = new Size(151, 23);
            label_state.TabIndex = 10;
            label_state.Text = "Trạng thái liên kết:";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.Blue;
            label_title.Location = new Point(196, 36);
            label_title.Name = "label_title";
            label_title.Size = new Size(240, 28);
            label_title.TabIndex = 9;
            label_title.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // LinkAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 341);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label_pass);
            Controls.Add(label_userResult);
            Controls.Add(label_username);
            Controls.Add(label_stateResult);
            Controls.Add(label_state);
            Controls.Add(label_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LinkAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LinkAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label_pass;
        private Label label_userResult;
        private Label label_username;
        private Label label_stateResult;
        private Label label_state;
        private Label label_title;
    }
}