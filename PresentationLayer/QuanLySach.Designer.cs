namespace PresentationLayer
{
    partial class QuanLySach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTheLoai = new System.Windows.Forms.RadioButton();
            this.rdTacGia = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btHome = new System.Windows.Forms.Button();
            this.btLoadDanhSach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSoLuongConLai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGiaBia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNamXB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTheLoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTheLoai);
            this.groupBox1.Controls.Add(this.rdTacGia);
            this.groupBox1.Controls.Add(this.rdTen);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdTheLoai
            // 
            this.rdTheLoai.AutoSize = true;
            this.rdTheLoai.Location = new System.Drawing.Point(67, 132);
            this.rdTheLoai.Name = "rdTheLoai";
            this.rdTheLoai.Size = new System.Drawing.Size(200, 36);
            this.rdTheLoai.TabIndex = 2;
            this.rdTheLoai.TabStop = true;
            this.rdTheLoai.Text = "Theo thể loại";
            this.rdTheLoai.UseVisualStyleBackColor = true;
            // 
            // rdTacGia
            // 
            this.rdTacGia.AutoSize = true;
            this.rdTacGia.Location = new System.Drawing.Point(67, 90);
            this.rdTacGia.Name = "rdTacGia";
            this.rdTacGia.Size = new System.Drawing.Size(191, 36);
            this.rdTacGia.TabIndex = 1;
            this.rdTacGia.TabStop = true;
            this.rdTacGia.Text = "Theo tác giả";
            this.rdTacGia.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(67, 48);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(147, 36);
            this.rdTen.TabIndex = 0;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Theo tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.tbTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(452, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 167);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(389, 127);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(98, 40);
            this.btTimKiem.TabIndex = 11;
            this.btTimKiem.Text = "Tìm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(24, 58);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(441, 38);
            this.tbTimKiem.TabIndex = 10;
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(264, 217);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(192, 64);
            this.btHome.TabIndex = 13;
            this.btHome.Text = "Home ";
            this.btHome.UseVisualStyleBackColor = true;
            // 
            // btLoadDanhSach
            // 
            this.btLoadDanhSach.AutoSize = true;
            this.btLoadDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadDanhSach.Location = new System.Drawing.Point(519, 219);
            this.btLoadDanhSach.Name = "btLoadDanhSach";
            this.btLoadDanhSach.Size = new System.Drawing.Size(192, 64);
            this.btLoadDanhSach.TabIndex = 14;
            this.btLoadDanhSach.Text = "Load danh sách";
            this.btLoadDanhSach.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSoLuongConLai);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbGiaBia);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbNamXB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbTheLoai);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbSoLuongNhap);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbTacGia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbTenSach);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbMaSach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(933, 303);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sách";
            // 
            // tbSoLuongConLai
            // 
            this.tbSoLuongConLai.Location = new System.Drawing.Point(670, 242);
            this.tbSoLuongConLai.Name = "tbSoLuongConLai";
            this.tbSoLuongConLai.Size = new System.Drawing.Size(263, 38);
            this.tbSoLuongConLai.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số lượng còn lại";
            // 
            // tbGiaBia
            // 
            this.tbGiaBia.Location = new System.Drawing.Point(670, 181);
            this.tbGiaBia.Name = "tbGiaBia";
            this.tbGiaBia.Size = new System.Drawing.Size(263, 38);
            this.tbGiaBia.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giá bìa";
            // 
            // tbNamXB
            // 
            this.tbNamXB.Location = new System.Drawing.Point(670, 108);
            this.tbNamXB.Name = "tbNamXB";
            this.tbNamXB.Size = new System.Drawing.Size(263, 38);
            this.tbNamXB.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(502, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Năm XB";
            // 
            // tbTheLoai
            // 
            this.tbTheLoai.Location = new System.Drawing.Point(670, 37);
            this.tbTheLoai.Name = "tbTheLoai";
            this.tbTheLoai.Size = new System.Drawing.Size(263, 38);
            this.tbTheLoai.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(502, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thể loại";
            // 
            // tbSoLuongNhap
            // 
            this.tbSoLuongNhap.Location = new System.Drawing.Point(193, 233);
            this.tbSoLuongNhap.Name = "tbSoLuongNhap";
            this.tbSoLuongNhap.Size = new System.Drawing.Size(263, 38);
            this.tbSoLuongNhap.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng nhập";
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(193, 172);
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.Size = new System.Drawing.Size(263, 38);
            this.tbTacGia.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tác giả";
            // 
            // tbTenSach
            // 
            this.tbTenSach.Location = new System.Drawing.Point(193, 111);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(263, 38);
            this.tbTenSach.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên sách";
            // 
            // tbMaSach
            // 
            this.tbMaSach.Location = new System.Drawing.Point(193, 46);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.Size = new System.Drawing.Size(263, 38);
            this.tbMaSach.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã sách";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(34, 598);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(127, 58);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(225, 598);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(127, 58);
            this.btSua.TabIndex = 17;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(416, 598);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(127, 58);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(607, 598);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(127, 58);
            this.btLuu.TabIndex = 19;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(798, 598);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(127, 58);
            this.btHuy.TabIndex = 20;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSach);
            this.groupBox4.Location = new System.Drawing.Point(19, 677);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(926, 254);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách Sách";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(23, 37);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(889, 199);
            this.dgvSach.TabIndex = 0;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 956);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btLoadDanhSach);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTheLoai;
        private System.Windows.Forms.RadioButton rdTacGia;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btLoadDanhSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSoLuongConLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGiaBia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNamXB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTheLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSoLuongNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}