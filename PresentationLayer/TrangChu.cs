using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class TrangChu : Form
    {
        private ThongTin tt = null;
        private QuanLyDocGia qlDocGia = null;
        private QuanLySach qlSach = null;
        private QuanLyNhanVien qlNhanVien = null;
        private QuanLyMuonTraSach qlMuonTraSach = null;
        private ThayDoiQuyDinh qlQuyDinh = null;
        private QuanLyTheLoaiSach qlTheLoaiSach = null;
       

        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            this.Show();
            Enabled = false;
            DangNhap dn = new DangNhap();
            DialogResult result = dn.ShowDialog();
            if(result == DialogResult.OK)
            {
                Enabled = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void tsmiThongTin_Click(object sender, EventArgs e)
        {
            if (tt == null || tt.IsDisposed)
            {
                tt = new ThongTin();
                tt.MdiParent = this;
                pictureBox1.Controls.Add(tt);
                tt.Show();
            }
        }

        private void tsmiQLDocGia_Click(object sender, EventArgs e)
        {
            if (qlDocGia == null || qlDocGia.IsDisposed)
            {
                qlDocGia = new QuanLyDocGia();
                qlDocGia.MdiParent = this;
                pictureBox1.Controls.Add(qlDocGia);
                qlDocGia.Show();
            }
        }

        private void tsmiQLSach_Click(object sender, EventArgs e)
        {
            if (qlSach == null || qlSach.IsDisposed)
            {
                qlSach = new QuanLySach();
                qlSach.MdiParent = this;
                pictureBox1.Controls.Add(qlSach);
                qlSach.Show();
            }
        }

        private void tsmiQLNhanVien_Click(object sender, EventArgs e)
        {
            if (qlNhanVien == null || qlNhanVien.IsDisposed)
            {
                qlNhanVien = new QuanLyNhanVien();
                qlNhanVien.MdiParent = this;
                pictureBox1.Controls.Add(qlNhanVien);
                qlNhanVien.Show();
            }
        }



        private void tsmiQLTheLoai_Click(object sender, EventArgs e)
        {
            if (qlTheLoaiSach == null || qlTheLoaiSach.IsDisposed)
            {
                qlTheLoaiSach = new QuanLyTheLoaiSach();
                qlTheLoaiSach.MdiParent = this;
                pictureBox1.Controls.Add(qlTheLoaiSach);
                qlTheLoaiSach.Show();
            }
        }

        private void tsmiMuonTra_Click(object sender, EventArgs e)
        {
            if (qlMuonTraSach == null || qlMuonTraSach.IsDisposed)
            {
                qlMuonTraSach = new QuanLyMuonTraSach();
                qlMuonTraSach.MdiParent = this;
                pictureBox1.Controls.Add(qlMuonTraSach);
                qlMuonTraSach.Show();
            }
        }

        private void tsmiQuyDinh_Click(object sender, EventArgs e)
        {
            if(qlQuyDinh == null || qlQuyDinh.IsDisposed)
            {
                qlQuyDinh = new ThayDoiQuyDinh();
                qlQuyDinh.MdiParent = this;
                pictureBox1.Controls.Add(qlQuyDinh);
                qlQuyDinh.Show();
            }
        }
    }
}
