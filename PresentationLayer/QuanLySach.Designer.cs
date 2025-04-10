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
            this.rbTacGia = new System.Windows.Forms.RadioButton();
            this.rbTen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btHome = new System.Windows.Forms.Button();
            this.btLoadDanhSach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTheLoaiSach = new System.Windows.Forms.ComboBox();
            this.tbSoLuongConLai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGiaBia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNamXB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btReset = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTacGia);
            this.groupBox1.Controls.Add(this.rbTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rbTacGia
            // 
            this.rbTacGia.AutoSize = true;
            this.rbTacGia.Location = new System.Drawing.Point(62, 71);
            this.rbTacGia.Name = "rbTacGia";
            this.rbTacGia.Size = new System.Drawing.Size(184, 35);
            this.rbTacGia.TabIndex = 1;
            this.rbTacGia.TabStop = true;
            this.rbTacGia.Text = "Theo tác giả";
            this.rbTacGia.UseVisualStyleBackColor = true;
            // 
            // rbTen
            // 
            this.rbTen.AutoSize = true;
            this.rbTen.Location = new System.Drawing.Point(62, 30);
            this.rbTen.Name = "rbTen";
            this.rbTen.Size = new System.Drawing.Size(142, 35);
            this.rbTen.TabIndex = 0;
            this.rbTen.TabStop = true;
            this.rbTen.Text = "Theo tên";
            this.rbTen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.tbTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 133);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(560, 73);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(90, 38);
            this.btTimKiem.TabIndex = 11;
            this.btTimKiem.Text = "Tìm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(30, 30);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(609, 37);
            this.tbTimKiem.TabIndex = 10;
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(300, 151);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(168, 47);
            this.btHome.TabIndex = 13;
            this.btHome.Text = "Home ";
            this.btHome.UseVisualStyleBackColor = true;
            // 
            // btLoadDanhSach
            // 
            this.btLoadDanhSach.AutoSize = true;
            this.btLoadDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadDanhSach.Location = new System.Drawing.Point(633, 152);
            this.btLoadDanhSach.Name = "btLoadDanhSach";
            this.btLoadDanhSach.Size = new System.Drawing.Size(192, 47);
            this.btLoadDanhSach.TabIndex = 14;
            this.btLoadDanhSach.Text = "Load danh sách";
            this.btLoadDanhSach.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTheLoaiSach);
            this.groupBox3.Controls.Add(this.tbSoLuongConLai);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbGiaBia);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbNamXB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbSoLuongNhap);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbTacGia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbTenSach);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbMaSach);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1077, 202);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sách";
            // 
            // cbTheLoaiSach
            // 
            this.cbTheLoaiSach.FormattingEnabled = true;
            this.cbTheLoaiSach.Location = new System.Drawing.Point(570, 27);
            this.cbTheLoaiSach.Name = "cbTheLoaiSach";
            this.cbTheLoaiSach.Size = new System.Drawing.Size(243, 38);
            this.cbTheLoaiSach.TabIndex = 21;
            // 
            // tbSoLuongConLai
            // 
            this.tbSoLuongConLai.Location = new System.Drawing.Point(570, 160);
            this.tbSoLuongConLai.Name = "tbSoLuongConLai";
            this.tbSoLuongConLai.Size = new System.Drawing.Size(243, 37);
            this.tbSoLuongConLai.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số lượng còn lại";
            // 
            // tbGiaBia
            // 
            this.tbGiaBia.Location = new System.Drawing.Point(570, 114);
            this.tbGiaBia.Name = "tbGiaBia";
            this.tbGiaBia.Size = new System.Drawing.Size(243, 37);
            this.tbGiaBia.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giá bìa";
            // 
            // tbNamXB
            // 
            this.tbNamXB.Location = new System.Drawing.Point(570, 73);
            this.tbNamXB.Name = "tbNamXB";
            this.tbNamXB.Size = new System.Drawing.Size(243, 37);
            this.tbNamXB.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(462, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Năm XB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(462, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thể loại";
            // 
            // tbSoLuongNhap
            // 
            this.tbSoLuongNhap.Location = new System.Drawing.Point(177, 160);
            this.tbSoLuongNhap.Name = "tbSoLuongNhap";
            this.tbSoLuongNhap.Size = new System.Drawing.Size(243, 37);
            this.tbSoLuongNhap.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng nhập";
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(177, 116);
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.Size = new System.Drawing.Size(243, 37);
            this.tbTacGia.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tác giả";
            // 
            // tbTenSach
            // 
            this.tbTenSach.Location = new System.Drawing.Point(177, 73);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(243, 37);
            this.tbTenSach.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên sách";
            // 
            // tbMaSach
            // 
            this.tbMaSach.Location = new System.Drawing.Point(177, 30);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.ReadOnly = true;
            this.tbMaSach.Size = new System.Drawing.Size(243, 37);
            this.tbMaSach.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã sách";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(31, 412);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(117, 56);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(266, 413);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(117, 56);
            this.btSua.TabIndex = 17;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(501, 413);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(117, 56);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(736, 412);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(117, 56);
            this.btLuu.TabIndex = 19;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(972, 412);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(117, 56);
            this.btReset.TabIndex = 20;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSach);
            this.groupBox4.Location = new System.Drawing.Point(12, 475);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1076, 244);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách Sách";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tenSach,
            this.tacGia,
            this.tenTheLoai,
            this.namXuatBan,
            this.soLuong,
            this.soLuongConLai,
            this.giaBia});
            this.dgvSach.Location = new System.Drawing.Point(21, 36);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(1055, 191);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.Width = 200;
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác giả";
            this.tacGia.MinimumWidth = 6;
            this.tacGia.Name = "tacGia";
            this.tacGia.Width = 150;
            // 
            // tenTheLoai
            // 
            this.tenTheLoai.DataPropertyName = "tenTheLoai";
            this.tenTheLoai.HeaderText = "Thể loại";
            this.tenTheLoai.MinimumWidth = 6;
            this.tenTheLoai.Name = "tenTheLoai";
            this.tenTheLoai.Width = 150;
            // 
            // namXuatBan
            // 
            this.namXuatBan.DataPropertyName = "namXuatBan";
            this.namXuatBan.HeaderText = "Năm xuất bản";
            this.namXuatBan.MinimumWidth = 6;
            this.namXuatBan.Name = "namXuatBan";
            this.namXuatBan.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 125;
            // 
            // soLuongConLai
            // 
            this.soLuongConLai.DataPropertyName = "soLuongConLai";
            this.soLuongConLai.HeaderText = "Số lượng còn lại";
            this.soLuongConLai.MinimumWidth = 6;
            this.soLuongConLai.Name = "soLuongConLai";
            this.soLuongConLai.Width = 125;
            // 
            // giaBia
            // 
            this.giaBia.DataPropertyName = "giaBia";
            this.giaBia.HeaderText = "Giá bìa";
            this.giaBia.MinimumWidth = 6;
            this.giaBia.Name = "giaBia";
            this.giaBia.Width = 200;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 731);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btLoadDanhSach);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
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
        private System.Windows.Forms.RadioButton rbTacGia;
        private System.Windows.Forms.RadioButton rbTen;
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
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBia;
        private System.Windows.Forms.ComboBox cbTheLoaiSach;
    }
}