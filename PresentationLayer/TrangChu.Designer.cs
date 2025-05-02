namespace PresentationLayer
{
    partial class TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQLTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThongTin,
            this.tsmiDanhMuc,
            this.tsmiMuonTra,
            this.tsmiThongKe,
            this.tsmiQuyDinh,
            this.tsmiThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiThongTin
            // 
            this.tsmiThongTin.Name = "tsmiThongTin";
            this.tsmiThongTin.Size = new System.Drawing.Size(74, 20);
            this.tsmiThongTin.Text = "Thông Tin";
            this.tsmiThongTin.Click += new System.EventHandler(this.tsmiThongTin_Click);
            // 
            // tsmiDanhMuc
            // 
            this.tsmiDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQLDocGia,
            this.toolStripSeparator1,
            this.tsmiQLSach,
            this.toolStripSeparator2,
            this.tsmiQLTheLoai,
            this.toolStripSeparator3,
            this.tsmiQLNhanVien});
            this.tsmiDanhMuc.Name = "tsmiDanhMuc";
            this.tsmiDanhMuc.Size = new System.Drawing.Size(120, 20);
            this.tsmiDanhMuc.Text = "Quản Lý Danh Mục";
            // 
            // tsmiQLDocGia
            // 
            this.tsmiQLDocGia.Name = "tsmiQLDocGia";
            this.tsmiQLDocGia.Size = new System.Drawing.Size(178, 22);
            this.tsmiQLDocGia.Text = "Quản Lý Độc Giả";
            this.tsmiQLDocGia.Click += new System.EventHandler(this.tsmiQLDocGia_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // tsmiQLSach
            // 
            this.tsmiQLSach.Name = "tsmiQLSach";
            this.tsmiQLSach.Size = new System.Drawing.Size(178, 22);
            this.tsmiQLSach.Text = "Quản Lý Sách";
            this.tsmiQLSach.Click += new System.EventHandler(this.tsmiQLSach_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // tsmiQLTheLoai
            // 
            this.tsmiQLTheLoai.Name = "tsmiQLTheLoai";
            this.tsmiQLTheLoai.Size = new System.Drawing.Size(178, 22);
            this.tsmiQLTheLoai.Text = "Quản Lý Thể Loại";
            this.tsmiQLTheLoai.Click += new System.EventHandler(this.tsmiQLTheLoai_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // tsmiQLNhanVien
            // 
            this.tsmiQLNhanVien.Name = "tsmiQLNhanVien";
            this.tsmiQLNhanVien.Size = new System.Drawing.Size(178, 22);
            this.tsmiQLNhanVien.Text = "Quản Lý Nhân Viên ";
            this.tsmiQLNhanVien.Click += new System.EventHandler(this.tsmiQLNhanVien_Click);
            // 
            // tsmiMuonTra
            // 
            this.tsmiMuonTra.Name = "tsmiMuonTra";
            this.tsmiMuonTra.Size = new System.Drawing.Size(124, 20);
            this.tsmiMuonTra.Text = "Quản Lý Mượn - Trả";
            this.tsmiMuonTra.Click += new System.EventHandler(this.tsmiMuonTra_Click);
            // 
            // tsmiThongKe
            // 
            this.tsmiThongKe.Name = "tsmiThongKe";
            this.tsmiThongKe.Size = new System.Drawing.Size(125, 20);
            this.tsmiThongKe.Text = "Báo Cáo - Thống Kê";
            this.tsmiThongKe.Click += new System.EventHandler(this.tsmiThongKe_Click);
            // 
            // tsmiQuyDinh
            // 
            this.tsmiQuyDinh.Name = "tsmiQuyDinh";
            this.tsmiQuyDinh.Size = new System.Drawing.Size(115, 20);
            this.tsmiQuyDinh.Text = "Thay đổi quy định";
            this.tsmiQuyDinh.Click += new System.EventHandler(this.tsmiQuyDinh_Click);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(50, 20);
            this.tsmiThoat.Text = "Thoát";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.z6435253236423_0412297fb2f83c99a65e9c50cb15f101;
            this.pictureBox1.Location = new System.Drawing.Point(0, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1030, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "TrangChu";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongTin;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLDocGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLSach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLTheLoai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuonTra;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuyDinh;
    }
}

