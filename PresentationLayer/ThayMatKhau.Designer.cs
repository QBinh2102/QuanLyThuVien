namespace PresentationLayer
{
    partial class ThayMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhanMatKhau = new System.Windows.Forms.Button();
            this.btnHuyThayMatKhau = new System.Windows.Forms.Button();
            this.lbThongBaoMK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(265, 28);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(207, 31);
            this.txtMatKhauHienTai.TabIndex = 1;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(265, 74);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(207, 31);
            this.txtMatKhauMoi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtXacNhanMatKhauMoi
            // 
            this.txtXacNhanMatKhauMoi.Location = new System.Drawing.Point(265, 121);
            this.txtXacNhanMatKhauMoi.Name = "txtXacNhanMatKhauMoi";
            this.txtXacNhanMatKhauMoi.Size = new System.Drawing.Size(207, 31);
            this.txtXacNhanMatKhauMoi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xác nhận mật khẩu mới:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXacNhanMatKhau
            // 
            this.btnXacNhanMatKhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhanMatKhau.Location = new System.Drawing.Point(83, 194);
            this.btnXacNhanMatKhau.Name = "btnXacNhanMatKhau";
            this.btnXacNhanMatKhau.Size = new System.Drawing.Size(117, 50);
            this.btnXacNhanMatKhau.TabIndex = 6;
            this.btnXacNhanMatKhau.Text = "Xác nhận";
            this.btnXacNhanMatKhau.UseVisualStyleBackColor = false;
            this.btnXacNhanMatKhau.Click += new System.EventHandler(this.btnXacNhanMatKhau_Click);
            // 
            // btnHuyThayMatKhau
            // 
            this.btnHuyThayMatKhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuyThayMatKhau.Location = new System.Drawing.Point(285, 194);
            this.btnHuyThayMatKhau.Name = "btnHuyThayMatKhau";
            this.btnHuyThayMatKhau.Size = new System.Drawing.Size(117, 50);
            this.btnHuyThayMatKhau.TabIndex = 7;
            this.btnHuyThayMatKhau.Text = "Hủy";
            this.btnHuyThayMatKhau.UseVisualStyleBackColor = false;
            this.btnHuyThayMatKhau.Click += new System.EventHandler(this.btnHuyThayMatKhau_Click);
            // 
            // lbThongBaoMK
            // 
            this.lbThongBaoMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongBaoMK.ForeColor = System.Drawing.Color.Red;
            this.lbThongBaoMK.Location = new System.Drawing.Point(12, 159);
            this.lbThongBaoMK.Name = "lbThongBaoMK";
            this.lbThongBaoMK.Size = new System.Drawing.Size(460, 32);
            this.lbThongBaoMK.TabIndex = 8;
            this.lbThongBaoMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThayMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 269);
            this.Controls.Add(this.lbThongBaoMK);
            this.Controls.Add(this.btnHuyThayMatKhau);
            this.Controls.Add(this.btnXacNhanMatKhau);
            this.Controls.Add(this.txtXacNhanMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ThayMatKhau";
            this.Text = "Thay Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXacNhanMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhanMatKhau;
        private System.Windows.Forms.Button btnHuyThayMatKhau;
        private System.Windows.Forms.Label lbThongBaoMK;
    }
}