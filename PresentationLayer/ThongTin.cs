using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class ThongTin : Form
    {
        public NhanVien nhanVien {  get; set; }
        public ThongTin()
        {
            InitializeComponent();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            if (nhanVien != null)
            {
                txtUser.Text = nhanVien.username;
                txtHoTen.Text = nhanVien.hoTen;
                txtSDT.Text = nhanVien.soDienThoai;
                txtEmail.Text = nhanVien.email;
                txtQueQuan.Text = nhanVien.queQuan;
            }
            else
            {
                txtUser.Text = "ABC";
            }
        }

        private void btnThayMatKhau_Click(object sender, EventArgs e)
        {
            using(ThayMatKhau tmk = new ThayMatKhau())
            {
                tmk.nhanVien = nhanVien;
                if(tmk.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
