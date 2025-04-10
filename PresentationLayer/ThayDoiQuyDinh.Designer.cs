namespace PresentationLayer
{
    partial class ThayDoiQuyDinh
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
            this.tbSoSachMuonToiDa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoNgayMuonToiDa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "THAY ĐỔI QUY ĐỊNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSoSachMuonToiDa
            // 
            this.tbSoSachMuonToiDa.Location = new System.Drawing.Point(280, 105);
            this.tbSoSachMuonToiDa.Name = "tbSoSachMuonToiDa";
            this.tbSoSachMuonToiDa.Size = new System.Drawing.Size(148, 32);
            this.tbSoSachMuonToiDa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số sách mượn tối đa";
            // 
            // tbSoNgayMuonToiDa
            // 
            this.tbSoNgayMuonToiDa.Location = new System.Drawing.Point(280, 169);
            this.tbSoNgayMuonToiDa.Name = "tbSoNgayMuonToiDa";
            this.tbSoNgayMuonToiDa.Size = new System.Drawing.Size(148, 32);
            this.tbSoNgayMuonToiDa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số ngày mượn tối đa";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(569, 175);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(145, 65);
            this.btLuu.TabIndex = 7;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // ThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 268);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbSoNgayMuonToiDa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoSachMuonToiDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThayDoiQuyDinh";
            this.Text = "ThayDoiQuyDinh";
            this.Load += new System.EventHandler(this.ThayDoiQuyDinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoSachMuonToiDa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoNgayMuonToiDa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLuu;
    }
}