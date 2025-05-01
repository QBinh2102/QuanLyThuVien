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
    public partial class ThayMatKhau : Form
    {
        private NhanVienBL nhanVienBL;
        public NhanVien nhanVien {  get; set; }
        public ThayMatKhau()
        {
            InitializeComponent();
            nhanVienBL = new NhanVienBL();
        }

        private void btnHuyThayMatKhau_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnXacNhanMatKhau_Click(object sender, EventArgs e)
        {
            string id, pass, newPass, confirmNewPass;
            id = nhanVien.id;
            pass = txtMatKhauHienTai.Text.ToString();
            newPass = txtMatKhauMoi.Text.ToString();
            confirmNewPass = txtXacNhanMatKhauMoi.Text.ToString();

            if (pass != nhanVien.password)
            {
                lbThongBaoMK.Text = "Mật khẩu hiện tại không đúng";
            } else
                if (newPass != confirmNewPass)
            {
                lbThongBaoMK.Text = "Mật khẩu không khớp";
            }
            else {
                nhanVienBL.ChangePassword(id, newPass);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
