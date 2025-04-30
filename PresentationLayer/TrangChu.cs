using BusinessLayer;
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

        private void AddForm(Form form)
        {
            form.TopLevel = false;

            pictureBox1.Controls.Clear();
            pictureBox1.Controls.Add(form);

            form.Show();
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void tsmiThongTin_Click(object sender, EventArgs e)
        {
            ThongTin thongTin = new ThongTin();
            AddForm(thongTin);
        }

        private void tsmiQLDocGia_Click(object sender, EventArgs e)
        {
            QuanLyDocGia qlDocGia = new QuanLyDocGia();
            AddForm(qlDocGia);
        }

        private void tsmiQLSach_Click(object sender, EventArgs e)
        {
            QuanLySach qlSach = new QuanLySach();
            AddForm(qlSach);
        }

        private void tsmiQLNhanVien_Click(object sender, EventArgs e)
        {
            if (UserService.Instance.Acc.VaiTro == 1)
            {
                QuanLyNhanVien qlNhanVien = new QuanLyNhanVien();
                AddForm(qlNhanVien);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này. Vui lòng liên hệ quản lý để được hỗ trợ.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }



        private void tsmiQLTheLoai_Click(object sender, EventArgs e)
        {
            
                QuanLyTheLoaiSach qlTheLoaiSach = new QuanLyTheLoaiSach();
                AddForm(qlTheLoaiSach);
            
        }

        private void tsmiMuonTra_Click(object sender, EventArgs e)
        {
            QuanLyMuonTraSach qlMuonTraSach = new QuanLyMuonTraSach();
            AddForm(qlMuonTraSach);
        }

        private void tsmiQuyDinh_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh qlQuyDinh = new ThayDoiQuyDinh();
            AddForm(qlQuyDinh);
        }
    }
}
